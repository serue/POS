Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.ComponentModel
Public Class multi_payment_report
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim forCash, ForCard, ForEco, ForForex As String


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If BackgroundWorker1.CancellationPending Then
            e.Cancel = True
        Else

        End If
    End Sub



    Private Sub show_report_Click(sender As Object, e As EventArgs) Handles show_report.Click
        show_report.Enabled = False

        FilterReport()

        show_report.Enabled = True
    End Sub

    Private Sub FURTHER_REPORT_Click(sender As Object, e As EventArgs) Handles FURTHER_REPORT.Click
        further_multi_payments.ShowDialog()
    End Sub

    Private Sub multi_payment_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' BackgroundWorker1.RunWorkerAsync()

        ReportLoading()



    End Sub

    Private Sub ReportLoading()                     'use the same delegate LoadRpt 
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()
            Dim CoTable As New DataTable
            Using command As New SqlCommand("SELECT * FROM SALES_REPORT WHERE SALE_TYPE='MULTIPLE'", connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "Sheduled_Report.rdlc"
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
    Private Sub FilterReport()                     'use the same delegate LoadRpt 
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()
            Dim CoTable As New DataTable
            Using command As New SqlCommand("SELECT * FROM SALES_REPORT WHERE TRANS_DATE BETWEEN @FROM AND @TO AND SALE_TYPE='MULTIPLE'", connection)

                Dim adapter As New SqlDataAdapter(command)
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "Sheduled_Report.rdlc"
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
End Class