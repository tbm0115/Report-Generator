<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Task_Scheduler
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
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.OK_Button = New System.Windows.Forms.Button()
    Me.Cancel_Button = New System.Windows.Forms.Button()
    Me.pnlIntervalType = New System.Windows.Forms.Panel()
    Me.lblIntervalType = New System.Windows.Forms.Label()
    Me.drpIntervalType = New System.Windows.Forms.ComboBox()
    Me.pnlContainer = New System.Windows.Forms.Panel()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.pnlIntervalType.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 300)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(612, 52)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.Location = New System.Drawing.Point(6, 6)
    Me.OK_Button.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(294, 40)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'Cancel_Button
    '
    Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Cancel_Button.Location = New System.Drawing.Point(312, 6)
    Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.Cancel_Button.Name = "Cancel_Button"
    Me.Cancel_Button.Size = New System.Drawing.Size(294, 40)
    Me.Cancel_Button.TabIndex = 1
    Me.Cancel_Button.Text = "Cancel"
    '
    'pnlIntervalType
    '
    Me.pnlIntervalType.Controls.Add(Me.drpIntervalType)
    Me.pnlIntervalType.Controls.Add(Me.lblIntervalType)
    Me.pnlIntervalType.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlIntervalType.Location = New System.Drawing.Point(0, 0)
    Me.pnlIntervalType.Name = "pnlIntervalType"
    Me.pnlIntervalType.Padding = New System.Windows.Forms.Padding(5)
    Me.pnlIntervalType.Size = New System.Drawing.Size(612, 43)
    Me.pnlIntervalType.TabIndex = 1
    '
    'lblIntervalType
    '
    Me.lblIntervalType.Dock = System.Windows.Forms.DockStyle.Left
    Me.lblIntervalType.Location = New System.Drawing.Point(5, 5)
    Me.lblIntervalType.Name = "lblIntervalType"
    Me.lblIntervalType.Size = New System.Drawing.Size(216, 33)
    Me.lblIntervalType.TabIndex = 4
    Me.lblIntervalType.Text = "Select an interval type:"
    Me.lblIntervalType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'drpIntervalType
    '
    Me.drpIntervalType.Dock = System.Windows.Forms.DockStyle.Fill
    Me.drpIntervalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.drpIntervalType.FormattingEnabled = True
    Me.drpIntervalType.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Logon"})
    Me.drpIntervalType.Location = New System.Drawing.Point(221, 5)
    Me.drpIntervalType.Name = "drpIntervalType"
    Me.drpIntervalType.Size = New System.Drawing.Size(386, 33)
    Me.drpIntervalType.TabIndex = 5
    '
    'pnlContainer
    '
    Me.pnlContainer.AutoScroll = True
    Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlContainer.Location = New System.Drawing.Point(0, 43)
    Me.pnlContainer.Name = "pnlContainer"
    Me.pnlContainer.Size = New System.Drawing.Size(612, 257)
    Me.pnlContainer.TabIndex = 2
    '
    'Task_Scheduler
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.Cancel_Button
    Me.ClientSize = New System.Drawing.Size(612, 352)
    Me.Controls.Add(Me.pnlContainer)
    Me.Controls.Add(Me.pnlIntervalType)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Task_Scheduler"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Task Scheduler Settings"
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.pnlIntervalType.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents Cancel_Button As System.Windows.Forms.Button
  Friend WithEvents pnlIntervalType As System.Windows.Forms.Panel
  Friend WithEvents drpIntervalType As System.Windows.Forms.ComboBox
  Friend WithEvents lblIntervalType As System.Windows.Forms.Label
  Friend WithEvents pnlContainer As System.Windows.Forms.Panel

End Class
