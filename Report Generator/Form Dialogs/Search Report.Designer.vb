<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Report
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
    Me.lblError = New System.Windows.Forms.Label()
    Me.lblInstructions = New System.Windows.Forms.Label()
    Me.pnlContainer = New System.Windows.Forms.Panel()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.lblError, 0, 1)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 311)
    Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(580, 77)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'OK_Button
    '
    Me.TableLayoutPanel1.SetColumnSpan(Me.OK_Button, 2)
    Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
    Me.OK_Button.Location = New System.Drawing.Point(4, 4)
    Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(572, 33)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'lblError
    '
    Me.TableLayoutPanel1.SetColumnSpan(Me.lblError, 2)
    Me.lblError.Dock = System.Windows.Forms.DockStyle.Fill
    Me.lblError.Location = New System.Drawing.Point(3, 41)
    Me.lblError.Name = "lblError"
    Me.lblError.Size = New System.Drawing.Size(574, 36)
    Me.lblError.TabIndex = 2
    '
    'lblInstructions
    '
    Me.lblInstructions.Cursor = System.Windows.Forms.Cursors.Hand
    Me.lblInstructions.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblInstructions.Location = New System.Drawing.Point(0, 0)
    Me.lblInstructions.Name = "lblInstructions"
    Me.lblInstructions.Size = New System.Drawing.Size(580, 42)
    Me.lblInstructions.TabIndex = 1
    Me.lblInstructions.Text = "Filter the report using the controls below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Regular Expressions can be used such" & _
    " as the wildcard filter (.*)):"
    '
    'pnlContainer
    '
    Me.pnlContainer.AutoScroll = True
    Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlContainer.Location = New System.Drawing.Point(0, 42)
    Me.pnlContainer.Name = "pnlContainer"
    Me.pnlContainer.Size = New System.Drawing.Size(580, 269)
    Me.pnlContainer.TabIndex = 2
    '
    'Search_Report
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(580, 388)
    Me.Controls.Add(Me.pnlContainer)
    Me.Controls.Add(Me.lblInstructions)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Margin = New System.Windows.Forms.Padding(4)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Search_Report"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Search"
    Me.TopMost = True
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents lblInstructions As System.Windows.Forms.Label
  Friend WithEvents pnlContainer As System.Windows.Forms.Panel
  Friend WithEvents lblError As System.Windows.Forms.Label

End Class
