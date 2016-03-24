Imports System.Windows.Forms
Imports System.Text, System.IO

Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports TaskScheduler

Public Class Settings

  Declare Function WNetGetConnection Lib "mpr.dll" Alias "WNetGetConnectionA" (ByVal lpszLocalName As String, _
       ByVal lpszRemoteName As String, ByRef cbRemoteName As Integer) As Integer
  Public Function GetUNCPath(ByVal sFilePath As String) As String
    'reformat FTP location to '\\' format location string as needed. This avoids issues with mapped drives.
    Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
    Dim d As DriveInfo
    Dim DriveType, Ctr As Integer
    Dim DriveLtr, UNCName As String
    Dim StrBldr As New StringBuilder

    If sFilePath.StartsWith("\\") Then Return sFilePath

    UNCName = Space(160)
    GetUNCPath = ""

    DriveLtr = sFilePath.Substring(0, 3)

    For Each d In allDrives
      If d.Name = DriveLtr Then
        DriveType = d.DriveType
        Exit For
      End If
    Next

    If DriveType = 4 Then

      Ctr = WNetGetConnection(sFilePath.Substring(0, 2), UNCName, UNCName.Length)

      If Ctr = 0 Then
        UNCName = UNCName.Trim
        For Ctr = 0 To UNCName.Length - 1
          Dim SingleChar As Char = UNCName(Ctr)
          Dim asciiValue As Integer = Asc(SingleChar)
          If asciiValue > 0 Then
            StrBldr.Append(SingleChar)
          Else
            Exit For
          End If
        Next
        StrBldr.Append(sFilePath.Substring(2))
        GetUNCPath = StrBldr.ToString
      Else
        MsgBox("Cannot Retrieve UNC path" & vbCrLf & "Must Use Mapped Drive of SQLServer", MsgBoxStyle.Critical)
      End If
    Else
      MsgBox("Cannot Use Local Drive" & vbCrLf & "Must Use Mapped Drive of SQLServer", MsgBoxStyle.Critical)
    End If

  End Function
  Private Sub LoadPrintTasks()
    lstPrintTask.Items.Clear()
    If Not IsNothing(My.Settings.PrintTaskPrograms) Then
      For Each prgrm As String In My.Settings.PrintTaskPrograms
        lstPrintTask.Items.Add(prgrm)
      Next
    End If
  End Sub
  Private Sub LoadSaveTasks()
    lstSaveTask.Items.Clear()
    lstTargetFile.Items.Clear()
    If Not IsNothing(My.Settings.SaveTaskPrograms) Then
      For i = 0 To My.Settings.SaveTaskPrograms.Count - 1 Step 1
        lstSaveTask.Items.Add(My.Settings.SaveTaskPrograms(i))
        If Not IsNothing(My.Settings.SaveTaskTargets(i)) Then
          lstTargetFile.Items.Add(My.Settings.SaveTaskTargets(i))
        Else
          lstTargetFile.Items.Add("- Missing Reference -")
        End If
      Next
    End If
  End Sub

  Private Sub btnProgramDirectory_Click(sender As Object, e As EventArgs) Handles btnProgramDirectory.Click
    Dim dg As DialogResult
    Dim opn As New FolderBrowserDialog
    dg = opn.ShowDialog()
    If Not dg = Windows.Forms.DialogResult.Cancel Then
      My.Settings.ProgramDirectory = GetUNCPath(opn.SelectedPath)
    End If
  End Sub

  Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
    My.Settings.Save()
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'MsgBox(My.Application.Info.DirectoryPath & "\" & My.Application.Info.ProductName & ".exe")
    If Not IsNothing(FindTask("Automatic Report Printer")) Then '' Task was found
      statStatus.Text = "Print Task available."
      btnInstallPrintTask.Text = "Re-Install Task"
    Else '' Task wasn't found
      statStatus.Text = "Print Task unavailable."
      btnInstallPrintTask.Text = "Install Task"
    End If
    If Not IsNothing(FindTask("Automatic Report Saver")) Then '' Task was found
      statStatus.Text += " Save Task available."
      btnInstallSaveTask.Text = "Re-Install Task"
    Else '' Task wasn't found
      statStatus.Text += " Save Task unavailable."
      btnInstallSaveTask.Text = "Install Task"
    End If
    LoadPrintTasks()
    LoadSaveTasks()
  End Sub
  Private Function FindTask(ByVal Name As String) As IRegisteredTask
    Dim ts As New TaskScheduler.TaskScheduler
    ts.Connect()
    Dim rootFolder As ITaskFolder = ts.GetFolder("\")
    For Each tsk As IRegisteredTask In rootFolder.GetTasks(1)
      Debug.WriteLine(tsk.Name)
      If tsk.Name = Name Then
        Debug.WriteLine("Found task '" & Name & "'!")
        Return tsk
      End If
    Next
    Return Nothing
  End Function

  Private Sub btnPTProgramBrowse_Click(sender As Object, e As EventArgs) Handles btnPTProgramBrowse.Click
    chooseProgram.ShowDialog()
    txtPTProgram.Text = chooseProgram.FileName
  End Sub
  Private Sub btnSTProgram_Click(sender As Object, e As EventArgs) Handles btnSTProgram.Click
    chooseProgram.ShowDialog()
    txtSTProgram.Text = chooseProgram.FileName
  End Sub
  Private Sub btnSTDestination_Click(sender As Object, e As EventArgs) Handles btnSTDestination.Click
    saveDestination.ShowDialog()
    txtSTDestination.Text = saveDestination.FileName
  End Sub

  Private Sub btnAddPrintTask_Click(sender As Object, e As EventArgs) Handles btnAddPrintTask.Click
    Dim path As String
    If IO.File.Exists(txtPTProgram.Text) Then
      path = My.Application.Info.DirectoryPath & "\Task Programs\" & txtPTProgram.Text.Remove(0, txtPTProgram.Text.LastIndexOf("\") + 1)
      '' Create storage directory if not available already
      If Not IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Task Programs") Then IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Task Programs")
      '' Copy program to local storage
      IO.File.Copy(txtPTProgram.Text, path, True)
      '' Add new file location to settings array
      If IsNothing(My.Settings.PrintTaskPrograms) Then My.Settings.PrintTaskPrograms = New Specialized.StringCollection
      My.Settings.PrintTaskPrograms.Add(path)

      '' Clear inputs
      txtPTProgram.Clear()
    End If

    LoadPrintTasks() '' Refresh view
  End Sub
  Private Sub btnAddSaveTask_Click(sender As Object, e As EventArgs) Handles btnAddSaveTask.Click
    Dim path As String
    If IO.File.Exists(txtSTProgram.Text) And IO.Directory.Exists(txtSTDestination.Text.Remove(txtSTDestination.Text.LastIndexOf("\"))) Then
      path = My.Application.Info.DirectoryPath & "\Task Programs\" & txtSTProgram.Text.Remove(0, txtSTProgram.Text.LastIndexOf("\") + 1)
      '' Create storage directory if not available already
      If Not IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Task Programs") Then IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Task Programs")
      '' Copy program to local storage
      IO.File.Copy(txtSTProgram.Text, path, True)
      '' Add new file location to settings array
      If IsNothing(My.Settings.SaveTaskPrograms) Then
        My.Settings.SaveTaskPrograms = New Specialized.StringCollection
        My.Settings.SaveTaskTargets = New Specialized.StringCollection
      End If
      My.Settings.SaveTaskPrograms.Add(path)

      path = txtSTDestination.Text
      '' Add new file location to settings array
      My.Settings.SaveTaskTargets.Add(path)

      '' Clear inputs
      txtSTProgram.Clear()
      txtSTDestination.Clear()
    End If

    LoadSaveTasks() '' Refresh view
  End Sub

  Private Sub btnInstallPrintTask_Click(sender As Object, e As EventArgs) Handles btnInstallPrintTask.Click
    Dim rt As IRegisteredTask = FindTask("Automatic Report Printer")
    Dim ts As New TaskScheduler.TaskScheduler
    ts.Connect()
    Dim rootFolder As ITaskFolder = ts.GetFolder("\")
    If Not IsNothing(rt) Then '' Delete the task, we'll write a new one
      rootFolder.DeleteTask(rt.Name, 0)
    End If

    '' Write a new task
    Dim td As ITaskDefinition = ts.NewTask(0)
    td.Settings.MultipleInstances = _TASK_INSTANCES_POLICY.TASK_INSTANCES_IGNORE_NEW
    td.RegistrationInfo.Description = "Automatically runs the Report Generator application in AutoPrint mode. The mode iterates through a list of Report Program(s) and automatically prints the report."
    td.Principal.LogonType = _TASK_LOGON_TYPE.TASK_LOGON_GROUP
    td.Settings.Hidden = True
    Dim tsd As New Task_Scheduler(td)
    tsd.ShowDialog()
    If tsd.DialogResult = Windows.Forms.DialogResult.OK Then
      Dim ta As IExecAction = DirectCast(td.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC), IExecAction)
      ta.Path = Chr(34) & My.Application.Info.DirectoryPath & "\" & My.Application.Info.ProductName & ".exe" & Chr(34)
      ta.Arguments = Chr(34) & "PRINTTASK" & Chr(34)
      ta.WorkingDirectory = My.Application.Info.DirectoryPath

      rootFolder.RegisterTaskDefinition("Automatic Report Printer", td, CInt(_TASK_CREATION.TASK_CREATE_OR_UPDATE), Nothing, Nothing, _TASK_LOGON_TYPE.TASK_LOGON_NONE)

      MessageBox.Show("Created Windows Scheduled Task to automatically print the provided Report Program report(s)!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      Exit Sub
    End If
  End Sub
  Private Sub btnInstallSaveTask_Click(sender As Object, e As EventArgs) Handles btnInstallSaveTask.Click
    Dim rt As IRegisteredTask = FindTask("Automatic Report Saver")
    Dim ts As New TaskScheduler.TaskScheduler
    ts.Connect()
    Dim rootFolder As ITaskFolder = ts.GetFolder("\")
    If Not IsNothing(rt) Then '' Delete the task, we'll write a new one
      rootFolder.DeleteTask(rt.Name, 0)
    End If

    '' Write a new task
    Dim td As ITaskDefinition = ts.NewTask(0)
    td.Settings.MultipleInstances = _TASK_INSTANCES_POLICY.TASK_INSTANCES_IGNORE_NEW
    td.RegistrationInfo.Description = "Automatically runs the Report Generator application in AutoSave mode. The mode iterates through a list of Report Program(s) and automatically saves the report."
    td.Principal.LogonType = _TASK_LOGON_TYPE.TASK_LOGON_GROUP
    td.Settings.Hidden = True
    Dim tsd As New Task_Scheduler(td)
    tsd.ShowDialog()
    If tsd.DialogResult = Windows.Forms.DialogResult.OK Then
      Dim ta As IExecAction = DirectCast(td.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC), IExecAction)
      ta.Path = Chr(34) & My.Application.Info.DirectoryPath & "\" & My.Application.Info.ProductName & ".exe" & Chr(34)
      ta.Arguments = Chr(34) & "SAVETASK" & Chr(34)
      ta.WorkingDirectory = My.Application.Info.DirectoryPath

      rootFolder.RegisterTaskDefinition("Automatic Report Saver", td, CInt(_TASK_CREATION.TASK_CREATE_OR_UPDATE), Nothing, Nothing, _TASK_LOGON_TYPE.TASK_LOGON_NONE)

      MessageBox.Show("Created Windows Scheduled Task to automatically save the provided Report Program report(s)!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      Exit Sub
    End If
  End Sub

  Private Sub btnRemovePrint_Click(sender As Object, e As EventArgs) Handles btnRemovePrint.Click
    If lstPrintTask.SelectedIndex >= 0 Then
      My.Settings.PrintTaskPrograms.RemoveAt(lstPrintTask.SelectedIndex)

      LoadPrintTasks() '' Reload programs
    Else
      MessageBox.Show("You must select a program before attempting to remove!", "Invalid Index", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub
  Private Sub btnRemoveSave_Click(sender As Object, e As EventArgs) Handles btnRemoveSave.Click
    If lstSaveTask.SelectedIndex >= 0 Then
      My.Settings.SaveTaskPrograms.RemoveAt(lstSaveTask.SelectedIndex)
      My.Settings.SaveTaskTargets.RemoveAt(lstSaveTask.SelectedIndex)
      LoadSaveTasks() '' Reload programs
    Else
      MessageBox.Show("You must select a program before attempting to remove!", "Invalid Index", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub
End Class
