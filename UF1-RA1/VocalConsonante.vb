Public Class VocalConsonante
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vocal As String = "aeiou"
        Dim consonante As String = "bcdfghjklmnpqrstvwxyz"
        Dim caracter As String
        caracter = TextBox1.Text
        If caracter = vocal Then
            MessageBox.Show(" Es una vocal ")
        ElseIf caracter = consonante Then
            MessageBox.Show(" Es una consonante")
        End If
    End Sub
End Class