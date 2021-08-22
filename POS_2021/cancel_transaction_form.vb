Imports System.Data.SqlClient

Public Class cancel_transaction_form
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions

    Private Sub Accept_button_Click(sender As Object, e As EventArgs) Handles Accept_button.Click
        If transactio_id.Text = "" Then
            MessageBox.Show("Please Enter Receipt Number  for you to cance the trnsaction", "Cancel Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim isAvailable As Boolean = False
            Try
                connection = myPermissions.getConnection
                connection.Open()
                Using command As New SqlCommand("SELECT * FROM TRANSACTIONS WHERE TRANSACTION_ID=@TRANSACTION", connection)
                    command.Parameters.Add("@TRANSACTION", SqlDbType.VarChar).Value = transactio_id.Text
                    Dim reader As SqlDataReader = command.ExecuteReader
                    If reader.HasRows Then
                        isAvailable = True
                    Else
                        MessageBox.Show("There is no transactio with this receipt number, please  check the receipt number and proceed,", "Invalid Receipt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
                connection.Close()
                If isAvailable = True Then
                    Cancel_Transaction(transactio_id.Text)
                End If
                isAvailable = False
            Catch ex As Exception
                connection.Close()
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cancel_transaction_form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you want to abort cancelling", "Abort Transaction cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        Else
            e.Cancel = True
        End If
    End Sub
End Class