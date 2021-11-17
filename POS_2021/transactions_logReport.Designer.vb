<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactions_logReport
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.normal_report = New System.Windows.Forms.Button()
        Me.filtered_report = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.cancelled_trasactions = New MaterialSkin.Controls.MaterialCheckBox()
        Me.to_date = New MetroFramework.Controls.MetroDateTime()
        Me.from_date = New MetroFramework.Controls.MetroDateTime()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(932, 3)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.normal_report)
        Me.Panel2.Controls.Add(Me.filtered_report)
        Me.Panel2.Controls.Add(Me.txt_username)
        Me.Panel2.Controls.Add(Me.cancelled_trasactions)
        Me.Panel2.Controls.Add(Me.to_date)
        Me.Panel2.Controls.Add(Me.from_date)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(932, 89)
        Me.Panel2.TabIndex = 1
        '
        'normal_report
        '
        Me.normal_report.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.normal_report.Location = New System.Drawing.Point(776, 43)
        Me.normal_report.Name = "normal_report"
        Me.normal_report.Size = New System.Drawing.Size(144, 34)
        Me.normal_report.TabIndex = 8
        Me.normal_report.Text = "Daily Report"
        Me.normal_report.UseVisualStyleBackColor = True
        '
        'filtered_report
        '
        Me.filtered_report.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtered_report.Location = New System.Drawing.Point(776, 6)
        Me.filtered_report.Name = "filtered_report"
        Me.filtered_report.Size = New System.Drawing.Size(144, 34)
        Me.filtered_report.TabIndex = 7
        Me.filtered_report.Text = "Filtered Report"
        Me.filtered_report.UseVisualStyleBackColor = True
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(484, 16)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(242, 25)
        Me.txt_username.TabIndex = 6
        '
        'cancelled_trasactions
        '
        Me.cancelled_trasactions.AutoSize = True
        Me.cancelled_trasactions.Depth = 0
        Me.cancelled_trasactions.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cancelled_trasactions.Location = New System.Drawing.Point(324, 43)
        Me.cancelled_trasactions.Margin = New System.Windows.Forms.Padding(0)
        Me.cancelled_trasactions.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cancelled_trasactions.MouseState = MaterialSkin.MouseState.HOVER
        Me.cancelled_trasactions.Name = "cancelled_trasactions"
        Me.cancelled_trasactions.Ripple = True
        Me.cancelled_trasactions.Size = New System.Drawing.Size(221, 30)
        Me.cancelled_trasactions.TabIndex = 5
        Me.cancelled_trasactions.Text = "Search Cancelled Transactions"
        Me.cancelled_trasactions.UseVisualStyleBackColor = True
        '
        'to_date
        '
        Me.to_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.to_date.Location = New System.Drawing.Point(102, 41)
        Me.to_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.to_date.Name = "to_date"
        Me.to_date.Size = New System.Drawing.Size(200, 29)
        Me.to_date.TabIndex = 4
        '
        'from_date
        '
        Me.from_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.from_date.Location = New System.Drawing.Point(102, 6)
        Me.from_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.from_date.Name = "from_date"
        Me.from_date.Size = New System.Drawing.Size(200, 29)
        Me.from_date.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Search by Cashier Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "End Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start Date:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ReportViewer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(932, 405)
        Me.Panel3.TabIndex = 2
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(932, 405)
        Me.ReportViewer1.TabIndex = 0
        '
        'BackgroundWorker1
        '
        '
        'transactions_logReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 497)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "transactions_logReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Log report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_username As TextBox
    Friend WithEvents cancelled_trasactions As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents to_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents from_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents normal_report As Button
    Friend WithEvents filtered_report As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
