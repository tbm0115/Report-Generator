Public Class ReportPreview

  Public Sub New(ByVal Markup As String, Optional ByVal Print As Boolean = False, Optional ByVal Save As Boolean = False)
    InitializeComponent()

    webPreview.DocumentText = Markup
    If Print Then
      webPreview.Print()
    End If
  End Sub

  Private Sub mnuPrint_Click(sender As Object, e As EventArgs) Handles mnuPrint.Click
    webPreview.ShowPrintPreviewDialog()
  End Sub
End Class