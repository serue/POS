Imports System.Data.SqlClient

Public Class categories
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
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

                End With

                command.ExecuteNonQuery()
                MessageBox.Show("New Category was inserted successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)

            connection.Close()
        End Try
    End Sub
    Private Sub clear()

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
End Class