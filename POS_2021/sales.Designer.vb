<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sales
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.total_label = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cost_label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.change_label = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.payment_method_label = New System.Windows.Forms.Label()
        Me.sales_panel = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.returns_button = New FontAwesome.Sharp.IconButton()
        Me.dayEnd_sales = New FontAwesome.Sharp.IconButton()
        Me.sales_menu = New FontAwesome.Sharp.IconButton()
        Me.users_panel = New System.Windows.Forms.Panel()
        Me.change_password_button = New FontAwesome.Sharp.IconButton()
        Me.updateUser_button = New FontAwesome.Sharp.IconButton()
        Me.registerUser_button = New FontAwesome.Sharp.IconButton()
        Me.users_menu = New FontAwesome.Sharp.IconButton()
        Me.reports_panel = New System.Windows.Forms.Panel()
        Me.stock_reports_button = New FontAwesome.Sharp.IconButton()
        Me.scheduled_report_button = New FontAwesome.Sharp.IconButton()
        Me.DayEnd_reports_button = New FontAwesome.Sharp.IconButton()
        Me.reports_menu = New FontAwesome.Sharp.IconButton()
        Me.inventoy_panel = New System.Windows.Forms.Panel()
        Me.Inventory_list_button = New FontAwesome.Sharp.IconButton()
        Me.update_price_button = New FontAwesome.Sharp.IconButton()
        Me.stock_valuation = New FontAwesome.Sharp.IconButton()
        Me.update_inventory_button = New FontAwesome.Sharp.IconButton()
        Me.add_inventory_button = New FontAwesome.Sharp.IconButton()
        Me.Inventory_menu = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.sales_panel.SuspendLayout()
        Me.users_panel.SuspendLayout()
        Me.reports_panel.SuspendLayout()
        Me.inventoy_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.total_label)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1680, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SlateBlue
        Me.Label6.Location = New System.Drawing.Point(45, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(620, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Shopwise Inventory Management and  Point Sale System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(1063, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total Sale:"
        '
        'total_label
        '
        Me.total_label.AutoSize = True
        Me.total_label.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_label.ForeColor = System.Drawing.Color.SeaGreen
        Me.total_label.Location = New System.Drawing.Point(1224, 3)
        Me.total_label.Name = "total_label"
        Me.total_label.Size = New System.Drawing.Size(121, 40)
        Me.total_label.TabIndex = 4
        Me.total_label.Text = "1, 300"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Peru
        Me.Panel4.Location = New System.Drawing.Point(23, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(15, 15)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Location = New System.Drawing.Point(5, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(15, 15)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel5.Location = New System.Drawing.Point(23, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(15, 15)
        Me.Panel5.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(5, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(15, 15)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(680, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cost:"
        '
        'cost_label
        '
        Me.cost_label.AutoSize = True
        Me.cost_label.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cost_label.ForeColor = System.Drawing.Color.Crimson
        Me.cost_label.Location = New System.Drawing.Point(765, 3)
        Me.cost_label.Name = "cost_label"
        Me.cost_label.Size = New System.Drawing.Size(121, 40)
        Me.cost_label.TabIndex = 4
        Me.cost_label.Text = "1, 300"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label5.Location = New System.Drawing.Point(1408, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 34)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Change:"
        '
        'change_label
        '
        Me.change_label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.change_label.AutoSize = True
        Me.change_label.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_label.ForeColor = System.Drawing.Color.DarkMagenta
        Me.change_label.Location = New System.Drawing.Point(1533, 21)
        Me.change_label.Name = "change_label"
        Me.change_label.Size = New System.Drawing.Size(121, 40)
        Me.change_label.TabIndex = 4
        Me.change_label.Text = "1, 300"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MintCream
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 57)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1680, 3)
        Me.Panel6.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Thistle
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.change_label)
        Me.Panel7.Controls.Add(Me.TextBox1)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 727)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1680, 82)
        Me.Panel7.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Purple
        Me.TextBox1.Location = New System.Drawing.Point(214, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(738, 40)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "01166741132"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(25, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product Code:"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.SplitContainer1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 60)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1680, 667)
        Me.Panel8.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel9)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.inventoy_panel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.reports_panel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.users_panel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.sales_panel)
        Me.SplitContainer1.Size = New System.Drawing.Size(1680, 667)
        Me.SplitContainer1.SplitterDistance = 1083
        Me.SplitContainer1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(583, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(427, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.cost_label)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Controls.Add(Me.payment_method_label)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1083, 52)
        Me.Panel9.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sale type:"
        '
        'payment_method_label
        '
        Me.payment_method_label.AutoSize = True
        Me.payment_method_label.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payment_method_label.ForeColor = System.Drawing.Color.DarkGreen
        Me.payment_method_label.Location = New System.Drawing.Point(118, 8)
        Me.payment_method_label.Name = "payment_method_label"
        Me.payment_method_label.Size = New System.Drawing.Size(98, 29)
        Me.payment_method_label.TabIndex = 0
        Me.payment_method_label.Text = "Ecocash"
        '
        'sales_panel
        '
        Me.sales_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.sales_panel.Controls.Add(Me.IconButton1)
        Me.sales_panel.Controls.Add(Me.IconButton5)
        Me.sales_panel.Controls.Add(Me.returns_button)
        Me.sales_panel.Controls.Add(Me.dayEnd_sales)
        Me.sales_panel.Controls.Add(Me.sales_menu)
        Me.sales_panel.Location = New System.Drawing.Point(3, 0)
        Me.sales_panel.Name = "sales_panel"
        Me.sales_panel.Size = New System.Drawing.Size(263, 216)
        Me.sales_panel.TabIndex = 7
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(0, 175)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.IconButton1.Size = New System.Drawing.Size(263, 40)
        Me.IconButton1.TabIndex = 4
        Me.IconButton1.Text = "Reprint Last Trans"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton5
        '
        Me.IconButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton5.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 30
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton5.Location = New System.Drawing.Point(0, 135)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.IconButton5.Size = New System.Drawing.Size(263, 40)
        Me.IconButton5.TabIndex = 3
        Me.IconButton5.Text = "Transaction Log"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'returns_button
        '
        Me.returns_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.returns_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.returns_button.FlatAppearance.BorderSize = 0
        Me.returns_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.returns_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returns_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.returns_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.returns_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.returns_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.returns_button.IconSize = 30
        Me.returns_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.returns_button.Location = New System.Drawing.Point(0, 95)
        Me.returns_button.Name = "returns_button"
        Me.returns_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.returns_button.Size = New System.Drawing.Size(263, 40)
        Me.returns_button.TabIndex = 2
        Me.returns_button.Text = "Sales Returns"
        Me.returns_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.returns_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.returns_button.UseVisualStyleBackColor = False
        '
        'dayEnd_sales
        '
        Me.dayEnd_sales.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.dayEnd_sales.Dock = System.Windows.Forms.DockStyle.Top
        Me.dayEnd_sales.FlatAppearance.BorderSize = 0
        Me.dayEnd_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dayEnd_sales.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayEnd_sales.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.dayEnd_sales.IconChar = FontAwesome.Sharp.IconChar.None
        Me.dayEnd_sales.IconColor = System.Drawing.Color.WhiteSmoke
        Me.dayEnd_sales.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.dayEnd_sales.IconSize = 30
        Me.dayEnd_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dayEnd_sales.Location = New System.Drawing.Point(0, 55)
        Me.dayEnd_sales.Name = "dayEnd_sales"
        Me.dayEnd_sales.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.dayEnd_sales.Size = New System.Drawing.Size(263, 40)
        Me.dayEnd_sales.TabIndex = 1
        Me.dayEnd_sales.Text = "Day End Sales"
        Me.dayEnd_sales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dayEnd_sales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.dayEnd_sales.UseVisualStyleBackColor = False
        '
        'sales_menu
        '
        Me.sales_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.sales_menu.FlatAppearance.BorderSize = 0
        Me.sales_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sales_menu.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sales_menu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.sales_menu.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        Me.sales_menu.IconColor = System.Drawing.Color.WhiteSmoke
        Me.sales_menu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.sales_menu.IconSize = 30
        Me.sales_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sales_menu.Location = New System.Drawing.Point(0, 0)
        Me.sales_menu.Name = "sales_menu"
        Me.sales_menu.Size = New System.Drawing.Size(263, 55)
        Me.sales_menu.TabIndex = 0
        Me.sales_menu.Text = "Sales"
        Me.sales_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sales_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.sales_menu.UseVisualStyleBackColor = True
        '
        'users_panel
        '
        Me.users_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.users_panel.Controls.Add(Me.change_password_button)
        Me.users_panel.Controls.Add(Me.updateUser_button)
        Me.users_panel.Controls.Add(Me.registerUser_button)
        Me.users_panel.Controls.Add(Me.users_menu)
        Me.users_panel.Location = New System.Drawing.Point(0, 246)
        Me.users_panel.Name = "users_panel"
        Me.users_panel.Size = New System.Drawing.Size(263, 175)
        Me.users_panel.TabIndex = 8
        '
        'change_password_button
        '
        Me.change_password_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.change_password_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.change_password_button.FlatAppearance.BorderSize = 0
        Me.change_password_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.change_password_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_password_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.change_password_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.change_password_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.change_password_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.change_password_button.IconSize = 30
        Me.change_password_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.change_password_button.Location = New System.Drawing.Point(0, 135)
        Me.change_password_button.Name = "change_password_button"
        Me.change_password_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.change_password_button.Size = New System.Drawing.Size(263, 40)
        Me.change_password_button.TabIndex = 3
        Me.change_password_button.Text = "Change Password"
        Me.change_password_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.change_password_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.change_password_button.UseVisualStyleBackColor = False
        '
        'updateUser_button
        '
        Me.updateUser_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.updateUser_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.updateUser_button.FlatAppearance.BorderSize = 0
        Me.updateUser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updateUser_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateUser_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.updateUser_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.updateUser_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.updateUser_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.updateUser_button.IconSize = 30
        Me.updateUser_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.updateUser_button.Location = New System.Drawing.Point(0, 95)
        Me.updateUser_button.Name = "updateUser_button"
        Me.updateUser_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.updateUser_button.Size = New System.Drawing.Size(263, 40)
        Me.updateUser_button.TabIndex = 2
        Me.updateUser_button.Text = "Update users"
        Me.updateUser_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updateUser_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.updateUser_button.UseVisualStyleBackColor = False
        '
        'registerUser_button
        '
        Me.registerUser_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.registerUser_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.registerUser_button.FlatAppearance.BorderSize = 0
        Me.registerUser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerUser_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerUser_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.registerUser_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.registerUser_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.registerUser_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.registerUser_button.IconSize = 30
        Me.registerUser_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.registerUser_button.Location = New System.Drawing.Point(0, 55)
        Me.registerUser_button.Name = "registerUser_button"
        Me.registerUser_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.registerUser_button.Size = New System.Drawing.Size(263, 40)
        Me.registerUser_button.TabIndex = 1
        Me.registerUser_button.Text = "Register New user"
        Me.registerUser_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.registerUser_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.registerUser_button.UseVisualStyleBackColor = False
        '
        'users_menu
        '
        Me.users_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.users_menu.FlatAppearance.BorderSize = 0
        Me.users_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.users_menu.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.users_menu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.users_menu.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        Me.users_menu.IconColor = System.Drawing.Color.WhiteSmoke
        Me.users_menu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.users_menu.IconSize = 30
        Me.users_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.users_menu.Location = New System.Drawing.Point(0, 0)
        Me.users_menu.Name = "users_menu"
        Me.users_menu.Size = New System.Drawing.Size(263, 55)
        Me.users_menu.TabIndex = 0
        Me.users_menu.Text = "Users"
        Me.users_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.users_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.users_menu.UseVisualStyleBackColor = True
        '
        'reports_panel
        '
        Me.reports_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.reports_panel.Controls.Add(Me.stock_reports_button)
        Me.reports_panel.Controls.Add(Me.scheduled_report_button)
        Me.reports_panel.Controls.Add(Me.DayEnd_reports_button)
        Me.reports_panel.Controls.Add(Me.reports_menu)
        Me.reports_panel.Location = New System.Drawing.Point(0, 427)
        Me.reports_panel.Name = "reports_panel"
        Me.reports_panel.Size = New System.Drawing.Size(263, 178)
        Me.reports_panel.TabIndex = 9
        '
        'stock_reports_button
        '
        Me.stock_reports_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.stock_reports_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.stock_reports_button.FlatAppearance.BorderSize = 0
        Me.stock_reports_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stock_reports_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_reports_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.stock_reports_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.stock_reports_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.stock_reports_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.stock_reports_button.IconSize = 30
        Me.stock_reports_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.stock_reports_button.Location = New System.Drawing.Point(0, 135)
        Me.stock_reports_button.Name = "stock_reports_button"
        Me.stock_reports_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.stock_reports_button.Size = New System.Drawing.Size(263, 40)
        Me.stock_reports_button.TabIndex = 3
        Me.stock_reports_button.Text = "Stock Reports"
        Me.stock_reports_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stock_reports_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.stock_reports_button.UseVisualStyleBackColor = False
        '
        'scheduled_report_button
        '
        Me.scheduled_report_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.scheduled_report_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.scheduled_report_button.FlatAppearance.BorderSize = 0
        Me.scheduled_report_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scheduled_report_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scheduled_report_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.scheduled_report_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.scheduled_report_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.scheduled_report_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.scheduled_report_button.IconSize = 30
        Me.scheduled_report_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.scheduled_report_button.Location = New System.Drawing.Point(0, 95)
        Me.scheduled_report_button.Name = "scheduled_report_button"
        Me.scheduled_report_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.scheduled_report_button.Size = New System.Drawing.Size(263, 40)
        Me.scheduled_report_button.TabIndex = 2
        Me.scheduled_report_button.Text = "Scheduled Sales Reports"
        Me.scheduled_report_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.scheduled_report_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.scheduled_report_button.UseVisualStyleBackColor = False
        '
        'DayEnd_reports_button
        '
        Me.DayEnd_reports_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.DayEnd_reports_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.DayEnd_reports_button.FlatAppearance.BorderSize = 0
        Me.DayEnd_reports_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DayEnd_reports_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayEnd_reports_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DayEnd_reports_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.DayEnd_reports_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.DayEnd_reports_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.DayEnd_reports_button.IconSize = 30
        Me.DayEnd_reports_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DayEnd_reports_button.Location = New System.Drawing.Point(0, 55)
        Me.DayEnd_reports_button.Name = "DayEnd_reports_button"
        Me.DayEnd_reports_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.DayEnd_reports_button.Size = New System.Drawing.Size(263, 40)
        Me.DayEnd_reports_button.TabIndex = 1
        Me.DayEnd_reports_button.Text = "Day End Sales"
        Me.DayEnd_reports_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DayEnd_reports_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.DayEnd_reports_button.UseVisualStyleBackColor = False
        '
        'reports_menu
        '
        Me.reports_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.reports_menu.FlatAppearance.BorderSize = 0
        Me.reports_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reports_menu.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reports_menu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.reports_menu.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        Me.reports_menu.IconColor = System.Drawing.Color.WhiteSmoke
        Me.reports_menu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.reports_menu.IconSize = 30
        Me.reports_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.reports_menu.Location = New System.Drawing.Point(0, 0)
        Me.reports_menu.Name = "reports_menu"
        Me.reports_menu.Size = New System.Drawing.Size(263, 55)
        Me.reports_menu.TabIndex = 0
        Me.reports_menu.Text = "Reports"
        Me.reports_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reports_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.reports_menu.UseVisualStyleBackColor = True
        '
        'inventoy_panel
        '
        Me.inventoy_panel.AutoScroll = True
        Me.inventoy_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.inventoy_panel.Controls.Add(Me.Inventory_list_button)
        Me.inventoy_panel.Controls.Add(Me.update_price_button)
        Me.inventoy_panel.Controls.Add(Me.stock_valuation)
        Me.inventoy_panel.Controls.Add(Me.update_inventory_button)
        Me.inventoy_panel.Controls.Add(Me.add_inventory_button)
        Me.inventoy_panel.Controls.Add(Me.Inventory_menu)
        Me.inventoy_panel.Location = New System.Drawing.Point(304, 12)
        Me.inventoy_panel.Name = "inventoy_panel"
        Me.inventoy_panel.Size = New System.Drawing.Size(263, 258)
        Me.inventoy_panel.TabIndex = 10
        '
        'Inventory_list_button
        '
        Me.Inventory_list_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Inventory_list_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.Inventory_list_button.FlatAppearance.BorderSize = 0
        Me.Inventory_list_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Inventory_list_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inventory_list_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Inventory_list_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Inventory_list_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Inventory_list_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Inventory_list_button.IconSize = 30
        Me.Inventory_list_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Inventory_list_button.Location = New System.Drawing.Point(0, 215)
        Me.Inventory_list_button.Name = "Inventory_list_button"
        Me.Inventory_list_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Inventory_list_button.Size = New System.Drawing.Size(263, 40)
        Me.Inventory_list_button.TabIndex = 5
        Me.Inventory_list_button.Text = "Available Inventory"
        Me.Inventory_list_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Inventory_list_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Inventory_list_button.UseVisualStyleBackColor = False
        '
        'update_price_button
        '
        Me.update_price_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.update_price_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.update_price_button.FlatAppearance.BorderSize = 0
        Me.update_price_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_price_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_price_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.update_price_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.update_price_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.update_price_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.update_price_button.IconSize = 30
        Me.update_price_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.update_price_button.Location = New System.Drawing.Point(0, 175)
        Me.update_price_button.Name = "update_price_button"
        Me.update_price_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.update_price_button.Size = New System.Drawing.Size(263, 40)
        Me.update_price_button.TabIndex = 4
        Me.update_price_button.Text = "Update Price and Quantity"
        Me.update_price_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.update_price_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.update_price_button.UseVisualStyleBackColor = False
        '
        'stock_valuation
        '
        Me.stock_valuation.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.stock_valuation.Dock = System.Windows.Forms.DockStyle.Top
        Me.stock_valuation.FlatAppearance.BorderSize = 0
        Me.stock_valuation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stock_valuation.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_valuation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.stock_valuation.IconChar = FontAwesome.Sharp.IconChar.None
        Me.stock_valuation.IconColor = System.Drawing.Color.WhiteSmoke
        Me.stock_valuation.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.stock_valuation.IconSize = 30
        Me.stock_valuation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.stock_valuation.Location = New System.Drawing.Point(0, 135)
        Me.stock_valuation.Name = "stock_valuation"
        Me.stock_valuation.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.stock_valuation.Size = New System.Drawing.Size(263, 40)
        Me.stock_valuation.TabIndex = 3
        Me.stock_valuation.Text = "Inventory Valuation"
        Me.stock_valuation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stock_valuation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.stock_valuation.UseVisualStyleBackColor = False
        '
        'update_inventory_button
        '
        Me.update_inventory_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.update_inventory_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.update_inventory_button.FlatAppearance.BorderSize = 0
        Me.update_inventory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_inventory_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_inventory_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.update_inventory_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.update_inventory_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.update_inventory_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.update_inventory_button.IconSize = 30
        Me.update_inventory_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.update_inventory_button.Location = New System.Drawing.Point(0, 95)
        Me.update_inventory_button.Name = "update_inventory_button"
        Me.update_inventory_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.update_inventory_button.Size = New System.Drawing.Size(263, 40)
        Me.update_inventory_button.TabIndex = 2
        Me.update_inventory_button.Text = "Update Inventory Details"
        Me.update_inventory_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.update_inventory_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.update_inventory_button.UseVisualStyleBackColor = False
        '
        'add_inventory_button
        '
        Me.add_inventory_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.add_inventory_button.Dock = System.Windows.Forms.DockStyle.Top
        Me.add_inventory_button.FlatAppearance.BorderSize = 0
        Me.add_inventory_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_inventory_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_inventory_button.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.add_inventory_button.IconChar = FontAwesome.Sharp.IconChar.None
        Me.add_inventory_button.IconColor = System.Drawing.Color.WhiteSmoke
        Me.add_inventory_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.add_inventory_button.IconSize = 30
        Me.add_inventory_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.add_inventory_button.Location = New System.Drawing.Point(0, 55)
        Me.add_inventory_button.Name = "add_inventory_button"
        Me.add_inventory_button.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.add_inventory_button.Size = New System.Drawing.Size(263, 40)
        Me.add_inventory_button.TabIndex = 1
        Me.add_inventory_button.Text = "Add New Inventory"
        Me.add_inventory_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add_inventory_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.add_inventory_button.UseVisualStyleBackColor = False
        '
        'Inventory_menu
        '
        Me.Inventory_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Inventory_menu.FlatAppearance.BorderSize = 0
        Me.Inventory_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Inventory_menu.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inventory_menu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Inventory_menu.IconChar = FontAwesome.Sharp.IconChar.AngleRight
        Me.Inventory_menu.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Inventory_menu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Inventory_menu.IconSize = 30
        Me.Inventory_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Inventory_menu.Location = New System.Drawing.Point(0, 0)
        Me.Inventory_menu.Name = "Inventory_menu"
        Me.Inventory_menu.Size = New System.Drawing.Size(263, 55)
        Me.Inventory_menu.TabIndex = 0
        Me.Inventory_menu.Text = "Inventory"
        Me.Inventory_menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Inventory_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Inventory_menu.UseVisualStyleBackColor = True
        '
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1680, 809)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beymo Technologies Private Limited"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.sales_panel.ResumeLayout(False)
        Me.users_panel.ResumeLayout(False)
        Me.reports_panel.ResumeLayout(False)
        Me.inventoy_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents cost_label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents change_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents total_label As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents payment_method_label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents sales_panel As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents returns_button As FontAwesome.Sharp.IconButton
    Friend WithEvents dayEnd_sales As FontAwesome.Sharp.IconButton
    Friend WithEvents sales_menu As FontAwesome.Sharp.IconButton
    Friend WithEvents users_panel As Panel
    Friend WithEvents change_password_button As FontAwesome.Sharp.IconButton
    Friend WithEvents updateUser_button As FontAwesome.Sharp.IconButton
    Friend WithEvents registerUser_button As FontAwesome.Sharp.IconButton
    Friend WithEvents users_menu As FontAwesome.Sharp.IconButton
    Friend WithEvents reports_panel As Panel
    Friend WithEvents stock_reports_button As FontAwesome.Sharp.IconButton
    Friend WithEvents scheduled_report_button As FontAwesome.Sharp.IconButton
    Friend WithEvents DayEnd_reports_button As FontAwesome.Sharp.IconButton
    Friend WithEvents reports_menu As FontAwesome.Sharp.IconButton
    Friend WithEvents inventoy_panel As Panel
    Friend WithEvents Inventory_list_button As FontAwesome.Sharp.IconButton
    Friend WithEvents update_price_button As FontAwesome.Sharp.IconButton
    Friend WithEvents stock_valuation As FontAwesome.Sharp.IconButton
    Friend WithEvents update_inventory_button As FontAwesome.Sharp.IconButton
    Friend WithEvents add_inventory_button As FontAwesome.Sharp.IconButton
    Friend WithEvents Inventory_menu As FontAwesome.Sharp.IconButton
End Class
