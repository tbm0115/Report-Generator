Imports System.Windows.Forms

Public Class Multiple_String
  Public ReadOnly Property Inputs As List(Of String)
    Get
      Dim arr As String()
      For Each item As String In lstInputs.Items
        If Not IsNothing(arr) Then
          ReDim Preserve arr(arr.Length)
        Else
          ReDim arr(0)
        End If
        arr(arr.Length - 1) = item
      Next
      Return arr.ToList
    End Get
  End Property

  Public Sub New(ByVal Label As String)
    InitializeComponent()

    grpLabel.Text = Label
    txtInput.Focus()
  End Sub

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If lstInputs.Items.Count > 0 Then
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
    Else
      MessageBox.Show("You must add item(s) to the list before continuing!", "Invalid Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    If Not String.IsNullOrEmpty(txtInput.Text) Then
      lstInputs.Items.Add(txtInput.Text)
      txtInput.Clear()
      txtInput.Focus()
    End If
  End Sub

  Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    If Not lstInputs.Items.Count <= 0 Then
      If lstInputs.SelectedIndex >= 0 Then
        lstInputs.Items.RemoveAt(lstInputs.SelectedIndex)
      Else
        MessageBox.Show("You must select a value before attempting to remove it!", "Invalid Index", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
    Else
      MessageBox.Show("You must add item(s) before attempting to remove one!", "Invalid Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub Multiple_String_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    txtInput.Focus()
  End Sub
End Class
