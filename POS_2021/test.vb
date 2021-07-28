﻿Imports System.Data.SqlClient

Public Class test
    Private myPermissions As New ConnectionAndPermissions
    Dim connection As SqlConnection
    Dim status As Integer = 0

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin.CheckState = status
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using Command As New SqlCommand("select * from INVENTORY_VIEW", connection)
                Dim table As New DataTable
                Dim adapter As New SqlDataAdapter(Command)
                adapter.Fill(table)

                DataGridView1.DataSource = table
            End Using

            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub save()
        connection = myPermissions.getConnection()
        Try
            connection.Open()

            Using Command As New SqlCommand("insert into user_permissions([username],[permission],[status]) values(@user,@permission,@status)", connection)

                With Command.Parameters

                    .Add("@permission", SqlDbType.VarChar).Value = Admin.Name.ToString
                    ' .Add("@status", SqlDbType.VarChar).Value = ProfitReports.ToString

                End With

                Command.ExecuteNonQuery()
                MsgBox("done")
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim symbol As String = "Y"
        Dim number1 As Decimal = TextBox1.Text
        Dim num As Decimal = TextBox3.Text
        Dim n As Decimal = TextBox4.Text
        TextBox2.Text = number1.ToString(symbol & " ###,###,###.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            connection = myPermissions.getConnection()
            connection.Open()
            Using command As New SqlCommand("insert into cashs(money) values(@money)", connection)
                command.Parameters.Add("@money", SqlDbType.Decimal).Value = TextBox2.Text
                command.ExecuteNonQuery()
                MsgBox("done boss")
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        Dim number As Decimal = TextBox2.Text
        TextBox2.Text = number.ToString("###,###,###.00")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            connection = myPermissions.getConnection()
            Using command As New SqlCommand("insert into hey(name,age) values(@name,@age)", connection)
                With command.Parameters
                    .Add("@name", SqlDbType.VarChar).Value = TextBox1.Text
                    .Add("@age", SqlDbType.Int).Value = TextBox3.Text
                End With
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
            MsgBox("done")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            MsgBox("Done my man")
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class