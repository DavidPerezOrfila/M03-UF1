Public Class menorque
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim n3 As Integer
        Dim menor As Integer


        n1 = CInt(Textbox1.Text())
        n2 = CInt(Textbox2.Text())
        n3 = CInt(Textbox3.Text())


        If n1 < n2 And n1 < n3 Then
            menor = n1
        ElseIf n2 < n1 < n3 Then
            menor = n2
        Else
            menor = n3

        End If

        TextBox4.Text = menor.ToString()
    End Sub
End Class
