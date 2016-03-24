Public Class AutoSort
  Private _itms As Object() '' Reference to controls
  Public ReadOnly Property Markup As String
    Get
      If Not IsNothing(drpColumns.SelectedItem) Then
        Dim strTemp As String = "SORT(" & Chr(34)
        strTemp += drpColumns.SelectedItem.ToString & Chr(34) & ")"
        Return strTemp
      Else
        Return "SORT(" & Chr(34) & Chr(34) & ")"
      End If
    End Get
  End Property
  Public ReadOnly Property Type As String
    Get
      Return "SORT"
    End Get
  End Property
  Public Sub New(ByVal ReferenceItems As Object())
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    _itms = ReferenceItems

    '' UPDATE AVAILABLE COLUMNS
    drpColumns.Items.Clear()
    For Each item As Object In _itms
      If item.Type = "COL" Then
        For Each hdr As String In item.Headers
          drpColumns.Items.Add(hdr.Remove(hdr.LastIndexOf(Chr(34))).Remove(0, 1))
        Next
      End If
    Next

    If drpColumns.Items.Count <= 0 Then MessageBox.Show("You must add column header(s) to the program before adding an output!", "Missing Columns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
  End Sub

End Class
