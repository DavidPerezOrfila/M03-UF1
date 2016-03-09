Public Class Fruteria
    Dim comprapla, compraman, compraper As Double
    Dim precio, pagado, cambio As Double
    Dim platanos As Double = 40
    Dim manzanas As Double = 50
    Dim peras As Double = 60
    Const valorpla As Double = 7.1
    Const valorman As Double = 4.9
    Const valorper As Double = 6.2



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        platanos += CDbl(TextBox1.Text)
        Me.TextBox1.Text = Val(Me.TextBox1.Text) - Val(Me.TextBox7.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        manzanas = CDbl(TextBox2.Text)
        Me.TextBox2.Text = Val(Me.TextBox2.Text) - Val(Me.TextBox8.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        peras = CDbl(TextBox3.Text)
        Me.TextBox3.Text = Val(Me.TextBox3.Text) - Val(Me.TextBox9.Text)
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged, TextBox8.TextChanged, TextBox9.TextChanged

        If IsNumeric(TextBox7.Text) And IsNumeric(TextBox8.Text) And IsNumeric(TextBox9.Text) Then
            Me.TextBox13.Text = (Val(Me.TextBox7.Text) * Val(Me.TextBox10.Text) + Val(Me.TextBox8.Text) * Val(Me.TextBox4.Text) + Val(Me.TextBox9.Text) * Val(Me.TextBox11.Text))
            precio = TextBox13.Text
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub



    Dim total As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox7.Text = "0"
        TextBox8.Text = "0"
        TextBox9.Text = "0"



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Close()

    End Sub

    Private Sub Fruteria_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = platanos
        TextBox2.Text = manzanas
        TextBox3.Text = peras
        TextBox11.Text = valorper
        TextBox10.Text = valorpla
        TextBox4.Text = valorman
        TextBox7.Text = "0"
        TextBox8.Text = "0"
        TextBox9.Text = "0"
    End Sub
End Class