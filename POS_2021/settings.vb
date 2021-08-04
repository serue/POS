Imports System.Data.SqlClient
Imports System.Net
Public Class settings
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim MyID As Integer = 0
    Dim company As String = ""
    Private user As String

    Public Property ActiveUser() As String
        Get
            Return user
        End Get
        Set(ByVal value As String)
            user = value
        End Set
    End Property
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = Dns.GetHostName
        txtTillName.Text = name
        loadSettings()
        Try
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
                        MessageBox.Show("Till has been set successfully", "Setting Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End If


            connection.Close()
        Catch ex As Exception

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
        menu_form.Show()
        Me.Close()
    End Sub

    Private Sub save_currency_Click(sender As Object, e As EventArgs) Handles save_currency.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("INSERT INTO CURRENCIES(CURRENCY,SYMBOL,RATE) VALUES(@CURRENCY,@SYMBOL,@RATE)", connection)
                With command.Parameters
                    .Add("@CURRENCY", SqlDbType.VarChar).Value = currency_combo.Text
                    .Add("@SYMBOL", SqlDbType.VarChar).Value = FOREX_SYMBOL.Text
                    .Add("@RATE", SqlDbType.Decimal).Value = rate_textbox.Text
                End With
                command.ExecuteNonQuery()
            End Using
            MessageBox.Show("CURRENCY ADDED SUCCESSFULLY!!", "ADDING CURRENCY", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Using command As New SqlCommand("SELECT CURRENCY,SYMBOL FROM BASE_CURRENCY", connection)
                Dim TABLE As New DataTable
                Dim adapters As New SqlDataAdapter(command)
                adapters.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    currency_name.Text = TABLE(0)(0)
                    currency_symbol.Text = TABLE(0)(1)

                End If
            End Using

            'loading tills
            Using command As New SqlCommand("SELECT TILL_NAME,TILL_NUMBER FROM TILLS", connection)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    txtTillName.Text = table(0)(0)
                    txtTillNumber.Text = table(0)(1)
                End If

            End Using

            'load tax
            Using command As New SqlCommand("SELECT VAT_NO,VAT,NOTES FROM TAX", connection)
                Dim TABLE As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then

                    vat_number.Text = TABLE(0)(0)
                    vat_textbox.Text = TABLE(0)(1)
                    vatNotes_textbox.Text = TABLE(0)(2)

                End If
            End Using

            'load forex
            Using command As New SqlCommand("SELECT CURRENCY,SYMBOL,RATE FROM CURRENCIES", connection)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    currency_combo.Text = table(0)(0)
                    FOREX_SYMBOL.Text = table(0)(1)
                    rate_textbox.Text = table(0)(2)

                End If


            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "AN ERROR OCCURED LOADING SETTINGS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class