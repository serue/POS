Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class transactions_logReport
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim isFilter As Boolean = False
    Private Sub transactions_logReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isFilter = True Then
            'ShowPanel([Panel2])
            FilterLoading()
        Else
            ReportLoading()
        End If

    End Sub
    Delegate Sub LoadRpt(ByVal [crv] As Object)
    Delegate Sub SetPanelVisible(ByVal [panel] As Panel)

    Private Sub FilterLoading()                     'use the same delegate LoadRpt 
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
                    Dim DataSet1 As New DataSet
                    adapter.Fill(DataSet1, "DataSet1")
                    Me.ReportViewer1.LocalReport.ReportPath = "transaction_log.rdlc"
                    Me.ReportViewer1.LocalReport.DataSources.Clear()
                    Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", DataSet1.Tables("DataSet1")))
                    Me.ReportViewer1.RefreshReport()
                End Using
            Else
                Using command As New SqlCommand("SELECT * FROM TRANSACTIONS WHERE TRANS_DATE BETWEEN @TRANS_DATE AND @TO AND CASHIER=@USERNAME AND STATUS='COMPLETED'", connection)
                    command.Parameters.Add("@TRANS_DATE", SqlDbType.VarChar).Value = from_date.Text
                    command.Parameters.Add("@TO", SqlDbType.VarChar).Value = to_date.Text
                    command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = txt_username.Text
                    Dim adapter As New SqlDataAdapter(command)
                    Dim DataSet1 As New DataSet
                    adapter.Fill(DataSet1, "DataSet1")
                    Me.ReportViewer1.LocalReport.ReportPath = "transaction_log.rdlc"
                    Me.ReportViewer1.LocalReport.DataSources.Clear()
                    Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", DataSet1.Tables("DataSet1")))
                    Me.ReportViewer1.RefreshReport()
                End Using
            End If
            connection.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Operation Error")
            MsgBox(ex.StackTrace)
            connection.Close()
        End Try
    End Sub
    Private Sub ReportLoading()                     'use the same delegate LoadRpt 
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
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "transaction_log.rdlc"
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", DataSet1.Tables("DataSet1")))
                Me.ReportViewer1.RefreshReport()
            End Using
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
                FilterLoading()
            Else
                ReportLoading()
            End If
        End If
    End Sub

    Private Sub filtered_report_Click(sender As Object, e As EventArgs) Handles filtered_report.Click
        isFilter = True
        filtered_report.Enabled = False
        If isFilter = True Then
            'ShowPanel([Panel2])
            FilterLoading()
        Else
            ReportLoading()
        End If
        filtered_report.Enabled = True
        isFilter = False
    End Sub

    Private Sub normal_report_Click(sender As Object, e As EventArgs) Handles normal_report.Click
        isFilter = False
        normal_report.Enabled = False
        If isFilter = True Then
            'ShowPanel([Panel2])
            FilterLoading()
        Else
            ReportLoading()
        End If
        normal_report.Enabled = True
    End Sub

End Class