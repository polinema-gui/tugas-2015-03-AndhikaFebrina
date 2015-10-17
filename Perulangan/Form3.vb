Public Class Form3


    Dim Text1, Text2 As Integer
    Dim hasil As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Text1 = Convert.ToInt64(Text1String.Text)
        Text2 = Convert.ToInt64(Text2String.Text)
        If operasi.Text = "Tambah" Then
            hasil = Text1 + Text2
        Else
            hasil = Text1 - Text2
        End If
        hasilText.Text = hasil
    End Sub
End Class


