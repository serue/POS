<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returns
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cancel_button = New System.Windows.Forms.Button()
        Me.clear_button = New System.Windows.Forms.Button()
        Me.transaction_button = New System.Windows.Forms.Button()
        Me.contact_textbox = New MetroFramework.Controls.MetroTextBox()
        Me.customer_textbox = New MetroFramework.Controls.MetroTextBox()
        Me.Reason_for_return = New MetroFramework.Controls.MetroTextBox()
        Me.transaction_id = New MetroFramework.Controls.MetroComboBox()
        Me.quantity_textbox = New MetroFramework.Controls.MetroTextBox()
        Me.AMOUNT_TEXTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.barcode_textbox = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 3)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cancel_button)
        Me.GroupBox1.Controls.Add(Me.clear_button)
        Me.GroupBox1.Controls.Add(Me.transaction_button)
        Me.GroupBox1.Controls.Add(Me.contact_textbox)
        Me.GroupBox1.Controls.Add(Me.customer_textbox)
        Me.GroupBox1.Controls.Add(Me.Reason_for_return)
        Me.GroupBox1.Controls.Add(Me.transaction_id)
        Me.GroupBox1.Controls.Add(Me.quantity_textbox)
        Me.GroupBox1.Controls.Add(Me.AMOUNT_TEXTBOX)
        Me.GroupBox1.Controls.Add(Me.barcode_textbox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 338)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Returning Sales from the customer"
        '
        'cancel_button
        '
        Me.cancel_button.Location = New System.Drawing.Point(246, 266)
        Me.cancel_button.Name = "cancel_button"
        Me.cancel_button.Size = New System.Drawing.Size(80, 32)
        Me.cancel_button.TabIndex = 16
        Me.cancel_button.Text = "Cancel"
        Me.cancel_button.UseVisualStyleBackColor = True
        '
        'clear_button
        '
        Me.clear_button.Location = New System.Drawing.Point(332, 266)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Size = New System.Drawing.Size(84, 32)
        Me.clear_button.TabIndex = 15
        Me.clear_button.Text = "Clear"
        Me.clear_button.UseVisualStyleBackColor = True
        '
        'transaction_button
        '
        Me.transaction_button.Location = New System.Drawing.Point(420, 267)
        Me.transaction_button.Name = "transaction_button"
        Me.transaction_button.Size = New System.Drawing.Size(162, 32)
        Me.transaction_button.TabIndex = 14
        Me.transaction_button.Text = "Process Transaction"
        Me.transaction_button.UseVisualStyleBackColor = True
        '
        'contact_textbox
        '
        '
        '
        '
        Me.contact_textbox.CustomButton.Image = Nothing
        Me.contact_textbox.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.contact_textbox.CustomButton.Name = ""
        Me.contact_textbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.contact_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.contact_textbox.CustomButton.TabIndex = 1
        Me.contact_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.contact_textbox.CustomButton.UseSelectable = True
        Me.contact_textbox.CustomButton.Visible = False
        Me.contact_textbox.Lines = New String(-1) {}
        Me.contact_textbox.Location = New System.Drawing.Point(210, 222)
        Me.contact_textbox.MaxLength = 32767
        Me.contact_textbox.Name = "contact_textbox"
        Me.contact_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contact_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.contact_textbox.SelectedText = ""
        Me.contact_textbox.SelectionLength = 0
        Me.contact_textbox.SelectionStart = 0
        Me.contact_textbox.ShortcutsEnabled = True
        Me.contact_textbox.Size = New System.Drawing.Size(372, 23)
        Me.contact_textbox.TabIndex = 13
        Me.contact_textbox.UseSelectable = True
        Me.contact_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.contact_textbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'customer_textbox
        '
        '
        '
        '
        Me.customer_textbox.CustomButton.Image = Nothing
        Me.customer_textbox.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.customer_textbox.CustomButton.Name = ""
        Me.customer_textbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.customer_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.customer_textbox.CustomButton.TabIndex = 1
        Me.customer_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.customer_textbox.CustomButton.UseSelectable = True
        Me.customer_textbox.CustomButton.Visible = False
        Me.customer_textbox.Lines = New String(-1) {}
        Me.customer_textbox.Location = New System.Drawing.Point(209, 194)
        Me.customer_textbox.MaxLength = 32767
        Me.customer_textbox.Name = "customer_textbox"
        Me.customer_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.customer_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.customer_textbox.SelectedText = ""
        Me.customer_textbox.SelectionLength = 0
        Me.customer_textbox.SelectionStart = 0
        Me.customer_textbox.ShortcutsEnabled = True
        Me.customer_textbox.Size = New System.Drawing.Size(372, 23)
        Me.customer_textbox.TabIndex = 12
        Me.customer_textbox.UseSelectable = True
        Me.customer_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.customer_textbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Reason_for_return
        '
        '
        '
        '
        Me.Reason_for_return.CustomButton.Image = Nothing
        Me.Reason_for_return.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.Reason_for_return.CustomButton.Name = ""
        Me.Reason_for_return.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.Reason_for_return.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Reason_for_return.CustomButton.TabIndex = 1
        Me.Reason_for_return.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Reason_for_return.CustomButton.UseSelectable = True
        Me.Reason_for_return.CustomButton.Visible = False
        Me.Reason_for_return.Lines = New String(-1) {}
        Me.Reason_for_return.Location = New System.Drawing.Point(210, 165)
        Me.Reason_for_return.MaxLength = 32767
        Me.Reason_for_return.Name = "Reason_for_return"
        Me.Reason_for_return.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Reason_for_return.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Reason_for_return.SelectedText = ""
        Me.Reason_for_return.SelectionLength = 0
        Me.Reason_for_return.SelectionStart = 0
        Me.Reason_for_return.ShortcutsEnabled = True
        Me.Reason_for_return.Size = New System.Drawing.Size(372, 23)
        Me.Reason_for_return.TabIndex = 11
        Me.Reason_for_return.UseSelectable = True
        Me.Reason_for_return.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Reason_for_return.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'transaction_id
        '
        Me.transaction_id.DisplayFocus = True
        Me.transaction_id.FormattingEnabled = True
        Me.transaction_id.ItemHeight = 23
        Me.transaction_id.Location = New System.Drawing.Point(211, 130)
        Me.transaction_id.Name = "transaction_id"
        Me.transaction_id.Size = New System.Drawing.Size(372, 29)
        Me.transaction_id.TabIndex = 10
        Me.transaction_id.UseSelectable = True
        '
        'quantity_textbox
        '
        '
        '
        '
        Me.quantity_textbox.CustomButton.Image = Nothing
        Me.quantity_textbox.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.quantity_textbox.CustomButton.Name = ""
        Me.quantity_textbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.quantity_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.quantity_textbox.CustomButton.TabIndex = 1
        Me.quantity_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.quantity_textbox.CustomButton.UseSelectable = True
        Me.quantity_textbox.CustomButton.Visible = False
        Me.quantity_textbox.Lines = New String(-1) {}
        Me.quantity_textbox.Location = New System.Drawing.Point(211, 100)
        Me.quantity_textbox.MaxLength = 32767
        Me.quantity_textbox.Name = "quantity_textbox"
        Me.quantity_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.quantity_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.quantity_textbox.SelectedText = ""
        Me.quantity_textbox.SelectionLength = 0
        Me.quantity_textbox.SelectionStart = 0
        Me.quantity_textbox.ShortcutsEnabled = True
        Me.quantity_textbox.Size = New System.Drawing.Size(372, 23)
        Me.quantity_textbox.TabIndex = 9
        Me.quantity_textbox.UseSelectable = True
        Me.quantity_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.quantity_textbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'AMOUNT_TEXTBOX
        '
        '
        '
        '
        Me.AMOUNT_TEXTBOX.CustomButton.Image = Nothing
        Me.AMOUNT_TEXTBOX.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.AMOUNT_TEXTBOX.CustomButton.Name = ""
        Me.AMOUNT_TEXTBOX.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.AMOUNT_TEXTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.AMOUNT_TEXTBOX.CustomButton.TabIndex = 1
        Me.AMOUNT_TEXTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.AMOUNT_TEXTBOX.CustomButton.UseSelectable = True
        Me.AMOUNT_TEXTBOX.CustomButton.Visible = False
        Me.AMOUNT_TEXTBOX.Lines = New String(-1) {}
        Me.AMOUNT_TEXTBOX.Location = New System.Drawing.Point(211, 73)
        Me.AMOUNT_TEXTBOX.MaxLength = 32767
        Me.AMOUNT_TEXTBOX.Name = "AMOUNT_TEXTBOX"
        Me.AMOUNT_TEXTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AMOUNT_TEXTBOX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AMOUNT_TEXTBOX.SelectedText = ""
        Me.AMOUNT_TEXTBOX.SelectionLength = 0
        Me.AMOUNT_TEXTBOX.SelectionStart = 0
        Me.AMOUNT_TEXTBOX.ShortcutsEnabled = True
        Me.AMOUNT_TEXTBOX.Size = New System.Drawing.Size(372, 23)
        Me.AMOUNT_TEXTBOX.TabIndex = 8
        Me.AMOUNT_TEXTBOX.UseSelectable = True
        Me.AMOUNT_TEXTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AMOUNT_TEXTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'barcode_textbox
        '
        '
        '
        '
        Me.barcode_textbox.CustomButton.Image = Nothing
        Me.barcode_textbox.CustomButton.Location = New System.Drawing.Point(350, 1)
        Me.barcode_textbox.CustomButton.Name = ""
        Me.barcode_textbox.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.barcode_textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.barcode_textbox.CustomButton.TabIndex = 1
        Me.barcode_textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.barcode_textbox.CustomButton.UseSelectable = True
        Me.barcode_textbox.CustomButton.Visible = False
        Me.barcode_textbox.Lines = New String(-1) {}
        Me.barcode_textbox.Location = New System.Drawing.Point(211, 44)
        Me.barcode_textbox.MaxLength = 32767
        Me.barcode_textbox.Name = "barcode_textbox"
        Me.barcode_textbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.barcode_textbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.barcode_textbox.SelectedText = ""
        Me.barcode_textbox.SelectionLength = 0
        Me.barcode_textbox.SelectionStart = 0
        Me.barcode_textbox.ShortcutsEnabled = True
        Me.barcode_textbox.Size = New System.Drawing.Size(372, 23)
        Me.barcode_textbox.TabIndex = 7
        Me.barcode_textbox.UseSelectable = True
        Me.barcode_textbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.barcode_textbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contact:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Customer:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Reason for Return:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Transaction ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode:"
        '
        'returns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 348)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "returns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return a Sale from a Client"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents quantity_textbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents AMOUNT_TEXTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents barcode_textbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cancel_button As Button
    Friend WithEvents clear_button As Button
    Friend WithEvents transaction_button As Button
    Friend WithEvents contact_textbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents customer_textbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Reason_for_return As MetroFramework.Controls.MetroTextBox
    Friend WithEvents transaction_id As MetroFramework.Controls.MetroComboBox
End Class
