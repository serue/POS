﻿Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class loader
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   Control.CheckForIllegalCrossThreadCalls = False
        re_load.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        re_load.Enabled = True
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If BackgroundWorker1.CancellationPending Then
            e.Cancel = True
        Else
            ShowPanel([Panel2])
            LoaderReportLoading([CrystalReportViewer1])
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
        sign_in.Show()
        Me.Close()
    End Sub
    Delegate Sub LoadRpt(ByVal [crv] As Object)
    Delegate Sub SetPanelVisible(ByVal [panel] As Panel)

    Private Sub LoaderReportLoading(ByVal [crv] As Object)                     'use the same delegate LoadRpt 
        Try
            If My.Settings.connection = "" Then
                server_configuration.ShowDialog()
            Else
                connection = New SqlConnection(My.Settings.connection)
                connection.Open()
                Dim CoTable As New DataTable
                Using command As New SqlCommand("SELECT * FROM COMPANY", connection)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(CoTable)
                End Using
                Dim rep As New loaderReport
                rep.Database.Tables("COMPANY").SetDataSource(CoTable)

                If [crv].InvokeRequired Then
                    Dim myDelegate As New LoadRpt(AddressOf LoaderReportLoading)

                    Me.Invoke(myDelegate, New Object() {crv})

                Else
                    [crv].ReportSource = rep
                End If
                connection.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Operation Error")
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

End Class