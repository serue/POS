Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class cash_up_reportForm
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim isFilter As Boolean = False

    Private Sub cash_up_reportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BackgroundWorker1.RunWorkerAsync()
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
            Using command As New SqlCommand("SELECT * FROM CASHUP WHERE TRANS_DATE BETWEEN @TRANS_DATE AND @TO AND USERNAME=@USERNAME", connection)
                command.Parameters.Add("@TRANS_DATE", SqlDbType.VarChar).Value = current_date.Text
                command.Parameters.Add("@TO", SqlDbType.VarChar).Value = TO_DATE.Text
                command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username_text.Text
                Dim adapter As New SqlDataAdapter(command)
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "Cashup_Report.rdlc"
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
    Private Sub ReportLoading()                     'use the same delegate LoadRpt 
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()
            Dim CoTable As New DataTable
            Using command As New SqlCommand("SELECT * FROM CASHUP WHERE TRANS_DATE=@TRANS_DATE", connection)
                command.Parameters.Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                Dim adapter As New SqlDataAdapter(command)
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "Cashup_Report.rdlc"
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

    Private Sub show_report_Click(sender As Object, e As EventArgs) Handles show_report.Click
        isFilter = True
        show_report.Enabled = False
        If isFilter = True Then
            'ShowPanel([Panel2])
            FilterLoading()
        Else
            ReportLoading()
        End If
        show_report.Enabled = True
        isFilter = False
    End Sub

    Private Sub day_report_Click(sender As Object, e As EventArgs) Handles day_report.Click
        isFilter = False
        day_report.Enabled = False
        If isFilter = True Then
            'ShowPanel([Panel2])
            FilterLoading()
        Else
            ReportLoading()
        End If
        day_report.Enabled = True
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
End Class