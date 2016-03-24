Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports TaskScheduler

Public Class Weekly_Trigger
  Private _td As ITaskDefinition
  Public Sub Trigger()
    If drpDayOfWeek.SelectedIndex >= 0 Then
      Dim t As IWeeklyTrigger = DirectCast(_td.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_WEEKLY), IWeeklyTrigger)
      t.WeeksInterval = numWeeksInterval.Value
      t.DaysOfWeek = drpDayOfWeek.SelectedIndex + 1
      t.StartBoundary = DateTime.Now.AddMinutes(5).ToString("yyyy-MM-ddThh:mm:ss" & TimeZone.CurrentTimeZone.GetUtcOffset(Now).ToString.Substring(0, 6))
    Else
      Throw New ArgumentException("You must select a day of the week to repeat the task on!")
    End If
  End Sub

  Public Sub New(ByRef ReferenceTask As ITaskDefinition)
    InitializeComponent()

    _td = ReferenceTask
  End Sub
End Class
