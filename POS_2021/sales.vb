Public Class sales
    Private Sub sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub sales_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            MsgBox("enter")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sale_form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        menu_form.Show()
    End Sub
End Class
