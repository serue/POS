<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockReportForm
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.category_combo = New MetroFramework.Controls.MetroComboBox()
        Me.show_report = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.category_check = New MaterialSkin.Controls.MaterialCheckBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 3)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.MaterialLabel1)
        Me.Panel2.Controls.Add(Me.category_combo)
        Me.Panel2.Controls.Add(Me.show_report)
        Me.Panel2.Controls.Add(Me.category_check)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(907, 77)
        Me.Panel2.TabIndex = 1
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(23, 49)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(665, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "Initially, the report is shown for all products, you can customise the report by " &
    "using the filter above"
        '
        'category_combo
        '
        Me.category_combo.FormattingEnabled = True
        Me.category_combo.ItemHeight = 23
        Me.category_combo.Location = New System.Drawing.Point(205, 4)
        Me.category_combo.Name = "category_combo"
        Me.category_combo.PromptText = "Select Category here"
        Me.category_combo.Size = New System.Drawing.Size(306, 29)
        Me.category_combo.TabIndex = 3
        Me.category_combo.UseSelectable = True
        '
        'show_report
        '
        Me.show_report.Depth = 0
        Me.show_report.Location = New System.Drawing.Point(523, 3)
        Me.show_report.MouseState = MaterialSkin.MouseState.HOVER
        Me.show_report.Name = "show_report"
        Me.show_report.Primary = True
        Me.show_report.Size = New System.Drawing.Size(111, 31)
        Me.show_report.TabIndex = 2
        Me.show_report.Text = "Show Report"
        Me.show_report.UseVisualStyleBackColor = True
        '
        'category_check
        '
        Me.category_check.AutoSize = True
        Me.category_check.Depth = 0
        Me.category_check.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.category_check.Location = New System.Drawing.Point(7, 1)
        Me.category_check.Margin = New System.Windows.Forms.Padding(0)
        Me.category_check.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.category_check.MouseState = MaterialSkin.MouseState.HOVER
        Me.category_check.Name = "category_check"
        Me.category_check.Ripple = True
        Me.category_check.Size = New System.Drawing.Size(172, 30)
        Me.category_check.TabIndex = 0
        Me.category_check.Text = "View By Main Category"
        Me.category_check.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 80)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(907, 359)
        Me.CrystalReportViewer1.TabIndex = 2
        '
        'BackgroundWorker1
        '
        '
        'StockReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 439)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "StockReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point Of Sale System (Stock Reports)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents category_combo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents show_report As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents category_check As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
