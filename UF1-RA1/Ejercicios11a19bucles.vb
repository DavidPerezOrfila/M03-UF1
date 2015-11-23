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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n As Integer
        Dim cnt As Integer
        Dim suma As Integer
        n = InputBox("Introduce un número mayor que 0")
        If n <= 0 Then
            MessageBox.Show("El número introducido debe ser mayor")
        End If
        While cnt <= n
            suma = suma + cnt
            cnt = cnt + 1
        End While

        MessageBox.Show(suma.ToString)

    End Sub

    Private Sub Ejercicios11a19bucles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim n As Integer
        Dim cnt As Integer
        Dim suma As Integer
        n = InputBox("Introduce un número mayor que 0")
        If n <= 0 Then
            MessageBox.Show("El número introducido debe ser mayor")
        End If
        For cnt = 1 To n
            suma = suma + cnt
        Next

        MessageBox.Show(suma.ToString)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim n As Integer
        Dim cnt As Integer
        Dim suma As Integer
        n = InputBox("Introduce un número mayor que 0")
        If n <= 0 Then
            MessageBox.Show("El número introducido debe ser mayor")
        End If
        Do While cnt <= n
            suma = suma + cnt
            cnt = cnt + 1
        Loop

        MessageBox.Show(suma.ToString)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim x As Integer = 0
        Dim n As Integer = 16

        While (n Mod 2 = 0)

            x = x + n
            n = n / 2
        End While
        MessageBox.Show(n.ToString + " " + x.ToString)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim i As Integer = 1
        Dim a As Integer = 0
        While i <= 20
            i = i + 2
            Do While (a < 10)
                a = a + 1
            Loop
            MessageBox.Show("XXX")
        End While



    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim x As Integer = 12
        Dim j As Integer = 5
        Dim k As Integer = 0
        If (x Mod 4 = 0) Then

            For j = 0 To 10 Step 4

                k = k + j
            Next
        Else

            For j = 0 To 10 Step 2

                k = k + j
            Next

        End If
        MessageBox.Show(j.ToString + " " + k.ToString)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim menor As Integer
        Dim mayor As Integer
        Dim numero As Integer
        Dim media As Double
        Dim cnt As Integer = 0
        Dim suma As Integer
        numero = InputBox("Introduce un número")
        mayor = numero
        menor = numero

        While numero > 0
            cnt = cnt + 1
            If numero < menor Then
                menor = numero
            ElseIf numero > mayor Then
                mayor = numero
            End If

            suma = (suma + numero)
            numero = InputBox("Introduce un número")
        End While
        media = suma / cnt
        MessageBox.Show(menor.ToString + " " + mayor.ToString + " " + media.ToString)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim num As Integer
        Dim negativo As Integer
        Dim positivo As Integer

        num = InputBox("Introduce un número")
        While num <> 0
            If num < 0 Then
                negativo = negativo + 1
            ElseIf num > 0 Then
                positivo = positivo + 1
            End If
            num = InputBox("Introduce un número")
        End While
        MessageBox.Show(negativo.ToString + " Son negativos" + " " + positivo.ToString + " Son positivos")

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim num As Double
        Dim salida As Double
        Dim cnt As Double

        num = InputBox("Introduce un número")
        For cnt = 1 To num
            If num < 0 Then
                MessageBox.Show("El número tiene que ser mayor que cero")
            End If
            salida = num ^ cnt
        Next
        MessageBox.Show(salida.ToString)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim num As Double
        Dim cnt As Double = 0

        num = InputBox("Introduce un número")

        While num >= 2
            num = num / 2
            cnt = cnt + 1

        End While
        MessageBox.Show(cnt.ToString)


    End Sub
End Class