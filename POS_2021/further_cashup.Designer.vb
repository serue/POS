<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class further_cashup
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
        Me.day_report = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TO_DATE = New MetroFramework.Controls.MetroDateTime()
        Me.show_report = New System.Windows.Forms.Button()
        Me.username_text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.current_date = New MetroFramework.Controls.MetroDateTime()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.forex_check = New MaterialSkin.Controls.MaterialCheckBox()
        Me.ecocash_check = New MaterialSkin.Controls.MaterialCheckBox()
        Me.card_check = New MaterialSkin.Controls.MaterialCheckBox()
        Me.cash_check = New MaterialSkin.Controls.MaterialCheckBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Brown
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(966, 3)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
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
        Me.Panel2.Size = New System.Drawing.Size(966, 109)
        Me.Panel2.TabIndex = 2
        '
        'day_report
        '
        Me.day_report.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day_report.Location = New System.Drawing.Point(807, 56)
        Me.day_report.Name = "day_report"
        Me.day_report.Size = New System.Drawing.Size(138, 27)
        Me.day_report.TabIndex = 7
        Me.day_report.Text = "Show Day Report"
        Me.day_report.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "End Date:"
        '
        'TO_DATE
        '
        Me.TO_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TO_DATE.Location = New System.Drawing.Point(94, 53)
        Me.TO_DATE.MinimumSize = New System.Drawing.Size(0, 29)
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.Size = New System.Drawing.Size(200, 29)
        Me.TO_DATE.TabIndex = 5
        '
        'show_report
        '
        Me.show_report.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show_report.Location = New System.Drawing.Point(807, 12)
        Me.show_report.Name = "show_report"
        Me.show_report.Size = New System.Drawing.Size(138, 27)
        Me.show_report.TabIndex = 4
        Me.show_report.Text = "Show Filtered Report"
        Me.show_report.UseVisualStyleBackColor = True
        '
        'username_text
        '
        Me.username_text.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_text.Location = New System.Drawing.Point(446, 7)
        Me.username_text.Name = "username_text"
        Me.username_text.Size = New System.Drawing.Size(197, 27)
        Me.username_text.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(334, 10)
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
        Me.current_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.current_date.Location = New System.Drawing.Point(94, 10)
        Me.current_date.MinimumSize = New System.Drawing.Size(0, 29)
        Me.current_date.Name = "current_date"
        Me.current_date.Size = New System.Drawing.Size(200, 29)
        Me.current_date.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ReportViewer1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 112)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(966, 338)
        Me.Panel3.TabIndex = 3
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(966, 338)
        Me.ReportViewer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.forex_check)
        Me.GroupBox1.Controls.Add(Me.ecocash_check)
        Me.GroupBox1.Controls.Add(Me.card_check)
        Me.GroupBox1.Controls.Add(Me.cash_check)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(331, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 56)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Report using"
        '
        'forex_check
        '
        Me.forex_check.AutoSize = True
        Me.forex_check.Depth = 0
        Me.forex_check.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.forex_check.Location = New System.Drawing.Point(305, 23)
        Me.forex_check.Margin = New System.Windows.Forms.Padding(0)
        Me.forex_check.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.forex_check.MouseState = MaterialSkin.MouseState.HOVER
        Me.forex_check.Name = "forex_check"
        Me.forex_check.Ripple = True
        Me.forex_check.Size = New System.Drawing.Size(64, 30)
        Me.forex_check.TabIndex = 9
        Me.forex_check.Text = "Forex"
        Me.forex_check.UseVisualStyleBackColor = True
        '
        'ecocash_check
        '
        Me.ecocash_check.AutoSize = True
        Me.ecocash_check.Depth = 0
        Me.ecocash_check.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.ecocash_check.Location = New System.Drawing.Point(190, 23)
        Me.ecocash_check.Margin = New System.Windows.Forms.Padding(0)
        Me.ecocash_check.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.ecocash_check.MouseState = MaterialSkin.MouseState.HOVER
        Me.ecocash_check.Name = "ecocash_check"
        Me.ecocash_check.Ripple = True
        Me.ecocash_check.Size = New System.Drawing.Size(82, 30)
        Me.ecocash_check.TabIndex = 8
        Me.ecocash_check.Text = "Ecocash"
        Me.ecocash_check.UseVisualStyleBackColor = True
        '
        'card_check
        '
        Me.card_check.AutoSize = True
        Me.card_check.Depth = 0
        Me.card_check.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.card_check.Location = New System.Drawing.Point(107, 23)
        Me.card_check.Margin = New System.Windows.Forms.Padding(0)
        Me.card_check.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.card_check.MouseState = MaterialSkin.MouseState.HOVER
        Me.card_check.Name = "card_check"
        Me.card_check.Ripple = True
        Me.card_check.Size = New System.Drawing.Size(59, 30)
        Me.card_check.TabIndex = 7
        Me.card_check.Text = "Card"
        Me.card_check.UseVisualStyleBackColor = True
        '
        'cash_check
        '
        Me.cash_check.AutoSize = True
        Me.cash_check.Depth = 0
        Me.cash_check.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cash_check.Location = New System.Drawing.Point(14, 23)
        Me.cash_check.Margin = New System.Windows.Forms.Padding(0)
        Me.cash_check.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cash_check.MouseState = MaterialSkin.MouseState.HOVER
        Me.cash_check.Name = "cash_check"
        Me.cash_check.Ripple = True
        Me.cash_check.Size = New System.Drawing.Size(61, 30)
        Me.cash_check.TabIndex = 6
        Me.cash_check.Text = "Cash"
        Me.cash_check.UseVisualStyleBackColor = True
        '
        'further_cashup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "further_cashup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mulriple Transaction cashup Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents day_report As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TO_DATE As MetroFramework.Controls.MetroDateTime
    Friend WithEvents show_report As Button
    Friend WithEvents username_text As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents current_date As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents forex_check As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents ecocash_check As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents card_check As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents cash_check As MaterialSkin.Controls.MaterialCheckBox
End Class
