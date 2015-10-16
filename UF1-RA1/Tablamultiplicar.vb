Public Class TablaMultiplicar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim salida As String = ""
        Dim contador As Integer
        Dim parcial As Integer

        num = TextBox1.Text

        For contador = 0 To 10
            parcial = num * contador
            salida = salida + num.ToString() + " x " + contador.ToString() + " = " + parcial.ToString() + Environment.NewLine

        Next

        MessageBox.Show(salida)

    End Sub
End Class