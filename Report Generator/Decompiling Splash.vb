Public NotInheritable Class Decompiling_Splash
  Private _prgrm As Program
  Public Sub New(ByVal Program As Program)
    InitializeComponent()
    _prgrm = Program
    txtFilePath.Text = _prgrm.FilePath
  End Sub
  Public Sub SetProgress(ByVal Line As String, ByVal CurrentIndex As Integer, ByVal MaxIndex As Integer)
    lblProgress.Text = "Decompiling(" & Line & ")"
    rtbProgress.AppendText(Line & vbLf)
    rtbProgress.ScrollToCaret()
    prgProgress.Minimum = 0
    prgProgress.Maximum = MaxIndex
    prgProgress.Value = CurrentIndex
    Application.DoEvents()
  End Sub

  Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
    _prgrm.Kill()
  End Sub
End Class
