Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Net
Imports System.Runtime.InteropServices

Public Class sales_form
    Private HWND As Message
    Dim found As Boolean = False
    Dim myPermissions As New ConnectionAndPermissions
    Dim connection As SqlConnection
    Dim Index As Integer
    Dim totalsum As Decimal = 0
    Dim TAX As Decimal
    Dim CurrencyRate As Decimal = 0
    Dim Transaction_type As String      ' gets the transaction type to save to the database
    Dim month As String
    Dim table1 As New DataTable("Table1")
    Dim iRowIndex As Integer
    Dim Transaction_id As Integer = 0
    Dim temp As String = "TN001R-"
    Dim Register_Transaction As String    ' inherited in receipt
    Dim cost As Decimal
    Dim profit As Decimal = 0
    Dim remainingStock As Decimal
    Dim position As Integer = 1
    Dim hasValuePassed As Boolean = False
    Dim check As CheckBox
    Private isButchery = False
    Dim isMultiple As Boolean = False
    Dim localMethod As String
    Dim EcocashRate As Decimal
    'FOREX RATE FOR THE DAY
    Dim DailyCurrencyRate As Decimal
    Dim currency As String = ""
    Private AddedTaxValue As Decimal = 0
    'GETTING CURRENCIES FOR USE
    Dim BaseCurrency, Forex As String

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2


    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal IParam As Integer) As Integer

    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean

    End Function


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
    Private Sub ForexCurrency()
        connection = myPermissions.getConnection
        connection.Open()
        Using command As New SqlCommand("SELECT CURRENCY FROM FOREX_CURRENCY", connection)
            Using ADAPTER As New SqlDataAdapter(command)
                Dim TABLE As New DataTable
                ADAPTER.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    Using cmd As New SqlCommand("SELECT CURRENCY FROM CURRENCIES WHERE ID=@CURRENCY", connection)
                        cmd.Parameters.Add("@CURRENCY", SqlDbType.VarChar).Value = TABLE(0)(0)
                        Dim AD As New SqlDataAdapter(cmd)
                        Dim CTAB As New DataTable
                        AD.Fill(CTAB)
                        currency = CTAB(0)(0)
                        forex_button.Text = currency.ToUpper

                    End Using
                End If
                TABLE.Dispose()
            End Using
        End Using
        connection.Close()
    End Sub
    Private Sub sales_form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            ForexCurrency()

            Timer1.Start()
            active_account_label.Text = ActiveUser

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
                    totLabel.Text = totLabel.Text & " " & table(0)(0)

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

    Private Sub lookup_button_Click(sender As Object, e As EventArgs)
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
    Private Sub AddProductToGrid(AddBarcode As String)
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
            Using command As New SqlCommand("SELECT BARCODE,NAME,SALE_QTY,PRICE,QUANTITY,CATEGORY,SUB_CATEGORY1 FROM INVENTORY WHERE BARCODE=@id", connection)
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = AddBarcode
                Dim ada As New SqlDataAdapter(command)
                Dim table1 As New DataTable
                ada.Fill(table1)
                If table1.Rows.Count > 0 Then
                    remainingStock = table1(0)(0)
                    Dim qua As Integer = table1(0)(4)
                    If table1(0)(6) = "weighed" Then
                        isButchery = True
                    End If

                    If qua > 1 Then
                        For Each row As DataGridViewRow In list_grid.Rows
                            If row.Cells(1).Value = AddBarcode Then
                                Index = row.Cells(3).Value + 1 'THIS IS THE PRODUCT QUANTITY BEING ADDED TO THE GRID
                                row.Cells(3).Value = Index  'THIS IS THE PRODUCT QUANTITY BEING ADDED TO THE GRID
                                row.Cells(5).Value = (row.Cells(3).Value * table1(0)(3))
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
                            list_grid.Rows.Item(rNum).Cells(5).Value = Math.Round(CDec(table1(0)(3)) * CDec(table1(0)(2)), 2)
                        End If
                        totalsum = 0
                        For row As Integer = 0 To list_grid.Rows.Count - 1
                            totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
                        Next
                        cost_label.Text = Math.Round(CDec(table1(0)(3)), 2)
                        total_label.Text = totalsum

                        If isButchery Then
                            barcode_textbox.Clear()
                            AmtPanel.Visible = True
                            qty_viewLabel.Visible = True
                            quantity_textbox.Visible = True
                            Accept_Quantity.Visible = True
                            HideQuantityInputs()
                            Me.AcceptButton = Me.Accept_Quantity
                            quantity_textbox.TextAlign = HorizontalAlignment.Right
                            quantity_textbox.Focus()
                        End If
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
        Try
            AddProductToGrid(barcode_textbox.Text)
            If ok_button Is AcceptButton Then
                barcode_textbox.Focus()
            End If
            barcode_textbox.Clear()
            iRowIndex = list_grid.RowCount
            'list_grid.Rows( iRowIndex).Cells(3).Value = quantity_textbox.Text
            list_grid.ClearSelection()
            list_grid.Rows(iRowIndex - 1).Selected = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Erro was was encountered", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    Private Function getTaxes(code As String) As Decimal
        Try

            Using command As New SqlCommand("SELECT TAX FROM INVENTORY WHERE BARCODE=@BARCODE", connection)
                command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = code
                Using taxTable As New DataTable
                    Using taxadapter As New SqlDataAdapter(command)
                        taxadapter.Fill(taxTable)
                        If taxTable.Rows.Count > 0 Then
                            TAX = taxTable(0)(0)
                        Else
                            TAX = 0

                        End If
                    End Using
                End Using
            End Using


        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An error while retrieving the tax", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function


    Private Function AddedTax() As Decimal
        Try

            If list_grid.Rows.Count > 0 Then
                AddedTaxValue = 0
                For Each row In list_grid.Rows
                    Using command As New SqlCommand("SELECT TAX FROM INVENTORY WHERE BARCODE=@BARCODE", connection)
                        command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = row.cells(1).value
                        Using taxTable As New DataTable
                            Using taxadapter As New SqlDataAdapter(command)
                                taxadapter.Fill(taxTable)
                                If taxTable.Rows.Count > 0 Then
                                    TAX = taxTable(0)(0)
                                    If TAX > 0 Then
                                        TAX = Math.Round(TAX * row.cells(5).value, 2)
                                        AddedTaxValue += TAX
                                        Return AddedTaxValue
                                    End If
                                End If
                            End Using
                        End Using
                    End Using
                Next
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub RegisterTransaction()

        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction

            If list_grid.Rows.Count > 0 Then
                AddedTaxValue = 0
                For Each row In list_grid.Rows
                    Using command As New SqlCommand("SELECT TAX FROM INVENTORY WHERE BARCODE=@BARCODE", connection, transaction)
                        command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = row.cells(1).value
                        Using taxTable As New DataTable
                            Using taxadapter As New SqlDataAdapter(command)
                                taxadapter.Fill(taxTable)
                                If taxTable.Rows.Count > 0 Then
                                    TAX = taxTable(0)(0)
                                    If TAX > 0 Then
                                        TAX = Math.Round(TAX * row.cells(5).value, 2)
                                        AddedTaxValue += TAX

                                    End If
                                End If
                            End Using
                        End Using
                    End Using
                Next
            End If
            If list_grid.Rows.Count >= 0 Then      ' checking if the datagridview is empty
                ' Registering the transaction to the database

                Dim RegisterTransactionQuery As String = "INSERT INTO TRANSACTIONS(TRANSACTION_ID,TRANS_DATE,TRANS_TIME,AMOUNT,PAID,TOTAL,CHANGE,TAX,PAYMENT,CASHIER,TILL,TOTAL_ITEMS,STATUS) Values(@TRANSACTION_ID,@TRANS_DATE,@TRANS_TIME,@AMOUNT,@PAID,@TOTAL,@CHANGE,@TAX,@PAYMENT,@CASHIER,@TILL,@TOTAL_ITEMS,@STATUS)"

                Using regcommand As New SqlCommand(RegisterTransactionQuery, connection, transaction)
                    With regcommand.Parameters
                        .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                        .Add("@TRANS_TIME", SqlDbType.VarChar).Value = Now.ToShortTimeString
                        .Add("@AMOUNT", SqlDbType.Decimal).Value = CDec(total_label.Text)
                        .Add("@PAID", SqlDbType.Decimal).Value = qty_paid_textbox.Text
                        .Add("@TOTAL", SqlDbType.Decimal).Value = Math.Round(CDec(total_label.Text) - AddedTaxValue, 2)
                        .Add("@CHANGE", SqlDbType.Decimal).Value = CDec(change_label.Text)
                        .Add("@TAX", SqlDbType.Decimal).Value = AddedTaxValue
                        .Add("@PAYMENT", SqlDbType.VarChar).Value = Transaction_type
                        .Add("@CASHIER", SqlDbType.VarChar).Value = username
                        .Add("@TILL", SqlDbType.VarChar).Value = till_label.Text
                        .Add("@TOTAL_ITEMS", SqlDbType.Int).Value = list_grid.RowCount
                        .Add("@STATUS", SqlDbType.VarChar).Value = "COMPLETED"
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
                            redCommand.Parameters.Add("@quantity", SqlDbType.Decimal).Value = UpdatedQuantity
                            redCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = row.Cells(1).Value
                            redCommand.ExecuteNonQuery()
                        End Using

                    End Using

                    'inserting transaction details into the database table

                    Using TransactionDetailCommand As New SqlCommand("INSERT INTO TRANS_DETAILS(TRANSACTION_ID,BARCODE,QUANTITY,AMOUNT) VALUES(@TRANSACTION_ID,@BARCODE,@QUANTITY,@AMOUNT)", connection, transaction)

                        With TransactionDetailCommand.Parameters
                            .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                            .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                            .Add("@QUANTITY", SqlDbType.Decimal).Value = row.Cells(3).Value
                            .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(5).Value

                        End With
                        list_grid.AllowUserToAddRows = False
                        TransactionDetailCommand.ExecuteNonQuery()
                    End Using

                    'check if the product has a sale for the day
                    Dim updateQuantity As Integer
                    Dim updateProfit As Decimal


                    Using command As New SqlCommand("SELECT TAX FROM INVENTORY WHERE BARCODE=@BARCODE", connection, transaction)
                        command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                        Using taxTable As New DataTable
                            Using taxadapter As New SqlDataAdapter(command)
                                taxadapter.Fill(taxTable)
                                If taxTable.Rows.Count > 0 Then
                                    TAX = taxTable(0)(0)
                                Else
                                    TAX = 0

                                End If
                            End Using
                        End Using
                    End Using

                    If TAX > 0 Then
                        TAX = TAX * row.Cells(5).Value
                    Else
                        TAX = 0
                    End If

                    'SELECT SALE FROM TH
                    Using saleSelectCommand As New SqlCommand("SELECT QUANTITY,PROFIT,AMOUNT,TAX FROM SALES WHERE BARCODE=@BARCODE AND TRANS_DATE=@trans_date AND SALE_TYPE=@sale", connection, transaction)

                        With saleSelectCommand.Parameters

                            .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                            .Add("@trans_date", SqlDbType.Date).Value = Now.ToShortDateString
                            .Add("@sale", SqlDbType.VarChar).Value = Transaction_type

                        End With

                        Dim saleSelectAdapter As New SqlDataAdapter(saleSelectCommand)
                        Dim saleSelectTable As New DataTable

                        saleSelectAdapter.Fill(saleSelectTable)

                        If saleSelectTable.Rows.Count > 0 Then
                            Dim newTax As Decimal = 0
                            If IsDBNull(saleSelectTable(0)(3)) Then
                                newTax = 0
                            Else
                                newTax = saleSelectTable(0)(3) + TAX
                            End If
                            'set quantity and profit
                            Dim localTax = newTax
                            Dim UpAmount = saleSelectTable(0)(2)
                            updateQuantity = saleSelectTable(0)(0)
                            updateProfit = saleSelectTable(0)(1)
                            updateQuantity = updateQuantity + row.Cells(3).Value
                            updateProfit = updateProfit + profit

                            'updating a sale in db SALE_TYPE
                            Using saleUpdateCommand As New SqlCommand("UPDATE SALES SET QUANTITY=@quantity,PROFIT=@profit,AMOUNT=@AMOUNT,TAX=@TAX WHERE BARCODE=@product_code and TRANS_DATE=@trans_date and SALE_TYPE=@sale", connection, transaction)

                                With saleUpdateCommand.Parameters
                                    .Add("@quantity", SqlDbType.Decimal).Value = updateQuantity
                                    .Add("@profit", SqlDbType.Decimal).Value = updateProfit
                                    .Add("@product_code", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    .Add("@trans_date", SqlDbType.Date).Value = Now.ToShortDateString
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = UpAmount + CDec(total_label.Text)
                                    .Add("@TAX", SqlDbType.Decimal).Value = localTax
                                    .Add("@sale", SqlDbType.VarChar).Value = Transaction_type
                                End With
                                saleUpdateCommand.ExecuteNonQuery()
                            End Using
                        Else
                            'registering a sale into the db

                            Using salecommand As New SqlCommand("INSERT INTO SALES(TRANS_DATE,BARCODE,QUANTITY,AMOUNT,PROFIT,SALE_TYPE,TAX) Values(@TRANS_DATE,@BARCODE,@QUANTITY,@AMOUNT,@PROFIT,@SALE_TYPE,@TAX)", connection, transaction)

                                With salecommand.Parameters
                                    .Add("@TRANS_DATE", SqlDbType.Date).Value = Now.ToShortDateString
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    .Add("@QUANTITY", SqlDbType.Decimal).Value = row.Cells(3).Value
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(5).Value
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = profit
                                    .Add("@SALE_TYPE", SqlDbType.VarChar).Value = Transaction_type
                                    .Add("@TAX", SqlDbType.Decimal).Value = TAX
                                End With
                                salecommand.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                    month = MonthName(Now.Date.Month(), False)

                    Using saleSelectCommand As New SqlCommand("SELECT QUANTITY,PROFIT,AMOUNT,TAX FROM SUMMARY_SALES WHERE BARCODE=@BARCODE AND SALE_MONTH=@TRANS_DATE AND SALE_YEAR=@SALE_YEAR AND METHOD=@METHOD", connection, transaction)
                        With saleSelectCommand.Parameters
                            .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                            .Add("@TRANS_DATE", SqlDbType.VarChar).Value = month
                            .Add("@SALE_YEAR", SqlDbType.Int).Value = Now.Year
                            .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                        End With

                        Dim saleSelectAdapter As New SqlDataAdapter(saleSelectCommand)
                        Dim saleSelectTable As New DataTable
                        saleSelectAdapter.Fill(saleSelectTable)
                        If saleSelectTable.Rows.Count > 0 Then
                            Dim newTax As Decimal = 0
                            If IsDBNull(saleSelectTable(0)(3)) Then
                                newTax = 0
                            Else
                                newTax = saleSelectTable(0)(3) + TAX
                            End If
                            'set quantity and profit
                            Dim localTax = newTax
                            Dim UpAmount = saleSelectTable(0)(2)
                            updateQuantity = saleSelectTable(0)(0)
                            updateProfit = saleSelectTable(0)(1)
                            updateQuantity = updateQuantity + row.Cells(3).Value
                            updateProfit = updateProfit + profit
                            'updating a sale in db
                            Using saleUpdateCommand As New SqlCommand("UPDATE SUMMARY_SALES SET QUANTITY=@QUANTITY,PROFIT=@PROFIT,AMOUNT=@AMOUNT,TAX=@TAX WHERE BARCODE=@BARCODE AND SALE_MONTH=@TRANSDATE AND SALE_YEAR=@SALE_YEAR AND METHOD=@METHOD", connection, transaction)

                                With saleUpdateCommand.Parameters
                                    .Add("@QUANTITY", SqlDbType.Decimal).Value = updateQuantity
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = updateProfit
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = UpAmount + CDec(total_label.Text)
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    .Add("@TRANSDATE", SqlDbType.VarChar).Value = month
                                    .Add("@SALE_YEAR", SqlDbType.Int).Value = Now.Year
                                    .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                    .Add("@TAX", SqlDbType.Decimal).Value = localTax
                                End With
                                saleUpdateCommand.ExecuteNonQuery()
                            End Using
                        Else
                            'registering a summar sale into the db
                            Using salecommand As New SqlCommand("INSERT INTO SUMMARY_SALES(SALE_MONTH,SALE_YEAR,BARCODE,QUANTITY,AMOUNT,PROFIT,METHOD,TAX) Values(@SALE_MONTH,@SALE_YEAR,@BARCODE,@QUANTITY,@AMOUNT,@PROFIT,@METHOD,@TAX)", connection, transaction)
                                With salecommand.Parameters
                                    .Add("@SALE_MONTH", SqlDbType.VarChar).Value = month
                                    .Add("@SALE_YEAR", SqlDbType.Int).Value = Now.Year
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    '.Add("@destion", SqlDbType.VarChar).Value = row.Cells(2).Value
                                    .Add("@QUANTITY", SqlDbType.Decimal).Value = row.Cells(3).Value
                                    '.Add("@cost_price", sqldbtype.decimal).Value = cost
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(5).Value
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = profit
                                    .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                    .Add("@TAX", SqlDbType.Decimal).Value = TAX
                                End With
                                salecommand.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                    Using cashupCommand As New SqlCommand("SELECT AMOUNT FROM CASHUP WHERE TRANS_DATE=@TRANS_DATE AND USERNAME=@USERNAME AND METHOD=@METHOD", connection, transaction)
                        With cashupCommand.Parameters
                            .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                            .Add("@USERNAME", SqlDbType.VarChar).Value = username
                            .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                        End With
                        Dim cashTable As New DataTable
                        Dim cashAdapter As New SqlDataAdapter(cashupCommand)
                        cashAdapter.Fill(cashTable)
                        If cashTable.Rows.Count > 0 Then
                            Dim amt As Decimal = cashTable(0)(0)
                            Using updateCashCommand As New SqlCommand("UPDATE CASHUP SET AMOUNT=@AMOUNT WHERE TRANS_DATE=@TRANS_DATE AND USERNAME=@USERNAME AND METHOD=@METHOD", connection, transaction)
                                With updateCashCommand.Parameters
                                    .Add("@AMOUNT", SqlDbType.VarChar).Value = amt + row.Cells(5).Value
                                    .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                    .Add("@USERNAME", SqlDbType.VarChar).Value = username
                                    .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                End With
                                updateCashCommand.ExecuteNonQuery()

                            End Using
                        Else

                            Using InsertCashCommand As New SqlCommand("INSERT INTO CASHUP(AMOUNT,TRANS_DATE,USERNAME,METHOD,TILL) VALUES(@AMOUNT,@TRANS_DATE,@USERNAME,@METHOD,@TILL)", connection, transaction)
                                With InsertCashCommand.Parameters
                                    .Add("@AMOUNT", SqlDbType.VarChar).Value = row.Cells(5).Value
                                    .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                    .Add("@USERNAME", SqlDbType.VarChar).Value = username
                                    .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                    .Add("@TILL", SqlDbType.VarChar).Value = till_label.Text
                                End With
                                InsertCashCommand.ExecuteNonQuery()

                            End Using
                        End If
                    End Using

                Next
                ' MessageBox.Show("Transaction is complete !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No Products has been found on the list !!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            transaction.Commit()
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
                        .Add("@quantity", SqlDbType.Decimal).Value = updateQuantity
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
                        .Add("@QUANTITY", SqlDbType.Decimal).Value = Row.Cells(3).Value
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
                        .Add("@QUANTITY", SqlDbType.Decimal).Value = updateQuantity
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
                        .Add("@QUANTITY", SqlDbType.Decimal).Value = Row.Cells(3).Value
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
            ProcessTrsactionButton.Focus()

            If CDec(SplitTotal_label.Text) >= CDec(total_label.Text) And SplitTotal_label.Text <> "" Then
                Dim change As Decimal = (SplitTotal_label.Text - total_label.Text)
                If change > 0 Then
                    change_label.Text = change
                End If

                FindMaxID()
                RegisterSplitTransaction()
                OtherPaymentsPanel.Visible = False
                Me.AcceptButton = Me.ok_button
                txtCard.Text = 0
                txtCash.Text = 0
                txtForex.Text = 0
                txtEcoCash.Text = 0
                barcode_textbox.Focus()
                hasValuePassed = True        'used in the thread completed event

                'If CombinedPayment > total_label.Text Then
                'proceed with the payment
                ' MessageBox.Show("proceeding with the payment!!")
                'RegisterTransaction()

                ' End If

                'MessageBox.Show("Transaction is complete please wait for your receipt which is being printed from the pos printer", "Transaction succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information)
                OtherPaymentsPanel.Visible = False
                If ask_radio.Checked = True Then
                    If MessageBox.Show("Do yo want to Print a Receipt for this transaction", "Receipt Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Dim ReceiptForm As New receipt_form
                        ReceiptForm.Transaction = 12
                        ReceiptForm.Show()
                        MessageBox.Show("Transaction was successful", "Transaction status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                ElseIf yes_radio.Checked = True Then
                    Dim ReceiptForm As New receipt_form
                    ReceiptForm.Transaction = 234
                    ReceiptForm.Show()
                    MessageBox.Show("Transaction was successful", "Transaction status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                AmtPanel.Visible = False
                list_grid.Rows.Clear()
                barcode_textbox.Clear()
                barcode_textbox.Focus()
                change_label.Text = 0
                total_label.Text = 0
                cost_label.Text = 0
                method_label.Text = "."


            Else
                MessageBox.Show("The amount paid is less than the charged amount of the products", "Charging less amounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            clearPaymentsAmounts()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "The system encountered the following exception, Please check if you provide all variables", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()
        End Try

    End Sub

    Private Sub OtherPaymentButton_Click(sender As Object, e As EventArgs) Handles OtherPaymentButton.Click
        Try
            AmtPanel.Visible = False
            lookupPanel.Visible = False
            Transaction_type = "MULTIPLE"
            localMethod = method_label.Text
            MultiplePayments()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Errore Occured on Split Tender", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CancelTransactionButton_Click(sender As Object, e As EventArgs) Handles CancelTransactionButton.Click
        OtherPaymentsPanel.Visible = False
        clearPaymentsAmounts()

    End Sub

    Public Sub txtForex_Click(sender As Object, e As EventArgs) Handles txtForex.Click, txtEcoCash.Click, txtCash.Click, txtCard.Click

    End Sub

    Private Sub txtForex_LostFocus(sender As Object, e As EventArgs) Handles txtForex.LostFocus, txtEcoCash.LostFocus, txtCard.LostFocus, txtCash.LostFocus
        Dim txt As TextBox = sender
        Try

            If txt.Text = "" Then
                txt.Text = 0
            End If
        Catch ex As Exception
            MsgBox("Probably you entered a character by mistake")
            txt.Text = ""
        End Try
    End Sub

    Private Sub txtForex_GotFocus(sender As Object, e As EventArgs) Handles txtForex.GotFocus, txtEcoCash.GotFocus, txtCard.GotFocus, txtCash.GotFocus
        Dim txt As TextBox = sender
        Try

            If txt.Text = 0 Then
                txt.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Probably you entered a character by mistake")
            txt.Text = ""
        End Try

    End Sub

    Private Sub Assign_Methods(sender As Object, e As EventArgs) Handles RTGS_button.Click, forex_button.Click, ecocash_button.Click, cash_button.Click
        Try
            OtherPaymentsPanel.Visible = False
            lookupPanel.Visible = False
            Dim TotalPayable As Decimal = 0
            If total_label.Text <= 0 Or total_label.Text = "" Then
                MessageBox.Show("You cannot proceed to payment since there is no product in the list", "No Product on the list", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim btn As Button = sender
                Transaction_type = btn.Text
                Me.AcceptButton = Me.FinaliseTransaction

                BaseCurrency = GetBaseCurrency()
                If BaseCurrency IsNot Transaction_type And Transaction_type IsNot "CASH" And Transaction_type IsNot "CARD" And Transaction_type IsNot "ECOCASH" And Transaction_type IsNot "MULTIPLE" Then
                    Transaction_type = "FOREX"
                End If
                localMethod = method_label.Text
                method_label.Text = Transaction_type
                If Transaction_type = "FOREX" Then
                    'THIS IMPLEMENTS ONLY CASH RATE
                    ForexPayments()

                    'implementing the cash payment method 
                ElseIf Transaction_type = "CASH" Or Transaction_type = "MULTIPLE" Then
                    'converting from forex.to cash price
                    CashPayments()

                    'CHANGING  THE PRICE FROM FOREX TO ECOCASH OR CARD BY TAKING THE CASH PRICE AND ADD THE LOCAL RTGS RATE.
                ElseIf Transaction_type = "ECOCASH" Or method_label.Text = "CARD" Then
                    CardEcocashPayments()
                End If
                If btn.Text = "CARD" Or btn.Text = "ECOCASH" Then
                    qty_paid_textbox.ReadOnly = True
                    qty_paid_textbox.Text = total_label.Text
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Encountered the following error on Payments", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub backoffice_button_Click(sender As Object, e As EventArgs) Handles backoffice_button.Click
        connection = myPermissions.getConnection
        connection.Open()
        Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION='is_admin' AND STATUS='1'", connection)
            command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                menu_form.ActiveUser = active_account_label.Text
                menu_form.ActiveUsername = username
                menu_form.Show()
                Me.Close()
            Else
                MessageBox.Show("You are restricted from accessing BackOffice", "User right restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Using
        connection.Close()
    End Sub

    Private Sub enquiry_button_Click(sender As Object, e As EventArgs) Handles enquiry_button.Click
        Try
            lookupPanel.Visible = True
            searchbar.Clear()
            searchbar.Focus()
            lookupPanel.Top = list_grid.Top
            OtherPaymentsPanel.Visible = False
            AmtPanel.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Headings()
        search_grid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        search_grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        search_grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
        search_grid.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub
    Private Sub Enquiry(ValToSearch As String)
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using command As New SqlCommand("SELECT BARCODE,NAME,QUANTITY,PRICE FROM INVENTORY WHERE BARCODE LIKE '%" & ValToSearch & "%' OR NAME LIKE '%" & ValToSearch & "%'", connection)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    search_grid.DataSource = table
                    Headings()
                Else
                    search_grid.DataSource = table
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "The system encountered the following error while perfoming a stock lookup", MessageBoxButtons.OK, MessageBoxIcon.Error)
            connection.Close()
        End Try
    End Sub
    Private Sub searchbar_TextChanged(sender As Object, e As EventArgs) Handles searchbar.TextChanged
        Enquiry(searchbar.Text)
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

    Private Sub CashPayments()
        'converting from forex.to cash price
        If localMethod = "FOREX" Then
            Try
                connection = myPermissions.getConnection
                connection.Open()
                totalsum = 0
                For Each row As DataGridViewRow In list_grid.Rows
                    Using command As New SqlCommand("SELECT PRICE FROM INVENTORY WHERE BARCODE=@BARCODE", connection)
                        command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                        Dim currencyTable As New DataTable
                        Dim adapter As New SqlDataAdapter(command)
                        adapter.Fill(currencyTable)
                        If currencyTable.Rows.Count > 0 Then
                            CurrencyRate = currencyTable(0)(0)
                            row.Cells(4).Value = CurrencyRate
                            row.Cells(5).Value = Math.Round((row.Cells(4).Value * row.Cells(3).Value), 2)
                            totalsum += row.Cells(5).Value
                        Else
                            MessageBox.Show("There was an error when trying to switch currency from forex to local currency")
                        End If
                    End Using
                Next
                total_label.Text = Math.Round(totalsum, 2)
                connection.Close()
            Catch ex As Exception
                connection.Close()
                MessageBox.Show(ex.Message, "The following error occured while trying to convert the currency from Forex")
            End Try

            'convert from cash price to ecocash or card rate
        ElseIf localMethod = "CARD" Or localMethod = "ECOCASH" Then
            Dim localRTGS As Decimal = LocalRTGSRate()
            totalsum = 0
            For row As Integer = 0 To list_grid.Rows.Count - 1
                list_grid.Rows(row).Cells(4).Value = CDec(Math.Round((list_grid.Rows(row).Cells(4).Value / localRTGS), 2))
                list_grid.Rows(row).Cells(5).Value = CDec(Math.Round((list_grid.Rows(row).Cells(5).Value / localRTGS), 2))
                totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
            Next
            total_label.Text = Math.Round(totalsum, 2)
        End If
        AmtPanel.Visible = True
        qty_viewLabel.Visible = False
        quantity_textbox.Visible = False
        Accept_Quantity.Visible = False
        HideQuantityInputs()
        Me.AcceptButton = Me.FinaliseTransaction
        AmtPanel.Visible = True
        method_label.Text = Transaction_type
        qty_paid_textbox.ReadOnly = False
        qty_paid_textbox.Text = ""
        qty_paid_textbox.Focus()

    End Sub
    Private Sub MultiplePayments()
        If localMethod = "FOREX" Then
            Try
                connection = myPermissions.getConnection
                connection.Open()
                totalsum = 0
                For Each row As DataGridViewRow In list_grid.Rows
                    Using command As New SqlCommand("SELECT PRICE FROM INVENTORY WHERE BARCODE=@BARCODE", connection)
                        command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                        Dim currencyTable As New DataTable
                        Dim adapter As New SqlDataAdapter(command)
                        adapter.Fill(currencyTable)
                        If currencyTable.Rows.Count > 0 Then
                            CurrencyRate = currencyTable(0)(0)
                            row.Cells(4).Value = CurrencyRate
                            row.Cells(5).Value = Math.Round((row.Cells(4).Value * row.Cells(3).Value), 2)
                            totalsum += row.Cells(5).Value
                        Else
                            MessageBox.Show("There was an error when trying to switch currency from forex to local currency")
                        End If
                    End Using
                Next
                total_label.Text = Math.Round(totalsum, 2)
                connection.Close()
            Catch ex As Exception
                connection.Close()
                MessageBox.Show(ex.Message, "The following error occured while trying to convert the currency from Forex")
            End Try

            'convert from cash price to ecocash or card rate
        ElseIf localMethod = "CARD" Or localMethod = "ECOCASH" Then
            Dim localRTGS As Decimal = LocalRTGSRate()
            totalsum = 0
            For row As Integer = 0 To list_grid.Rows.Count - 1
                list_grid.Rows(row).Cells(4).Value = Math.Round((list_grid.Rows(row).Cells(4).Value / localRTGS), 2)
                list_grid.Rows(row).Cells(5).Value = Math.Round((list_grid.Rows(row).Cells(5).Value / localRTGS), 2)
                totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
            Next
            total_label.Text = Math.Round(totalsum, 2)
        End If
        'AmtPanel.Visible = True
        qty_viewLabel.Visible = False
        quantity_textbox.Visible = False
        Accept_Quantity.Visible = False
        HideQuantityInputs()
        Me.AcceptButton = Me.FinaliseTransaction
        OtherPaymentsPanel.Visible = True
        method_label.Text = Transaction_type
        qty_paid_textbox.ReadOnly = False
        qty_paid_textbox.Text = ""
        qty_paid_textbox.Focus()
    End Sub
    Private Sub CardEcocashPayments()
        If localMethod = "FOREX" Then
            Try
                connection = myPermissions.getConnection
                connection.Open()
                totalsum = 0
                For Each row As DataGridViewRow In list_grid.Rows
                    Using command As New SqlCommand("SELECT PRICE FROM INVENTORY WHERE BARCODE=@BARCODE", connection)
                        command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value.ToString
                        Dim currencyTable As New DataTable
                        Dim adapter As New SqlDataAdapter(command)
                        adapter.Fill(currencyTable)
                        If currencyTable.Rows.Count > 0 Then
                            CurrencyRate = currencyTable(0)(0)
                            Dim r As Decimal = LocalRTGSRate()
                            row.Cells(4).Value = Math.Round(CurrencyRate * r, 2)
                            ' Dim ra = r * row.Cells(3).Value
                            row.Cells(5).Value = Math.Round((row.Cells(4).Value * row.Cells(3).Value), 2)
                            totalsum += row.Cells(5).Value
                        Else
                            MessageBox.Show("There was an error when trying to switch currency from forex to local currency")
                        End If
                    End Using
                Next
                total_label.Text = totalsum
                connection.Close()
            Catch ex As Exception
                connection.Close()
                MessageBox.Show(ex.Message, "The following error occured while trying to convert the currency from Forex")
            End Try

            'convert from cash price  ecocash or card rate
        ElseIf localMethod = "CASH" Or localMethod = "MULTIPLE" Or localMethod = "" Or localMethod = "." Then
            Dim localRTGS As Decimal = LocalRTGSRate()
            totalsum = 0
            For row As Integer = 0 To list_grid.Rows.Count - 1
                list_grid.Rows(row).Cells(4).Value = Math.Round(list_grid.Rows(row).Cells(4).Value * localRTGS, 2)
                list_grid.Rows(row).Cells(5).Value = Math.Round(list_grid.Rows(row).Cells(5).Value * localRTGS, 2)
                totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
            Next
            total_label.Text = Math.Round(totalsum, 2)
        End If
        AmtPanel.Visible = True
        qty_viewLabel.Visible = False
        quantity_textbox.Visible = False
        Accept_Quantity.Visible = False
        HideQuantityInputs()
        Me.AcceptButton = Me.FinaliseTransaction
        AmtPanel.Visible = True
        method_label.Text = Transaction_type
        qty_paid_textbox.ReadOnly = True
        qty_paid_textbox.Text = ""
        qty_paid_textbox.Focus()

    End Sub
    Private Sub ForexPayments()
        If localMethod = "CASH" Or localMethod = "MULTIPLE" Or localMethod = "." Or localMethod = "" Or localMethod = "ECOCASH" Or localMethod = "CARD" Then
            Try
                Forex = GetForex()
                If Forex.ToUpper = BaseCurrency.ToUpper Then
                    totalsum = 0
                    For row As Integer = 0 To list_grid.Rows.Count - 1
                        totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
                    Next
                    total_label.Text = Math.Round(totalsum, 2)
                Else
                    'CHECKS IF THE LOCAL CURRENCY IS NOT EMPTY AND SELECT RATE EITHER  CASH
                    If localMethod = "CASH" Or localMethod = "MULTIPLE" Or localMethod = "" Or localMethod = "." Then
                        DailyCurrencyRate = GetForexRate("CASH")
                        totalsum = 0
                        For row As Integer = 0 To list_grid.Rows.Count - 1
                            list_grid.Rows(row).Cells(4).Value = Math.Round(list_grid.Rows(row).Cells(4).Value / DailyCurrencyRate, 2)
                            list_grid.Rows(row).Cells(5).Value = Math.Round(list_grid.Rows(row).Cells(5).Value / DailyCurrencyRate, 2)
                            totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
                        Next
                        total_label.Text = Math.Round(totalsum, 2)
                    End If

                    'checks if the local method is ecocash or card then first return the price   to a cash price before converting  the ecocash rate to forex
                    If localMethod = "CARD" Or localMethod = "ECOCASH" Then
                        'initially get the local rtgs rate for division and devide the current price with local rtgs rate to get cash price.
                        Dim localRTGS As Decimal = LocalRTGSRate()
                        For row As Integer = 0 To list_grid.Rows.Count - 1
                            list_grid.Rows(row).Cells(4).Value = Math.Round(list_grid.Rows(row).Cells(4).Value / localRTGS, 2)
                            list_grid.Rows(row).Cells(5).Value = Math.Round(list_grid.Rows(row).Cells(5).Value / localRTGS, 2)
                        Next
                        DailyCurrencyRate = GetForexRate(localMethod)
                        totalsum = 0
                        For row As Integer = 0 To list_grid.Rows.Count - 1
                            list_grid.Rows(row).Cells(4).Value = Math.Round(list_grid.Rows(row).Cells(4).Value / DailyCurrencyRate, 2)
                            list_grid.Rows(row).Cells(5).Value = Math.Round(list_grid.Rows(row).Cells(5).Value / DailyCurrencyRate, 2)
                            totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
                        Next
                        total_label.Text = Math.Round(totalsum, 2)
                    End If
                End If
                connection.Close()
            Catch ex As Exception
                connection.Close()
                MessageBox.Show(ex.Message, "The following error occured while trying to convert the currency to Forex")
            End Try
            'implements the ecocash and swipe rate
        Else
        End If

        AmtPanel.Visible = True
        qty_viewLabel.Visible = False
        quantity_textbox.Visible = False
        Accept_Quantity.Visible = False
        HideQuantityInputs()
        Me.AcceptButton = Me.FinaliseTransaction

        AmtPanel.Visible = True
        qty_paid_textbox.ReadOnly = False
        qty_paid_textbox.Focus()

    End Sub
    Private Sub sales_Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        'cash transactions
        If e.KeyCode = Keys.F2 Then
            Transaction_type = "CASH"
            Try
                If total_label.Text <= 0 Or total_label.Text = "" Then
                    MessageBox.Show("You cannot proceed to payment since there is no product in the list", "No Product on the list", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    CashPayments()

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "An error occured on cash transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf e.KeyCode = Keys.F4 Then
            Transaction_type = "CARD"
            Try
                If total_label.Text <= 0 Or total_label.Text = "" Then
                    MessageBox.Show("You cannot proceed to payment since there is no product in the list", "No Product on the list", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    CardEcocashPayments()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "An Error Occured on Card Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf e.KeyCode = Keys.F3 Then
            Transaction_type = "ECOCASH"
            Try
                If total_label.Text <= 0 Or total_label.Text = "" Then
                    MessageBox.Show("You cannot proceed to payment since there is no product in the list", "No Product on the list", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'function calling
                    CardEcocashPayments()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error happened On Ecocash Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf e.KeyCode = Keys.F5 Then
            Transaction_type = "FOREX"
            Try
                If total_label.Text <= 0 Or total_label.Text = "" Then
                    MessageBox.Show("You cannot proceed to payment since there is no product in the list", "No Product on the list", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    'function calling
                    ForexPayments()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "An Error happenened while processing Forex Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf e.KeyCode = Keys.F6 Then
            Try
                lookupPanel.Visible = True
                AmtPanel.Visible = False

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf e.KeyCode = Keys.Add Then
            Try
                barcode_textbox.Clear()
                AmtPanel.Visible = True
                qty_viewLabel.Visible = True
                quantity_textbox.Visible = True
                Accept_Quantity.Visible = True
                HideQuantityInputs()
                Me.AcceptButton = Me.Accept_Quantity
                quantity_textbox.TextAlign = HorizontalAlignment.Right
                quantity_textbox.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "An Error Happened while adding the quantity for a Product.Please Try again", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf e.KeyCode = Keys.Escape Then
            Try
                If MessageBox.Show("Confirm Exit ", " Exit Appplication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Application.Exit()
                Else
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "An error occured while closing the system", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        ElseIf e.KeyCode = Keys.F10 Then
            Try
                If MessageBox.Show("Do you want to Reprint Last Receipt", "Reprinting Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Reprint()
                End If
            Catch ex As Exception

            End Try

        ElseIf e.KeyCode = Keys.F11 Then
            Try
                If MessageBox.Show("Are you sure you want to Open Backoffice", "Closing Sales Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    menu_form.ActiveUser = active_account_label.Text
                    menu_form.ActiveUsername = username
                    menu_form.Show()
                    Me.Hide()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error happened while closing sales form", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub Form_Thread_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Form_Thread.DoWork
        Try

            If Not qty_paid_textbox.Text Is Nothing And CDec(qty_paid_textbox.Text) >= CDec(total_label.Text) Then
                Dim change As Decimal = (qty_paid_textbox.Text - total_label.Text)
                If change > 0 Then
                    change_label.Text = change
                End If
                If isMultiple = False Then

                    FindMaxID()
                    RegisterTransaction()
                    AmtPanel.Visible = False
                    Me.AcceptButton = Me.ok_button
                    qty_paid_textbox.Clear()
                    barcode_textbox.Focus()
                    hasValuePassed = True
                Else
                    RegisterSplitTransaction()
                End If

            ElseIf qty_paid_textbox.Text = "" Then
                MessageBox.Show("You did not supply the amount paid by the customer, Please check if the amount is correct", "Error of the Payment amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                hasValuePassed = False
            ElseIf CDec(qty_paid_textbox.Text) < CDec(total_label.Text) Then
                MessageBox.Show("The amount paid by the customer is less than than the cost of products", "Supplying less amount than the cost", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error occure while processing the final transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Form_Thread_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Form_Thread.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.ToString)
        ElseIf e.Cancelled Then
            MsgBox("cancelled")
        ElseIf hasValuePassed = False Then
            MessageBox.Show("Transaction Failed Please enter the amount paid correctly or cancel the transaction if the user paid insufficient amaount. Please note, the trasaction is not going to be processed if the amount paid is less than the amount charged for the products", "Paying Less Amount Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If ask_radio.Checked = True Then
                If MessageBox.Show("Do yo want to Print a Receipt for this transaction", "Receipt Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim ReceiptForm As New receipt_form
                    ReceiptForm.Transaction = 12
                    ReceiptForm.Show()
                    MessageBox.Show("Transaction was successful", "Transaction status", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf yes_radio.Checked = True Then
                Dim ReceiptForm As New receipt_form
                ReceiptForm.Transaction = 234
                ReceiptForm.Show()
                MessageBox.Show("Transaction was successful", "Transaction status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Transaction was successful", "Transaction status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            AmtPanel.Visible = False
            list_grid.Rows.Clear()
            barcode_textbox.Clear()
            barcode_textbox.Focus()
            change_label.Text = 0
            total_label.Text = 0
            cost_label.Text = 0
            method_label.Text = "."
        End If

    End Sub

    Private Sub Cancel_Payment_Click(sender As Object, e As EventArgs) Handles Cancel_Payment.Click
        AmtPanel.Visible = False
        quantity_textbox.Clear()
        qty_paid_textbox.Clear()
        barcode_textbox.Clear()
        barcode_textbox.Focus()
        Me.AcceptButton = Me.ok_button
    End Sub
    Private Sub HideQuantityInputs()
        If qty_viewLabel.Visible = False Then
            View_AmtPaid_Label.Visible = True
        Else
            View_AmtPaid_Label.Visible = False

        End If
        If quantity_textbox.Visible = False Then
            qty_paid_textbox.Visible = True
        Else
            qty_paid_textbox.Visible = False
        End If
        If Accept_Quantity.Visible = False Then
            FinaliseTransaction.Visible = True

        Else
            FinaliseTransaction.Visible = False
        End If
    End Sub

    Private Sub Accept_Quantity_Click(sender As Object, e As EventArgs) Handles Accept_Quantity.Click
        Try
            If remainingStock > quantity_textbox.Text Then
                list_grid.Rows(iRowIndex - 1).Cells(3).Value = quantity_textbox.Text
                list_grid.Rows(iRowIndex - 1).Cells(5).Value = list_grid.Rows(iRowIndex - 1).Cells(3).Value * list_grid.Rows(iRowIndex - 1).Cells(4).Value
                totalsum = 0
                For row As Integer = 0 To list_grid.Rows.Count - 1
                    totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
                Next
                total_label.Text = totalsum.ToString("###,###,###.00")
                quantity_textbox.Clear()
                barcode_textbox.Clear()
                barcode_textbox.Focus()
                AmtPanel.Visible = False
                Me.AcceptButton = Me.ok_button
                isButchery = False
            Else
                MessageBox.Show("You out of stock, The remaining stock is " & remainingStock, "Stock level Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MsgBox(ex.StackTrace)
            quantity_textbox.Clear()
            barcode_textbox.Clear()
            barcode_textbox.Focus()
        End Try

    End Sub

    Private Sub list_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles list_grid.CellClick
        Try
            iRowIndex = list_grid.CurrentRow.Index + 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error happened", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub list_grid_Click(sender As Object, e As EventArgs) Handles list_grid.Click

        lookupPanel.Visible = False
        AmtPanel.Visible = False
        OtherPaymentsPanel.Visible = False

        barcode_textbox.Focus()
        Me.AcceptButton = Me.ok_button

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
    Private Sub escape_button_Click(sender As Object, e As EventArgs) Handles escape_button.Click
        Try
            If MessageBox.Show("Confirm Exit ", " Exit Appplication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Application.Exit()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error occured on Exit", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub f2_button_Click(sender As Object, e As EventArgs) Handles f2_button.Click
        Transaction_type = "CASH"
        CashPayments()
    End Sub

    Private Sub f3_button_Click(sender As Object, e As EventArgs) Handles f3_button.Click
        Transaction_type = "ECOCASH"
        CardEcocashPayments()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles f5_button.Click
        Transaction_type = "FOREX"
        ForexPayments()
    End Sub

    Private Sub f4_button_Click(sender As Object, e As EventArgs) Handles f4_button.Click
        Transaction_type = "CARD"
        CardEcocashPayments()

    End Sub

    Private Sub f6_button_Click(sender As Object, e As EventArgs) Handles f6_button.Click
        Try
            lookupPanel.Visible = True
            searchbar.Clear()
            searchbar.Focus()
            lookupPanel.Top = list_grid.Top
            OtherPaymentsPanel.Visible = False
            AmtPanel.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub f7_button_Click(sender As Object, e As EventArgs) Handles f7_button.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles fast_other_button.Click
        Try
            Transaction_type = "MULTIPLE"
            If method_label.Text = "FOREX" Then
                Try
                    connection = myPermissions.getConnection
                    connection.Open()
                    Using command As New SqlCommand("SELECT RATE FROM CURRENCIES", connection)
                        Dim currencyTable As New DataTable
                        Dim adapter As New SqlDataAdapter(command)
                        adapter.Fill(currencyTable)
                        If currencyTable.Rows.Count > 0 Then
                            totalsum = 0
                            For row As Integer = 0 To list_grid.Rows.Count - 1
                                totalsum = totalsum + list_grid.Rows(row).Cells(5).Value
                            Next
                            total_label.Text = totalsum
                        End If
                    End Using
                    connection.Close()
                Catch ex As Exception
                    connection.Close()
                    MessageBox.Show(ex.Message, "The following error occured while trying to convert the currency from Forex")
                End Try
            End If
            AmtPanel.Visible = False
            AmtPanel.Visible = False
            lookupPanel.Visible = False
            OtherPaymentsPanel.Visible = True
            txtCash.Focus()
            Me.AcceptButton = Me.ProcessTrsactionButton
            method_label.Text = "MULTIPLE"



        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Errore Occured on Split Tender", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles addition_button.Click
        Try
            If list_grid.RowCount < 1 Then
                MessageBox.Show("There is no product on the purchase list", "No Products to increase quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                barcode_textbox.Clear()
                AmtPanel.Visible = True
                qty_viewLabel.Visible = True
                quantity_textbox.Visible = True
                Accept_Quantity.Visible = True
                HideQuantityInputs()
                Me.AcceptButton = Me.Accept_Quantity
                quantity_textbox.TextAlign = HorizontalAlignment.Right
                quantity_textbox.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error happened while trying to increase quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub f11_button_Click(sender As Object, e As EventArgs) Handles f11_button.Click
        Try
            If MessageBox.Show("Are you sure you want to Open Backoffice", "Closing Sales Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                connection = myPermissions.getConnection
                connection.Open()
                Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION='is_admin' AND STATUS='1'", connection)
                    command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable
                    adapter.Fill(table)
                    If table.Rows.Count > 0 Then
                        menu_form.ActiveUser = active_account_label.Text
                        menu_form.ActiveUsername = username
                        menu_form.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("You are restricted from accessing BackOffice", "User right restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
                connection.Close()
            End If
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error happened while closing sales form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub f10_button_Click(sender As Object, e As EventArgs) Handles f10_button.Click
        Reprint()
    End Sub

    Private Sub f9_button_Click(sender As Object, e As EventArgs) Handles f9_button.Click

    End Sub

    Private Sub f8_button_Click(sender As Object, e As EventArgs) Handles f8_button.Click

    End Sub

    Private Sub cancelTrans_button_Click(sender As Object, e As EventArgs) Handles cancelTrans_button.Click
        Try
            list_grid.Rows.Clear()
            method_label.Text = "."
            change_label.Text = 0
            total_label.Text = 0
            cost_label.Text = 0
            Register_Transaction = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error Occured when cancelling a transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub void_button_Click(sender As Object, e As EventArgs) Handles void_button.Click
        Try
            If MessageBox.Show("Do you want to remove this product from List", "Void", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                list_grid.Rows.Remove(list_grid.Rows(iRowIndex - 1))
                If list_grid.RowCount > 0 Then
                    totalsum = 0
                    For Each row As DataGridViewRow In list_grid.Rows
                        row.Cells(0).Value = row.Index + 1
                        totalsum += row.Cells(5).Value
                    Next
                    total_label.Text = totalsum.ToString("###,###,###.00")
                Else
                    cost_label.Text = 0
                    total_label.Text = 0
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "The following error occured when removing the product from sales list", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Reprint()
        Dim transaction_id As String
        Dim my_id As Integer
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Dim table As New DataTable
            Using Command As New SqlCommand("SELECT MAX(ID) FROM TRANSACTIONS", connection)
                Dim adapter As New SqlDataAdapter(Command)
                adapter.Fill(table)
                my_id = table(0)(0)
            End Using
            Using Command As New SqlCommand("SELECT TRSANSACTION_ID FROM TRANSACTIONS WHERE ID=@id", connection)
                Command.Parameters.Add("@id", SqlDbType.Int).Value = my_id
                Dim table1 As New DataTable
                Dim adapter As New SqlDataAdapter(Command)
                adapter.Fill(table1)
                transaction_id = table1(0)(0)
            End Using

            connection.Close()

            Dim ReceiptForm As New receipt_form
            ReceiptForm.Transaction = transaction_id
            ReceiptForm.Show()

        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error Occured While Reprinting the Last transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub reprint_button_Click(sender As Object, e As EventArgs) Handles reprint_button.Click
        Reprint()
    End Sub

    Private Sub OtherPaymentsPanel_Paint(sender As Object, e As PaintEventArgs) Handles OtherPaymentsPanel.Paint

    End Sub
    Private Sub RegisterSplitTransaction()

        Try
            connection = myPermissions.getConnection()
            connection.Open()

            Dim transaction As SqlTransaction = connection.BeginTransaction

            If list_grid.Rows.Count > 0 Then
                AddedTaxValue = 0
                For Each row In list_grid.Rows
                    Using command As New SqlCommand("SELECT TAX FROM INVENTORY WHERE BARCODE=@BARCODE", connection, transaction)
                        command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = row.cells(1).value
                        Using taxTable As New DataTable
                            Using taxadapter As New SqlDataAdapter(command)
                                taxadapter.Fill(taxTable)
                                If taxTable.Rows.Count > 0 Then
                                    TAX = taxTable(0)(0)
                                    If TAX > 0 Then
                                        TAX = Math.Round(TAX * row.cells(5).value, 2)
                                        AddedTaxValue += TAX

                                    End If
                                End If
                            End Using
                        End Using
                    End Using
                Next
            End If

            If list_grid.Rows.Count >= 0 Then      ' checking if the datagridview is empty
                ' Registering the transaction to the database

                Dim RegisterTransactionQuery As String = "INSERT INTO TRANSACTIONS(TRANSACTION_ID,TRANS_DATE,TRANS_TIME,AMOUNT,PAID,TOTAL,CHANGE,TAX,PAYMENT,CASHIER,TILL,TOTAL_ITEMS,STATUS) Values(@TRANSACTION_ID,@TRANS_DATE,@TRANS_TIME,@AMOUNT,@PAID,@TOTAL,@CHANGE,@TAX,@PAYMENT,@CASHIER,@TILL,@TOTAL_ITEMS,@STATUS)"

                Using regcommand As New SqlCommand(RegisterTransactionQuery, connection, transaction)
                    With regcommand.Parameters
                        .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                        .Add("@TRANS_TIME", SqlDbType.VarChar).Value = Now.ToShortTimeString
                        .Add("@AMOUNT", SqlDbType.Decimal).Value = CDec(total_label.Text)
                        .Add("@PAID", SqlDbType.Decimal).Value = SplitTotal_label.Text
                        .Add("@TOTAL", SqlDbType.Decimal).Value = Math.Round(CDec(total_label.Text) - AddedTaxValue, 2)
                        .Add("@CHANGE", SqlDbType.Decimal).Value = CDec(change_label.Text)
                        .Add("@TAX", SqlDbType.Decimal).Value = AddedTaxValue
                        .Add("@PAYMENT", SqlDbType.VarChar).Value = Transaction_type
                        .Add("@CASHIER", SqlDbType.VarChar).Value = username
                        .Add("@TILL", SqlDbType.VarChar).Value = till_label.Text
                        .Add("@TOTAL_ITEMS", SqlDbType.Int).Value = list_grid.RowCount
                        .Add("@STATUS", SqlDbType.VarChar).Value = "COMPLETED"
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
                            redCommand.Parameters.Add("@quantity", SqlDbType.Decimal).Value = UpdatedQuantity
                            redCommand.Parameters.Add("@barcode", SqlDbType.VarChar).Value = row.Cells(1).Value
                            redCommand.ExecuteNonQuery()
                        End Using

                    End Using

                    'inserting transaction details into the database table

                    Using TransactionDetailCommand As New SqlCommand("INSERT INTO TRANS_DETAILS(TRANSACTION_ID,BARCODE,QUANTITY,AMOUNT) VALUES(@TRANSACTION_ID,@BARCODE,@QUANTITY,@AMOUNT)", connection, transaction)

                        With TransactionDetailCommand.Parameters
                            .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                            .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                            .Add("@QUANTITY", SqlDbType.Decimal).Value = row.Cells(3).Value
                            .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(5).Value

                        End With
                        list_grid.AllowUserToAddRows = False
                        TransactionDetailCommand.ExecuteNonQuery()
                    End Using


                    'check if the product has a sale for the day
                    Dim updateQuantity As Integer
                    Dim updateProfit As Decimal

                    Using command As New SqlCommand("SELECT TAX FROM INVENTORY WHERE BARCODE=@BARCODE", connection, transaction)
                        command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                        Using taxTable As New DataTable
                            Using taxadapter As New SqlDataAdapter(command)
                                taxadapter.Fill(taxTable)
                                If taxTable.Rows.Count > 0 Then
                                    TAX = taxTable(0)(0)
                                ElseIf IsDBNull(taxTable(0)(0)) Then
                                    TAX = 0
                                Else
                                    TAX = 0
                                End If
                            End Using
                        End Using
                    End Using

                    If TAX > 0 Then
                        TAX = TAX * row.Cells(5).Value
                    Else
                        TAX = 0
                    End If

                    'SELECT SALE FROM TH
                    Using saleSelectCommand As New SqlCommand("SELECT QUANTITY,PROFIT,AMOUNT,TAX FROM SALES WHERE BARCODE=@BARCODE and TRANS_DATE=@trans_date and SALE_TYPE=@sale", connection, transaction)

                        With saleSelectCommand.Parameters

                            .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                            .Add("@trans_date", SqlDbType.Date).Value = Now.ToShortDateString
                            .Add("@sale", SqlDbType.VarChar).Value = Transaction_type

                        End With

                        Dim saleSelectAdapter As New SqlDataAdapter(saleSelectCommand)
                        Dim saleSelectTable As New DataTable

                        saleSelectAdapter.Fill(saleSelectTable)

                        If saleSelectTable.Rows.Count > 0 Then
                            Dim newTax As Decimal = 0
                            If IsDBNull(saleSelectTable(0)(3)) Then
                                newTax = 0
                            Else
                                newTax = saleSelectTable(0)(3)

                            End If
                            'set quantity and profit
                            Dim LocalTax = Newtax + TAX
                            Dim UpAmount = saleSelectTable(0)(2)
                            updateQuantity = saleSelectTable(0)(0)
                            updateProfit = saleSelectTable(0)(1)
                            updateQuantity = updateQuantity + row.Cells(3).Value
                            updateProfit = updateProfit + profit

                            'updating a sale in db SALE_TYPE
                            Using saleUpdateCommand As New SqlCommand("UPDATE SALES SET QUANTITY=@quantity,PROFIT=@profit,AMOUNT=@AMOUNT,TAX=@TAX WHERE BARCODE=@product_code and TRANS_DATE=@trans_date and SALE_TYPE=@sale", connection, transaction)

                                With saleUpdateCommand.Parameters
                                    .Add("@quantity", SqlDbType.Decimal).Value = updateQuantity
                                    .Add("@profit", SqlDbType.Decimal).Value = updateProfit
                                    .Add("@product_code", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    .Add("@trans_date", SqlDbType.Date).Value = Now.ToShortDateString
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = UpAmount + CDec(total_label.Text)
                                    .Add("@sale", SqlDbType.VarChar).Value = Transaction_type
                                    .Add("@TAX", SqlDbType.Decimal).Value = LocalTax
                                End With
                                saleUpdateCommand.ExecuteNonQuery()
                            End Using
                        Else
                            'registering a sale into the db

                            Using salecommand As New SqlCommand("INSERT INTO SALES(TRANS_DATE,BARCODE,QUANTITY,AMOUNT,PROFIT,SALE_TYPE,TAX) Values(@TRANS_DATE,@BARCODE,@QUANTITY,@AMOUNT,@PROFIT,@SALE_TYPE,@TAX)", connection, transaction)

                                With salecommand.Parameters
                                    .Add("@TRANS_DATE", SqlDbType.Date).Value = Now.ToShortDateString
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    .Add("@QUANTITY", SqlDbType.Decimal).Value = row.Cells(3).Value
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(5).Value
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = profit
                                    .Add("@SALE_TYPE", SqlDbType.VarChar).Value = Transaction_type
                                    .Add("@TAX", SqlDbType.Decimal).Value = TAX
                                End With
                                salecommand.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                    month = MonthName(Now.Date.Month(), False)

                    Using saleSelectCommand As New SqlCommand("SELECT QUANTITY,PROFIT,AMOUNT,TAX FROM SUMMARY_SALES WHERE BARCODE=@BARCODE AND SALE_MONTH=@TRANS_TIME AND SALE_YEAR=@TRANS_DATE AND METHOD=@METHOD", connection, transaction)
                        With saleSelectCommand.Parameters
                            .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                            .Add("@TRANS_TIME", SqlDbType.VarChar).Value = month
                            .Add("@TRANS_DATE", SqlDbType.Int).Value = Now.Year
                            .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                        End With

                        Dim saleSelectAdapter As New SqlDataAdapter(saleSelectCommand)
                        Dim saleSelectTable As New DataTable
                        saleSelectAdapter.Fill(saleSelectTable)
                        If saleSelectTable.Rows.Count > 0 Then
                            Dim newTax As Decimal = 0
                            If IsDBNull(saleSelectTable(0)(3)) Then
                                newTax = 0
                            Else
                                newTax = saleSelectTable(0)(3)

                            End If
                            'set quantity and profit
                            Dim LocalTax = newTax + TAX
                            Dim UpAmount = saleSelectTable(0)(2)
                            updateQuantity = saleSelectTable(0)(0)
                            updateProfit = saleSelectTable(0)(1)
                            updateQuantity = updateQuantity + row.Cells(3).Value
                            updateProfit = updateProfit + profit
                            'updating a sale in db
                            Using saleUpdateCommand As New SqlCommand("UPDATE SUMMARY_SALES SET QUANTITY=@QUANTITY,PROFIT=@PROFIT,AMOUNT=@AMOUNT WHERE BARCODE=@BARCODE AND SALE_MONTH=@TRANSDATE AND SALE_YEAR=@SALE_YEAR AND METHOD=@METHOD", connection, transaction)

                                With saleUpdateCommand.Parameters
                                    .Add("@QUANTITY", SqlDbType.Decimal).Value = updateQuantity
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = updateProfit
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = UpAmount + CDec(total_label.Text)
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    .Add("@TRANSDATE", SqlDbType.VarChar).Value = month
                                    .Add("@SALE_YEAR", SqlDbType.Int).Value = Now.Year
                                    .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                    .Add("@TAX", SqlDbType.Decimal).Value = LocalTax
                                    'to display use date January and dateNow 
                                End With
                                saleUpdateCommand.ExecuteNonQuery()
                            End Using
                        Else
                            'registering a summar sale into the db
                            Using salecommand As New SqlCommand("INSERT INTO SUMMARY_SALES(SALE_MONTH,SALE_YEAR,BARCODE,QUANTITY,AMOUNT,PROFIT,METHOD,TAX) Values(@SALE_MONTH,@SALE_YEAR,@BARCODE,@QUANTITY,@AMOUNT,@PROFIT,@METHOD,@TAX)", connection, transaction)
                                With salecommand.Parameters
                                    .Add("@SALE_MONTH", SqlDbType.VarChar).Value = month
                                    .Add("@SALE_YEAR", SqlDbType.Int).Value = Now.Year
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row.Cells(1).Value
                                    '.Add("@destion", SqlDbType.VarChar).Value = row.Cells(2).Value
                                    .Add("@QUANTITY", SqlDbType.Decimal).Value = row.Cells(3).Value
                                    '.Add("@cost_price", sqldbtype.decimal).Value = cost
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = row.Cells(5).Value
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = profit
                                    .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                    .Add("@TAX", SqlDbType.Decimal).Value = TAX
                                End With
                                salecommand.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                Next
                'creating an array for all used methods which will be used to save the amount into the other methods for tressing of payment method per sale
                Dim txtBoxArray() As TextBox = {txtCard, txtCash, txtEcoCash, txtForex}

                Using cashupCommand As New SqlCommand("SELECT AMOUNT FROM CASHUP WHERE TRANS_DATE=@TRANS_DATE AND USERNAME=@USERNAME AND METHOD=@METHOD", connection, transaction)
                    With cashupCommand.Parameters
                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                    End With
                    Dim cashTable As New DataTable
                    Dim cashAdapter As New SqlDataAdapter(cashupCommand)
                    cashAdapter.Fill(cashTable)
                    If cashTable.Rows.Count > 0 Then
                        Dim amt As Decimal = cashTable(0)(0)
                        'Using updateCashCommand As New SqlCommand("UPDATE CASHUP SET AMOUNT=@AMOUNT WHERE TRANS_DATE=@TRANS_DATE AND USERNAME=@USERNAME AND METHOD=@METHOD", connection, transaction)
                        '    With updateCashCommand.Parameters
                        '        .Add("@AMOUNT", SqlDbType.VarChar).Value = amt + CDec(total_label.Text)
                        '        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                        '        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                        '        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                        '    End With
                        '    updateCashCommand.ExecuteNonQuery()

                        'End Using
                        ''iterating through the array
                        For Each element As TextBox In txtBoxArray

                            If element.Text > 0 Or element.Text <> "" Then    'checking the quantity in the textbox
                                'ASSOCIATE A METHOD WITH A TEXTBOX
                                If element Is txtCard Then Transaction_type = "CARD"
                                If element Is txtCash Then Transaction_type = "CASH"
                                If element Is txtEcoCash Then Transaction_type = "ECOCASH"
                                If element Is txtForex Then Transaction_type = "FOREX"
                                Using splitCommand As New SqlCommand("INSERT INTO OTHER_METHODS(TRANS_DATE,TRANSACTION_ID,METHOD,AMOUNT) VALUES(@TRANS_DATE,@TRANSACTION_ID,@METHOD,@AMOUNT)", connection, transaction)
                                    With splitCommand.Parameters
                                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                        .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                                        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                        .Add("@AMOUNT", SqlDbType.Decimal).Value = element.Text
                                    End With
                                    splitCommand.ExecuteNonQuery()
                                End Using

                                Using command As New SqlCommand("SELECT AMOUNT FROM OTHER_METHODS_SUMMARY WHERE TRANS_DATE=@TRANS_DATE AND METHOD=@METHOD AND USERNAME=@USERNAME", connection, transaction)
                                    With command.Parameters
                                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                                    End With
                                    Using otherAdapter As New SqlDataAdapter(command)
                                        Using otherTable As New DataTable
                                            otherAdapter.Fill(otherTable)
                                            If otherTable.Rows.Count > 0 Then
                                                Using otherCommand As New SqlCommand("UPDATE OTHER_METHODS_SUMMARY SET AMOUNT=@AMOUNT WHERE TRANS_DATE=@TRANS_DATE AND METHOD=@METHOD AND USERNAME=@USERNAME", connection, transaction)
                                                    With otherCommand.Parameters
                                                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                                        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                                        .Add("@AMOUNT", SqlDbType.Decimal).Value = otherTable(0)(0) + element.Text
                                                        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                                                    End With
                                                    otherCommand.ExecuteNonQuery()
                                                End Using
                                            Else
                                                Using otherCommand As New SqlCommand("INSERT INTO OTHER_METHODS_SUMMARY (TRANS_DATE,METHOD, AMOUNT, USERNAME) VALUES(@TRANS_DATE,@METHOD, @AMOUNT, @USERNAME)", connection, transaction)
                                                    With otherCommand.Parameters
                                                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                                        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                                        .Add("@AMOUNT", SqlDbType.Decimal).Value = element.Text
                                                        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                                                    End With
                                                    otherCommand.ExecuteNonQuery()
                                                End Using
                                            End If
                                        End Using
                                    End Using
                                End Using
                            End If
                        Next
                    Else

                        ''Using InsertCashCommand As New SqlCommand("INSERT INTO CASHUP(AMOUNT,TRANS_DATE,USERNAME,METHOD,TILL) VALUES(@AMOUNT,@TRANS_DATE,@USERNAME,@METHOD,@TILL)", connection, transaction)
                        ''    With InsertCashCommand.Parameters
                        ''        .Add("@AMOUNT", SqlDbType.VarChar).Value = CDec(total_label.Text)
                        ''        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                        ''        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                        ''        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                        ''        .Add("@TILL", SqlDbType.VarChar).Value = till_label.Text
                        ''    End With
                        ''    InsertCashCommand.ExecuteNonQuery()

                        ''End Using

                        'iterating through the array
                        For Each element As TextBox In txtBoxArray

                            If element.Text > 0 Or element.Text <> "" Then    'checking the quantity in the textbox
                                'ASSOCIATE A METHOD WITH A TEXTBOX
                                If element Is txtCard Then Transaction_type = "CARD"
                                If element Is txtCash Then Transaction_type = "CASH"
                                If element Is txtEcoCash Then Transaction_type = "ECOCASH"
                                If element Is txtForex Then Transaction_type = "FOREX"
                                Using splitCommand As New SqlCommand("INSERT INTO OTHER_METHODS(TRANS_DATE,TRANSACTION_ID,METHOD,AMOUNT) VALUES(@TRANS_DATE,@TRANSACTION_ID,@METHOD,@AMOUNT)", connection, transaction)
                                    With splitCommand.Parameters
                                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                        .Add("@TRANSACTION_ID", SqlDbType.VarChar).Value = Register_Transaction
                                        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                        .Add("@AMOUNT", SqlDbType.Decimal).Value = element.Text
                                    End With
                                    splitCommand.ExecuteNonQuery()
                                End Using

                                'MINI CASH UP

                                Using command As New SqlCommand("SELECT AMOUNT FROM OTHER_METHODS_SUMMARY WHERE TRANS_DATE=@TRANS_DATE AND METHOD=@METHOD AND USERNAME=@USERNAME", connection, transaction)
                                    With command.Parameters
                                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                                    End With
                                    Using otherAdapter As New SqlDataAdapter(command)
                                        Using otherTable As New DataTable
                                            otherAdapter.Fill(otherTable)
                                            If otherTable.Rows.Count > 0 Then
                                                Using otherCommand As New SqlCommand("UPDATE OTHER_METHODS_SUMMARY SET AMOUNT=@AMOUNT WHERE TRANS_DATE=@TRANS_DATE AND METHOD=@METHOD AND USERNAME=@USERNAME", connection, transaction)
                                                    With otherCommand.Parameters
                                                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                                        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                                        .Add("@AMOUNT", SqlDbType.Decimal).Value = otherTable(0)(0) + element.Text
                                                        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                                                    End With
                                                    otherCommand.ExecuteNonQuery()
                                                End Using
                                            Else
                                                Using otherCommand As New SqlCommand("INSERT INTO OTHER_METHODS_SUMMARY (TRANS_DATE,METHOD, AMOUNT, USERNAME) VALUES(@TRANS_DATE,@METHOD, @AMOUNT, @USERNAME)", connection, transaction)
                                                    With otherCommand.Parameters
                                                        .Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                                                        .Add("@METHOD", SqlDbType.VarChar).Value = Transaction_type
                                                        .Add("@AMOUNT", SqlDbType.Decimal).Value = element.Text
                                                        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                                                    End With
                                                    otherCommand.ExecuteNonQuery()
                                                End Using
                                            End If
                                        End Using
                                    End Using
                                End Using

                            End If
                        Next
                    End If
                End Using

                transaction.Commit()

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

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtForex.TextChanged, txtEcoCash.TextChanged, txtCash.TextChanged, txtCard.TextChanged
        Try
            Dim NullText() As TextBox = {txtCard, txtCash, txtEcoCash, txtForex}
            Dim forex As Decimal = 0
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT RATE FROM CURRENCIES", connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    SplitTotal_label.Text = 0
                    For Each item In NullText
                        If item.Text <> "" Then
                            If item.Name = "txtForex" Then
                                forex = CDec(item.Text) * CDec(table(0)(0))
                                SplitTotal_label.Text += forex
                            Else
                                SplitTotal_label.Text += CDec(item.Text)
                            End If
                        End If
                    Next
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error Occured Adding the split tender", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub search_grid_KeyDown(sender As Object, e As KeyEventArgs) Handles search_grid.KeyDown
        Try

            Dim dgv As DataGridView = TryCast(sender, DataGridView)
            Dim dt As DataTable = TryCast(dgv.DataSource, DataTable)

            If dgv.Rows.Count > 0 Then
                Dim index As Integer = dgv.CurrentRow.Index

                If e.KeyData = (Keys.Control + Keys.Up) Then
                    dgv.CurrentCell = Nothing
                    Dim dgvr As DataGridViewRow() = New DataGridViewRow(1) {dgv.Rows(index), dgv.Rows(index - 1)}

                    For Each row In dgvr
                        dgv.Rows.Remove(row)
                    Next

                    dgv.Rows.InsertRange(index, dgvr)
                ElseIf e.KeyData = (Keys.Control Or Keys.Down) Then
                    dgv.CurrentCell = Nothing
                    Dim dgvr As DataGridViewRow() = New DataGridViewRow(1) {dgv.Rows(index + 1), dgv.Rows(index)}

                    For Each row In dgvr
                        dgv.Rows.Remove(row)
                    Next

                    dgv.Rows.InsertRange(index, dgvr)
                ElseIf e.KeyData = (Keys.Control + Keys.Enter) Then
                    AddProductToGrid(search_grid.SelectedRows.Item(0).Cells(0).Value.ToString)
                    lookupPanel.Hide()
                    barcode_textbox.Clear()
                    barcode_textbox.Focus()
                End If

                dgv.DataSource = dt
                dgv.Rows(index).Selected = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub searchbar_KeyDown(sender As Object, e As KeyEventArgs) Handles searchbar.KeyDown
        Try
            If e.KeyData = Keys.Down Then
                If search_grid.RowCount > 0 Then
                    search_grid.Focus()
                    search_grid.Rows(0).Selected = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Try
            If MessageBox.Show("Are you sure you want to logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                sign_in.Show()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dayEnd_rpt_Click(sender As Object, e As EventArgs) Handles dayEnd_rpt.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION='dayEnd_reports' AND STATUS='1'", connection)
                command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    DayEndReportForm.ShowDialog()
                Else
                    MessageBox.Show("OOps sorry , seems you don't have the rights to open this report", "User Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error occured while processing dayend Reports", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class