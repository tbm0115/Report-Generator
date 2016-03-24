Public Class Column_Header
  Public ReadOnly Property Markup As String
    Get
      Dim strTemp As String = "COL={"
      For Each item As String In lstHeaders.Items
        strTemp += item & ","
      Next
      If strTemp.EndsWith(",") Then strTemp = strTemp.Remove(strTemp.Length - 1)
      strTemp += "}"
      Return strTemp
    End Get
  End Property
  Public ReadOnly Property Type As String
    Get
      Return "COL"
    End Get
  End Property
  Public ReadOnly Property Headers As String()
    Get
      Dim tmp As String()
      For Each itm As String In lstHeaders.Items
        If Not IsNothing(tmp) Then
          ReDim Preserve tmp(tmp.Length)
        Else
          ReDim tmp(0)
        End If
        tmp(tmp.Length - 1) = itm
      Next
      Return tmp
    End Get
  End Property


  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    If Not String.IsNullOrEmpty(txtHeader.Text) Then
      Select Case drpType.SelectedIndex
        Case 1
          lstHeaders.Items.Add(Chr(34) & txtHeader.Text & Chr(34) & "#") '' Numeric Value
        Case 2
          lstHeaders.Items.Add(Chr(34) & txtHeader.Text & Chr(34) & "D") '' Date Value
        Case Else
          lstHeaders.Items.Add(Chr(34) & txtHeader.Text & Chr(34)) '' Alphanumeric Value
      End Select
      txtHeader.Clear()
      drpType.SelectedIndex = -1
      txtHeader.Focus()
    Else
      MessageBox.Show("You must provide text for the new header!", "Add Text", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    If lstHeaders.SelectedIndex = -1 Then MsgBox("You must select an added header!") : Exit Sub
    lstHeaders.Items.RemoveAt(lstHeaders.SelectedIndex)
  End Sub

  Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
    If lstHeaders.SelectedIndex <= 0 Then MsgBox("You must select a valid added header!") : Exit Sub

    Dim strTemp As String = lstHeaders.SelectedItem.ToString '' Get current value
    Dim index As Integer = lstHeaders.SelectedIndex '' Get current index
    lstHeaders.Items.RemoveAt(index) '' Remove existing item
    lstHeaders.Items.Insert(index - 1, strTemp) '' Add at decreased index
  End Sub

  Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
    If lstHeaders.SelectedIndex = -1 Or lstHeaders.SelectedIndex = lstHeaders.Items.Count - 1 Then MsgBox("You must select a valid added header!") : Exit Sub

    Dim strTemp As String = lstHeaders.SelectedItem.ToString '' Get current value
    Dim index As Integer = lstHeaders.SelectedIndex '' Get current index
    lstHeaders.Items.RemoveAt(index) '' Remove existing item
    lstHeaders.Items.Insert(index + 1, strTemp) '' Add at decreased index
  End Sub

  Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
    If lstHeaders.SelectedIndex = -1 Then MsgBox("You must select a valid added header!") : Exit Sub

    Dim strTemp As String = lstHeaders.SelectedItem.ToString '' Get current value
    Dim typ As String = strTemp.Remove(0, strTemp.LastIndexOf(Chr(34)) + 1) '' Get type reference
    strTemp = strTemp.Remove(strTemp.LastIndexOf(Chr(34))).Remove(0, 1) ''Reformat to human readable
    Dim index As Integer = lstHeaders.SelectedIndex '' Get current index
    strTemp = InputBox("Edit header text:", "Edit Header", strTemp)
    If Not String.IsNullOrEmpty(strTemp) Then
      lstHeaders.Items.RemoveAt(index) '' Remove existing item
      lstHeaders.Items.Insert(index, Chr(34) & strTemp & Chr(34) & typ) '' Add at decreased index
    End If
  End Sub

  Private Sub lstHeaders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHeaders.SelectedIndexChanged
    If lstHeaders.SelectedIndex = 0 Then
      btnUp.Enabled = False
    Else
      btnUp.Enabled = True
    End If
    If lstHeaders.SelectedIndex = lstHeaders.Items.Count - 1 Then
      btnDown.Enabled = False
    Else
      btnDown.Enabled = True
    End If
  End Sub
End Class
