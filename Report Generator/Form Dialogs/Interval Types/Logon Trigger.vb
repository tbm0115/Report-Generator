Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports TaskScheduler

Public Class Logon_Trigger
  Private _td As ITaskDefinition
  Public Sub Trigger()
    Dim t As ILogonTrigger = DirectCast(_td.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON), ILogonTrigger)
    t.UserId = My.User.Name
    t.StartBoundary = DateTime.Now.AddMinutes(5).ToString("yyyy-MM-ddThh:mm:ss" & TimeZone.CurrentTimeZone.GetUtcOffset(Now).ToString.Substring(0, 6))
  End Sub

  Public Sub New(ByRef ReferenceTask As ITaskDefinition)
    InitializeComponent()

    _td = ReferenceTask

    rtbNotes.Text = "Task will be run when '" & My.User.Name & "' logs onto this machine."
  End Sub
End Class
