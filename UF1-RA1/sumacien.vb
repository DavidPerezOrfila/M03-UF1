Public Class sumacien
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim suma As Integer
        For cnt As Integer = 0 To 100
            suma = suma + cnt
        Next

        MessageBox.Show(suma.ToString())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim suma As Integer = 0
        Dim cnt As Integer = 0
        While cnt <= 100
            suma = suma + cnt
            cnt = cnt + 1
        End While

        MessageBox.Show(suma.ToString())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim suma As Integer
        For cnt As Integer = 0 To 100
            If cnt Mod 2 <> 0 Then
                suma = suma + cnt
            End If
        Next

        MessageBox.Show(suma.ToString())



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim suma As Integer = 0
        Dim cnt As Integer = 0
        While cnt <= 100
            cnt = cnt + 1

            If cnt Mod 2 <> 0 Then
                suma = suma + cnt

            End If
        End While


        MessageBox.Show(suma.ToString())

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim suma As Integer

        suma = TextBox1.Text()
        For cnt As Integer = 0 To 100 Step +1

            suma = suma + cnt

        Next

        MessageBox.Show(suma.ToString())



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim notapromedio As Double
        Dim nota As Double
        Dim total As Double = 0

        For nota = 0 To 9
            nota = InputBox("Introduce una nota")
            total = nota + total

        Next
        notapromedio = total / 10
        MessageBox.Show(notapromedio.ToString())

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim menor As Integer
        Dim cnt As Integer
        Dim num As Integer
        menor = InputBox("Introduce un número")

        For cnt = 0 To 9
            num = InputBox("Introduce un número")
            If num < menor Then
                num = menor
            End If

        Next
        MessageBox.Show(menor.ToString())



    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Num As Integer
        Dim par As Integer
        Dim impar As Integer
        Dim Cnt As Integer
        Num = InputBox("Introduce un número")
        Cnt = 0
        For Cnt = 0 To 9
            If Num Mod 2 = 0 Then
                Num = par
                MessageBox.Show("Es par!")
            Else
                Num = impar
                MessageBox.Show("Es impar!")
            End If
        Next
        MessageBox.Show(Num.ToString())
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim N1 As Integer
        Dim N2 As Integer
        Dim cnt As Integer
        Dim intervalo As Integer
        Dim SUMA As Integer = 0
        N1 = InputBox("Introduce un número")
        N2 = InputBox("Introduce otro número")
        intervalo = N2 - N1


        MessageBox.Show(SUMA.ToString())
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim n As Integer
        Dim digitos As Integer = 0

        n = InputBox("Introduce un número")
        Do
            n = n \ 10
            digitos = digitos + 1
        Loop Until (n = 0)

        MessageBox.Show(digitos)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim i, j As Integer
        Dim salida As String = ""
        For i = 0 To 5 'filas
            For j = 0 To 5 'columnas
                salida = salida + " * "
            Next 'fin de una fila
            salida = salida + vbNewLine
        Next 'fin de todas las filas
        MessageBox.Show(salida)






    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim i, j As Integer
        Dim salida As String = ""

        For i = 0 To 5

            For j = 0 To i
                salida = salida + " * "
            Next
            salida = salida + vbNewLine

        Next
        MessageBox.Show(salida)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim i, j As Integer
        Dim salida As String = ""

        For i = 0 To 5

            For j = 0 To i
                salida = salida + " * "
            Next
            salida = salida + vbNewLine

        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim Num As Integer
        Dim cnt As Integer
        Dim factorial As Integer = 1
        Num = InputBox("Introduce un número")
        For cnt = 1 To Num
            factorial = factorial * cnt
        Next
        MessageBox.Show(factorial)
    End Sub
End Class