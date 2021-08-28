Imports System.Data.SqlClient

Public Class cash_up_reportForm
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim isFilter As Boolean = False

    Private Sub cash_up_reportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Using command As New SqlCommand("SELECT * FROM CASHUP WHERE TRANS_DATE BETWEEN @TRANS_DATE AND @TO AND USERNAME=@USERNAME", connection)
                command.Parameters.Add("@TRANS_DATE", SqlDbType.VarChar).Value = current_date.Text
                command.Parameters.Add("@TO", SqlDbType.VarChar).Value = TO_DATE.Text
                command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username_text.Text
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(CoTable)
            End Using
            Dim rep As New cashUpReport
            rep.Database.Tables("CASHUP").SetDataSource(CoTable)


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
            Using command As New SqlCommand("SELECT * FROM CASHUP WHERE TRANS_DATE=@TRANS_DATE", connection)
                command.Parameters.Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(CoTable)
            End Using
            Dim rep As New cashUpReport
            rep.Database.Tables("CASHUP").SetDataSource(CoTable)


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

    Private Sub show_report_Click(sender As Object, e As EventArgs) Handles show_report.Click
        isFilter = True
        show_report.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        show_report.Enabled = True
        isFilter = False
    End Sub

    Private Sub day_report_Click(sender As Object, e As EventArgs) Handles day_report.Click
        isFilter = False
        day_report.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        day_report.Enabled = True
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
End Class