Public Class calculator
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim result As Decimal
    Dim operation As String
    Dim design As New IntefaceDesign

    Private Sub Numbers_Click(sender As Object, e As EventArgs) Handles two.Click, three.Click, six.Click, seven.Click, one.Click, nine.Click, four.Click, five.Click, eight.Click
        Try
            Dim b As Button = sender
            If solution_box.Text = 0 Then
                If (solution_box.Text.Contains(".")) Then
                    solution_box.Text = solution_box.Text & b.Text
                Else
                    solution_box.Text = b.Text
                End If

            Else
                solution_box.Text = solution_box.Text & b.Text
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub backspace_Click(sender As Object, e As EventArgs) Handles backspace.Click
        Try
            If solution_box.Text.Length > 0 Then
                If solution_box.Text.Length = 1 Then
                    solution_box.Text = 0
                Else
                    solution_box.Text = solution_box.Text.Remove(solution_box.Text.Length - 1, 1)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub solution_box_TextChanged(sender As Object, e As EventArgs) Handles solution_box.TextChanged

    End Sub

    Private Sub comma_Click(sender As Object, e As EventArgs) Handles comma.Click
        Try
            If Not (solution_box.Text.Contains(".")) Then
                solution_box.Text = solution_box.Text & "."
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        solution_box.Text = 0
        holder_label.Text = ""
    End Sub

    Private Sub cancel_all_Click(sender As Object, e As EventArgs) Handles cancel_all.Click
        solution_box.Text = 0
        holder_label.Text = ""
    End Sub

    Private Sub Arithmetic_function(sender As Object, e As EventArgs) Handles times.Click, plus.Click, minus.Click, devide.Click
        Try
            Dim b As Button = sender
            num1 = solution_box.Text
            operation = b.Text
            holder_label.Text = num1 & operation
            solution_box.Text = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click
        Try
            num2 = solution_box.Text
            holder_label.Text = num1 & operation & num2
            If operation = "÷" Then
                Try
                    result = num1 / num2
                    solution_box.Text = result
                Catch ex As Exception
                    solution_box.Text = "Cannot devide by zero"
                End Try

            ElseIf operation = "+" Then
                result = CDec(num1) + num2
                solution_box.Text = result
            ElseIf operation = "-" Then
                result = num1 - num2
                solution_box.Text = result

            ElseIf operation = "*" Then
                result = num1 * num2
                solution_box.Text = result
            ElseIf operation = "%" Then
                result = (num1 / 100) * num2
                solution_box.Text = result
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub squareroot_button_Click(sender As Object, e As EventArgs) Handles squareroot_button.Click
        Try
            If Not solution_box.Text = 0 Then
                num1 = solution_box.Text
                holder_label.Text = "√" & "(" & num1 & ")"
                solution_box.Text = CDec(Math.Sqrt(num1))

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub plus_minus_button_Click(sender As Object, e As EventArgs) Handles plus_minus_button.Click
        Try
            If Not solution_box.Text = 0 Then
                If (solution_box.Text.Contains("-")) Then
                    solution_box.Text = solution_box.Text.Replace("-", "")
                Else
                    solution_box.Text = "-" & solution_box.Text
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub squared_button_Click(sender As Object, e As EventArgs) Handles squared_button.Click
        Try
            If Not solution_box.Text = 0 Then
                num1 = solution_box.Text
                holder_label.Text = "sqr" & "(" & num1 & ")"
                solution_box.Text = Math.Pow(num1, 2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cubed_button_Click(sender As Object, e As EventArgs) Handles cubed_button.Click
        Try
            If Not solution_box.Text = 0 Then
                num1 = solution_box.Text
                holder_label.Text = "cube" & "(" & num1 & ")"
                solution_box.Text = Math.Pow(num1, 3)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fraction_button_Click(sender As Object, e As EventArgs) Handles fraction_button.Click
        Try
            If Not solution_box.Text = 0 Then
                num1 = solution_box.Text
                holder_label.Text = 1 & "/" & "(" & num1 & ")"
                solution_box.Text = CDec(1 / solution_box.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub zero_Click(sender As Object, e As EventArgs) Handles zero.Click
        Try
            If solution_box.Text <> 0 Then
                solution_box.Text += "0"
            Else
                solution_box.Text = "0"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub percentage_button_Click(sender As Object, e As EventArgs) Handles percentage_button.Click
        Try
            Dim b As Button = sender
            num1 = solution_box.Text
            operation = b.Text
            holder_label.Text = num1 & operation
            solution_box.Text = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menu_form.Show()
    End Sub
End Class