Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class ConnectionAndPermissions
    Private connection As SqlConnection = New SqlConnection("Data Source=192.168.43.223,1433;Network Library=DBMSSOCN;Initial Catalog=POS_DATABASE;User ID=sa;Password=2556b11j;")
    Dim backCon As New SqlConnection(My.Settings.backupconnection)
    Dim connect As New SqlConnection(My.Settings.connection)

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
            Using command As New SqlCommand("SELECT EMP_ID FROM ACCOUNTS WHERE USERNAME=@username AND PASSWORD=@password", conn)
                With command.Parameters
                    .Add("@username", SqlDbType.VarChar).Value = username
                    .Add("@password", SqlDbType.VarChar).Value = Encrypt(password, "Abc")
                End With
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable

                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    Using UserCommand As New SqlCommand("SELECT NAME FROM USERS WHERE EMP_ID=@EMP_ID", conn)
                        UserCommand.Parameters.Add("@EMP_ID", SqlDbType.VarChar).Value = table(0)(0)
                        adapter = New SqlDataAdapter(UserCommand)
                        table = New DataTable
                        adapter.Fill(table)
                        Full_name = table(0)(0)
                    End Using
                    Using CM As New SqlCommand("SELECT * FROM ACCOUNTS WHERE STATUS='1' AND USERNAME=@USERNAME", conn)
                        CM.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username
                        Dim reader As New SqlDataAdapter(CM)
                        Dim AccTable As New DataTable
                        reader.Fill(AccTable)
                        If AccTable.Rows.Count > 0 Then
                            Using permissionsCommand As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION='is_admin' AND STATUS='1'", conn)
                                With permissionsCommand.Parameters
                                    .Add("@USERNAME", SqlDbType.VarChar).Value = username
                                End With
                                Dim permissionAdapter As New SqlDataAdapter(permissionsCommand)
                                Dim permissionsTable As New DataTable
                                permissionAdapter.Fill(permissionsTable)
                                If permissionsTable.Rows.Count Then
                                    Using cmd As New SqlCommand("SELECT * FROM COMPANY", conn)
                                        Dim COMPANYTABLE As New DataTable
                                        Dim ADAPTER1 As New SqlDataAdapter(cmd)
                                        ADAPTER1.Fill(COMPANYTABLE)
                                        If COMPANYTABLE.Rows.Count > 0 Then
                                            '
                                            menu_form.ActiveUser = Full_name
                                            menu_form.ActiveUsername = username
                                            menu_form.Show()
                                            sign_in.Close()
                                        Else
                                            MessageBox.Show("Some critical settings has not been done, user is taken to set it up now", "Setting Pop up", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                            Full_name = table(0)(0)
                                            company.ActiveUser = Full_name
                                            company.ActiveUsername = username
                                            company.Show()
                                            sign_in.Close()
                                        End If
                                    End Using
                                Else
                                    Full_name = table(0)(0)
                                    sales_form.ActiveUser = Full_name
                                    sales_form.ActiveUsername = username
                                    sales_form.Show()
                                    sign_in.Close()
                                End If
                            End Using

                        Else
                            MessageBox.Show("Your account has been deactivated, Please see your supervisor to activate it", "Account was deactivated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Else
                    MessageBox.Show("login failed, wrong username or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
            conn.Close()
        End Try
    End Sub



    Public Function getConnection() As SqlConnection
        Return connect
    End Function
    Public Function getBackupConnection() As SqlConnection
        Return backCon
    End Function
    Public Sub savePermissions(user As String, employee As String, permission As String, status As Integer, conString As SqlConnection, trans As SqlTransaction)
        Using Command As New SqlCommand("INSERT INTO USER_PERMISSIONS(USERNAME,EMP_ID,PERMISSION,STATUS) values(@user,@EMP_ID,@permission,@status)", conString, trans)
            With Command.Parameters
                .Add("@user", SqlDbType.VarChar).Value = user
                .Add("@EMP_ID", SqlDbType.VarChar).Value = employee
                .Add("@permission", SqlDbType.VarChar).Value = permission
                .Add("@status", SqlDbType.VarChar).Value = status
            End With
            Command.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub updatePermissions(user As String, employee As String, permission As String, status As Integer, conString As SqlConnection, trans As SqlTransaction)
        Using Command As New SqlCommand("UPDATE USER_PERMISSIONS SET STATUS=@status where PERMISSION=@permission AND USERNAME=@user AND EMP_ID=@EMP_ID", conString, trans)
            With Command.Parameters
                .Add("@user", SqlDbType.VarChar).Value = user
                .Add("@EMP_ID", SqlDbType.VarChar).Value = employee
                .Add("@permission", SqlDbType.VarChar).Value = permission
                .Add("@status", SqlDbType.Int).Value = status
            End With
            Command.ExecuteNonQuery()
        End Using
    End Sub

End Class
