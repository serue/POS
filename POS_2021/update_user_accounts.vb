Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

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

    End Sub
    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            If is_Registerd = True Then
                Using command As New SqlCommand("UPDATE ACCOUNTS SET PASSWORD=@PASSWORD WHERE EMP_ID=@EMP_ID AND USERNAME=@USERNAME", connection)
                    With command.Parameters
                        .Add("@USERNAME", SqlDbType.VarChar).Value = username.Text
                        .Add("@PASSWORD", SqlDbType.VarChar).Value = Encrypt(password.Text, "Abc")
                        Using cmd As New SqlCommand("SELECT * FROM ACCOUNTS WHERE USERNAME=@USERNAME", connection)
                            cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username.Text
                            Dim reader As SqlDataReader = cmd.ExecuteReader
                            If reader.HasRows Then
                                command.ExecuteNonQuery()
                            Else
                                MessageBox.Show("User Does not Exist", "Checking user Details to update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        End Using
                    End With
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Account was created successfully. Now you can login", "User Account creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearTexts()
            Else
                MessageBox.Show("The employee is not in the system", "Employee not Registered", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

End Class