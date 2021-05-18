<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_permissions
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
        Me.lblClose = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckDayEndSales = New System.Windows.Forms.CheckBox()
        Me.CheckViewSalesReutrns = New System.Windows.Forms.CheckBox()
        Me.CheckViewCreditSales = New System.Windows.Forms.CheckBox()
        Me.CheckCashupBalances = New System.Windows.Forms.CheckBox()
        Me.CheckTransactionLog = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckInventoryTransfer = New System.Windows.Forms.CheckBox()
        Me.CheckEditIventory = New System.Windows.Forms.CheckBox()
        Me.CheckAddIventory = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckUserRegistration = New System.Windows.Forms.CheckBox()
        Me.CheckResetPassword = New System.Windows.Forms.CheckBox()
        Me.CheckManageUsers = New System.Windows.Forms.CheckBox()
        Me.CheckManageAdmin = New System.Windows.Forms.CheckBox()
        Me.CheckAddAdmin = New System.Windows.Forms.CheckBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbUuserType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtNationalID = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.CmbUsers = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckProfit = New System.Windows.Forms.CheckBox()
        Me.CheckAllReports = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblClose)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 39)
        Me.Panel1.TabIndex = 0
        '
        'lblClose
        '
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblClose.Location = New System.Drawing.Point(709, 4)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(25, 26)
        Me.lblClose.TabIndex = 2
        Me.lblClose.Text = "X"
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(59, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change / Edit User Permissions"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 8)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckDayEndSales)
        Me.GroupBox1.Controls.Add(Me.CheckViewSalesReutrns)
        Me.GroupBox1.Controls.Add(Me.CheckViewCreditSales)
        Me.GroupBox1.Controls.Add(Me.CheckCashupBalances)
        Me.GroupBox1.Controls.Add(Me.CheckTransactionLog)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 178)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. Transactions Rights"
        '
        'CheckDayEndSales
        '
        Me.CheckDayEndSales.AutoSize = True
        Me.CheckDayEndSales.Location = New System.Drawing.Point(57, 143)
        Me.CheckDayEndSales.Name = "CheckDayEndSales"
        Me.CheckDayEndSales.Size = New System.Drawing.Size(115, 21)
        Me.CheckDayEndSales.TabIndex = 4
        Me.CheckDayEndSales.Text = "Day End Sales"
        Me.CheckDayEndSales.UseVisualStyleBackColor = True
        '
        'CheckViewSalesReutrns
        '
        Me.CheckViewSalesReutrns.AutoSize = True
        Me.CheckViewSalesReutrns.Location = New System.Drawing.Point(57, 112)
        Me.CheckViewSalesReutrns.Name = "CheckViewSalesReutrns"
        Me.CheckViewSalesReutrns.Size = New System.Drawing.Size(144, 21)
        Me.CheckViewSalesReutrns.TabIndex = 3
        Me.CheckViewSalesReutrns.Text = "View Sales Returns"
        Me.CheckViewSalesReutrns.UseVisualStyleBackColor = True
        '
        'CheckViewCreditSales
        '
        Me.CheckViewCreditSales.AutoSize = True
        Me.CheckViewCreditSales.Location = New System.Drawing.Point(57, 82)
        Me.CheckViewCreditSales.Name = "CheckViewCreditSales"
        Me.CheckViewCreditSales.Size = New System.Drawing.Size(138, 21)
        Me.CheckViewCreditSales.TabIndex = 2
        Me.CheckViewCreditSales.Text = "View Credit Sales"
        Me.CheckViewCreditSales.UseVisualStyleBackColor = True
        '
        'CheckCashupBalances
        '
        Me.CheckCashupBalances.AutoSize = True
        Me.CheckCashupBalances.Location = New System.Drawing.Point(57, 53)
        Me.CheckCashupBalances.Name = "CheckCashupBalances"
        Me.CheckCashupBalances.Size = New System.Drawing.Size(178, 21)
        Me.CheckCashupBalances.TabIndex = 1
        Me.CheckCashupBalances.Text = "View Cashup Balances "
        Me.CheckCashupBalances.UseVisualStyleBackColor = True
        '
        'CheckTransactionLog
        '
        Me.CheckTransactionLog.AutoSize = True
        Me.CheckTransactionLog.Location = New System.Drawing.Point(57, 22)
        Me.CheckTransactionLog.Name = "CheckTransactionLog"
        Me.CheckTransactionLog.Size = New System.Drawing.Size(166, 21)
        Me.CheckTransactionLog.TabIndex = 0
        Me.CheckTransactionLog.Text = "View Transactions log"
        Me.CheckTransactionLog.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckInventoryTransfer)
        Me.GroupBox2.Controls.Add(Me.CheckEditIventory)
        Me.GroupBox2.Controls.Add(Me.CheckAddIventory)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 383)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 148)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2. Inventory Rights"
        '
        'CheckInventoryTransfer
        '
        Me.CheckInventoryTransfer.AutoSize = True
        Me.CheckInventoryTransfer.Location = New System.Drawing.Point(57, 108)
        Me.CheckInventoryTransfer.Name = "CheckInventoryTransfer"
        Me.CheckInventoryTransfer.Size = New System.Drawing.Size(137, 21)
        Me.CheckInventoryTransfer.TabIndex = 3
        Me.CheckInventoryTransfer.Text = "Inventory Transfer"
        Me.CheckInventoryTransfer.UseVisualStyleBackColor = True
        '
        'CheckEditIventory
        '
        Me.CheckEditIventory.AutoSize = True
        Me.CheckEditIventory.Location = New System.Drawing.Point(57, 71)
        Me.CheckEditIventory.Name = "CheckEditIventory"
        Me.CheckEditIventory.Size = New System.Drawing.Size(114, 21)
        Me.CheckEditIventory.TabIndex = 2
        Me.CheckEditIventory.Text = "Edit Inventory"
        Me.CheckEditIventory.UseVisualStyleBackColor = True
        '
        'CheckAddIventory
        '
        Me.CheckAddIventory.AutoSize = True
        Me.CheckAddIventory.Location = New System.Drawing.Point(57, 35)
        Me.CheckAddIventory.Name = "CheckAddIventory"
        Me.CheckAddIventory.Size = New System.Drawing.Size(117, 21)
        Me.CheckAddIventory.TabIndex = 1
        Me.CheckAddIventory.Text = "Add Inventory"
        Me.CheckAddIventory.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckUserRegistration)
        Me.GroupBox3.Controls.Add(Me.CheckResetPassword)
        Me.GroupBox3.Controls.Add(Me.CheckManageUsers)
        Me.GroupBox3.Controls.Add(Me.CheckManageAdmin)
        Me.GroupBox3.Controls.Add(Me.CheckAddAdmin)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(372, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 178)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "3. Administration Rights"
        '
        'CheckUserRegistration
        '
        Me.CheckUserRegistration.AutoSize = True
        Me.CheckUserRegistration.Location = New System.Drawing.Point(48, 143)
        Me.CheckUserRegistration.Name = "CheckUserRegistration"
        Me.CheckUserRegistration.Size = New System.Drawing.Size(132, 21)
        Me.CheckUserRegistration.TabIndex = 5
        Me.CheckUserRegistration.Text = "User Registration"
        Me.CheckUserRegistration.UseVisualStyleBackColor = True
        '
        'CheckResetPassword
        '
        Me.CheckResetPassword.AutoSize = True
        Me.CheckResetPassword.Location = New System.Drawing.Point(49, 110)
        Me.CheckResetPassword.Name = "CheckResetPassword"
        Me.CheckResetPassword.Size = New System.Drawing.Size(119, 21)
        Me.CheckResetPassword.TabIndex = 4
        Me.CheckResetPassword.Text = "Reset Passords"
        Me.CheckResetPassword.UseVisualStyleBackColor = True
        '
        'CheckManageUsers
        '
        Me.CheckManageUsers.AutoSize = True
        Me.CheckManageUsers.Location = New System.Drawing.Point(49, 80)
        Me.CheckManageUsers.Name = "CheckManageUsers"
        Me.CheckManageUsers.Size = New System.Drawing.Size(115, 21)
        Me.CheckManageUsers.TabIndex = 3
        Me.CheckManageUsers.Text = "AMnage Users"
        Me.CheckManageUsers.UseVisualStyleBackColor = True
        '
        'CheckManageAdmin
        '
        Me.CheckManageAdmin.AutoSize = True
        Me.CheckManageAdmin.Location = New System.Drawing.Point(49, 52)
        Me.CheckManageAdmin.Name = "CheckManageAdmin"
        Me.CheckManageAdmin.Size = New System.Drawing.Size(127, 21)
        Me.CheckManageAdmin.TabIndex = 2
        Me.CheckManageAdmin.Text = "Manage Admin"
        Me.CheckManageAdmin.UseVisualStyleBackColor = True
        '
        'CheckAddAdmin
        '
        Me.CheckAddAdmin.AutoSize = True
        Me.CheckAddAdmin.Location = New System.Drawing.Point(49, 22)
        Me.CheckAddAdmin.Name = "CheckAddAdmin"
        Me.CheckAddAdmin.Size = New System.Drawing.Size(100, 21)
        Me.CheckAddAdmin.TabIndex = 1
        Me.CheckAddAdmin.Text = "Add Admin"
        Me.CheckAddAdmin.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(304, 554)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(201, 27)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save "
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(527, 554)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(201, 27)
        Me.BtnUpdate.TabIndex = 5
        Me.BtnUpdate.Text = "Save Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtUsername)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.CmbUuserType)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtPhone)
        Me.GroupBox4.Controls.Add(Me.txtNationalID)
        Me.GroupBox4.Controls.Add(Me.txtAddress)
        Me.GroupBox4.Controls.Add(Me.CmbUsers)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(9, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(720, 130)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "User Personal Details "
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(492, 23)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(213, 23)
        Me.txtUsername.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(393, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Username:"
        '
        'CmbUuserType
        '
        Me.CmbUuserType.FormattingEnabled = True
        Me.CmbUuserType.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.CmbUuserType.Location = New System.Drawing.Point(133, 25)
        Me.CmbUuserType.Name = "CmbUuserType"
        Me.CmbUuserType.Size = New System.Drawing.Size(231, 25)
        Me.CmbUuserType.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "User Type:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(491, 88)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(214, 23)
        Me.txtPhone.TabIndex = 8
        '
        'txtNationalID
        '
        Me.txtNationalID.Location = New System.Drawing.Point(491, 54)
        Me.txtNationalID.Name = "txtNationalID"
        Me.txtNationalID.ReadOnly = True
        Me.txtNationalID.Size = New System.Drawing.Size(214, 23)
        Me.txtNationalID.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(133, 88)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(231, 35)
        Me.txtAddress.TabIndex = 6
        '
        'CmbUsers
        '
        Me.CmbUsers.FormattingEnabled = True
        Me.CmbUsers.Location = New System.Drawing.Point(133, 57)
        Me.CmbUsers.MaxDropDownItems = 100
        Me.CmbUsers.Name = "CmbUsers"
        Me.CmbUsers.Size = New System.Drawing.Size(231, 25)
        Me.CmbUsers.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(393, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Phone :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(389, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "National ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Select User:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckProfit)
        Me.GroupBox5.Controls.Add(Me.CheckAllReports)
        Me.GroupBox5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(372, 390)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(357, 142)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "4. Reports"
        '
        'CheckProfit
        '
        Me.CheckProfit.AutoSize = True
        Me.CheckProfit.Location = New System.Drawing.Point(58, 68)
        Me.CheckProfit.Name = "CheckProfit"
        Me.CheckProfit.Size = New System.Drawing.Size(112, 21)
        Me.CheckProfit.TabIndex = 1
        Me.CheckProfit.Text = "Profit Reports"
        Me.CheckProfit.UseVisualStyleBackColor = True
        '
        'CheckAllReports
        '
        Me.CheckAllReports.AutoSize = True
        Me.CheckAllReports.Location = New System.Drawing.Point(58, 36)
        Me.CheckAllReports.Name = "CheckAllReports"
        Me.CheckAllReports.Size = New System.Drawing.Size(94, 21)
        Me.CheckAllReports.TabIndex = 0
        Me.CheckAllReports.Text = "All Reports"
        Me.CheckAllReports.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(12, 191)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(720, 5)
        Me.Panel3.TabIndex = 3
        '
        'user_permissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 598)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user_permissions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "user_permissions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckDayEndSales As System.Windows.Forms.CheckBox
    Friend WithEvents CheckViewSalesReutrns As System.Windows.Forms.CheckBox
    Friend WithEvents CheckViewCreditSales As System.Windows.Forms.CheckBox
    Friend WithEvents CheckCashupBalances As System.Windows.Forms.CheckBox
    Friend WithEvents CheckTransactionLog As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckEditIventory As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAddIventory As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckUserRegistration As System.Windows.Forms.CheckBox
    Friend WithEvents CheckResetPassword As System.Windows.Forms.CheckBox
    Friend WithEvents CheckManageUsers As System.Windows.Forms.CheckBox
    Friend WithEvents CheckManageAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAddAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtNationalID As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents CmbUsers As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CheckProfit As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAllReports As System.Windows.Forms.CheckBox
    Friend WithEvents CmbUuserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckInventoryTransfer As System.Windows.Forms.CheckBox
End Class
