<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Permissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.scheduled_reports = New System.Windows.Forms.CheckBox()
        Me.dayEnd_reports = New System.Windows.Forms.CheckBox()
        Me.profit_reports = New System.Windows.Forms.CheckBox()
        Me.stock_reports = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.backup_database = New System.Windows.Forms.CheckBox()
        Me.is_admin = New System.Windows.Forms.CheckBox()
        Me.activate_users = New System.Windows.Forms.CheckBox()
        Me.edit_settings = New System.Windows.Forms.CheckBox()
        Me.register_users = New System.Windows.Forms.CheckBox()
        Me.update_users = New System.Windows.Forms.CheckBox()
        Me.Give_permissions = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.edit_inventory = New System.Windows.Forms.CheckBox()
        Me.add_inventory = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.return_sales = New System.Windows.Forms.CheckBox()
        Me.view_sales = New System.Windows.Forms.CheckBox()
        Me.cancel_transactions = New System.Windows.Forms.CheckBox()
        Me.cashup_balances = New System.Windows.Forms.CheckBox()
        Me.transaction_logs = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.employee_id = New System.Windows.Forms.ComboBox()
        Me.search_button = New MetroFramework.Controls.MetroButton()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 609)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Olive
        Me.Button2.Location = New System.Drawing.Point(672, 567)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(274, 35)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Update Permissions for Existing User"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Olive
        Me.Button1.Location = New System.Drawing.Point(379, 567)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(289, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Create Permissions For New User"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox5.Controls.Add(Me.scheduled_reports)
        Me.GroupBox5.Controls.Add(Me.dayEnd_reports)
        Me.GroupBox5.Controls.Add(Me.profit_reports)
        Me.GroupBox5.Controls.Add(Me.stock_reports)
        Me.GroupBox5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox5.Location = New System.Drawing.Point(10, 371)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(466, 172)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "4. Reports"
        '
        'scheduled_reports
        '
        Me.scheduled_reports.AutoSize = True
        Me.scheduled_reports.Location = New System.Drawing.Point(49, 142)
        Me.scheduled_reports.Name = "scheduled_reports"
        Me.scheduled_reports.Size = New System.Drawing.Size(146, 21)
        Me.scheduled_reports.TabIndex = 3
        Me.scheduled_reports.Text = "Scheduled Reports"
        Me.scheduled_reports.UseVisualStyleBackColor = True
        '
        'dayEnd_reports
        '
        Me.dayEnd_reports.AutoSize = True
        Me.dayEnd_reports.Location = New System.Drawing.Point(49, 105)
        Me.dayEnd_reports.Name = "dayEnd_reports"
        Me.dayEnd_reports.Size = New System.Drawing.Size(180, 21)
        Me.dayEnd_reports.TabIndex = 2
        Me.dayEnd_reports.Text = "End Of day Sales Report"
        Me.dayEnd_reports.UseVisualStyleBackColor = True
        '
        'profit_reports
        '
        Me.profit_reports.AutoSize = True
        Me.profit_reports.Location = New System.Drawing.Point(49, 76)
        Me.profit_reports.Name = "profit_reports"
        Me.profit_reports.Size = New System.Drawing.Size(112, 21)
        Me.profit_reports.TabIndex = 1
        Me.profit_reports.Text = "Profit Reports"
        Me.profit_reports.UseVisualStyleBackColor = True
        '
        'stock_reports
        '
        Me.stock_reports.AutoSize = True
        Me.stock_reports.Location = New System.Drawing.Point(49, 44)
        Me.stock_reports.Name = "stock_reports"
        Me.stock_reports.Size = New System.Drawing.Size(114, 21)
        Me.stock_reports.TabIndex = 0
        Me.stock_reports.Text = "Stock Reports"
        Me.stock_reports.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.backup_database)
        Me.GroupBox3.Controls.Add(Me.is_admin)
        Me.GroupBox3.Controls.Add(Me.activate_users)
        Me.GroupBox3.Controls.Add(Me.edit_settings)
        Me.GroupBox3.Controls.Add(Me.register_users)
        Me.GroupBox3.Controls.Add(Me.update_users)
        Me.GroupBox3.Controls.Add(Me.Give_permissions)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox3.Location = New System.Drawing.Point(484, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(466, 167)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "3. Administration Rights"
        '
        'backup_database
        '
        Me.backup_database.AutoSize = True
        Me.backup_database.Location = New System.Drawing.Point(265, 49)
        Me.backup_database.Name = "backup_database"
        Me.backup_database.Size = New System.Drawing.Size(196, 21)
        Me.backup_database.TabIndex = 9
        Me.backup_database.Text = "Backup/Restore Database"
        Me.backup_database.UseVisualStyleBackColor = True
        '
        'is_admin
        '
        Me.is_admin.AutoSize = True
        Me.is_admin.Location = New System.Drawing.Point(265, 22)
        Me.is_admin.Name = "is_admin"
        Me.is_admin.Size = New System.Drawing.Size(81, 21)
        Me.is_admin.TabIndex = 8
        Me.is_admin.Text = "Is Admin"
        Me.is_admin.UseVisualStyleBackColor = True
        '
        'activate_users
        '
        Me.activate_users.AutoSize = True
        Me.activate_users.Location = New System.Drawing.Point(49, 139)
        Me.activate_users.Name = "activate_users"
        Me.activate_users.Size = New System.Drawing.Size(195, 21)
        Me.activate_users.TabIndex = 7
        Me.activate_users.Text = "Activate/Deactivate Users"
        Me.activate_users.UseVisualStyleBackColor = True
        '
        'edit_settings
        '
        Me.edit_settings.AutoSize = True
        Me.edit_settings.Location = New System.Drawing.Point(49, 109)
        Me.edit_settings.Name = "edit_settings"
        Me.edit_settings.Size = New System.Drawing.Size(104, 21)
        Me.edit_settings.TabIndex = 6
        Me.edit_settings.Text = "Edit Settings"
        Me.edit_settings.UseVisualStyleBackColor = True
        '
        'register_users
        '
        Me.register_users.AutoSize = True
        Me.register_users.Location = New System.Drawing.Point(49, 82)
        Me.register_users.Name = "register_users"
        Me.register_users.Size = New System.Drawing.Size(111, 21)
        Me.register_users.TabIndex = 5
        Me.register_users.Text = "Register Users"
        Me.register_users.UseVisualStyleBackColor = True
        '
        'update_users
        '
        Me.update_users.AutoSize = True
        Me.update_users.Location = New System.Drawing.Point(49, 52)
        Me.update_users.Name = "update_users"
        Me.update_users.Size = New System.Drawing.Size(115, 21)
        Me.update_users.TabIndex = 2
        Me.update_users.Text = "Manage Users"
        Me.update_users.UseVisualStyleBackColor = True
        '
        'Give_permissions
        '
        Me.Give_permissions.AutoSize = True
        Me.Give_permissions.Location = New System.Drawing.Point(49, 22)
        Me.Give_permissions.Name = "Give_permissions"
        Me.Give_permissions.Size = New System.Drawing.Size(161, 21)
        Me.Give_permissions.TabIndex = 1
        Me.Give_permissions.Text = "Give User Permissions"
        Me.Give_permissions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.edit_inventory)
        Me.GroupBox2.Controls.Add(Me.add_inventory)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox2.Location = New System.Drawing.Point(484, 371)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(466, 106)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2. Inventory Rights"
        '
        'edit_inventory
        '
        Me.edit_inventory.AutoSize = True
        Me.edit_inventory.Location = New System.Drawing.Point(57, 71)
        Me.edit_inventory.Name = "edit_inventory"
        Me.edit_inventory.Size = New System.Drawing.Size(114, 21)
        Me.edit_inventory.TabIndex = 2
        Me.edit_inventory.Text = "Edit Inventory"
        Me.edit_inventory.UseVisualStyleBackColor = True
        '
        'add_inventory
        '
        Me.add_inventory.AutoSize = True
        Me.add_inventory.Location = New System.Drawing.Point(57, 35)
        Me.add_inventory.Name = "add_inventory"
        Me.add_inventory.Size = New System.Drawing.Size(117, 21)
        Me.add_inventory.TabIndex = 1
        Me.add_inventory.Text = "Add Inventory"
        Me.add_inventory.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.return_sales)
        Me.GroupBox1.Controls.Add(Me.view_sales)
        Me.GroupBox1.Controls.Add(Me.cancel_transactions)
        Me.GroupBox1.Controls.Add(Me.cashup_balances)
        Me.GroupBox1.Controls.Add(Me.transaction_logs)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Location = New System.Drawing.Point(10, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 167)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. Transactions Rights"
        '
        'return_sales
        '
        Me.return_sales.AutoSize = True
        Me.return_sales.Location = New System.Drawing.Point(57, 139)
        Me.return_sales.Name = "return_sales"
        Me.return_sales.Size = New System.Drawing.Size(98, 21)
        Me.return_sales.TabIndex = 4
        Me.return_sales.Text = "Return Sale"
        Me.return_sales.UseVisualStyleBackColor = True
        '
        'view_sales
        '
        Me.view_sales.AutoSize = True
        Me.view_sales.Location = New System.Drawing.Point(57, 112)
        Me.view_sales.Name = "view_sales"
        Me.view_sales.Size = New System.Drawing.Size(121, 21)
        Me.view_sales.TabIndex = 3
        Me.view_sales.Text = "View  All Sales "
        Me.view_sales.UseVisualStyleBackColor = True
        '
        'cancel_transactions
        '
        Me.cancel_transactions.AutoSize = True
        Me.cancel_transactions.Location = New System.Drawing.Point(57, 82)
        Me.cancel_transactions.Name = "cancel_transactions"
        Me.cancel_transactions.Size = New System.Drawing.Size(156, 21)
        Me.cancel_transactions.TabIndex = 2
        Me.cancel_transactions.Text = "Cancel Transactions"
        Me.cancel_transactions.UseVisualStyleBackColor = True
        '
        'cashup_balances
        '
        Me.cashup_balances.AutoSize = True
        Me.cashup_balances.Location = New System.Drawing.Point(57, 53)
        Me.cashup_balances.Name = "cashup_balances"
        Me.cashup_balances.Size = New System.Drawing.Size(178, 21)
        Me.cashup_balances.TabIndex = 1
        Me.cashup_balances.Text = "View Cashup Balances "
        Me.cashup_balances.UseVisualStyleBackColor = True
        '
        'transaction_logs
        '
        Me.transaction_logs.AutoSize = True
        Me.transaction_logs.Location = New System.Drawing.Point(57, 22)
        Me.transaction_logs.Name = "transaction_logs"
        Me.transaction_logs.Size = New System.Drawing.Size(166, 21)
        Me.transaction_logs.TabIndex = 0
        Me.transaction_logs.Text = "View Transactions log"
        Me.transaction_logs.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Location = New System.Drawing.Point(10, 162)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(937, 3)
        Me.Panel2.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.Controls.Add(Me.employee_id)
        Me.GroupBox4.Controls.Add(Me.search_button)
        Me.GroupBox4.Controls.Add(Me.txtUsername)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox4.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(937, 156)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "User Personal Details "
        '
        'employee_id
        '
        Me.employee_id.FormattingEnabled = True
        Me.employee_id.Location = New System.Drawing.Point(171, 23)
        Me.employee_id.Name = "employee_id"
        Me.employee_id.Size = New System.Drawing.Size(403, 25)
        Me.employee_id.TabIndex = 15
        '
        'search_button
        '
        Me.search_button.Location = New System.Drawing.Point(171, 98)
        Me.search_button.Name = "search_button"
        Me.search_button.Size = New System.Drawing.Size(109, 35)
        Me.search_button.TabIndex = 13
        Me.search_button.Text = "SEARCH USER"
        Me.search_button.UseSelectable = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(169, 56)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.Size = New System.Drawing.Size(405, 27)
        Me.txtUsername.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Select Employee ID:"
        '
        'Permissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 609)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Permissions"
        Me.Text = "Permissions"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents profit_reports As CheckBox
    Friend WithEvents stock_reports As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents register_users As CheckBox
    Friend WithEvents update_users As CheckBox
    Friend WithEvents Give_permissions As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents edit_inventory As CheckBox
    Friend WithEvents add_inventory As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents view_sales As CheckBox
    Friend WithEvents cancel_transactions As CheckBox
    Friend WithEvents cashup_balances As CheckBox
    Friend WithEvents transaction_logs As CheckBox
    Friend WithEvents dayEnd_reports As CheckBox
    Friend WithEvents scheduled_reports As CheckBox
    Friend WithEvents activate_users As CheckBox
    Friend WithEvents edit_settings As CheckBox
    Friend WithEvents return_sales As CheckBox
    Friend WithEvents backup_database As CheckBox
    Friend WithEvents is_admin As CheckBox
    Friend WithEvents search_button As MetroFramework.Controls.MetroButton
    Friend WithEvents employee_id As ComboBox
End Class
