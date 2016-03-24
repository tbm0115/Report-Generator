<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Decompiling_Splash
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
    Me.txtFilePath = New System.Windows.Forms.TextBox()
    Me.lblProgress = New System.Windows.Forms.Label()
    Me.rtbProgress = New System.Windows.Forms.RichTextBox()
    Me.prgProgress = New System.Windows.Forms.ProgressBar()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'txtFilePath
    '
    Me.txtFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtFilePath.Location = New System.Drawing.Point(13, 13)
    Me.txtFilePath.Name = "txtFilePath"
    Me.txtFilePath.ReadOnly = True
    Me.txtFilePath.Size = New System.Drawing.Size(473, 30)
    Me.txtFilePath.TabIndex = 0
    '
    'lblProgress
    '
    Me.lblProgress.AutoSize = True
    Me.lblProgress.Location = New System.Drawing.Point(13, 45)
    Me.lblProgress.Name = "lblProgress"
    Me.lblProgress.Size = New System.Drawing.Size(97, 17)
    Me.lblProgress.TabIndex = 1
    Me.lblProgress.Text = "Decompiling..."
    '
    'rtbProgress
    '
    Me.rtbProgress.Location = New System.Drawing.Point(16, 90)
    Me.rtbProgress.Name = "rtbProgress"
    Me.rtbProgress.ReadOnly = True
    Me.rtbProgress.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
    Me.rtbProgress.Size = New System.Drawing.Size(470, 171)
    Me.rtbProgress.TabIndex = 2
    Me.rtbProgress.Text = ""
    '
    'prgProgress
    '
    Me.prgProgress.Location = New System.Drawing.Point(16, 66)
    Me.prgProgress.Name = "prgProgress"
    Me.prgProgress.Size = New System.Drawing.Size(470, 23)
    Me.prgProgress.TabIndex = 3
    '
    'btnCancel
    '
    Me.btnCancel.Location = New System.Drawing.Point(411, 271)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 4
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = True
    '
    'Decompiling_Splash
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(498, 300)
    Me.ControlBox = False
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.prgProgress)
    Me.Controls.Add(Me.rtbProgress)
    Me.Controls.Add(Me.lblProgress)
    Me.Controls.Add(Me.txtFilePath)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Decompiling_Splash"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
  Friend WithEvents lblProgress As System.Windows.Forms.Label
  Friend WithEvents rtbProgress As System.Windows.Forms.RichTextBox
  Friend WithEvents prgProgress As System.Windows.Forms.ProgressBar
  Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
