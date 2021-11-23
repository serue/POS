<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class multi_payment_report
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
        Me.FURTHER_REPORT = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.show_report = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.date_to = New MetroFramework.Controls.MetroDateTime()
        Me.date_from = New MetroFramework.Controls.MetroDateTime()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(858, 5)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FURTHER_REPORT)
        Me.Panel2.Controls.Add(Me.MaterialLabel2)
        Me.Panel2.Controls.Add(Me.MaterialLabel1)
        Me.Panel2.Controls.Add(Me.show_report)
        Me.Panel2.Controls.Add(Me.date_to)
        Me.Panel2.Controls.Add(Me.date_from)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(858, 81)
        Me.Panel2.TabIndex = 2
        '
        'FURTHER_REPORT
        '
        Me.FURTHER_REPORT.Depth = 0
        Me.FURTHER_REPORT.Location = New System.Drawing.Point(502, 13)
        Me.FURTHER_REPORT.MouseState = MaterialSkin.MouseState.HOVER
        Me.FURTHER_REPORT.Name = "FURTHER_REPORT"
        Me.FURTHER_REPORT.Primary = True
        Me.FURTHER_REPORT.Size = New System.Drawing.Size(169, 40)
        Me.FURTHER_REPORT.TabIndex = 5
        Me.FURTHER_REPORT.Text = "OPEN FURTHER MULTIPLE REPORTS"
        Me.FURTHER_REPORT.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(38, 52)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(31, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "To:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(22, 13)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(48, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "From:"
        '
        'show_report
        '
        Me.show_report.Depth = 0
        Me.show_report.Location = New System.Drawing.Point(318, 13)
        Me.show_report.MouseState = MaterialSkin.MouseState.HOVER
        Me.show_report.Name = "show_report"
        Me.show_report.Primary = True
        Me.show_report.Size = New System.Drawing.Size(169, 40)
        Me.show_report.TabIndex = 3
        Me.show_report.Text = "Open Report"
        Me.show_report.UseVisualStyleBackColor = True
        '
        'date_to
        '
        Me.date_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_to.Location = New System.Drawing.Point(75, 46)
        Me.date_to.MinimumSize = New System.Drawing.Size(0, 29)
        Me.date_to.Name = "date_to"
        Me.date_to.Size = New System.Drawing.Size(174, 29)
        Me.date_to.TabIndex = 2
        '
        'date_from
        '
        Me.date_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_from.Location = New System.Drawing.Point(75, 9)
        Me.date_from.MinimumSize = New System.Drawing.Size(0, 29)
        Me.date_from.Name = "date_from"
        Me.date_from.Size = New System.Drawing.Size(174, 29)
        Me.date_from.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(858, 2)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ReportViewer1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 86)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(858, 364)
        Me.Panel4.TabIndex = 3
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(858, 364)
        Me.ReportViewer1.TabIndex = 1
        '
        'BackgroundWorker1
        '
        '
        'multi_payment_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "multi_payment_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi-Payment Reports "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents show_report As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents date_to As MetroFramework.Controls.MetroDateTime
    Friend WithEvents date_from As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FURTHER_REPORT As MaterialSkin.Controls.MaterialRaisedButton
End Class
