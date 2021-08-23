Imports System.Data.SqlClient

Public Class Permissions
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub Permissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'connection = myPermissions.getConnection()
            'connection.Open()
            'Using command As New SqlCommand("SELECT PERMISSION FROM USER_PERMISSIONS WHERE STATUS=@STATUS", connection)
            '    command.Parameters.Add("@STATUS", SqlDbType.Int).Value = 1
            '    Dim table As New DataTable
            '    Dim adapter As New SqlDataAdapter(command)
            '    adapter.Fill(table)
            '    If table.Rows.Count > 0 Then
            '        For Each control As CheckBox In table.Rows
            '            control.Checked = True
            '        Next
            '    End If
            'End Using
            'connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error occured while loading the user permissions", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using cmd As New SqlCommand("SELECT PERMISSION FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME", connection)
                cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = txtUsername.Text
                Dim reader As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                reader.Fill(table)
                If table.Rows.Count > 0 Then
                    MessageBox.Show("The user exist, Please try to update", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim transaction As SqlTransaction = connection.BeginTransaction
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, transaction_logs.Name, transaction_logs.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, cashup_balances.Name, cashup_balances.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, cancel_transactions.Name, cancel_transactions.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, view_sales.Name, view_sales.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, stock_reports.Name, stock_reports.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, profit_reports.Name, profit_reports.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, dayEnd_reports.Name, dayEnd_reports.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, scheduled_reports.Name, scheduled_reports.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, Give_permissions.Name, Give_permissions.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, register_users.Name, register_users.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, update_users.Name, update_users.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, add_inventory.Name, add_inventory.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, edit_inventory.Name, edit_inventory.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, return_sales.Name, return_sales.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, edit_settings.Name, edit_settings.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, activate_users.Name, activate_users.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, is_admin.Name, is_admin.CheckState, connection, transaction)
                    myPermissions.savePermissions(txtUsername.Text, employee_id.Text, backup_database.Name, backup_database.CheckState, connection, transaction)
                    transaction.Commit()
                    MessageBox.Show("User rights has been granted for this user", "Granting Permissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
            connection.Close()
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
            Using cmd As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME", connection)
                Dim reader As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                reader.Fill(table)
                If table.Rows.Count > 0 Then
                    Dim transaction As SqlTransaction = connection.BeginTransaction
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, transaction_logs.Name, transaction_logs.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, cashup_balances.Name, cashup_balances.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, cancel_transactions.Name, cancel_transactions.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, view_sales.Name, view_sales.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, stock_reports.Name, stock_reports.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, profit_reports.Name, profit_reports.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, dayEnd_reports.Name, dayEnd_reports.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, scheduled_reports.Name, scheduled_reports.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, Give_permissions.Name, Give_permissions.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, register_users.Name, register_users.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, update_users.Name, update_users.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, add_inventory.Name, add_inventory.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, edit_inventory.Name, edit_inventory.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, return_sales.Name, return_sales.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, edit_settings.Name, edit_settings.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, activate_users.Name, activate_users.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, is_admin.Name, is_admin.CheckState, connection, transaction)
                    myPermissions.updatePermissions(txtUsername.Text, employee_id.Text, backup_database.Name, backup_database.CheckState, connection, transaction)
                    transaction.Commit()
                    MessageBox.Show("User rights has been updated for this user", "Granting Permissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("There is  no user to update, Please save the user permissions first", "No User found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CmbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employee_id.SelectedIndexChanged
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT EMP_ID,USERNAME FROM USER_PERMISSIONS WHERE EMP_ID=@USERNAME", connection)
                command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = employee_id.Text
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    employee_id.Text = table(0)(0)
                    txtUsername.Text = table(0)(1)
                    Using cmd As New SqlCommand("SELECT PERMISSION FROM USE_PERMISSIONS WHERE EMP_ID=@USERNAME AND STATUS='1'", connection)
                        cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = employee_id.Text
                        adapter = New SqlDataAdapter(cmd)
                        table = New DataTable
                        adapter.Fill(table)
                        If table.Rows.Count > 0 Then
                            For Each item As CheckBox In table.Rows
                                item.Checked = True
                            Next
                        End If
                    End Using
                Else
                    MsgBox("NO EMPLOYEE FOUND")
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "The following Error Ocuured while loading the user permissions", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub search_button_Click(sender As Object, e As EventArgs) Handles search_button.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT EMP_ID,USERNAME FROM ACCOUNTS WHERE EMP_ID=@USERNAME", connection)
                command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = employee_id.Text
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    employee_id.Text = table(0)(0)
                    txtUsername.Text = table(0)(1)
                    Using cmd As New SqlCommand("SELECT PERMISSION FROM USER_PERMISSIONS WHERE EMP_ID=@USERNAME AND STATUS='1'", connection)
                        cmd.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = employee_id.Text
                        adapter = New SqlDataAdapter(cmd)
                        table = New DataTable
                        adapter.Fill(table)
                        If table.Rows.Count > 0 Then
                            For Each item As CheckBox In table.Rows
                                item.Checked = True
                            Next
                        End If
                    End Using
                Else
                    MsgBox("NO EMPLOYEE FOUND")
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "The following Error Ocuured while loading the user permissions", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class