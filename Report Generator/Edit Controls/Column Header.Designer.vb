<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Column_Header
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
    Me.btnEdit = New System.Windows.Forms.Button()
    Me.btnDown = New System.Windows.Forms.Button()
    Me.btnUp = New System.Windows.Forms.Button()
    Me.btnRemove = New System.Windows.Forms.Button()
    Me.lstHeaders = New System.Windows.Forms.ListBox()
    Me.grpAdd = New System.Windows.Forms.GroupBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.drpType = New System.Windows.Forms.ComboBox()
    Me.txtHeader = New System.Windows.Forms.TextBox()
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.grpAdd.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnEdit
    '
    Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnEdit.Location = New System.Drawing.Point(471, 71)
    Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnEdit.Name = "btnEdit"
    Me.btnEdit.Size = New System.Drawing.Size(116, 56)
    Me.btnEdit.TabIndex = 12
    Me.btnEdit.TabStop = False
    Me.btnEdit.Text = "Edit"
    Me.btnEdit.UseVisualStyleBackColor = True
    '
    'btnDown
    '
    Me.btnDown.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnDown.Location = New System.Drawing.Point(471, 137)
    Me.btnDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnDown.Name = "btnDown"
    Me.btnDown.Size = New System.Drawing.Size(116, 56)
    Me.btnDown.TabIndex = 11
    Me.btnDown.TabStop = False
    Me.btnDown.Text = "Down"
    Me.btnDown.UseVisualStyleBackColor = True
    '
    'btnUp
    '
    Me.btnUp.Dock = System.Windows.Forms.DockStyle.Fill
    Me.btnUp.Location = New System.Drawing.Point(471, 5)
    Me.btnUp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnUp.Name = "btnUp"
    Me.btnUp.Size = New System.Drawing.Size(116, 56)
    Me.btnUp.TabIndex = 10
    Me.btnUp.TabStop = False
    Me.btnUp.Text = "Up"
    Me.btnUp.UseVisualStyleBackColor = True
    '
    'btnRemove
    '
    Me.btnRemove.Location = New System.Drawing.Point(1128, 425)
    Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(112, 42)
    Me.btnRemove.TabIndex = 9
    Me.btnRemove.Text = "Remove"
    Me.btnRemove.UseVisualStyleBackColor = True
    '
    'lstHeaders
    '
    Me.lstHeaders.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lstHeaders.FormattingEnabled = True
    Me.lstHeaders.ItemHeight = 25
    Me.lstHeaders.Location = New System.Drawing.Point(4, 5)
    Me.lstHeaders.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.lstHeaders.Name = "lstHeaders"
    Me.TableLayoutPanel1.SetRowSpan(Me.lstHeaders, 3)
    Me.lstHeaders.Size = New System.Drawing.Size(459, 188)
    Me.lstHeaders.TabIndex = 8
    Me.lstHeaders.TabStop = False
    '
    'grpAdd
    '
    Me.grpAdd.Controls.Add(Me.Label1)
    Me.grpAdd.Controls.Add(Me.drpType)
    Me.grpAdd.Controls.Add(Me.txtHeader)
    Me.grpAdd.Controls.Add(Me.btnAdd)
    Me.grpAdd.Dock = System.Windows.Forms.DockStyle.Top
    Me.grpAdd.Location = New System.Drawing.Point(0, 0)
    Me.grpAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.grpAdd.Name = "grpAdd"
    Me.grpAdd.Padding = New System.Windows.Forms.Padding(8)
    Me.grpAdd.Size = New System.Drawing.Size(591, 106)
    Me.grpAdd.TabIndex = 7
    Me.grpAdd.TabStop = False
    Me.grpAdd.Text = "Add Report Column Headers"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 68)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(130, 25)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Column Type"
    '
    'drpType
    '
    Me.drpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.drpType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.drpType.FormattingEnabled = True
    Me.drpType.Items.AddRange(New Object() {"Alphanumeric", "Numeric", "Date"})
    Me.drpType.Location = New System.Drawing.Point(150, 65)
    Me.drpType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.drpType.Name = "drpType"
    Me.drpType.Size = New System.Drawing.Size(285, 33)
    Me.drpType.TabIndex = 2
    '
    'txtHeader
    '
    Me.txtHeader.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtHeader.Location = New System.Drawing.Point(8, 31)
    Me.txtHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.txtHeader.Name = "txtHeader"
    Me.txtHeader.Size = New System.Drawing.Size(427, 30)
    Me.txtHeader.TabIndex = 0
    '
    'btnAdd
    '
    Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
    Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAdd.Location = New System.Drawing.Point(435, 31)
    Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(148, 67)
    Me.btnAdd.TabIndex = 1
    Me.btnAdd.Text = "Add"
    Me.btnAdd.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.03226!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.96774!))
    Me.TableLayoutPanel1.Controls.Add(Me.lstHeaders, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnDown, 1, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.btnEdit, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.btnUp, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 106)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 3
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(591, 198)
    Me.TableLayoutPanel1.TabIndex = 13
    '
    'Column_Header
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Controls.Add(Me.btnRemove)
    Me.Controls.Add(Me.grpAdd)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
    Me.Name = "Column_Header"
    Me.Size = New System.Drawing.Size(591, 304)
    Me.grpAdd.ResumeLayout(False)
    Me.grpAdd.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnEdit As System.Windows.Forms.Button
  Friend WithEvents btnDown As System.Windows.Forms.Button
  Friend WithEvents btnUp As System.Windows.Forms.Button
  Friend WithEvents btnRemove As System.Windows.Forms.Button
  Friend WithEvents lstHeaders As System.Windows.Forms.ListBox
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents grpAdd As System.Windows.Forms.GroupBox
  Friend WithEvents txtHeader As System.Windows.Forms.TextBox
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents drpType As System.Windows.Forms.ComboBox

End Class
