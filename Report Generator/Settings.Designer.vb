<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.statStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.tabSettings = New System.Windows.Forms.TabControl()
    Me.tabFileFolders = New System.Windows.Forms.TabPage()
    Me.grpProgramDirectory = New System.Windows.Forms.GroupBox()
    Me.btnProgramDirectory = New System.Windows.Forms.Button()
    Me.txtProgramDirectory = New System.Windows.Forms.TextBox()
    Me.tabTasks = New System.Windows.Forms.TabPage()
    Me.grpSaveTask = New System.Windows.Forms.GroupBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.btnSTDestination = New System.Windows.Forms.Button()
    Me.txtSTDestination = New System.Windows.Forms.TextBox()
    Me.btnAddSaveTask = New System.Windows.Forms.Button()
    Me.btnSTProgram = New System.Windows.Forms.Button()
    Me.txtSTProgram = New System.Windows.Forms.TextBox()
    Me.btnInstallSaveTask = New System.Windows.Forms.Button()
    Me.lstTargetFile = New System.Windows.Forms.ListBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.chkAppendDateSaveTask = New System.Windows.Forms.CheckBox()
    Me.lstSaveTask = New System.Windows.Forms.ListBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.grpPrintTask = New System.Windows.Forms.GroupBox()
    Me.btnAddPrintTask = New System.Windows.Forms.Button()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.btnPTProgramBrowse = New System.Windows.Forms.Button()
    Me.txtPTProgram = New System.Windows.Forms.TextBox()
    Me.btnInstallPrintTask = New System.Windows.Forms.Button()
    Me.lstPrintTask = New System.Windows.Forms.ListBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.saveDestination = New System.Windows.Forms.SaveFileDialog()
    Me.chooseProgram = New System.Windows.Forms.OpenFileDialog()
    Me.btnRemovePrint = New System.Windows.Forms.Button()
    Me.btnRemoveSave = New System.Windows.Forms.Button()
    Me.StatusStrip1.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.tabSettings.SuspendLayout()
    Me.tabFileFolders.SuspendLayout()
    Me.grpProgramDirectory.SuspendLayout()
    Me.tabTasks.SuspendLayout()
    Me.grpSaveTask.SuspendLayout()
    Me.grpPrintTask.SuspendLayout()
    Me.SuspendLayout()
    '
    'StatusStrip1
    '
    Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statStatus})
    Me.StatusStrip1.Location = New System.Drawing.Point(5, 358)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(570, 25)
    Me.StatusStrip1.TabIndex = 2
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'statStatus
    '
    Me.statStatus.Name = "statStatus"
    Me.statStatus.Size = New System.Drawing.Size(49, 20)
    Me.statStatus.Text = "Status"
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 313)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(570, 45)
    Me.TableLayoutPanel1.TabIndex = 3
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.Location = New System.Drawing.Point(4, 4)
    Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(277, 37)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.Location = New System.Drawing.Point(289, 4)
    Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(277, 37)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'tabSettings
    '
    Me.tabSettings.Controls.Add(Me.tabFileFolders)
    Me.tabSettings.Controls.Add(Me.tabTasks)
    Me.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tabSettings.Location = New System.Drawing.Point(5, 5)
    Me.tabSettings.Name = "tabSettings"
    Me.tabSettings.SelectedIndex = 0
    Me.tabSettings.Size = New System.Drawing.Size(570, 308)
    Me.tabSettings.TabIndex = 4
    '
    'tabFileFolders
    '
    Me.tabFileFolders.Controls.Add(Me.grpProgramDirectory)
    Me.tabFileFolders.Location = New System.Drawing.Point(4, 25)
    Me.tabFileFolders.Name = "tabFileFolders"
    Me.tabFileFolders.Padding = New System.Windows.Forms.Padding(3)
    Me.tabFileFolders.Size = New System.Drawing.Size(562, 279)
    Me.tabFileFolders.TabIndex = 0
    Me.tabFileFolders.Text = "Files/Folders"
    Me.tabFileFolders.UseVisualStyleBackColor = True
    '
    'grpProgramDirectory
    '
    Me.grpProgramDirectory.Controls.Add(Me.btnProgramDirectory)
    Me.grpProgramDirectory.Controls.Add(Me.txtProgramDirectory)
    Me.grpProgramDirectory.Dock = System.Windows.Forms.DockStyle.Top
    Me.grpProgramDirectory.Location = New System.Drawing.Point(3, 3)
    Me.grpProgramDirectory.Name = "grpProgramDirectory"
    Me.grpProgramDirectory.Size = New System.Drawing.Size(556, 64)
    Me.grpProgramDirectory.TabIndex = 2
    Me.grpProgramDirectory.TabStop = False
    Me.grpProgramDirectory.Text = "Public Program Directory"
    '
    'btnProgramDirectory
    '
    Me.btnProgramDirectory.Location = New System.Drawing.Point(477, 22)
    Me.btnProgramDirectory.Name = "btnProgramDirectory"
    Me.btnProgramDirectory.Size = New System.Drawing.Size(83, 30)
    Me.btnProgramDirectory.TabIndex = 1
    Me.btnProgramDirectory.Text = "Browse..."
    Me.btnProgramDirectory.UseVisualStyleBackColor = True
    '
    'txtProgramDirectory
    '
    Me.txtProgramDirectory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Report_Generator.My.MySettings.Default, "ProgramDirectory", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.txtProgramDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtProgramDirectory.Location = New System.Drawing.Point(13, 22)
    Me.txtProgramDirectory.Name = "txtProgramDirectory"
    Me.txtProgramDirectory.ReadOnly = True
    Me.txtProgramDirectory.Size = New System.Drawing.Size(458, 30)
    Me.txtProgramDirectory.TabIndex = 0
    Me.txtProgramDirectory.Text = Global.Report_Generator.My.MySettings.Default.ProgramDirectory
    '
    'tabTasks
    '
    Me.tabTasks.AutoScroll = True
    Me.tabTasks.Controls.Add(Me.grpSaveTask)
    Me.tabTasks.Controls.Add(Me.grpPrintTask)
    Me.tabTasks.Location = New System.Drawing.Point(4, 25)
    Me.tabTasks.Name = "tabTasks"
    Me.tabTasks.Padding = New System.Windows.Forms.Padding(3)
    Me.tabTasks.Size = New System.Drawing.Size(562, 279)
    Me.tabTasks.TabIndex = 1
    Me.tabTasks.Text = "Automtic Tasks"
    Me.tabTasks.UseVisualStyleBackColor = True
    '
    'grpSaveTask
    '
    Me.grpSaveTask.Controls.Add(Me.btnRemoveSave)
    Me.grpSaveTask.Controls.Add(Me.Label5)
    Me.grpSaveTask.Controls.Add(Me.Label4)
    Me.grpSaveTask.Controls.Add(Me.btnSTDestination)
    Me.grpSaveTask.Controls.Add(Me.txtSTDestination)
    Me.grpSaveTask.Controls.Add(Me.btnAddSaveTask)
    Me.grpSaveTask.Controls.Add(Me.btnSTProgram)
    Me.grpSaveTask.Controls.Add(Me.txtSTProgram)
    Me.grpSaveTask.Controls.Add(Me.btnInstallSaveTask)
    Me.grpSaveTask.Controls.Add(Me.lstTargetFile)
    Me.grpSaveTask.Controls.Add(Me.Label3)
    Me.grpSaveTask.Controls.Add(Me.chkAppendDateSaveTask)
    Me.grpSaveTask.Controls.Add(Me.lstSaveTask)
    Me.grpSaveTask.Controls.Add(Me.Label2)
    Me.grpSaveTask.Dock = System.Windows.Forms.DockStyle.Top
    Me.grpSaveTask.Location = New System.Drawing.Point(3, 259)
    Me.grpSaveTask.Name = "grpSaveTask"
    Me.grpSaveTask.Size = New System.Drawing.Size(535, 351)
    Me.grpSaveTask.TabIndex = 1
    Me.grpSaveTask.TabStop = False
    Me.grpSaveTask.Text = "Save Report Task(s)"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(6, 75)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(223, 17)
    Me.Label5.TabIndex = 14
    Me.Label5.Text = "Select a destination for the report:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(6, 18)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(121, 17)
    Me.Label4.TabIndex = 13
    Me.Label4.Text = "Select a Program:"
    '
    'btnSTDestination
    '
    Me.btnSTDestination.Location = New System.Drawing.Point(458, 94)
    Me.btnSTDestination.Name = "btnSTDestination"
    Me.btnSTDestination.Size = New System.Drawing.Size(75, 23)
    Me.btnSTDestination.TabIndex = 12
    Me.btnSTDestination.Text = "Browse..."
    Me.btnSTDestination.UseVisualStyleBackColor = True
    '
    'txtSTDestination
    '
    Me.txtSTDestination.Location = New System.Drawing.Point(6, 95)
    Me.txtSTDestination.Name = "txtSTDestination"
    Me.txtSTDestination.ReadOnly = True
    Me.txtSTDestination.Size = New System.Drawing.Size(446, 22)
    Me.txtSTDestination.TabIndex = 11
    '
    'btnAddSaveTask
    '
    Me.btnAddSaveTask.Location = New System.Drawing.Point(188, 123)
    Me.btnAddSaveTask.Name = "btnAddSaveTask"
    Me.btnAddSaveTask.Size = New System.Drawing.Size(126, 40)
    Me.btnAddSaveTask.TabIndex = 10
    Me.btnAddSaveTask.Text = "Add Program"
    Me.btnAddSaveTask.UseVisualStyleBackColor = True
    '
    'btnSTProgram
    '
    Me.btnSTProgram.Location = New System.Drawing.Point(458, 37)
    Me.btnSTProgram.Name = "btnSTProgram"
    Me.btnSTProgram.Size = New System.Drawing.Size(75, 23)
    Me.btnSTProgram.TabIndex = 9
    Me.btnSTProgram.Text = "Browse..."
    Me.btnSTProgram.UseVisualStyleBackColor = True
    '
    'txtSTProgram
    '
    Me.txtSTProgram.Location = New System.Drawing.Point(6, 38)
    Me.txtSTProgram.Name = "txtSTProgram"
    Me.txtSTProgram.ReadOnly = True
    Me.txtSTProgram.Size = New System.Drawing.Size(446, 22)
    Me.txtSTProgram.TabIndex = 8
    '
    'btnInstallSaveTask
    '
    Me.btnInstallSaveTask.Location = New System.Drawing.Point(412, 317)
    Me.btnInstallSaveTask.Name = "btnInstallSaveTask"
    Me.btnInstallSaveTask.Size = New System.Drawing.Size(124, 28)
    Me.btnInstallSaveTask.TabIndex = 7
    Me.btnInstallSaveTask.Text = "Install Task(s)"
    Me.btnInstallSaveTask.UseVisualStyleBackColor = True
    '
    'lstTargetFile
    '
    Me.lstTargetFile.FormattingEnabled = True
    Me.lstTargetFile.ItemHeight = 16
    Me.lstTargetFile.Location = New System.Drawing.Point(268, 200)
    Me.lstTargetFile.Name = "lstTargetFile"
    Me.lstTargetFile.Size = New System.Drawing.Size(268, 84)
    Me.lstTargetFile.TabIndex = 6
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(265, 180)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(76, 17)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Target File"
    '
    'chkAppendDateSaveTask
    '
    Me.chkAppendDateSaveTask.AutoSize = True
    Me.chkAppendDateSaveTask.Checked = Global.Report_Generator.My.MySettings.Default.AppendDateSaveTask
    Me.chkAppendDateSaveTask.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Report_Generator.My.MySettings.Default, "AppendDateSaveTask", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
    Me.chkAppendDateSaveTask.Location = New System.Drawing.Point(6, 324)
    Me.chkAppendDateSaveTask.Name = "chkAppendDateSaveTask"
    Me.chkAppendDateSaveTask.Size = New System.Drawing.Size(183, 21)
    Me.chkAppendDateSaveTask.TabIndex = 4
    Me.chkAppendDateSaveTask.Text = "Append date to save file"
    Me.chkAppendDateSaveTask.UseVisualStyleBackColor = True
    '
    'lstSaveTask
    '
    Me.lstSaveTask.FormattingEnabled = True
    Me.lstSaveTask.ItemHeight = 16
    Me.lstSaveTask.Location = New System.Drawing.Point(6, 200)
    Me.lstSaveTask.Name = "lstSaveTask"
    Me.lstSaveTask.Size = New System.Drawing.Size(256, 84)
    Me.lstSaveTask.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(3, 180)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(88, 17)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Program List"
    '
    'grpPrintTask
    '
    Me.grpPrintTask.Controls.Add(Me.btnRemovePrint)
    Me.grpPrintTask.Controls.Add(Me.btnAddPrintTask)
    Me.grpPrintTask.Controls.Add(Me.Label6)
    Me.grpPrintTask.Controls.Add(Me.btnPTProgramBrowse)
    Me.grpPrintTask.Controls.Add(Me.txtPTProgram)
    Me.grpPrintTask.Controls.Add(Me.btnInstallPrintTask)
    Me.grpPrintTask.Controls.Add(Me.lstPrintTask)
    Me.grpPrintTask.Controls.Add(Me.Label1)
    Me.grpPrintTask.Dock = System.Windows.Forms.DockStyle.Top
    Me.grpPrintTask.Location = New System.Drawing.Point(3, 3)
    Me.grpPrintTask.Name = "grpPrintTask"
    Me.grpPrintTask.Size = New System.Drawing.Size(535, 256)
    Me.grpPrintTask.TabIndex = 0
    Me.grpPrintTask.TabStop = False
    Me.grpPrintTask.Text = "Print Report Task(s)"
    '
    'btnAddPrintTask
    '
    Me.btnAddPrintTask.Location = New System.Drawing.Point(188, 66)
    Me.btnAddPrintTask.Name = "btnAddPrintTask"
    Me.btnAddPrintTask.Size = New System.Drawing.Size(126, 40)
    Me.btnAddPrintTask.TabIndex = 17
    Me.btnAddPrintTask.Text = "Add Program"
    Me.btnAddPrintTask.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(6, 18)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(121, 17)
    Me.Label6.TabIndex = 16
    Me.Label6.Text = "Select a Program:"
    '
    'btnPTProgramBrowse
    '
    Me.btnPTProgramBrowse.Location = New System.Drawing.Point(458, 37)
    Me.btnPTProgramBrowse.Name = "btnPTProgramBrowse"
    Me.btnPTProgramBrowse.Size = New System.Drawing.Size(75, 23)
    Me.btnPTProgramBrowse.TabIndex = 15
    Me.btnPTProgramBrowse.Text = "Browse..."
    Me.btnPTProgramBrowse.UseVisualStyleBackColor = True
    '
    'txtPTProgram
    '
    Me.txtPTProgram.Location = New System.Drawing.Point(6, 38)
    Me.txtPTProgram.Name = "txtPTProgram"
    Me.txtPTProgram.ReadOnly = True
    Me.txtPTProgram.Size = New System.Drawing.Size(446, 22)
    Me.txtPTProgram.TabIndex = 14
    '
    'btnInstallPrintTask
    '
    Me.btnInstallPrintTask.Location = New System.Drawing.Point(409, 216)
    Me.btnInstallPrintTask.Name = "btnInstallPrintTask"
    Me.btnInstallPrintTask.Size = New System.Drawing.Size(124, 28)
    Me.btnInstallPrintTask.TabIndex = 8
    Me.btnInstallPrintTask.Text = "Install Task(s)"
    Me.btnInstallPrintTask.UseVisualStyleBackColor = True
    '
    'lstPrintTask
    '
    Me.lstPrintTask.FormattingEnabled = True
    Me.lstPrintTask.ItemHeight = 16
    Me.lstPrintTask.Location = New System.Drawing.Point(3, 126)
    Me.lstPrintTask.Name = "lstPrintTask"
    Me.lstPrintTask.Size = New System.Drawing.Size(530, 84)
    Me.lstPrintTask.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(0, 106)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(88, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Program List"
    '
    'saveDestination
    '
    Me.saveDestination.Filter = "Hyper Text Markup Language|*.html|Comma Separated Values|*.csv"
    Me.saveDestination.Title = "Select a location for the automatic output"
    '
    'chooseProgram
    '
    Me.chooseProgram.FileName = "ReportProgram.rpgr"
    Me.chooseProgram.Filter = "Report Program|*.rpgr"
    Me.chooseProgram.InitialDirectory = Global.Report_Generator.My.MySettings.Default.ProgramDirectory
    Me.chooseProgram.Title = "Select a Report Program"
    '
    'btnRemovePrint
    '
    Me.btnRemovePrint.Location = New System.Drawing.Point(6, 216)
    Me.btnRemovePrint.Name = "btnRemovePrint"
    Me.btnRemovePrint.Size = New System.Drawing.Size(75, 28)
    Me.btnRemovePrint.TabIndex = 18
    Me.btnRemovePrint.Text = "Remove"
    Me.btnRemovePrint.UseVisualStyleBackColor = True
    '
    'btnRemoveSave
    '
    Me.btnRemoveSave.Location = New System.Drawing.Point(9, 290)
    Me.btnRemoveSave.Name = "btnRemoveSave"
    Me.btnRemoveSave.Size = New System.Drawing.Size(83, 26)
    Me.btnRemoveSave.TabIndex = 15
    Me.btnRemoveSave.Text = "Remove"
    Me.btnRemoveSave.UseVisualStyleBackColor = True
    '
    'Settings
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(580, 388)
    Me.Controls.Add(Me.tabSettings)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.StatusStrip1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Settings"
    Me.Padding = New System.Windows.Forms.Padding(5)
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Settings"
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.tabSettings.ResumeLayout(False)
    Me.tabFileFolders.ResumeLayout(False)
    Me.grpProgramDirectory.ResumeLayout(False)
    Me.grpProgramDirectory.PerformLayout()
    Me.tabTasks.ResumeLayout(False)
    Me.grpSaveTask.ResumeLayout(False)
    Me.grpSaveTask.PerformLayout()
    Me.grpPrintTask.ResumeLayout(False)
    Me.grpPrintTask.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents tabSettings As System.Windows.Forms.TabControl
  Friend WithEvents tabFileFolders As System.Windows.Forms.TabPage
  Friend WithEvents grpProgramDirectory As System.Windows.Forms.GroupBox
  Friend WithEvents btnProgramDirectory As System.Windows.Forms.Button
  Friend WithEvents txtProgramDirectory As System.Windows.Forms.TextBox
  Friend WithEvents tabTasks As System.Windows.Forms.TabPage
  Friend WithEvents grpSaveTask As System.Windows.Forms.GroupBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents btnSTDestination As System.Windows.Forms.Button
  Friend WithEvents txtSTDestination As System.Windows.Forms.TextBox
  Friend WithEvents btnAddSaveTask As System.Windows.Forms.Button
  Friend WithEvents btnSTProgram As System.Windows.Forms.Button
  Friend WithEvents txtSTProgram As System.Windows.Forms.TextBox
  Friend WithEvents btnInstallSaveTask As System.Windows.Forms.Button
  Friend WithEvents lstTargetFile As System.Windows.Forms.ListBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents chkAppendDateSaveTask As System.Windows.Forms.CheckBox
  Friend WithEvents lstSaveTask As System.Windows.Forms.ListBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents grpPrintTask As System.Windows.Forms.GroupBox
  Friend WithEvents btnInstallPrintTask As System.Windows.Forms.Button
  Friend WithEvents lstPrintTask As System.Windows.Forms.ListBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents statStatus As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents btnAddPrintTask As System.Windows.Forms.Button
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents btnPTProgramBrowse As System.Windows.Forms.Button
  Friend WithEvents txtPTProgram As System.Windows.Forms.TextBox
  Friend WithEvents chooseProgram As System.Windows.Forms.OpenFileDialog
  Friend WithEvents saveDestination As System.Windows.Forms.SaveFileDialog
  Friend WithEvents btnRemoveSave As System.Windows.Forms.Button
  Friend WithEvents btnRemovePrint As System.Windows.Forms.Button

End Class
