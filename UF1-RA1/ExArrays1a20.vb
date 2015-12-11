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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tabla(2, 2) As Integer
        Dim salida As String = ""
        Dim i, j As Integer
        tabla = {
            {2, 3, 4},
            {1, 5, 0},
            {2, 4, 1}
        }
        For i = 0 To 2
            For j = 0 To 2
                salida = salida + tabla(i, j).ToString + " "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tabla(2, 2) As Integer
        Dim salida As String = ""
        Dim i, j As Integer
        Dim r As New Random()
        tabla = {
            {2, 3, 4},
            {1, 5, 0},
            {2, 4, 1}
        }
        For i = 0 To 2
            For j = 0 To 2
                If i = j Then 'diagonal
                    tabla(i, j) = 0
                End If

            Next

        Next


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i, j As Integer
        Dim tabla(2, 2) As Integer
        Dim r As New Random()
        For i = 0 To 2
            For j = 0 To 2
                If i = j Then
                    tabla(i, j) = r.Next(0, 100) 'random entre 0 y 100
                End If
            Next

        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim tabla(19)
        Dim cnt As Integer
        Dim r As New Random()
        Dim salida As String = ""
        For cnt = 0 To 19
            tabla(cnt) = r.Next()
            If tabla(cnt) > 30 Then
                salida = salida + tabla(cnt).ToString + " "
            Else
                salida = salida + tabla(cnt).ToString + "NO HAY NUMEROS MAYORES DE 30"

            End If
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim origen() As Integer = {1, 4, 10, 32, 60, 91, 34, 56, 73, 88, 86}
        Dim destino As Integer
        Dim cnt As Integer
        Dim salida As String = " "
        destino = origen(0)

        For origen(cnt) = 0 To 10
            If origen(cnt) > 25 Mod 2 = 0 Then
                destino = origen(cnt)
                salida = salida + (origen(cnt).ToString + " " + destino.ToString())

            End If
            MessageBox.Show(salida)
        Next

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim tabla(9, 9) As Integer
        Dim i, j As Integer
        Dim r As New Random()
        Dim salida As String = ""

        For i = 0 To 9
            For j = 0 To 9
                tabla(i, j) = r.Next(0, 100)
            Next
        Next
        For i = 0 To 9
            For j = 0 To 9
                If i Mod 2 = 0 Then
                    i = 1
                Else
                    i = 0
                End If

            Next
            salida = salida + tabla(i, j).ToString + " "
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim matriz(9, 9) As Integer
        Dim i, j As Integer
        Dim r As New Random()
        Dim salida As String = ""
        Dim suma As Integer
        Dim cnt As Integer

        For i = 0 To 9
            For j = 0 To 9
                matriz(i, j) = r.Next(0, 100)
            Next
        Next
        For i = 0 To 9
            For j = 0 To 9

            Next
        Next
    End Sub
End Class