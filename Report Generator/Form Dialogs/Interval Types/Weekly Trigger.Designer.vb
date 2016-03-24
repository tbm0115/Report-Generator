<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Weekly_Trigger
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
    Me.numWeeksInterval = New System.Windows.Forms.NumericUpDown()
    Me.lblWeeksInterval = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.lblDayOfWeek = New System.Windows.Forms.Label()
    Me.drpDayOfWeek = New System.Windows.Forms.ComboBox()
    Me.pnlDaysInterval.SuspendLayout()
    CType(Me.numWeeksInterval, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlDaysInterval
    '
    Me.pnlDaysInterval.Controls.Add(Me.numWeeksInterval)
    Me.pnlDaysInterval.Controls.Add(Me.lblWeeksInterval)
    Me.pnlDaysInterval.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlDaysInterval.Location = New System.Drawing.Point(8, 8)
    Me.pnlDaysInterval.Margin = New System.Windows.Forms.Padding(0)
    Me.pnlDaysInterval.Name = "pnlDaysInterval"
    Me.pnlDaysInterval.Padding = New System.Windows.Forms.Padding(12)
    Me.pnlDaysInterval.Size = New System.Drawing.Size(529, 49)
    Me.pnlDaysInterval.TabIndex = 1
    '
    'numWeeksInterval
    '
    Me.numWeeksInterval.Dock = System.Windows.Forms.DockStyle.Fill
    Me.numWeeksInterval.Location = New System.Drawing.Point(286, 12)
    Me.numWeeksInterval.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.numWeeksInterval.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
    Me.numWeeksInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numWeeksInterval.Name = "numWeeksInterval"
    Me.numWeeksInterval.Size = New System.Drawing.Size(231, 30)
    Me.numWeeksInterval.TabIndex = 1
    Me.numWeeksInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblWeeksInterval
    '
    Me.lblWeeksInterval.Dock = System.Windows.Forms.DockStyle.Left
    Me.lblWeeksInterval.Location = New System.Drawing.Point(12, 12)
    Me.lblWeeksInterval.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
    Me.lblWeeksInterval.Name = "lblWeeksInterval"
    Me.lblWeeksInterval.Size = New System.Drawing.Size(274, 25)
    Me.lblWeeksInterval.TabIndex = 0
    Me.lblWeeksInterval.Text = "Repeat Interval:"
    Me.lblWeeksInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.drpDayOfWeek)
    Me.Panel1.Controls.Add(Me.lblDayOfWeek)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(8, 57)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(12)
    Me.Panel1.Size = New System.Drawing.Size(529, 49)
    Me.Panel1.TabIndex = 2
    '
    'lblDayOfWeek
    '
    Me.lblDayOfWeek.Dock = System.Windows.Forms.DockStyle.Left
    Me.lblDayOfWeek.Location = New System.Drawing.Point(12, 12)
    Me.lblDayOfWeek.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
    Me.lblDayOfWeek.Name = "lblDayOfWeek"
    Me.lblDayOfWeek.Size = New System.Drawing.Size(274, 25)
    Me.lblDayOfWeek.TabIndex = 0
    Me.lblDayOfWeek.Text = "Day of the Week to repeat on:"
    Me.lblDayOfWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'drpDayOfWeek
    '
    Me.drpDayOfWeek.Dock = System.Windows.Forms.DockStyle.Fill
    Me.drpDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.drpDayOfWeek.FormattingEnabled = True
    Me.drpDayOfWeek.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
    Me.drpDayOfWeek.Location = New System.Drawing.Point(286, 12)
    Me.drpDayOfWeek.Name = "drpDayOfWeek"
    Me.drpDayOfWeek.Size = New System.Drawing.Size(231, 33)
    Me.drpDayOfWeek.TabIndex = 1
    '
    'Weekly_Trigger
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.pnlDaysInterval)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Weekly_Trigger"
    Me.Padding = New System.Windows.Forms.Padding(8)
    Me.Size = New System.Drawing.Size(545, 111)
    Me.pnlDaysInterval.ResumeLayout(False)
    CType(Me.numWeeksInterval, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlDaysInterval As System.Windows.Forms.Panel
  Friend WithEvents numWeeksInterval As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblWeeksInterval As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents lblDayOfWeek As System.Windows.Forms.Label
  Friend WithEvents drpDayOfWeek As System.Windows.Forms.ComboBox

End Class
