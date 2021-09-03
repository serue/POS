Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class DayEndReportForm
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub DayEndReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Dim CoTable As New DataTable
            Using command As New SqlCommand("SELECT * FROM SALES_REPORT", connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "DayEnd_Report.rdlc"
                Me.ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", DataSet1.Tables("DataSet1")))
                Me.ReportViewer1.RefreshReport()
            End Using
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Operation Error")
            connection.Close()

        End Try
    End Sub

    Delegate Sub LoadRpt(ByVal [crv] As Object)
    Delegate Sub SetPanelVisible(ByVal [panel] As Panel)

    'Private Sub ReportLoading(ByVal [crv] As Object)                     'use the same delegate LoadRpt 
    '    Try
    '        connection = myPermissions.getConnection
    '        If connection.State = ConnectionState.Open Then
    '            connection.Close()
    '        End If
    '        connection.Open()
    '        Dim CoTable As New DataTable
    '        Using command As New SqlCommand("SELECT * FROM SALES WHERE TRANS_DATE=@TO", connection)
    '            command.Parameters.Add("@TO", SqlDbType.Date).Value = Now.ToShortDateString
    '            Dim adapter As New SqlDataAdapter(command)
    '            adapter.Fill(CoTable)
    '        End Using
    '        Dim invtable As New DataTable
    '        Using command As New SqlCommand("SELECT * FROM INVENTORY", connection)
    '            Dim adapter As New SqlDataAdapter(command)
    '            adapter.Fill(invtable)
    '        End Using
    '        'Dim rep As New DayEndSalesReport
    '        rep.Database.Tables("SALES").SetDataSource(CoTable)
    '        rep.Database.Tables("INVENTORY").SetDataSource(invtable)
    '        If [crv].InvokeRequired Then
    '            Dim myDelegate As New LoadRpt(AddressOf ReportLoading)
    '            Me.Invoke(myDelegate, New Object() {crv})

    '        Else
    '            [crv].ReportSource = rep
    '            End If
    '            connection.Close()


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Operation Error")
    '        MsgBox(ex.StackTrace)
    '        connection.Close()
    '    End Try
    'End Sub
    Private Sub ShowPanel(ByVal [panel] As Panel)
        If [panel].InvokeRequired Then
            Dim myDelegate As New SetPanelVisible(AddressOf ShowPanel)

            Me.Invoke(myDelegate, New Object() {panel})

        Else
            [panel].Visible = True
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'If BackgroundWorker1.CancellationPending Then
        '    e.Cancel = True
        'Else
        '    'ShowPanel([Panel2])
        '    ReportLoading([CrystalReportViewer1])
        'End If
    End Sub
End Class