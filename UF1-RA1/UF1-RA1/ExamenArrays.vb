﻿Public Class ExamenArrays
    Dim tabla(49, 49) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j As Integer
        Dim r As New Random()
        Dim salida As String = ""
        For i = 0 To 49
            For j = 0 To 49
                tabla(i, j) = r.Next(0, 100) 'random entre 0 y 100
                salida = salida + tabla(i, j).ToString + "  "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, j As Integer

        Dim salida As String = ""

        For i = 0 To 49
            For j = 0 To 49
                If j = 4 Then
                    tabla(i, j) = 0
                End If
                salida = salida + tabla(i, j).ToString + "  "
            Next
            salida = salida + vbNewLine
        Next
        MessageBox.Show(salida)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i, j As Integer
        Dim mayor As Integer

        mayor = tabla(0, 0)
        For i = 0 To 49
            For j = 0 To 49

                If tabla(i, j) > mayor Then
                    mayor = tabla(i, j)
                End If

            Next
        Next
        MessageBox.Show(mayor)
    End Sub
End Class