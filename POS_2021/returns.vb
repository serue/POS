Imports System.Data.SqlClient
Public Class returns
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub transaction_button_Click(sender As Object, e As EventArgs) Handles transaction_button.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Dim transaction As SqlTransaction = connection.BeginTransaction
            ''Dim QUANTITY, TOTAL, TAX As Decimal
            ''Dim _QTY, _AMOUNT, _PRICE As Decimal
            ''Using command As New SqlCommand("SELECT PRICE,QUANTITY FROM INVENTORY WHERE BARCODE=@BARCODE", connection, transaction)
            ''    command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = barcode_textbox.Text
            ''    Using adapter As New SqlDataAdapter(command)
            ''        Using table As New DataTable
            ''            adapter.Fill(table)
            ''            If table.Rows.Count > 0 Then
            ''                _PRICE = table(0)(0)
            ''                QUANTITY = table(0)(1)
            ''            End If
            ''        End Using
            ''    End Using
            ''End Using
            ''Using command As New SqlCommand("SELECT AMOUNT,QTY FROM TRANS_DETAILS WHERE BARCODE=@BARCODE", connection, transaction)
            ''    command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = barcode_textbox.Text
            ''    Dim ADAPTER As New SqlDataAdapter(command)
            ''    Dim table As New DataTable
            ''    ADAPTER.Fill(table)
            ''    If table.Rows.Count > 0 Then    'check if transaction has product
            ''        _AMOUNT = Math.Round(table(0)(0) - (_PRICE * quantity_textbox.Text), 2)
            ''        _QTY = table(0)(1)
            ''        _QTY = Math.Round(_QTY - quantity_textbox.Text, 2)
            ''        If _QTY > 0 Then    'check if the quantity is worthy update or delete
            ''            Using cmd As New SqlCommand("UPDATE TRANS_DETAILS SET QUANTITY=@QUANTITY, AMOUNT=@AMOUNT WHERE BARCODE=@BARCODE", connection, transaction)
            ''                With cmd.Parameters
            ''                    .Add("@QUANTITY", SqlDbType.Decimal).Value = _QTY
            ''                    .Add("@AMOUNT", SqlDbType.Decimal).Value = _AMOUNT
            ''                    .Add("@BARCODE", SqlDbType.VarChar).Value = barcode_textbox.Text
            ''                End With
            ''                cmd.ExecuteNonQuery()
            ''            End Using
            ''        Else    ' if the amount is worthy delete
            ''            Using cmd As New SqlCommand("DELETE FROM TRANS_DETAILS WHERE BARCODE=@BARCODE", connection, transaction)
            ''                cmd.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = barcode_textbox.Text
            ''                cmd.ExecuteNonQuery()
            ''            End Using
            ''        End If
            ''    End If
            ''End Using
            Using command As New SqlCommand("INSERT INTO P_RETURNS(BARCODE,QUANTITY,AMOUNT,TRSANSACTION_ID,DATE,REASON,CUSTOMER,CONTACT) VALUES(@BARCODE,@QUANTITY,@AMOUNT,@TRANS,@DATE,@REASON,@CUSTOMER,@CONTACT)", connection, transaction)
                With command.Parameters
                    .Add("@BARCODE", SqlDbType.VarChar).Value = barcode_textbox.Text
                    .Add("@QUANTITY", SqlDbType.Decimal).Value = quantity_textbox.Text
                    .Add("@AMOUNT", SqlDbType.Decimal).Value = AMOUNT_TEXTBOX.Text
                    .Add("@DATE", SqlDbType.DateTime).Value = Now
                    .Add("@TRANS", SqlDbType.VarChar).Value = transaction_id.Text
                    .Add("@REASON", SqlDbType.VarChar).Value = Reason_for_return.Text
                    .Add("@CUSTOMER", SqlDbType.VarChar).Value = customer_textbox.Text
                    .Add("@CONTACT", SqlDbType.VarChar).Value = contact_textbox.Text
                End With
                command.ExecuteNonQuery()
            End Using
            Using command As New SqlCommand("UPDATE INVENTORY SET QUANTITY=QUANTITY + @QUANTITY WHERE BARCODE=@BARCODE", connection, transaction)
                command.Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = barcode_textbox.Text
                command.Parameters.Add("@QUANTITY", SqlDbType.Decimal).Value = quantity_textbox.Text
                command.ExecuteNonQuery()
            End Using
            transaction.Commit()
            MessageBox.Show("Product was returned sucessfully", "Returning a product", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click

    End Sub

    Private Sub returns_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you want to cancel sales returns", "cancel Returns", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub
End Class