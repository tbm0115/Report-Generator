<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
    Me.pnlInputs = New System.Windows.Forms.Panel()
    Me.statStrip = New System.Windows.Forms.StatusStrip()
    Me.statProgram = New System.Windows.Forms.ToolStripStatusLabel()
    Me.statCount = New System.Windows.Forms.ToolStripStatusLabel()
    Me.statStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.dgvReport = New System.Windows.Forms.DataGridView()
    Me.mnuPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuStrip1.SuspendLayout()
    Me.statStrip.SuspendLayout()
    CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnuSearch})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(782, 28)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuPrintPreview})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
    Me.FileToolStripMenuItem.Text = "File"
    '
    'mnuSave
    '
    Me.mnuSave.Name = "mnuSave"
    Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
    Me.mnuSave.Size = New System.Drawing.Size(228, 26)
    Me.mnuSave.Text = "Save"
    '
    'mnuSearch
    '
    Me.mnuSearch.Name = "mnuSearch"
    Me.mnuSearch.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
    Me.mnuSearch.Size = New System.Drawing.Size(65, 24)
    Me.mnuSearch.Text = "Search"
    '
    'pnlInputs
    '
    Me.pnlInputs.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlInputs.Location = New System.Drawing.Point(0, 28)
    Me.pnlInputs.Name = "pnlInputs"
    Me.pnlInputs.Size = New System.Drawing.Size(782, 60)
    Me.pnlInputs.TabIndex = 1
    '
    'statStrip
    '
    Me.statStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.statStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statProgram, Me.statCount, Me.statStatus})
    Me.statStrip.Location = New System.Drawing.Point(0, 526)
    Me.statStrip.Name = "statStrip"
    Me.statStrip.Size = New System.Drawing.Size(782, 29)
    Me.statStrip.TabIndex = 2
    Me.statStrip.Text = "StatusStrip1"
    '
    'statProgram
    '
    Me.statProgram.AutoSize = False
    Me.statProgram.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
    Me.statProgram.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
    Me.statProgram.Name = "statProgram"
    Me.statProgram.Size = New System.Drawing.Size(250, 24)
    Me.statProgram.Text = "Program"
    Me.statProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'statCount
    '
    Me.statCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
    Me.statCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
    Me.statCount.Name = "statCount"
    Me.statCount.Size = New System.Drawing.Size(52, 24)
    Me.statCount.Text = "Count"
    '
    'statStatus
    '
    Me.statStatus.AutoSize = False
    Me.statStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
    Me.statStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
    Me.statStatus.Name = "statStatus"
    Me.statStatus.Size = New System.Drawing.Size(517, 24)
    Me.statStatus.Text = "Status"
    Me.statStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'dgvReport
    '
    Me.dgvReport.AllowUserToAddRows = False
    Me.dgvReport.AllowUserToDeleteRows = False
    Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgvReport.Location = New System.Drawing.Point(0, 88)
    Me.dgvReport.Name = "dgvReport"
    Me.dgvReport.RowTemplate.Height = 24
    Me.dgvReport.Size = New System.Drawing.Size(782, 438)
    Me.dgvReport.TabIndex = 3
    '
    'mnuPrintPreview
    '
    Me.mnuPrintPreview.Name = "mnuPrintPreview"
    Me.mnuPrintPreview.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
    Me.mnuPrintPreview.Size = New System.Drawing.Size(228, 26)
    Me.mnuPrintPreview.Text = "Print Preview..."
    '
    'Report
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(782, 555)
    Me.Controls.Add(Me.dgvReport)
    Me.Controls.Add(Me.statStrip)
    Me.Controls.Add(Me.pnlInputs)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Report"
    Me.Text = "Report"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.statStrip.ResumeLayout(False)
    Me.statStrip.PerformLayout()
    CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents pnlInputs As System.Windows.Forms.Panel
  Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents statStrip As System.Windows.Forms.StatusStrip
  Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
  Friend WithEvents statProgram As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents statStatus As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents mnuSearch As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents statCount As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents mnuPrintPreview As System.Windows.Forms.ToolStripMenuItem
End Class
