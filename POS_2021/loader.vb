Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class loader
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   Control.CheckForIllegalCrossThreadCalls = 
        re_load.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        re_load.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If BackgroundWorker1.CancellationPending Then
            e.Cancel = True
        Else
            ShowPanel([Panel2])
            LoaderReportLoading()
        End If

    End Sub

    Private Sub re_load_Click(sender As Object, e As EventArgs) Handles re_load.Click

        If BackgroundWorker1.IsBusy Then
            MsgBox("busy")
        Else
            re_load.Enabled = False
            BackgroundWorker1.RunWorkerAsync()
            re_load.Enabled = True
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error Is Nothing Then
            sign_in.Show()
            Me.Close()
        Else
            MessageBox.Show("There was an Error, Try to configure settings and proceed", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            server_configuration.Show()
            Me.Close()
        End If

    End Sub
    Delegate Sub LoadRpt(ByVal [crv] As Object)
    Delegate Sub SetPanelVisible(ByVal [panel] As Panel)

    Private Sub LoaderReportLoading()                     'use the same delegate LoadRpt 
        Try
            If My.Settings.connection = "" Then
                server_configuration.ShowDialog()
                Me.Close()
            Else
                connection = New SqlConnection(My.Settings.connection)
                connection.Open()
                Dim CoTable As New DataTable
                Using command As New SqlCommand("SELECT * FROM COMPANY", connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(CoTable)
                End Using
                'Dim rep As New loaderReport
                ''rep.Database.Tables("COMPANY").SetDataSource(CoTable)

                ''If [crv].InvokeRequired Then
                ''    Dim myDelegate As New LoadRpt(AddressOf LoaderReportLoading)

                ''    Me.Invoke(myDelegate, New Object() {crv})

                ''Else
                ''    [crv].ReportSource = rep
                ''End If
                connection.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Operation Error")
            Dim source As String
            Dim log As String
            Dim eventname As String
            source = "CRV"
            log = "Application"
            eventname = ex.ToString
            If Not EventLog.SourceExists(source) Then
                EventLog.CreateEventSource(source, log)
            End If
            EventLog.WriteEntry(source, eventname)
            EventLog.WriteEntry(source, eventname, EventLogEntryType.Error)

            server_configuration.ShowDialog()
            Me.Close()
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

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        If MessageBox.Show("Confirm Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class