Public Class Arraymultidimensional
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabla(2, 2) As Integer
        Dim i, j As Integer
        Dim suma As Integer = 0
        Dim media As Double
        tabla = {
            {2, 3, 4},
            {1, 5, 0},
            {2, 4, 1},
            }
        For i = 0 To 2
            For j = 0 To 2
                suma = suma + tabla(i, j)
            Next
        Next
        media = suma / (3 * 3)


    End Sub
End Class