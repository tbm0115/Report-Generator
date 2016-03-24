<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Date_Range
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
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.grpLabel = New System.Windows.Forms.GroupBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.datEnd = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.datStart = New System.Windows.Forms.DateTimePicker()
    Me.grpLabel.SuspendLayout()
    Me.SuspendLayout()
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.OK_Button.Location = New System.Drawing.Point(0, 105)
    Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(555, 36)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'grpLabel
    '
    Me.grpLabel.Controls.Add(Me.Label2)
    Me.grpLabel.Controls.Add(Me.datEnd)
    Me.grpLabel.Controls.Add(Me.Label1)
    Me.grpLabel.Controls.Add(Me.datStart)
    Me.grpLabel.Dock = System.Windows.Forms.DockStyle.Top
    Me.grpLabel.Location = New System.Drawing.Point(0, 0)
    Me.grpLabel.Name = "grpLabel"
    Me.grpLabel.Size = New System.Drawing.Size(555, 100)
    Me.grpLabel.TabIndex = 4
    Me.grpLabel.TabStop = False
    Me.grpLabel.Text = "{Insert Label}"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(341, 33)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(131, 17)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "End Date (optional)"
    '
    'datEnd
    '
    Me.datEnd.Location = New System.Drawing.Point(281, 53)
    Me.datEnd.Name = "datEnd"
    Me.datEnd.Size = New System.Drawing.Size(263, 22)
    Me.datEnd.TabIndex = 2
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(72, 33)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 17)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Start Date"
    '
    'datStart
    '
    Me.datStart.Location = New System.Drawing.Point(12, 53)
    Me.datStart.Name = "datStart"
    Me.datStart.Size = New System.Drawing.Size(263, 22)
    Me.datStart.TabIndex = 0
    '
    'Date_Range
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(555, 141)
    Me.Controls.Add(Me.grpLabel)
    Me.Controls.Add(Me.OK_Button)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Date_Range"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Date Range"
    Me.grpLabel.ResumeLayout(False)
    Me.grpLabel.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents grpLabel As System.Windows.Forms.GroupBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents datEnd As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents datStart As System.Windows.Forms.DateTimePicker

End Class
