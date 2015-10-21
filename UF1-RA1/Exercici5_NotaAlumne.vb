Public Class Exercici5_NotaAlumne
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim OP1 As Double
        OP1 = TextBox1.Text
        Dim nota As String = ""

        Select Case OP1
            Case 0 <= 5
                nota = OP1.ToString() + " Suspendido"
            Case 5 <= 6.5
                nota = OP1.ToString() + " Aprobado"
            Case 6.5 <= 8.5
                OP1 = OP1.ToString() + " Notable"
            Case 8.5 <= 9.75
                nota = OP1.ToString() + " Excelente"
            Case 9.75 <= 10
                nota = OP1.ToString() + " Matricula"
        End Select
        MessageBox.Show(nota)
    End Sub
End Class