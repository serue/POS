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
        Try
            employee_id.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SelectUserById()
        Using command As New SqlCommand("SELECT * FROM USERS WHERE EMP_ID=@name", connection)
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = employee_id.Text
            is_Registerd = False
            Dim reader As SqlDataReader = command.ExecuteReader
            If reader.HasRows Then
                is_Registerd = True
            End If
        End Using
    End Sub
    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            SelectUserById()
            If employee_id.Text = "" Or username.Text = "" Or password.Text = "" Or confirm_password.Text = "" Then
                MessageBox.Show("Some controls are empty, Please fill your data properly", "Empty Controls", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If is_Registerd = True Then
                    Using command As New SqlCommand("INSERT INTO ACCOUNTS(EMP_ID,USERNAME,PASSWORD VALUES(@EMP_ID,@USERNAME,@PASSWORD", connection)
                        With command.Parameters
                            .Add("@EMP_ID", SqlDbType.VarChar).Value = employee_id.Text
                            .Add("@USERNAME", SqlDbType.VarChar).Value = employee_id.Text
                            .Add("@PASSWORD", SqlDbType.VarChar).Value = Encrypt(password.Text, "Abc")
                        End With
                        Using cmd As New SqlCommand("SELECT * FROM ACCOUNTS WHERE USERNAME=@USERNAME", connection)
                            cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = employee_id.Text
                            Dim reader As SqlDataReader = cmd.ExecuteReader
                            If reader.HasRows Then
                                MessageBox.Show("Already Exists", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Else
                                command.ExecuteNonQuery()
                                MessageBox.Show("Account was created successfully. Now you can login", "User Account creation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ClearTexts()
                            End If
                        End Using
                    End Using
                Else
                    MessageBox.Show("The employee is not in the system", "Employee not Registered", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.StackTrace, "An Error Occured while Creating Account", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub cancel_button_Click(sender As Object, e As EventArgs) Handles cancel_button.Click
        Me.Close()
    End Sub

    Private Sub create_user_accounts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not MessageBox.Show("Do you want to stop password update", "Updating Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Private Sub confirm_password_Leave(sender As Object, e As EventArgs) Handles username.Leave, password.Leave, employee_id.Leave, confirm_password.Leave
        Dim t As MetroTextBox = sender
        If t.Text = "" Then
            ErrorProvider1.SetError(t, "value cannot be empty")
        Else
            ErrorProvider1.SetError(t, "")
        End If
    End Sub

    Private Sub confirm_password_TextChanged(sender As Object, e As EventArgs) Handles confirm_password.TextChanged
        If confirm_password.Text <> password.Text Then
            ErrorProvider1.SetError(confirm_password, "password does not match")
            confirm_password.Focus()
        Else
            ErrorProvider1.SetError(confirm_password, "")
        End If
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
End Class