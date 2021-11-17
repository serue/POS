Imports System.Data.SqlClient
Module GetForexCurrency
    Dim myPermissions As New ConnectionAndPermissions
    Dim connection As SqlConnection
    Dim rate As Decimal
    Dim Forex As String
    Dim BaseCurrency As String
    Public Function GetForexRate(ByVal method As String) As Decimal
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
            Else
                connection.Open()
            End If
            Using command As New SqlCommand("SELECT CURRENCY FROM FOREX_CURRENCY", connection)
                Using adapter As New SqlDataAdapter(command)
                    Using table As New DataTable
                        adapter.Fill(table)
                        If table.Rows.Count > 0 Then
                            If method = "CASH" Then
                                Using CMD As New SqlCommand("SELECT RATE FROM CURRENCIES WHERE ID=@CURRENCY", connection)
                                    CMD.Parameters.Add("@CURRENCY", SqlDbType.VarChar).Value = table(0)(0)
                                    Using Adp As New SqlDataAdapter(CMD)
                                        Using ratetable As New DataTable
                                            Adp.Fill(ratetable)
                                            If ratetable.Rows.Count > 0 Then
                                                rate = ratetable(0)(0)
                                                Return rate
                                            Else
                                                MessageBox.Show("There is a problem with the saved currency, Please check the currency using settings form", "Rate not found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            End If
                                        End Using
                                    End Using
                                End Using
                            ElseIf method = "CARD" Or method = "ECOCASH" Then
                                Using CMD As New SqlCommand("SELECT RTGS_RATE FROM CURRENCIES WHERE ID=@CURRENCY", connection)
                                    CMD.Parameters.Add("@CURRENCY", SqlDbType.VarChar).Value = table(0)(0)
                                    Using Adp As New SqlDataAdapter(CMD)
                                        Using ratetable As New DataTable
                                            Adp.Fill(ratetable)
                                            If ratetable.Rows.Count > 0 Then
                                                rate = ratetable(0)(0)
                                                Return rate
                                            Else
                                                MessageBox.Show("There is a problem with the saved currency, Please check the currency using settings form", "Rate not found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            End If
                                        End Using
                                    End Using
                                End Using

                            End If
                        End If
                    End Using
                End Using
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "The following error occured while trying to get the current rate", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetBaseCurrency() As String
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
            Else
                connection.Open()
            End If
            Using command As New SqlCommand("SELECT CURRENCY FROM BASE_CURRENCY", connection)
                Using ADAPTER As New SqlDataAdapter(command)
                    Using TABLE As New DataTable
                        ADAPTER.Fill(TABLE)
                        If TABLE.Rows.Count > 0 Then
                            BaseCurrency = TABLE(0)(0)
                            Return BaseCurrency
                        End If
                    End Using
                End Using
            End Using
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "The following error was encountered on retrieving base currency", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function GetForex() As String
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
            Else
                connection.Open()
            End If
            Using command As New SqlCommand("SELECT CURRENCY FROM FOREX_CURRENCY", connection)
                Using ADAPTER As New SqlDataAdapter(command)
                    Using TABLE As New DataTable
                        ADAPTER.Fill(TABLE)
                        If TABLE.Rows.Count > 0 Then
                            Forex = TABLE(0)(0)
                            Return Forex
                        End If
                    End Using
                End Using
            End Using
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "The following error was encountered on retrieving base currency", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function LocalRTGSRate() As String
        Try
            connection = myPermissions.getConnection
            If connection.State = ConnectionState.Open Then
            Else
                connection.Open()
            End If
            Using command As New SqlCommand("SELECT RTGS_RATE FROM BASE_CURRENCY", connection)
                Dim adapter As New SqlDataAdapter(command)
                Dim table As New DataTable
                adapter.Fill(table)
                rate = table(0)(0)
                Return rate
            End Using
            connection.Close()
        Catch ex As Exception
            connection.Close()
            MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
End Module
