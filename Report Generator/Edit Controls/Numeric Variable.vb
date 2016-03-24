Imports System.Text

Public Class Numeric_Variable
  Public ReadOnly Property Markup As String
    Get
      Dim strTemp As String = "V(" & numIndex.Value.ToString & ")=" & rtbCalculation.Text
      Return strTemp
    End Get
  End Property
  Public ReadOnly Property Type As String
    Get
      Return "V"
    End Get
  End Property
  Public ReadOnly Property Index As Integer
    Get
      Return numIndex.Value
    End Get
  End Property

End Class
