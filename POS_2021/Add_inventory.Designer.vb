<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_inventory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.list_grid = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.SEARCH_BOX = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.category_combo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.name_textbox = New System.Windows.Forms.TextBox()
        Me.vendorCode_textbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sku_textbox = New System.Windows.Forms.TextBox()
        Me.quantity_textbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cost_textbox = New System.Windows.Forms.TextBox()
        Me.re_order_textbox = New System.Windows.Forms.TextBox()
        Me.margin_textbox = New System.Windows.Forms.TextBox()
        Me.barcode_textbox = New System.Windows.Forms.TextBox()
        Me.selling_textbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sale_qty_textbox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Delete_button = New FontAwesome.Sharp.IconButton()
        Me.clear_button = New FontAwesome.Sharp.IconButton()
        Me.NEW_STOCK = New FontAwesome.Sharp.IconButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PRODUCT_ID_LABEL = New System.Windows.Forms.Label()
        Me.edit_price = New FontAwesome.Sharp.IconButton()
        Me.save_item = New FontAwesome.Sharp.IconButton()
        Me.edit_details = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.list_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CATEGORY:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 601)
        Me.Panel1.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.list_grid)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 299)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1028, 302)
        Me.Panel6.TabIndex = 30
        '
        'list_grid
        '
        Me.list_grid.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue
        Me.list_grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.list_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.list_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.list_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.list_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.list_grid.ColumnHeadersHeight = 35
        Me.list_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.list_grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.list_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_grid.EnableHeadersVisualStyles = False
        Me.list_grid.Location = New System.Drawing.Point(0, 0)
        Me.list_grid.Margin = New System.Windows.Forms.Padding(2)
        Me.list_grid.Name = "list_grid"
        Me.list_grid.RowHeadersVisible = False
        Me.list_grid.RowHeadersWidth = 8
        Me.list_grid.RowTemplate.Height = 28
        Me.list_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.list_grid.Size = New System.Drawing.Size(1028, 302)
        Me.list_grid.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1028, 297)
        Me.Panel3.TabIndex = 29
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.category_combo)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.name_textbox)
        Me.Panel5.Controls.Add(Me.vendorCode_textbox)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.sku_textbox)
        Me.Panel5.Controls.Add(Me.quantity_textbox)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.cost_textbox)
        Me.Panel5.Controls.Add(Me.re_order_textbox)
        Me.Panel5.Controls.Add(Me.margin_textbox)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.barcode_textbox)
        Me.Panel5.Controls.Add(Me.selling_textbox)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.sale_qty_textbox)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(856, 297)
        Me.Panel5.TabIndex = 24
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(852, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(4, 269)
        Me.Panel8.TabIndex = 25
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel7.Controls.Add(Me.SEARCH_BOX)
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 269)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(856, 28)
        Me.Panel7.TabIndex = 24
        '
        'SEARCH_BOX
        '
        Me.SEARCH_BOX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEARCH_BOX.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCH_BOX.ForeColor = System.Drawing.Color.SaddleBrown
        Me.SEARCH_BOX.Location = New System.Drawing.Point(426, 2)
        Me.SEARCH_BOX.Margin = New System.Windows.Forms.Padding(2)
        Me.SEARCH_BOX.Name = "SEARCH_BOX"
        Me.SEARCH_BOX.Size = New System.Drawing.Size(316, 25)
        Me.SEARCH_BOX.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SeaShell
        Me.Label14.Location = New System.Drawing.Point(365, 5)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 18)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Search:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label13.Location = New System.Drawing.Point(7, 8)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 17)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "View Added Products"
        '
        'category_combo
        '
        Me.category_combo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_combo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.category_combo.FormattingEnabled = True
        Me.category_combo.Location = New System.Drawing.Point(10, 33)
        Me.category_combo.Margin = New System.Windows.Forms.Padding(2)
        Me.category_combo.Name = "category_combo"
        Me.category_combo.Size = New System.Drawing.Size(339, 26)
        Me.category_combo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(365, 144)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "SELLING PRICE:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label10.Location = New System.Drawing.Point(7, 208)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "VENDOR CODE (optional):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(7, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NAME:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label11.Location = New System.Drawing.Point(365, 208)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "SKU CODE (optional):"
        '
        'name_textbox
        '
        Me.name_textbox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.name_textbox.Location = New System.Drawing.Point(10, 97)
        Me.name_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.name_textbox.Name = "name_textbox"
        Me.name_textbox.Size = New System.Drawing.Size(339, 26)
        Me.name_textbox.TabIndex = 6
        '
        'vendorCode_textbox
        '
        Me.vendorCode_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendorCode_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.vendorCode_textbox.Location = New System.Drawing.Point(10, 228)
        Me.vendorCode_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.vendorCode_textbox.Name = "vendorCode_textbox"
        Me.vendorCode_textbox.Size = New System.Drawing.Size(339, 30)
        Me.vendorCode_textbox.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(234, 144)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "MARGIN:"
        '
        'sku_textbox
        '
        Me.sku_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sku_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.sku_textbox.Location = New System.Drawing.Point(368, 228)
        Me.sku_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.sku_textbox.Name = "sku_textbox"
        Me.sku_textbox.Size = New System.Drawing.Size(423, 30)
        Me.sku_textbox.TabIndex = 22
        '
        'quantity_textbox
        '
        Me.quantity_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.quantity_textbox.Location = New System.Drawing.Point(368, 94)
        Me.quantity_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.quantity_textbox.Name = "quantity_textbox"
        Me.quantity_textbox.Size = New System.Drawing.Size(155, 30)
        Me.quantity_textbox.TabIndex = 7
        Me.quantity_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(7, 144)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "COST PRICE:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(535, 144)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(272, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "STANDARD SALE QUANTITY (optional):"
        '
        'cost_textbox
        '
        Me.cost_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cost_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cost_textbox.Location = New System.Drawing.Point(10, 163)
        Me.cost_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.cost_textbox.Name = "cost_textbox"
        Me.cost_textbox.Size = New System.Drawing.Size(142, 30)
        Me.cost_textbox.TabIndex = 9
        Me.cost_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        're_order_textbox
        '
        Me.re_order_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.re_order_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.re_order_textbox.Location = New System.Drawing.Point(538, 94)
        Me.re_order_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.re_order_textbox.Name = "re_order_textbox"
        Me.re_order_textbox.Size = New System.Drawing.Size(253, 30)
        Me.re_order_textbox.TabIndex = 8
        Me.re_order_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'margin_textbox
        '
        Me.margin_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.margin_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.margin_textbox.Location = New System.Drawing.Point(237, 163)
        Me.margin_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.margin_textbox.Name = "margin_textbox"
        Me.margin_textbox.Size = New System.Drawing.Size(112, 30)
        Me.margin_textbox.TabIndex = 10
        Me.margin_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'barcode_textbox
        '
        Me.barcode_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barcode_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.barcode_textbox.Location = New System.Drawing.Point(368, 30)
        Me.barcode_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.barcode_textbox.Name = "barcode_textbox"
        Me.barcode_textbox.Size = New System.Drawing.Size(423, 30)
        Me.barcode_textbox.TabIndex = 4
        '
        'selling_textbox
        '
        Me.selling_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selling_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.selling_textbox.Location = New System.Drawing.Point(368, 163)
        Me.selling_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.selling_textbox.Name = "selling_textbox"
        Me.selling_textbox.Size = New System.Drawing.Size(155, 30)
        Me.selling_textbox.TabIndex = 11
        Me.selling_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(535, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "RE ORDER QUANTITY (optional):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(365, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "QUANTITY:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(365, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BARCODE:"
        '
        'sale_qty_textbox
        '
        Me.sale_qty_textbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sale_qty_textbox.ForeColor = System.Drawing.Color.SaddleBrown
        Me.sale_qty_textbox.Location = New System.Drawing.Point(538, 163)
        Me.sale_qty_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.sale_qty_textbox.Name = "sale_qty_textbox"
        Me.sale_qty_textbox.Size = New System.Drawing.Size(253, 30)
        Me.sale_qty_textbox.TabIndex = 18
        Me.sale_qty_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Delete_button)
        Me.Panel4.Controls.Add(Me.clear_button)
        Me.Panel4.Controls.Add(Me.NEW_STOCK)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.PRODUCT_ID_LABEL)
        Me.Panel4.Controls.Add(Me.edit_price)
        Me.Panel4.Controls.Add(Me.save_item)
        Me.Panel4.Controls.Add(Me.edit_details)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(856, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(172, 297)
        Me.Panel4.TabIndex = 23
        '
        'Delete_button
        '
        Me.Delete_button.BackColor = System.Drawing.Color.Maroon
        Me.Delete_button.FlatAppearance.BorderSize = 0
        Me.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.Delete_button.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_button.ForeColor = System.Drawing.Color.Gainsboro
        Me.Delete_button.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.Delete_button.IconColor = System.Drawing.SystemColors.ControlLight
        Me.Delete_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Delete_button.IconSize = 25
        Me.Delete_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Delete_button.Location = New System.Drawing.Point(8, 211)
        Me.Delete_button.Margin = New System.Windows.Forms.Padding(2)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Rotation = 0R
        Me.Delete_button.Size = New System.Drawing.Size(158, 37)
        Me.Delete_button.TabIndex = 30
        Me.Delete_button.Text = "DELETE STOCK ITEM"
        Me.Delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete_button.UseVisualStyleBackColor = False
        '
        'clear_button
        '
        Me.clear_button.BackColor = System.Drawing.Color.Purple
        Me.clear_button.FlatAppearance.BorderSize = 0
        Me.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_button.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.clear_button.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_button.ForeColor = System.Drawing.Color.Gainsboro
        Me.clear_button.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.clear_button.IconColor = System.Drawing.SystemColors.ControlLight
        Me.clear_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clear_button.IconSize = 25
        Me.clear_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.clear_button.Location = New System.Drawing.Point(8, 255)
        Me.clear_button.Margin = New System.Windows.Forms.Padding(2)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Rotation = 0R
        Me.clear_button.Size = New System.Drawing.Size(158, 37)
        Me.clear_button.TabIndex = 26
        Me.clear_button.Text = "CLEAR ALL TEXT"
        Me.clear_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clear_button.UseVisualStyleBackColor = False
        '
        'NEW_STOCK
        '
        Me.NEW_STOCK.BackColor = System.Drawing.Color.SteelBlue
        Me.NEW_STOCK.FlatAppearance.BorderSize = 0
        Me.NEW_STOCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NEW_STOCK.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.NEW_STOCK.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NEW_STOCK.ForeColor = System.Drawing.Color.Gainsboro
        Me.NEW_STOCK.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket
        Me.NEW_STOCK.IconColor = System.Drawing.SystemColors.ControlLight
        Me.NEW_STOCK.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.NEW_STOCK.IconSize = 25
        Me.NEW_STOCK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NEW_STOCK.Location = New System.Drawing.Point(8, 167)
        Me.NEW_STOCK.Margin = New System.Windows.Forms.Padding(2)
        Me.NEW_STOCK.Name = "NEW_STOCK"
        Me.NEW_STOCK.Rotation = 0R
        Me.NEW_STOCK.Size = New System.Drawing.Size(158, 37)
        Me.NEW_STOCK.TabIndex = 29
        Me.NEW_STOCK.Text = "NEW STOCK"
        Me.NEW_STOCK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NEW_STOCK.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Snow
        Me.Label12.Location = New System.Drawing.Point(5, 11)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "PRODUCT ID:"
        '
        'PRODUCT_ID_LABEL
        '
        Me.PRODUCT_ID_LABEL.AutoSize = True
        Me.PRODUCT_ID_LABEL.BackColor = System.Drawing.Color.SaddleBrown
        Me.PRODUCT_ID_LABEL.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRODUCT_ID_LABEL.ForeColor = System.Drawing.Color.Snow
        Me.PRODUCT_ID_LABEL.Location = New System.Drawing.Point(94, 11)
        Me.PRODUCT_ID_LABEL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PRODUCT_ID_LABEL.Name = "PRODUCT_ID_LABEL"
        Me.PRODUCT_ID_LABEL.Size = New System.Drawing.Size(56, 18)
        Me.PRODUCT_ID_LABEL.TabIndex = 28
        Me.PRODUCT_ID_LABEL.Text = "449876"
        '
        'edit_price
        '
        Me.edit_price.BackColor = System.Drawing.Color.DarkKhaki
        Me.edit_price.FlatAppearance.BorderSize = 0
        Me.edit_price.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_price.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.edit_price.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_price.ForeColor = System.Drawing.Color.Gainsboro
        Me.edit_price.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        Me.edit_price.IconColor = System.Drawing.SystemColors.ControlLight
        Me.edit_price.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_price.IconSize = 25
        Me.edit_price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit_price.Location = New System.Drawing.Point(8, 124)
        Me.edit_price.Margin = New System.Windows.Forms.Padding(2)
        Me.edit_price.Name = "edit_price"
        Me.edit_price.Rotation = 0R
        Me.edit_price.Size = New System.Drawing.Size(158, 37)
        Me.edit_price.TabIndex = 25
        Me.edit_price.Text = "EDIT PRICE + QTY"
        Me.edit_price.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.edit_price.UseVisualStyleBackColor = False
        '
        'save_item
        '
        Me.save_item.BackColor = System.Drawing.Color.SeaGreen
        Me.save_item.FlatAppearance.BorderSize = 0
        Me.save_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_item.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.save_item.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_item.ForeColor = System.Drawing.Color.Gainsboro
        Me.save_item.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.save_item.IconColor = System.Drawing.SystemColors.ControlLight
        Me.save_item.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.save_item.IconSize = 25
        Me.save_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.save_item.Location = New System.Drawing.Point(8, 36)
        Me.save_item.Margin = New System.Windows.Forms.Padding(2)
        Me.save_item.Name = "save_item"
        Me.save_item.Rotation = 0R
        Me.save_item.Size = New System.Drawing.Size(158, 37)
        Me.save_item.TabIndex = 23
        Me.save_item.Text = "SAVE NEW ITEM"
        Me.save_item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.save_item.UseVisualStyleBackColor = False
        '
        'edit_details
        '
        Me.edit_details.BackColor = System.Drawing.Color.Olive
        Me.edit_details.FlatAppearance.BorderSize = 0
        Me.edit_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit_details.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.edit_details.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_details.ForeColor = System.Drawing.Color.Gainsboro
        Me.edit_details.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.edit_details.IconColor = System.Drawing.SystemColors.ControlLight
        Me.edit_details.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.edit_details.IconSize = 25
        Me.edit_details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.edit_details.Location = New System.Drawing.Point(8, 80)
        Me.edit_details.Margin = New System.Windows.Forms.Padding(2)
        Me.edit_details.Name = "edit_details"
        Me.edit_details.Rotation = 0R
        Me.edit_details.Size = New System.Drawing.Size(158, 37)
        Me.edit_details.TabIndex = 24
        Me.edit_details.Text = "EDIT  DETAILS"
        Me.edit_details.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.edit_details.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 2)
        Me.Panel2.TabIndex = 1
        '
        'Add_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 601)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Add_inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Update Inventory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.list_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Delete_button As FontAwesome.Sharp.IconButton
    Friend WithEvents NEW_STOCK As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents list_grid As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents SEARCH_BOX As TextBox
    Friend WithEvents Label14 As Label
End Class
