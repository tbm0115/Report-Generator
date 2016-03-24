Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports TaskScheduler

Public Class Monthly_Trigger
  Private _td As ITaskDefinition
  Public Sub Trigger()
    If drpMonthInterval.SelectedIndex >= 0 Then
      Dim t As IMonthlyTrigger = DirectCast(_td.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_MONTHLY), IMonthlyTrigger)
      t.MonthsOfYear = drpMonthInterval.SelectedIndex + 1
      t.DaysOfMonth = numDayOfMonth.Value
      t.StartBoundary = DateTime.Now.AddMinutes(5).ToString("yyyy-MM-ddThh:mm:ss" & TimeZone.CurrentTimeZone.GetUtcOffset(Now).ToString.Substring(0, 6))
    Else
      Throw New ArgumentException("You must select a repeat cycle for the month!")
    End If
  End Sub

  Public Sub New(ByRef ReferenceTask As ITaskDefinition)
    InitializeComponent()

    _td = ReferenceTask
  End Sub
End Class
