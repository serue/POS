Imports System.Data.SqlClient

Public Class receipt_form
    Dim myPermissions As New ConnectionAndPermissions
    Dim connection As SqlConnection

    Private TransId As String = ""

    Public Property Transaction As String


        Get
            Return TransId
        End Get
        Set(value As String)

            TransId = value

        End Set

    End Property
    Private Sub receipt_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    connection.Open()

        '    Dim table As New DataTable
        '    Using command As New SqlCommand("SELECT * FROM TRANSACTIONS WHERE TRANSACTION_ID=@receipt", connection)

        '        command.Parameters.Add("@receipt", SqlDbType.VarChar).Value = TransId
        '        Dim adapter As New SqlDataAdapter(command)

        '        adapter.Fill(table)

        '    End Using


        '    Dim table1 As New DataTable
        '    Using command As New SqlCommand("SELECT * FROM TRANSACTION_DETAILS WHERE TRANSACTION_ID=@receipt", connection)

        '        command.Parameters.Add("@receipt", SqlDbType.VarChar).Value = TransId
        '        Dim adapter As New SqlDataAdapter(command)

        '        adapter.Fill(table1)

        '    End Using

        '    Dim CoTable As New DataTable
        '    Using command As New SqlCommand("SELECT * FORM COMPANY", connection)
        '        Dim adapter As New SqlDataAdapter(command)
        '        adapter.Fill(CoTable)

        '    End Using

        '    Dim taxTable As New DataTable
        '    Using command As New SqlCommand("SELECT * FROM TAX", connection)
        '        Dim ADAPTER As New SqlDataAdapter(command)
        '        ADAPTER.Fill(taxTable)
        '    End Using
        '    connection.Close()

        '    'Dim rep As New CrystalReport1
        '    rep.Database.Tables("TRANSACTIONS").SetDataSource(table)
        '    rep.Database.Tables("TRANSACTION_DETAILS").SetDataSource(table1)
        '    rep.Database.Tables("COMPANY").SetDataSource(CoTable)
        '    rep.Database.Tables("TAX").SetDataSource(taxTable)

        '    'Me.CrystalReportViewer1.ReportSource = rep
        '    rep.PrintToPrinter(1, False, 0, 0)

        Me.Close()
        'Catch ex As Exception
        '    connection.Close()
        '    MessageBox.Show(ex.Message, "Operation Error")
        'End Try
    End Sub
End Class