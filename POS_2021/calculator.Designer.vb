<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculator
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
        Me.holder_label = New System.Windows.Forms.Label()
        Me.backspace = New FontAwesome.Sharp.IconButton()
        Me.equal = New System.Windows.Forms.Button()
        Me.plus = New System.Windows.Forms.Button()
        Me.comma = New System.Windows.Forms.Button()
        Me.three = New System.Windows.Forms.Button()
        Me.plus_minus_button = New System.Windows.Forms.Button()
        Me.one = New System.Windows.Forms.Button()
        Me.zero = New System.Windows.Forms.Button()
        Me.two = New System.Windows.Forms.Button()
        Me.fraction_button = New System.Windows.Forms.Button()
        Me.cubed_button = New System.Windows.Forms.Button()
        Me.minus = New System.Windows.Forms.Button()
        Me.six = New System.Windows.Forms.Button()
        Me.four = New System.Windows.Forms.Button()
        Me.five = New System.Windows.Forms.Button()
        Me.squared_button = New System.Windows.Forms.Button()
        Me.times = New System.Windows.Forms.Button()
        Me.nine = New System.Windows.Forms.Button()
        Me.seven = New System.Windows.Forms.Button()
        Me.eight = New System.Windows.Forms.Button()
        Me.squareroot_button = New System.Windows.Forms.Button()
        Me.devide = New System.Windows.Forms.Button()
        Me.cancel_all = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.percentage_button = New System.Windows.Forms.Button()
        Me.solution_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.holder_label)
        Me.Panel1.Controls.Add(Me.backspace)
        Me.Panel1.Controls.Add(Me.equal)
        Me.Panel1.Controls.Add(Me.plus)
        Me.Panel1.Controls.Add(Me.comma)
        Me.Panel1.Controls.Add(Me.three)
        Me.Panel1.Controls.Add(Me.plus_minus_button)
        Me.Panel1.Controls.Add(Me.one)
        Me.Panel1.Controls.Add(Me.zero)
        Me.Panel1.Controls.Add(Me.two)
        Me.Panel1.Controls.Add(Me.fraction_button)
        Me.Panel1.Controls.Add(Me.cubed_button)
        Me.Panel1.Controls.Add(Me.minus)
        Me.Panel1.Controls.Add(Me.six)
        Me.Panel1.Controls.Add(Me.four)
        Me.Panel1.Controls.Add(Me.five)
        Me.Panel1.Controls.Add(Me.squared_button)
        Me.Panel1.Controls.Add(Me.times)
        Me.Panel1.Controls.Add(Me.nine)
        Me.Panel1.Controls.Add(Me.seven)
        Me.Panel1.Controls.Add(Me.eight)
        Me.Panel1.Controls.Add(Me.squareroot_button)
        Me.Panel1.Controls.Add(Me.devide)
        Me.Panel1.Controls.Add(Me.cancel_all)
        Me.Panel1.Controls.Add(Me.cancel)
        Me.Panel1.Controls.Add(Me.percentage_button)
        Me.Panel1.Controls.Add(Me.solution_box)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 652)
        Me.Panel1.TabIndex = 0
        '
        'holder_label
        '
        Me.holder_label.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.holder_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.holder_label.Location = New System.Drawing.Point(185, 7)
        Me.holder_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.holder_label.Name = "holder_label"
        Me.holder_label.Size = New System.Drawing.Size(364, 22)
        Me.holder_label.TabIndex = 57
        Me.holder_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'backspace
        '
        Me.backspace.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.backspace.BackColor = System.Drawing.SystemColors.Control
        Me.backspace.FlatAppearance.BorderSize = 0
        Me.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backspace.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.backspace.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.backspace.IconColor = System.Drawing.Color.DimGray
        Me.backspace.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.backspace.IconSize = 40
        Me.backspace.Location = New System.Drawing.Point(340, 102)
        Me.backspace.Margin = New System.Windows.Forms.Padding(2)
        Me.backspace.Name = "backspace"
        Me.backspace.Rotation = 0R
        Me.backspace.Size = New System.Drawing.Size(109, 106)
        Me.backspace.TabIndex = 56
        Me.backspace.UseVisualStyleBackColor = False
        '
        'equal
        '
        Me.equal.FlatAppearance.BorderSize = 0
        Me.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equal.Location = New System.Drawing.Point(449, 535)
        Me.equal.Margin = New System.Windows.Forms.Padding(2)
        Me.equal.Name = "equal"
        Me.equal.Size = New System.Drawing.Size(109, 106)
        Me.equal.TabIndex = 5
        Me.equal.Text = "="
        Me.equal.UseVisualStyleBackColor = True
        '
        'plus
        '
        Me.plus.FlatAppearance.BorderSize = 0
        Me.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.plus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plus.Location = New System.Drawing.Point(453, 427)
        Me.plus.Margin = New System.Windows.Forms.Padding(2)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(109, 106)
        Me.plus.TabIndex = 5
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = True
        '
        'comma
        '
        Me.comma.FlatAppearance.BorderSize = 0
        Me.comma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comma.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comma.Location = New System.Drawing.Point(338, 535)
        Me.comma.Margin = New System.Windows.Forms.Padding(2)
        Me.comma.Name = "comma"
        Me.comma.Size = New System.Drawing.Size(109, 106)
        Me.comma.TabIndex = 5
        Me.comma.Text = "."
        Me.comma.UseVisualStyleBackColor = True
        '
        'three
        '
        Me.three.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.three.FlatAppearance.BorderSize = 0
        Me.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.three.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.three.Location = New System.Drawing.Point(338, 427)
        Me.three.Margin = New System.Windows.Forms.Padding(2)
        Me.three.Name = "three"
        Me.three.Size = New System.Drawing.Size(109, 106)
        Me.three.TabIndex = 5
        Me.three.Text = "3"
        Me.three.UseVisualStyleBackColor = False
        '
        'plus_minus_button
        '
        Me.plus_minus_button.FlatAppearance.BorderSize = 0
        Me.plus_minus_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.plus_minus_button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plus_minus_button.Location = New System.Drawing.Point(116, 535)
        Me.plus_minus_button.Margin = New System.Windows.Forms.Padding(2)
        Me.plus_minus_button.Name = "plus_minus_button"
        Me.plus_minus_button.Size = New System.Drawing.Size(109, 106)
        Me.plus_minus_button.TabIndex = 5
        Me.plus_minus_button.Text = "±"
        Me.plus_minus_button.UseVisualStyleBackColor = True
        '
        'one
        '
        Me.one.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.one.FlatAppearance.BorderSize = 0
        Me.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.one.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.one.Location = New System.Drawing.Point(116, 427)
        Me.one.Margin = New System.Windows.Forms.Padding(2)
        Me.one.Name = "one"
        Me.one.Size = New System.Drawing.Size(109, 106)
        Me.one.TabIndex = 5
        Me.one.Text = "1"
        Me.one.UseVisualStyleBackColor = False
        '
        'zero
        '
        Me.zero.FlatAppearance.BorderSize = 0
        Me.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.zero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zero.Location = New System.Drawing.Point(227, 535)
        Me.zero.Margin = New System.Windows.Forms.Padding(2)
        Me.zero.Name = "zero"
        Me.zero.Size = New System.Drawing.Size(109, 106)
        Me.zero.TabIndex = 5
        Me.zero.Text = "0"
        Me.zero.UseVisualStyleBackColor = True
        '
        'two
        '
        Me.two.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.two.FlatAppearance.BorderSize = 0
        Me.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.two.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.two.Location = New System.Drawing.Point(227, 427)
        Me.two.Margin = New System.Windows.Forms.Padding(2)
        Me.two.Name = "two"
        Me.two.Size = New System.Drawing.Size(109, 106)
        Me.two.TabIndex = 5
        Me.two.Text = "2"
        Me.two.UseVisualStyleBackColor = False
        '
        'fraction_button
        '
        Me.fraction_button.FlatAppearance.BorderSize = 0
        Me.fraction_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fraction_button.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraction_button.Location = New System.Drawing.Point(5, 535)
        Me.fraction_button.Margin = New System.Windows.Forms.Padding(2)
        Me.fraction_button.Name = "fraction_button"
        Me.fraction_button.Size = New System.Drawing.Size(109, 106)
        Me.fraction_button.TabIndex = 5
        Me.fraction_button.Text = "¹̷ x"
        Me.fraction_button.UseVisualStyleBackColor = True
        '
        'cubed_button
        '
        Me.cubed_button.FlatAppearance.BorderSize = 0
        Me.cubed_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cubed_button.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cubed_button.Location = New System.Drawing.Point(5, 427)
        Me.cubed_button.Margin = New System.Windows.Forms.Padding(2)
        Me.cubed_button.Name = "cubed_button"
        Me.cubed_button.Size = New System.Drawing.Size(109, 106)
        Me.cubed_button.TabIndex = 5
        Me.cubed_button.Text = "x³"
        Me.cubed_button.UseVisualStyleBackColor = True
        '
        'minus
        '
        Me.minus.FlatAppearance.BorderSize = 0
        Me.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minus.Location = New System.Drawing.Point(453, 318)
        Me.minus.Margin = New System.Windows.Forms.Padding(2)
        Me.minus.Name = "minus"
        Me.minus.Size = New System.Drawing.Size(109, 106)
        Me.minus.TabIndex = 4
        Me.minus.Text = "-"
        Me.minus.UseVisualStyleBackColor = True
        '
        'six
        '
        Me.six.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.six.FlatAppearance.BorderSize = 0
        Me.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.six.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.six.Location = New System.Drawing.Point(338, 318)
        Me.six.Margin = New System.Windows.Forms.Padding(2)
        Me.six.Name = "six"
        Me.six.Size = New System.Drawing.Size(109, 106)
        Me.six.TabIndex = 4
        Me.six.Text = "6"
        Me.six.UseVisualStyleBackColor = False
        '
        'four
        '
        Me.four.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.four.FlatAppearance.BorderSize = 0
        Me.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.four.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.four.Location = New System.Drawing.Point(116, 318)
        Me.four.Margin = New System.Windows.Forms.Padding(2)
        Me.four.Name = "four"
        Me.four.Size = New System.Drawing.Size(109, 106)
        Me.four.TabIndex = 4
        Me.four.Text = "4"
        Me.four.UseVisualStyleBackColor = False
        '
        'five
        '
        Me.five.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.five.FlatAppearance.BorderSize = 0
        Me.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.five.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.five.Location = New System.Drawing.Point(227, 318)
        Me.five.Margin = New System.Windows.Forms.Padding(2)
        Me.five.Name = "five"
        Me.five.Size = New System.Drawing.Size(109, 106)
        Me.five.TabIndex = 4
        Me.five.Text = "5"
        Me.five.UseVisualStyleBackColor = False
        '
        'squared_button
        '
        Me.squared_button.FlatAppearance.BorderSize = 0
        Me.squared_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.squared_button.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.squared_button.Location = New System.Drawing.Point(5, 318)
        Me.squared_button.Margin = New System.Windows.Forms.Padding(2)
        Me.squared_button.Name = "squared_button"
        Me.squared_button.Size = New System.Drawing.Size(109, 106)
        Me.squared_button.TabIndex = 4
        Me.squared_button.Text = "x²"
        Me.squared_button.UseVisualStyleBackColor = True
        '
        'times
        '
        Me.times.FlatAppearance.BorderSize = 0
        Me.times.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.times.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.times.Location = New System.Drawing.Point(453, 210)
        Me.times.Margin = New System.Windows.Forms.Padding(2)
        Me.times.Name = "times"
        Me.times.Size = New System.Drawing.Size(109, 106)
        Me.times.TabIndex = 3
        Me.times.Text = "x"
        Me.times.UseVisualStyleBackColor = True
        '
        'nine
        '
        Me.nine.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nine.FlatAppearance.BorderSize = 0
        Me.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nine.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nine.Location = New System.Drawing.Point(338, 210)
        Me.nine.Margin = New System.Windows.Forms.Padding(2)
        Me.nine.Name = "nine"
        Me.nine.Size = New System.Drawing.Size(109, 106)
        Me.nine.TabIndex = 3
        Me.nine.Text = "9"
        Me.nine.UseVisualStyleBackColor = False
        '
        'seven
        '
        Me.seven.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.seven.FlatAppearance.BorderSize = 0
        Me.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seven.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seven.Location = New System.Drawing.Point(116, 210)
        Me.seven.Margin = New System.Windows.Forms.Padding(2)
        Me.seven.Name = "seven"
        Me.seven.Size = New System.Drawing.Size(109, 106)
        Me.seven.TabIndex = 3
        Me.seven.Text = "7"
        Me.seven.UseVisualStyleBackColor = False
        '
        'eight
        '
        Me.eight.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.eight.FlatAppearance.BorderSize = 0
        Me.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eight.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eight.Location = New System.Drawing.Point(227, 210)
        Me.eight.Margin = New System.Windows.Forms.Padding(2)
        Me.eight.Name = "eight"
        Me.eight.Size = New System.Drawing.Size(109, 106)
        Me.eight.TabIndex = 3
        Me.eight.Text = "8"
        Me.eight.UseVisualStyleBackColor = False
        '
        'squareroot_button
        '
        Me.squareroot_button.FlatAppearance.BorderSize = 0
        Me.squareroot_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.squareroot_button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.squareroot_button.Location = New System.Drawing.Point(5, 210)
        Me.squareroot_button.Margin = New System.Windows.Forms.Padding(2)
        Me.squareroot_button.Name = "squareroot_button"
        Me.squareroot_button.Size = New System.Drawing.Size(109, 106)
        Me.squareroot_button.TabIndex = 3
        Me.squareroot_button.Text = "√"
        Me.squareroot_button.UseVisualStyleBackColor = True
        '
        'devide
        '
        Me.devide.FlatAppearance.BorderSize = 0
        Me.devide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.devide.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devide.Location = New System.Drawing.Point(453, 102)
        Me.devide.Margin = New System.Windows.Forms.Padding(2)
        Me.devide.Name = "devide"
        Me.devide.Size = New System.Drawing.Size(109, 106)
        Me.devide.TabIndex = 2
        Me.devide.Text = "÷"
        Me.devide.UseVisualStyleBackColor = True
        '
        'cancel_all
        '
        Me.cancel_all.FlatAppearance.BorderSize = 0
        Me.cancel_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel_all.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_all.Location = New System.Drawing.Point(116, 102)
        Me.cancel_all.Margin = New System.Windows.Forms.Padding(2)
        Me.cancel_all.Name = "cancel_all"
        Me.cancel_all.Size = New System.Drawing.Size(109, 106)
        Me.cancel_all.TabIndex = 2
        Me.cancel_all.Text = "CE"
        Me.cancel_all.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.FlatAppearance.BorderSize = 0
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(227, 102)
        Me.cancel.Margin = New System.Windows.Forms.Padding(2)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(109, 106)
        Me.cancel.TabIndex = 2
        Me.cancel.Text = "C"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'percentage_button
        '
        Me.percentage_button.FlatAppearance.BorderSize = 0
        Me.percentage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.percentage_button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.percentage_button.Location = New System.Drawing.Point(5, 102)
        Me.percentage_button.Margin = New System.Windows.Forms.Padding(2)
        Me.percentage_button.Name = "percentage_button"
        Me.percentage_button.Size = New System.Drawing.Size(109, 106)
        Me.percentage_button.TabIndex = 2
        Me.percentage_button.Text = "%"
        Me.percentage_button.UseVisualStyleBackColor = True
        '
        'solution_box
        '
        Me.solution_box.BackColor = System.Drawing.SystemColors.Control
        Me.solution_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.solution_box.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solution_box.Location = New System.Drawing.Point(2, 34)
        Me.solution_box.Margin = New System.Windows.Forms.Padding(2, 2, 19, 2)
        Me.solution_box.Name = "solution_box"
        Me.solution_box.Size = New System.Drawing.Size(548, 44)
        Me.solution_box.TabIndex = 1
        Me.solution_box.Text = "0"
        Me.solution_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Standard"
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.Location = New System.Drawing.Point(5, 6)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(44, 23)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 652)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS system Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents solution_box As TextBox
    Friend WithEvents percentage_button As Button
    Friend WithEvents plus As Button
    Friend WithEvents three As Button
    Friend WithEvents one As Button
    Friend WithEvents two As Button
    Friend WithEvents cubed_button As Button
    Friend WithEvents minus As Button
    Friend WithEvents six As Button
    Friend WithEvents four As Button
    Friend WithEvents five As Button
    Friend WithEvents squared_button As Button
    Friend WithEvents times As Button
    Friend WithEvents nine As Button
    Friend WithEvents seven As Button
    Friend WithEvents eight As Button
    Friend WithEvents squareroot_button As Button
    Friend WithEvents devide As Button
    Friend WithEvents cancel_all As Button
    Friend WithEvents cancel As Button
    Friend WithEvents equal As Button
    Friend WithEvents comma As Button
    Friend WithEvents plus_minus_button As Button
    Friend WithEvents zero As Button
    Friend WithEvents fraction_button As Button
    Friend WithEvents backspace As FontAwesome.Sharp.IconButton
    Friend WithEvents holder_label As Label
End Class
