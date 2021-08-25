Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Imports Tulpep.NotificationWindow

Public Class menu_form
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    Public oPanel As New Panel
    Dim isCollapsed As Boolean = True
    Dim butt As New IconButton
    Dim Design As New IntefaceDesign
    Dim Notice As New PopupNotifier
    Public nyuwani As New Form
    Dim myPermissions As New ConnectionAndPermissions
    Dim connection As New SqlConnection
    Private user As String
    Public Property ActiveUser() As String
        Get
            Return user
        End Get
        Set(ByVal value As String)
            user = value
        End Set
    End Property

    Private username As String
    Public Property ActiveUsername() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Private Sub openPanel(ByVal op As Panel, ByVal but As IconButton)
        If oPanel Is Nothing Then
            oPanel = op
            butt = but

        Else
            oPanel = Nothing
            oPanel = op
            butt = but

        End If
    End Sub

    Private Sub defaultHome()
        oPanel = Nothing

    End Sub

    Private Sub CollapsePanel()
        If oPanel IsNot Nothing Then
            If isCollapsed Then
                oPanel.Height += 10
                butt.IconChar = IconChar.AngleDown
                If oPanel.Size = oPanel.MaximumSize Then
                    Timer1.Stop()
                    isCollapsed = False
                End If
            Else

                oPanel.Height -= 10

                If oPanel.Size = oPanel.MinimumSize Then
                    Timer1.Stop()
                    isCollapsed = True
                End If
            End If
        End If

    End Sub

    Private Sub menu_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Design.OpenChildForeign(Me.mainPanel, nyuwani)
        inventoy_panel.Size = inventoy_panel.MinimumSize
        sales_panel.Size = sales_panel.MinimumSize
        users_panel.Size = users_panel.MinimumSize
        reports_panel.Size = reports_panel.MinimumSize
        Timer4.Start()
        active_user.Text = ActiveUser

        'tulpet notifications

        Notice.HeaderColor = Color.DarkBlue
        Notice.Image = My.Resources.Company_Logo 'Image.FromFile(Application.StartupPath & "\information.jpg")
        Notice.ImageSize = New Size(40, 40)
        Notice.ImagePadding = New Padding(10)
        Notice.TitleText = "Stock Level Alert"
        Notice.TitleFont = New Font("Arial", 14, FontStyle.Bold)
        Notice.TitleColor = Color.DarkRed
        Notice.ContentText = " Your stock level is low, Click here for more Information !!!"
        Notice.ContentFont = New Font("Arial", 9, FontStyle.Regular)
        Notice.ContentColor = Color.Purple
        Notice.ContentPadding = New Padding(10)
        Notice.AnimationDuration = 5000
        Notice.Delay = 10000
        Notice.ShowOptionsButton = True
        Notice.Size = New Size(700, 200)
        Notice.Popup()


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
        Me.Chart1.Series("Series2").Points.AddXY("chamakore", 98)

        Me.Chart1.Series("Series3").Points.AddXY("zindove", 90)
        Me.Chart1.Series("Series3").Points.AddXY("jebwe", 25)
        Me.Chart1.Series("Series3").Points.AddXY("raika", 60)
        Me.Chart1.Series("Series3").Points.AddXY("chamakore", 40)

        Me.Chart1.Series("Series1").Points.AddXY("zind", 87)
        Me.Chart1.Series("Series1").Points.AddXY("jeb", 50)
        Me.Chart1.Series("Series1").Points.AddXY("rai", 60)
        Me.Chart1.Series("Series1").Points.AddXY("cham", 70)

        Me.Chart1.Series("Series2").Points.AddXY("zin", 50)
        Me.Chart1.Series("Series2").Points.AddXY("jeb", 65)
        Me.Chart1.Series("Series2").Points.AddXY("rai", 33)
        Me.Chart1.Series("Series2").Points.AddXY("cham", 40)

        Me.Chart1.Series("Series3").Points.AddXY("zin", 70)
        Me.Chart1.Series("Series3").Points.AddXY("jeb", 80)
        Me.Chart1.Series("Series3").Points.AddXY("rai", 40)
        Me.Chart1.Series("Series3").Points.AddXY("cham", 34)
    End Sub

    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles close_button.Click
        If MessageBox.Show("Confirm Exit ", " Exit Appplication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub Inventory_menu_Click(sender As Object, e As EventArgs) Handles Inventory_menu.Click
        Design.activeMainButton(Inventory_menu)
        If oPanel IsNot Nothing Then
            oPanel.Size = oPanel.MinimumSize
            butt.IconChar = IconChar.AngleRight
            isCollapsed = True
            openPanel(inventoy_panel, Inventory_menu)
            Timer1.Start()
        Else
            openPanel(inventoy_panel, Inventory_menu)
            Timer1.Start()
        End If


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CollapsePanel()

    End Sub

    Private Sub sales_menu_Click(sender As Object, e As EventArgs) Handles sales_menu.Click
        Design.activeMainButton(sales_menu)
        If oPanel IsNot Nothing Then
            oPanel.Size = oPanel.MinimumSize
            butt.IconChar = IconChar.AngleRight
            isCollapsed = True
            openPanel(sales_panel, sales_menu)
            Timer1.Start()
        Else
            openPanel(sales_panel, sales_menu)
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If oPanel IsNot Nothing Then
            oPanel.Height -= 10

            If oPanel.Size = oPanel.MinimumSize Then
                butt.IconChar = IconChar.AngleRight
                isCollapsed = True
                Timer2.Stop()
                defaultHome()
            End If

        Else
            defaultHome()
        End If
    End Sub

    Private Sub reports_menu_Click(sender As Object, e As EventArgs) Handles reports_menu.Click
        Design.activeMainButton(reports_menu)
        If oPanel IsNot Nothing Then
            oPanel.Size = oPanel.MinimumSize
            butt.IconChar = IconChar.AngleRight
            isCollapsed = True
            openPanel(reports_panel, reports_menu)
            Timer1.Start()
        Else
            openPanel(reports_panel, reports_menu)
            Timer1.Start()
        End If
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Design.activeMainButton(IconButton4)
        If oPanel IsNot Nothing Then
            oPanel.Size = oPanel.MinimumSize
            butt.IconChar = IconChar.AngleRight
            isCollapsed = True
            openPanel(users_panel, IconButton4)
            Timer1.Start()
        Else
            openPanel(users_panel, IconButton4)
            Timer1.Start()
        End If
    End Sub

    Private Sub home_button_Click(sender As Object, e As EventArgs) Handles home_button.Click
        Timer2.Start()
        Design.CloseChildSmall(Me.oPanel)
        subPanel.Visible = True
        dashboard_label.Text = "dashboard".ToUpper
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

    End Sub

    Private Sub btnPermissions_Click(sender As Object, e As EventArgs) Handles give_permissions.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION=@PERMISSION AND STATUS='1'", connection)
                With command.Parameters
                    .Add("@USERNAME", SqlDbType.VarChar).Value = username
                    .Add("@PERMISSION", SqlDbType.VarChar).Value = give_permissions.Name
                End With
                Dim reader As SqlDataReader = command.ExecuteReader
                If reader.HasRows Then
                    Design.activeMainButton(give_permissions)
                    Design.OpenChildSmall(Me.mainPanel, New Permissions)
                    subPanel.Visible = False
                    dashboard_label.Text = "user permissions".ToUpper
                Else
                    MessageBox.Show("You are not permitted to do this operation, Please contact your Supervisor for assistance", "Checking User Permissions For the operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "The following error happened while trying to check roles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        date_label.Text = Now

    End Sub

    Private Sub database_button_Click(sender As Object, e As EventArgs) Handles database_button.Click
        Design.activeMainButton(database_button)
        If oPanel IsNot Nothing Then
            oPanel.Size = oPanel.MinimumSize
            butt.IconChar = IconChar.AngleRight
            isCollapsed = True
            openPanel(database_panel, database_button)
            Timer1.Start()
        Else
            openPanel(database_panel, database_button)
            Timer1.Start()
        End If
    End Sub

    Private Sub add_inventory_Click(sender As Object, e As EventArgs) Handles add_inventory.Click
        Design.OpenChildSmall(Me.mainPanel, New Add_inventory)
        Design.activeButton(add_inventory)
        subPanel.Visible = False
        dashboard_label.Text = "ADD NEW INVENTORY IN STOCK".ToUpper
    End Sub

    Private Sub maximise_button_Click(sender As Object, e As EventArgs) Handles maximise_button.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            maximise_button.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Else
            Me.WindowState = FormWindowState.Maximized
            maximise_button.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        End If
    End Sub

    Private Sub minimise_button_Click(sender As Object, e As EventArgs) Handles minimise_button.Click
        Me.WindowState = FormWindowState.Minimized
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
    Private Sub settings_button_Click(sender As Object, e As EventArgs) Handles edit_settings.Click
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION=@PERMISSION AND STATUS='1'", connection)
                With command.Parameters
                    .Add("@USERNAME", SqlDbType.VarChar).Value = username
                    .Add("@PERMISSION", SqlDbType.VarChar).Value = edit_settings.Name
                End With
                Dim reader As SqlDataReader = command.ExecuteReader
                If reader.HasRows Then
                    Design.activeMainButton(edit_settings)
                    settings.ActiveUser = ActiveUser
                    settings.ActiveUsername = username
                    settings.ShowDialog()
                Else
                    MessageBox.Show("You are not permitted to do this operation, Please contact your Supervisor for assistance", "Checking User Permissions For the operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub logout_button_Click(sender As Object, e As EventArgs) Handles logout_button.Click
        Design.activeMainButton(logout_button)
        sign_in.Show()
        Me.Close()
    End Sub

    Private Sub stock_valuation_Click(sender As Object, e As EventArgs) Handles stock_valuation.Click
        Design.OpenChildSmall(Me.mainPanel, New inventory_list)
        Design.activeButton(stock_valuation)
        subPanel.Visible = False
        dashboard_label.Text = "INVENTORY LIST".ToUpper
    End Sub

    Private Sub Category_button_Click(sender As Object, e As EventArgs) Handles Category_button.Click
        categories.ShowDialog()
    End Sub
    Private Sub Backup_button_Click(sender As Object, e As EventArgs) Handles backup_database.Click
        If MessageBox.Show("Are sure you want to backup your database, Please make sure that no operation is going to be interupted and then proceed", "System Database Backup", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Try
                connection = myPermissions.getConnection
                connection.Open()
                Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION=@PERMISSION AND STATUS='1'", connection)
                    With command.Parameters
                        .Add("@USERNAME", SqlDbType.VarChar).Value = username
                        .Add("@PERMISSION", SqlDbType.VarChar).Value = backup_database.Name
                    End With
                    Dim reader As SqlDataReader = command.ExecuteReader
                    If reader.HasRows Then
                        Using cmd As New SqlCommand("BACKUP DATABASE POS_DATABASE TO DISK=@DISK WITH init;", connection)
                            cmd.Parameters.Add("@DISK", SqlDbType.VarChar).Value = Application.StartupPath & "\back\POS_DB.bak"
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("System Database Backup was successful", "Back Up System Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Using
                    Else
                        MessageBox.Show("You are not permitted to do this operation, Please contact your Supervisor for assistance", "Checking User Permissions For the operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
                connection.Close()
            Catch ex As Exception
                connection.Close()
                MessageBox.Show(ex.Message, "Backup Failed with the following  Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub restore_button_Click(sender As Object, e As EventArgs) Handles restore_button.Click
        Try
            connection = New SqlConnection("Data Source=BEYMO\SERU; Initial Catalog=POS_DATABASE; Integrated Security=True;")
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION=@PERMISSION AND STATUS='1'", connection)
                With command.Parameters
                    .Add("@USERNAME", SqlDbType.VarChar).Value = username
                    .Add("@PERMISSION", SqlDbType.VarChar).Value = backup_database.Name
                End With
                Dim reader As SqlDataReader = command.ExecuteReader
                If reader.HasRows Then
                    Using cmd As New SqlCommand("RESTORE DATABASE POS_DATABASE FROM DISK=@DISK WITH replace;", connection)
                        cmd.Parameters.Add("@DISK", SqlDbType.VarChar).Value = Application.StartupPath & "\back\POS_DB.bak"
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Database Restore was successful", "Restoring a database from backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Else
                    MessageBox.Show("You are not permitted to do this operation, Please contact your Supervisor for assistance", "Checking User Permissions For the operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "An Error Occured on restoring the database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles users_label.Click, monthlySalesLabel.Click

    End Sub

    Private Sub dayEnd_sales_Click(sender As Object, e As EventArgs) Handles dayEnd_sales.Click
        checkPermissions(username, dayEnd_sales.Name, New Add_inventory)
    End Sub

    Private Sub cashup_balances_Click(sender As Object, e As EventArgs) Handles cashup_balances.Click
        checkPermissions(username, cashup_balances.Name, New Add_inventory)
    End Sub
    Private Sub checkPermissions(account As String, permit As String, destinition As Form)
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION=@PERMISSION AND STATUS='1'", connection)
                With command.Parameters
                    .Add("@USERNAME", SqlDbType.VarChar).Value = account
                    .Add("@PERMISSION", SqlDbType.VarChar).Value = permit
                End With
                Dim reader As SqlDataReader = command.ExecuteReader
                If reader.HasRows Then
                    destinition.Show()
                Else
                    MessageBox.Show("You are not permitted to do this operation, Please contact your Supervisor for assistance", "Checking User Permissions For the operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Erro Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub checkPermission(account As String, permit As String, destinition As Form)
        Try
            connection = myPermissions.getConnection
            connection.Open()
            Using command As New SqlCommand("SELECT * FROM USER_PERMISSIONS WHERE USERNAME=@USERNAME AND PERMISSION=@PERMISSION AND STATUS='1'", connection)
                With command.Parameters
                    .Add("@USERNAME", SqlDbType.VarChar).Value = account
                    .Add("@PERMISSION", SqlDbType.VarChar).Value = permit
                End With
                Dim reader As SqlDataReader = command.ExecuteReader
                If reader.HasRows Then
                    destinition.ShowDialog()
                Else
                    MessageBox.Show("You are not permitted to do this operation, Please contact your Supervisor for assistance", "Checking User Permissions For the operation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Erro Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub return_sales_Click(sender As Object, e As EventArgs) Handles return_sales.Click
        checkPermissions(username, return_sales.Name, New DayEndReportForm)
    End Sub

    Private Sub transaction_logs_Click(sender As Object, e As EventArgs) Handles transaction_logs.Click
        checkPermissions(username, transaction_logs.Name, New Add_inventory)
    End Sub

    Private Sub profit_reports_Click(sender As Object, e As EventArgs) Handles profit_reports.Click
        checkPermissions(username, profit_reports.Name, New Add_inventory)
    End Sub

    Private Sub scheduled_reports_Click(sender As Object, e As EventArgs) Handles scheduled_reports.Click
        checkPermissions(username, scheduled_reports.Name, New Add_inventory)
    End Sub

    Private Sub stock_reports_Click(sender As Object, e As EventArgs) Handles stock_reports.Click
        checkPermissions(username, stock_reports.Name, New StockReportForm)
    End Sub

    Private Sub register_users_Click(sender As Object, e As EventArgs) Handles register_users.Click
        checkPermission(username, register_users.Name, New user_registration)
    End Sub

    Private Sub update_users_Click(sender As Object, e As EventArgs) Handles update_users.Click
        checkPermissions(username, update_users.Name, New user_registration)
    End Sub
End Class