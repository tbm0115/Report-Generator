<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monthly_Trigger
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
    Me.lblMonthsInterval = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.lblDayOfMonth = New System.Windows.Forms.Label()
    Me.numDayOfMonth = New System.Windows.Forms.NumericUpDown()
    Me.drpMonthInterval = New System.Windows.Forms.ComboBox()
    Me.pnlDaysInterval.SuspendLayout()
    Me.Panel1.SuspendLayout()
    CType(Me.numDayOfMonth, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlDaysInterval
    '
    Me.pnlDaysInterval.Controls.Add(Me.drpMonthInterval)
    Me.pnlDaysInterval.Controls.Add(Me.lblMonthsInterval)
    Me.pnlDaysInterval.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlDaysInterval.Location = New System.Drawing.Point(0, 0)
    Me.pnlDaysInterval.Margin = New System.Windows.Forms.Padding(0)
    Me.pnlDaysInterval.Name = "pnlDaysInterval"
    Me.pnlDaysInterval.Padding = New System.Windows.Forms.Padding(5)
    Me.pnlDaysInterval.Size = New System.Drawing.Size(659, 40)
    Me.pnlDaysInterval.TabIndex = 3
    '
    'lblMonthsInterval
    '
    Me.lblMonthsInterval.Dock = System.Windows.Forms.DockStyle.Left
    Me.lblMonthsInterval.Location = New System.Drawing.Point(5, 5)
    Me.lblMonthsInterval.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
    Me.lblMonthsInterval.Name = "lblMonthsInterval"
    Me.lblMonthsInterval.Size = New System.Drawing.Size(277, 30)
    Me.lblMonthsInterval.TabIndex = 0
    Me.lblMonthsInterval.Text = "Month of the Year:"
    Me.lblMonthsInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.numDayOfMonth)
    Me.Panel1.Controls.Add(Me.lblDayOfMonth)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 40)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
    Me.Panel1.Size = New System.Drawing.Size(659, 39)
    Me.Panel1.TabIndex = 5
    '
    'lblDayOfMonth
    '
    Me.lblDayOfMonth.Dock = System.Windows.Forms.DockStyle.Left
    Me.lblDayOfMonth.Location = New System.Drawing.Point(5, 5)
    Me.lblDayOfMonth.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
    Me.lblDayOfMonth.Name = "lblDayOfMonth"
    Me.lblDayOfMonth.Size = New System.Drawing.Size(277, 29)
    Me.lblDayOfMonth.TabIndex = 0
    Me.lblDayOfMonth.Text = "Day of the Month to repeat on:"
    Me.lblDayOfMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'numDayOfMonth
    '
    Me.numDayOfMonth.Dock = System.Windows.Forms.DockStyle.Fill
    Me.numDayOfMonth.Location = New System.Drawing.Point(282, 5)
    Me.numDayOfMonth.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
    Me.numDayOfMonth.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
    Me.numDayOfMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.numDayOfMonth.Name = "numDayOfMonth"
    Me.numDayOfMonth.Size = New System.Drawing.Size(372, 30)
    Me.numDayOfMonth.TabIndex = 2
    Me.numDayOfMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'drpMonthInterval
    '
    Me.drpMonthInterval.Dock = System.Windows.Forms.DockStyle.Fill
    Me.drpMonthInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.drpMonthInterval.FormattingEnabled = True
    Me.drpMonthInterval.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
    Me.drpMonthInterval.Location = New System.Drawing.Point(282, 5)
    Me.drpMonthInterval.Name = "drpMonthInterval"
    Me.drpMonthInterval.Size = New System.Drawing.Size(372, 33)
    Me.drpMonthInterval.TabIndex = 1
    '
    'Monthly_Trigger
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.pnlDaysInterval)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Monthly_Trigger"
    Me.Size = New System.Drawing.Size(659, 87)
    Me.pnlDaysInterval.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    CType(Me.numDayOfMonth, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlDaysInterval As System.Windows.Forms.Panel
  Friend WithEvents lblMonthsInterval As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents lblDayOfMonth As System.Windows.Forms.Label
  Friend WithEvents numDayOfMonth As System.Windows.Forms.NumericUpDown
  Friend WithEvents drpMonthInterval As System.Windows.Forms.ComboBox

End Class
