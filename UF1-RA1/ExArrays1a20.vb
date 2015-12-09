Public Class ExArrays1a20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeros(9) As Integer
        Dim cnt As Integer
        Dim cuadrado As Integer
        Dim cubo As Integer
        Dim salida As String = 0
        For cnt = 0 To 9
            numeros(cnt) = InputBox("Introduce un número entero")
        Next
        For cnt = 0 To 9
            cuadrado = numeros(cnt) ^ 2
            cubo = numeros(cnt) ^ 3
            salida = salida(numeros(cnt).ToString + " " + cuadrado.ToString() + " " + cubo.ToString() + " " + Environment.NewLine())
        Next
        MessageBox.Show(salida.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vector(14) As Integer
        Dim n1 As Integer
        Dim n2 As Integer
        Dim r As New Random
        Dim cnt As Integer
        Dim suma As Integer
        n1 = InputBox("introduce número")
        n2 = InputBox("introduce número")

        For vector(cnt) = 0 To 14
            vector(cnt) = r.Next(n1, n2)
        Next
        suma = suma + (vector.ToString + Environment.NewLine)
        MessageBox.Show(suma.ToString)
    End Sub
End Class