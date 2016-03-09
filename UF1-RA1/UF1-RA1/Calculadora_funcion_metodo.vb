Public Class Calculadora_funcion_metodo
    Dim n1, n2, resultado As Integer

    Public Sub operadorsum(ByVal n1 As Integer, ByVal n2 As Integer)

        resultado = n1 + n2

    End Sub

    Public Sub operadorres(ByVal n1 As Integer, ByVal n2 As Integer)

        resultado = n1 - n2

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        n2 = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        n1 = TextBox1.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox3.Text = resultado
    End Sub
End Class