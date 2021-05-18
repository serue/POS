<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_inventory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PRODUCT_ID_LABEL = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.clear_button = New FontAwesome.Sharp.IconButton()
        Me.edit_price = New FontAwesome.Sharp.IconButton()
        Me.edit_details = New FontAwesome.Sharp.IconButton()
        Me.save_item = New FontAwesome.Sharp.IconButton()
        Me.sku_textbox = New System.Windows.Forms.TextBox()
        Me.vendorCode_textbox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.sale_qty_textbox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.selling_textbox = New System.Windows.Forms.TextBox()
        Me.margin_textbox = New System.Windows.Forms.TextBox()
        Me.cost_textbox = New System.Windows.Forms.TextBox()
        Me.re_order_textbox = New System.Windows.Forms.TextBox()
        Me.quantity_textbox = New System.Windows.Forms.TextBox()
        Me.name_textbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.barcode_textbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.category_combo = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(29, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CATEGORY:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PRODUCT_ID_LABEL)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.clear_button)
        Me.Panel1.Controls.Add(Me.edit_price)
        Me.Panel1.Controls.Add(Me.edit_details)
        Me.Panel1.Controls.Add(Me.save_item)
        Me.Panel1.Controls.Add(Me.sku_textbox)
        Me.Panel1.Controls.Add(Me.vendorCode_textbox)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.sale_qty_textbox)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.selling_textbox)
        Me.Panel1.Controls.Add(Me.margin_textbox)
        Me.Panel1.Controls.Add(Me.cost_textbox)
        Me.Panel1.Controls.Add(Me.re_order_textbox)
        Me.Panel1.Controls.Add(Me.quantity_textbox)
        Me.Panel1.Controls.Add(Me.name_textbox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.barcode_textbox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.category_combo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1678, 811)
        Me.Panel1.TabIndex = 1
        '
        'PRODUCT_ID_LABEL
        '
        Me.PRODUCT_ID_LABEL.AutoSize = True
        Me.PRODUCT_ID_LABEL.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCT_ID_LABEL.ForeColor = System.Drawing.Color.SaddleBrown
        Me.PRODUCT_ID_LABEL.Location = New System.Drawing.Point(160, 23)
        Me.PRODUCT_ID_LABEL.Name = "PRODUCT_ID_LABEL"
        Me.PRODUCT_ID_LABEL.Size = New System.Drawing.Size(0, 34)
        Me.PRODUCT_ID_LABEL.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label12.Location = New System.Drawing.Point(29, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 21)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "PRODUCT ID:"
        '
        'clear_button
        '
        Me.clear_button.BackColor = System.Drawing.Color.SteelBlue
        Me.clear_button.FlatAppearance.BorderSize = 0
        Me.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_button.ForeColor = System.Drawing.Color.Gainsboro
        Me.clear_button.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.clear_button.IconColor = System.Drawing.SystemColors.ControlLight
        Me.clear_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clear_button.IconSize = 30
        Me.clear_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.clear_button.Location = New System.Drawing.Point(1023, 572)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Size = New System.Drawing.Size(267, 45)
        Me.clear_button.TabIndex = 26
        Me.clear_button.Text = "CLEAR ALL TEXT"
        Me.clear_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clear_button.UseVisualStyleBackColor = False
        '
        'edit_price
        '
        Me.edit_price.BackColor = System.Drawing.Color.Maroon
        Me.edit_price.FlatAppearance.BorderSize = 0
        Me.edit_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_price.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_price.ForeColor = System.Drawing.Color.Gainsboro
        Me.edit_price.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        Me.edit_price.IconColor = System.Drawing.SystemColors.ControlLight
        Me.edit_price.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_price.IconSize = 30
        Me.edit_price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit_price.Location = New System.Drawing.Point(693, 572)
        Me.edit_price.Name = "edit_price"
        Me.edit_price.Size = New System.Drawing.Size(288, 45)
        Me.edit_price.TabIndex = 25
        Me.edit_price.Text = "EDIT PRICE AND QUANTITY"
        Me.edit_price.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.edit_price.UseVisualStyleBackColor = False
        '
        'edit_details
        '
        Me.edit_details.BackColor = System.Drawing.Color.Olive
        Me.edit_details.FlatAppearance.BorderSize = 0
        Me.edit_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_details.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_details.ForeColor = System.Drawing.Color.Gainsboro
        Me.edit_details.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.edit_details.IconColor = System.Drawing.SystemColors.ControlLight
        Me.edit_details.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_details.IconSize = 30
        Me.edit_details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit_details.Location = New System.Drawing.Point(363, 572)
        Me.edit_details.Name = "edit_details"
        Me.edit_details.Size = New System.Drawing.Size(267, 45)
        Me.edit_details.TabIndex = 24
        Me.edit_details.Text = "EDIT ALL DETAILS"
        Me.edit_details.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.edit_details.UseVisualStyleBackColor = False
        '
        'save_item
        '
        Me.save_item.BackColor = System.Drawing.Color.SeaGreen
        Me.save_item.FlatAppearance.BorderSize = 0
        Me.save_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_item.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_item.ForeColor = System.Drawing.Color.Gainsboro
        Me.save_item.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.save_item.IconColor = System.Drawing.SystemColors.ControlLight
        Me.save_item.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.save_item.IconSize = 30
        Me.save_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_item.Location = New System.Drawing.Point(33, 572)
        Me.save_item.Name = "save_item"
        Me.save_item.Size = New System.Drawing.Size(267, 45)
        Me.save_item.TabIndex = 23
        Me.save_item.Text = "SAVE NEW ITEM"
        Me.save_item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.save_item.UseVisualStyleBackColor = False
        '
        'sku_textbox
        '
        Me.sku_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sku_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.sku_textbox.Location = New System.Drawing.Point(652, 380)
        Me.sku_textbox.Name = "sku_textbox"
        Me.sku_textbox.Size = New System.Drawing.Size(639, 35)
        Me.sku_textbox.TabIndex = 22
        '
        'vendorCode_textbox
        '
        Me.vendorCode_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendorCode_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.vendorCode_textbox.Location = New System.Drawing.Point(33, 380)
        Me.vendorCode_textbox.Name = "vendorCode_textbox"
        Me.vendorCode_textbox.Size = New System.Drawing.Size(583, 35)
        Me.vendorCode_textbox.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label11.Location = New System.Drawing.Point(648, 356)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 21)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "SKU CODE (optional):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(29, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "VENDOR CODE (optional):"
        '
        'sale_qty_textbox
        '
        Me.sale_qty_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sale_qty_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.sale_qty_textbox.Location = New System.Drawing.Point(955, 284)
        Me.sale_qty_textbox.Name = "sale_qty_textbox"
        Me.sale_qty_textbox.Size = New System.Drawing.Size(336, 35)
        Me.sale_qty_textbox.TabIndex = 18
        Me.sale_qty_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(951, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(347, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "STANDARD SALE QUANTITY (optional):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(648, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "SELLING PRICE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(363, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "MARGIN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(29, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "COST PRICE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(951, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(290, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "RE ORDER QUANTITY (optional):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(648, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "QUANTITY:"
        '
        'selling_textbox
        '
        Me.selling_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selling_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.selling_textbox.Location = New System.Drawing.Point(652, 284)
        Me.selling_textbox.Name = "selling_textbox"
        Me.selling_textbox.Size = New System.Drawing.Size(273, 35)
        Me.selling_textbox.TabIndex = 11
        Me.selling_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'margin_textbox
        '
        Me.margin_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.margin_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.margin_textbox.Location = New System.Drawing.Point(367, 284)
        Me.margin_textbox.Name = "margin_textbox"
        Me.margin_textbox.Size = New System.Drawing.Size(249, 35)
        Me.margin_textbox.TabIndex = 10
        Me.margin_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cost_textbox
        '
        Me.cost_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cost_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cost_textbox.Location = New System.Drawing.Point(33, 284)
        Me.cost_textbox.Name = "cost_textbox"
        Me.cost_textbox.Size = New System.Drawing.Size(289, 35)
        Me.cost_textbox.TabIndex = 9
        Me.cost_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        're_order_textbox
        '
        Me.re_order_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.re_order_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.re_order_textbox.Location = New System.Drawing.Point(955, 191)
        Me.re_order_textbox.Name = "re_order_textbox"
        Me.re_order_textbox.Size = New System.Drawing.Size(336, 35)
        Me.re_order_textbox.TabIndex = 8
        Me.re_order_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'quantity_textbox
        '
        Me.quantity_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.quantity_textbox.Location = New System.Drawing.Point(652, 191)
        Me.quantity_textbox.Name = "quantity_textbox"
        Me.quantity_textbox.Size = New System.Drawing.Size(273, 35)
        Me.quantity_textbox.TabIndex = 7
        Me.quantity_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'name_textbox
        '
        Me.name_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.name_textbox.Location = New System.Drawing.Point(33, 191)
        Me.name_textbox.Name = "name_textbox"
        Me.name_textbox.Size = New System.Drawing.Size(583, 35)
        Me.name_textbox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(29, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NAME:"
        '
        'barcode_textbox
        '
        Me.barcode_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barcode_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.barcode_textbox.Location = New System.Drawing.Point(652, 100)
        Me.barcode_textbox.Name = "barcode_textbox"
        Me.barcode_textbox.Size = New System.Drawing.Size(639, 35)
        Me.barcode_textbox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(648, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BARCODE:"
        '
        'category_combo
        '
        Me.category_combo.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_combo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.category_combo.FormattingEnabled = True
        Me.category_combo.Location = New System.Drawing.Point(33, 100)
        Me.category_combo.Name = "category_combo"
        Me.category_combo.Size = New System.Drawing.Size(583, 36)
        Me.category_combo.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1678, 2)
        Me.Panel2.TabIndex = 1
        '
        'Add_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1678, 811)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Add_inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Update Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents barcode_textbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents category_combo As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents sale_qty_textbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents selling_textbox As TextBox
    Friend WithEvents margin_textbox As TextBox
    Friend WithEvents cost_textbox As TextBox
    Friend WithEvents re_order_textbox As TextBox
    Friend WithEvents quantity_textbox As TextBox
    Friend WithEvents name_textbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sku_textbox As TextBox
    Friend WithEvents vendorCode_textbox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents clear_button As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_price As FontAwesome.Sharp.IconButton
    Friend WithEvents edit_details As FontAwesome.Sharp.IconButton
    Friend WithEvents save_item As FontAwesome.Sharp.IconButton
    Friend WithEvents PRODUCT_ID_LABEL As Label
    Friend WithEvents Label12 As Label
End Class
