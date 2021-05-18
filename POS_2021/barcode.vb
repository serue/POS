Imports ZXing

Public Class barcode
    Private Sub encode_button_Click(sender As Object, e As EventArgs) Handles encode_button.Click
        Try
            Dim writer As New BarcodeWriter
            writer.Format = BarcodeFormat.CODE_128
            pic.Image = writer.Write(txtInput.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class