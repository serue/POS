<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class categories
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.notes_textbox = New System.Windows.Forms.TextBox()
        Me.save_item = New FontAwesome.Sharp.IconButton()
        Me.edit_details = New FontAwesome.Sharp.IconButton()
        Me.clear_button = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_subcategory2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 3)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(18, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Main Category:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(18, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Main Category Notes:"
        '
        'notes_textbox
        '
        Me.notes_textbox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notes_textbox.Location = New System.Drawing.Point(161, 84)
        Me.notes_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.notes_textbox.Multiline = True
        Me.notes_textbox.Name = "notes_textbox"
        Me.notes_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.notes_textbox.Size = New System.Drawing.Size(322, 61)
        Me.notes_textbox.TabIndex = 4
        '
        'save_item
        '
        Me.save_item.BackColor = System.Drawing.Color.SeaGreen
        Me.save_item.FlatAppearance.BorderSize = 0
        Me.save_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_item.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.save_item.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_item.ForeColor = System.Drawing.Color.Gainsboro
        Me.save_item.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.save_item.IconColor = System.Drawing.SystemColors.ControlLight
        Me.save_item.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.save_item.IconSize = 25
        Me.save_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_item.Location = New System.Drawing.Point(313, 159)
        Me.save_item.Margin = New System.Windows.Forms.Padding(2)
        Me.save_item.Name = "save_item"
        Me.save_item.Rotation = 0R
        Me.save_item.Size = New System.Drawing.Size(170, 28)
        Me.save_item.TabIndex = 24
        Me.save_item.Text = "Save New Category"
        Me.save_item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.save_item.UseVisualStyleBackColor = False
        '
        'edit_details
        '
        Me.edit_details.BackColor = System.Drawing.Color.Olive
        Me.edit_details.FlatAppearance.BorderSize = 0
        Me.edit_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_details.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.edit_details.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_details.ForeColor = System.Drawing.Color.Gainsboro
        Me.edit_details.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.edit_details.IconColor = System.Drawing.SystemColors.ControlLight
        Me.edit_details.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_details.IconSize = 25
        Me.edit_details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit_details.Location = New System.Drawing.Point(154, 159)
        Me.edit_details.Margin = New System.Windows.Forms.Padding(2)
        Me.edit_details.Name = "edit_details"
        Me.edit_details.Rotation = 0R
        Me.edit_details.Size = New System.Drawing.Size(155, 28)
        Me.edit_details.TabIndex = 25
        Me.edit_details.Text = "Edit Category"
        Me.edit_details.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.edit_details.UseVisualStyleBackColor = False
        '
        'clear_button
        '
        Me.clear_button.BackColor = System.Drawing.Color.DarkRed
        Me.clear_button.FlatAppearance.BorderSize = 0
        Me.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.clear_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_button.ForeColor = System.Drawing.Color.Gainsboro
        Me.clear_button.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.clear_button.IconColor = System.Drawing.SystemColors.ControlLight
        Me.clear_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clear_button.IconSize = 25
        Me.clear_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.clear_button.Location = New System.Drawing.Point(372, 89)
        Me.clear_button.Margin = New System.Windows.Forms.Padding(2)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Rotation = 0R
        Me.clear_button.Size = New System.Drawing.Size(109, 28)
        Me.clear_button.TabIndex = 27
        Me.clear_button.Text = "Clear"
        Me.clear_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clear_button.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_category)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.edit_details)
        Me.GroupBox1.Controls.Add(Me.save_item)
        Me.GroupBox1.Controls.Add(Me.notes_textbox)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 202)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mandatory Main Categories"
        '
        'cmb_category
        '
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(161, 39)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(320, 25)
        Me.cmb_category.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IconButton2)
        Me.GroupBox2.Controls.Add(Me.IconButton1)
        Me.GroupBox2.Controls.Add(Me.cmb_subcategory2)
        Me.GroupBox2.Controls.Add(Me.clear_button)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 153)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Optional Sub Categories"
        '
        'cmb_subcategory2
        '
        Me.cmb_subcategory2.FormattingEnabled = True
        Me.cmb_subcategory2.Location = New System.Drawing.Point(158, 28)
        Me.cmb_subcategory2.Name = "cmb_subcategory2"
        Me.cmb_subcategory2.Size = New System.Drawing.Size(322, 25)
        Me.cmb_subcategory2.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sub Category :"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.SeaGreen
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.IconButton1.IconColor = System.Drawing.SystemColors.ControlLight
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 25
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(38, 89)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(170, 28)
        Me.IconButton1.TabIndex = 29
        Me.IconButton1.Text = "Save Sub Category"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Olive
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.IconButton2.IconColor = System.Drawing.SystemColors.ControlLight
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 25
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(213, 89)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(155, 28)
        Me.IconButton2.TabIndex = 26
        Me.IconButton2.Text = "Edit Category"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox3.Location = New System.Drawing.Point(524, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 199)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Added Main Categories"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListBox2)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox4.Location = New System.Drawing.Point(524, 213)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(275, 153)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Added Sub Categories"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(14, 29)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(247, 157)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 17
        Me.ListBox2.Location = New System.Drawing.Point(15, 21)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(246, 123)
        Me.ListBox2.TabIndex = 0
        '
        'categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 371)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "categories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products Categories Options"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents notes_textbox As TextBox
    Friend WithEvents save_item As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_details As FontAwesome.Sharp.IconButton
    Friend WithEvents clear_button As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_category As ComboBox
    Friend WithEvents cmb_subcategory2 As ComboBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
End Class
