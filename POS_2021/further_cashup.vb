Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class further_cashup
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim isFilter As Boolean = False
    Dim forCash, ForCard, ForEco, ForForex As String
    Private Sub further_cashup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forCash = ""
        ForCard = ""
        ForEco = ""
        ForForex = ""
        If isFilter = True Then
            'ShowPanel([Panel2])
            FilterLoading()
        Else
            ReportLoading()
        End If
    End Sub
    Private Sub FilterLoading()                     'use the same delegate LoadRpt 
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()
            Dim CoTable As New DataTable
            Using command As New SqlCommand("SELECT * FROM OTHER_METHODS_SUMMARY WHERE AMOUNT > 0 AND TRANS_DATE BETWEEN @TRANS_DATE AND @TO AND USERNAME=@USERNAME OR METHOD=@CASH OR METHOD=@CARD OR METHOD=@ECOCASH OR METHOD=@FOREX ORDER BY ID DESC", connection)
                command.Parameters.Add("@TRANS_DATE", SqlDbType.VarChar).Value = current_date.Text
                command.Parameters.Add("@TO", SqlDbType.VarChar).Value = TO_DATE.Text
                command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = username_text.Text
                command.Parameters.Add("@CASH", SqlDbType.VarChar).Value = forCash
                command.Parameters.Add("@CARD", SqlDbType.VarChar).Value = ForCard
                command.Parameters.Add("@ECOCASH", SqlDbType.VarChar).Value = ForEco
                command.Parameters.Add("@FOREX", SqlDbType.VarChar).Value = ForForex
                Dim adapter As New SqlDataAdapter(command)
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "futher_report.rdlc"
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
            Using command As New SqlCommand("SELECT * FROM OTHER_METHODS_SUMMARY WHERE AMOUNT > 0 AND  TRANS_DATE=@TRANS_DATE ORDER BY ID DESC", connection)
                command.Parameters.Add("@TRANS_DATE", SqlDbType.VarChar).Value = Now.ToShortDateString
                Dim adapter As New SqlDataAdapter(command)
                Dim DataSet1 As New DataSet
                adapter.Fill(DataSet1, "DataSet1")
                Me.ReportViewer1.LocalReport.ReportPath = "futher_report.rdlc"
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
End Class