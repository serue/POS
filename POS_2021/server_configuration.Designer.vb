<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class server_configuration
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.sql_password = New System.Windows.Forms.TextBox()
        Me.Sql_Server_name = New System.Windows.Forms.TextBox()
        Me.sql_username = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Windows_server_name = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Windows_authentication = New MaterialSkin.Controls.MaterialRadioButton()
        Me.sqlServerAuthentication = New MaterialSkin.Controls.MaterialRadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.clear_printer = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.save_printer = New FontAwesome.Sharp.IconButton()
        Me.txtSavedPrinter = New System.Windows.Forms.TextBox()
        Me.cmbPrinter = New MetroFramework.Controls.MetroComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Panel8)
        Me.GroupBox6.Controls.Add(Me.Panel7)
        Me.GroupBox6.Controls.Add(Me.Windows_authentication)
        Me.GroupBox6.Controls.Add(Me.sqlServerAuthentication)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(617, 259)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "System Connection Settings"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.Controls.Add(Me.Label19)
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Controls.Add(Me.sql_password)
        Me.Panel8.Controls.Add(Me.Sql_Server_name)
        Me.Panel8.Controls.Add(Me.sql_username)
        Me.Panel8.ForeColor = System.Drawing.Color.Indigo
        Me.Panel8.Location = New System.Drawing.Point(9, 69)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(267, 171)
        Me.Panel8.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Server Name:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 108)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 17)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Server Password:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Server Username:"
        '
        'sql_password
        '
        Me.sql_password.Location = New System.Drawing.Point(6, 128)
        Me.sql_password.Name = "sql_password"
        Me.sql_password.Size = New System.Drawing.Size(254, 25)
        Me.sql_password.TabIndex = 5
        Me.sql_password.UseSystemPasswordChar = True
        '
        'Sql_Server_name
        '
        Me.Sql_Server_name.Location = New System.Drawing.Point(6, 24)
        Me.Sql_Server_name.Name = "Sql_Server_name"
        Me.Sql_Server_name.Size = New System.Drawing.Size(254, 25)
        Me.Sql_Server_name.TabIndex = 4
        '
        'sql_username
        '
        Me.sql_username.Location = New System.Drawing.Point(6, 77)
        Me.sql_username.Name = "sql_username"
        Me.sql_username.Size = New System.Drawing.Size(254, 25)
        Me.sql_username.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Windows_server_name)
        Me.Panel7.Controls.Add(Me.Label18)
        Me.Panel7.Enabled = False
        Me.Panel7.ForeColor = System.Drawing.Color.Indigo
        Me.Panel7.Location = New System.Drawing.Point(310, 67)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(285, 84)
        Me.Panel7.TabIndex = 8
        '
        'Windows_server_name
        '
        Me.Windows_server_name.Location = New System.Drawing.Point(16, 27)
        Me.Windows_server_name.Name = "Windows_server_name"
        Me.Windows_server_name.Size = New System.Drawing.Size(262, 25)
        Me.Windows_server_name.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 17)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Server Name:"
        '
        'Windows_authentication
        '
        Me.Windows_authentication.AutoSize = True
        Me.Windows_authentication.Depth = 0
        Me.Windows_authentication.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Windows_authentication.Location = New System.Drawing.Point(312, 31)
        Me.Windows_authentication.Margin = New System.Windows.Forms.Padding(0)
        Me.Windows_authentication.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Windows_authentication.MouseState = MaterialSkin.MouseState.HOVER
        Me.Windows_authentication.Name = "Windows_authentication"
        Me.Windows_authentication.Ripple = True
        Me.Windows_authentication.Size = New System.Drawing.Size(205, 30)
        Me.Windows_authentication.TabIndex = 7
        Me.Windows_authentication.Text = "Use Windows Authentication"
        Me.Windows_authentication.UseVisualStyleBackColor = True
        '
        'sqlServerAuthentication
        '
        Me.sqlServerAuthentication.AutoSize = True
        Me.sqlServerAuthentication.Checked = True
        Me.sqlServerAuthentication.Depth = 0
        Me.sqlServerAuthentication.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.sqlServerAuthentication.Location = New System.Drawing.Point(9, 31)
        Me.sqlServerAuthentication.Margin = New System.Windows.Forms.Padding(0)
        Me.sqlServerAuthentication.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.sqlServerAuthentication.MouseState = MaterialSkin.MouseState.HOVER
        Me.sqlServerAuthentication.Name = "sqlServerAuthentication"
        Me.sqlServerAuthentication.Ripple = True
        Me.sqlServerAuthentication.Size = New System.Drawing.Size(207, 30)
        Me.sqlServerAuthentication.TabIndex = 6
        Me.sqlServerAuthentication.TabStop = True
        Me.sqlServerAuthentication.Text = "Use Sqlserver Authentication"
        Me.sqlServerAuthentication.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.clear_printer)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.save_printer)
        Me.GroupBox3.Controls.Add(Me.txtSavedPrinter)
        Me.GroupBox3.Controls.Add(Me.cmbPrinter)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(10, 267)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(616, 206)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Printer name"
        '
        'clear_printer
        '
        Me.clear_printer.BackColor = System.Drawing.Color.Maroon
        Me.clear_printer.FlatAppearance.BorderSize = 0
        Me.clear_printer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_printer.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.clear_printer.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_printer.ForeColor = System.Drawing.Color.Gainsboro
        Me.clear_printer.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.clear_printer.IconColor = System.Drawing.SystemColors.ControlLight
        Me.clear_printer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clear_printer.IconSize = 25
        Me.clear_printer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.clear_printer.Location = New System.Drawing.Point(461, 158)
        Me.clear_printer.Margin = New System.Windows.Forms.Padding(2)
        Me.clear_printer.Name = "clear_printer"
        Me.clear_printer.Rotation = 0R
        Me.clear_printer.Size = New System.Drawing.Size(125, 27)
        Me.clear_printer.TabIndex = 33
        Me.clear_printer.Text = "Clear Text"
        Me.clear_printer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clear_printer.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Saved Printer :"
        '
        'save_printer
        '
        Me.save_printer.BackColor = System.Drawing.Color.SeaGreen
        Me.save_printer.FlatAppearance.BorderSize = 0
        Me.save_printer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_printer.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.save_printer.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_printer.ForeColor = System.Drawing.Color.Gainsboro
        Me.save_printer.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.save_printer.IconColor = System.Drawing.SystemColors.ControlLight
        Me.save_printer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.save_printer.IconSize = 25
        Me.save_printer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.save_printer.Location = New System.Drawing.Point(287, 158)
        Me.save_printer.Margin = New System.Windows.Forms.Padding(2)
        Me.save_printer.Name = "save_printer"
        Me.save_printer.Rotation = 0R
        Me.save_printer.Size = New System.Drawing.Size(152, 27)
        Me.save_printer.TabIndex = 32
        Me.save_printer.Text = "Save Settings"
        Me.save_printer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.save_printer.UseVisualStyleBackColor = False
        '
        'txtSavedPrinter
        '
        Me.txtSavedPrinter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSavedPrinter.Location = New System.Drawing.Point(154, 32)
        Me.txtSavedPrinter.Name = "txtSavedPrinter"
        Me.txtSavedPrinter.Size = New System.Drawing.Size(435, 25)
        Me.txtSavedPrinter.TabIndex = 8
        '
        'cmbPrinter
        '
        Me.cmbPrinter.FormattingEnabled = True
        Me.cmbPrinter.ItemHeight = 23
        Me.cmbPrinter.Location = New System.Drawing.Point(157, 66)
        Me.cmbPrinter.Name = "cmbPrinter"
        Me.cmbPrinter.PromptText = "Select Printer"
        Me.cmbPrinter.Size = New System.Drawing.Size(429, 29)
        Me.cmbPrinter.TabIndex = 7
        Me.cmbPrinter.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Select New Printer :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'server_configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 481)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "server_configuration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Server Configuration"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents sql_password As TextBox
    Friend WithEvents Sql_Server_name As TextBox
    Friend WithEvents sql_username As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Windows_server_name As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Windows_authentication As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents sqlServerAuthentication As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents clear_printer As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents save_printer As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSavedPrinter As TextBox
    Friend WithEvents cmbPrinter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
