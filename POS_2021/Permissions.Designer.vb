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
        Me.register_users = New System.Windows.Forms.CheckBox()
        Me.manage_users = New System.Windows.Forms.CheckBox()
        Me.Give_permissions = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.edit_inventory = New System.Windows.Forms.CheckBox()
        Me.add_inventory = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.view_sales = New System.Windows.Forms.CheckBox()
        Me.cancel_transactions = New System.Windows.Forms.CheckBox()
        Me.cashup_balances = New System.Windows.Forms.CheckBox()
        Me.transaction_log = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtNationalID = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.CmbUsers = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 760)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Olive
        Me.Button2.Location = New System.Drawing.Point(896, 698)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(366, 43)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Update Permissions for Existing User"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Olive
        Me.Button1.Location = New System.Drawing.Point(505, 698)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(385, 43)
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
        Me.GroupBox5.Location = New System.Drawing.Point(13, 412)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(621, 212)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "4. Reports"
        '
        'scheduled_reports
        '
        Me.scheduled_reports.AutoSize = True
        Me.scheduled_reports.Location = New System.Drawing.Point(65, 175)
        Me.scheduled_reports.Margin = New System.Windows.Forms.Padding(4)
        Me.scheduled_reports.Name = "scheduled_reports"
        Me.scheduled_reports.Size = New System.Drawing.Size(188, 25)
        Me.scheduled_reports.TabIndex = 3
        Me.scheduled_reports.Text = "Scheduled Reports"
        Me.scheduled_reports.UseVisualStyleBackColor = True
        '
        'dayEnd_reports
        '
        Me.dayEnd_reports.AutoSize = True
        Me.dayEnd_reports.Location = New System.Drawing.Point(65, 129)
        Me.dayEnd_reports.Margin = New System.Windows.Forms.Padding(4)
        Me.dayEnd_reports.Name = "dayEnd_reports"
        Me.dayEnd_reports.Size = New System.Drawing.Size(232, 25)
        Me.dayEnd_reports.TabIndex = 2
        Me.dayEnd_reports.Text = "End Of day Sales Report"
        Me.dayEnd_reports.UseVisualStyleBackColor = True
        '
        'profit_reports
        '
        Me.profit_reports.AutoSize = True
        Me.profit_reports.Location = New System.Drawing.Point(65, 94)
        Me.profit_reports.Margin = New System.Windows.Forms.Padding(4)
        Me.profit_reports.Name = "profit_reports"
        Me.profit_reports.Size = New System.Drawing.Size(141, 25)
        Me.profit_reports.TabIndex = 1
        Me.profit_reports.Text = "Profit Reports"
        Me.profit_reports.UseVisualStyleBackColor = True
        '
        'stock_reports
        '
        Me.stock_reports.AutoSize = True
        Me.stock_reports.Location = New System.Drawing.Point(65, 54)
        Me.stock_reports.Margin = New System.Windows.Forms.Padding(4)
        Me.stock_reports.Name = "stock_reports"
        Me.stock_reports.Size = New System.Drawing.Size(146, 25)
        Me.stock_reports.TabIndex = 0
        Me.stock_reports.Text = "Stock Reports"
        Me.stock_reports.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.register_users)
        Me.GroupBox3.Controls.Add(Me.manage_users)
        Me.GroupBox3.Controls.Add(Me.Give_permissions)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox3.Location = New System.Drawing.Point(645, 228)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(621, 148)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "3. Administration Rights"
        '
        'register_users
        '
        Me.register_users.AutoSize = True
        Me.register_users.Location = New System.Drawing.Point(65, 101)
        Me.register_users.Margin = New System.Windows.Forms.Padding(4)
        Me.register_users.Name = "register_users"
        Me.register_users.Size = New System.Drawing.Size(144, 25)
        Me.register_users.TabIndex = 5
        Me.register_users.Text = "Register Users"
        Me.register_users.UseVisualStyleBackColor = True
        '
        'manage_users
        '
        Me.manage_users.AutoSize = True
        Me.manage_users.Location = New System.Drawing.Point(65, 64)
        Me.manage_users.Margin = New System.Windows.Forms.Padding(4)
        Me.manage_users.Name = "manage_users"
        Me.manage_users.Size = New System.Drawing.Size(152, 25)
        Me.manage_users.TabIndex = 2
        Me.manage_users.Text = "Manage Users"
        Me.manage_users.UseVisualStyleBackColor = True
        '
        'Give_permissions
        '
        Me.Give_permissions.AutoSize = True
        Me.Give_permissions.Location = New System.Drawing.Point(65, 27)
        Me.Give_permissions.Margin = New System.Windows.Forms.Padding(4)
        Me.Give_permissions.Name = "Give_permissions"
        Me.Give_permissions.Size = New System.Drawing.Size(206, 25)
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
        Me.GroupBox2.Location = New System.Drawing.Point(645, 384)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(621, 130)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2. Inventory Rights"
        '
        'edit_inventory
        '
        Me.edit_inventory.AutoSize = True
        Me.edit_inventory.Location = New System.Drawing.Point(76, 87)
        Me.edit_inventory.Margin = New System.Windows.Forms.Padding(4)
        Me.edit_inventory.Name = "edit_inventory"
        Me.edit_inventory.Size = New System.Drawing.Size(146, 25)
        Me.edit_inventory.TabIndex = 2
        Me.edit_inventory.Text = "Edit Inventory"
        Me.edit_inventory.UseVisualStyleBackColor = True
        '
        'add_inventory
        '
        Me.add_inventory.AutoSize = True
        Me.add_inventory.Location = New System.Drawing.Point(76, 43)
        Me.add_inventory.Margin = New System.Windows.Forms.Padding(4)
        Me.add_inventory.Name = "add_inventory"
        Me.add_inventory.Size = New System.Drawing.Size(152, 25)
        Me.add_inventory.TabIndex = 1
        Me.add_inventory.Text = "Add Inventory"
        Me.add_inventory.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.view_sales)
        Me.GroupBox1.Controls.Add(Me.cancel_transactions)
        Me.GroupBox1.Controls.Add(Me.cashup_balances)
        Me.GroupBox1.Controls.Add(Me.transaction_log)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Location = New System.Drawing.Point(13, 228)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(621, 176)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. Transactions Rights"
        '
        'view_sales
        '
        Me.view_sales.AutoSize = True
        Me.view_sales.Location = New System.Drawing.Point(76, 138)
        Me.view_sales.Margin = New System.Windows.Forms.Padding(4)
        Me.view_sales.Name = "view_sales"
        Me.view_sales.Size = New System.Drawing.Size(153, 25)
        Me.view_sales.TabIndex = 3
        Me.view_sales.Text = "View  All Sales "
        Me.view_sales.UseVisualStyleBackColor = True
        '
        'cancel_transactions
        '
        Me.cancel_transactions.AutoSize = True
        Me.cancel_transactions.Location = New System.Drawing.Point(76, 101)
        Me.cancel_transactions.Margin = New System.Windows.Forms.Padding(4)
        Me.cancel_transactions.Name = "cancel_transactions"
        Me.cancel_transactions.Size = New System.Drawing.Size(201, 25)
        Me.cancel_transactions.TabIndex = 2
        Me.cancel_transactions.Text = "Cancel Transactions"
        Me.cancel_transactions.UseVisualStyleBackColor = True
        '
        'cashup_balances
        '
        Me.cashup_balances.AutoSize = True
        Me.cashup_balances.Location = New System.Drawing.Point(76, 65)
        Me.cashup_balances.Margin = New System.Windows.Forms.Padding(4)
        Me.cashup_balances.Name = "cashup_balances"
        Me.cashup_balances.Size = New System.Drawing.Size(229, 25)
        Me.cashup_balances.TabIndex = 1
        Me.cashup_balances.Text = "View Cashup Balances "
        Me.cashup_balances.UseVisualStyleBackColor = True
        '
        'transaction_log
        '
        Me.transaction_log.AutoSize = True
        Me.transaction_log.Location = New System.Drawing.Point(76, 27)
        Me.transaction_log.Margin = New System.Windows.Forms.Padding(4)
        Me.transaction_log.Name = "transaction_log"
        Me.transaction_log.Size = New System.Drawing.Size(211, 25)
        Me.transaction_log.TabIndex = 0
        Me.transaction_log.Text = "View Transactions log"
        Me.transaction_log.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Location = New System.Drawing.Point(13, 200)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1249, 4)
        Me.Panel2.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.Controls.Add(Me.txtUsername)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtPhone)
        Me.GroupBox4.Controls.Add(Me.txtNationalID)
        Me.GroupBox4.Controls.Add(Me.txtAddress)
        Me.GroupBox4.Controls.Add(Me.CmbUsers)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Firebrick
        Me.GroupBox4.Location = New System.Drawing.Point(13, 36)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(1249, 160)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "User Personal Details "
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(790, 29)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(424, 32)
        Me.txtUsername.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(658, 34)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Username:"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(789, 73)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(425, 32)
        Me.txtPhone.TabIndex = 8
        '
        'txtNationalID
        '
        Me.txtNationalID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNationalID.Location = New System.Drawing.Point(171, 121)
        Me.txtNationalID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNationalID.Name = "txtNationalID"
        Me.txtNationalID.ReadOnly = True
        Me.txtNationalID.Size = New System.Drawing.Size(448, 32)
        Me.txtNationalID.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(171, 68)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(448, 42)
        Me.txtAddress.TabIndex = 6
        '
        'CmbUsers
        '
        Me.CmbUsers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUsers.FormattingEnabled = True
        Me.CmbUsers.Location = New System.Drawing.Point(171, 28)
        Me.CmbUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbUsers.MaxDropDownItems = 100
        Me.CmbUsers.Name = "CmbUsers"
        Me.CmbUsers.Size = New System.Drawing.Size(448, 31)
        Me.CmbUsers.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(658, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Phone :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "National ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 70)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Select User:"
        '
        'Permissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 760)
        Me.Controls.Add(Me.Panel1)
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
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtNationalID As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents CmbUsers As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents profit_reports As CheckBox
    Friend WithEvents stock_reports As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents register_users As CheckBox
    Friend WithEvents manage_users As CheckBox
    Friend WithEvents Give_permissions As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents edit_inventory As CheckBox
    Friend WithEvents add_inventory As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents view_sales As CheckBox
    Friend WithEvents cancel_transactions As CheckBox
    Friend WithEvents cashup_balances As CheckBox
    Friend WithEvents transaction_log As CheckBox
    Friend WithEvents dayEnd_reports As CheckBox
    Friend WithEvents scheduled_reports As CheckBox
End Class
