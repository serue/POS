Imports System.Data.SqlClient

Public Class categories
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim myId As Integer = 0
    Private Sub save_item_Click(sender As Object, e As EventArgs) Handles save_item.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()

            Using command As New SqlCommand()
                command.Connection = connection
                command.CommandText = "INSERT_CATEGORY"
                command.CommandType = CommandType.StoredProcedure
                With command.Parameters

                    .Add("@CATEGORY", SqlDbType.VarChar).Value = cmb_category.Text
                    .Add("@NOTES ", SqlDbType.VarChar).Value = notes_textbox.Text
                    .Add("@SUB_CATEGORY1", SqlDbType.VarChar).Value = cmb_subCategory1.Text
                    .Add("@SUB_CATEGORY2", SqlDbType.VarChar).Value = cmb_subcategory2.Text
                    .Add("@SUB_CATEGORY3", SqlDbType.VarChar).Value = cmb_SubCategory3.Text

                End With

                command.ExecuteNonQuery()
                MessageBox.Show("New Category was inserted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Using
            connection.Close()
            clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An error occured while saving the data into the databse", MessageBoxButtons.OK, MessageBoxIcon.Error)

            connection.Close()
        End Try
    End Sub
    Private Sub clear()
        cmb_category.Text = ""
        notes_textbox.Clear()
        cmb_category.Focus()
    End Sub
    Private Sub loadCategories()
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using command As New SqlCommand("SELECT CATEGORY FROM CATEGORY ", connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                cmb_category.Items.Clear()
                If table.Rows.Count > 0 Then
                    For Each cat As DataRow In table.Rows
                        cmb_category.Items.Add(cat(0).ToString)
                    Next
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error loading categories", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCategories()
    End Sub

    Private Sub edit_details_Click(sender As Object, e As EventArgs) Handles edit_details.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            If myId > 0 Then
                Using command As New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "UPDATE_CATEGORY"
                    command.CommandType = CommandType.StoredProcedure
                    With command.Parameters
                        .Add("@ID", SqlDbType.Int).Value = myId
                        .Add("@CATEGORY", SqlDbType.VarChar).Value = cmb_category.Text
                        .Add("@NOTES ", SqlDbType.VarChar).Value = notes_textbox.Text
                        .Add("@SUB_CATEGORY1", SqlDbType.VarChar).Value = cmb_subCategory1.Text
                        .Add("@SUB_CATEGORY2", SqlDbType.VarChar).Value = cmb_subcategory2.Text
                        .Add("@SUB_CATEGORY3", SqlDbType.VarChar).Value = cmb_SubCategory3.Text


                    End With

                    command.ExecuteNonQuery()
                    MessageBox.Show("New Category was inserted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            End If
            connection.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub findID()
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using cmd As New SqlCommand("SELECT ID FROM CATEGORY WHERE CATEGORY=@CATEGORY", connection)
                cmd.Parameters.Add("@CATEGORY", SqlDbType.VarChar).Value = cmb_category.Text
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    myId = table(0)(0)
                Else
                    myId = 0
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "The following error occured while getting the category ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmb_category_Click(sender As Object, e As EventArgs)
        loadCategories()
    End Sub

    Private Sub cmb_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_category.Click
        findID()
    End Sub

    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click
        clear()
    End Sub
End Class