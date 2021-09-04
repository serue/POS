<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_user_accounts
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.show_pass = New MaterialSkin.Controls.MaterialCheckBox()
        Me.cancel_button = New FontAwesome.Sharp.IconButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.clear_button = New FontAwesome.Sharp.IconButton()
        Me.confirm_password = New MetroFramework.Controls.MetroTextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.save_button = New FontAwesome.Sharp.IconButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.password = New MetroFramework.Controls.MetroTextBox()
        Me.username = New MetroFramework.Controls.MetroTextBox()
        Me.IconPictureBox8 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox9 = New FontAwesome.Sharp.IconPictureBox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.show_pass)
        Me.GroupBox1.Controls.Add(Me.cancel_button)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.clear_button)
        Me.GroupBox1.Controls.Add(Me.confirm_password)
        Me.GroupBox1.Controls.Add(Me.IconPictureBox1)
        Me.GroupBox1.Controls.Add(Me.save_button)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Controls.Add(Me.IconPictureBox8)
        Me.GroupBox1.Controls.Add(Me.IconPictureBox9)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 201)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update User Account"
        '
        'show_pass
        '
        Me.show_pass.AutoSize = True
        Me.show_pass.Depth = 0
        Me.show_pass.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.show_pass.Location = New System.Drawing.Point(213, 121)
        Me.show_pass.Margin = New System.Windows.Forms.Padding(0)
        Me.show_pass.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.show_pass.MouseState = MaterialSkin.MouseState.HOVER
        Me.show_pass.Name = "show_pass"
        Me.show_pass.Ripple = True
        Me.show_pass.Size = New System.Drawing.Size(127, 30)
        Me.show_pass.TabIndex = 9
        Me.show_pass.Text = "Show password"
        Me.show_pass.UseVisualStyleBackColor = True
        '
        'cancel_button
        '
        Me.cancel_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.cancel_button.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_button.IconChar = FontAwesome.Sharp.IconChar.Xbox
        Me.cancel_button.IconColor = System.Drawing.Color.DarkRed
        Me.cancel_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cancel_button.IconSize = 20
        Me.cancel_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.cancel_button.Location = New System.Drawing.Point(223, 157)
        Me.cancel_button.Margin = New System.Windows.Forms.Padding(2)
        Me.cancel_button.Name = "cancel_button"
        Me.cancel_button.Rotation = 0R
        Me.cancel_button.Size = New System.Drawing.Size(92, 33)
        Me.cancel_button.TabIndex = 6
        Me.cancel_button.Text = "Cancel"
        Me.cancel_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cancel_button.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Confirm New Password:"
        '
        'clear_button
        '
        Me.clear_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.clear_button.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_button.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.clear_button.IconColor = System.Drawing.Color.DarkRed
        Me.clear_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clear_button.IconSize = 20
        Me.clear_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.clear_button.Location = New System.Drawing.Point(319, 157)
        Me.clear_button.Margin = New System.Windows.Forms.Padding(2)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Rotation = 0R
        Me.clear_button.Size = New System.Drawing.Size(79, 33)
        Me.clear_button.TabIndex = 5
        Me.clear_button.Text = "Clear"
        Me.clear_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clear_button.UseVisualStyleBackColor = True
        '
        'confirm_password
        '
        Me.confirm_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.confirm_password.CustomButton.Image = Nothing
        Me.confirm_password.CustomButton.Location = New System.Drawing.Point(350, 2)
        Me.confirm_password.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.confirm_password.CustomButton.Name = ""
        Me.confirm_password.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.confirm_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.confirm_password.CustomButton.TabIndex = 1
        Me.confirm_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.confirm_password.CustomButton.UseSelectable = True
        Me.confirm_password.CustomButton.Visible = False
        Me.confirm_password.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.confirm_password.Lines = New String(-1) {}
        Me.confirm_password.Location = New System.Drawing.Point(184, 85)
        Me.confirm_password.Margin = New System.Windows.Forms.Padding(2)
        Me.confirm_password.MaxLength = 32767
        Me.confirm_password.Multiline = True
        Me.confirm_password.Name = "confirm_password"
        Me.confirm_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirm_password.PromptText = "Confirm your new password"
        Me.confirm_password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.confirm_password.SelectedText = ""
        Me.confirm_password.SelectionLength = 0
        Me.confirm_password.SelectionStart = 0
        Me.confirm_password.ShortcutsEnabled = True
        Me.confirm_password.Size = New System.Drawing.Size(374, 26)
        Me.confirm_password.TabIndex = 3
        Me.confirm_password.UseSelectable = True
        Me.confirm_password.WaterMark = "Confirm your new password"
        Me.confirm_password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.confirm_password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 24
        Me.IconPictureBox1.Location = New System.Drawing.Point(156, 86)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(24, 26)
        Me.IconPictureBox1.TabIndex = 22
        Me.IconPictureBox1.TabStop = False
        '
        'save_button
        '
        Me.save_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.save_button.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_button.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.save_button.IconColor = System.Drawing.Color.DarkSlateBlue
        Me.save_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.save_button.IconSize = 25
        Me.save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_button.Location = New System.Drawing.Point(402, 157)
        Me.save_button.Margin = New System.Windows.Forms.Padding(2)
        Me.save_button.Name = "save_button"
        Me.save_button.Rotation = 0R
        Me.save_button.Size = New System.Drawing.Size(145, 33)
        Me.save_button.TabIndex = 4
        Me.save_button.Text = "Update Account"
        Me.save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.save_button.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Enter New Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Enter Username:"
        '
        'password
        '
        Me.password.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.password.CustomButton.Image = Nothing
        Me.password.CustomButton.Location = New System.Drawing.Point(350, 2)
        Me.password.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.password.CustomButton.Name = ""
        Me.password.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.password.CustomButton.TabIndex = 1
        Me.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.password.CustomButton.UseSelectable = True
        Me.password.CustomButton.Visible = False
        Me.password.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.password.Lines = New String(-1) {}
        Me.password.Location = New System.Drawing.Point(183, 55)
        Me.password.Margin = New System.Windows.Forms.Padding(2)
        Me.password.MaxLength = 32767
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.PromptText = "Enter your new password"
        Me.password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.password.SelectedText = ""
        Me.password.SelectionLength = 0
        Me.password.SelectionStart = 0
        Me.password.ShortcutsEnabled = True
        Me.password.Size = New System.Drawing.Size(374, 26)
        Me.password.TabIndex = 2
        Me.password.UseSelectable = True
        Me.password.WaterMark = "Enter your new password"
        Me.password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'username
        '
        Me.username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.username.CustomButton.Image = Nothing
        Me.username.CustomButton.Location = New System.Drawing.Point(350, 2)
        Me.username.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.username.CustomButton.Name = ""
        Me.username.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.username.CustomButton.TabIndex = 1
        Me.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.username.CustomButton.UseSelectable = True
        Me.username.CustomButton.Visible = False
        Me.username.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.username.Lines = New String(-1) {}
        Me.username.Location = New System.Drawing.Point(183, 25)
        Me.username.Margin = New System.Windows.Forms.Padding(2)
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
        Me.username.Size = New System.Drawing.Size(374, 26)
        Me.username.TabIndex = 0
        Me.username.UseSelectable = True
        Me.username.WaterMark = "Enter your username"
        Me.username.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.username.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'IconPictureBox8
        '
        Me.IconPictureBox8.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox8.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.UserLock
        Me.IconPictureBox8.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox8.IconSize = 24
        Me.IconPictureBox8.Location = New System.Drawing.Point(155, 26)
        Me.IconPictureBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.IconPictureBox8.Name = "IconPictureBox8"
        Me.IconPictureBox8.Size = New System.Drawing.Size(24, 26)
        Me.IconPictureBox8.TabIndex = 4
        Me.IconPictureBox8.TabStop = False
        '
        'IconPictureBox9
        '
        Me.IconPictureBox9.BackColor = System.Drawing.SystemColors.Control
        Me.IconPictureBox9.ForeColor = System.Drawing.Color.Indigo
        Me.IconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.IconPictureBox9.IconColor = System.Drawing.Color.Indigo
        Me.IconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox9.IconSize = 24
        Me.IconPictureBox9.Location = New System.Drawing.Point(155, 56)
        Me.IconPictureBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.IconPictureBox9.Name = "IconPictureBox9"
        Me.IconPictureBox9.Size = New System.Drawing.Size(24, 26)
        Me.IconPictureBox9.TabIndex = 4
        Me.IconPictureBox9.TabStop = False
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.Red
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialDivider1.Margin = New System.Windows.Forms.Padding(2)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(587, 2)
        Me.MaterialDivider1.TabIndex = 22
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'update_user_accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 219)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "update_user_accounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update your user Account"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents clear_button As FontAwesome.Sharp.IconButton
    Friend WithEvents confirm_password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents save_button As FontAwesome.Sharp.IconButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents username As MetroFramework.Controls.MetroTextBox
    Friend WithEvents IconPictureBox8 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox9 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents cancel_button As FontAwesome.Sharp.IconButton
    Friend WithEvents show_pass As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
