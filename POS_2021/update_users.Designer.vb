<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_users
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.delete_user = New FontAwesome.Sharp.IconButton()
        Me.activate_user = New FontAwesome.Sharp.IconButton()
        Me.deactivate_user = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.user_grid = New MetroFramework.Controls.MetroGrid()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.user_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(970, 3)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.deactivate_user)
        Me.Panel2.Controls.Add(Me.activate_user)
        Me.Panel2.Controls.Add(Me.delete_user)
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(970, 50)
        Me.Panel2.TabIndex = 1
        '
        'IconButton1
        '
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Indigo
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.IconButton1.IconColor = System.Drawing.Color.SeaGreen
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 25
        Me.IconButton1.Location = New System.Drawing.Point(27, 9)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(139, 29)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.Text = "Edit User Details"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'delete_user
        '
        Me.delete_user.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.delete_user.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_user.ForeColor = System.Drawing.Color.Indigo
        Me.delete_user.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.delete_user.IconColor = System.Drawing.Color.DarkRed
        Me.delete_user.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.delete_user.IconSize = 25
        Me.delete_user.Location = New System.Drawing.Point(185, 9)
        Me.delete_user.Name = "delete_user"
        Me.delete_user.Rotation = 0R
        Me.delete_user.Size = New System.Drawing.Size(138, 29)
        Me.delete_user.TabIndex = 1
        Me.delete_user.Text = "Delete User"
        Me.delete_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.delete_user.UseVisualStyleBackColor = True
        '
        'activate_user
        '
        Me.activate_user.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.activate_user.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activate_user.ForeColor = System.Drawing.Color.Indigo
        Me.activate_user.IconChar = FontAwesome.Sharp.IconChar.Adjust
        Me.activate_user.IconColor = System.Drawing.Color.SaddleBrown
        Me.activate_user.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.activate_user.IconSize = 25
        Me.activate_user.Location = New System.Drawing.Point(347, 9)
        Me.activate_user.Name = "activate_user"
        Me.activate_user.Rotation = 0R
        Me.activate_user.Size = New System.Drawing.Size(135, 29)
        Me.activate_user.TabIndex = 2
        Me.activate_user.Text = "Activate User"
        Me.activate_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.activate_user.UseVisualStyleBackColor = True
        '
        'deactivate_user
        '
        Me.deactivate_user.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.deactivate_user.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deactivate_user.ForeColor = System.Drawing.Color.Indigo
        Me.deactivate_user.IconChar = FontAwesome.Sharp.IconChar.Dev
        Me.deactivate_user.IconColor = System.Drawing.Color.Purple
        Me.deactivate_user.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.deactivate_user.IconSize = 25
        Me.deactivate_user.Location = New System.Drawing.Point(493, 9)
        Me.deactivate_user.Name = "deactivate_user"
        Me.deactivate_user.Rotation = 0R
        Me.deactivate_user.Size = New System.Drawing.Size(135, 29)
        Me.deactivate_user.TabIndex = 3
        Me.deactivate_user.Text = "Deactivate User"
        Me.deactivate_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.deactivate_user.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.user_grid)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(970, 447)
        Me.Panel3.TabIndex = 2
        '
        'user_grid
        '
        Me.user_grid.AllowUserToAddRows = False
        Me.user_grid.AllowUserToResizeRows = False
        Me.user_grid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.user_grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.user_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.user_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.user_grid.ColumnHeadersHeight = 35
        Me.user_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.user_grid.DefaultCellStyle = DataGridViewCellStyle8
        Me.user_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.user_grid.EnableHeadersVisualStyles = False
        Me.user_grid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.user_grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.user_grid.Location = New System.Drawing.Point(0, 0)
        Me.user_grid.Name = "user_grid"
        Me.user_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.user_grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.user_grid.RowHeadersWidth = 15
        Me.user_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.user_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.user_grid.Size = New System.Drawing.Size(970, 447)
        Me.user_grid.TabIndex = 0
        '
        'update_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 500)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "update_users"
        Me.Text = "update_users"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.user_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents deactivate_user As FontAwesome.Sharp.IconButton
    Friend WithEvents activate_user As FontAwesome.Sharp.IconButton
    Friend WithEvents delete_user As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents user_grid As MetroFramework.Controls.MetroGrid
End Class
