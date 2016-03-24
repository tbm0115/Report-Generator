<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoSort
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
    Me.drpColumns = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'drpColumns
    '
    Me.drpColumns.Dock = System.Windows.Forms.DockStyle.Fill
    Me.drpColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.drpColumns.FormattingEnabled = True
    Me.drpColumns.Location = New System.Drawing.Point(0, 25)
    Me.drpColumns.Name = "drpColumns"
    Me.drpColumns.Size = New System.Drawing.Size(591, 33)
    Me.drpColumns.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(224, 25)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Select a Column to Sort:"
    '
    'AutoSort
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.drpColumns)
    Me.Controls.Add(Me.Label1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "AutoSort"
    Me.Size = New System.Drawing.Size(591, 70)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents drpColumns As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
