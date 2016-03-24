<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPreview
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPreview))
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
    Me.webPreview = New System.Windows.Forms.WebBrowser()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrint})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(482, 28)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'mnuPrint
    '
    Me.mnuPrint.Name = "mnuPrint"
    Me.mnuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
    Me.mnuPrint.Size = New System.Drawing.Size(51, 24)
    Me.mnuPrint.Text = "&Print"
    '
    'webPreview
    '
    Me.webPreview.Dock = System.Windows.Forms.DockStyle.Fill
    Me.webPreview.Location = New System.Drawing.Point(0, 28)
    Me.webPreview.MinimumSize = New System.Drawing.Size(20, 20)
    Me.webPreview.Name = "webPreview"
    Me.webPreview.Size = New System.Drawing.Size(482, 427)
    Me.webPreview.TabIndex = 1
    '
    'ReportPreview
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(482, 455)
    Me.Controls.Add(Me.webPreview)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "ReportPreview"
    Me.Text = "ReportPreview"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents webPreview As System.Windows.Forms.WebBrowser
End Class
