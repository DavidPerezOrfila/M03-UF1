Public Class Semana
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer = 1
        n1 = CInt(TextBox1.Text)
        Dim Dia As String = ""
        Dia = n1

        Select Case Dia

            Case 1
                MessageBox.Show("Lunes")

            Case 2
                MessageBox.Show("Martes")

            Case 3
                MessageBox.Show("Miércoles")

            Case 4
                MessageBox.Show("Jueves")

            Case 5
                MessageBox.Show("Viernes")
            Case 6
                MessageBox.Show("Sábado")

            Case 7
                MessageBox.Show("Domingo")

        End Select
    End Sub
End Class