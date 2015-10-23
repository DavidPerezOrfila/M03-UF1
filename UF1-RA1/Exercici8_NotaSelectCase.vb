Public Class Exercici8_NotaSelectCase
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        n1 = CInt(TextBox1.Text)

        Select Case n1
            Case 0 To 4

                MessageBox.Show(" Suspendido ")
            Case 5 To 6

                MessageBox.Show(" Aprobado ")
            Case 6 To 8

                MessageBox.Show(" Notable ")
            Case 9 To 10

                MessageBox.Show(" Matrícula ")

        End Select

    End Sub
End Class