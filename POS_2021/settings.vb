Imports System.Data.SqlClient
Imports System.Net
Public Class settings
    Dim connection As SqlConnection
    Dim backUpConnection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim createconnection As SqlConnection
    Dim MyID As Integer = 0
    Dim company As String = ""
    Private user As String

    'data variables

    Dim currency_id As Integer = 0
    Dim till_id As Integer = 0
    Dim tax_id As Integer = 0
    Dim forex_id As Integer = 0

    Public Property ActiveUser() As String
        Get
            Return user
        End Get
        Set(ByVal value As String)
            user = value
        End Set
    End Property

    Private username As String
    Public Property ActiveUsername() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = Dns.GetHostName
        txtTillName.Text = name

        loadSettings()
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
            connection = myPermissions.getConnection
            connection.Open()
            SelectCompany()

            If company = "" Then

                If MessageBox.Show("There is no Organisation registered in the system, for settings to be saved, it requires the Organisation name.Do you want to register Organisation ", "Company Not Registered", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim c As Form = New company
                    c.ShowDialog()
                Else
                    MsgBox("close")
                End If
            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error Occured when loading settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click
        currency_name.Clear()
        currency_symbol.Clear()
        vat_number.Clear()
        vat_textbox.Clear()
        txtTillNumber.Clear()
        currency_name.Focus()
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
    Private Sub SelectCompany()
        Using cm As New SqlCommand("SELECT NAME FROM COMPANY", connection)
            Dim table As New DataTable
            Dim adapter As New SqlDataAdapter(cm)
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                company = table(0)(0)
            End If
        End Using
    End Sub

    Private Sub save_item_Click(sender As Object, e As EventArgs) Handles save_item.Click
        Try
            'loading the settings to the system
            txtSavedPrinter.Text = My.Settings.PRINTER
            If My.Settings.auth_type = "" Then
            ElseIf My.Settings.auth_type = "SqlServerAuthentication" Then
                Panel8.Enabled = True
                sqlServerAuthentication.Checked = True
            Else
                Panel7.Enabled = True
                Windows_authentication.Checked = True
            End If


            connection = myPermissions.getConnection()
            connection.Open()
            Using CMD As New SqlCommand("SELECT ID FROM BASE_CURRENCY", connection)
                Dim TABLE As New DataTable
                Dim ADAPTER As New SqlDataAdapter(CMD)
                ADAPTER.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    MyID = TABLE(0)(0)
                    MessageBox.Show("CANNOT SAVE THE CURRENCY, SEEMS THERE IS ALREADY CURRENCY, YOU CAN UPDATE IT ONLY", "CURRENCY", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Using command As New SqlCommand("INSERT INTO BASE_CURRENCY(CURRENCY,SYMBOL) VALUES(@CURRENCY,@SYMBOL)", connection)
                        With command.Parameters
                            .Add("@CURRENCY", SqlDbType.VarChar).Value = currency_name.Text
                            .Add("@SYMBOL", SqlDbType.VarChar).Value = currency_symbol.Text
                        End With
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Currency has been set successfully", "Setting Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            Using CMD As New SqlCommand("SELECT ID FROM TILLS", connection)
                Dim TABLE As New DataTable
                Dim ADAPTER As New SqlDataAdapter(CMD)
                ADAPTER.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    MessageBox.Show("CANNOT SAVE THE TILL, SEEMS IT IS ALREADY SAVED, YOU CAN UPDATE IT ONLY", "TILL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Using command As New SqlCommand("INSERT INTO TILLS(TILL_NAME,TILL_NUMBER) VALUES(@TILL_NAME,@TILL_NUMBER)", connection)
                        With command.Parameters
                            .Add("@TILL_NAME", SqlDbType.VarChar).Value = txtTillName.Text
                            .Add("@TILL_NUMBER", SqlDbType.VarChar).Value = txtTillNumber.Text
                        End With
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Till has been set successfully", "Setting Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
            SelectCompany()
            If company <> "" Then
                Using CMD As New SqlCommand("SELECT ID FROM TAX", connection)
                    Dim TABLE As New DataTable
                    Dim ADAPTER As New SqlDataAdapter(CMD)
                    ADAPTER.Fill(TABLE)
                    If TABLE.Rows.Count > 0 Then
                        MessageBox.Show("CANNOT SAVE THE TAX, SEEMS IT IS ALREADY SAVED, YOU CAN UPDATE IT ONLY", "TAX", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Using command As New SqlCommand("INSERT INTO TAX(COMPANY,VAT_NO,VAT,NOTES) VALUES(@COMPANY,@VAT_NO,@VAT,@NOTES)", connection)
                            With command.Parameters
                                .Add("@COMPANY", SqlDbType.VarChar).Value = company
                                .Add("@VAT_NO", SqlDbType.VarChar).Value = vat_number.Text
                                .Add("@VAT", SqlDbType.VarChar).Value = vat_textbox.Text
                                .Add("@NOTES", SqlDbType.VarChar).Value = vatNotes_textbox.Text
                            End With
                            command.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Tax has been set successfully", "Setting Tax", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End If


            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Eroor occured while Setting up the System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub vat_textbox_LostFocus(sender As Object, e As EventArgs) Handles vat_textbox.LostFocus
        If vat_textbox.Text <> "" Then
            Try
                Dim number As Decimal = vat_textbox.Text / 100
                vat_textbox.Text = number
            Catch ex As Exception
                MessageBox.Show("Quantity is empty or in wrong format", "Quantity ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        menu_form.ActiveUser = user
        menu_form.ActiveUsername = username
        menu_form.Show()
        Me.Close()
    End Sub

    Private Sub save_currency_Click(sender As Object, e As EventArgs) Handles save_currency.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using cmd As New SqlCommand("SELECT * FROM CURRENCIES", connection)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    MessageBox.Show("The forex was already saved Please you can only edit it", "Seting foreign currency for the system", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Using command As New SqlCommand("INSERT INTO CURRENCIES(CURRENCY,SYMBOL,RATE) VALUES(@CURRENCY,@SYMBOL,@RATE)", connection)
                        With command.Parameters
                            .Add("@CURRENCY", SqlDbType.VarChar).Value = currency_combo.Text
                            .Add("@SYMBOL", SqlDbType.VarChar).Value = FOREX_SYMBOL.Text
                            .Add("@RATE", SqlDbType.Decimal).Value = rate_textbox.Text
                        End With
                        command.ExecuteNonQuery()
                    End Using
                End If
            End Using
            MessageBox.Show("CURRENCY ADDED SUCCESSFULLY!!", "ADDING CURRENCY SETTING", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "FOLLOWING ERROR ENCOUNTERED DURNG THE ADDITION OF CURRENCY", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()
        End Try
    End Sub
    Private Sub loadSettings()
        Try
            connection = myPermissions.getConnection
            connection.Open()

            'load base currency
            Using command As New SqlCommand("SELECT ID,CURRENCY,SYMBOL FROM BASE_CURRENCY", connection)
                Dim TABLE As New DataTable
                Dim adapters As New SqlDataAdapter(command)
                adapters.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    currency_id = TABLE(0)(0)
                    currency_name.Text = TABLE(0)(1)
                    currency_symbol.Text = TABLE(0)(2)

                End If
            End Using

            'loading tills
            Dim name As String = Dns.GetHostName
            txtTillName.Text = name

            'load tax

            Using command As New SqlCommand("SELECT ID,VAT_NO,VAT,NOTES FROM TAX", connection)
                Dim TABLE As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    tax_id = TABLE(0)(0)
                    vat_number.Text = TABLE(0)(1)
                    vat_textbox.Text = TABLE(0)(2)
                    vatNotes_textbox.Text = TABLE(0)(3)

                End If
            End Using

            'load forex

            Using command As New SqlCommand("SELECT ID,CURRENCY,SYMBOL,RATE FROM CURRENCIES", connection)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    forex_id = table(0)(0)
                    currency_combo.Text = table(0)(1)
                    FOREX_SYMBOL.Text = table(0)(2)
                    rate_textbox.Text = table(0)(3)

                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "AN ERROR OCCURED LOADING SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub UPDATE_FOREX_Click(sender As Object, e As EventArgs) Handles UPDATE_FOREX.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            If forex_id > 0 Then
                Using command As New SqlCommand("UPDATE CURRENCIES SET CURRENCY=@CURRENCY,SYMBOL=@SYMBOL,RATE=@RATE WHERE ID=@ID", connection)
                    With command.Parameters
                        .Add("@ID", SqlDbType.VarChar).Value = currency_combo.Text
                        .Add("@CURRENCY", SqlDbType.VarChar).Value = currency_combo.Text
                        .Add("@SYMBOL", SqlDbType.VarChar).Value = FOREX_SYMBOL.Text
                        .Add("@RATE", SqlDbType.Decimal).Value = rate_textbox.Text
                    End With
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Forex was edited successfully", "Edit settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("There is no selected item", "Edit settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An error  occured while editing the settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub edit_details_Click(sender As Object, e As EventArgs) Handles edit_details.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using CMD As New SqlCommand("SELECT ID FROM BASE_CURRENCY", connection)
                Dim TABLE As New DataTable
                Dim ADAPTER As New SqlDataAdapter(CMD)
                ADAPTER.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    MyID = TABLE(0)(0)
                    Using command As New SqlCommand("UPDATE BASE_CURRENCY SET CURRENCY=@CURRENCY,SYMBOL=@SYMBOL WHERE ID=@ID", connection)
                        With command.Parameters
                            .Add("@ID", SqlDbType.Int).Value = currency_id
                            .Add("@CURRENCY", SqlDbType.VarChar).Value = currency_name.Text
                            .Add("@SYMBOL", SqlDbType.VarChar).Value = currency_symbol.Text
                        End With
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Currency has been set successfully", "Setting Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("CANNOT SAVE UPDATE CURRENCY, IT DOES NOT EXIST", "CURRENCY", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End Using

            Using CMD As New SqlCommand("SELECT ID FROM TILLS", connection)
                Dim TABLE As New DataTable
                Dim ADAPTER As New SqlDataAdapter(CMD)
                ADAPTER.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    Using command As New SqlCommand("UPDATE TILLS SET TILL_NAME=@TILL_NAME,TILL_NUMBER=@TILL_NUMBER HWERE ID=@ID", connection)
                        With command.Parameters
                            .Add("@ID", SqlDbType.Int).Value = till_id
                            .Add("@TILL_NAME", SqlDbType.VarChar).Value = txtTillName.Text
                            .Add("@TILL_NUMBER", SqlDbType.VarChar).Value = txtTillNumber.Text
                        End With
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Till has been updated", "Setting Tills", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("CANNOT SAVE THE TILL, SEEMS IT IS ALREADY SAVED, YOU CAN UPDATE IT ONLY", "TILL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
            SelectCompany()
            If company <> "" Then
                Using CMD As New SqlCommand("SELECT ID FROM TAX", connection)
                    Dim TABLE As New DataTable
                    Dim ADAPTER As New SqlDataAdapter(CMD)
                    ADAPTER.Fill(TABLE)
                    If TABLE.Rows.Count > 0 Then
                        Using command As New SqlCommand("UPDATE TAX SET COMPANY=@COMPANY,VAT_NO=@VAT_NO,VAT=@VAT,NOTES=@NOTES WHERE ID=@ID", connection)
                            With command.Parameters
                                .Add("@ID", SqlDbType.Int).Value = tax_id
                                .Add("@COMPANY", SqlDbType.VarChar).Value = company
                                .Add("@VAT_NO", SqlDbType.VarChar).Value = vat_number.Text
                                .Add("@VAT", SqlDbType.VarChar).Value = vat_textbox.Text
                                .Add("@NOTES", SqlDbType.VarChar).Value = vatNotes_textbox.Text
                            End With
                            command.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Till has been set successfully", "Setting Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("The item does not exist", "Updating Error")
                    End If
                End Using
            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An error occured while editing settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

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

    Private Sub clear_printer_Click(sender As Object, e As EventArgs) Handles clear_printer.Click
        Try
            connection = New SqlConnection(My.Settings.connection)
            connection.Open()
            MsgBox("open")
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class