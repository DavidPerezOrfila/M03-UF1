Public Class ControlMental
    Public cont As Integer
    Private r As New Random
    Private op1, op2 As Integer
    Private operador As New Random
    Dim resultado As Integer
    Public Sub operacion()
        Dim operacion As Integer
        operacion = operador.Next(1, 4)
        Select Case operacion
            Case 1
                TextBox2.Text = TextBox2.Text & " + "
                resultado = Val(TextBox1.Text) + Val(TextBox3.Text)
            Case 2
                TextBox2.Text = TextBox2.Text & " - "
                resultado = Val(TextBox1.Text) - Val(TextBox3.Text)
            Case 3
                TextBox2.Text = TextBox2.Text & " * "
                resultado = Val(TextBox1.Text) * Val(TextBox3.Text)
            Case 4
                TextBox2.Text = TextBox2.Text & " / "
                resultado = Val(TextBox1.Text) - Val(TextBox3.Text)
        End Select
    End Sub
    Public Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 90

    End Sub


    Public Sub dificultad()
        If RadioButton1.Enabled Then
            op1 = r.Next(0, 10)
            op2 = r.Next(0, 10)
            TextBox1.Text = op1
            TextBox3.Text = op2
            Me.operacion()

        ElseIf RadioButton2.Enabled Then
            op1 = r.Next(0, 50)
            op2 = r.Next(0, 50)
            TextBox1.Text = op1
            TextBox3.Text = op2
            Me.operacion()
        ElseIf RadioButton3.Enabled Then
            op1 = r.Next(0, 100)
            op2 = r.Next(0, 100)
            TextBox1.Text = op1
            TextBox3.Text = op2
            Me.operacion()
        End If


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox2.Visible = True
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        Timer1.Enabled = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        Label1.Visible = False
        TextBox4.Visible = False
        Label2.Visible = False
        ProgressBar1.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.Timer1.Enabled = True
        Me.Timer1.Start()
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        ProgressBar1.Visible = True
        Me.dificultad()
    End Sub

    Public Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick


        If cont < 101 Then
            ProgressBar1.Value = cont
            cont += 1
            Timer1.Enabled = True
            Timer1.Start()
        Else
            Timer1.Stop()
            Timer1.Enabled = False
            MessageBox.Show("Se ha terminado el tiempo!")
            GroupBox2.Visible = False
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = "0"
            ProgressBar1.Value = 0
            cont = 0
        End If





    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.Timer1.Enabled = True
        Me.Timer1.Start()
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        Label2.Visible = True
        Label1.Visible = True
        ProgressBar1.Visible = True
        Me.dificultad()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Me.Timer1.Enabled = True
        Me.Timer1.Start()
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        ProgressBar1.Visible = True
        Me.dificultad()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If Val(TextBox4.Text) = resultado Then
            Me.Timer1.Stop()
            MessageBox.Show("Es correcto")

        End If
    End Sub

    Private Sub ControlMental_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Button1.Enabled = True Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        Label2.Visible = False
        Label1.Visible = False
        ProgressBar1.Visible = False
    End Sub
End Class