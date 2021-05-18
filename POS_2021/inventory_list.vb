Imports System.Data.SqlClient

Public Class inventory_list
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub inventory_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using Command As New SqlCommand("SELECT ID,BARCODE,NAME,QUANTITY,SALE_QTY,MARGIN,PRICE FROM INVENTORY", connection)
                Dim adapter As New SqlDataAdapter(Command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    list_grid.DataSource = table
                End If
            End Using
            HeaderText()
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error while retrieving data for Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub HeaderText()

        '  id, product_code, description, receipt_name, current_stock, selling_price

        list_grid.Columns(0).HeaderText = "ID"
        list_grid.Columns(1).HeaderText = "BARCODE"
        list_grid.Columns(2).HeaderText = "NAME"
        list_grid.Columns(3).HeaderText = "QUANTITY"
        list_grid.Columns(4).HeaderText = "SALE QUANTITY"
        list_grid.Columns(5).HeaderText = "MARGIN"
        list_grid.Columns(6).HeaderText = "PRICE"




        ''styling rows from the datagridview

        list_grid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        list_grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        list_grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        list_grid.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        list_grid.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        list_grid.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        list_grid.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        ''text align
        list_grid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        list_grid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        list_grid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        list_grid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        list_grid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        list_grid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        list_grid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    End Sub

    Private Sub refresh_button_Click(sender As Object, e As EventArgs) Handles refresh_button.Click

    End Sub
End Class