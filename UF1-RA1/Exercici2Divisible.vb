﻿Public Class Exercici2Divisible
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
            n1 = CInt(TextBox1.Text)
            n2 = CInt(TextBox2.Text)

            If n1 Mod n2 = 0 Then
                MessageBox.Show("es divisible")
            Else
                MessageBox.Show("el número no es divisible")
            End If
        End Sub
    End Class
