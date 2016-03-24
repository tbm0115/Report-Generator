<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daily_Trigger
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.pnlDaysInterval = New System.Windows.Forms.Panel()
    Me.lblDaysInterval = New System.Windows.Forms.Label()
    Me.numDaysInterval = New System.Windows.Forms.NumericUpDown()
    Me.pnlDaysInterval.SuspendLayout()
    CType(Me.numDaysInterval, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlDaysInterval
    '
    Me.pnlDaysInterval.Controls.Add(Me.numDaysInterval)
    Me.pnlDaysInterval.Controls.Add(Me.lblDaysInterval)
    Me.pnlDaysInterval.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlDaysInterval.Location = New System.Drawing.Point(0, 0)
    Me.pnlDaysInterval.Margin = New System.Windows.Forms.Padding(0)
    Me.pnlDaysInterval.Name = "pnlDaysInterval"
    Me.pnlDaysInterval.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)
    Me.pnlDaysInterval.Size = New System.Drawing.Size(374, 43)
    Me.pnlDaysInterval.TabIndex = 0
    '
    'lblDaysInterval
    '
    Me.lblDaysInterval.Dock = System.Windows.Forms.DockStyle.Left
    Me.lblDaysInterval.Location = New System.Drawing.Point(8, 8)
    Me.lblDaysInterval.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblDaysInterval.Name = "lblDaysInterval"
    Me.lblDaysInterval.Size = New System.Drawing.Size(150, 27)
    Me.lblDaysInterval.TabIndex = 0
    Me.lblDaysInterval.Text = "Repeat Interval:"
    Me.lblDaysInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'numDaysInterval
    '
    Me.numDaysInterval.Dock = System.Windows.Forms.DockStyle.Fill
    Me.numDaysInterval.Location = New System.Drawing.Point(158, 8)
    Me.numDaysInterval.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
    Me.numDaysInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numDaysInterval.Name = "numDaysInterval"
    Me.numDaysInterval.Size = New System.Drawing.Size(208, 30)
    Me.numDaysInterval.TabIndex = 1
    Me.numDaysInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Daily_Trigger
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.pnlDaysInterval)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Daily_Trigger"
    Me.Size = New System.Drawing.Size(374, 48)
    Me.pnlDaysInterval.ResumeLayout(False)
    CType(Me.numDaysInterval, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlDaysInterval As System.Windows.Forms.Panel
  Friend WithEvents lblDaysInterval As System.Windows.Forms.Label
  Friend WithEvents numDaysInterval As System.Windows.Forms.NumericUpDown

End Class
