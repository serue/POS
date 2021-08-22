Imports System.Data.SqlClient
Public Class transaction_log
    Dim connection As sqlconnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub transaction_log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLog()
    End Sub
    Private Sub loadLog()
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT TRANS_DATE AS DATE,TRANSACTION_ID AS REFERENCE,CASHIER,AMOUNT FROM TRANSACTIONS", connection)
                Dim reader As SqlDataReader = command.ExecuteReader
                Dim table As New DataTable
                table.Load(reader)
                list_grid.DataSource = table
                Headers()
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Headers()
        Try
            list_grid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            list_grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            list_grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            list_grid.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        Catch ex As Exception

        End Try
    End Sub
    Private Sub FilterData()
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT TRANS_DATE AS DATE,TRANSACTION_ID AS REFERENCE,CASHIER,AMOUNT FROM TRANSACTIONS WHERE CASHIER=@CASHIER AND TRANS_DATE BETWEEN @FROM AND @TO", connection)
                With command.Parameters
                    .Add("@CASHIER", SqlDbType.VarChar).Value = cashier.Text
                    .Add("@FROM", SqlDbType.DateTime).Value = currenDate.Text
                    .Add("@TO", SqlDbType.DateTime).Value = TODATE.Text
                End With
                Dim reader As SqlDataReader = command.ExecuteReader
                Dim table As New DataTable
                table.Load(reader)
                Headers()
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        FilterData()
    End Sub
End Class