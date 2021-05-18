Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class company
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Dim connection As SqlConnection
    Dim myPermissions As New ConnectionAndPermissions
    Dim COMPANY_ID As Integer
    Private Sub company_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM COMPANY ", connection)
                Dim adapter As New SqlDataAdapter
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count > 0 Then
                    COMPANY_ID = table(0)(0)
                    name_textbox.Text = table(0)(1).ToString
                    If Not IsDBNull(table(0)(2)) Then
                        TRADE_TEXTBOX.Text = table(0)(2).ToString

                    End If
                    address_textbox.Text = table(0)(3).ToString
                    description_textbox.Text = table(0)(4).ToString
                    contact_textbox.Text = table(0)(5).ToString
                    txtvat_no.Text = table(0)(5).ToString
                    txtvat.Text = table(0)(7).ToString
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error when retrieving Company Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal IParam As Integer) As Integer

    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean

    End Function

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub minimise_button_Click(sender As Object, e As EventArgs) Handles minimise_button.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles close_button.Click
        If MessageBox.Show("Confirm Exit ", " Exit Appplication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub save_item_Click(sender As Object, e As EventArgs) Handles save_item.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using command As New SqlCommand("INSERT INTO COMPANY VALUES(@NAME,@TRADENAME,@ADDRESS,@DESCRIPTION,@CONTACTS,@VAT_NO,@VAT)", connection)
                With command.Parameters
                    .Add("@NAME", SqlDbType.VarChar).Value = name_textbox.Text
                    .Add("@TRADENAME", SqlDbType.VarChar).Value = TRADE_TEXTBOX.Text
                    .Add("@ADDRESS", SqlDbType.VarChar).Value = address_textbox.Text
                    .Add("@DESCRIPTION", SqlDbType.VarChar).Value = description_textbox.Text
                    .Add("@CONTACTS", SqlDbType.VarChar).Value = contact_textbox.Text
                    .Add("@VAT_NO", SqlDbType.VarChar).Value = txtvat_no.Text
                    .Add("@VAT", SqlDbType.Decimal).Value = txtvat.Text

                End With
                command.ExecuteNonQuery()
                MessageBox.Show("The Company was registerd successfully!!", "Company Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
            connection.Close()

        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error occured while savingCompany Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub edit_details_Click(sender As Object, e As EventArgs) Handles edit_details.Click
        Try
            If Not IsDBNull(COMPANY_ID) Then
                connection = myPermissions.getConnection()
                connection.Open()
                Using command As New SqlCommand("INSERT INTO COMPANY VALUES(@NAME,@TRADENAME,@ADDRESS,@DESCRIPTION,@CONTACTS,@VAT_NO,@VAT) WHERE ID=@ID", connection)
                    With command.Parameters
                        .Add("@NAME", SqlDbType.VarChar).Value = name_textbox.Text
                        .Add("@TRADENAME", SqlDbType.VarChar).Value = TRADE_TEXTBOX.Text
                        .Add("@ADDRESS", SqlDbType.VarChar).Value = address_textbox.Text
                        .Add("@DESCRIPTION", SqlDbType.VarChar).Value = description_textbox.Text
                        .Add("@CONTACTS", SqlDbType.VarChar).Value = contact_textbox.Text
                        .Add("@VAT_NO", SqlDbType.VarChar).Value = txtvat_no.Text
                        .Add("@VAT", SqlDbType.Decimal).Value = txtvat.Text

                    End With
                    command.ExecuteNonQuery()
                    MessageBox.Show("The Company was registerd successfully!!", "Company Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
                connection.Close()

            Else
                MessageBox.Show("There is no record to update", "Update Company Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error occured while savingCompany Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class