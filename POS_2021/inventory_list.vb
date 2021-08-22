Imports System.Data.SqlClient

Public Class inventory_list
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim productID As Integer
    Private Sub inventory_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using Command As New SqlCommand("SELECT ID,BARCODE,NAME,QUANTITY,SALE_QTY,MARGIN,PRICE FROM INVENTORY WHERE PRODUCT_STATUS='1'", connection)
                Dim adapter As New SqlDataAdapter(Command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    list_grid.DataSource = table
                    HeaderText()
                Else
                    MessageBox.Show("No Product found ACTIVE Products", "SEARCHING PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

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

    Private Sub NewStock_button_Click(sender As Object, e As EventArgs) Handles NewStock_button.Click
        panel_Stock.Visible = True
        quantity_box.Focus()
    End Sub

    Private Sub Save_button_Click(sender As Object, e As EventArgs) Handles Save_button.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            If (list_grid.SelectedRows.Count = 1) Then
                productID = list_grid.CurrentRow.Cells(0).Value.ToString
                Using command As New SqlCommand("SELECT QUANTITY FROM INVENTORY WHERE ID=@ID AND PRODUCT_STATUS='1'", connection)
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productID
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable
                    adapter.Fill(table)
                    If table.Rows.Count > 0 Then
                        Dim quantity As Decimal = table(0)(0).ToString
                        Using cmd As New SqlCommand("UPDATE INVENTORY SET QUANTITY=@QUANTITY WHERE ID=@ID", connection)
                            With cmd.Parameters
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = productID
                                cmd.Parameters.Add("@QUANTITY", SqlDbType.Decimal).Value = quantity + quantity_box.Text
                            End With
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Product was successfully updated, Please Refresh to see the updated quantity", "Updating Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No Product forund, maybe the product is written off", "SEARCHING PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            Else
                MessageBox.Show("No Item is selected Please make sure you select a Product to update", "Updating Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Updating Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        panel_Stock.Visible = False
    End Sub

    Private Sub Refresh_button_Click(sender As Object, e As EventArgs) Handles Refresh_button.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using Command As New SqlCommand("SELECT ID,BARCODE,NAME,QUANTITY,SALE_QTY,MARGIN,PRICE FROM INVENTORY WHERE PRODUCT_STATUS='1'", connection)
                Dim adapter As New SqlDataAdapter(Command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    list_grid.DataSource = table
                    HeaderText()
                Else
                    MessageBox.Show("No  ACTIVE Products Found ", "SEARCHING PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error while retrieving data for Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Delete_button_Click(sender As Object, e As EventArgs) Handles Delete_button.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            If (list_grid.SelectedRows.Count = 1) Then
                productID = list_grid.CurrentRow.Cells(0).Value.ToString
                Using command As New SqlCommand("SELECT * FROM INVENTORY WHERE ID=@ID AND PRODUCT_STATUS='1'", connection)
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productID
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable
                    adapter.Fill(table)
                    If table.Rows.Count > 0 Then
                        Dim quantity As Decimal = table(0)(0).ToString
                        Using cmd As New SqlCommand("DELETE FROM INVENTORY  WHERE ID=@ID", connection)
                            With cmd.Parameters
                                cmd.Parameters.Add("@id", SqlDbType.Int).Value = productID

                            End With
                            cmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Product was successfully Deleted, Please Refresh to see the updated List", "Deleting Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Else
                MessageBox.Show("No Item is selected Please make sure you select a Product to Delete", "Deleting Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error while retrieving data for Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub search_button_Click(sender As Object, e As EventArgs) Handles search_button.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using Command As New SqlCommand("SELECT ID,BARCODE,NAME,QUANTITY,SALE_QTY,MARGIN,PRICE FROM INVENTORY WHERE BARCODE LIKE '%@VALUE%' OR NAME LIKE '%@VALUE%' AND PRODUCT_STATUS='1'", connection)
                Command.Parameters.Add("@VALUE", SqlDbType.VarChar).Value = SEARCH_BOX.Text
                Dim adapter As New SqlDataAdapter(Command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    list_grid.DataSource = table
                    HeaderText()
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error while retrieving data for Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Write_off_Click(sender As Object, e As EventArgs) Handles Write_off.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            If (list_grid.SelectedRows.Count = 1) Then
                productID = list_grid.CurrentRow.Cells(0).Value.ToString
                Using cmd As New SqlCommand("UPDATE INVENTORY SET PRODUCT_STATUS='0' WHERE ID=@ID", connection)
                    With cmd.Parameters
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = productID
                    End With
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product was successfully Written Off, Please Refresh to see the updated List", "Updating Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No Item is selected Please make sure you select a Product to update", "Updating Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error while retrieving data for Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Return_product_Click(sender As Object, e As EventArgs) Handles Return_product.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            If (list_grid.SelectedRows.Count = 1) Then
                productID = list_grid.CurrentRow.Cells(0).Value.ToString
                Using cmd As New SqlCommand("UPDATE INVENTORY SET PRODUCT_STATUS='1' WHERE ID=@ID", connection)
                    With cmd.Parameters
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = productID
                    End With
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Product was successfully Activated for use, Please Refresh to see the updated List", "Updating Stock", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No Item is selected Please make sure you select a Product to update", "Updating Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error while retrieving data for Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub quantity_box_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantity_box.KeyPress
        Try
            If ((Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57)) And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 Then
                MessageBox.Show("Only numbers are allowed", "Numbers only")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub list_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles list_grid.CellClick
        Try
            SEARCH_BOX.Text = list_grid.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
End Class