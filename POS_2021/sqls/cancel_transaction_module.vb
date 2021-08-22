Imports System.Data.SqlClient
Module cancel_transaction_module
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions

    Public Sub Cancel_Transaction(trans As String)
        Try
            'variable for sales
            Dim s_profit As Decimal

            'variable for inventory
            Dim _cost, _price As Decimal

            connection = myPermissions.getConnection
            connection.Open()

            Dim transaction As SqlTransaction = connection.BeginTransaction

            Using command As New SqlCommand("SELECT BARCODE,QUANTITY,AMOUNT FROM TRANS_DETAILS WHERE TRANSACTION_ID=@ID", connection, transaction)
                command.Parameters.Add("@ID", SqlDbType.VarChar).Value = trans
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)     'these are the results for transactio Details table
                If table.Rows.Count > 0 Then
                    For Each row As DataRow In table.Rows
                        'GETTING THE PRICE TO CALCULATE PROFIT
                        Using comm As New SqlCommand("SELECT COST,PRICE FROM INVENTORY WHERE BARCODE=@BARCODE", connection, transaction)
                            comm.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = row(0)
                            Dim ad As New SqlDataAdapter(comm)
                            Dim ta As New DataTable
                            ad.Fill(ta)
                            _cost = ta(0)(0)
                            _price = ta(0)(1)
                            s_profit = Math.Round((_price - _cost) * row(2), 2)
                            'UPDATE SALES
                            Using cmd As New SqlCommand("UPDATE SALES SET QUANTITY=QUANTITY-@QUANTITY,AMOUNT=AMOUNT-@AMOUNT,PROFIT=PROFIT-@PROFIT WHERE BARCODE=@BARCODE", connection, transaction)
                                With cmd.Parameters
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row(0)
                                    .Add("@QUANTITY", SqlDbType.Decimal).Value = row(1)
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = row(2)
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = s_profit
                                End With
                                cmd.ExecuteNonQuery()
                            End Using
                            Using cmd As New SqlCommand("UPDATE SUMMARY_SALES SET QUANTITY=QUANTITY-@QUANTITY,AMOUNT=AMOUNT-@AMOUNT,PROFIT=PROFIT-@PROFIT WHERE BARCODE=@BARCODE", connection, transaction)
                                With cmd.Parameters
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row(0)
                                    .Add("@QUANTITY", SqlDbType.Decimal).Value = row(1)
                                    .Add("@AMOUNT", SqlDbType.Decimal).Value = row(2)
                                    .Add("@PROFIT", SqlDbType.Decimal).Value = s_profit
                                End With
                                cmd.ExecuteNonQuery()
                            End Using
                            Using cmd As New SqlCommand("UPDATE INVENTORY SET QUANTITY=QUANTITY+@QUANTITY WHERE BARCODE=@BARCODE", connection, transaction)
                                With cmd.Parameters
                                    .Add("@BARCODE", SqlDbType.VarChar).Value = row(0)
                                    .Add("@QUANTITY", SqlDbType.Decimal).Value = row(1)
                                End With
                                cmd.ExecuteNonQuery()
                            End Using
                            Using cmd As New SqlCommand("UPDATE TRANSACTIONS SET STATUS='CANCELLED' WHERE TRANSACTION_ID=@TRANSACTION", connection, transaction)
                                cmd.Parameters.Add("@TRANSACTION", SqlDbType.VarChar).Value = trans
                                cmd.ExecuteNonQuery()
                            End Using
                        End Using
                        transaction.Commit()
                    Next
                End If
            End Using
            MessageBox.Show("Transaction was Cancelled succesfully", "Cancelling Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error Occured while Cancelling transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
