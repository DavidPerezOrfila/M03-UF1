Public Class UF2_RA1
    Dim nom As String = "David"

    Public Sub Hello(ByVal nom As String)

        MessageBox.Show("hello, " + nom + "!")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hello(nom)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hello("boton 2")
    End Sub
    Public Sub hell(ByRef nom As String)
        nom = "modificado"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.hell(nom)
    End Sub

    Public Sub suma(ByVal n1 As Integer, ByVal n2 As Integer, ByRef sumar As Integer)
        sumar = n1 + n2

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim resultado As Integer
        Me.suma(4, 7, resultado)
        MessageBox.Show(resultado)
    End Sub
    Public Function suma2(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        Return n1 + n2

    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim resultado As Integer = Me.suma2(4, 7)
        MessageBox.Show(resultado)
    End Sub
End Class
