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
End Class