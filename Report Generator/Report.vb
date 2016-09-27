Imports HTML, HTML.HTMLWriter, HTML.HTMLWriter.HTMLTable
Imports System.Text

Public Class Report
  Private prgrm As Program
  Private search As Search_Report

  Public Sub New(ByVal FilePath As String, Optional ByVal AutoPrint As Boolean = False, Optional ByVal AutoSave As String = "")
    InitializeComponent()
    dgvReport.Rows.Clear() '' Clear data
    dgvReport.Columns.Clear() '' Clear data
    Cursor = Cursors.WaitCursor '' Set Wait cursor
    statProgram.Text = FilePath '' Set status bar
    statProgram.IsLink = True

    If IO.File.Exists(FilePath) Then
      statStatus.Text = "Decompiling program..."
      prgrm = New Program(FilePath) '' Initialize program
      If prgrm.Run Then '' Run program
        dgvReport.DataSource = prgrm.Source
        If Not IsNothing(prgrm.Source) Then
          dgvReport.DataSource = prgrm.Data
          Debug.WriteLine("Found table '" & prgrm.Data.TableName & "' with '" & prgrm.Data.Rows.Count.ToString & "' records")
          statStatus.Text = "Data found, added to grid view."
          statCount.Text = dgvReport.Rows.Count.ToString & " records"
          search = New Search_Report(dgvReport, prgrm.Data, prgrm.AutoSortColumn)
          If AutoPrint Then
            Dim prev As New ReportPreview(Output_HTML(), True)
            prev.Show()
          End If
          If Not String.IsNullOrEmpty(AutoSave) Then
            If AutoSave.IndexOf("html", System.StringComparison.OrdinalIgnoreCase) >= 0 Or AutoSave.IndexOf("htm", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
              IO.File.WriteAllText(AutoSave, Output_HTML)
            ElseIf AutoSave.ToLower.EndsWith("csv") Then
              IO.File.WriteAllText(AutoSave, Output_CSV)
            End If
          End If

          If Not String.IsNullOrEmpty(prgrm.AutoSortColumn) Then
            If Not IsNothing(dgvReport.Columns.Item(prgrm.AutoSortColumn)) Then
              Debug.WriteLine("Try to sort by '" & prgrm.AutoSortColumn & "'")
              dgvReport.Sort(dgvReport.Columns(prgrm.AutoSortColumn), System.ComponentModel.ListSortDirection.Ascending)
            End If
          End If
        Else
          statStatus.Text = "No data was found!"
          Debug.WriteLine("No tables found...")
        End If
      Else
        statStatus.Text = "Report program failed due to some sort of error."
        MessageBox.Show("Something went wrong...", "Nope!", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    Else
      statStatus.Text = "Provided file doesn't exist..."
    End If
    Cursor = Cursors.Default
  End Sub
  Private Sub statProgram_Click(sender As Object, e As EventArgs) Handles statProgram.Click
    If Not String.IsNullOrEmpty(statProgram.Text) Then
      If IO.File.Exists(statProgram.Text) Then
        Try
          Dim proc As New Process
          proc.StartInfo.FileName = "notepad.exe"
          proc.StartInfo.Arguments = Chr(34) & statProgram.Text & Chr(34)
          proc.Start()
          statStatus.Text = "Opening program in Notepad"
        Catch ex As Exception
          MessageBox.Show("Couldn't open report program in notepad...." & vbLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
          statStatus.Text = "Error opening program in Notepad"
        End Try
      End If
    End If
  End Sub

  Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
    Dim out, ext As String
    Dim sav As New SaveFileDialog
    sav.Title = "Choose a location to save the report..."
    sav.Filter = "Web Page|*.html;*.htm|Comma Seperated Values|*.csv"
    sav.CheckPathExists = True
    sav.CheckFileExists = False
    sav.OverwritePrompt = True
    sav.ShowDialog()
    If String.IsNullOrEmpty(sav.FileName) Then Exit Sub
    If IO.Directory.Exists(sav.FileName.Remove(sav.FileName.LastIndexOf("\"))) Then
      Select Case sav.FilterIndex
        Case 1 ''HTML
          out = Output_HTML()
        Case 2 ''CSV
          out = Output_CSV()
        Case Else
          out = "Oops, undetermined file format!"
      End Select
      If Not String.IsNullOrEmpty(out) Then
        IO.File.WriteAllText(sav.FileName, out)
        Try
          Process.Start(sav.FileName)
          statStatus.Text = "Saved report to '" & sav.FileName & "', now opening..."
        Catch ex As Exception
          MessageBox.Show("An error occurred while attempting to open the saved report..." & vbLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
          statStatus.Text = "Report saved, but failed to open..."
        End Try
      Else
        MessageBox.Show("Couldn't determine the selected file type...", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error)
        statStatus.Text = "Couldn't determine the selected file type..."
      End If
    End If
  End Sub
  Private Function Output_CSV() As String
    Dim out As New StringBuilder
    If Not IsNothing(prgrm.Source) And Not IsNothing(prgrm.Data) Then
      For Each col As DataGridViewColumn In dgvReport.Columns
        out.Append("`" & col.HeaderText & "`,")
      Next
      If out.ToString.EndsWith(",") Then out = out.Remove(out.Length - 1, 1) '' Remove trailing comma
      For Each row As DataGridViewRow In dgvReport.Rows
        out.Append(vbCrLf) '' New line for data
        For i = 0 To prgrm.Data.Columns.Count - 1 Step 1
          If prgrm.Data.Columns(i).DataType.ToString = "System.DateTime" Then
            out.Append("`" & DateTime.Parse(row.Cells(i).Value.ToString).ToShortDateString & "`,")
          Else
            out.Append("`" & row.Cells(i).Value.ToString & "`,")
          End If
          'out.Append("`" & row.Cells(i).Value.ToString & "`,")
        Next
        If out.ToString.EndsWith(",") Then out = out.Remove(out.Length - 1, 1) '' Remove trailing comma
      Next
      If out.ToString.Contains("`") Then out = out.Replace("`", Chr(34)) '' Replace placeholder for double quotes
    End If
    Return out.ToString()
  End Function
  Private Function Output_HTML() As String
    Dim report As New HTMLWriter
    report += "<meta http-equiv='X-UA-Compatible' content='IE=edge'>"
    report.AddBootstrapReference()
    report += New HTMLHeader(prgrm.FilePath.Remove(prgrm.FilePath.LastIndexOf(".")).Remove(0, prgrm.FilePath.LastIndexOf("\") + 1), HTMLHeader.HeaderSize.H1)
    Dim tbl As New HTMLTable(New AttributeList({"class"}, {"table table-striped table-responsive table-hover"}))
    Dim th As New HTMLTableRow(New AttributeList({"background-color"}, {"rgb(128,128,128)"}, True))
    Dim tr As HTMLTableRow
    If Not IsNothing(prgrm.Source) And Not IsNothing(prgrm.Data) Then
      For Each col As DataGridViewColumn In dgvReport.Columns
        th += New HTMLTableCell(col.HeaderText, HTMLTableCell.CellType.Header)
      Next
      tbl += th
      For Each row As DataGridViewRow In dgvReport.Rows
        tr = New HTMLTableRow()
        For i = 0 To prgrm.Data.Columns.Count - 1 Step 1
          If prgrm.Data.Columns(i).DataType.ToString = "System.DateTime" Then
            tr += New HTMLTableCell(DateTime.Parse(row.Cells(i).Value.ToString).ToShortDateString, HTMLTableCell.CellType.Row)
          Else
            tr += New HTMLTableCell(row.Cells(i).Value.ToString, HTMLTableCell.CellType.Row)
          End If
        Next
        tbl += tr
      Next
      report += tbl
    End If
    Dim out As String = report.HTMLMarkup
    report.Dispose()
    Return out
  End Function

  Private Sub mnuSearch_Click(sender As Object, e As EventArgs) Handles mnuSearch.Click
    If Not IsNothing(search) Then
      If search.IsDisposed Then
        search = New Search_Report(dgvReport, prgrm.Data, prgrm.AutoSortColumn)
      End If
      search.Show()
    Else
      search = New Search_Report(dgvReport, prgrm.Data, prgrm.AutoSortColumn)
    End If
  End Sub

  Private Sub dgvReport_DataSourceChanged(sender As Object, e As EventArgs) Handles dgvReport.DataSourceChanged
    statCount.Text = dgvReport.Rows.Count.ToString & " records"
  End Sub

  Private Sub mnuPrintPreview_Click(sender As Object, e As EventArgs) Handles mnuPrintPreview.Click
    Dim prev As New ReportPreview(Output_HTML())
    prev.ShowDialog()
    prev.Dispose()
  End Sub
End Class