Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports MetroFramework.Controls

Public Class create_user_accounts
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private is_Registerd As Boolean = False

    Dim des As New TripleDESCryptoServiceProvider
    Dim MDS As New MD5CryptoServiceProvider

    Function MD5Hash(ByVal value As String) As Byte()

        Return MDS.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))


    End Function


    Function Encrypt(ByVal StringInput As String, ByVal key As String) As String

        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(StringInput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))

    End Function
    Private Sub create_user_accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SelectUserById()
        Using command As New SqlCommand("SELECT * FROM USERS WHERE NAME='admin'", connection)
            is_Registerd = False
            Dim reader As SqlDataReader = command.ExecuteReader
            While reader.Read
                is_Registerd = True
                Exit While
            End While
        End Using
    End Sub
    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            SelectUserById()

            If is_Registerd = True Then
                Using command As New SqlCommand("INSERT INTO ACCOUNTS(EMP_ID,USERNAME,PASSWORD VALUES(@EMP_ID,@USERNAME,@PASSWORD", connection)
                    With command.Parameters
                        .Add("@EMP_ID", SqlDbType.VarChar).Value = employee_id.Text
                        .Add("@USERNAME", SqlDbType.VarChar).Value = employee_id.Text
                        .Add("@PASSWORD", SqlDbType.VarChar).Value = Encrypt(password.Text, "Abc")
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
        employee_id.Clear()
        username.Clear()
        password.Clear()
        confirm_password.Clear()
        employee_id.Focus()
    End Sub

    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click
        Try
            ClearTexts()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class