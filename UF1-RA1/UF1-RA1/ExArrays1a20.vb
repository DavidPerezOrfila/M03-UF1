Public Class ExArrays1a20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num(9) As Double
        Dim cnt As Integer
        Dim cuadrado(9) As Double
        Dim cubo(9) As Double
        Dim salida2 As String = ""
        Dim salida3 As String = ""
        For cnt = 0 To 9
            num(cnt) = InputBox("Introduce un número entero")
        Next
        For cnt = 0 To 9
            cuadrado(cnt) = num(cnt) * num(cnt)
            salida2 += num(cnt).ToString + " Su cuadrado es= " + cuadrado(cnt).ToString + vbNewLine
        Next
        For cnt = 0 To 9
            cubo(cnt) = num(cnt) * num(cnt) * num(cnt)
            salida3 += num(cnt).ToString + " Su cubo es= " + cubo(cnt).ToString + vbNewLine
        Next


        MessageBox.Show(salida2 + vbNewLine + salida3 + " ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vector(14) As Integer
        Dim n1, n2 As Integer
        Dim r As New Random
        Dim cnt As Integer
        Dim suma As Integer
        n1 = InputBox("introduce un número entero ")
        n2 = InputBox("introduce un número entero ")
        For vector(cnt) = 0 To 14

            vector(cnt) = r.Next(n1, n2)
            suma = suma + (vector(cnt).ToString + Environment.NewLine)
        Next

        MessageBox.Show(suma)
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
            salida = salida + tabla(i, j).ToString + "  "
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i, j As Integer
        Dim tabla(2, 2) As Integer
        Dim r As New Random()
        Dim salida = ""
        For i = 0 To 2
            For j = 0 To 2
                If i = j Then
                    tabla(i, j) = r.Next(0, 100) 'random entre 0 y 100
                End If
            Next
            salida = salida + tabla(i, j).ToString + "  "
        Next
        MessageBox.Show(salida)
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
        Dim destino(10) As Integer
        Dim cnt, cnt2 As Integer
        Dim salida As String = ""
        Dim salidades As String = ""

        cnt2 = 0

        For origen(cnt) = 0 To 10
            salida += origen(cnt).ToString
        Next
        For origen(cnt) = 0 To 10
            If origen(cnt) > 25 And origen(cnt) Mod 2 = 0 Then
                destino(cnt2) = origen(cnt)
                salidades += destino(cnt2).ToString + " "
                cnt2 = cnt2 + 1

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

        For cnt = 0 To 4
            v(cnt) = InputBox("Introduce un número entero: ")

        Next
        cnt = 4
        For cnti = 0 To 4
            w(cnti) = v(cnt)
            cnt = cnt - 1
            salida = salida + w(cnti).ToString + vbNewLine


        Next
        MessageBox.Show(salida)
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

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim v(4), w(4), x(9) As Integer
        Dim cnt, cntv, cntw As Integer
        Dim salida As String = ""

        For cntv = 0 To 4
            v(cntv) = InputBox("Introduce cinco números")
        Next

        For cntw = 0 To 4
            w(cntw) = InputBox("Introduce cinco números ")
        Next
        cntv = 0
        cntw = 0
        For cnt = 0 To 9
            If cnt Mod 2 = 0 Then
                x(cnt) = v(cntv)
            Else
                x(cnt) = w(cntw)
            End If
            salida += +" " + x(cnt).ToString + " "
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim i(4), p(4), v(9), cnti, cntp, cntv As Integer
        Dim salidai As String = ""
        Dim salidap As String = ""
        Dim salidav As String = ""

        cnti = 0
        cntp = 0
        For cntv = 0 To 9
            v(cntv) = InputBox("Introduce un número ")
        Next
        For cntv = 0 To 9
            If v(cntv) Mod 2 = 0 Then
                p(cntp) = v(cntv)
                salidap += p(cntp).ToString + vbNewLine
            Else
                i(cnti) = v(cntv)
                salidai += i(cnti).ToString + vbNewLine
            End If
            salidav = salidai.ToString + vbNewLine + salidap.ToString
        Next
        MessageBox.Show(salidav)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim may, men, v(4), total As Integer
        Dim m As Integer
        Dim cnt As Integer

        may = v(0)
        men = v(0)
        total = v(0)

        For cnt = 0 To 4
            v(cnt) = InputBox("Introduce un número entero ")
        Next
        For cnt = 1 To 4
            If v(cnt) < men Then
                men = v(cnt)
            ElseIf v(cnt) > may Then
                may = v(cnt)

            End If
            total = total + v(cnt)
        Next
        m = total / v.Length()
        MessageBox.Show(men.ToString() + " , " + may.ToString())



    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        'Crear un array de dos dimensiones 10 x 10, el usuario debe introducir un número y 
        'hay que mostrar cuantas veces sale ese número en la tabla'

        Dim tabla(9, 9), i, j, num, x As Integer
        Dim r As New Random()
        Dim salida As String = ""
        num = InputBox("Introduce un número del 0 al 10")

        For i = 0 To 9
            For j = 0 To 9
                tabla(i, j) = r.Next(0, 10)
                salida += tabla(i, j).ToString
            Next
            salida += vbNewLine
        Next
        x = 0
        For i = 0 To 9
            For j = 0 To 9
                If tabla(i, j) = num Then
                    x = x + 1
                End If
            Next
        Next
        salida += x.ToString + ""
        MessageBox.Show(salida)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim liminf(), limsup(), sa, sm, pa, cnt As Integer
        Dim pct() As Integer = {5, 12, 15, 22, 30}
        Dim salida As String = ""
        sm = InputBox("Introduce tu salario mensual: ")
        pa = InputBox("Introduce el número de pagas anuales")
        liminf = {0, 1000000, 2500001, 3800001, 6000001}
        limsup = {1000001, 3800000, 6000000}
        For cnt = 0 To 4
            If sa >= liminf(cnt) And sa <= limsup(cnt) Then
                salida += pct(cnt).ToString
                Exit For
            ElseIf sa Then
                salida += pct(4).ToString
            End If
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim a, b, c As Double
        Dim x As Integer
        Dim salida As String = ""
        a = 0
        b = 1
        c = 0
        For x = 0 To 99
            If a = 0 Then
                salida += a.ToString + " " + b.ToString + " "
            End If
            c = a + b
            a = b
            b = c
            salida += c.ToString + " "
        Next

        MessageBox.Show(salida)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim num, cuadrado As Double
        Dim salida As String = ""

        For num = 1 To 100
            cuadrado = num * num
            salida += num.ToString + " Su cuadrado es= " + cuadrado.ToString + vbNewLine
        Next

        MessageBox.Show(salida)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim mayor, menor, media As Double
        Dim n, cnt As Integer
        Dim salida As String = ""
        Dim alto As String = ""
        Dim bajo As String = ""
        Dim salidamay As String = ""
        Dim salidamen As String = ""

        n = InputBox("Introduce número de personas")
        Dim altura(n) As Double
        For cnt = 0 To n - 1
            altura(cnt) = InputBox("Introduce alturas: ")
            media = media + altura(cnt)
        Next
        media = media / n
        menor = altura(0)
        mayor = altura(0)

        For cnt = 0 To n - 1
            If altura(cnt) < menor Then
                menor = altura(cnt)
            ElseIf altura(cnt) > mayor Then
                mayor = altura(cnt)

            End If
        Next
        For cnt = 0 To n - 1

            If altura(cnt) < media Then
                bajo += altura(cnt).ToString + " "
            ElseIf altura(cnt) > media Then
                alto += altura(cnt).ToString + " "
            End If


        Next
        MessageBox.Show("La estatura media es: " + media.ToString + vbNewLine + "La altura menor es:  " + menor.ToString + vbNewLine + "La altura mayor es:  " + mayor.ToString + vbNewLine + "Las alturas más bajas que la media son: " + bajo + vbNewLine + "Las alturas más altas que la media son: " + alto + vbNewLine)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim tabla(4, 4) As Integer
        Dim i, j As Integer
        Dim salida As String = " "
        Dim r As New Random()
        For i = 0 To 4
            For j = 0 To 4
                tabla(i, j) = r.Next(0, 10)
                salida += tabla(i, j).ToString
            Next
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        'Suma todos los elementos de una tabla. Dí que elementos de una tabla tiene la mayor suma de sus vecinos
        Dim i, j, tabla(3, 3) As Integer
        Dim r As New Random()
        Dim salida As String = ""
        For i = 0 To 3
            For j = 0 To 3
                tabla(i, j) = r.Next(0, 10)
                salida += tabla(i, j).ToString
            Next
            salida += vbNewLine
        Next
        For i = 0 To 3
            For j = 0 To 3

            Next
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
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

