Imports System.Data.SqlClient

Public Class receipt_form
    Dim myPermissions As New ConnectionAndPermissions
    Dim connection As SqlConnection
    Private TransId As String = ""

    Public Property Transaction As String


        Get
            Return TransId
        End Get
        Set(value As String)

            TransId = value

        End Set

    End Property
    Private Sub receipt_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class