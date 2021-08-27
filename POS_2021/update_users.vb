Imports System.Data.SqlClient

Public Class update_users
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim EMP_ID As String = ""

    Private username As String
    Public Property ActiveUser() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property
    Private Sub update_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
    Private Sub loadData()
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USERS", connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    ' resize header
                    user_grid.DataSource = table
                    HeaderTexts()
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error occured while loading your users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub HeaderTexts()
        Try
            user_grid.Columns(2).HeaderText = "NATIONAL ID"
            user_grid.Columns(7).HeaderText = "EMPLOYEE ID"

            user_grid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            user_grid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            user_grid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells

            user_grid.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            user_grid.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            user_grid.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells

            user_grid.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            user_grid.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As Exception

        End Try
    End Sub

    Private Sub user_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles user_grid.CellClick
        Try
            EMP_ID = user_grid.CurrentRow.Cells(7).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        'UPDATING USER
        Try
            If EMP_ID <> 1 Or EMP_ID <> "" Then
                user_registration.Employee = EMP_ID
                user_registration.ShowDialog()
            Else
                MessageBox.Show("You are trying to edit a super user whith Employee id of 1 or you hav not selected a user to edit, please make sure you select the right user", "Editing User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub delete_user_Click(sender As Object, e As EventArgs) Handles delete_user.Click
        Try
            If EMP_ID <> "1" Then
                If EMP_ID = "" Then
                    MessageBox.Show("Please select a user to delete", "Deleting usr", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    connection = myPermissions.getConnection
                    connection.Open()
                    Using command As New SqlCommand("DELETE FROM USERS WHERE EMP_ID=@EMP_ID", connection)
                        command.Parameters.Add("@EMP_ID", SqlDbType.VarChar).Value = EMP_ID
                        command.ExecuteNonQuery()
                        MessageBox.Show("The user was deleted successfully", "Deleting User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                    connection.Close()
                End If
            Else
                MessageBox.Show("You have no exclusive rights to delete the super user", "Deleting user", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An error occured while trying to delete the user", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub activate_user_Click(sender As Object, e As EventArgs) Handles activate_user.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION='activate_users' AND STATUS='1'", connection)
                command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    If EMP_ID <> "1" Or EMP_ID <> "" Then
                        Using cmd As New SqlCommand("UPDATE ACCOUNTS SET STATUS='1' WHERE EMP_ID=@EMP_ID", connection)
                            cmd.Parameters.Add("@EMP_ID", SqlDbType.VarChar).Value = EMP_ID
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("The user was activated successfully", "Activating user", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                    Else
                        MessageBox.Show("Please select a user to activate, you cannot activate or deactivate system superuser with Employee ID 1", "ACtivating user")
                    End If
                Else
                    MessageBox.Show("You don't have the permission to activate or deactivate users", "Activating user", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An error occured while activating user", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub deactivate_user_Click(sender As Object, e As EventArgs) Handles deactivate_user.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION='activate_users' AND STATUS='1'", connection)
                command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    If EMP_ID <> "1" Or EMP_ID <> "" Then
                        Using cmd As New SqlCommand("UPDATE ACCOUNTS SET STATUS='0' WHERE EMP_ID=@EMP_ID", connection)
                            cmd.Parameters.Add("@EMP_ID", SqlDbType.VarChar).Value = EMP_ID
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("The user was activated successfully", "Activating user", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                    Else
                        MessageBox.Show("Please select a user to activate, you cannot activate or deactivate system superuser with Employee ID 1", "ACtivating user")
                    End If
                Else
                    MessageBox.Show("You don't have the permission to activate or deactivate users", "Activating user", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An error occured while activating user", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class