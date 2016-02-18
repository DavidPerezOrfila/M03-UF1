Public Class Semanaifelse
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer = 1
        n1 = CInt(TextBox1.Text)
        Dim Dia As String = ""
        Dia = n1

        If Dia = 1 Then
            MessageBox.Show("Lunes")
        ElseIf Dia = 2 Then
            MessageBox.Show("Martes")
        ElseIf Dia = 3 Then
            MessageBox.Show("Miércoles")
        ElseIf Dia = 4 Then
            MessageBox.Show("Jueves")
        ElseIf Dia = 5
            MessageBox.Show("Viernes")
        ElseIf Dia = 6 Then
            MessageBox.Show("Sábado")
        ElseIf Dia = 7 Then
            MessageBox.Show("Domingo")
        End If
    End Sub
End Class