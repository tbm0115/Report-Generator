Public Class Input
  Public ReadOnly Property Markup As String
    Get
      Select Case drpType.SelectedIndex
        Case 0 '' Single
          Return "INPUT(" & Chr(34) & "SINGLE" & Chr(34) & "," & Chr(34) & txtLabel.Text & Chr(34) & "){"
        Case 1 '' Multiple
          Return "INPUT(" & Chr(34) & "MULTIPLE" & Chr(34) & "," & Chr(34) & txtLabel.Text & Chr(34) & "){"
        Case 2 '' Date Range
          Return "INPUT(" & Chr(34) & "DATE" & Chr(34) & "," & Chr(34) & txtLabel.Text & Chr(34) & "){"
        Case Else
          Return "//INVALID INPUT TYPE"
      End Select
    End Get
  End Property
  Public ReadOnly Property Type As String
    Get
      Return "INPUT"
    End Get
  End Property
  Public ReadOnly Property ClosingMarkup As String
    Get
      Return "}INPUT"
    End Get
  End Property
End Class
