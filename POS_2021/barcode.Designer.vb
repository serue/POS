<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class barcode
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.clear_button = New System.Windows.Forms.Button()
        Me.l = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.encode_button = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 6)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.clear_button)
        Me.Panel2.Controls.Add(Me.l)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.pic)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.encode_button)
        Me.Panel2.Controls.Add(Me.txtInput)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 6)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 433)
        Me.Panel2.TabIndex = 9
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(255, 330)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 28)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "load barcode"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'clear_button
        '
        Me.clear_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_button.Location = New System.Drawing.Point(371, 366)
        Me.clear_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Size = New System.Drawing.Size(216, 28)
        Me.clear_button.TabIndex = 18
        Me.clear_button.Text = "Clear All Inputs"
        Me.clear_button.UseVisualStyleBackColor = True
        '
        'l
        '
        Me.l.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l.Location = New System.Drawing.Point(55, 366)
        Me.l.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(216, 28)
        Me.l.TabIndex = 17
        Me.l.Text = "Save To Database"
        Me.l.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Barcodes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 272)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Input the text"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(445, 330)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 28)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "load barcode"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'encode_button
        '
        Me.encode_button.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.encode_button.Location = New System.Drawing.Point(55, 330)
        Me.encode_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.encode_button.Name = "encode_button"
        Me.encode_button.Size = New System.Drawing.Size(136, 28)
        Me.encode_button.TabIndex = 9
        Me.encode_button.Text = "Encode barcode"
        Me.encode_button.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(55, 293)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(531, 28)
        Me.txtInput.TabIndex = 8
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(55, 46)
        Me.pic.Margin = New System.Windows.Forms.Padding(4)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(532, 204)
        Me.pic.TabIndex = 11
        Me.pic.TabStop = False
        '
        'barcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(649, 439)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "barcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate Your Organisational Barcodes"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pic As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents encode_button As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents clear_button As System.Windows.Forms.Button
    Friend WithEvents l As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
