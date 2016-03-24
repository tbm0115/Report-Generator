Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports TaskScheduler

Public Class Task_Scheduler
  Private _td As ITaskDefinition

  Public Sub New(ByRef ReferenceTask As ITaskDefinition)
    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    _td = ReferenceTask
  End Sub

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If drpIntervalType.SelectedIndex >= 0 And pnlContainer.Controls.Count = 1 Then
      Dim cntrl As Object = pnlContainer.Controls(0)
      Try
        cntrl.Trigger() '' Run sub to add trigger to reference definition

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
      Catch ex As Exception
        MessageBox.Show("Couldn't create trigger definition!" & vbLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    Else
      MessageBox.Show("You must select an interval type!", "Invalid Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub drpIntervalType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drpIntervalType.SelectedIndexChanged
    pnlContainer.Controls.Clear()
    Select Case drpIntervalType.SelectedItem.ToString
      Case "Daily"
        pnlContainer.Controls.Add(New Daily_Trigger(_td))
      Case "Weekly"
        pnlContainer.Controls.Add(New Weekly_Trigger(_td))
      Case "Monthly"
        pnlContainer.Controls.Add(New Monthly_Trigger(_td))
      Case "Logon"
        pnlContainer.Controls.Add(New Logon_Trigger(_td))
    End Select
  End Sub
End Class
