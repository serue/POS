Imports System.Net
Public Class settings
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

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
        vat.Clear()
        txtTillNumber.Clear()
        currency_name.Focus()
    End Sub
End Class