Imports System.Data.SqlClient

Public Class Add_inventory
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions


    'getters and setters

    Private productID As String
    Public Property NewProperty() As String
        Get
            Return productID
        End Get
        Set(ByVal value As String)
            productID = value
        End Set
    End Property

    Private Sub loadCategories()

        Using command As New SqlCommand("SELECT CATEGORY FROM CATEGORY ", connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
            category_combo.Items.Clear()
            If table.Rows.Count > 0 Then
                    For Each cat As DataRow In table.Rows
                    category_combo.Items.Add(cat(0).ToString)
                Next
                End If
            End Using
            connection.Close()

    End Sub
    Private Sub LoadData()
        Using Command As New SqlCommand("SELECT ID,BARCODE,NAME,QUANTITY,SALE_QTY,MARGIN,PRICE FROM INVENTORY WHERE PRODUCT_STATUS='1'", connection)
            Dim adapter As New SqlDataAdapter(Command)
            Dim table As New DataTable
            adapter.Fill(table)
            list_grid.DataSource = table
            If table.Rows.Count > 0 Then


            Else
                MessageBox.Show("No Product found ACTIVE Products", "SEARCHING PRODUCTS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Using

    End Sub
    Private Sub Add_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            LoadData()
            loadCategories()
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error while retrieving data for Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cost_textbox_LostFocus(sender As Object, e As EventArgs) Handles cost_textbox.LostFocus

        If cost_textbox.Text <> "" Then
            Try
                Dim number As Decimal = cost_textbox.Text
                cost_textbox.Text = number.ToString(" ###,###,###.00")
            Catch ex As Exception
                MessageBox.Show("Cost Price is empty or in wrong format", "Cost Price", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub margin_textbox_LostFocus(sender As Object, e As EventArgs) Handles margin_textbox.LostFocus
        If margin_textbox.Text <> "" Then
            Try
                Dim cost As Decimal = cost_textbox.Text
                Dim number As Decimal = (margin_textbox.Text / 100)
                margin_textbox.Text = number
                selling_textbox.Text = (number * cost) + cost

            Catch ex As Exception
                MessageBox.Show("Margin is empty or in wrong format", "Margin calculation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If

    End Sub

    Private Sub quantity_textbox_LostFocus(sender As Object, e As EventArgs) Handles quantity_textbox.LostFocus
        If quantity_textbox.Text <> "" Then
            Try
                Dim number As Decimal = quantity_textbox.Text
                quantity_textbox.Text = number.ToString(" ###,###,###.00")
            Catch ex As Exception
                MessageBox.Show("Quantity is empty or in wrong format", "Quantity ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub re_order_textbox_LostFocus(sender As Object, e As EventArgs) Handles re_order_textbox.LostFocus
        If re_order_textbox.Text <> "" Then
            Try
                Dim number As Decimal = re_order_textbox.Text
                re_order_textbox.Text = number.ToString(" ###,###,###.00")
            Catch ex As Exception
                MessageBox.Show("Re Order Point is empty or in wrong format", "Re Order Point ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub sale_qty_textbox_LostFocus(sender As Object, e As EventArgs) Handles sale_qty_textbox.LostFocus
        If sale_qty_textbox.Text <> "" Then
            Try
                Dim number As Decimal = sale_qty_textbox.Text
                sale_qty_textbox.Text = number.ToString(" ###,###,###.00")
            Catch ex As Exception
                MessageBox.Show("Standard Sale Quantity is empty or in wrong format", "Sale Quantity ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub selling_textbox_LostFocus(sender As Object, e As EventArgs) Handles selling_textbox.LostFocus
        If selling_textbox.Text <> "" Then
            Try
                Dim number As Decimal = selling_textbox.Text
                selling_textbox.Text = number.ToString(" ###,###,###.00")
            Catch ex As Exception
                MessageBox.Show("Selling Price is empty or in wrong format", "Selling Price ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub save_item_Click(sender As Object, e As EventArgs) Handles save_item.Click
        Try
            connection.Open()
            Using command As New SqlCommand()
                command.Connection = connection

                command.CommandText = "INSERT_INVENTORY"
                command.CommandType = CommandType.StoredProcedure
                With command.Parameters
                    .Add("@DATE", SqlDbType.Date).Value = Now
                    .Add("@CATEGORY", SqlDbType.VarChar).Value = category_combo.Text
                    .Add("@BARCODE", SqlDbType.VarChar).Value = barcode_textbox.Text
                    .Add("@NAME", SqlDbType.VarChar).Value = name_textbox.Text
                    .Add("@QUANTITY", SqlDbType.Decimal).Value = quantity_textbox.Text
                    .Add("@RE_ORDER", SqlDbType.Decimal).Value = re_order_textbox.Text
                    .Add("@SALE_QTY", SqlDbType.Decimal).Value = sale_qty_textbox.Text
                    .Add("@COST", SqlDbType.Decimal).Value = cost_textbox.Text
                    .Add("@PRICE", SqlDbType.Decimal).Value = selling_textbox.Text
                    .Add("@MARGIN", SqlDbType.Decimal).Value = margin_textbox.Text
                    .Add("@VENDOR_CODE", SqlDbType.VarChar).Value = vendorCode_textbox.Text
                    .Add("@PRODUCT_STATUS", SqlDbType.Int).Value = 1
                    .Add("@SKU", SqlDbType.VarChar).Value = sku_textbox.Text

                End With
                command.ExecuteNonQuery()
            End Using
            MessageBox.Show("Connection opened !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            connection.Close()

        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub edit_price_Click(sender As Object, e As EventArgs) Handles edit_price.Click
        If barcode_textbox.Text <> "" Or barcode_textbox.Text IsNot Nothing Then

            Try
                connection.Open()
                Using command As New SqlCommand()
                    command.Connection = connection

                    command.CommandText = "UPDATE_INVENTORY_PRICE"
                    command.CommandType = CommandType.StoredProcedure
                    With command.Parameters

                        .Add("@BARCODE", SqlDbType.VarChar).Value = barcode_textbox.Text

                        .Add("@QUANTITY", SqlDbType.Decimal).Value = quantity_textbox.Text

                        .Add("@PRICE", SqlDbType.Decimal).Value = selling_textbox.Text
                        .Add("@MARGIN", SqlDbType.Decimal).Value = margin_textbox.Text


                    End With
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Connection opened !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("You cannot update a product without an ID, Please Go to list and select a product to edit", "Error On Editing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub edit_details_Click(sender As Object, e As EventArgs) Handles edit_details.Click
        If PRODUCT_ID_LABEL.Text <> "" Or PRODUCT_ID_LABEL.Text IsNot Nothing Then

            Try
                connection.Open()
                Using command As New SqlCommand()
                    command.Connection = connection

                    command.CommandText = "UPDATE_INVENTORY"
                    command.CommandType = CommandType.StoredProcedure
                    With command.Parameters
                        .Add("@ID", SqlDbType.Int).Value = PRODUCT_ID_LABEL.Text
                        .Add("@CATEGORY", SqlDbType.VarChar).Value = category_combo.Text
                        .Add("@BARCODE", SqlDbType.VarChar).Value = barcode_textbox.Text
                        .Add("@NAME", SqlDbType.VarChar).Value = name_textbox.Text
                        .Add("@QUANTITY", SqlDbType.Decimal).Value = quantity_textbox.Text
                        .Add("@RE_ORDER", SqlDbType.Decimal).Value = re_order_textbox.Text
                        .Add("@SALE_QTY", SqlDbType.Decimal).Value = sale_qty_textbox.Text
                        .Add("@COST", SqlDbType.Decimal).Value = cost_textbox.Text
                        .Add("@PRICE", SqlDbType.Decimal).Value = selling_textbox.Text
                        .Add("@MARGIN", SqlDbType.Decimal).Value = margin_textbox.Text
                        .Add("@VENDOR_CODE", SqlDbType.VarChar).Value = vendorCode_textbox.Text
                        .Add("@SKU", SqlDbType.VarChar).Value = sku_textbox.Text

                    End With
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Connection opened !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("You cannot update a product without an ID, Please Go to list and select a product to edit", "Error On Editing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click
        CLEAR()
    End Sub
    Private Sub CLEAR()
        PRODUCT_ID_LABEL.Text = ""
        category_combo.Text = ""
        barcode_textbox.Clear()
        name_textbox.Text = ""
        quantity_textbox.Clear()
        re_order_textbox.Clear()
        sale_qty_textbox.Clear()
        cost_textbox.Clear()
        selling_textbox.Clear()
        margin_textbox.Clear()
        vendorCode_textbox.Clear()
        sku_textbox.Clear()
        category_combo.Focus()
        End Sub

    Private Sub quantity_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quantity_textbox.KeyPress
        If (Asc(e.KeyChar) < 48 And Asc(e.KeyChar) > 57) Then
            e.Handled = True
            MsgBox("numbers only")
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub margin_textbox_Leave(sender As Object, e As EventArgs) Handles margin_textbox.Leave
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class