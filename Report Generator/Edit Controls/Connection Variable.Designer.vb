<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connection_Variable
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.pnlIndex = New System.Windows.Forms.Panel()
    Me.numIndex = New System.Windows.Forms.NumericUpDown()
    Me.pnlConnection = New System.Windows.Forms.Panel()
    Me.rtbConnectionString = New System.Windows.Forms.RichTextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.rtbCommand = New System.Windows.Forms.RichTextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.pnlIndex.SuspendLayout()
    CType(Me.numIndex, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlConnection.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(137, 25)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Variable Index"
    '
    'pnlIndex
    '
    Me.pnlIndex.Controls.Add(Me.numIndex)
    Me.pnlIndex.Controls.Add(Me.Label1)
    Me.pnlIndex.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlIndex.Location = New System.Drawing.Point(0, 0)
    Me.pnlIndex.Name = "pnlIndex"
    Me.pnlIndex.Size = New System.Drawing.Size(591, 32)
    Me.pnlIndex.TabIndex = 12
    '
    'numIndex
    '
    Me.numIndex.Dock = System.Windows.Forms.DockStyle.Fill
    Me.numIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.numIndex.Location = New System.Drawing.Point(137, 0)
    Me.numIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.numIndex.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
    Me.numIndex.Name = "numIndex"
    Me.numIndex.Size = New System.Drawing.Size(454, 30)
    Me.numIndex.TabIndex = 0
    '
    'pnlConnection
    '
    Me.pnlConnection.Controls.Add(Me.rtbConnectionString)
    Me.pnlConnection.Controls.Add(Me.Label2)
    Me.pnlConnection.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlConnection.Location = New System.Drawing.Point(0, 32)
    Me.pnlConnection.Name = "pnlConnection"
    Me.pnlConnection.Size = New System.Drawing.Size(591, 160)
    Me.pnlConnection.TabIndex = 13
    '
    'rtbConnectionString
    '
    Me.rtbConnectionString.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rtbConnectionString.Location = New System.Drawing.Point(0, 25)
    Me.rtbConnectionString.Name = "rtbConnectionString"
    Me.rtbConnectionString.Size = New System.Drawing.Size(591, 135)
    Me.rtbConnectionString.TabIndex = 1
    Me.rtbConnectionString.Text = ""
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label2.Location = New System.Drawing.Point(0, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(168, 25)
    Me.Label2.TabIndex = 10
    Me.Label2.Text = "Connection String"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.rtbCommand)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 192)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(591, 150)
    Me.Panel1.TabIndex = 14
    '
    'rtbCommand
    '
    Me.rtbCommand.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rtbCommand.Location = New System.Drawing.Point(0, 25)
    Me.rtbCommand.Name = "rtbCommand"
    Me.rtbCommand.Size = New System.Drawing.Size(591, 125)
    Me.rtbCommand.TabIndex = 2
    Me.rtbCommand.Text = ""
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label3.Location = New System.Drawing.Point(0, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(159, 25)
    Me.Label3.TabIndex = 11
    Me.Label3.Text = "Command String"
    '
    'Connection_Variable
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.pnlConnection)
    Me.Controls.Add(Me.pnlIndex)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Connection_Variable"
    Me.Size = New System.Drawing.Size(591, 373)
    Me.pnlIndex.ResumeLayout(False)
    Me.pnlIndex.PerformLayout()
    CType(Me.numIndex, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlConnection.ResumeLayout(False)
    Me.pnlConnection.PerformLayout()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pnlIndex As System.Windows.Forms.Panel
  Friend WithEvents numIndex As System.Windows.Forms.NumericUpDown
  Friend WithEvents pnlConnection As System.Windows.Forms.Panel
  Friend WithEvents rtbConnectionString As System.Windows.Forms.RichTextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents rtbCommand As System.Windows.Forms.RichTextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
