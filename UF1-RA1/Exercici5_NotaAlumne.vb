Public Class Exercici5_NotaAlumne
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim OP1 As Double
        OP1 = TextBox1.Text
        If OP1 = 0 <= 4 Then
            MessageBox.Show(" Suspendido")
        ElseIf OP1 = 5 <= 6.5 Then
            MessageBox.Show(" Aprobado")
        ElseIf OP1 = 6.5 <= 8.5 Then
            MessageBox.Show(" Notable")
        ElseIf OP1 = 8.5 <= 9.75 Then
            MessageBox.Show(" Excelente")
        ElseIf OP1 = 9.75 <= 10 Then
            MessageBox.Show(" Matricula")
        End If
    End Sub
End Class