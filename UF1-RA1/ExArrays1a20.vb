Public Class ExArrays1a20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeros(9) As Integer
        Dim cnt As Integer
        Dim cuadrado As Integer
        Dim cubo As Integer
        Dim salida As String = ""
        For cnt = 0 To 9
            numeros(cnt) = InputBox("Introduce un número entero")
        Next
        For cnt = 0 To 9
            cuadrado = numeros(cnt) ^ 2
            cubo = numeros(cnt) ^ 3
            salida = salida(numeros(cnt).ToString + " " + cuadrado.ToString() + " " + cubo.ToString() + " " + Environment.NewLine())
        Next
        MessageBox.Show(salida)
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
        Dim salida As String = ""


        For origen(cnt) = 0 To 10
            If origen(cnt) > 25 Mod 2 = 0 Then
                destino = origen(cnt)

            End If

        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim tabla(9, 9) As Integer
        Dim i, j As Integer
        Dim r As New Random()
        Dim salida As String = ""

        For i = 0 To 9
            For j = 0 To 9
                tabla(i, j) = r.Next(0, 100)
                salida = salida + tabla(i, j).ToString + "  "
            Next
            salida = salida + vbNewLine

        Next

        For i = 0 To 9
            For j = 0 To 9
                If i Mod 2 = 0 Then
                    i = 1
                Else
                    i = 0
                End If
                salida = salida + tabla(i, j).ToString + "  "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim matriz(9, 9) As Integer
        Dim i, j As Integer
        Dim r As New Random()
        Dim salida As String = ""
        Dim sumalinea As Integer
        Dim sumacolumna As Integer


        For i = 0 To 9
            For j = 0 To 9
                matriz(i, j) = r.Next(0, 100)
            Next
        Next
        For i = 0 To 9
            sumalinea = sumalinea + matriz(i, j)
        Next

        For j = 0 To 9
            sumacolumna = sumacolumna + matriz(j, i)

        Next
        MessageBox.Show(salida = "La linea de la matriz suma " + sumalinea.ToString() + "La suma de la columna suma  " + sumacolumna.ToString() + " ")




    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim i, j As Integer
        Dim marco(4, 14) As Integer
        Dim salida As String = ""

        For i = 0 To 4
            For j = 0 To 14
                If i >= 1 And i <= 3 And j >= 1 And j <= 13 Then
                    marco(i, j) = 0
                Else
                    marco(i, j) = 1
                End If
                salida = salida + marco(i, j).ToString + " "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim vector(9), cnt, par(9), impar(9), cntp, cnti, suma(9) As Integer
        cntp = 0
        cnti = 0


        For cnt = 0 To 9
            vector(cnt) = InputBox("Introduce un número entero")
        Next
        For cnt = 0 To 9
            If vector(cnt) Mod 2 = 0 Then
                par(cntp) = vector(cnt)
                cntp = cntp + 1

            ElseIf vector(cnt) Mod 2 <> 0 Then
                impar(cnti) = vector(cnt)
                impar(cnti) = impar(cnti) + 1
            End If
        Next





    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim vector(4), cnt As Integer
        Dim suma As Integer
        Dim salida As String = ""
        For cnt = 0 To 4
            vector(cnt) = InputBox("Introduce un número entero: ")
        Next
        suma = vector(0)
        For cnt = 1 To 4
            suma = suma + vector(cnt)
            salida = salida + " " + suma.ToString + " " + vbNewLine

        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim vector(9), cnt As Integer
        Dim r As New Random()
        Dim salida As String = ""
        Dim menor As Integer

        For cnt = 0 To 9
            vector(cnt) = r.Next(0, 100)
            salida = salida + " " + vector(cnt).ToString + " " + vbNewLine
        Next
        menor = vector(0)
        For cnt = 1 To 9
            If vector(cnt) < menor Then
                menor = vector(cnt)
            End If

        Next
        MessageBox.Show(salida + "Número menor= " + menor.ToString)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim tabla(4, 4) As Integer
        Dim i, j As Integer
        Dim salida As String = ""

        For i = 0 To 4
            For j = 0 To 4
                If (i = 2 Or j = 2) Then
                    tabla(i, j) = 1
                Else
                    tabla(i, j) = 0
                End If
            Next
        Next
        For i = 0 To 4
            For j = 0 To 4
                salida += tabla(i, j).ToString + " "
            Next
            salida += vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim tabla(4, 4) As Integer
        Dim i, j As Integer
        Dim r As New Random()
        Dim suma As Integer = 0
        Dim salida As String = ""

        For i = 0 To 4
            For j = 0 To 4
                tabla(i, j) = r.Next(0, 10)
                If (i = 0 Or i = 4 Or j = 0 Or j = 4) Then
                    suma += tabla(i, j)
                End If
            Next
        Next

        For i = 0 To 4
            For j = 0 To 4
                salida += tabla(i, j).ToString + " "
            Next
        Next
        MessageBox.Show("La suma de los bordes es: " + suma.ToString)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        Dim v(4), w(4) As Integer
        Dim salida As String = ""
        Dim cnt, cnti As Integer
        Dim r As New Random()
        For cnt = 0 To 9
            v(cnt) = r.Next(0, 100)
            salida = salida + " " + v(cnt).ToString + " " + vbNewLine
        Next
        For cnti = 0 To 9

        Next

    End Sub
    Private Function imprimir(ByVal tabla(,) As Integer, ByVal filas As Integer, ByVal cols As Integer) As String
        Dim salida As String = ""
        Dim i, j As Integer
        For i = 0 To filas
            For j = 0 To cols
                salida += tabla(i, j).ToString + ""
            Next
            salida += vbNewLine
        Next

        Return salida
    End Function

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim tabla(4, 4) As Integer
        Dim tabla2(4, 4) As Integer
        Dim tabla3(4, 4) As Integer
        Dim r As New Random()
        Dim i, j As Integer
        Dim salida As String = ""
        Dim salida2 As String = ""
        Dim salida3 As String = ""
        For i = 0 To 4
            For j = 0 To 4
                tabla(i, j) = r.Next(0, 10)
                tabla2(i, j) = r.Next(0, 10)
                tabla3(i, j) = tabla(i, j) + tabla2(i, j)
            Next

            salida = Me.imprimir(tabla, 4, 4)
            salida2 = Me.imprimir(tabla2, 4, 4)
            salida3 = Me.imprimir(tabla3, 4, 4)
        Next
        MessageBox.Show(salida + vbNewLine + salida2 + vbNewLine + salida3 + vbNewLine)



    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim v(4), w(4), x(4) As Integer
        Dim r As New Random()
        Dim cntv, cntw As Integer
        Dim salida As String = ""
        Dim salida2 As String = ""
        Dim salida3 As String = ""
        For cntv = 0 To 4
            v(cntv) = r.Next(0, 9)
            salida2 = v(cntv).ToString
        Next
        For cntw = 0 To 4
            w(cntw) = r.Next(0, 9)
            salida3 = w(cntw).ToString
        Next

        x(4) = salida2 + salida3


        salida = x(4).ToString + vbNewLine
        MessageBox.Show(salida2 + vbNewLine + salida3 + vbNewLine + salida + " ")

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim vector(9), cnt As Integer

        Dim salida As String = ""
        For cnt = 0 To 9
            vector(cnt) = InputBox("Introduce números ")
            If vector(cnt) < 0 Then
                Exit For
                MessageBox.Show(salida = "Los números positivos introducidos son: " + vector(cnt).ToString)

            End If

            salida += vector(cnt).ToString + " "
        Next
        MessageBox.Show(salida)
    End Sub
End Class

