<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logon_Trigger
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
    Me.rtbNotes = New System.Windows.Forms.RichTextBox()
    Me.SuspendLayout()
    '
    'rtbNotes
    '
    Me.rtbNotes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rtbNotes.Location = New System.Drawing.Point(0, 0)
    Me.rtbNotes.Name = "rtbNotes"
    Me.rtbNotes.ReadOnly = True
    Me.rtbNotes.Size = New System.Drawing.Size(401, 124)
    Me.rtbNotes.TabIndex = 0
    Me.rtbNotes.Text = ""
    '
    'Logon_Trigger
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.rtbNotes)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Logon_Trigger"
    Me.Size = New System.Drawing.Size(401, 124)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents rtbNotes As System.Windows.Forms.RichTextBox

End Class
