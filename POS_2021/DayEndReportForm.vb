Imports System.Data.SqlClient

Public Class DayEndReportForm
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub DayEndReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Delegate Sub LoadRpt(ByVal [crv] As Object)
    Delegate Sub SetPanelVisible(ByVal [panel] As Panel)

    Private Sub ReportLoading(ByVal [crv] As Object)                     'use the same delegate LoadRpt 
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()
            Dim CoTable As New DataTable
            Using command As New SqlCommand("SELECT * FROM SALES", connection)
                Dim adapter As New SqlDataAdapter(command)
                adapter.Fill(CoTable)
            End Using
            Dim rep As New DayEndSalesReport
            rep.Database.Tables("SALES").SetDataSource(CoTable)

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
    Private Sub ShowPanel(ByVal [panel] As Panel)
        If [panel].InvokeRequired Then
            Dim myDelegate As New SetPanelVisible(AddressOf ShowPanel)

            Me.Invoke(myDelegate, New Object() {panel})

        Else
            [panel].Visible = True
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If BackgroundWorker1.CancellationPending Then
            e.Cancel = True
        Else
            'ShowPanel([Panel2])
            ReportLoading([CrystalReportViewer1])
        End If
    End Sub
End Class