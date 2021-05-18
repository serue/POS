Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class user_permissions

    Dim connection As New OleDbConnection("")

    ' variable declaration as object

    Dim AddAdmin As Byte = 0
    Dim ManageAdmin As Byte = 0
    Dim ManangeUsers As Byte = 0
    Dim ResetPasswords As Byte = 0
    Dim Userregistration As Byte = 0


    ' variable fortransactions

    Dim TransactionLog As Byte = 0
    Dim CashupBalances As Byte = 0
    Dim ViewCreditsales As Byte = 0
    Dim ViewSalesReturns As Byte = 0
    Dim DayEndSales As Byte = 0

    'Report Variable
    Dim OtherReports As Byte = 0
    Dim ProfitReports As Byte = 0

    ' Iventory Variables
    Dim AddInventory As Byte = 0
    Dim InventoryTransfer As Byte = 0
    Dim EditInventory As Byte = 0




    Private Sub lblClose_MouseEnter(sender As Object, e As EventArgs) Handles lblClose.MouseEnter
        lblClose.ForeColor = Color.Red
        lblClose.BackColor = Color.Beige
    End Sub

    Private Sub lblClose_MouseLeave(sender As Object, e As EventArgs) Handles lblClose.MouseLeave
        lblClose.BackColor = Color.FromArgb(99, 99, 99)
        lblClose.ForeColor = Color.White
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        If MessageBox.Show("Are you sure you want to Close", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        Else

        End If


    End Sub


    Private Sub SavePermissions()



        If txtUsername.Text <> "" Then

            Try
                connection.Open()
                Using cmd As New OleDbCommand("select * from user_permissions where username=@userId", connection)

                    cmd.Parameters.Add("@userId", OleDbType.VarChar).Value = txtUsername.Text
                    Dim table1 As New DataTable

                    Dim adapter1 As New OleDbDataAdapter(cmd)

                    adapter1.Fill(table1)

                    If table1.Rows.Count > 0 Then
                        MessageBox.Show("Username already exist, Please use SaveUpdate Button to update the permissions", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters

                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "AddAdminP"
                                .Add("@status", OleDbType.VarChar).Value = AddAdmin.ToString


                            End With

                            Command.ExecuteNonQuery()
                        End Using

                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "ManangeUsersP"
                                .Add("@status", OleDbType.VarChar).Value = ManangeUsers.ToString


                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "ManageAdminP"
                                .Add("@status", OleDbType.VarChar).Value = ManageAdmin.ToString


                            End With

                            Command.ExecuteNonQuery()
                        End Using

                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "ResetPasswordsP"
                                .Add("@status", OleDbType.VarChar).Value = ResetPasswords.ToString
                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "UserregistrationP"
                                .Add("@status", OleDbType.VarChar).Value = Userregistration.ToString
                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                ' variable fortransactions
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "TransactionLogP"
                                .Add("@status", OleDbType.VarChar).Value = TransactionLog.ToString
                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                ' variable fortransactions
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "CashupBalancesP"
                                .Add("@status", OleDbType.VarChar).Value = CashupBalances.ToString
                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                ' variable fortransactions
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "ViewCreditsalesP"
                                .Add("@status", OleDbType.VarChar).Value = ViewCreditsales.ToString
                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                ' variable fortransactions
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "ViewSalesReturnsP"
                                .Add("@status", OleDbType.VarChar).Value = ViewSalesReturns.ToString

                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "DayEndSalesP"
                                .Add("@status", OleDbType.VarChar).Value = DayEndSales.ToString

                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                'Report Variable

                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "OtherReportsP"
                                .Add("@status", OleDbType.VarChar).Value = OtherReports.ToString

                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "ProfitReportsP"
                                .Add("@status", OleDbType.VarChar).Value = ProfitReports.ToString

                            End With

                            Command.ExecuteNonQuery()
                        End Using



                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                ' Iventory Variables

                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "AddInventoryP"
                                .Add("@status", OleDbType.VarChar).Value = AddInventory.ToString

                            End With

                            Command.ExecuteNonQuery()
                        End Using



                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "InventoryTransferP"
                                .Add("@status", OleDbType.VarChar).Value = InventoryTransfer.ToString


                            End With

                            Command.ExecuteNonQuery()
                        End Using


                        ' tora apa
                        Using Command As New OleDbCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                            With Command.Parameters
                                .Add("@username", OleDbType.VarChar).Value = txtUsername.Text
                                .Add("@permission", OleDbType.VarChar).Value = "EditInventoryP"
                                .Add("@status", OleDbType.VarChar).Value = EditInventory.ToString

                            End With
                            Command.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Permissions for " & txtUsername.Text & "  were set successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    End If
                End Using


                connection.Close()
            Catch ex As Exception
                connection.Close()
                MessageBox.Show(ex.Message, "Operation Error")
            End Try

        Else
            MessageBox.Show("No user is selected, please select a user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If


    End Sub



    Private Sub UpdatePermissions()

        If txtUsername.Text <> "" Then

            Try
                connection.Open()

                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='AddAdminP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = AddAdmin.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With

                    Command.ExecuteNonQuery()
                End Using

                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='ManangeUsersP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = ManangeUsers.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using



                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='ManageAdminP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = ManageAdmin.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using




                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='ResetPasswordsP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = ResetPasswords.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using

                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='UserregistrationP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = Userregistration.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using

                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='TransactionLogP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = TransactionLog.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using


                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='CashupBalancesP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = CashupBalances.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using



                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='ViewCreditsalesP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = ViewCreditsales.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using



                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='ViewSalesReturnsP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = ViewSalesReturns.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using



                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='DayEndSalesP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = DayEndSales.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using



                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='OtherReportsP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = OtherReports.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using



                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='ProfitReportsP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = ProfitReports.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using



                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='AddInventoryP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = AddInventory.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using




                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='InventoryTransferP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = InventoryTransfer.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using




                Using Command As New OleDbCommand("update user_permissions set [status]=@status where permission='EditInventoryP' and username=@username", connection)

                    With Command.Parameters

                        .Add("@status", OleDbType.VarChar).Value = EditInventory.ToString
                        .Add("@username", OleDbType.VarChar).Value = txtUsername.Text


                    End With
                    Command.ExecuteNonQuery()
                End Using


                ' tora apa

                MessageBox.Show("Permissions for " & txtUsername.Text & "  were set successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

                connection.Close()
            Catch ex As Exception
                connection.Close()
                MessageBox.Show(ex.Message, "Operation Error")
            End Try


        Else
            MessageBox.Show("No user is selected, please select a user", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If


    End Sub



    Private Sub CheckPermissions()

        If txtUsername.Text <> "" Then

            Try
                connection.Open()

                Using command As New OleDbCommand("select permission from user_permissions where username=@name and status='1'", connection)
                    command.Parameters.Add("@name", OleDbType.VarChar).Value = txtUsername.Text
                    Dim table As New DataTable

                    Dim adapter As New OleDbDataAdapter(command)

                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        For Each row As DataRow In table.Rows

                            If row(0).ToString = "AddAdminP" Then
                                CheckAddAdmin.Checked = True
                            End If

                            If row(0).ToString = " ManageAdminP" Then
                                CheckManageAdmin.Checked = True
                            End If
                            If row(0).ToString = "ManangeUsersP" Then
                                CheckManageUsers.Checked = True
                            End If

                            If row(0).ToString = "ManangeUsersP" Then
                                CheckManageUsers.Checked = True
                            End If

                            If row(0).ToString = "ResetPasswordsP" Then
                                CheckResetPassword.Checked = True
                            End If

                            If row(0).ToString = "UserregistrationP" Then
                                CheckUserRegistration.Checked = True
                            End If

                            If row(0).ToString = "TransactionLogP" Then
                                CheckTransactionLog.Checked = True
                            End If


                            If row(0).ToString = "CashupBalancesP" Then
                                CheckCashupBalances.Checked = True
                            End If

                            If row(0).ToString = "ViewCreditsalesP" Then
                                CheckViewCreditSales.Checked = True
                            End If

                            If row(0).ToString = "ViewSalesReturnsP" Then
                                CheckViewSalesReutrns.Checked = True
                            End If

                            If row(0).ToString = "DayEndSalesP" Then
                                CheckDayEndSales.Checked = True
                            End If


                            If row(0).ToString = "OtherReportsP" Then
                                CheckAllReports.Checked = True
                            End If

                            If row(0).ToString = "ProfitReportsP" Then
                                CheckProfit.Checked = True
                            End If

                            If row(0).ToString = "AddInventoryP" Then
                                CheckAddIventory.Checked = True
                            End If

                            If row(0).ToString = "EditInventoryP" Then
                                CheckEditIventory.Checked = True
                            End If


                            If row(0).ToString = "InventoryTransferP" Then
                                CheckInventoryTransfer.Checked = True
                            End If



                        Next
                    End If
                End Using

                connection.Close()
            Catch ex As Exception
                connection.Close()
                MessageBox.Show(ex.Message, "operation Error")
            End Try

        End If

    End Sub

    Private Sub CmbUsers_Click(sender As Object, e As EventArgs) Handles CmbUsers.Click


        Try
            connection.Open()


            CmbUsers.Items.Clear()

            If CmbUuserType.Text = "ADMIN" Then

                Using command As New OleDbCommand("select full_name from admin", connection)

                    Dim table As New DataTable
                    Dim adapter As New OleDbDataAdapter(command)
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        For Each row As DataRow In table.Rows

                            CmbUsers.Items.Add(row(0))
                        Next

                    End If
                End Using
            End If

            If CmbUuserType.Text = "USER" Then

                Using command As New OleDbCommand("select full_name from users", connection)

                    Dim table As New DataTable
                    Dim adapter As New OleDbDataAdapter(command)
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        For Each row As DataRow In table.Rows

                            CmbUsers.Items.Add(row(0))
                        Next

                    End If
                End Using
            End If


            connection.Close()

        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Operation Error")
        End Try
    End Sub

    Private Sub CmbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUsers.SelectedIndexChanged

        Try
            connection.Open()

            Dim name As String = CmbUsers.Text
            If CmbUuserType.Text = "ADMIN" Then
                Using Command As New OleDbCommand("select id_no,address,phone  from admin where full_name=@name", connection)
                    Command.Parameters.Add("@name", OleDbType.VarChar).Value = name
                    Dim table As New DataTable
                    Dim adapter As New OleDbDataAdapter(Command)

                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then

                        txtNationalID.Text = table(0)(0)
                        txtAddress.Text = table(0)(1)
                        txtPhone.Text = table(0)(2)
                    End If

                End Using


                Using Command As New OleDbCommand("select username from admin_accounts where full_name=@name", connection)
                    Command.Parameters.Add("@name", OleDbType.VarChar).Value = name
                    Dim table As New DataTable
                    Dim adapter As New OleDbDataAdapter(Command)

                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then

                        txtUsername.Text = table(0)(0)

                    End If

                End Using
            End If


            If CmbUuserType.Text = "USER" Then
                Using Command As New OleDbCommand("select id_no,address,phone  from users where full_name=@name", connection)
                    Command.Parameters.Add("@name", OleDbType.VarChar).Value = CmbUsers.SelectedIndex.ToString
                    Dim table As New DataTable
                    Dim adapter As New OleDbDataAdapter(Command)

                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        txtNationalID.Text = table(0)(0)
                        txtAddress.Text = table(0)(1)
                        txtPhone.Text = table(0)(2)
                    End If

                End Using



                Using Command As New OleDbCommand("select username  from users where full_name=@name", connection)
                    Command.Parameters.Add("@name", OleDbType.VarChar).Value = CmbUsers.SelectedIndex.ToString
                    Dim table As New DataTable
                    Dim adapter As New OleDbDataAdapter(Command)

                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        txtUsername.Text = table(0)(0)

                    End If

                End Using
            End If
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Operation Error")
        End Try


        CheckPermissions()

    End Sub

    Private Sub CheckTransactionLog_CheckedChanged(sender As Object, e As EventArgs) Handles CheckTransactionLog.CheckedChanged

        If CheckTransactionLog.Checked = True Then
            TransactionLog = 1
        Else
            TransactionLog = 0
        End If


    End Sub

    Private Sub CheckCashupBalances_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCashupBalances.CheckedChanged

        If CheckCashupBalances.Checked = True Then
            CashupBalances = 1
        Else
            CashupBalances = 0
        End If

    End Sub

    Private Sub CheckViewCreditSales_CheckedChanged(sender As Object, e As EventArgs) Handles CheckViewCreditSales.CheckedChanged

        If CheckViewCreditSales.Checked = True Then
            ViewCreditsales = 1
        Else
            ViewCreditsales = 0
        End If


    End Sub

    Private Sub CheckViewSalesReutrns_CheckedChanged(sender As Object, e As EventArgs) Handles CheckViewSalesReutrns.CheckedChanged
        If CheckViewSalesReutrns.Checked = True Then
            ViewSalesReturns = 1
        Else
            ViewSalesReturns = 0
        End If

    End Sub

    Private Sub CheckDayEndSales_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDayEndSales.CheckedChanged

        If CheckDayEndSales.Checked = True Then
            DayEndSales = 1
        Else
            DayEndSales = 0
        End If


    End Sub

    Private Sub CheckAddIventory_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAddIventory.CheckedChanged


        If CheckAddIventory.Checked = True Then
            AddInventory = 1
        Else
            AddInventory = 0

        End If


    End Sub

    Private Sub CheckEditIventory_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEditIventory.CheckedChanged


        If CheckEditIventory.Checked = True Then
            EditInventory = 1
        Else
            EditInventory = 0

        End If


    End Sub

    Private Sub CheckInventoryTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles CheckInventoryTransfer.CheckedChanged

        If CheckInventoryTransfer.Checked = True Then
            InventoryTransfer = 1
        Else
            InventoryTransfer = 0

        End If


    End Sub

    Private Sub CheckAddAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAddAdmin.CheckedChanged

        If CheckAddAdmin.Checked = True Then
            AddAdmin = 1
        Else
            AddAdmin = 0

        End If

    End Sub

    Private Sub CheckManageAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles CheckManageAdmin.CheckedChanged

        If CheckManageAdmin.Checked = True Then
            ManageAdmin = 1
        Else
            ManageAdmin = 0

        End If


    End Sub

    Private Sub CheckManageUsers_CheckedChanged(sender As Object, e As EventArgs) Handles CheckManageUsers.CheckedChanged

        If CheckManageUsers.Checked = True Then
            ManangeUsers = 1
        Else
            ManangeUsers = 0

        End If


    End Sub

    Private Sub CheckResetPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckResetPassword.CheckedChanged

        If CheckResetPassword.Checked = True Then
            ResetPasswords = 1
        Else
            ResetPasswords = 0

        End If



    End Sub

    Private Sub CheckUserRegistration_CheckedChanged(sender As Object, e As EventArgs) Handles CheckUserRegistration.CheckedChanged


        If CheckUserRegistration.Checked = True Then
            Userregistration = 1
        Else
            Userregistration = 0

        End If


    End Sub

    Private Sub CheckAllReports_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAllReports.CheckedChanged


        If CheckAllReports.Checked = True Then
            OtherReports = 1
        Else
            OtherReports = 0

        End If


    End Sub

    Private Sub CheckProfit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckProfit.CheckedChanged

        If CheckProfit.Checked = True Then
            ProfitReports = 1
        Else
            ProfitReports = 0

        End If



    End Sub

    Private Sub user_permissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckPermissions()


    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SavePermissions()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        UpdatePermissions()
    End Sub

    Private Sub CmbUuserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUuserType.SelectedIndexChanged

    End Sub
End Class