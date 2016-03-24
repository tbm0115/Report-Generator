Imports System.Text

Public Class Editor
  Private _node As TreeNode
  Private _itms As New SortedList(Of Integer, Object)
  Private _idx As Integer = 0

  Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
    Static dg As DialogResult
    Static dir As String
    If IsNothing(dg) Or String.IsNullOrEmpty(dir) Then
      dg = MessageBox.Show("Would you like to save this program into the default program directory?", "Save Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      If dg = Windows.Forms.DialogResult.Yes Then
        Do Until Not String.IsNullOrEmpty(dir)
          dir = InputBox("Enter a name for the report:", "Report Name")
        Loop
        dir = My.Settings.ProgramDirectory & "\" & dir & ".rpgr"
      Else
        Dim sav As New SaveFileDialog
        sav.Title = "Choose a location to save the report to:"
        sav.Filter = "Report Program|*.rpgr"
        sav.InitialDirectory = My.Settings.ProgramDirectory
        sav.CheckPathExists = True
        Do Until Not String.IsNullOrEmpty(dir)
          sav.ShowDialog()
          dir = sav.FileName
        Loop
      End If
    End If
    IO.File.WriteAllText(dir, CompileMarkup())
    statStatus.Text = "Saved!"
  End Sub
  Private Sub mnuPreviewReport_Click(sender As Object, e As EventArgs) Handles mnuPreviewReport.Click
    IO.File.WriteAllText("Preview.rpgr", CompileMarkup())
    If IO.File.Exists("Preview.rpgr") Then
      statStatus.Text = "Starting report..."
      Try
        Dim rpt As New Report("Preview.rpgr")
        rpt.ShowDialog()
        rpt.Dispose()
      Catch ex As Exception
        MessageBox.Show("An error occurred while attempting to preview the report:" & vbLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    Else
      statStatus.Text = "Couldn't find the temporary report."
    End If
  End Sub
  Private Sub mnuPreviewCode_Click(sender As Object, e As EventArgs) Handles mnuPreviewCode.Click
    rtbProgram.Text = CompileMarkup()
    statStatus.Text = "Preview compiled."
  End Sub
  Private Sub mnuRemove_Click(sender As Object, e As EventArgs) Handles mnuRemove.Click
    If Not IsNothing(_node) Then
      '' Remove item from array
      _itms.RemoveAt(_itms.IndexOfKey(_node.Tag))
      trvCommands.Nodes.Remove(_node)

      pnlContainer.Controls.Clear() '' Remove any controls in the panel

      statStatus.Text = "Removed command."
    End If
  End Sub
  Private Sub mnuColumns_Click(sender As Object, e As EventArgs) Handles mnuColumns.Click
    AddControlToContainer(New Column_Header, "COL{}")
    statStatus.Text = "Added Column Header command!"
  End Sub
  Private Sub mnuNumerical_Click(sender As Object, e As EventArgs) Handles mnuNumerical.Click
    AddControlToContainer(New Numeric_Variable, "V(n)")
    statStatus.Text = "Added Numeric Variable command!"
  End Sub
  Private Sub mnuAlphanumerical_Click(sender As Object, e As EventArgs) Handles mnuAlphanumerical.Click
    AddControlToContainer(New Alphanumeric_Variable, "S(n)")
    statStatus.Text = "Added Alphanumeric Variable command!"
  End Sub
  Private Sub mnuConnection_Click(sender As Object, e As EventArgs) Handles mnuConnection.Click
    AddControlToContainer(New Connection_Variable, "C(n)(){")
    statStatus.Text = "Added Connection Variable command!"
  End Sub
  Private Sub mnuInput_Click(sender As Object, e As EventArgs) Handles mnuInput.Click
    AddControlToContainer(New Input, "INPUT(){")
    statStatus.Text = "Added Input command!"
  End Sub
  Private Sub mnuOutput_Click(sender As Object, e As EventArgs) Handles mnuOutput.Click
    AddControlToContainer(New Output(_itms.Values.ToArray), "OUT({})")
    statStatus.Text = "Added Output command!"
  End Sub
  Private Sub mnuAutoSort_Click(sender As Object, e As EventArgs) Handles mnuAutoSort.Click
    AddControlToContainer(New AutoSort(_itms.Values.ToArray), "SORT(" & Chr(34) & Chr(34) & ")")
    statStatus.Text = "Added Auto Sort command!"
  End Sub

  Private Sub tlColumns_Click(sender As Object, e As EventArgs) Handles tlColumns.Click
    mnuColumns_Click(mnuColumns, Nothing)
  End Sub
  Private Sub tlNumeric_Click(sender As Object, e As EventArgs) Handles tlNumeric.Click
    mnuNumerical_Click(mnuNumerical, Nothing)
  End Sub
  Private Sub tlString_Click(sender As Object, e As EventArgs) Handles tlString.Click
    mnuAlphanumerical_Click(mnuAlphanumerical, Nothing)
  End Sub
  Private Sub tlConnection_Click(sender As Object, e As EventArgs) Handles tlConnection.Click
    mnuConnection_Click(mnuConnection, Nothing)
  End Sub
  Private Sub tlOutput_Click(sender As Object, e As EventArgs) Handles tlOutput.Click
    mnuOutput_Click(mnuOutput, Nothing)
  End Sub
  Private Sub tlInput_Click(sender As Object, e As EventArgs) Handles tlInput.Click
    mnuInput_Click(mnuInput, Nothing)
  End Sub
  Private Sub tlPreview_Click(sender As Object, e As EventArgs) Handles tlPreview.Click
    mnuPreviewReport_Click(mnuPreviewReport, Nothing)
  End Sub
  Private Sub tlDelete_Click(sender As Object, e As EventArgs) Handles tlDelete.Click
    mnuRemove_Click(mnuRemove, Nothing)
  End Sub
  Private Sub tlPreviewCode_Click(sender As Object, e As EventArgs) Handles tlPreviewCode.Click
    mnuPreviewCode_Click(mnuPreviewCode, Nothing)
  End Sub
  Private Sub tlSave_Click(sender As Object, e As EventArgs) Handles tlSave.Click
    mnuSave_Click(mnuSave, Nothing)
  End Sub
  Private Sub tlSort_Click(sender As Object, e As EventArgs) Handles tlSort.Click
    mnuAutoSort_Click(mnuAutoSort, Nothing)
  End Sub

  Private Sub AddControlToContainer(ByVal Item As Object, ByVal NodeText As String)
    '' Create reference to new Object control, clear the container, and add the new reference
    pnlContainer.Controls.Clear()
    Item.Dock = DockStyle.Fill
    pnlContainer.Controls.Add(Item)

    '' Add node to treeview
    If Not IsNothing(_node) Then
      _node.Nodes.Add(NodeText).Tag = AddObject(Item)
    Else
      trvCommands.Nodes(0).Nodes.Add(NodeText).Tag = AddObject(Item)
    End If
    trvCommands.ExpandAll()
  End Sub
  Private Function AddObject(ByVal Item As Object)
    _idx += 1
    _itms.Add(_idx, Item)
    Return _idx
  End Function
  Private Function CompileMarkup(Optional ByVal Node As TreeNode = Nothing) As String
    Dim out As New StringBuilder
    If IsNothing(Node) Then
      '' Starting from root node
      Node = trvCommands.Nodes(0) '' Select root node
    End If
    For Each nod As TreeNode In Node.Nodes '' Iterate through each node
      Dim itm As Object = _itms(nod.Tag) '' Get control reference
      If Not IsNothing(itm) Then '' Verify we got something
        If _itms(nod.Tag).Type.ToString = "COL" Or _itms(nod.Tag).Type.ToString = "V" Or _itms(nod.Tag).Type.ToString = "S" Or _itms(nod.Tag).Type.ToString = "OUT" Or _itms(nod.Tag).Type.ToString = "SORT" Then
          out.AppendLine(itm.Markup) '' Output command markup
        Else
          If nod.GetNodeCount(False) > 0 Then
            out.AppendLine(itm.Markup)
            out.AppendLine(CompileMarkup(nod)) '' Append recursion
            If Not IsNothing(itm.ClosingMarkup) Then
              out.AppendLine(itm.ClosingMarkup) '' Add closing bracket
            End If
          End If
        End If
      End If
    Next
    Return out.ToString
  End Function

  Private Sub trvCommands_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvCommands.AfterSelect
    If Not trvCommands.SelectedNode.Name = "root" Then
      _node = trvCommands.SelectedNode
      If Not IsNothing(_node) Then
        pnlContainer.Controls.Clear()
        pnlContainer.Controls.Add(_itms(_node.Tag))
        Debug.WriteLine("Selected '" & _itms(_node.Tag).Type & "'")
        If _itms(_node.Tag).Type.ToString = "COL" Then
          tlColumns.Enabled = False
          tlNumeric.Enabled = False
          tlString.Enabled = False
          tlConnection.Enabled = False
          tlInput.Enabled = False
          tlOutput.Enabled = False
          tlSort.Enabled = False
        ElseIf _itms(_node.Tag).Type.ToString = "OUT" Then
          tlColumns.Enabled = False
          tlNumeric.Enabled = False
          tlString.Enabled = False
          tlConnection.Enabled = False
          tlInput.Enabled = False
          tlOutput.Enabled = False
          tlSort.Enabled = False
        ElseIf _itms(_node.Tag).Type.ToString = "S" Then
          tlColumns.Enabled = False
          tlNumeric.Enabled = False
          tlString.Enabled = False
          tlConnection.Enabled = False
          tlInput.Enabled = False
          tlOutput.Enabled = False
          tlSort.Enabled = False
          _node.Text = "S(" & _itms(_node.Tag).Index.ToString & ")"
        ElseIf _itms(_node.Tag).Type.ToString = "V" Then
          tlColumns.Enabled = False
          tlNumeric.Enabled = False
          tlString.Enabled = False
          tlConnection.Enabled = False
          tlInput.Enabled = False
          tlOutput.Enabled = False
          tlSort.Enabled = False
          _node.Text = "V(" & _itms(_node.Tag).Index.ToString & ")"
        ElseIf _itms(_node.Tag).Type.ToString = "INPUT" Then
          tlColumns.Enabled = True
          tlNumeric.Enabled = True
          tlString.Enabled = True
          tlConnection.Enabled = True
          tlInput.Enabled = True
          tlOutput.Enabled = True
          tlSort.Enabled = False
          _node.Text = _itms(_node.Tag).Markup
        ElseIf _itms(_node.Tag).Type.ToString = "C" Then
          tlColumns.Enabled = True
          tlNumeric.Enabled = True
          tlString.Enabled = True
          tlConnection.Enabled = True
          tlInput.Enabled = True
          tlOutput.Enabled = True
          tlSort.Enabled = False
          _node.Text = "C(" & _itms(_node.Tag).Index.ToString & ")"
        ElseIf _itms(_node.Tag).Type.ToString = "SORT" Then
          tlColumns.Enabled = False
          tlNumeric.Enabled = False
          tlString.Enabled = False
          tlConnection.Enabled = False
          tlInput.Enabled = False
          tlOutput.Enabled = False
          tlSort.Enabled = False
          _node.Text = _itms(_node.Tag).Markup
        Else
          tlColumns.Enabled = True
          tlNumeric.Enabled = True
          tlString.Enabled = True
          tlConnection.Enabled = True
          tlInput.Enabled = True
          tlOutput.Enabled = True
          tlSort.Enabled = True
        End If
        statStatus.Text = "Viewing command '" & _itms(_node.Tag).Type.ToString & "'."
      Else
        Debug.WriteLine("Selected node isnothing")
        statStatus.Text = "No valid command selected!"
      End If
    Else
      Debug.WriteLine("Selected 'root'")
      tlColumns.Enabled = True
      tlNumeric.Enabled = True
      tlString.Enabled = True
      tlConnection.Enabled = True
      tlInput.Enabled = True
      tlOutput.Enabled = True
      tlSort.Enabled = True
      _node = Nothing
      statStatus.Text = "Viewing root of program"
    End If
  End Sub

End Class
