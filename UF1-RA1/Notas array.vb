Public Class Notas_array
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim notas(4) As Double
        Dim mayor As Double
        Dim menor As Double
        Dim media As Double
        Dim cnt As Integer
        Dim total As Double
        Dim salida As String = ""

        For cnt = 0 To 3
            notas(cnt) = InputBox("Introduce una nota")

        Next
        notas(0) = menor
        notas(0) = mayor
        notas(0) = total
        For cnt = 1 To 3
            If notas(cnt) < menor Then
                menor = notas(cnt)
            End If
            If notas(cnt) > mayor Then

                mayor = notas(cnt)
            End If
            total = total + notas(cnt)

        Next
        media = total / notas.Length()
        MessageBox.Show(menor.ToString() + " " + media.ToString() + " " + mayor.ToString())
    End Sub
End Class