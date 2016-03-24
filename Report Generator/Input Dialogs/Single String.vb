Imports System.Windows.Forms

Public Class Single_String
  Public ReadOnly Property Input As String
    Get
      Return txtInput.Text
    End Get
  End Property

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If Not String.IsNullOrEmpty(txtInput.Text) Then
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    Else
      MessageBox.Show("You must provide an input value!", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Public Sub New(ByVal Label As String)
    InitializeComponent()

    lblInputLabel.Text = Label
  End Sub

  Private Sub Single_String_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    txtInput.Focus()
  End Sub
End Class
