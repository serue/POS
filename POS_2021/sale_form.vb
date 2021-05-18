Public Class sale_form


    Private Sub sale_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles close_button.Click
        If MessageBox.Show("Confirm Exit ", " Exit Appplication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_label.Text = Now
    End Sub

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
End Class