Public Class Bucle_Pares
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim salida As String = ""

        For pares As Integer = 0 To 20 Step +2

            salida = salida + " - " + pares.ToString()
        Next
        MessageBox.Show(salida)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim salida As String = ""
        Dim pares As Integer = 0
        While pares <= 20

            salida = salida + " - " + pares.ToString()
            pares = pares + 2

        End While
        MessageBox.Show(salida)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pares As Integer = 0
        Dim salida As String = ""
        Do While pares <= 20
            salida = salida + " - " + pares.ToString()
            pares = pares + 2

        Loop
        MessageBox.Show(salida)
    End Sub
End Class