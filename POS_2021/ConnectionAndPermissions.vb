Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class ConnectionAndPermissions
    Private connection As SqlConnection = New SqlConnection("Data Source=192.168.43.223,1433;Network Library=DBMSSOCN;Initial Catalog=POS_DATABASE;User ID=sa;Password=2556b11j;")
    Dim con As New SqlConnection("Data Source=BEYMO\SERU; Initial Catalog=POS_DATABASE; Integrated Security=True;")


    ' password harshing using md5

    Dim des As New TripleDESCryptoServiceProvider
    Dim MDS As New MD5CryptoServiceProvider
    Dim valid As Boolean = False
    Dim matchPassword As Boolean


    Dim username As String
    Dim Full_name As String

    Function MD5Hash(ByVal value As String) As Byte()

        Return MDS.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))


    End Function


    Function Encrypt(ByVal StringInput As String, ByVal key As String) As String

        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(StringInput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))

    End Function


    Public Sub Login(username As String, password As String, conn As SqlConnection)
        Try
            conn.Open()
            Using command As New SqlCommand("select name from users where username=@username and password=@password", conn)
                With command.Parameters
                    .Add("@username", SqlDbType.VarChar).Value = username
                    .Add("@password", SqlDbType.VarChar).Value = Encrypt(password, "Abc")
                End With
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable

                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    Using cmd As New SqlCommand("SELECT * FROM COMPANY", conn)
                        Dim COMPANYTABLE As New DataTable
                        Dim ADAPTER1 As New SqlDataAdapter(cmd)
                        ADAPTER1.Fill(COMPANYTABLE)
                        If COMPANYTABLE.Rows.Count > 0 Then
                            Full_name = table(0)(0)
                            menu_form.ActiveUser = Full_name
                            menu_form.Show()
                            sign_in.Close()
                        Else
                            MessageBox.Show("Some critical settings has not been done, user is taken to set it up now", "Setting Pop up", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Full_name = table(0)(0)
                            company.ActiveUser = Full_name
                            company.Show()
                            sign_in.Close()
                        End If
                    End Using

                Else
                    MessageBox.Show("login failed, wrong username or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

            conn.Close()
        End Try
    End Sub



    Public Function getConnection() As SqlConnection
        Return con
    End Function
    Public Sub savePermissions(ByVal user As String, ByVal permission As String, ByVal status As Integer, ByVal conString As SqlConnection)
        Using Command As New SqlCommand("insert into user_permissions(username,permission,status) values(@user,@permission,@status)", conString)

            With Command.Parameters

                .Add("@user", SqlDbType.VarChar).Value = user
                .Add("@permission", SqlDbType.VarChar).Value = permission
                .Add("@status", SqlDbType.VarChar).Value = status


            End With

            Command.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub updatePermissions(ByVal user As String, ByVal permission As String, ByVal status As Integer, ByVal conString As SqlConnection)
        Using Command As New SqlCommand("update user_permissions set permission=@permission,status=@status where username=@user", conString)

            With Command.Parameters

                .Add("@user", SqlDbType.VarChar).Value = user
                .Add("@permission", SqlDbType.VarChar).Value = permission
                .Add("@status", SqlDbType.Int).Value = status


            End With

            Command.ExecuteNonQuery()
        End Using
    End Sub

End Class
