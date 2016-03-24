Public Class Alphanumeric_Variable
  Public ReadOnly Property Markup As String
    Get
      Dim strTemp As String = "S(" & numIndex.Value.ToString & ")=" & rtbCalculation.Text
      Return strTemp
    End Get
  End Property
  Public ReadOnly Property Type As String
    Get
      Return "S"
    End Get
  End Property
  Public ReadOnly Property Index As Integer
    Get
      Return numIndex.Value
    End Get
  End Property
End Class
