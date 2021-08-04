<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class company
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.minimise_button = New FontAwesome.Sharp.IconButton()
        Me.close_button = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.clear_button = New FontAwesome.Sharp.IconButton()
        Me.edit_details = New FontAwesome.Sharp.IconButton()
        Me.save_item = New FontAwesome.Sharp.IconButton()
        Me.TRADE_TEXTBOX = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.contact_textbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.description_textbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.address_textbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.name_textbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.minimise_button)
        Me.Panel1.Controls.Add(Me.close_button)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 55)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.POS_2021.My.Resources.Resources.Company_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(8, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'minimise_button
        '
        Me.minimise_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimise_button.FlatAppearance.BorderSize = 0
        Me.minimise_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimise_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.minimise_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.minimise_button.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.minimise_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.minimise_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.minimise_button.IconSize = 35
        Me.minimise_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.minimise_button.Location = New System.Drawing.Point(796, 9)
        Me.minimise_button.Name = "minimise_button"
        Me.minimise_button.Rotation = 0R
        Me.minimise_button.Size = New System.Drawing.Size(30, 30)
        Me.minimise_button.TabIndex = 12
        Me.minimise_button.UseVisualStyleBackColor = True
        '
        'close_button
        '
        Me.close_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_button.FlatAppearance.BorderSize = 0
        Me.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.close_button.ForeColor = System.Drawing.SystemColors.ControlText
        Me.close_button.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.close_button.IconColor = System.Drawing.Color.Snow
        Me.close_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.close_button.IconSize = 35
        Me.close_button.Location = New System.Drawing.Point(840, 9)
        Me.close_button.Name = "close_button"
        Me.close_button.Rotation = 0R
        Me.close_button.Size = New System.Drawing.Size(30, 30)
        Me.close_button.TabIndex = 12
        Me.close_button.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label6.Location = New System.Drawing.Point(53, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(416, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Shopwise POS Company Reagistration"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.clear_button)
        Me.Panel2.Controls.Add(Me.edit_details)
        Me.Panel2.Controls.Add(Me.save_item)
        Me.Panel2.Controls.Add(Me.TRADE_TEXTBOX)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.contact_textbox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.description_textbox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.address_textbox)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.name_textbox)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 486)
        Me.Panel2.TabIndex = 3
        '
        'clear_button
        '
        Me.clear_button.BackColor = System.Drawing.Color.SteelBlue
        Me.clear_button.FlatAppearance.BorderSize = 0
        Me.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.clear_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_button.ForeColor = System.Drawing.Color.Gainsboro
        Me.clear_button.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.clear_button.IconColor = System.Drawing.SystemColors.ControlLight
        Me.clear_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clear_button.IconSize = 30
        Me.clear_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.clear_button.Location = New System.Drawing.Point(655, 418)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Rotation = 0R
        Me.clear_button.Size = New System.Drawing.Size(174, 45)
        Me.clear_button.TabIndex = 7
        Me.clear_button.Text = "CLEAR TEXT"
        Me.clear_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clear_button.UseVisualStyleBackColor = False
        '
        'edit_details
        '
        Me.edit_details.BackColor = System.Drawing.Color.Olive
        Me.edit_details.FlatAppearance.BorderSize = 0
        Me.edit_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_details.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.edit_details.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_details.ForeColor = System.Drawing.Color.Gainsboro
        Me.edit_details.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.edit_details.IconColor = System.Drawing.SystemColors.ControlLight
        Me.edit_details.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_details.IconSize = 30
        Me.edit_details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit_details.Location = New System.Drawing.Point(446, 418)
        Me.edit_details.Name = "edit_details"
        Me.edit_details.Rotation = 0R
        Me.edit_details.Size = New System.Drawing.Size(174, 45)
        Me.edit_details.TabIndex = 6
        Me.edit_details.Text = "EDIT DETAILS"
        Me.edit_details.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.edit_details.UseVisualStyleBackColor = False
        '
        'save_item
        '
        Me.save_item.BackColor = System.Drawing.Color.SeaGreen
        Me.save_item.FlatAppearance.BorderSize = 0
        Me.save_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_item.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.save_item.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_item.ForeColor = System.Drawing.Color.Gainsboro
        Me.save_item.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.save_item.IconColor = System.Drawing.SystemColors.ControlLight
        Me.save_item.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.save_item.IconSize = 30
        Me.save_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_item.Location = New System.Drawing.Point(249, 418)
        Me.save_item.Name = "save_item"
        Me.save_item.Rotation = 0R
        Me.save_item.Size = New System.Drawing.Size(174, 45)
        Me.save_item.TabIndex = 5
        Me.save_item.Text = "SAVE INFO"
        Me.save_item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.save_item.UseVisualStyleBackColor = False
        '
        'TRADE_TEXTBOX
        '
        Me.TRADE_TEXTBOX.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRADE_TEXTBOX.ForeColor = System.Drawing.Color.SaddleBrown
        Me.TRADE_TEXTBOX.Location = New System.Drawing.Point(249, 80)
        Me.TRADE_TEXTBOX.Name = "TRADE_TEXTBOX"
        Me.TRADE_TEXTBOX.Size = New System.Drawing.Size(580, 35)
        Me.TRADE_TEXTBOX.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(23, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "COMPANY TRADE NAME:"
        '
        'contact_textbox
        '
        Me.contact_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.contact_textbox.Location = New System.Drawing.Point(249, 340)
        Me.contact_textbox.Name = "contact_textbox"
        Me.contact_textbox.Size = New System.Drawing.Size(580, 35)
        Me.contact_textbox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(32, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "COMPANY CONTACTS:"
        '
        'description_textbox
        '
        Me.description_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.description_textbox.Location = New System.Drawing.Point(249, 239)
        Me.description_textbox.Multiline = True
        Me.description_textbox.Name = "description_textbox"
        Me.description_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.description_textbox.Size = New System.Drawing.Size(580, 65)
        Me.description_textbox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(24, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "COMPANY DESCRIPTION:"
        '
        'address_textbox
        '
        Me.address_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.address_textbox.Location = New System.Drawing.Point(249, 143)
        Me.address_textbox.Multiline = True
        Me.address_textbox.Name = "address_textbox"
        Me.address_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.address_textbox.Size = New System.Drawing.Size(580, 73)
        Me.address_textbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(32, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "COMPANY ADDRESS:"
        '
        'name_textbox
        '
        Me.name_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.name_textbox.Location = New System.Drawing.Point(249, 16)
        Me.name_textbox.Name = "name_textbox"
        Me.name_textbox.Size = New System.Drawing.Size(580, 35)
        Me.name_textbox.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(32, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "COMPANY NAME:"
        '
        'company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 541)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "company"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "company"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents minimise_button As FontAwesome.Sharp.IconButton
    Friend WithEvents close_button As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TRADE_TEXTBOX As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents contact_textbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents description_textbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents address_textbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents name_textbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clear_button As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_details As FontAwesome.Sharp.IconButton
    Friend WithEvents save_item As FontAwesome.Sharp.IconButton
End Class
