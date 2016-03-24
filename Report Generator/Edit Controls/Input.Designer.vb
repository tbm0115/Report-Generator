<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input
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
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.drpType = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.txtLabel = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.rtbNotes = New System.Windows.Forms.RichTextBox()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.drpType)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel1.Location = New System.Drawing.Point(0, 0)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(591, 65)
    Me.Panel1.TabIndex = 0
    '
    'drpType
    '
    Me.drpType.Dock = System.Windows.Forms.DockStyle.Fill
    Me.drpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.drpType.FormattingEnabled = True
    Me.drpType.Items.AddRange(New Object() {"Single String", "Multiple String", "Date Range"})
    Me.drpType.Location = New System.Drawing.Point(0, 25)
    Me.drpType.Name = "drpType"
    Me.drpType.Size = New System.Drawing.Size(591, 33)
    Me.drpType.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(190, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Select an Input type:"
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.txtLabel)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 65)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(591, 65)
    Me.Panel2.TabIndex = 1
    '
    'txtLabel
    '
    Me.txtLabel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtLabel.Location = New System.Drawing.Point(0, 25)
    Me.txtLabel.Name = "txtLabel"
    Me.txtLabel.Size = New System.Drawing.Size(591, 30)
    Me.txtLabel.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label2.Location = New System.Drawing.Point(0, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(211, 25)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Provide a prompt label:"
    '
    'rtbNotes
    '
    Me.rtbNotes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rtbNotes.Location = New System.Drawing.Point(0, 130)
    Me.rtbNotes.Name = "rtbNotes"
    Me.rtbNotes.ReadOnly = True
    Me.rtbNotes.Size = New System.Drawing.Size(591, 268)
    Me.rtbNotes.TabIndex = 2
    Me.rtbNotes.Text = "Note that the value(s) that result from an Input will automatically provide a val" & _
    "ue in the Alphanumeric Variable at index 100"
    '
    'Input
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.rtbNotes)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Input"
    Me.Size = New System.Drawing.Size(591, 398)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents drpType As System.Windows.Forms.ComboBox
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtLabel As System.Windows.Forms.TextBox
  Friend WithEvents rtbNotes As System.Windows.Forms.RichTextBox

End Class
