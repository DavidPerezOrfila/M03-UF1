Public Class Exercici9_Calendari
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mes As Integer, año As Integer
        mes = CInt(TextBox1.Text)
        año = CInt(TextBox2.Text)

        If mes < 1 Or mes > 12 Then
            MessageBox.Show(" Los meses son del 1 al 12!!")
        ElseIf mes = 2 And año Mod 4 = 0 And año Mod 100 = 0 And año Mod 400 <> 0 Then
            MessageBox.Show("28")
        ElseIf mes = 2 And año Mod 4 = 0
            MessageBox.Show("29")
        ElseIf mes = 2
            MessageBox.Show("28")
        ElseIf mes <> 2 And mes Mod 2 <> 0 And mes <= 7 Then
            MessageBox.Show("31")
        ElseIf mes <> 2 And mes > 7 And mes Mod 2 = 0 Then
            MessageBox.Show("31")
        ElseIf mes <> 2 And mes Mod 2 = 0 And mes <= 6 Then
            MessageBox.Show("30")
        ElseIf mes <> 2 And mes Mod 2 <> 0 And mes >= 9 Then
            MessageBox.Show("30")

        End If
    End Sub
End Class