Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports MetroFramework.Controls

Public Class update_user_accounts
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions

    Dim des As New TripleDESCryptoServiceProvider
    Dim MDS As New MD5CryptoServiceProvider
    Private is_Registerd As Boolean = False

    Function MD5Hash(ByVal value As String) As Byte()

        Return MDS.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))


    End Function


    Function Encrypt(ByVal StringInput As String, ByVal key As String) As String

        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(StringInput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))

    End Function

    Private Sub update_user_accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        username.Focus()
    End Sub
    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            If username.Text = "" Or password.Text = "" Or confirm_password.Text = "" Then
                MessageBox.Show("Some controls are empty, Please fill your data properly", "Empty Controls", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                confirm_password.WithError = False
                If is_Registerd = True Then
                    Using command As New SqlCommand("UPDATE ACCOUNTS SET PASSWORD=@PASSWORD WHERE PASSWORD=@PASS AND USERNAME=@USERNAME", connection)
                        With command.Parameters
                            .Add("@USERNAME", SqlDbType.VarChar).Value = username.Text
                            .Add("@PASSWORD", SqlDbType.VarChar).Value = Encrypt(password.Text, "Abc")
                            Using cmd As New SqlCommand("SELECT * FROM ACCOUNTS WHERE USERNAME=@USERNAME", connection)
                                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username.Text
                                Dim reader As SqlDataReader = cmd.ExecuteReader
                                If reader.HasRows Then
                                    command.ExecuteNonQuery()
                                    MessageBox.Show("Account was updated successfully.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ClearTexts()
                                Else
                                    MessageBox.Show("User Does not Exist", "Checking user Details to update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            End Using
                        End With
                        command.ExecuteNonQuery()
                    End Using

                Else
                    MessageBox.Show("The employee is not in the system", "Employee not Registered", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error Occured while Creating Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearTexts()
        username.Clear()
        password.Clear()
        confirm_password.Clear()
        username.Focus()
    End Sub

    Private Sub cancel_button_Click(sender As Object, e As EventArgs) Handles cancel_button.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub show_pass_CheckedChanged(sender As Object, e As EventArgs) Handles show_pass.CheckedChanged
        Try
            If show_pass.Checked Then
                password.PasswordChar = ""
                confirm_password.PasswordChar = ""
            Else
                password.PasswordChar = "*"
                confirm_password.PasswordChar = "*"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub confirm_password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles confirm_password.KeyPress
    End Sub

    Private Sub confirm_password_TextChanged(sender As Object, e As EventArgs) Handles confirm_password.TextChanged
        If confirm_password.Text <> password.Text Then
            ErrorProvider1.SetError(confirm_password, "password does not match")
            confirm_password.Focus()
        Else
            ErrorProvider1.SetError(confirm_password, "")
        End If
    End Sub

    Private Sub update_user_accounts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not MessageBox.Show("Do you want to stop password update", "Updating Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = True
        End If

    End Sub

    Private Sub password_Leave(sender As Object, e As EventArgs) Handles username.Leave, password.Leave, confirm_password.Leave
        Dim t As MetroTextBox = sender
        If t.Text = "" Then
            ErrorProvider1.SetError(t, "value cannot be empty")
        Else
            ErrorProvider1.SetError(t, "")
        End If
    End Sub
End Class