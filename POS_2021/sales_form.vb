Public Class sales_form
    Private HWND As Message

    Private Sub maximise_button_Click(sender As Object, e As EventArgs) Handles maximise_button.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            maximise_button.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Else
            Me.WindowState = FormWindowState.Maximized
            maximise_button.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        End If
    End Sub

    Private Sub minimise_button_Click(sender As Object, e As EventArgs) Handles minimise_button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles close_button.Click
        If MessageBox.Show("Confirm Exit ", " Exit Appplication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub sales_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_label.Text = Now
    End Sub

    Private Sub lookup_button_Click(sender As Object, e As EventArgs) Handles lookup_button.Click

    End Sub

    Private Sub sales_form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        e.SuppressKeyPress = True
        ProcessCmdKey(HWND, Keys.F1)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F1

                ' Do something 
                MsgBox("yeeeesssssss")
            Case Keys.F3
                ' Do more

            Case Keys.Escape
                ' Crap

            Case Else
                Return MyBase.ProcessCmdKey(msg, keyData)

        End Select

        Return True
    End Function
    Private Sub btnComma_Click(sender As Object, e As EventArgs) Handles btnComma.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        Dim b As Button = sender
        barcode_textbox.Text = barcode_textbox.Text & b.Text
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If barcode_textbox.Text.Length > 0 Then
            barcode_textbox.Text = barcode_textbox.Text.Remove(barcode_textbox.Text.Length - 1, 1)
        End If
    End Sub
End Class