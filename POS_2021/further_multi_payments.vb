Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class further_multi_payments
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim forCash, ForCard, ForEco, ForForex As String
    Private Sub further_multi_payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        forCash = ""
        ForCard = ""
        ForEco = ""
        ForForex = ""
        If filter_toggler.Checked = True Then
            'ShowPanel([Panel2])
            FilterReport()
        Else
            ReportLoading()
        End If
    End Sub

    Private Sub cash_check_CheckedChanged(sender As Object, e As EventArgs) Handles cash_check.CheckedChanged
        If cash_check.Checked Then
            forCash = "CASH"
        Else
            forCash = ""
        End If
    End Sub

    Private Sub card_check_CheckedChanged(sender As Object, e As EventArgs) Handles card_check.CheckedChanged
        If card_check.Checked Then
            ForCard = "CARD"
        Else
            ForCard = ""
        End If
    End Sub

    Private Sub ecocash_check_CheckedChanged(sender As Object, e As EventArgs) Handles ecocash_check.CheckedChanged
        If ecocash_check.Checked Then
            ForEco = "ECOCASH"
        Else
            ForEco = ""
        End If
    End Sub

    Private Sub forex_check_CheckedChanged(sender As Object, e As EventArgs) Handles forex_check.CheckedChanged
        If forex_check.Checked Then
            ForForex = "FOREX"
        Else
            ForForex = ""
        End If
    End Sub

    Private Sub show_report_Click(sender As Object, e As EventArgs) Handles show_report.Click
        show_report.Enabled = False
        If filter_toggler.Checked = True Then
            'ShowPanel([Panel2])
            FilterReport()
        Else
            ReportLoading()
        End If
        show_report.Enabled = True
    End Sub

    Private Sub filter_toggler_CheckedChanged(sender As Object, e As EventArgs) Handles filter_toggler.CheckedChanged
        If filter_toggler.Checked Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub ReportLoading()                     'use the same delegate LoadRpt 
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()
            Dim CoTable As New DataTable
            Using command As New SqlCommand("SELECT * FROM OTHER_METHODS", connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "multi_Report.rdlc"
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
            Using command As New SqlCommand("SELECT * FROM OTHER_METHODS WHERE TRANS_DATE BETWEEN @FROM AND @TO AND (METHOD=@CASH OR METHOD=@ECOCASH OR METHOD=@CARD OR METHOD=@FOREX)", connection)
                With command.Parameters
                    .Add("@FROM", SqlDbType.DateTime).Value = date_from.Text
                    .Add("@TO", SqlDbType.DateTime).Value = date_to.Text
                    .Add("@CASH", SqlDbType.VarChar).Value = forCash
                    .Add("@ECOCASH", SqlDbType.VarChar).Value = ForEco
                    .Add("@CARD", SqlDbType.VarChar).Value = ForCard
                    .Add("@FOREX", SqlDbType.VarChar).Value = ForForex
                End With
                Dim adapter As New SqlDataAdapter(command)
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "multi_Report.rdlc"
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