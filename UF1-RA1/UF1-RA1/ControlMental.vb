Public Class ControlMental
    Public cont As Integer
    Private r As New Random
    Private op1, op2 As Integer
    Private operador As New Random



    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 90
        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cont < 101 Then
            ProgressBar1.Value = cont
            cont += 1
        Else
            Timer1.Enabled = False
            MessageBox.Show("Se ha terminado el tiempo!")
            Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Num1_ValueChanged(sender As Object, e As EventArgs) Handles Num1.ValueChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim operacion As Integer
        operacion = operador.Next(1, 4)
        Select Case operacion
            Case 1
                TextBox2.Text = " + "
            Case 2
                TextBox2.Text = " - "
            Case 3
                TextBox2.Text = " * "
            Case 4
                TextBox2.Text = " / "
        End Select
    End Sub

    Public Sub Empezar()
        op1 = r.Next(0, 100)
        op2 = r.Next(0, 100)

        TextBox1.Text = op1.ToString()
        TextBox3.Text = op2.ToString()

        Num1.Value = 0
    End Sub

    Private Sub ControlMental_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class