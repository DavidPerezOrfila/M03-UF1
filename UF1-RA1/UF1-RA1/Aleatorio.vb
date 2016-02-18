Public Class Aleatorio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim min As Integer
        Dim max As Integer
        Dim r As New Random
        min = CInt(TextBox1.Text)
        max = CInt(TextBox2.Text)

        TextBox3.Text = r.Next(min, max)
    End Sub

    Private Sub Aleatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class