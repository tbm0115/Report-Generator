<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Numeric_Variable
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
    Me.numIndex = New System.Windows.Forms.NumericUpDown()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.rtbCalculation = New System.Windows.Forms.RichTextBox()
    CType(Me.numIndex, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(15, 8)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(137, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Variable Index"
    '
    'numIndex
    '
    Me.numIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.numIndex.Location = New System.Drawing.Point(160, 6)
    Me.numIndex.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.numIndex.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
    Me.numIndex.Name = "numIndex"
    Me.numIndex.Size = New System.Drawing.Size(72, 30)
    Me.numIndex.TabIndex = 0
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(20, 57)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(119, 25)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Set Variable"
    '
    'rtbCalculation
    '
    Me.rtbCalculation.Location = New System.Drawing.Point(25, 86)
    Me.rtbCalculation.Name = "rtbCalculation"
    Me.rtbCalculation.Size = New System.Drawing.Size(543, 215)
    Me.rtbCalculation.TabIndex = 1
    Me.rtbCalculation.Text = ""
    '
    'Numeric_Variable
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.rtbCalculation)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.numIndex)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Numeric_Variable"
    Me.Size = New System.Drawing.Size(591, 304)
    CType(Me.numIndex, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents numIndex As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents rtbCalculation As System.Windows.Forms.RichTextBox

End Class
