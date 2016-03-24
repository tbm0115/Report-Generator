Public Class Main

  Private Sub btnRunReport_Click(sender As Object, e As EventArgs) Handles btnRunReport.Click
    If lstReports.SelectedIndex >= 0 Then
      Try
        Dim rpt As New Report(My.Settings.ProgramDirectory & "\" & lstReports.SelectedItem.ToString & ".rpgr")
        rpt.ShowDialog()
        rpt.Dispose()
      Catch ex As Exception
        MessageBox.Show("An error occurred while attempting to run report:" & vbLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub

  Private Sub mnuSettings_Click(sender As Object, e As EventArgs) Handles mnuSettings.Click
    Dim settings As New Settings
    settings.ShowDialog()
  End Sub

  Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
    My.Application.SaveMySettingsOnExit = True

    If String.IsNullOrEmpty(My.Settings.ProgramDirectory) Or Not IO.Directory.Exists(My.Settings.ProgramDirectory) Then
      MessageBox.Show("It appears that the default report program directory is not set. Please set the Program Directory now...", "Initialized", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Dim dg As DialogResult
      Dim settings As New Settings
      Do Until dg = Windows.Forms.DialogResult.OK
        dg = settings.ShowDialog()
      Loop
    End If

    For Each fil As String In IO.Directory.GetFiles(My.Settings.ProgramDirectory, "*.rpgr")
      lstReports.Items.Add(fil.Remove(fil.LastIndexOf(".")).Remove(0, fil.LastIndexOf("\") + 1))
    Next

    If Not IsNothing(My.Application.CommandLineArgs) Then
      If My.Application.CommandLineArgs.Count > 0 Then
        For Each argument In My.Application.CommandLineArgs
          If argument = "PRINTTASK" Then
            Try
              If Not IsNothing(My.Settings.PrintTaskPrograms) Then
                For Each prgrm As String In My.Settings.PrintTaskPrograms
                  Dim rpt As New Report(prgrm, True)
                  rpt.Show()
                  rpt.Dispose()
                Next
              End If
            Catch ex As Exception
              MessageBox.Show("An error occurred while attempting to begin AutoPrint Task:" & vbLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Me.Close()
          ElseIf argument = "SAVETASK" Then
            Try
              If Not IsNothing(My.Settings.SaveTaskPrograms) And Not IsNothing(My.Settings.SaveTaskTargets) Then
                For i = 0 To My.Settings.SaveTaskPrograms.Count - 1 Step 1
                  Dim prgrm, out As String
                  prgrm = My.Settings.SaveTaskPrograms(i)
                  out = My.Settings.SaveTaskTargets(i)
                  If My.Settings.AppendDateSaveTask Then
                    out = out.Remove(out.LastIndexOf(".")) & "_" & DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss tt") & "." & out.Remove(0, out.LastIndexOf(".") + 1)
                  End If
                  Dim rpt As New Report(prgrm, False, out)
                  rpt.Show()
                  rpt.Dispose()
                Next
              End If
            Catch ex As Exception
              MessageBox.Show("An error occurred while attempting to begin AutoSave Task:" & vbLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Me.Close()
          End If
          MsgBox("Arguments: " & argument)
        Next
      End If
    End If

    If Not IsNothing(AppDomain.CurrentDomain.SetupInformation.ActivationArguments) Then
      If Not IsNothing(AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData) Then
        If Not IsNothing(AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData(0)) Then
          If AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData(0).Contains("file:") Then
            If lstReports.Items.Count > 0 Then
              For Each item As String In lstReports.Items
                If AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData(0).Replace("file:", "").Replace("%20", " ").Replace("/", "\") Like "*" & item & "*" Then
                  lstReports.SelectedIndex = lstReports.FindStringExact(item)
                  Application.DoEvents()
                  Try
                    Dim rpt As New Report(My.Settings.ProgramDirectory & "\" & lstReports.SelectedItem.ToString & ".rpgr")
                    rpt.ShowDialog()
                    rpt.Dispose()
                  Catch ex As Exception
                    MessageBox.Show("An error occurred while attempting to run report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                  End Try
                End If
              Next
            End If
          End If
        End If
      End If
    End If
  End Sub

  Private Sub mnuQuit_Click(sender As Object, e As EventArgs) Handles mnuQuit.Click
    Me.Close()
  End Sub

  Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
    Dim opn As New OpenFileDialog
    opn.Title = "Select a report to run"
    opn.Filter = "Report Program|*.rpgr"
    opn.InitialDirectory = My.Settings.ProgramDirectory
    opn.CheckFileExists = True
    opn.CheckPathExists = True
    opn.ShowDialog()
    If Not String.IsNullOrEmpty(opn.FileName) Then
      If IO.File.Exists(opn.FileName) Then
        Try
          Dim rpt As New Report(opn.FileName)
          rpt.ShowDialog()
          rpt.Dispose()
        Catch ex As Exception
          MessageBox.Show("An error occurred while attempting to run report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      End If
    End If
  End Sub

  Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
    Dim edit As New Editor
    edit.ShowDialog()
    edit.Dispose()
  End Sub
End Class
