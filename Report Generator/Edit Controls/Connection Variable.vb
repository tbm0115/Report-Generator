Public Class Connection_Variable
  Public ReadOnly Property Markup As String
    Get
      Dim strTemp As String = "C(" & numIndex.Value.ToString & ")(" & Chr(34) & rtbConnectionString.Text & Chr(34) & "," & _
       Chr(34) & rtbCommand.Text & Chr(34) & "){"
      Return strTemp
    End Get
  End Property
  Public ReadOnly Property Type As String
    Get
      Return "C"
    End Get
  End Property
  Public ReadOnly Property Index As Integer
    Get
      Return numIndex.Value
    End Get
  End Property
  Public ReadOnly Property ClosingMarkup As String
    Get
      Return "}C(" & numIndex.Value.ToString & ")"
    End Get
  End Property

  Private Sub rtbCommand_TextChanged(sender As Object, e As EventArgs) Handles rtbCommand.TextChanged
    If rtbCommand.Text.Contains(Chr(34)) Then rtbCommand.Text = rtbCommand.Text.Replace(Chr(34), "'")
    If rtbCommand.Text.Contains(vbLf) Then rtbCommand.Text = rtbCommand.Text.Replace(vbLf, " ")
    If rtbCommand.Text.Contains(vbCr) Then rtbCommand.Text = rtbCommand.Text.Replace(vbCr, " ")
    If rtbCommand.Text.Contains(vbCrLf) Then rtbCommand.Text = rtbCommand.Text.Replace(vbCrLf, " ")
  End Sub
End Class
