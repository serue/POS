Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Net

Public Class sales_form
    Private HWND As Message
    Dim found As Boolean = False
    Dim myPermissions As New ConnectionAndPermissions
    Dim connection As SqlConnection
    Dim Index As Integer
    Dim totalsum As Decimal = 0
    Dim TAX As Decimal
    Dim sale_tax As Decimal = 0
    Dim Transaction_type As String      ' gets the transaction type to save to the database
    Dim month As String
    Dim CurrentBarcode As String
    Dim DataIndex As Integer = 0
    Dim table1 As New DataTable("Table1")
    Dim RowIndex As Integer
    Dim Transaction_id As Integer = 0
    Dim temp As String = "TN001R-"
    Dim Register_Transaction As String    ' inherited in receipt
    Dim taxcode As String
    Dim cost As Decimal
    Dim profit As Decimal = 0

    Dim position As Integer = 1

    Dim check As CheckBox

    Private user As String
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


    Private Sub maximise_button_Click(sender As Object, e As EventArgs) Handles maximise_button.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            maximise_button.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Else
            Me.WindowState = FormWindowState.Maximized
            maximise_button.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        End If
    End Sub

    Private Sub minimise_button_Click(sender As Object, e As EventArgs) Handles minimise_button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles close_button.Click
        If MessageBox.Show("Confirm Exit ", " Exit Appplication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub sales_form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            Timer1.Start()
            active_account_label.Text = ActiveUser
            lookupPanel.Height = lookPan.Height + Panel4.Height + 5
            barcode_textbox.Focus()
            total_label.Text = 0
            method_label.Text = "."
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT TILL_NUMBER FROM TILLS WHERE TILL_NAME=@NAME", connection)
                command.Parameters.Add("@NAME", SqlDbType.VarChar).Value = Dns.GetHostName
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    till_label.Text = table(0)(0)
                End If
            End Using
            Using command As New SqlCommand("SELECT SYMBOL FROM BASE_CURRENCY", connection)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    Label2.Text = Label2.Text & " " & table(0)(0)
                    Label3.Text = Label3.Text & " " & table(0)(0)
                    Label8.Text = Label8.Text & " " & table(0)(0)

                End If
            End Using
            connection.Close()
            Control.CheckForIllegalCrossThreadCalls = False
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error while loading currency to system", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_label.Text = Now
    End Sub

    Private Sub lookup_button_Click(sender As Object, e As EventArgs) Handles lookup_button.Click
        lookupPanel.Visible = True

    End Sub

    'Private Sub sales_form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    '    e.SuppressKeyPress = True
    '    ProcessCmdKey(HWND, Keys.F1)
    'End Sub

    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    '    Select Case keyData
    '        Case Keys.F1

    '            ' Do something 
    '            MsgBox("yeeeesssssss")
    '        Case Keys.F3
    '            ' Do more

    '        Case Keys.Escape
    '            ' Crap

    '        Case Else
    '            Return MyBase.ProcessCmdKey(msg, keyData)

    '    End Select

    '    Return True
    'End Function
    Private Sub btnComma_Click(sender As Object, e As EventArgs) Handles btnComma.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        Dim b As Button = sender
        barcode_textbox.Text = barcode_textbox.Text & b.Text
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If barcode_textbox.Text.Length > 0 Then
            barcode_textbox.Text = barcode_textbox.Text.Remove(barcode_textbox.Text.Length - 1, 1)
        End If
    End Sub
    'adding items to datagrid view in a sub
    Private Sub AddProductToGrid()
        found = False
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using Command As New SqlCommand("SELECT VAT FROM TAX", connection)
                Dim adapter As New SqlDataAdapter(Command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    TAX = table(0)(0)    'add this variable to the product entry
                End If

            End Using
            Using command As New SqlCommand("SELECT BARCODE,NAME,SALE_QTY,PRICE,QUANTITY FROM INVENTORY WHERE BARCODE=@id", connection)
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = barcode_textbox.Text
                Dim ada As New SqlDataAdapter(command)
                Dim table1 As New DataTable
                ada.Fill(table1)
                If table1.Rows.Count > 0 Then
                    Dim qua As Integer = table1(0)(4)
                    If qua > 1 Then
                        For Each row As DataGridViewRow In list_grid.Rows
                            If row.Cells(1).Value = barcode_textbox.Text Then
                                Index = row.Cells(3).Value + 1 'THIS IS THE PRODUCT QUANTITY BEING ADDED TO THE GRID
                                row.Cells(3).Value = Index  'THIS IS THE PRODUCT QUANTITY BEING ADDED TO THE GRID
                                row.Cells(5).Value = row.Cells(3).Value * table1(0)(3)
                                ' Label1.Text = table1(0)(0) & vbNewLine & vbNewLine & " X " & row.Cells(3).Value & vbNewLine & vbNewLine & "@  $" & table1(0)(2) & vbNewLine & vbNewLine & " Cost   $ " & CDec(row.Cells(4).Value * row.Cells(3).Value)
                                '   Label2.Text = " Cost   $ " & CDec(table(0)(2))
                                found = True
                                Exit For
                            End If
                        Next
                        If found = False Then
                            Dim rNum As Integer = list_grid.Rows.Add
                            list_grid.Rows.Item(rNum).Cells(0).Value = list_grid.RowCount
                            list_grid.Rows.Item(rNum).Cells(1).Value = table1(0)(0)
                            list_grid.Rows.Item(rNum).Cells(2).Value = table1(0)(1)
                            list_grid.Rows.Item(rNum).Cells(3).Value = table1(0)(2)
                            list_grid.Rows.Item(rNum).Cells(4).Value = table1(0)(3)
                            list_grid.Rows.Item(rNum).Cells(5).Value = (CDec(table1(0)(3)) * CDec(table1(0)(2))).ToString(" ###,###,###.00")
                        End If
                        totalsum = 0
                        For row As Integer = 0 To list_grid.Rows.Count - 1
                            totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
                        Next
                        cost_label.Text = CDec(table1(0)(3)).ToString(" ###,###,###.00")
                        total_label.Text = totalsum.ToString(" ###,###,###.00")

                        'If Not IsDBNull(TAX) Then
                        '    sale_tax = TAX * total_label.Text
                        'End If
                    Else
                        MsgBox("out of stock")
                    End If
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Adding data on cart", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show(ex.StackTrace, "Adding data on cart", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ok_button_Click(sender As Object, e As EventArgs) Handles ok_button.Click
        'YOU NEED TO USE THE TAX VALUE ON CALCULATING THE PRICE OF THE PRODUCT ON INVONTORY ADDITION FORM
        'ON THIS FORM ADD THE LABEL TO DISPAY THE TOTAL TAX FOR THE SALE
        AddProductToGrid()
        barcode_textbox.Clear()
        barcode_textbox.Focus()
    End Sub

    Private Sub getTax()
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT VAT FROM TAX", connection)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    TAX = table(0)(0) * total_label.Text
                    TAX = TAX.ToString(" ###,###,###.00")
                Else
                    MessageBox.Show("There is no VAT set for the organisation", "Retrieving VAT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "The following error occured while retrieving the VAT", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RegisterTransaction()

        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction
            If list_grid.Rows.Count >= 0 Then      ' checking if the datagridview is empty
                ' Registering the transaction to the database

                Dim RegisterTransactionQuery As String = "INSERT INTO TRANSACTIONS(TRANSACTION_ID,TRANS_DATE,TRANS_TIME,AMOUNT,PAID,CHANGE,TAX,PAYMENT,CASHIER,TILL) Values(@TRANS_DATE,@TRANS_TIME,@TRANSACTION_ID,@AMOUNT,@PAID,@CHANGE,@TAX,@PAYMENT,@CASHIER,@TILL)"

                Using regcommand As New SqlCommand(RegisterTransactionQuery, connection, transaction)
                    With regcommand.Parameters
                        .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                        .Add("@TRANS_DATE", SqlDbType.DateTime).Value = Now.Date
                        .Add("@TRANS_TIME", SqlDbType.Time).Value = Now.TimeOfDay
                        .Add("@AMOUNT", SqlDbType.Decimal).Value = total_label.Text
                        .Add("@PAID", SqlDbType.Decimal).Value = qty_paid_textbox.Text
                        .Add("@CHANGE", SqlDbType.Decimal).Value = CDec(change_label.Text)
                        .Add("@TAX", SqlDbType.Decimal).Value = TAX
                        .Add("@PAYMENT", SqlDbType.VarChar).Value = Transaction_type
                        .Add("@CASHIER", SqlDbType.VarChar).Value = username
                        .Add("@TILL", SqlDbType.VarChar).Value = till_label.Text
                    End With
                    regcommand.ExecuteNonQuery()
                End Using

                Dim quantity As Integer
                Dim UpdatedQuantity As Integer

                For Each row As DataGridViewRow In list_grid.Rows           ' looping the datagridview

                    Using selectcommand As New SqlCommand("SELECT QUANTITY,COST FROM INVENTORY WHERE BARCODE=@code", connection, transaction) 'selecting the current quantity 
                        selectcommand.Parameters.Add("@code", SqlDbType.VarChar).Value = row.Cells(1).Value
                        Dim selectAdapter As New SqlDataAdapter(selectcommand)        'selection adapter
                        Dim selectTable As New DataTable
                        selectAdapter.Fill(selectTable)
                        quantity = CInt(selectTable(0)(0))
                        cost = CDec(selectTable(0)(1))
                        profit = CDec(row.Cells(4).Value - cost)
                        profit *= row.Cells(3).Value        'this is the profit to be written to the database just use the variable
                        UpdatedQuantity = CInt((quantity - row.Cells(3).Value))

                        'REDIUCING THE QUANTITY OF PRODUCTS IN A TABLE BASING ON THE DEDUCTED QUANTITY
                        Using redCommand As New SqlCommand("UPDATE INVENTORY SET QUANTITY=@quantity WHERE BARCODE=@barcode", connection, transaction)  '  reducing the quantity
                            redCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = UpdatedQuantity
                            redCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = row.Cells(1).Value
                            redCommand.ExecuteNonQuery()
                        End Using

                    End Using

                    'inserting transaction details into the database table

                    'Using TransactionDetailCommand As New SqlCommand("INSERT INTO TRANS_DETAILS(TRANSACTION_ID,BARCODE,QUANTITY,AMOUNT) VALUES(@TRANSACTION_ID,@BARCODE,@QUANTITY,@AMOUNT)", connection, transaction)

                    '    With TransactionDetailCommand.Parameters
                    '        .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                    '        .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                    '        .Add("@QUANTITY", SqlDbType.Int).Value = row.Cells(3).Value
                    '        .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(5).Value

                    '    End With
                    '    list_grid.AllowUserToAddRows = False
                    '    TransactionDetailCommand.ExecuteNonQuery()
                    'End Using

                    'check if the product has a sale for the day
                    Dim updateQuantity As Integer
                    Dim updateProfit As Decimal

                    'SELECT SALE FROM TH
                    Using saleSelectCommand As New SqlCommand("SELECT QUANTITY,PROFIT,AMOUNT FROM SALES WHERE BARCODE=@BARCODE and TRANS_DATE=@trans_date and SALE_TYPE=@sale", connection, transaction)

                        With saleSelectCommand.Parameters

                            .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                            .Add("@trans_date", SqlDbType.Date).Value = Now.ToShortDateString
                            .Add("@sale", SqlDbType.VarChar).Value = Transaction_type

                        End With

                        Dim saleSelectAdapter As New SqlDataAdapter(saleSelectCommand)
                        Dim saleSelectTable As New DataTable

                        saleSelectAdapter.Fill(saleSelectTable)

                        If saleSelectTable.Rows.Count > 0 Then

                            'set quantity and profit
                            Dim UpAmount = saleSelectTable(0)(2)
                            updateQuantity = saleSelectTable(0)(0)
                            updateProfit = saleSelectTable(0)(1)
                            updateQuantity = updateQuantity + row.Cells(3).Value
                            updateProfit = updateProfit + profit

                            'updating a sale in db SALE_TYPE
                            Using saleUpdateCommand As New SqlCommand("UPDATE SALES SET QUANTITY=@quantity,PROFIT=@profit,AMOUNT=@AMOUNT WHERE BARCODE=@product_code and TRANS_DATE=@trans_date and SALE_TYPE=@sale", connection, transaction)

                                With saleUpdateCommand.Parameters
                                    .Add("@quantity", SqlDbType.Int).Value = updateQuantity
                                    .Add("@profit", SqlDbType.Decimal).Value = updateProfit
                                    .Add("@product_code", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    .Add("@trans_date", SqlDbType.Date).Value = Now.ToShortDateString
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = UpAmount + total_label.Text
                                    .Add("@sale", SqlDbType.VarChar).Value = Transaction_type
                                End With
                                saleUpdateCommand.ExecuteNonQuery()
                            End Using
                        Else
                            'registering a sale into the db

                            Using salecommand As New SqlCommand("INSERT INTO SALES(TRANS_DATE,BARCODE,QUANTITY,AMOUNT,PROFIT,SALE_TYPE) Values(@TRANS_DATE,@BARCODE,@QUANTITY,@AMOUNT,@PROFIT,@SALE_TYPE)", connection, transaction)

                                With salecommand.Parameters
                                    .Add("@TRANS_DATE", SqlDbType.Date).Value = Now.ToShortDateString
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    .Add("@QUANTITY", SqlDbType.Int).Value = row.Cells(3).Value
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(4).Value
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = profit
                                    .Add("@SALE_TYPE", SqlDbType.VarChar).Value = Transaction_type
                                End With
                                salecommand.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                    month = MonthName(Now.Date.Month(), False)

                    Using saleSelectCommand As New SqlCommand("SELECT QUANTITY,PROFIT,AMOUNT FROM SUMMARY_SALES WHERE BARCODE=@BARCODE AND SALE_MONTH=@TRANS_DATE", connection, transaction)
                        With saleSelectCommand.Parameters
                            .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                            .Add("@TRANS_DATE", SqlDbType.VarChar).Value = month & " " & Now.Year
                        End With

                        Dim saleSelectAdapter As New SqlDataAdapter(saleSelectCommand)
                        Dim saleSelectTable As New DataTable
                        saleSelectAdapter.Fill(saleSelectTable)
                        If saleSelectTable.Rows.Count > 0 Then
                            'set quantity and profit
                            Dim UpAmount = saleSelectTable(0)(2)
                            updateQuantity = saleSelectTable(0)(0)
                            updateProfit = saleSelectTable(0)(1)
                            updateQuantity = updateQuantity + row.Cells(3).Value
                            updateProfit = updateProfit + profit
                            'updating a sale in db
                            Using saleUpdateCommand As New SqlCommand("UPDATE SUMMARY_SALES SET QUANTITY=@QUANTITY,PROFIT=@PROFIT,AMOUNT=@AMOUNT WHERE BARCODE=@BARCODE AND SALE_MONTH=@TRANSDATE", connection, transaction)

                                With saleUpdateCommand.Parameters
                                    .Add("@QUANTITY", SqlDbType.Int).Value = updateQuantity
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = updateProfit
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = UpAmount + total_label.Text
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    .Add("@TRANSDATE", SqlDbType.VarChar).Value = month & " " & Now.Year
                                End With
                                saleUpdateCommand.ExecuteNonQuery()
                            End Using
                        Else
                            'registering a summar sale into the db
                            Using salecommand As New SqlCommand("INSERT INTO SUMMARY_SALES(SALE_MONTH,BARCODE,QUANTITY,AMOUNT,PROFIT) Values(@SALE_MONTH,@BARCODE,@QUANTITY,@AMOUNT,@PROFIT)", connection, transaction)
                                With salecommand.Parameters
                                    .Add("@SALE_MONTH", SqlDbType.VarChar).Value = month & " " & Now.Year
                                    ' .Add("@trans_id", sqldbtype.VarChar).Value = Register_Transaction
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    '.Add("@destion", SqlDbType.VarChar).Value = row.Cells(2).Value
                                    .Add("@QUANTITY", SqlDbType.Int).Value = row.Cells(3).Value
                                    '.Add("@cost_price", sqldbtype.decimal).Value = cost
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(5).Value
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = profit
                                    '.Add("@sale_type", sqldbtype.VarChar).Value = PayMethod.Text
                                End With
                                salecommand.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                Next
                ' MessageBox.Show("Transaction is complete !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No Products has been found on the list !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            barcode_textbox.Focus()
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.StackTrace)
        End Try


    End Sub
    Private Sub saveAllSales(Row As DataGridViewRow)
        Dim updateQuantity As Integer
        Dim updateProfit As Decimal

        'SELECT SALE FROM TH
        Using saleSelectCommand As New SqlCommand("SELECT QUANTITY,PROFIT FROM SALES WHERE BARCODE=@BARCODE and TRANS_DATE=@trans_date and SALE_TYPE=@sale", connection)

            With saleSelectCommand.Parameters

                .Add("@BARCODE", SqlDbType.VarChar).Value = Row.Cells(1).Value
                .Add("@trans_date", SqlDbType.VarChar).Value = Now.ToShortDateString
                .Add("@sale", SqlDbType.VarChar).Value = "PayMethod.Text"

            End With

            Dim saleSelectAdapter As New SqlDataAdapter(saleSelectCommand)
            Dim saleSelectTable As New DataTable

            saleSelectAdapter.Fill(saleSelectTable)

            If saleSelectTable.Rows.Count > 0 Then

                'set quantity and profit

                updateQuantity = saleSelectTable(0)(0)
                updateProfit = saleSelectTable(0)(1)
                updateQuantity = updateQuantity + Row.Cells(3).Value
                updateProfit = updateProfit + profit

                'updating a sale in db SALE_TYPE
                Using saleUpdateCommand As New SqlCommand("UPDATE SALES SET QUANTITY=@quantity,PROFIT=@profit WHERE BARCODE=@product_code and TRANS_DATE=@trans_date and SALE_TYPE=@sale", connection)

                    With saleUpdateCommand.Parameters
                        .Add("@quantity", SqlDbType.Int).Value = updateQuantity
                        .Add("@profit", SqlDbType.Decimal).Value = updateProfit
                        .Add("@product_code", SqlDbType.VarChar).Value = Row.Cells(1).Value
                        .Add("@trans_date", SqlDbType.VarChar).Value = Now.ToShortDateString
                    End With
                    saleUpdateCommand.ExecuteNonQuery()
                End Using
            Else
                'registering a sale into the db

                Using salecommand As New SqlCommand("INSERT INTO SALES(TRANS_DATE,BARCODE,QUANTITY,AMOUNT,PROFIT) Values(@TRANS_DATE,@BARCODE,@QUANTITY,@AMOUNT,@PROFIT)", connection)

                    With salecommand.Parameters
                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                        .Add("@BARCODE", SqlDbType.VarChar).Value = Row.Cells(1).Value
                        .Add("@QUANTITY", SqlDbType.Int).Value = Row.Cells(3).Value
                        .Add("@AMOUNT", SqlDbType.Decimal).Value = cost
                        .Add("@PROFIT", SqlDbType.Decimal).Value = profit
                    End With
                    salecommand.ExecuteNonQuery()
                End Using
            End If
        End Using
        month = MonthName(Now.Date.Month(), False)

        Using saleSelectCommand As New SqlCommand("SELECT QUANTITY,PROFIT FROM SUMMARY_SALES WHERE BARCODE=@BARCODE AND TRANS_DATE=@TRANS_DATE", connection)
            With saleSelectCommand.Parameters
                .Add("@BARCODE", SqlDbType.VarChar).Value = Row.Cells(1).Value
                .Add("@TRANS_DATE", SqlDbType.VarChar).Value = month
            End With

            Dim saleSelectAdapter As New SqlDataAdapter(saleSelectCommand)
            Dim saleSelectTable As New DataTable
            saleSelectAdapter.Fill(saleSelectTable)
            If saleSelectTable.Rows.Count > 0 Then
                'set quantity and profit

                updateQuantity = saleSelectTable(0)(0)
                updateProfit = saleSelectTable(0)(1)
                updateQuantity = updateQuantity + Row.Cells(3).Value
                updateProfit = updateProfit + profit
                'updating a sale in db
                Using saleUpdateCommand As New SqlCommand("UPDATE SUMMARY_SALES SET QUANTITY=@QUANTITY,PROFIT=@PROFIT WHERE BARCODE=@BARCODE AND TRANS_DATE=@TRANSDATE", connection)

                    With saleUpdateCommand.Parameters
                        .Add("@QUANTITY", SqlDbType.Int).Value = updateQuantity
                        .Add("@PROFIT", SqlDbType.Decimal).Value = updateProfit
                        .Add("@BARCODE", SqlDbType.VarChar).Value = Row.Cells(1).Value
                        .Add("@TRANSDATE", SqlDbType.VarChar).Value = month
                    End With
                    saleUpdateCommand.ExecuteNonQuery()
                End Using
            Else
                'registering a summar sale into the db
                Using salecommand As New SqlCommand("INSERT INTO SUMMARY_SALES(TRANS_DATE,BARCODE,QUANTITY,AMOUNT,PROFIT) Values(@TRANS_DATE,@BARCODE,@QUANTITY,@AMOUNT,@PROFIT)", connection)
                    With salecommand.Parameters
                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = month
                        ' .Add("@trans_id", sqldbtype.VarChar).Value = Register_Transaction
                        .Add("@BARCODE", SqlDbType.VarChar).Value = Row.Cells(1).Value
                        '.Add("@destion", SqlDbType.VarChar).Value = row.Cells(2).Value
                        .Add("@QUANTITY", SqlDbType.Int).Value = Row.Cells(3).Value
                        '.Add("@cost_price", sqldbtype.decimal).Value = cost
                        .Add("@AMOUNT", SqlDbType.Decimal).Value = Row.Cells(4).Value
                        .Add("@PROFIT", SqlDbType.Decimal).Value = profit
                        '.Add("@sale_type", sqldbtype.VarChar).Value = PayMethod.Text
                    End With
                    salecommand.ExecuteNonQuery()
                End Using
            End If
        End Using
    End Sub
    Private Sub saveTransactions()
        Dim RegisterTransactionQuery As String = "INSERT INTO TRANSACTIONS(TRANSACTION_ID,TRANS_DATE,TRANS_TIME,AMOUNT,PAID,CHANGE,TAX,PAYMENT,CASHIER,TILL) Values(@TRANS_DATE,@TRANS_TIME,@TRANSACTION_ID,@AMOUNT,@PAID,@CHANGE,@TAX,@PAYMENT,@CASHIER,@TILL)"

        Using regcommand As New SqlCommand(RegisterTransactionQuery, connection)
            With regcommand.Parameters
                .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.Date.ToShortDateString
                .Add("@TRANS_TIME", SqlDbType.VarChar).Value = TimeOfDay
                .Add("@AMOUNT", SqlDbType.Decimal).Value = total_label.Text
                .Add("@PAID", SqlDbType.Decimal).Value = qty_paid_textbox.Text
                .Add("@CHANGE", SqlDbType.Decimal).Value = change_label.Text
                .Add("@TAX", SqlDbType.Decimal).Value = TAX
                .Add("@PAYMENT", SqlDbType.VarChar).Value = Transaction_type
                .Add("@CASHIER", SqlDbType.VarChar).Value = active_account_label.Text
                .Add("@TILL", SqlDbType.Decimal).Value = till_label.Text
            End With
            regcommand.ExecuteNonQuery()
        End Using

    End Sub
    Private Sub Placeholder()
        Using CheckTransactionIDCommand As New SqlCommand("SELECT TRANSACTION_ID, STATUS FORM TRANSACTIONS_STATUS WHERE TRANS_ID=@TRANS_ID", connection)
            Dim CheckTransactionTable As New DataTable
            Dim CheckTransactionAdapter As New SqlDataAdapter(CheckTransactionIDCommand)
            CheckTransactionAdapter.Fill(CheckTransactionTable)
            If CheckTransactionTable.Rows.Count > 0 Then        'this means that the transaction is already registerd
                If CheckTransactionTable(0)(0) = "complete" Then

                End If
            End If
        End Using
    End Sub
    Private Sub clearPaymentsAmounts()
        txtCard.Text = 0
        txtCash.Text = 0
        txtEcoCash.Text = 0
        txtForex.Text = 0

        txtCash.Focus()
    End Sub
    Private Sub ProcessTrsactionButton_Click(sender As Object, e As EventArgs) Handles ProcessTrsactionButton.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()


            If list_grid.Rows.Count >= 0 Then      ' checking if the datagridview is empty
                ' Registering the transaction to the database
                Dim objectArray As ListBox = New ListBox
                Dim PayMethods() As TextBox = {txtCard, txtCash, txtEcoCash, txtForex} ' creating an array of text boxes for getting the value of the payment method
                'if the payment method value is not empty then the payment method is going to be ssaved into the databae
                Dim CombinedPayment As Decimal
                For Each item As TextBox In PayMethods
                    If Not item.Text = 0 Then
                        objectArray.Items.Add(item)
                        CombinedPayment += item.Text
                    End If
                Next
                If CombinedPayment >= total_label.Text Then

                    'process of saving the product
                    saveTransactions()

                    Dim quantity As Integer
                    Dim UpdatedQuantity As Integer

                    For Each row As DataGridViewRow In list_grid.Rows           ' looping the datagridview

                        Using selectcommand As New SqlCommand("SELECT QUANTITY,COST FROM INVENTORY WHERE BARCODE=@code", connection) 'selecting the current quantity 
                            selectcommand.Parameters.Add("@code", SqlDbType.VarChar).Value = row.Cells(1).Value
                            Dim selectAdapter As New SqlDataAdapter(selectcommand)        'selection adapter
                            Dim selectTable As New DataTable
                            selectAdapter.Fill(selectTable)
                            quantity = CInt(selectTable(0)(0))
                            cost = CDec(selectTable(0)(1))
                            profit = CDec(row.Cells(4).Value - cost)
                            profit *= row.Cells(3).Value
                            UpdatedQuantity = CInt((quantity - row.Cells(3).Value))

                            'REDIUCING THE QUANTITY OF PRODUCTS IN A TABLE BASING ON THE DEDUCTED QUANTITY
                            Using redCommand As New SqlCommand("UPDATE INVENTORY SET QUANITY=@quantity WHERE BARCODE=@barcode", connection)  '  reducing the quantity
                                redCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = UpdatedQuantity
                                redCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = row.Cells(1).Value
                                redCommand.ExecuteNonQuery()
                            End Using

                        End Using

                        ' inserting transaction details into the database table

                        Using TransactionDetailCommand As New SqlCommand("INSERT INTO TRANS_DETAILS(TRANSACTION_ID,BARCODE,QUANTITY,AMOUNT) VALUES(@TRANSACTION_ID,@BARCODE,@QUANTITY,@AMOUNT)", connection)

                            With TransactionDetailCommand.Parameters
                                .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                                .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                .Add("@QUANTITY", SqlDbType.Int).Value = row.Cells(3).Value
                                .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(4).Value

                            End With
                            list_grid.AllowUserToAddRows = False
                            TransactionDetailCommand.ExecuteNonQuery()
                        End Using

                        'check if the product has a sale for the day



                        For Each item As TextBox In objectArray.Items
                            If item.Name.ToUpper = "txtCard".ToUpper Then
                                Transaction_type = "swipe"

                                saveAllSales(row)
                            End If
                            If item.Name.ToUpper = "txtCash".ToUpper Then
                                Transaction_type = "cash"
                                saveAllSales(row)

                            End If
                            If item.Name.ToUpper = "txtEcoCash".ToUpper Then
                                Transaction_type = "ecocash"
                                saveAllSales(row)

                            End If
                            If item.Name.ToUpper = "txtForex".ToUpper Then
                                Transaction_type = "us_dollar"
                                saveAllSales(row)

                            End If
                        Next


                    Next
                    ' MessageBox.Show("Transaction is complete !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information) CONTINUE WITH THIS COMMENT
                Else
                    MessageBox.Show("No Products has been found on the list !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

            'If CombinedPayment > total_label.Text Then
            'proceed with the payment
            ' MessageBox.Show("proceeding with the payment!!")
            'RegisterTransaction()

            ' End If

            MessageBox.Show("Transaction is complete please wait for your receipt which is being printed from the pos printer", "Transaction succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information)
            OtherPaymentsPanel.Visible = False


            connection.Close()
            clearPaymentsAmounts()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "The system encountered the following exception, Please check if you provide all variables", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()
        End Try

    End Sub

    Private Sub OtherPaymentButton_Click(sender As Object, e As EventArgs) Handles OtherPaymentButton.Click

    End Sub

    Private Sub CancelTransactionButton_Click(sender As Object, e As EventArgs) Handles CancelTransactionButton.Click
        'OtherPaymentsPanel.Visible = False
        Dim obj() As TextBox = {txtCard, txtCash, txtEcoCash, txtForex}
        For Each item As TextBox In obj
            If item.Text = 0 Then
                MsgBox(item.Name & " is empty")
            End If
        Next

    End Sub

    Public Sub txtForex_Click(sender As Object, e As EventArgs) Handles txtForex.Click, txtEcoCash.Click, txtCash.Click, txtCard.Click

    End Sub

    Private Sub txtForex_LostFocus(sender As Object, e As EventArgs) Handles txtForex.LostFocus, txtEcoCash.LostFocus, txtCard.LostFocus, txtCash.LostFocus
        Dim txt As TextBox = sender
        If txt.Text = "" Then
            txt.Text = 0
        End If
    End Sub

    Private Sub txtForex_GotFocus(sender As Object, e As EventArgs) Handles txtForex.GotFocus, txtEcoCash.GotFocus, txtCard.GotFocus, txtCash.GotFocus
        Dim txt As TextBox = sender
        If txt.Text = 0 Then
            txt.Text = ""
        End If
    End Sub

    Private Sub Assign_Methods(sender As Object, e As EventArgs) Handles RTGS_button.Click, OtherPaymentButton.Click, forex_button.Click, ecocash_button.Click, cash_button.Click
        Try
            If total_label.Text <= 0 Or total_label.Text = "" Then
                MessageBox.Show("You cannot proceed to payment since there is no product in the lis", "No Product on the list", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim btn As Button = sender
                Transaction_type = btn.Text
                Me.AcceptButton = Me.FinaliseTransaction
                AmtPanel.Visible = True
                qty_paid_textbox.Focus()
                method_label.Text = btn.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Encountered the following error on Payments", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub backoffice_button_Click(sender As Object, e As EventArgs) Handles backoffice_button.Click
        'for back office development
        menu_form.ActiveUser = active_account_label.Text
        menu_form.Show()
        Me.Hide()
    End Sub

    Private Sub enquiry_button_Click(sender As Object, e As EventArgs) Handles enquiry_button.Click
        lookupPanel.Visible = True
    End Sub


    Private Sub Enquiry(ValToSearch As String)
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using command As New SqlCommand("SELECT BARCODE,NAME,QUANTITY,PRICE FORM INVENTORY WHERE BARCODE LIKE '%" & ValToSearch & "%' OR NAME LIKE '%" & ValToSearch & "%'", connection)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then

                Else
                    MessageBox.Show("There is no related product in the inventory!!", "Lookup Results", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "The system encountered the following error while perfoming a stock lookup", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()
        End Try
    End Sub
    Private Sub searchbar_TextChanged(sender As Object, e As EventArgs) Handles searchbar.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Enquiry(searchbar.Text)
    End Sub
    Private Sub FindMaxID()
        'find the maximum transaction id from the database and save from there 
        Try
            connection.Open()
            Using Command As New SqlCommand("SELECT * FROM TRANSACTIONS", connection)
                Dim adapter As New SqlDataAdapter(Command)
                Dim table As New DataTable

                adapter.Fill(table)
                If table.Rows.Count > 0 Then

                    Using cmd As New SqlCommand("SELECT MAX(ID) FROM TRANSACTIONS", connection)

                        Dim Trans_id As New SqlDataAdapter(cmd)

                        Dim Trans_table As New DataTable

                        Trans_id.Fill(Trans_table)

                        Transaction_id = Trans_table(0)(0) + 1
                    End Using
                Else
                    Transaction_id = 1
                End If

                Register_Transaction = temp & Transaction_id
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub FinaliseTransaction_Click(sender As Object, e As EventArgs) Handles FinaliseTransaction.Click
        Form_Thread.RunWorkerAsync()

    End Sub

    Private Sub sales_Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown


        If e.KeyCode = Keys.F1 Then
            Transaction_type = "CASH"
            AmtPanel.Visible = True
            method_label.Text = "CASH"
        ElseIf e.KeyCode = Keys.F3 Then
            Transaction_type = "CARD"
            AmtPanel.Visible = True
            method_label.Text = "CARD"
        ElseIf e.KeyCode = Keys.F4 Then
            Transaction_type = "ECOCASH"
            AmtPanel.Visible = True
            method_label.Text = "ECOCASH"
        ElseIf e.KeyCode = Keys.F5 Then
            Transaction_type = "FOREX"
            method_label.Text = "FOREX"
            AmtPanel.Visible = True
        ElseIf e.KeyCode = Keys.F6 Then
            lookupPanel.Visible = True
            AmtPanel.Visible = False

        ElseIf e.KeyCode = Keys.Add Then
            MsgBox("Add")
        ElseIf e.KeyCode = Keys.Multiply Then
            MsgBox("multiply")

            ' MsgBox(e.KeyCode)

        End If

    End Sub

    Private Sub Form_Thread_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Form_Thread.DoWork
        If qty_paid_textbox.Text <> "" And qty_paid_textbox.Text >= total_label.Text And Transaction_type = "cash".ToUpper Then
            Dim change As Decimal = (qty_paid_textbox.Text - total_label.Text)

            getTax()
            MsgBox(TAX)
            FindMaxID()
            RegisterTransaction()
            If ask_radio.Checked = True Then
                If MessageBox.Show("Do yo want to Print a Receipt for this transaction", "Receipt Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim ReceiptForm As New receipt_form
                    ReceiptForm.Transaction = Register_Transaction
                    ReceiptForm.Show()
                End If
            ElseIf yes_radio.Checked = True Then
                Dim ReceiptForm As New receipt_form
                'ReceiptForm.Transaction = Register_Transaction
                settings.Show()
            End If


            AmtPanel.Visible = False
            Me.AcceptButton = Me.ok_button
            qty_paid_textbox.Clear()
            barcode_textbox.Focus()
        ElseIf qty_paid_textbox.Text = "" Then
            MessageBox.Show("You did not supply the amount paid by the customer, Please check if the amount is correct", "Error of the Payment amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf qty_paid_textbox.Text < total_label.Text Then
            MessageBox.Show("The amount paid by the customer is less than than the cost of products", "Supplying less amount than the cost", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form_Thread_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Form_Thread.RunWorkerCompleted
        MessageBox.Show("Transaction was successful", "Transaction status", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
