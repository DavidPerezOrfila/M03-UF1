Public Class p1
    Dim n1 As Double
    Dim n2 As Double
    Dim total As Double
    Dim stock As Double = 40

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        n1 = CDbl(TextBox1.Text)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        n2 = CDbl(TextBox4.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox4.TextChanged
        Me.TextBox3.Text = Val(Me.TextBox1.Text) * Val(Me.TextBox4.Text)

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = TextBox2.Text & "40"

    End Sub
End Class