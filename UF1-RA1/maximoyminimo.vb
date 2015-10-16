Public Class maximoyminimo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim resultado As String = ""
        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)
        n3 = CInt(TextBox3.Text)


        If n1 > n2 And n2 > n3 Then
            resultado = n1.ToString() + " máximo" + ", " + n3.ToString() + " mínimo"
        ElseIf n1 > n3 And n3 > n2 Then
            resultado = n1.ToString() + " máximo" + ", " + n2.ToString() + " mínimo"
        ElseIf n2 > n1 And n1 > n3 Then
            resultado = n2.ToString() + " máximo" + ", " + n3.ToString() + " mínimo"
        ElseIf n2 > n3 And n3 > n1 Then
            resultado = n2.ToString() + " máximo" + ", " + n1.ToString() + " mínimo"
        ElseIf n3 > n2 And n2 > n1 Then
            resultado = n3.ToString() + " máximo" + ", " + n1.ToString() + " mínimo"
        ElseIf n3 > n1 And n1 > n2 Then
            resultado = n3.ToString() + " máximo" + ", " + n2.ToString() + " mínimo"



        End If

        MessageBox.Show(resultado)

    End Sub
End Class