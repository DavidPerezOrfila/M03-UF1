Public Class VocalConsonante
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim caracter, consonante, vocal As String
        caracter = TextBox1.Text
        vocal = 0
        consonante = 0
        If InStr("a,e,i,o,u", caracter) <> 0 Then
            vocal = vocal + 1
            MessageBox.Show(" Es una vocal ")
        ElseIf InStr("b,c,d,f,g,h,j,k,l,m,n,p,q,r,s,t,v,w,x,y,z", caracter) <> 0 Then
            consonante = consonante + 1
            MessageBox.Show(" Es una consonante")
        End If
    End Sub
End Class