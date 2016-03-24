<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Output
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
    Me.pnlVariables = New System.Windows.Forms.Panel()
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.drpValues = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnRemove = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.lstValues = New System.Windows.Forms.ListBox()
    Me.lstColumns = New System.Windows.Forms.ListBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.pnlVariables.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlVariables
    '
    Me.pnlVariables.Controls.Add(Me.btnAdd)
    Me.pnlVariables.Controls.Add(Me.drpValues)
    Me.pnlVariables.Controls.Add(Me.Label1)
    Me.pnlVariables.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlVariables.Location = New System.Drawing.Point(0, 0)
    Me.pnlVariables.Name = "pnlVariables"
    Me.pnlVariables.Size = New System.Drawing.Size(591, 103)
    Me.pnlVariables.TabIndex = 12
    '
    'btnAdd
    '
    Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.btnAdd.Location = New System.Drawing.Point(0, 64)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(591, 39)
    Me.btnAdd.TabIndex = 2
    Me.btnAdd.Text = "Add"
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'drpValues
    '
    Me.drpValues.Dock = System.Windows.Forms.DockStyle.Fill
    Me.drpValues.FormattingEnabled = True
    Me.drpValues.Location = New System.Drawing.Point(0, 25)
    Me.drpValues.Name = "drpValues"
    Me.drpValues.Size = New System.Drawing.Size(591, 33)
    Me.drpValues.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(225, 25)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Select a Variable to add:"
    '
    'btnRemove
    '
    Me.btnRemove.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.btnRemove.Location = New System.Drawing.Point(0, 361)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(591, 37)
    Me.btnRemove.TabIndex = 2
    Me.btnRemove.Text = "Remove Value"
    Me.btnRemove.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.lstValues, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.lstColumns, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 103)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(3)
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(591, 258)
    Me.TableLayoutPanel1.TabIndex = 15
    '
    'lstValues
    '
    Me.lstValues.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstValues.FormattingEnabled = True
    Me.lstValues.ItemHeight = 25
    Me.lstValues.Location = New System.Drawing.Point(298, 35)
    Me.lstValues.Name = "lstValues"
    Me.lstValues.Size = New System.Drawing.Size(287, 217)
    Me.lstValues.TabIndex = 7
    Me.lstValues.TabStop = False
    '
    'lstColumns
    '
    Me.lstColumns.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstColumns.FormattingEnabled = True
    Me.lstColumns.ItemHeight = 25
    Me.lstColumns.Location = New System.Drawing.Point(6, 35)
    Me.lstColumns.Name = "lstColumns"
    Me.lstColumns.Size = New System.Drawing.Size(286, 217)
    Me.lstColumns.TabIndex = 6
    Me.lstColumns.TabStop = False
    '
    'Label2
    '
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label2.Location = New System.Drawing.Point(6, 3)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(286, 29)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Columns"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label3
    '
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label3.Location = New System.Drawing.Point(298, 3)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(287, 29)
    Me.Label3.TabIndex = 1
    Me.Label3.Text = "Values"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Output
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.btnRemove)
    Me.Controls.Add(Me.pnlVariables)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Output"
    Me.Size = New System.Drawing.Size(591, 398)
    Me.pnlVariables.ResumeLayout(False)
    Me.pnlVariables.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlVariables As System.Windows.Forms.Panel
  Friend WithEvents drpValues As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnRemove As System.Windows.Forms.Button
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lstValues As System.Windows.Forms.ListBox
  Friend WithEvents lstColumns As System.Windows.Forms.ListBox
  Friend WithEvents btnAdd As System.Windows.Forms.Button

End Class
