Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class user_registration

    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions

    Dim NameExist As Boolean = False
    Dim passMatch As Boolean = False
    Dim des As New TripleDESCryptoServiceProvider
    Dim MDS As New MD5CryptoServiceProvider
    Dim valid As Boolean = False
    Dim matchPassword As Boolean

    Private userID As String
    Public Property user As String
        Get
            Return userID
        End Get
        Set(ByVal value As String)
            userID = value
        End Set
    End Property
    Function MD5Hash(ByVal value As String) As Byte()

        Return MDS.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))


    End Function


    Function Encrypt(ByVal StringInput As String, ByVal key As String) As String

        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(StringInput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))

    End Function
    Private Sub user_registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clear()
        name_textbox.Clear()
        id_number.Clear()
        address.Clear()
        age.Clear()
        phone.Clear()
        employee_id.Clear()
        name_textbox.Focus()
    End Sub

    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click
        clear()
    End Sub

    Private Sub save_button_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()

            Using command As New SqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT_USERS"
                command.CommandType = CommandType.StoredProcedure
                With command.Parameters

                    .Add("@NAME", SqlDbType.VarChar).Value = name_textbox.Text
                    .Add("@ID_NO ", SqlDbType.VarChar).Value = id_number.Text
                    .Add("@AGE", SqlDbType.Int).Value = age.Text
                    .Add("@ADDRESS", SqlDbType.VarChar).Value = address.Text
                    .Add("@CONTACT", SqlDbType.VarChar).Value = phone.Text
                    .Add("@GENDER", SqlDbType.VarChar).Value = gender.Text
                    .Add("@EMP_ID", SqlDbType.VarChar).Value = employee_id.Text
                    '.Add("@PASSWORD", SqlDbType.VarChar).Value = Encrypt(password.Text, "Abc")
                End With

                command.ExecuteNonQuery()
                MessageBox.Show("New user was registered successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)

            connection.Close()
        End Try
    End Sub

    Private Sub update_button_Click(sender As Object, e As EventArgs) Handles update_button.Click
        Try
            If Not IsDBNull(user) Or user <> "" Then
                connection = myPermissions.getConnection()
                connection.Open()
                Dim query As String = "insert into users(name,id_no,address,age,gender,contact,username,password) values(@name,@id_no,@address,@age ,@gender,@CONTACT,@username,@password) "
                Using command As New SqlCommand()
                    command.Connection = connection

                    command.CommandText = "UPDATE_USERS"
                    command.CommandType = CommandType.StoredProcedure

                    With command.Parameters
                        .Add("@ID", SqlDbType.Int).Value = user
                        .Add("@NAME", SqlDbType.VarChar).Value = name_textbox.Text
                        .Add("@ID_NO", SqlDbType.VarChar).Value = id_number.Text
                        .Add("@ADDRESS", SqlDbType.Int).Value = age.Text
                        .Add("@AGE ", SqlDbType.VarChar).Value = address.Text
                        .Add("@CONTACT", SqlDbType.VarChar).Value = phone.Text
                        .Add("@GENDER", SqlDbType.VarChar).Value = gender.Text
                        .Add("@EMP_ID", SqlDbType.VarChar).Value = employee_id.Text
                        '.Add("@PASSWORD", SqlDbType.VarChar).Value = Encrypt(password.Text, "abc")


                    End With

                    command.ExecuteNonQuery()
                    MessageBox.Show("New user was registered successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                End Using
            Else
                MessageBox.Show("There is no data to update", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            connection.Close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        sign_in.Show()
        Me.Close()
    End Sub
End Class