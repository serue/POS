<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cash_up_reportForm
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
        Me.show_report = New System.Windows.Forms.Button()
        Me.username_text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.current_date = New MetroFramework.Controls.MetroDateTime()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TO_DATE = New MetroFramework.Controls.MetroDateTime()
        Me.day_report = New System.Windows.Forms.Button()
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
        Me.Panel1.Size = New System.Drawing.Size(824, 3)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.day_report)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TO_DATE)
        Me.Panel2.Controls.Add(Me.show_report)
        Me.Panel2.Controls.Add(Me.username_text)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.current_date)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 85)
        Me.Panel2.TabIndex = 1
        '
        'show_report
        '
        Me.show_report.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show_report.Location = New System.Drawing.Point(658, 12)
        Me.show_report.Name = "show_report"
        Me.show_report.Size = New System.Drawing.Size(138, 27)
        Me.show_report.TabIndex = 4
        Me.show_report.Text = "Show Filtered Report"
        Me.show_report.UseVisualStyleBackColor = True
        '
        'username_text
        '
        Me.username_text.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_text.Location = New System.Drawing.Point(349, 30)
        Me.username_text.Name = "username_text"
        Me.username_text.Size = New System.Drawing.Size(261, 27)
        Me.username_text.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search By Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Start Date:"
        '
        'current_date
        '
        Me.current_date.Location = New System.Drawing.Point(94, 10)
        Me.current_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.current_date.Name = "current_date"
        Me.current_date.Size = New System.Drawing.Size(200, 29)
        Me.current_date.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 88)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(824, 309)
        Me.Panel3.TabIndex = 2
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(824, 309)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'BackgroundWorker1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "End Date:"
        '
        'TO_DATE
        '
        Me.TO_DATE.Location = New System.Drawing.Point(94, 45)
        Me.TO_DATE.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.Size = New System.Drawing.Size(200, 29)
        Me.TO_DATE.TabIndex = 5
        '
        'day_report
        '
        Me.day_report.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day_report.Location = New System.Drawing.Point(658, 45)
        Me.day_report.Name = "day_report"
        Me.day_report.Size = New System.Drawing.Size(138, 27)
        Me.day_report.TabIndex = 7
        Me.day_report.Text = "Show Day Report"
        Me.day_report.UseVisualStyleBackColor = True
        '
        'cash_up_reportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 397)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "cash_up_reportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash up Reports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents show_report As Button
    Friend WithEvents username_text As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents current_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents day_report As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TO_DATE As MetroFramework.Controls.MetroDateTime
End Class
