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
        Me.cmb_category = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 4)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CATEGORY:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CATEGORY NOTES:"
        '
        'notes_textbox
        '
        Me.notes_textbox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notes_textbox.Location = New System.Drawing.Point(16, 103)
        Me.notes_textbox.Multiline = True
        Me.notes_textbox.Name = "notes_textbox"
        Me.notes_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.notes_textbox.Size = New System.Drawing.Size(590, 94)
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
        Me.save_item.IconSize = 30
        Me.save_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_item.Location = New System.Drawing.Point(16, 220)
        Me.save_item.Name = "save_item"
        Me.save_item.Rotation = 0R
        Me.save_item.Size = New System.Drawing.Size(226, 34)
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
        Me.edit_details.IconSize = 30
        Me.edit_details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit_details.Location = New System.Drawing.Point(248, 220)
        Me.edit_details.Name = "edit_details"
        Me.edit_details.Rotation = 0R
        Me.edit_details.Size = New System.Drawing.Size(207, 34)
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
        Me.clear_button.IconSize = 30
        Me.clear_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.clear_button.Location = New System.Drawing.Point(461, 220)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Rotation = 0R
        Me.clear_button.Size = New System.Drawing.Size(145, 34)
        Me.clear_button.TabIndex = 27
        Me.clear_button.Text = "Clear"
        Me.clear_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clear_button.UseVisualStyleBackColor = False
        '
        'cmb_category
        '
        Me.cmb_category.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_category.FormattingEnabled = True
        Me.cmb_category.Location = New System.Drawing.Point(12, 33)
        Me.cmb_category.Name = "cmb_category"
        Me.cmb_category.Size = New System.Drawing.Size(594, 29)
        Me.cmb_category.TabIndex = 28
        '
        'categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 268)
        Me.Controls.Add(Me.cmb_category)
        Me.Controls.Add(Me.clear_button)
        Me.Controls.Add(Me.edit_details)
        Me.Controls.Add(Me.save_item)
        Me.Controls.Add(Me.notes_textbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "categories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products Categories Options"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents notes_textbox As TextBox
    Friend WithEvents save_item As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_details As FontAwesome.Sharp.IconButton
    Friend WithEvents clear_button As FontAwesome.Sharp.IconButton
    Friend WithEvents cmb_category As ComboBox
End Class
