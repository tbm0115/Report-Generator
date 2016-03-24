<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Single_String
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
    Me.lblInputLabel = New System.Windows.Forms.Label()
    Me.txtInput = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.OK_Button.Location = New System.Drawing.Point(0, 340)
    Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(580, 48)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'lblInputLabel
    '
    Me.lblInputLabel.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblInputLabel.Location = New System.Drawing.Point(0, 0)
    Me.lblInputLabel.Name = "lblInputLabel"
    Me.lblInputLabel.Size = New System.Drawing.Size(580, 87)
    Me.lblInputLabel.TabIndex = 1
    Me.lblInputLabel.Text = "{Insert Label}"
    '
    'txtInput
    '
    Me.txtInput.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtInput.Location = New System.Drawing.Point(0, 87)
    Me.txtInput.Multiline = True
    Me.txtInput.Name = "txtInput"
    Me.txtInput.Size = New System.Drawing.Size(580, 253)
    Me.txtInput.TabIndex = 2
    '
    'Single_String
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(580, 388)
    Me.Controls.Add(Me.txtInput)
    Me.Controls.Add(Me.lblInputLabel)
    Me.Controls.Add(Me.OK_Button)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Single_String"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Input Single String"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents lblInputLabel As System.Windows.Forms.Label
  Friend WithEvents txtInput As System.Windows.Forms.TextBox

End Class
