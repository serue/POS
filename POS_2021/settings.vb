Imports System.Data.SqlClient
Imports System.Net
Public Class settings
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim MyID As Integer = 0
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim name As String = Dns.GetHostName
        txtTillName.Text = name
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
                    MessageBox.Show("CANNOT SSAVE THE CURRENCY, SEEMS THERE IS ALREADY CURRENCY, YOU CAN UPDATE IT ONLY", "CURRENCY", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                            .Add("@TILL_NAME", SqlDbType.VarChar).Value = currency_name.Text
                            .Add("@TILL_NUMBER", SqlDbType.VarChar).Value = currency_symbol.Text
                        End With
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Till has been set successfully", "Setting Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            Using CMD As New SqlCommand("SELECT ID FROM TAX", connection)
                Dim TABLE As New DataTable
                Dim ADAPTER As New SqlDataAdapter(CMD)
                ADAPTER.Fill(TABLE)
                If TABLE.Rows.Count > 0 Then
                    MessageBox.Show("CANNOT SAVE THE TAX, SEEMS IT IS ALREADY SAVED, YOU CAN UPDATE IT ONLY", "TAX", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Using command As New SqlCommand("INSERT INTO TAX(TILL_NAME,TILL_NUMBER) VALUES(@TILL_NAME,@TILL_NUMBER)", connection)
                        With command.Parameters
                            .Add("@TILL_NAME", SqlDbType.VarChar).Value = currency_name.Text
                            .Add("@TILL_NUMBER", SqlDbType.VarChar).Value = currency_symbol.Text
                        End With
                        command.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Till has been set successfully", "Setting Currency", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using

            connection.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class