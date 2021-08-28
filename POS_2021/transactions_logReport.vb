Imports System.Data.SqlClient

Public Class transactions_logReport
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim isFilter As Boolean = False
    Private Sub transactions_logReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Delegate Sub LoadRpt(ByVal [crv] As Object)
    Delegate Sub SetPanelVisible(ByVal [panel] As Panel)

    Private Sub FilterLoading(ByVal [crv] As Object)                     'use the same delegate LoadRpt 
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()
            Dim CoTable As New DataTable
            If cancelled_trasactions.Checked Then
                Using command As New SqlCommand("SELECT * FROM TRANSACTIONS WHERE TRANS_DATE BETWEEN @TRANS_DATE AND @TO AND CASHIER=@USERNAME AND STATUS='CANCELLED'", connection)
                    command.Parameters.Add("@TRANS_DATE", SqlDbType.VarChar).Value = from_date.Text
                    command.Parameters.Add("@TO", SqlDbType.VarChar).Value = to_date.Text
                    command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = txt_username.Text
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(CoTable)
                End Using
            Else
                Using command As New SqlCommand("SELECT * FROM TRANSACTIONS WHERE TRANS_DATE BETWEEN @TRANS_DATE AND @TO AND CASHIER=@USERNAME AND STATUS='COMPLETED'", connection)
                    command.Parameters.Add("@TRANS_DATE", SqlDbType.VarChar).Value = from_date.Text
                    command.Parameters.Add("@TO", SqlDbType.VarChar).Value = to_date.Text
                    command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = txt_username.Text
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(CoTable)
                End Using
            End If

            Dim rep As New transactio_logRpt
            rep.Database.Tables("TRANSACTIONS").SetDataSource(CoTable)


            If [crv].InvokeRequired Then
                Dim myDelegate As New LoadRpt(AddressOf FilterLoading)
                Me.Invoke(myDelegate, New Object() {crv})

            Else
                [crv].ReportSource = rep
            End If
            connection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Operation Error")
            MsgBox(ex.StackTrace)
            connection.Close()
        End Try
    End Sub
    Private Sub ReportLoading(ByVal [crv] As Object)                     'use the same delegate LoadRpt 
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()
            Dim CoTable As New DataTable
            Dim date2 As Date = Now.ToShortDateString & " 00:00:01.000"
            Using command As New SqlCommand("SELECT * FROM TRANSACTIONS WHERE TRANS_DATE  BETWEEN @TRANS_DATE AND @TO", connection)
                command.Parameters.Add("@TRANS_DATE", SqlDbType.DateTime).Value = date2
                command.Parameters.Add("@TO", SqlDbType.DateTime).Value = Now.ToLongDateString
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(CoTable)
            End Using
            Dim rep As New transactio_logRpt
            rep.Database.Tables("TRANSACTIONS").SetDataSource(CoTable)


            If [crv].InvokeRequired Then
                Dim myDelegate As New LoadRpt(AddressOf ReportLoading)
                Me.Invoke(myDelegate, New Object() {crv})

            Else
                [crv].ReportSource = rep
            End If
            connection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Operation Error")
            MsgBox(ex.StackTrace)
            connection.Close()
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If BackgroundWorker1.CancellationPending Then
            e.Cancel = True
        Else
            If isFilter = True Then
                'ShowPanel([Panel2])
                FilterLoading([CrystalReportViewer1])
            Else
                ReportLoading(CrystalReportViewer1)
            End If
        End If
    End Sub

    Private Sub filtered_report_Click(sender As Object, e As EventArgs) Handles filtered_report.Click
        isFilter = True
        filtered_report.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        filtered_report.Enabled = True
        isFilter = False
    End Sub

    Private Sub normal_report_Click(sender As Object, e As EventArgs) Handles normal_report.Click
        isFilter = False
        normal_report.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        normal_report.Enabled = True
    End Sub
End Class