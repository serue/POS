Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text


Public Class sign_in

    Dim myPermission As New ConnectionAndPermissions
    Dim connection As SqlConnection
    Private Sub sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub LinkLabel1_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel1.MouseEnter
        LinkLabel1.LinkColor = Color.Magenta

    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        LinkLabel1.LinkColor = Color.FromArgb(128, 128, 255)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        user_registration.Show()
    End Sub

    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        If username_textbox.Text = "" Or password_textbox.Text = "" Then
            MessageBox.Show("Username or password is empty", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            connection = myPermission.getConnection()
            myPermission.Login(username_textbox.Text, password_textbox.Text, connection)

        End If
    End Sub

    Private Sub Clear_button_Click(sender As Object, e As EventArgs) Handles Clear_button.Click
        username_textbox.Clear()
        password_textbox.Clear()
        username_textbox.Focus()
    End Sub
End Class