Imports System.Windows.Forms
Imports System.Text.RegularExpressions

Public Class Search_Report
  Private _grd As DataGridView
  Private _tbl As DataTable
  Private _asort As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Hide()
    End Sub
  Public Sub New(ByVal Grid As DataGridView, ByVal SourceTable As DataTable, Optional ByVal AutoSortColumnName As String = "")
    InitializeComponent()
    _asort = AutoSortColumnName
    _grd = Grid '' Setup reference to data grid view
    _tbl = SourceTable
    pnlContainer.Controls.Clear() '' Remove any existing controls
    For i = 0 To _grd.Columns.Count - 1 Step 1
      Dim pnl As New Panel '' Create filter panel
      pnl.Dock = DockStyle.Top
      pnl.Height = 40
      Dim lbl As New Label '' Create label for filter
      lbl.Text = _grd.Columns(i).HeaderText
      lbl.Dock = DockStyle.Left
      lbl.AutoSize = False
      lbl.Width = Me.Width * (1 / 3)
      lbl.AutoEllipsis = True
      lbl.TextAlign = ContentAlignment.MiddleRight
      Dim txt As New TextBox '' Create textbox for filter
      txt.Tag = i
      txt.Dock = DockStyle.Right
      txt.Width = Me.Width * (1 / 2)
      txt.Height = 38
      AddHandler txt.TextChanged, AddressOf TextUpdated '' Bind method for filtering to textbox
      pnl.Controls.Add(lbl)
      pnl.Controls.Add(txt)
      pnlContainer.Controls.Add(pnl) '' Add filter panel to dialog container
      pnlContainer.Controls.SetChildIndex(pnl, 0)
    Next
  End Sub
  Private Sub TextUpdated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    lblError.Text = ""
    Dim dataRows As DataRow()
    Dim bln As Boolean = True
    For Each row As DataRow In _tbl.Rows
      bln = True '' Assume true
      For Each pnl As Panel In pnlContainer.Controls
        Dim txt As TextBox = pnl.Controls(1) '' Get textbox
        If Not String.IsNullOrEmpty(txt.Text) Then
          Try
            If Not New Regex(txt.Text).Match(row.Item(txt.Tag).ToString).Success Then
              bln = False
              Exit For '' No need to continue filtering if this cell is not correct
            End If
          Catch ex As Exception
            '' Might still be typing
            lblError.Text = ex.Message
            Exit Sub '' allow user to create valid expression
          End Try
        End If
      Next
      If bln Then
        If Not IsNothing(dataRows) Then
          ReDim Preserve dataRows(dataRows.Length)
        Else
          ReDim dataRows(0)
        End If
        dataRows(dataRows.Length - 1) = row
      End If
    Next
    'Choose what you wan to do if no row is found. I bind back the oriDataTable.
    If Not IsNothing(dataRows) Then
      _grd.DataSource = Nothing
      _grd.Rows.Clear()
      _grd.DataSource = If(dataRows.Count > 0, dataRows.CopyToDataTable(), _tbl)

    End If
    If Not String.IsNullOrEmpty(_asort) Then
      If Not IsNothing(_grd.Columns.Item(_asort)) Then
        Debug.WriteLine("Try to sort by '" & _asort & "'")
        _grd.Sort(_grd.Columns(_asort), System.ComponentModel.ListSortDirection.Ascending)
      End If
    End If
  End Sub

  Private Sub Search_Report_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    Me.Opacity = 1
  End Sub
  Private Sub Search_Report_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
    Me.Opacity = 0.4
  End Sub

  Private Sub lblInstructions_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click
    Try
      Process.Start("`https://www.google.com/#q=common+regular+expressions+examples`".Replace("`", Chr(34)))
    Catch ex As Exception
      Debug.WriteLine("Couldn't open link: " & ex.Message)
    End Try
  End Sub
End Class
