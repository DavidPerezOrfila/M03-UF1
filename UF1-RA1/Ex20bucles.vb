Public Class Ex20bucles
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer
        Dim factorial As Integer
        Dim i As Integer
        numero = InputBox("Introdueix un numero positiu:")
        factorial = 1
        i = 1
        While i < numero
            factorial = factorial * i
            i = i + 1
        End While
        MessageBox.Show("El factorial del numero és: " + factorial.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero As Integer
        Dim factorial As Integer
        Dim i As Integer
        numero = InputBox("Introdueix un numero positiu:")
        factorial = 1
        For i = 1 To numero - 1
            factorial = factorial * i
        Next
        MessageBox.Show("El factorial del numero és: " + factorial.ToString)
    End Sub

End Class