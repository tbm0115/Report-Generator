<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
    Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report Program")
    Me.tlTools = New System.Windows.Forms.ToolStrip()
    Me.tlSave = New System.Windows.Forms.ToolStripButton()
    Me.tlOpen = New System.Windows.Forms.ToolStripButton()
    Me.tlPreview = New System.Windows.Forms.ToolStripButton()
    Me.tlPreviewCode = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.tlDelete = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.tlColumns = New System.Windows.Forms.ToolStripButton()
    Me.tlNumeric = New System.Windows.Forms.ToolStripButton()
    Me.tlString = New System.Windows.Forms.ToolStripButton()
    Me.tlConnection = New System.Windows.Forms.ToolStripButton()
    Me.tlInput = New System.Windows.Forms.ToolStripButton()
    Me.tlOutput = New System.Windows.Forms.ToolStripButton()
    Me.tlSort = New System.Windows.Forms.ToolStripButton()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuColumns = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuNumerical = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAlphanumerical = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuConnection = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuInput = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuOutput = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAutoSort = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuRemove = New System.Windows.Forms.ToolStripMenuItem()
    Me.PreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuPreviewCode = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuPreviewReport = New System.Windows.Forms.ToolStripMenuItem()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.statStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.spltProgramViewer = New System.Windows.Forms.SplitContainer()
    Me.trvCommands = New System.Windows.Forms.TreeView()
    Me.rtbProgram = New System.Windows.Forms.RichTextBox()
    Me.pnlContainer = New System.Windows.Forms.Panel()
    Me.tlTools.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.StatusStrip1.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    CType(Me.spltProgramViewer, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.spltProgramViewer.Panel1.SuspendLayout()
    Me.spltProgramViewer.Panel2.SuspendLayout()
    Me.spltProgramViewer.SuspendLayout()
    Me.SuspendLayout()
    '
    'tlTools
    '
    Me.tlTools.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.tlTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlSave, Me.tlOpen, Me.tlPreview, Me.tlPreviewCode, Me.ToolStripSeparator1, Me.tlDelete, Me.ToolStripSeparator2, Me.tlColumns, Me.tlNumeric, Me.tlString, Me.tlConnection, Me.tlInput, Me.tlOutput, Me.tlSort})
    Me.tlTools.Location = New System.Drawing.Point(0, 28)
    Me.tlTools.Name = "tlTools"
    Me.tlTools.Size = New System.Drawing.Size(782, 27)
    Me.tlTools.TabIndex = 0
    Me.tlTools.Text = "ToolStrip1"
    '
    'tlSave
    '
    Me.tlSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlSave.Image = CType(resources.GetObject("tlSave.Image"), System.Drawing.Image)
    Me.tlSave.ImageTransparentColor = System.Drawing.Color.Black
    Me.tlSave.Name = "tlSave"
    Me.tlSave.Size = New System.Drawing.Size(24, 24)
    Me.tlSave.Text = "Save"
    '
    'tlOpen
    '
    Me.tlOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlOpen.Image = CType(resources.GetObject("tlOpen.Image"), System.Drawing.Image)
    Me.tlOpen.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tlOpen.Name = "tlOpen"
    Me.tlOpen.Size = New System.Drawing.Size(24, 24)
    Me.tlOpen.Text = "Open"
    Me.tlOpen.Visible = False
    '
    'tlPreview
    '
    Me.tlPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlPreview.Image = CType(resources.GetObject("tlPreview.Image"), System.Drawing.Image)
    Me.tlPreview.ImageTransparentColor = System.Drawing.Color.Black
    Me.tlPreview.Name = "tlPreview"
    Me.tlPreview.Size = New System.Drawing.Size(24, 24)
    Me.tlPreview.Text = "Preview Program"
    '
    'tlPreviewCode
    '
    Me.tlPreviewCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlPreviewCode.Image = CType(resources.GetObject("tlPreviewCode.Image"), System.Drawing.Image)
    Me.tlPreviewCode.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tlPreviewCode.Name = "tlPreviewCode"
    Me.tlPreviewCode.Size = New System.Drawing.Size(24, 24)
    Me.tlPreviewCode.Text = "Preview Code"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
    '
    'tlDelete
    '
    Me.tlDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlDelete.Image = CType(resources.GetObject("tlDelete.Image"), System.Drawing.Image)
    Me.tlDelete.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tlDelete.Name = "tlDelete"
    Me.tlDelete.Size = New System.Drawing.Size(24, 24)
    Me.tlDelete.Text = "Delete Command"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
    '
    'tlColumns
    '
    Me.tlColumns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlColumns.Image = CType(resources.GetObject("tlColumns.Image"), System.Drawing.Image)
    Me.tlColumns.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tlColumns.Name = "tlColumns"
    Me.tlColumns.Size = New System.Drawing.Size(24, 24)
    Me.tlColumns.Text = "Add Column Header(s)"
    '
    'tlNumeric
    '
    Me.tlNumeric.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlNumeric.Image = CType(resources.GetObject("tlNumeric.Image"), System.Drawing.Image)
    Me.tlNumeric.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tlNumeric.Name = "tlNumeric"
    Me.tlNumeric.Size = New System.Drawing.Size(24, 24)
    Me.tlNumeric.Text = "Add Numeric Variable"
    '
    'tlString
    '
    Me.tlString.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlString.Image = CType(resources.GetObject("tlString.Image"), System.Drawing.Image)
    Me.tlString.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tlString.Name = "tlString"
    Me.tlString.Size = New System.Drawing.Size(24, 24)
    Me.tlString.Text = "Add Alphanumeric Variable"
    '
    'tlConnection
    '
    Me.tlConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlConnection.Image = CType(resources.GetObject("tlConnection.Image"), System.Drawing.Image)
    Me.tlConnection.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tlConnection.Name = "tlConnection"
    Me.tlConnection.Size = New System.Drawing.Size(24, 24)
    Me.tlConnection.Text = "Add Connection Variable"
    '
    'tlInput
    '
    Me.tlInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlInput.Image = CType(resources.GetObject("tlInput.Image"), System.Drawing.Image)
    Me.tlInput.ImageTransparentColor = System.Drawing.Color.Black
    Me.tlInput.Name = "tlInput"
    Me.tlInput.Size = New System.Drawing.Size(24, 24)
    Me.tlInput.Text = "Input Command"
    '
    'tlOutput
    '
    Me.tlOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlOutput.Image = CType(resources.GetObject("tlOutput.Image"), System.Drawing.Image)
    Me.tlOutput.ImageTransparentColor = System.Drawing.Color.Black
    Me.tlOutput.Name = "tlOutput"
    Me.tlOutput.Size = New System.Drawing.Size(24, 24)
    Me.tlOutput.Text = "Add Output Command"
    '
    'tlSort
    '
    Me.tlSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tlSort.Image = CType(resources.GetObject("tlSort.Image"), System.Drawing.Image)
    Me.tlSort.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tlSort.Name = "tlSort"
    Me.tlSort.Size = New System.Drawing.Size(24, 24)
    Me.tlSort.Text = "Add Sort"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.ToolsToolStripMenuItem, Me.PreviewToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(782, 28)
    Me.MenuStrip1.TabIndex = 2
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'mnuFile
    '
    Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave})
    Me.mnuFile.Name = "mnuFile"
    Me.mnuFile.Size = New System.Drawing.Size(44, 24)
    Me.mnuFile.Text = "File"
    '
    'mnuSave
    '
    Me.mnuSave.Name = "mnuSave"
    Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
    Me.mnuSave.Size = New System.Drawing.Size(165, 26)
    Me.mnuSave.Text = "Save"
    '
    'ToolsToolStripMenuItem
    '
    Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumns, Me.mnuNumerical, Me.mnuAlphanumerical, Me.mnuConnection, Me.mnuInput, Me.mnuOutput, Me.mnuAutoSort, Me.ToolStripSeparator3, Me.mnuRemove})
    Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
    Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
    Me.ToolsToolStripMenuItem.Text = "Commands"
    '
    'mnuColumns
    '
    Me.mnuColumns.Name = "mnuColumns"
    Me.mnuColumns.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
    Me.mnuColumns.Size = New System.Drawing.Size(293, 26)
    Me.mnuColumns.Text = "Column Header(s)"
    '
    'mnuNumerical
    '
    Me.mnuNumerical.Name = "mnuNumerical"
    Me.mnuNumerical.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
    Me.mnuNumerical.Size = New System.Drawing.Size(293, 26)
    Me.mnuNumerical.Text = "Numerical Variable"
    '
    'mnuAlphanumerical
    '
    Me.mnuAlphanumerical.Name = "mnuAlphanumerical"
    Me.mnuAlphanumerical.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
    Me.mnuAlphanumerical.Size = New System.Drawing.Size(293, 26)
    Me.mnuAlphanumerical.Text = "Alphanumerical Variable"
    '
    'mnuConnection
    '
    Me.mnuConnection.Name = "mnuConnection"
    Me.mnuConnection.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
    Me.mnuConnection.Size = New System.Drawing.Size(293, 26)
    Me.mnuConnection.Text = "Connection Variable"
    '
    'mnuInput
    '
    Me.mnuInput.Name = "mnuInput"
    Me.mnuInput.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
    Me.mnuInput.Size = New System.Drawing.Size(293, 26)
    Me.mnuInput.Text = "Input Command"
    '
    'mnuOutput
    '
    Me.mnuOutput.Name = "mnuOutput"
    Me.mnuOutput.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
    Me.mnuOutput.Size = New System.Drawing.Size(293, 26)
    Me.mnuOutput.Text = "Output Command"
    '
    'mnuAutoSort
    '
    Me.mnuAutoSort.Name = "mnuAutoSort"
    Me.mnuAutoSort.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D6), System.Windows.Forms.Keys)
    Me.mnuAutoSort.Size = New System.Drawing.Size(293, 26)
    Me.mnuAutoSort.Text = "Auto Sort"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(290, 6)
    '
    'mnuRemove
    '
    Me.mnuRemove.Name = "mnuRemove"
    Me.mnuRemove.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
    Me.mnuRemove.Size = New System.Drawing.Size(293, 26)
    Me.mnuRemove.Text = "Remove"
    '
    'PreviewToolStripMenuItem
    '
    Me.PreviewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPreviewCode, Me.mnuPreviewReport})
    Me.PreviewToolStripMenuItem.Name = "PreviewToolStripMenuItem"
    Me.PreviewToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
    Me.PreviewToolStripMenuItem.Text = "Preview"
    '
    'mnuPreviewCode
    '
    Me.mnuPreviewCode.Name = "mnuPreviewCode"
    Me.mnuPreviewCode.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
    Me.mnuPreviewCode.Size = New System.Drawing.Size(214, 26)
    Me.mnuPreviewCode.Text = "Code"
    '
    'mnuPreviewReport
    '
    Me.mnuPreviewReport.Name = "mnuPreviewReport"
    Me.mnuPreviewReport.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
    Me.mnuPreviewReport.Size = New System.Drawing.Size(214, 26)
    Me.mnuPreviewReport.Text = "Run Report..."
    '
    'StatusStrip1
    '
    Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statStatus})
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 530)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(782, 25)
    Me.StatusStrip1.TabIndex = 3
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'statStatus
    '
    Me.statStatus.Name = "statStatus"
    Me.statStatus.Size = New System.Drawing.Size(49, 20)
    Me.statStatus.Text = "Status"
    '
    'SplitContainer1
    '
    Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 55)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.spltProgramViewer)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.pnlContainer)
    Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(3)
    Me.SplitContainer1.Size = New System.Drawing.Size(782, 475)
    Me.SplitContainer1.SplitterDistance = 260
    Me.SplitContainer1.SplitterWidth = 7
    Me.SplitContainer1.TabIndex = 4
    '
    'spltProgramViewer
    '
    Me.spltProgramViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.spltProgramViewer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.spltProgramViewer.Location = New System.Drawing.Point(0, 0)
    Me.spltProgramViewer.Name = "spltProgramViewer"
    Me.spltProgramViewer.Orientation = System.Windows.Forms.Orientation.Horizontal
    '
    'spltProgramViewer.Panel1
    '
    Me.spltProgramViewer.Panel1.Controls.Add(Me.trvCommands)
    '
    'spltProgramViewer.Panel2
    '
    Me.spltProgramViewer.Panel2.Controls.Add(Me.rtbProgram)
    Me.spltProgramViewer.Size = New System.Drawing.Size(260, 475)
    Me.spltProgramViewer.SplitterDistance = 416
    Me.spltProgramViewer.SplitterWidth = 7
    Me.spltProgramViewer.TabIndex = 0
    '
    'trvCommands
    '
    Me.trvCommands.Dock = System.Windows.Forms.DockStyle.Fill
    Me.trvCommands.Location = New System.Drawing.Point(0, 0)
    Me.trvCommands.Name = "trvCommands"
    TreeNode1.Name = "root"
    TreeNode1.Text = "Report Program"
    TreeNode1.ToolTipText = "Report Program"
    Me.trvCommands.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
    Me.trvCommands.Size = New System.Drawing.Size(256, 412)
    Me.trvCommands.TabIndex = 1
    '
    'rtbProgram
    '
    Me.rtbProgram.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rtbProgram.Location = New System.Drawing.Point(0, 0)
    Me.rtbProgram.Name = "rtbProgram"
    Me.rtbProgram.ReadOnly = True
    Me.rtbProgram.Size = New System.Drawing.Size(256, 48)
    Me.rtbProgram.TabIndex = 0
    Me.rtbProgram.Text = ""
    '
    'pnlContainer
    '
    Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlContainer.Location = New System.Drawing.Point(3, 3)
    Me.pnlContainer.Name = "pnlContainer"
    Me.pnlContainer.Size = New System.Drawing.Size(505, 465)
    Me.pnlContainer.TabIndex = 0
    '
    'Editor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(782, 555)
    Me.Controls.Add(Me.SplitContainer1)
    Me.Controls.Add(Me.StatusStrip1)
    Me.Controls.Add(Me.tlTools)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Editor"
    Me.Text = "Editor"
    Me.tlTools.ResumeLayout(False)
    Me.tlTools.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.spltProgramViewer.Panel1.ResumeLayout(False)
    Me.spltProgramViewer.Panel2.ResumeLayout(False)
    CType(Me.spltProgramViewer, System.ComponentModel.ISupportInitialize).EndInit()
    Me.spltProgramViewer.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents tlTools As System.Windows.Forms.ToolStrip
  Friend WithEvents tlSave As System.Windows.Forms.ToolStripButton
  Friend WithEvents tlOpen As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents tlDelete As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents tlColumns As System.Windows.Forms.ToolStripButton
  Friend WithEvents tlNumeric As System.Windows.Forms.ToolStripButton
  Friend WithEvents tlString As System.Windows.Forms.ToolStripButton
  Friend WithEvents tlConnection As System.Windows.Forms.ToolStripButton
  Friend WithEvents tlPreview As System.Windows.Forms.ToolStripButton
  Friend WithEvents tlPreviewCode As System.Windows.Forms.ToolStripButton
  Friend WithEvents tlOutput As System.Windows.Forms.ToolStripButton
  Friend WithEvents tlInput As System.Windows.Forms.ToolStripButton
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuColumns As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuNumerical As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAlphanumerical As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuConnection As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuInput As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuOutput As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuPreviewCode As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuPreviewReport As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuRemove As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents spltProgramViewer As System.Windows.Forms.SplitContainer
  Friend WithEvents trvCommands As System.Windows.Forms.TreeView
  Friend WithEvents rtbProgram As System.Windows.Forms.RichTextBox
  Friend WithEvents pnlContainer As System.Windows.Forms.Panel
  Friend WithEvents statStatus As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tlSort As System.Windows.Forms.ToolStripButton
  Friend WithEvents mnuAutoSort As System.Windows.Forms.ToolStripMenuItem
End Class
