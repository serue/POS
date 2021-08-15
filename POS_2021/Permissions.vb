Imports System.Data.SqlClient

Public Class Permissions
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub Permissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE STATUS=@STATUS", connection)
                command.Parameters.Add("@STATUS", SqlDbType.Int).Value = 1
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    For Each control As CheckBox In table.Rows
                        control.Checked = True
                    Next
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error occured while loading the user permissions", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction
            myPermissions.savePermissions(txtUsername.Text, transaction_log.Name, transaction_log.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, cashup_balances.Name, cashup_balances.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, cancel_transactions.Name, cancel_transactions.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, view_sales.Name, view_sales.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, stock_reports.Name, stock_reports.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, profit_reports.Name, profit_reports.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, dayEnd_reports.Name, dayEnd_reports.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, scheduled_reports.Name, scheduled_reports.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, Give_permissions.Name, Give_permissions.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, register_users.Name, register_users.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, manage_users.Name, manage_users.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, add_inventory.Name, add_inventory.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, edit_inventory.Name, edit_inventory.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, return_sales.Name, return_sales.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, reset_passwords.Name, reset_passwords.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, activate_user.Name, activate_user.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, is_admin.Name, is_admin.CheckState, connection, transaction)
            myPermissions.savePermissions(txtUsername.Text, backup_database.Name, backup_database.CheckState, connection, transaction)
            transaction.Commit()
            connection.Close()
            MessageBox.Show("User rights has been granted for this user", "Granting Permissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message)
            MsgBox(ex.StackTrace)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction
            myPermissions.updatePermissions(txtUsername.Text, transaction_log.Name, transaction_log.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, cashup_balances.Name, cashup_balances.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, cancel_transactions.Name, cancel_transactions.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, view_sales.Name, view_sales.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, stock_reports.Name, stock_reports.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, profit_reports.Name, profit_reports.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, dayEnd_reports.Name, dayEnd_reports.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, scheduled_reports.Name, scheduled_reports.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, Give_permissions.Name, Give_permissions.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, register_users.Name, register_users.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, manage_users.Name, manage_users.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, add_inventory.Name, add_inventory.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, edit_inventory.Name, edit_inventory.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, return_sales.Name, return_sales.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, reset_passwords.Name, reset_passwords.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, activate_user.Name, activate_user.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, is_admin.Name, is_admin.CheckState, connection, transaction)
            myPermissions.updatePermissions(txtUsername.Text, backup_database.Name, backup_database.CheckState, connection, transaction)
            transaction.Commit()
            connection.Close()
            MessageBox.Show("User rights has been updated for this user", "Granting Permissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class