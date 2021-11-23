Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class StockReportForm
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Private Sub StockReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        category_combo.Enabled = False
        'BackgroundWorker1.RunWorkerAsync()
        'Me.ReportViewer1.RefreshReport()
        ReportLoading()
    End Sub

    Private Sub category_check_CheckedChanged(sender As Object, e As EventArgs) Handles category_check.CheckedChanged
        If category_check.Checked = True Then
            category_combo.Enabled = True
        Else
            category_combo.Enabled = False
        End If
    End Sub
    Delegate Sub LoadRpt(ByVal [crv] As Object)
    Delegate Sub SetPanelVisible(ByVal [panel] As Panel)

    Private Sub ReportLoading()                     'use the same delegate LoadRpt 
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Dim CoTable As New DataTable
            If category_check.Checked And category_combo.Text = "" Then
                Using command As New SqlCommand("SELECT * FROM INVENTORY", connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim DataSet1 As New DataSet
                    adapter.Fill(DataSet1, "DataSet1")
                    Me.ReportViewer1.LocalReport.ReportPath = "Stock_Report.rdlc"
                    Me.ReportViewer1.LocalReport.DataSources.Clear()
                    Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", DataSet1.Tables("DataSet1")))
                    Me.ReportViewer1.RefreshReport()
                End Using
            ElseIf category_check.Checked = False Then
                Using command As New SqlCommand("SELECT * FROM INVENTORY", connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim DataSet1 As New DataSet
                    adapter.Fill(DataSet1, "DataSet1")
                    Me.ReportViewer1.LocalReport.ReportPath = "Stock_Report.rdlc"
                    Me.ReportViewer1.LocalReport.DataSources.Clear()
                    Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", DataSet1.Tables("DataSet1")))
                    Me.ReportViewer1.RefreshReport()
                End Using

            Else
                Using command As New SqlCommand("SELECT * FROM INVENTORY WHERE CATEGORY=@CATEGORY", connection)
                    command.Parameters.Add("@CATEGORY", SqlDbType.VarChar).Value = category_combo.Text
                    Dim adapter As New SqlDataAdapter(command)
                    Dim DataSet1 As New DataSet
                    adapter.Fill(DataSet1, "DataSet1")
                    Me.ReportViewer1.LocalReport.ReportPath = "Stock_Report.rdlc"
                    Me.ReportViewer1.LocalReport.DataSources.Clear()
                    Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", DataSet1.Tables("DataSet1")))
                    Me.ReportViewer1.RefreshReport()
                End Using
            End If
            connection.Close()
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

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If BackgroundWorker1.CancellationPending Then
            e.Cancel = True
        Else
            'ShowPanel([Panel2])
            'ReportLoading([CrystalReportViewer1])
        End If
    End Sub

    Private Sub category_combo_Click(sender As Object, e As EventArgs) Handles category_combo.Click
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            connection.Open()
            Using command As New SqlCommand("SELECT CATEGORY FROM CATEGORY", connection)
                Using adapter As New SqlDataAdapter(command)
                    Using table As New DataTable
                        adapter.Fill(table)
                        category_combo.Items.Clear()

                        For Each item In table.Rows
                            category_combo.Items.Add(item(0))
                        Next
                    End Using
                End Using
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub show_report_Click(sender As Object, e As EventArgs) Handles show_report.Click
        ReportLoading()
    End Sub

End Class