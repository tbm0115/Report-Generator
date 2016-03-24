<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multiple_String
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
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.txtInput = New System.Windows.Forms.TextBox()
    Me.lstInputs = New System.Windows.Forms.ListBox()
    Me.btnRemove = New System.Windows.Forms.Button()
    Me.grpLabel.SuspendLayout()
    Me.SuspendLayout()
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.OK_Button.Location = New System.Drawing.Point(0, 297)
    Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(580, 42)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'grpLabel
    '
    Me.grpLabel.Controls.Add(Me.btnAdd)
    Me.grpLabel.Controls.Add(Me.txtInput)
    Me.grpLabel.Dock = System.Windows.Forms.DockStyle.Top
    Me.grpLabel.Location = New System.Drawing.Point(0, 0)
    Me.grpLabel.Name = "grpLabel"
    Me.grpLabel.Size = New System.Drawing.Size(580, 64)
    Me.grpLabel.TabIndex = 1
    Me.grpLabel.TabStop = False
    Me.grpLabel.Text = "{Insert Label}"
    '
    'btnAdd
    '
    Me.btnAdd.Location = New System.Drawing.Point(442, 21)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(126, 30)
    Me.btnAdd.TabIndex = 1
    Me.btnAdd.Text = "Add"
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'txtInput
    '
    Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInput.Location = New System.Drawing.Point(12, 21)
    Me.txtInput.Name = "txtInput"
    Me.txtInput.Size = New System.Drawing.Size(424, 30)
    Me.txtInput.TabIndex = 0
    '
    'lstInputs
    '
    Me.lstInputs.FormattingEnabled = True
    Me.lstInputs.ItemHeight = 16
    Me.lstInputs.Location = New System.Drawing.Point(12, 71)
    Me.lstInputs.Name = "lstInputs"
    Me.lstInputs.Size = New System.Drawing.Size(556, 180)
    Me.lstInputs.TabIndex = 2
    '
    'btnRemove
    '
    Me.btnRemove.Location = New System.Drawing.Point(493, 257)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(75, 23)
    Me.btnRemove.TabIndex = 3
    Me.btnRemove.Text = "Remove"
    Me.btnRemove.UseVisualStyleBackColor = True
    '
    'Multiple_String
    '
    Me.AcceptButton = Me.btnAdd
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(580, 339)
    Me.Controls.Add(Me.btnRemove)
    Me.Controls.Add(Me.lstInputs)
    Me.Controls.Add(Me.grpLabel)
    Me.Controls.Add(Me.OK_Button)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Multiple_String"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Multiple String"
    Me.grpLabel.ResumeLayout(False)
    Me.grpLabel.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents grpLabel As System.Windows.Forms.GroupBox
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents txtInput As System.Windows.Forms.TextBox
  Friend WithEvents lstInputs As System.Windows.Forms.ListBox
  Friend WithEvents btnRemove As System.Windows.Forms.Button

End Class
