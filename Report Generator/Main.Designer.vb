<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
    Me.lstReports = New System.Windows.Forms.ListBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnRunReport = New System.Windows.Forms.Button()
    Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnuSettings})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(484, 28)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.ToolStripSeparator1, Me.mnuOpen, Me.ToolStripSeparator2, Me.mnuQuit})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
    Me.FileToolStripMenuItem.Text = "File"
    '
    'mnuSettings
    '
    Me.mnuSettings.Name = "mnuSettings"
    Me.mnuSettings.Size = New System.Drawing.Size(74, 24)
    Me.mnuSettings.Text = "Settings"
    '
    'lstReports
    '
    Me.lstReports.FormattingEnabled = True
    Me.lstReports.ItemHeight = 16
    Me.lstReports.Location = New System.Drawing.Point(12, 67)
    Me.lstReports.Name = "lstReports"
    Me.lstReports.Size = New System.Drawing.Size(460, 164)
    Me.lstReports.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 47)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(110, 17)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Select a Report:"
    '
    'btnRunReport
    '
    Me.btnRunReport.Location = New System.Drawing.Point(377, 237)
    Me.btnRunReport.Name = "btnRunReport"
    Me.btnRunReport.Size = New System.Drawing.Size(95, 35)
    Me.btnRunReport.TabIndex = 3
    Me.btnRunReport.Text = "Run Report"
    Me.btnRunReport.UseVisualStyleBackColor = True
    '
    'mnuNew
    '
    Me.mnuNew.Name = "mnuNew"
    Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
    Me.mnuNew.Size = New System.Drawing.Size(182, 26)
    Me.mnuNew.Text = "New..."
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
    '
    'mnuQuit
    '
    Me.mnuQuit.Name = "mnuQuit"
    Me.mnuQuit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
    Me.mnuQuit.Size = New System.Drawing.Size(182, 26)
    Me.mnuQuit.Text = "Quit"
    '
    'mnuOpen
    '
    Me.mnuOpen.Name = "mnuOpen"
    Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
    Me.mnuOpen.Size = New System.Drawing.Size(182, 26)
    Me.mnuOpen.Text = "Open..."
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(179, 6)
    '
    'Main
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(484, 295)
    Me.Controls.Add(Me.btnRunReport)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lstReports)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Main"
    Me.Text = "Report Generator"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents lstReports As System.Windows.Forms.ListBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnRunReport As System.Windows.Forms.Button
  Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
