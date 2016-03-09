Public Class EjerciciosUD2
    Dim comprapla, compraman, compraper As Double
    Dim precio, pagado, cambio As Double
    Dim platanos As Integer = 40
    Dim manzanas As Integer = 50
    Dim peras As Integer = 60
    Const valorpla As Double = 7.1
    Const valorman As Double = 4.9
    Const valorper As Double = 6.2
    Dim total As Double
    Dim cerrar As MsgBoxResult




    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.Text = valorman
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

        TextBox7.Text = TextBox7.Text
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        TextBox9.Text = TextBox9.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        TextBox8.Text = TextBox8.Text
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        TextBox11.Text = valorper
    End Sub



    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        TextBox10.Text = valorpla
    End Sub


    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged


    End Sub

    Private Sub Button2_Click(ByVal sender As Object, e As EventArgs) Handles Button2.Click
        Dim cerrar As Integer
        cerrar = MessageBox.Show("Atención" + MessageBoxButtons.YesNoCancel)

        If cerrar = DialogResult.Cancel Then
            MessageBox.Show("Ha pulsado cancelar")
        ElseIf cerrar = DialogResult.No Then
            MessageBox.Show("Ha decidido continuar")
        ElseIf cerrar = DialogResult.Yes Then
            MessageBox.Show("Gracias por utilizar la aplicación, hasta pronto!")
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.Text = peras
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = manzanas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = platanos
    End Sub

    Private Sub EjerciciosUD2_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged


        If IsNumeric(TextBox7.Text) And IsNumeric(TextBox8.Text) And IsNumeric(TextBox9.Text) Then
            TextBox13.Text = comprapla + compraman + compraper
        ElseIf IsNumeric(TextBox7.Text) And IsNumeric(TextBox8.Text) Then
            TextBox13.Text = comprapla.ToString + compraman.ToString

        End If

    End Sub
End Class