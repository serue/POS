<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_registration
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.name_textbox = New MetroFramework.Controls.MetroTextBox()
        Me.id_number = New MetroFramework.Controls.MetroTextBox()
        Me.address = New MetroFramework.Controls.MetroTextBox()
        Me.age = New MetroFramework.Controls.MetroTextBox()
        Me.email = New MetroFramework.Controls.MetroTextBox()
        Me.phone = New MetroFramework.Controls.MetroTextBox()
        Me.username = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.password = New MetroFramework.Controls.MetroTextBox()
        Me.gender = New MetroFramework.Controls.MetroComboBox()
        Me.IconPictureBox9 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox8 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox10 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox7 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.save_button = New FontAwesome.Sharp.IconButton()
        Me.update_button = New FontAwesome.Sharp.IconButton()
        Me.clear_button = New FontAwesome.Sharp.IconButton()
        CType(Me.IconPictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.MetroLabel1.Location = New System.Drawing.Point(67, 18)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(350, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Administration App  User Registration"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.Red
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(5, 60)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(613, 3)
        Me.MaterialDivider1.TabIndex = 3
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'name_textbox
        '
        '
        '
        '
        Me.name_textbox.CustomButton.Image = Nothing
        Me.name_textbox.CustomButton.Location = New System.Drawing.Point(469, 2)
        Me.name_textbox.CustomButton.Name = ""
        Me.name_textbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.name_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.name_textbox.CustomButton.TabIndex = 1
        Me.name_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.name_textbox.CustomButton.UseSelectable = True
        Me.name_textbox.CustomButton.Visible = False
        Me.name_textbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.name_textbox.Lines = New String(-1) {}
        Me.name_textbox.Location = New System.Drawing.Point(78, 79)
        Me.name_textbox.MaxLength = 32767
        Me.name_textbox.Multiline = True
        Me.name_textbox.Name = "name_textbox"
        Me.name_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.name_textbox.PromptText = "Enter your full name"
        Me.name_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.name_textbox.SelectedText = ""
        Me.name_textbox.SelectionLength = 0
        Me.name_textbox.SelectionStart = 0
        Me.name_textbox.ShortcutsEnabled = True
        Me.name_textbox.Size = New System.Drawing.Size(499, 32)
        Me.name_textbox.TabIndex = 5
        Me.name_textbox.UseSelectable = True
        Me.name_textbox.WaterMark = "Enter your full name"
        Me.name_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.name_textbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'id_number
        '
        '
        '
        '
        Me.id_number.CustomButton.Image = Nothing
        Me.id_number.CustomButton.Location = New System.Drawing.Point(469, 2)
        Me.id_number.CustomButton.Name = ""
        Me.id_number.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.id_number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.id_number.CustomButton.TabIndex = 1
        Me.id_number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.id_number.CustomButton.UseSelectable = True
        Me.id_number.CustomButton.Visible = False
        Me.id_number.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.id_number.Lines = New String(-1) {}
        Me.id_number.Location = New System.Drawing.Point(78, 117)
        Me.id_number.MaxLength = 32767
        Me.id_number.Multiline = True
        Me.id_number.Name = "id_number"
        Me.id_number.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.id_number.PromptText = "Enter your national id number"
        Me.id_number.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.id_number.SelectedText = ""
        Me.id_number.SelectionLength = 0
        Me.id_number.SelectionStart = 0
        Me.id_number.ShortcutsEnabled = True
        Me.id_number.Size = New System.Drawing.Size(499, 32)
        Me.id_number.TabIndex = 6
        Me.id_number.UseSelectable = True
        Me.id_number.WaterMark = "Enter your national id number"
        Me.id_number.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.id_number.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'address
        '
        '
        '
        '
        Me.address.CustomButton.Image = Nothing
        Me.address.CustomButton.Location = New System.Drawing.Point(469, 2)
        Me.address.CustomButton.Name = ""
        Me.address.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.address.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.address.CustomButton.TabIndex = 1
        Me.address.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.address.CustomButton.UseSelectable = True
        Me.address.CustomButton.Visible = False
        Me.address.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.address.Lines = New String(-1) {}
        Me.address.Location = New System.Drawing.Point(78, 155)
        Me.address.MaxLength = 32767
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.address.PromptText = "Enter your address"
        Me.address.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.address.SelectedText = ""
        Me.address.SelectionLength = 0
        Me.address.SelectionStart = 0
        Me.address.ShortcutsEnabled = True
        Me.address.Size = New System.Drawing.Size(499, 32)
        Me.address.TabIndex = 7
        Me.address.UseSelectable = True
        Me.address.WaterMark = "Enter your address"
        Me.address.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.address.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'age
        '
        '
        '
        '
        Me.age.CustomButton.Image = Nothing
        Me.age.CustomButton.Location = New System.Drawing.Point(469, 2)
        Me.age.CustomButton.Name = ""
        Me.age.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.age.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.age.CustomButton.TabIndex = 1
        Me.age.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.age.CustomButton.UseSelectable = True
        Me.age.CustomButton.Visible = False
        Me.age.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.age.Lines = New String(-1) {}
        Me.age.Location = New System.Drawing.Point(78, 193)
        Me.age.MaxLength = 32767
        Me.age.Multiline = True
        Me.age.Name = "age"
        Me.age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.age.PromptText = "Enter your age"
        Me.age.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.age.SelectedText = ""
        Me.age.SelectionLength = 0
        Me.age.SelectionStart = 0
        Me.age.ShortcutsEnabled = True
        Me.age.Size = New System.Drawing.Size(499, 32)
        Me.age.TabIndex = 8
        Me.age.UseSelectable = True
        Me.age.WaterMark = "Enter your age"
        Me.age.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.age.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'email
        '
        '
        '
        '
        Me.email.CustomButton.Image = Nothing
        Me.email.CustomButton.Location = New System.Drawing.Point(469, 2)
        Me.email.CustomButton.Name = ""
        Me.email.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.email.CustomButton.TabIndex = 1
        Me.email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.email.CustomButton.UseSelectable = True
        Me.email.CustomButton.Visible = False
        Me.email.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.email.Lines = New String(-1) {}
        Me.email.Location = New System.Drawing.Point(78, 307)
        Me.email.MaxLength = 32767
        Me.email.Multiline = True
        Me.email.Name = "email"
        Me.email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.email.PromptText = "Enter your email address"
        Me.email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.email.SelectedText = ""
        Me.email.SelectionLength = 0
        Me.email.SelectionStart = 0
        Me.email.ShortcutsEnabled = True
        Me.email.Size = New System.Drawing.Size(499, 32)
        Me.email.TabIndex = 11
        Me.email.UseSelectable = True
        Me.email.WaterMark = "Enter your email address"
        Me.email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'phone
        '
        '
        '
        '
        Me.phone.CustomButton.Image = Nothing
        Me.phone.CustomButton.Location = New System.Drawing.Point(469, 2)
        Me.phone.CustomButton.Name = ""
        Me.phone.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.phone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.phone.CustomButton.TabIndex = 1
        Me.phone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.phone.CustomButton.UseSelectable = True
        Me.phone.CustomButton.Visible = False
        Me.phone.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.phone.Lines = New String(-1) {}
        Me.phone.Location = New System.Drawing.Point(78, 269)
        Me.phone.MaxLength = 32767
        Me.phone.Multiline = True
        Me.phone.Name = "phone"
        Me.phone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phone.PromptText = "Enter your phone number"
        Me.phone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.phone.SelectedText = ""
        Me.phone.SelectionLength = 0
        Me.phone.SelectionStart = 0
        Me.phone.ShortcutsEnabled = True
        Me.phone.Size = New System.Drawing.Size(499, 32)
        Me.phone.TabIndex = 10
        Me.phone.UseSelectable = True
        Me.phone.WaterMark = "Enter your phone number"
        Me.phone.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.phone.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'username
        '
        '
        '
        '
        Me.username.CustomButton.Image = Nothing
        Me.username.CustomButton.Location = New System.Drawing.Point(469, 2)
        Me.username.CustomButton.Name = ""
        Me.username.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.username.CustomButton.TabIndex = 1
        Me.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.username.CustomButton.UseSelectable = True
        Me.username.CustomButton.Visible = False
        Me.username.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.username.Lines = New String(-1) {}
        Me.username.Location = New System.Drawing.Point(78, 345)
        Me.username.MaxLength = 32767
        Me.username.Multiline = True
        Me.username.Name = "username"
        Me.username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username.PromptText = "Enter your username"
        Me.username.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.username.SelectedText = ""
        Me.username.SelectionLength = 0
        Me.username.SelectionStart = 0
        Me.username.ShortcutsEnabled = True
        Me.username.Size = New System.Drawing.Size(499, 32)
        Me.username.TabIndex = 12
        Me.username.UseSelectable = True
        Me.username.WaterMark = "Enter your username"
        Me.username.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.username.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 467)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Already have an Account?"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(284, 465)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(98, 25)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "login here"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'password
        '
        '
        '
        '
        Me.password.CustomButton.Image = Nothing
        Me.password.CustomButton.Location = New System.Drawing.Point(469, 2)
        Me.password.CustomButton.Name = ""
        Me.password.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.password.CustomButton.TabIndex = 1
        Me.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.password.CustomButton.UseSelectable = True
        Me.password.CustomButton.Visible = False
        Me.password.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.password.Lines = New String(-1) {}
        Me.password.Location = New System.Drawing.Point(78, 383)
        Me.password.MaxLength = 32767
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.PromptText = "Enter your password"
        Me.password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.password.SelectedText = ""
        Me.password.SelectionLength = 0
        Me.password.SelectionStart = 0
        Me.password.ShortcutsEnabled = True
        Me.password.Size = New System.Drawing.Size(499, 32)
        Me.password.TabIndex = 13
        Me.password.UseSelectable = True
        Me.password.WaterMark = "Enter your password"
        Me.password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'gender
        '
        Me.gender.FormattingEnabled = True
        Me.gender.ItemHeight = 24
        Me.gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.gender.Location = New System.Drawing.Point(78, 231)
        Me.gender.Name = "gender"
        Me.gender.PromptText = "Select Gender"
        Me.gender.Size = New System.Drawing.Size(499, 30)
        Me.gender.TabIndex = 9
        Me.gender.UseSelectable = True
        '
        'IconPictureBox9
        '
        Me.IconPictureBox9.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox9.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.IconPictureBox9.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox9.Location = New System.Drawing.Point(40, 384)
        Me.IconPictureBox9.Name = "IconPictureBox9"
        Me.IconPictureBox9.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox9.TabIndex = 4
        Me.IconPictureBox9.TabStop = False
        '
        'IconPictureBox8
        '
        Me.IconPictureBox8.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox8.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.UserLock
        Me.IconPictureBox8.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox8.Location = New System.Drawing.Point(40, 346)
        Me.IconPictureBox8.Name = "IconPictureBox8"
        Me.IconPictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox8.TabIndex = 4
        Me.IconPictureBox8.TabStop = False
        '
        'IconPictureBox10
        '
        Me.IconPictureBox10.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox10.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox10.IconChar = FontAwesome.Sharp.IconChar.Male
        Me.IconPictureBox10.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox10.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox10.Location = New System.Drawing.Point(40, 232)
        Me.IconPictureBox10.Name = "IconPictureBox10"
        Me.IconPictureBox10.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox10.TabIndex = 4
        Me.IconPictureBox10.TabStop = False
        '
        'IconPictureBox7
        '
        Me.IconPictureBox7.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox7.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Phone
        Me.IconPictureBox7.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox7.Location = New System.Drawing.Point(40, 270)
        Me.IconPictureBox7.Name = "IconPictureBox7"
        Me.IconPictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox7.TabIndex = 4
        Me.IconPictureBox7.TabStop = False
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox5.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Info
        Me.IconPictureBox5.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox5.Location = New System.Drawing.Point(40, 194)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox5.TabIndex = 4
        Me.IconPictureBox5.TabStop = False
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.IdCard
        Me.IconPictureBox3.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.Location = New System.Drawing.Point(40, 118)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox3.TabIndex = 4
        Me.IconPictureBox3.TabStop = False
        '
        'IconPictureBox6
        '
        Me.IconPictureBox6.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox6.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.At
        Me.IconPictureBox6.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox6.Location = New System.Drawing.Point(40, 308)
        Me.IconPictureBox6.Name = "IconPictureBox6"
        Me.IconPictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox6.TabIndex = 4
        Me.IconPictureBox6.TabStop = False
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.IconPictureBox4.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.Location = New System.Drawing.Point(40, 156)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox4.TabIndex = 4
        Me.IconPictureBox4.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconPictureBox2.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.Location = New System.Drawing.Point(40, 80)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox2.TabIndex = 4
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BookOpen
        Me.IconPictureBox1.IconColor = System.Drawing.Color.MediumVioletRed
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 39
        Me.IconPictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(49, 39)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'save_button
        '
        Me.save_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_button.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.save_button.IconColor = System.Drawing.Color.DarkSlateBlue
        Me.save_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.save_button.IconSize = 25
        Me.save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_button.Location = New System.Drawing.Point(89, 530)
        Me.save_button.Name = "save_button"
        Me.save_button.Size = New System.Drawing.Size(161, 41)
        Me.save_button.TabIndex = 16
        Me.save_button.Text = "Add New User"
        Me.save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.save_button.UseVisualStyleBackColor = True
        '
        'update_button
        '
        Me.update_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_button.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.update_button.IconColor = System.Drawing.Color.Navy
        Me.update_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.update_button.IconSize = 25
        Me.update_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.update_button.Location = New System.Drawing.Point(278, 530)
        Me.update_button.Name = "update_button"
        Me.update_button.Size = New System.Drawing.Size(161, 41)
        Me.update_button.TabIndex = 17
        Me.update_button.Text = "Update User"
        Me.update_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.update_button.UseVisualStyleBackColor = True
        '
        'clear_button
        '
        Me.clear_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_button.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.clear_button.IconColor = System.Drawing.Color.DarkRed
        Me.clear_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clear_button.IconSize = 25
        Me.clear_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.clear_button.Location = New System.Drawing.Point(463, 530)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Size = New System.Drawing.Size(114, 41)
        Me.clear_button.TabIndex = 18
        Me.clear_button.Text = "Clear"
        Me.clear_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clear_button.UseVisualStyleBackColor = True
        '
        'user_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 609)
        Me.Controls.Add(Me.clear_button)
        Me.Controls.Add(Me.update_button)
        Me.Controls.Add(Me.save_button)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.IconPictureBox9)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.IconPictureBox8)
        Me.Controls.Add(Me.id_number)
        Me.Controls.Add(Me.IconPictureBox10)
        Me.Controls.Add(Me.IconPictureBox7)
        Me.Controls.Add(Me.IconPictureBox5)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.IconPictureBox3)
        Me.Controls.Add(Me.IconPictureBox6)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.IconPictureBox4)
        Me.Controls.Add(Me.name_textbox)
        Me.Controls.Add(Me.IconPictureBox2)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "user_registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beymo Technologies"
        CType(Me.IconPictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents name_textbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents id_number As MetroFramework.Controls.MetroTextBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents address As MetroFramework.Controls.MetroTextBox
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents age As MetroFramework.Controls.MetroTextBox
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents IconPictureBox7 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox8 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents phone As MetroFramework.Controls.MetroTextBox
    Friend WithEvents username As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents IconPictureBox9 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents IconPictureBox10 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents gender As MetroFramework.Controls.MetroComboBox
    Friend WithEvents save_button As FontAwesome.Sharp.IconButton
    Friend WithEvents update_button As FontAwesome.Sharp.IconButton
    Friend WithEvents clear_button As FontAwesome.Sharp.IconButton
End Class
