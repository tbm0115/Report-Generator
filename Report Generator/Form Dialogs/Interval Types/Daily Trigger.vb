Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports TaskScheduler

Public Class Daily_Trigger
  Private _td As ITaskDefinition
  Public Sub Trigger()
    Dim t As IDailyTrigger = DirectCast(_td.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_DAILY), IDailyTrigger)
    t.DaysInterval = numDaysInterval.Value
    t.StartBoundary = DateTime.Now.AddMinutes(5).ToString("yyyy-MM-ddThh:mm:ss" & TimeZone.CurrentTimeZone.GetUtcOffset(Now).ToString.Substring(0, 6))
  End Sub

  Public Sub New(ByRef ReferenceTask As ITaskDefinition)
    InitializeComponent()

    _td = ReferenceTask
  End Sub
End Class
