<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sign_in
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
        Me.username_textbox = New MetroFramework.Controls.MetroTextBox()
        Me.password_textbox = New MetroFramework.Controls.MetroTextBox()
        Me.login_button = New MetroFramework.Controls.MetroButton()
        Me.Clear_button = New MetroFramework.Controls.MetroButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'username_textbox
        '
        '
        '
        '
        Me.username_textbox.CustomButton.Image = Nothing
        Me.username_textbox.CustomButton.Location = New System.Drawing.Point(335, 2)
        Me.username_textbox.CustomButton.Name = ""
        Me.username_textbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.username_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.username_textbox.CustomButton.TabIndex = 1
        Me.username_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.username_textbox.CustomButton.UseSelectable = True
        Me.username_textbox.CustomButton.Visible = False
        Me.username_textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.username_textbox.Lines = New String(-1) {}
        Me.username_textbox.Location = New System.Drawing.Point(144, 12)
        Me.username_textbox.MaxLength = 32767
        Me.username_textbox.Multiline = True
        Me.username_textbox.Name = "username_textbox"
        Me.username_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username_textbox.PromptText = "Username"
        Me.username_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.username_textbox.SelectedText = ""
        Me.username_textbox.SelectionLength = 0
        Me.username_textbox.SelectionStart = 0
        Me.username_textbox.ShortcutsEnabled = True
        Me.username_textbox.ShowClearButton = True
        Me.username_textbox.Size = New System.Drawing.Size(365, 32)
        Me.username_textbox.TabIndex = 6
        Me.username_textbox.UseSelectable = True
        Me.username_textbox.WaterMark = "Username"
        Me.username_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.username_textbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        Me.username_textbox.WithError = True
        '
        'password_textbox
        '
        '
        '
        '
        Me.password_textbox.CustomButton.Image = Nothing
        Me.password_textbox.CustomButton.Location = New System.Drawing.Point(335, 2)
        Me.password_textbox.CustomButton.Name = ""
        Me.password_textbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.password_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.password_textbox.CustomButton.TabIndex = 1
        Me.password_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.password_textbox.CustomButton.UseSelectable = True
        Me.password_textbox.CustomButton.Visible = False
        Me.password_textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.password_textbox.Lines = New String(-1) {}
        Me.password_textbox.Location = New System.Drawing.Point(142, 67)
        Me.password_textbox.MaxLength = 32767
        Me.password_textbox.Multiline = True
        Me.password_textbox.Name = "password_textbox"
        Me.password_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_textbox.PromptText = "Password"
        Me.password_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.password_textbox.SelectedText = ""
        Me.password_textbox.SelectionLength = 0
        Me.password_textbox.SelectionStart = 0
        Me.password_textbox.ShortcutsEnabled = True
        Me.password_textbox.ShowClearButton = True
        Me.password_textbox.Size = New System.Drawing.Size(365, 32)
        Me.password_textbox.TabIndex = 7
        Me.password_textbox.UseSelectable = True
        Me.password_textbox.WaterMark = "Password"
        Me.password_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.password_textbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        Me.password_textbox.WithError = True
        '
        'login_button
        '
        Me.login_button.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.login_button.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.login_button.Location = New System.Drawing.Point(142, 140)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(168, 34)
        Me.login_button.TabIndex = 8
        Me.login_button.Text = "Login"
        Me.login_button.UseSelectable = True
        '
        'Clear_button
        '
        Me.Clear_button.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.Clear_button.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.Clear_button.Location = New System.Drawing.Point(326, 140)
        Me.Clear_button.Name = "Clear_button"
        Me.Clear_button.Size = New System.Drawing.Size(168, 34)
        Me.Clear_button.TabIndex = 9
        Me.Clear_button.Text = "Clear"
        Me.Clear_button.UseSelectable = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(349, 112)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(138, 25)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "create Account"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Do not have an Account?"
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.Gray
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Lock
        Me.IconPictureBox3.IconColor = System.Drawing.Color.Gray
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.Location = New System.Drawing.Point(110, 67)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox3.TabIndex = 5
        Me.IconPictureBox3.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconPictureBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 30
        Me.IconPictureBox2.Location = New System.Drawing.Point(114, 12)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(30, 32)
        Me.IconPictureBox2.TabIndex = 4
        Me.IconPictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PASSWORD"
        '
        'sign_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 187)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Clear_button)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.password_textbox)
        Me.Controls.Add(Me.username_textbox)
        Me.Controls.Add(Me.IconPictureBox3)
        Me.Controls.Add(Me.IconPictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sign_in"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN SYSTEM"
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents username_textbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents password_textbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents login_button As MetroFramework.Controls.MetroButton
    Friend WithEvents Clear_button As MetroFramework.Controls.MetroButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
