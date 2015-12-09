Public Class ArraysNotasAlumnos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim nota() As Double = {6.5, 4, 7, 9.75}
        Dim nota(4) As Double
        Dim cnt As Integer
        Dim menor As Double
        For cnt = 0 To 3
            nota(cnt) = InputBox("Introduce una nota")
        Next
        menor = nota(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nota(3) As Double
        Dim cnt As Integer
        Dim menor As Double
        Dim mayor As Double
        Dim total As Double
        Dim media As Double
        mayor = nota(0)
        menor = nota(0)
        total = nota(0)
        For cnt = 1 To 3
            If nota(cnt) < menor Then
                menor = nota(cnt)
            End If
            total = total + nota(cnt)
        Next
        Media = total / nota.Length()
        MessageBox.Show(menor.ToString() + " , " + mayor.ToString() + " , " + Media.tostring())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim numeros() As Integer = {4, 20, 10, 12, 0, 7}
        Dim cnt As Integer
        Dim menor As Integer = numeros(0)
        Dim posmenor As Integer
        For cnt = 1 To 5
            If numeros(cnt) < menor Then
                menor = numeros(cnt)
                posmenor = cnt
            End If

        Next
        MessageBox.Show(posmenor.ToString())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim numeros(4) As Integer
        Dim cnt As Integer
        Dim buscar As Boolean
        numeros(cnt) = InputBox("")

    End Sub
End Class