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
    Dim EditID As Integer = 0
    'data variables

    Dim currency_id As Integer = 0
    Dim currencyID As String = "1"
    Dim till_id As Integer = 0
    Dim tax_id As Integer = 0
    Dim forex_id As Integer = 0
    Dim UpdateForexCurrency As String = ""

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
            Using command As New SqlCommand("SELECT CURRENCY FROM CURRENCIES", connection)
                Dim ADAPTER As New SqlDataAdapter(command)
                Dim TABLE As New DataTable
                ADAPTER.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    currency_combo.Items.Clear()

                    For Each row As DataRow In TABLE.Rows
                        currency_combo.Items.Add(row(0))
                    Next
                End If
            End Using

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
        BASE_RT_RATE.Clear()

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
                    Using command As New SqlCommand("INSERT INTO BASE_CURRENCY(CURRENCY,SYMBOL,RTGS_RATE) VALUES(@CURRENCY,@SYMBOL,@RATE)", connection)
                        With command.Parameters
                            .Add("@CURRENCY", SqlDbType.VarChar).Value = currency_name.Text
                            .Add("@SYMBOL", SqlDbType.VarChar).Value = currency_symbol.Text
                            .Add("@RATE", SqlDbType.Decimal).Value = BASE_RT_RATE.Text
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


            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Eroor occured while Setting up the System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            Using cmd As New SqlCommand("SELECT CURRENCY FROM CURRENCIES WHERE CURRENCY=@CURRENCY", connection)
                cmd.Parameters.Add("@CURRENCY", SqlDbType.VarChar).Value = currency_combo.Text
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    MessageBox.Show("The forex was already saved Please you can only edit it", "Seting foreign currency for the system", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Using command As New SqlCommand("INSERT INTO CURRENCIES(CURRENCY,SYMBOL,RATE,RTGS_RATE) VALUES(@CURRENCY,@SYMBOL,@RATE,@RTGS_RATE)", connection)
                        With command.Parameters
                            .Add("@CURRENCY", SqlDbType.VarChar).Value = currency_combo.Text
                            .Add("@SYMBOL", SqlDbType.VarChar).Value = FOREX_SYMBOL.Text
                            .Add("@RATE", SqlDbType.Decimal).Value = rate_textbox.Text
                            .Add("@RTGS_RATE", SqlDbType.Decimal).Value = rtgs_rate.Text
                        End With
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("CURRENCY ADDED SUCCESSFULLY!!", "ADDING CURRENCY SETTING", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "FOLLOWING ERROR ENCOUNTERED DURNG THE ADDITION OF CURRENCY", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()
        End Try
    End Sub
    Private Function GetCurrencyID() As String
        Using command As New SqlCommand("SELECT CURRENCY FROM FOREX_CURRENCY", connection)
            Using c_adapter As New SqlDataAdapter(command)
                Using c_table As New DataTable
                    c_adapter.Fill(c_table)
                    If c_table.Rows.Count > 0 Then
                        currencyID = c_table(0)(0)
                        Return currencyID
                        Exit Function
                    End If
                End Using
            End Using
        End Using
    End Function
    Private Sub loadSettings()
        Try
            connection = myPermissions.getConnection
            connection.Open()

            'load base currency
            Using command As New SqlCommand("SELECT ID,CURRENCY,SYMBOL,RTGS_RATE FROM BASE_CURRENCY", connection)
                Dim TABLE As New DataTable
                Dim adapters As New SqlDataAdapter(command)
                adapters.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    currency_id = TABLE(0)(0)
                    currency_name.Text = TABLE(0)(1)
                    currency_symbol.Text = TABLE(0)(2)
                    BASE_RT_RATE.Text = TABLE(0)(3)

                End If
            End Using

            'loading tills
            Dim name As String = Dns.GetHostName
            txtTillName.Text = name

            'load tax


            'load forex
            GetCurrencyID()

            Using command As New SqlCommand("SELECT ID,CURRENCY,SYMBOL,RATE,RTGS_RATE FROM CURRENCIES WHERE ID=@ID", connection)
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = currencyID
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    forex_id = table(0)(0)
                    currency_combo.Text = table(0)(1)
                    FOREX_SYMBOL.Text = table(0)(2)
                    rate_textbox.Text = table(0)(3)
                    rtgs_rate.Text = table(0)(4)

                End If
            End Using
            Using command As New SqlCommand("SELECT ID,CURRENCY,SYMBOL,RATE,RTGS_RATE FROM CURRENCIES", connection)
                Using adapter As New SqlDataAdapter(command)
                    Using table As New DataTable
                        adapter.Fill(table)
                        search_grid.DataSource = table
                        If search_grid.RowCount > 0 Then
                            SearchHeaders()
                        End If
                    End Using
                End Using
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "AN ERROR OCCURED LOADING SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub SearchHeaders()
        search_grid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        search_grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        search_grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        search_grid.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        search_grid.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells

        search_grid.Columns(0).HeaderText = "#"
        search_grid.Columns(1).HeaderText = "Currency Name"
        search_grid.Columns(2).HeaderText = "Symbol"
        search_grid.Columns(3).HeaderText = "Cash Rate"
        search_grid.Columns(4).HeaderText = "RTGS Rate"
        search_grid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        search_grid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        search_grid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        search_grid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        search_grid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Private Sub UPDATE_FOREX_Click(sender As Object, e As EventArgs) Handles UPDATE_FOREX.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            GetDefaultForex
            If EditID > 0 Then
                Using command As New SqlCommand("UPDATE CURRENCIES SET CURRENCY=@CURRENCY,SYMBOL=@SYMBOL,RATE=@RATE,RTGS_RATE=@RRATE WHERE ID=@ID", connection)
                    With command.Parameters
                        .Add("@ID", SqlDbType.VarChar).Value = EditID
                        .Add("@CURRENCY", SqlDbType.VarChar).Value = currency_combo.Text
                        .Add("@SYMBOL", SqlDbType.VarChar).Value = FOREX_SYMBOL.Text
                        .Add("@RATE", SqlDbType.Decimal).Value = rate_textbox.Text
                        .Add("@RRATE", SqlDbType.Decimal).Value = rtgs_rate.Text
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
                    Using command As New SqlCommand("UPDATE BASE_CURRENCY SET CURRENCY=@CURRENCY,SYMBOL=@SYMBOL,RTGS_RATE=@RATE WHERE ID=@ID", connection)
                        With command.Parameters
                            .Add("@ID", SqlDbType.Int).Value = currency_id
                            .Add("@CURRENCY", SqlDbType.VarChar).Value = currency_name.Text
                            .Add("@SYMBOL", SqlDbType.VarChar).Value = currency_symbol.Text
                            .Add("@RATE", SqlDbType.Decimal).Value = BASE_RT_RATE.Text
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

    Private Sub currency_combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles currency_combo.SelectedIndexChanged
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT ID FROM CURRENCIES WHERE CURRENCY=@CURRENCY", connection)
                command.Parameters.Add("@CURRENCY", SqlDbType.VarChar).Value = currency_combo.Text
                Dim ADAPTER As New SqlDataAdapter(command)
                Dim TABLE As New DataTable
                ADAPTER.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    EditID = TABLE(0)(0)
                Else
                    EditID = 0
                End If
            End Using
            connection.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction()

            Using command As New SqlCommand("DROP PROCEDURE IF EXISTS UPDATE_INVENTORY;", connection, transaction)
                command.ExecuteNonQuery()
            End Using
            Using command As New SqlCommand("CREATE PROCEDURE UPDATE_INVENTORY	@ID INT ,@CATEGORY VARCHAR(50),@SUB_CATEGORY1 VARCHAR(200),@SUB_CATEGORY2 VARCHAR(200),@SUB_CATEGORY3 VARCHAR(200),@BARCODE VARCHAR(50) ,@NAME VARCHAR(500), @QUANTITY DECIMAL(18,2) ,@RE_ORDER DECIMAL(18,2),@SALE_QTY DECIMAL(18,2),@COST DECIMAL(18,2),@PRICE DECIMAL(18,2),@MARGIN DECIMAL(18,2) AS BEGIN UPDATE INVENTORY SET CATEGORY=@CATEGORY,BARCODE=@BARCODE,NAME=@NAME,QUANTITY=@QUANTITY,RE_ORDER=@RE_ORDER,SALE_QTY=@SALE_QTY,COST=@COST,PRICE=@PRICE,MARGIN=@MARGIN,SUB_CATEGORY1=@SUB_CATEGORY1,SUB_CATEGORY2=@SUB_CATEGORY2,SUB_CATEGORY3=@SUB_CATEGORY3 WHERE ID=@ID END ", connection, transaction)
                command.ExecuteNonQuery()
            End Using
            transaction.Commit()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub search_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles search_grid.CellClick
        Try
            Name_textbox.Text = search_grid.CurrentRow.Cells(1).Value
            currency_rate.Text = search_grid.CurrentRow.Cells(2).Value
            the_symbol.Text = search_grid.CurrentRow.Cells(1).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Default_button_Click(sender As Object, e As EventArgs) Handles Default_button.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM FOREX_CURRENCY", connection)
                Using ADAPTER As New SqlDataAdapter(command)
                    Dim table As New DataTable
                    ADAPTER.Fill(table)
                    If table.Rows.Count > 0 Then
                        Using cmd As New SqlCommand("UPDATE FOREX_CURRENCY SET CURRENCY=@CURRENCY", connection)
                            cmd.Parameters.Add("@CURRENCY", SqlDbType.VarChar).Value = search_grid.CurrentRow.Cells(0).Value
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Currency was set as default currency", "Default Foreign Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                    Else
                        Using cmd As New SqlCommand("INSERT INTO FOREX_CURRENCY (CURRENCY) VALUES(@CURRENCY)", connection)
                            cmd.Parameters.Add("@CURRENCY", SqlDbType.VarChar).Value = search_grid.CurrentRow.Cells(0).Value
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Currency was set as default currency", "Default Foreign Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                    End If
                End Using
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
        End Try
    End Sub

    Private Sub delete_button_Click(sender As Object, e As EventArgs) Handles delete_button.Click
        Dim RATE As Decimal = GetForexRate("CARD")

        MessageBox.Show(RATE)
    End Sub

    Private Sub GetDefaultForex()
        Using command As New SqlCommand("SELECT CURRENCY FROM FOREX_CURRENCY", connection)
            Using adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    UpdateForexCurrency = table(0)(0)
                Else
                    UpdateForexCurrency = ""
                End If
            End Using
        End Using
    End Sub
End Class