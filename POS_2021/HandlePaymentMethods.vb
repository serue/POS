Imports System.Data.SqlClient
Module HandlePaymentMethods
    Dim myPermissions As New ConnectionAndPermissions
    Dim connection As SqlConnection

    Public Function HandleForexPayment()
        Dim CURR As String = GetBaseCurrency()
        Dim forex As String = GetForex()
        If CURR = forex Then
            Return "FOREX"
        End If
    End Function
End Module
