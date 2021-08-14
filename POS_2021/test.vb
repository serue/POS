Imports System.Data.SqlClient

Public Class test
    Private myPermissions As New ConnectionAndPermissions
    Dim connection As SqlConnection
    Dim status As Integer = 0

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Admin.CheckState = status
        Timer1.Start()

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim transaction As SqlTransaction
        Try
            connection = myPermissions.getConnection
            connection.Open()
            transaction = connection.BeginTransaction
            Using command As New SqlCommand("insert into test_name(name) values(@name)", connection, transaction)
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = TextBox5.Text
                command.ExecuteNonQuery()
            End Using
            Using command As New SqlCommand("insert into test_surname(surnam) values(@name)", connection, transaction)
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = TextBox6.Text
                command.ExecuteNonQuery()
            End Using
            transaction.Commit()
            MsgBox("successfull")
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim collen As Decimal = CDec("1,223,456.90") + CDec("200")
        MsgBox(collen)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Chart1.ChartAreas(0).AxisX.LineWidth = 1
        Chart1.ChartAreas(0).AxisY.LineWidth = 1
        'Chart1.ChartAreas(0).AxisX.LabelStyle.Enabled = False
        'Chart1.ChartAreas(0).AxisY.LabelStyle.Enabled = False
        'Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        Chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = False
        'Chart1.ChartAreas(0).AxisX.MinorGrid.Enabled = False
        'Chart1.ChartAreas(0).AxisY.MinorGrid.Enabled = False
        'Chart1.ChartAreas(0).AxisX.MajorTickMark.Enabled = False
        'Chart1.ChartAreas(0).AxisY.MajorTickMark.Enabled = False
        'Chart1.ChartAreas(0).AxisX.MinorTickMark.Enabled = False
        'Chart1.ChartAreas(0).AxisY.MinorTickMark.Enabled = False
        Chart1.ChartAreas(0).BackColor = SystemColors.Control
        Me.Refresh()
        Chart1.ChartAreas(0).AxisX.IsMarginVisible = False
        Me.Chart1.Series("Series1").Points.AddXY("collen", 110)
        Me.Chart1.Series("Series1").Points.AddXY("kabote", 99)
        Me.Chart1.Series("Series1").Points.AddXY("dhinda", 9)
        Me.Chart1.Series("Series1").Points.AddXY("seru", 56)

        Me.Chart1.Series("Series2").Points.AddXY("collen", 90)
        Me.Chart1.Series("Series2").Points.AddXY("kabote", 69)
        Me.Chart1.Series("Series2").Points.AddXY("dhinda", 89)
        Me.Chart1.Series("Series2").Points.AddXY("seru", 40)

        Me.Chart1.Series("Series3").Points.AddXY("collen", 60)
        Me.Chart1.Series("Series3").Points.AddXY("kabote", 40)
        Me.Chart1.Series("Series3").Points.AddXY("dhinda", 50)
        Me.Chart1.Series("Series3").Points.AddXY("seru", 76)


        Me.Chart1.Series("Series1").Points.AddXY("zindove", 75)
        Me.Chart1.Series("Series1").Points.AddXY("jebwe", 60)
        Me.Chart1.Series("Series1").Points.AddXY("raika", 34)
        Me.Chart1.Series("Series1").Points.AddXY("chamakore", 55)

        Me.Chart1.Series("Series2").Points.AddXY("zindove", 30)
        Me.Chart1.Series("Series2").Points.AddXY("jebwe", 38)
        Me.Chart1.Series("Series2").Points.AddXY("raika", 10)
        Me.Chart1.Series("Series2").Points.AddXY("camakore", 98)

        Me.Chart1.Series("Series3").Points.AddXY("zindove", 90)
        Me.Chart1.Series("Series3").Points.AddXY("jebwe", 25)
        Me.Chart1.Series("Series3").Points.AddXY("raika", 60)
        Me.Chart1.Series("Series3").Points.AddXY("chamakore", 40)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Now
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using cmd As New SqlCommand("BACKUP DATABASE POS_DATABASE TO DISK=@DISK WITH init;", connection)
                cmd.Parameters.Add("@DISK", SqlDbType.VarChar).Value = Application.StartupPath & "\back\POS_DB.bak"
                cmd.ExecuteNonQuery()
                MsgBox("Success")
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MaterialRaisedButton2_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Try
            connection = New SqlConnection("Data Source=BEYMO\SERU; Initial Catalog=POS_DATABASE; Integrated Security=True;")
            connection.Open()
            Using cmd As New SqlCommand("RESTORE DATABASE POS_DATABASE FROM DISK=@DISK WITH replace;", connection)
                cmd.Parameters.Add("@DISK", SqlDbType.VarChar).Value = Application.StartupPath & "\back\POS_DB.bak"
                cmd.ExecuteNonQuery()
                MsgBox("Success")
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class