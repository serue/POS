<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventory_list
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.panel_Stock = New System.Windows.Forms.Panel()
        Me.Save_button = New System.Windows.Forms.Button()
        Me.quantity_box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.list_grid = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.update_product = New FontAwesome.Sharp.IconButton()
        Me.Return_product = New FontAwesome.Sharp.IconButton()
        Me.Write_off = New FontAwesome.Sharp.IconButton()
        Me.NewStock_button = New FontAwesome.Sharp.IconButton()
        Me.Delete_button = New FontAwesome.Sharp.IconButton()
        Me.search_button = New FontAwesome.Sharp.IconButton()
        Me.Refresh_button = New FontAwesome.Sharp.IconButton()
        Me.SEARCH_BOX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.panel_Stock.SuspendLayout()
        CType(Me.list_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1564, 726)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1564, 723)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 55)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1564, 668)
        Me.Panel5.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.panel_Stock)
        Me.Panel7.Controls.Add(Me.list_grid)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1564, 667)
        Me.Panel7.TabIndex = 2
        '
        'panel_Stock
        '
        Me.panel_Stock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Stock.Controls.Add(Me.Save_button)
        Me.panel_Stock.Controls.Add(Me.quantity_box)
        Me.panel_Stock.Controls.Add(Me.Label3)
        Me.panel_Stock.Controls.Add(Me.Panel9)
        Me.panel_Stock.Controls.Add(Me.Label2)
        Me.panel_Stock.Location = New System.Drawing.Point(621, 103)
        Me.panel_Stock.Name = "panel_Stock"
        Me.panel_Stock.Size = New System.Drawing.Size(393, 196)
        Me.panel_Stock.TabIndex = 1
        Me.panel_Stock.Visible = False
        '
        'Save_button
        '
        Me.Save_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_button.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Save_button.Location = New System.Drawing.Point(103, 119)
        Me.Save_button.Name = "Save_button"
        Me.Save_button.Size = New System.Drawing.Size(184, 51)
        Me.Save_button.TabIndex = 4
        Me.Save_button.Text = "Update Quantity"
        Me.Save_button.UseVisualStyleBackColor = True
        '
        'quantity_box
        '
        Me.quantity_box.Font = New System.Drawing.Font("Tahoma", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_box.Location = New System.Drawing.Point(103, 66)
        Me.quantity_box.Name = "quantity_box"
        Me.quantity_box.Size = New System.Drawing.Size(184, 47)
        Me.quantity_box.TabIndex = 3
        Me.quantity_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(99, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Ordered Stock:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel9.Location = New System.Drawing.Point(4, 32)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(380, 2)
        Me.Panel9.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(17, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Update The Current Stock Quantity"
        '
        'list_grid
        '
        Me.list_grid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.list_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.list_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.list_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.list_grid.Location = New System.Drawing.Point(0, 0)
        Me.list_grid.Name = "list_grid"
        Me.list_grid.RowHeadersWidth = 51
        Me.list_grid.RowTemplate.Height = 24
        Me.list_grid.Size = New System.Drawing.Size(1564, 667)
        Me.list_grid.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Yellow
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1564, 1)
        Me.Panel6.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.update_product)
        Me.Panel4.Controls.Add(Me.Return_product)
        Me.Panel4.Controls.Add(Me.Write_off)
        Me.Panel4.Controls.Add(Me.NewStock_button)
        Me.Panel4.Controls.Add(Me.Delete_button)
        Me.Panel4.Controls.Add(Me.search_button)
        Me.Panel4.Controls.Add(Me.Refresh_button)
        Me.Panel4.Controls.Add(Me.SEARCH_BOX)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1564, 55)
        Me.Panel4.TabIndex = 1
        '
        'update_product
        '
        Me.update_product.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.update_product.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_product.ForeColor = System.Drawing.Color.Blue
        Me.update_product.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.update_product.IconColor = System.Drawing.Color.Blue
        Me.update_product.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.update_product.IconSize = 30
        Me.update_product.Location = New System.Drawing.Point(1279, 16)
        Me.update_product.Name = "update_product"
        Me.update_product.Size = New System.Drawing.Size(163, 31)
        Me.update_product.TabIndex = 5
        Me.update_product.Text = "Update Product"
        Me.update_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.update_product.UseVisualStyleBackColor = True
        '
        'Return_product
        '
        Me.Return_product.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Return_product.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Return_product.ForeColor = System.Drawing.Color.Teal
        Me.Return_product.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.Return_product.IconColor = System.Drawing.Color.Teal
        Me.Return_product.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Return_product.IconSize = 30
        Me.Return_product.Location = New System.Drawing.Point(1112, 16)
        Me.Return_product.Name = "Return_product"
        Me.Return_product.Size = New System.Drawing.Size(161, 31)
        Me.Return_product.TabIndex = 5
        Me.Return_product.Text = "Return Product"
        Me.Return_product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Return_product.UseVisualStyleBackColor = True
        '
        'Write_off
        '
        Me.Write_off.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Write_off.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Write_off.ForeColor = System.Drawing.Color.DarkRed
        Me.Write_off.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.Write_off.IconColor = System.Drawing.Color.DarkRed
        Me.Write_off.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Write_off.IconSize = 30
        Me.Write_off.Location = New System.Drawing.Point(976, 16)
        Me.Write_off.Name = "Write_off"
        Me.Write_off.Size = New System.Drawing.Size(130, 31)
        Me.Write_off.TabIndex = 7
        Me.Write_off.Text = "Write Off"
        Me.Write_off.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Write_off.UseVisualStyleBackColor = True
        '
        'NewStock_button
        '
        Me.NewStock_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewStock_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewStock_button.ForeColor = System.Drawing.Color.MidnightBlue
        Me.NewStock_button.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.NewStock_button.IconColor = System.Drawing.Color.MidnightBlue
        Me.NewStock_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.NewStock_button.IconSize = 30
        Me.NewStock_button.Location = New System.Drawing.Point(840, 16)
        Me.NewStock_button.Name = "NewStock_button"
        Me.NewStock_button.Size = New System.Drawing.Size(130, 31)
        Me.NewStock_button.TabIndex = 6
        Me.NewStock_button.Text = "New Stock"
        Me.NewStock_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NewStock_button.UseVisualStyleBackColor = True
        '
        'Delete_button
        '
        Me.Delete_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Delete_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_button.ForeColor = System.Drawing.Color.Red
        Me.Delete_button.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.Delete_button.IconColor = System.Drawing.Color.Red
        Me.Delete_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Delete_button.IconSize = 26
        Me.Delete_button.Location = New System.Drawing.Point(724, 16)
        Me.Delete_button.Name = "Delete_button"
        Me.Delete_button.Size = New System.Drawing.Size(110, 31)
        Me.Delete_button.TabIndex = 5
        Me.Delete_button.Text = "Delete"
        Me.Delete_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Delete_button.UseVisualStyleBackColor = True
        '
        'search_button
        '
        Me.search_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.search_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_button.ForeColor = System.Drawing.Color.Indigo
        Me.search_button.IconChar = FontAwesome.Sharp.IconChar.SearchPlus
        Me.search_button.IconColor = System.Drawing.Color.Indigo
        Me.search_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.search_button.IconSize = 30
        Me.search_button.Location = New System.Drawing.Point(608, 15)
        Me.search_button.Name = "search_button"
        Me.search_button.Size = New System.Drawing.Size(110, 31)
        Me.search_button.TabIndex = 4
        Me.search_button.Text = "Search"
        Me.search_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.search_button.UseVisualStyleBackColor = True
        '
        'Refresh_button
        '
        Me.Refresh_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Refresh_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh_button.ForeColor = System.Drawing.Color.DarkGreen
        Me.Refresh_button.IconChar = FontAwesome.Sharp.IconChar.Recycle
        Me.Refresh_button.IconColor = System.Drawing.Color.DarkGreen
        Me.Refresh_button.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Refresh_button.IconSize = 30
        Me.Refresh_button.Location = New System.Drawing.Point(1448, 16)
        Me.Refresh_button.Name = "Refresh_button"
        Me.Refresh_button.Size = New System.Drawing.Size(110, 31)
        Me.Refresh_button.TabIndex = 3
        Me.Refresh_button.Text = "Refresh"
        Me.Refresh_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Refresh_button.UseVisualStyleBackColor = True
        '
        'SEARCH_BOX
        '
        Me.SEARCH_BOX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SEARCH_BOX.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCH_BOX.ForeColor = System.Drawing.Color.SaddleBrown
        Me.SEARCH_BOX.Location = New System.Drawing.Point(85, 16)
        Me.SEARCH_BOX.Name = "SEARCH_BOX"
        Me.SEARCH_BOX.Size = New System.Drawing.Size(517, 29)
        Me.SEARCH_BOX.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Tomato
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1564, 3)
        Me.Panel2.TabIndex = 0
        '
        'inventory_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1564, 726)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "inventory_list"
        Me.Text = "INVENTORY LIST"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.panel_Stock.ResumeLayout(False)
        Me.panel_Stock.PerformLayout()
        CType(Me.list_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents list_grid As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SEARCH_BOX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents update_product As FontAwesome.Sharp.IconButton
    Friend WithEvents Return_product As FontAwesome.Sharp.IconButton
    Friend WithEvents Write_off As FontAwesome.Sharp.IconButton
    Friend WithEvents NewStock_button As FontAwesome.Sharp.IconButton
    Friend WithEvents Delete_button As FontAwesome.Sharp.IconButton
    Friend WithEvents search_button As FontAwesome.Sharp.IconButton
    Friend WithEvents Refresh_button As FontAwesome.Sharp.IconButton
    Friend WithEvents panel_Stock As Panel
    Friend WithEvents Save_button As Button
    Friend WithEvents quantity_box As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label2 As Label
End Class
