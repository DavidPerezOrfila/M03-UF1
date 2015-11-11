Public Class Ejercicios11a19bucles
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim cnt As Integer = 0
        Dim salida As Integer
        n = InputBox("Introduce un número")
        While cnt <= n
            salida = salida + cnt
            cnt = cnt + 2
        End While

        MessageBox.Show(salida.ToString)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As Integer
        Dim cnt As Integer
        Dim salida As Integer
        n = InputBox("Introduce un número")
        For cnt = 0 To n Step 2
            salida = salida + cnt
        Next

        MessageBox.Show(salida.ToString)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As Integer
        Dim cnt As Integer
        Dim salida As Integer
        n = InputBox("Introduce un número")
        Do While cnt <= n
            salida = salida + cnt
            cnt = cnt + 2
        Loop
        MessageBox.Show(salida.ToString)
    End Sub
End Class