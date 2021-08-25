<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduledReportForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filter_toggler = New MetroFramework.Controls.MetroToggle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.forex_check = New MaterialSkin.Controls.MaterialCheckBox()
        Me.ecocash_check = New MaterialSkin.Controls.MaterialCheckBox()
        Me.card_check = New MaterialSkin.Controls.MaterialCheckBox()
        Me.cash_check = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.show_report = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.date_to = New MetroFramework.Controls.MetroDateTime()
        Me.date_from = New MetroFramework.Controls.MetroDateTime()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1047, 3)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.filter_toggler)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.MaterialLabel2)
        Me.Panel2.Controls.Add(Me.MaterialLabel1)
        Me.Panel2.Controls.Add(Me.show_report)
        Me.Panel2.Controls.Add(Me.date_to)
        Me.Panel2.Controls.Add(Me.date_from)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1047, 81)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(786, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Check to allow report filter"
        '
        'filter_toggler
        '
        Me.filter_toggler.Appearance = System.Windows.Forms.Appearance.Button
        Me.filter_toggler.AutoSize = True
        Me.filter_toggler.FontSize = MetroFramework.MetroLinkSize.Medium
        Me.filter_toggler.Location = New System.Drawing.Point(878, 9)
        Me.filter_toggler.Name = "filter_toggler"
        Me.filter_toggler.Size = New System.Drawing.Size(80, 23)
        Me.filter_toggler.Style = MetroFramework.MetroColorStyle.Purple
        Me.filter_toggler.TabIndex = 8
        Me.filter_toggler.Text = "Off"
        Me.filter_toggler.UseSelectable = True
        Me.filter_toggler.UseStyleColors = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.forex_check)
        Me.GroupBox1.Controls.Add(Me.ecocash_check)
        Me.GroupBox1.Controls.Add(Me.card_check)
        Me.GroupBox1.Controls.Add(Me.cash_check)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(299, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 69)
        Me.GroupBox1.TabIndex = 7
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
        Me.cash_check.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
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
        Me.show_report.Location = New System.Drawing.Point(789, 42)
        Me.show_report.MouseState = MaterialSkin.MouseState.HOVER
        Me.show_report.Name = "show_report"
        Me.show_report.Primary = True
        Me.show_report.Size = New System.Drawing.Size(169, 29)
        Me.show_report.TabIndex = 3
        Me.show_report.Text = "Open Report"
        Me.show_report.UseVisualStyleBackColor = True
        '
        'date_to
        '
        Me.date_to.Location = New System.Drawing.Point(75, 46)
        Me.date_to.MinimumSize = New System.Drawing.Size(0, 29)
        Me.date_to.Name = "date_to"
        Me.date_to.Size = New System.Drawing.Size(174, 29)
        Me.date_to.TabIndex = 2
        '
        'date_from
        '
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
        Me.Panel3.Size = New System.Drawing.Size(1047, 2)
        Me.Panel3.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 84)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1047, 365)
        Me.CrystalReportViewer1.TabIndex = 2
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'ScheduledReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 449)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ScheduledReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scheduled Sales Reports"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents date_from As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents show_report As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents date_to As MetroFramework.Controls.MetroDateTime
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cash_check As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents filter_toggler As MetroFramework.Controls.MetroToggle
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents forex_check As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents ecocash_check As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents card_check As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
