Imports FontAwesome.Sharp

Public Class IntefaceDesign
    Private CurrentButton As New IconButton
    Private CurrentMainButton As New IconButton
    Dim currentChild As Form
    Public Sub activeButton(OpenButton As IconButton)

        If CurrentButton Is Nothing Then

            CurrentButton = OpenButton
            CurrentButton.BackColor = Color.FromArgb(92, 115, 156)
        Else
            CurrentButton.BackColor = Color.FromArgb(77, 96, 130)
            CurrentButton = OpenButton
            CurrentButton.BackColor = Color.FromArgb(92, 115, 156)

        End If

    End Sub
    Public Sub activeMainButton(OpenButton As IconButton)

        If CurrentMainButton Is Nothing Then
            CurrentMainButton = OpenButton
            CurrentMainButton.BackColor = Color.FromArgb(49, 68, 102)

        Else
            CurrentMainButton.BackColor = Color.FromArgb(41, 57, 85)
            CurrentMainButton = OpenButton
            CurrentMainButton.BackColor = Color.FromArgb(49, 68, 102)

        End If

    End Sub
    Public Sub OpenChildSmall(myPanel As Panel, ChildForm As Form)

        If currentChild Is Nothing Then
            myPanel.Visible = True
            currentChild = ChildForm
            currentChild.TopLevel = False
            currentChild.AutoSize = False
            currentChild.Show()
            currentChild.Dock = DockStyle.Fill
            currentChild.FormBorderStyle = FormBorderStyle.None
            myPanel.Controls.Add(currentChild)
        Else
            myPanel.Visible = True
            currentChild.Close()
            currentChild = ChildForm
            currentChild.TopLevel = False
            currentChild.AutoSize = False
            currentChild.Show()
            currentChild.Dock = DockStyle.Fill
            currentChild.FormBorderStyle = FormBorderStyle.None
            myPanel.Controls.Add(currentChild)

        End If

    End Sub

    Public Sub OpenChildForeign(myPanel As Panel, ChildForm As Form)

        If currentChild Is Nothing Then
            myPanel.Visible = True
            currentChild = ChildForm
            currentChild.TopLevel = False
            currentChild.AutoSize = False
            currentChild.Show()
            currentChild.Dock = DockStyle.Fill
            currentChild.FormBorderStyle = FormBorderStyle.None
            myPanel.Controls.Add(currentChild)
        Else
            myPanel.Visible = True
            currentChild.Close()
            currentChild = ChildForm
            currentChild.TopLevel = False
            currentChild.AutoSize = False
            currentChild.Show()
            currentChild.Dock = DockStyle.Fill
            currentChild.FormBorderStyle = FormBorderStyle.None
            myPanel.Controls.Add(currentChild)

        End If

    End Sub
    Public Sub CloseChildSmall(myPanel As Panel)

        If currentChild Is Nothing Then

        Else
            myPanel.Visible = True
            currentChild.Close()


        End If

    End Sub
End Class
