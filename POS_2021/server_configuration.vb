Imports System.Data.SqlClient

Public Class server_configuration

    Dim backUpConnection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim createconnection As SqlConnection
    Private Sub sqlServerAuthentication_CheckedChanged(sender As Object, e As EventArgs) Handles sqlServerAuthentication.CheckedChanged
        If sqlServerAuthentication.Checked Then
            Panel8.Enabled = True
        Else
            Panel8.Enabled = False
        End If
    End Sub

    Private Sub Windows_authentication_CheckedChanged(sender As Object, e As EventArgs) Handles Windows_authentication.CheckedChanged
        If Windows_authentication.Checked = True Then
            Panel7.Enabled = True
        Else
            Panel7.Enabled = False
        End If
    End Sub

    Private Sub save_printer_Click(sender As Object, e As EventArgs) Handles save_printer.Click
        Try
            'variables for network authentication on server
            Dim networkAuth As String = "1433;Network Library=DBMSSOCN;Initial Catalog=POS_DATABASE;"
            Dim backAuthNetwork As String = "1433;Network Library=DBMSSOCN;Initial Catalog=master;"
            Dim server As String = Sql_Server_name.Text
            Dim userID As String = sql_username.Text
            Dim Password As String = sql_password.Text
            Dim SqlConString As String = "Data Source=" & server & "," & networkAuth & "User ID=" & userID & ";Password=" & Password
            Dim SqlbackupCon As String = "Data Source=" & server & "," & backAuthNetwork & "User ID=" & userID & ";Password=" & Password

            'variables for windows authentication on server
            '   Dim con As New SqlConnection("Data Source=BEYMO\SERU; Initial Catalog=POS_DATABASE; Integrated Security=True;")
            Dim WinAuth As String = "Data Source=" & Windows_server_name.Text & ";Initial Catalog=POS_DATABASE; Integrated Security=True;"
            Dim winBakUPAuth As String = "Data Source=" & Windows_server_name.Text & ";Initial Catalog=master; Integrated Security=True;"



            'building the  connection for sqlserver based authentication
            If sqlServerAuthentication.Checked Then


                If Sql_Server_name.Text <> "" And sql_password.Text <> "" And sql_username.Text <> "" Then
                    createconnection = New SqlConnection(SqlConString)
                    createconnection.Open()

                    backUpConnection = New SqlConnection(SqlbackupCon)
                    backUpConnection.Open()
                    My.Settings.Reset()
                    My.Settings.connection = SqlConString
                    My.Settings.backupConnection = SqlbackupCon
                    My.Settings.server = Sql_Server_name.Text
                    My.Settings.DBusername = sql_username.Text
                    My.Settings.DBPassword = sql_password.Text
                    My.Settings.auth_type = "sqlserver"
                    My.Settings.PRINTER = cmbPrinter.Text
                    My.Settings.Save()
                    MessageBox.Show("Connection Set up was successful", "connection Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    backUpConnection.Close()
                    createconnection.Close()
                Else
                    MsgBox("Provide details baba")
                End If
                'buil the connection for windows based authentication
            ElseIf Windows_authentication.Checked Then

                If Windows_server_name.Text <> "" Then
                    createconnection = New SqlConnection(WinAuth)
                    backUpConnection = New SqlConnection(winBakUPAuth)
                    createconnection.Open()
                    backUpConnection.Open()
                    My.Settings.Reset()
                    My.Settings.connection = WinAuth
                    My.Settings.backupConnection = winBakUPAuth
                    My.Settings.server = Windows_server_name.Text
                    My.Settings.DBusername = "windows"
                    My.Settings.DBusername = "windows"
                    My.Settings.auth_type = "windows"
                    My.Settings.PRINTER = cmbPrinter.Text

                    My.Settings.Save()
                    MessageBox.Show("Connection Set up was successful", "connection Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    createconnection.Close()

                    backUpConnection.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "The following error was encountered on saving settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.StackTrace)
        End Try
    End Sub

    Private Sub server_configuration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If My.Settings.auth_type = "" Then
            ElseIf My.Settings.auth_type = "windows" Then
                Panel7.Enabled = True
                Panel8.Enabled = False
                sqlServerAuthentication.Checked = False
                Windows_authentication.Checked = True
                Windows_server_name.Text = My.Settings.server
            Else
                Panel8.Enabled = True
                sqlServerAuthentication.Checked = True
                Windows_authentication.Checked = False
                Sql_Server_name.Text = My.Settings.server
                sql_password.Text = My.Settings.DBPassword
                sql_username.Text = My.Settings.DBusername
            End If
            txtSavedPrinter.Text = My.Settings.PRINTER
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbPrinter_Click(sender As Object, e As EventArgs) Handles cmbPrinter.Click
        cmbPrinter.Items.Clear()
        Dim objSettings As New Printing.PrinterSettings
        Dim strPrinter As String
        Try
            For Each strPrinter In Printing.PrinterSettings.InstalledPrinters
                cmbPrinter.Items.Add(strPrinter)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()

    End Sub
End Class