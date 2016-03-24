Public Class Output
  Private _itms As Object() '' Reference to controls

  Public ReadOnly Property Markup As String
    Get
      Dim strTemp As String = "OUT({"
      For Each item As String In lstValues.Items
        strTemp += item & ","
      Next
      If strTemp.EndsWith(",") Then strTemp = strTemp.Remove(strTemp.Length - 1)
      strTemp += "})"
      Return strTemp
    End Get
  End Property
  Public ReadOnly Property Type As String
    Get
      Return "OUT"
    End Get
  End Property

  Public Sub New(ByVal ReferenceItems As Object())
    InitializeComponent()

    _itms = ReferenceItems
  End Sub

  Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    If lstValues.SelectedIndex = -1 Then MessageBox.Show("You must select a valid value!", "Select Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
    lstValues.Items.RemoveAt(lstValues.SelectedIndex)
  End Sub

  Private Sub Output_ParentChanged(sender As Object, e As EventArgs) Handles Me.ParentChanged
    drpValues.Items.Clear()
    '' UPDATE AVAILABLE VALUES
    For Each item As Object In _itms
      If item.Type = "V" Then
        drpValues.Items.Add("V(" & item.Index.ToString & ")")
      End If
    Next
    For Each item As Object In _itms
      If item.Type = "S" Then
        drpValues.Items.Add("S(" & item.Index.ToString & ")")
      End If
    Next
    For Each item As Object In _itms
      If item.Type = "C" Then
        drpValues.Items.Add("C(" & item.Index.ToString & ")(n)")
      End If
    Next
    For Each item As Object In _itms
      If item.Type = "INPUT" Then
        drpValues.Items.Add("S(100)")
      End If
    Next

    '' UPDATE AVAILABLE COLUMNS
    lstColumns.Items.Clear()
    For Each item As Object In _itms
      If item.Type = "COL" Then
        lstColumns.Items.AddRange(item.Headers)
      End If
    Next

    If lstColumns.Items.Count <= 0 Then MessageBox.Show("You must add column header(s) to the program before adding an output!", "Missing Columns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
  End Sub

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    If drpValues.SelectedIndex >= 0 Then
      lstValues.Items.Add(drpValues.SelectedItem.ToString)
    ElseIf Not String.IsNullOrEmpty(drpValues.Text) Then
      If drpValues.Text.StartsWith("V") Or drpValues.Text.StartsWith("S") Then
        lstValues.Items.Add(drpValues.Text)
      ElseIf drpValues.Text.StartsWith("C") And drpValues.Text.Contains("(n)") Then
        MessageBox.Show("You should provide an index to the query result 'n'!", "n is not a valid index", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      ElseIf drpValues.Text.StartsWith("C") Then
        lstValues.Items.Add(drpValues.Text)
      Else
        lstValues.Items.Add(Chr(34) & drpValues.Text & Chr(34))
      End If
    Else
      MessageBox.Show("You must provide/select a valid variable or value!", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
    drpValues.SelectedIndex = -1
    drpValues.Text = ""
    drpValues.Focus()
  End Sub
End Class
