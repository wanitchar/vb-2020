﻿Public Class Form1
    Dim num1, num2, Result As Double
    Dim stamp As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        Result = num1 * num2
        Stamp = Result / 50
        Label5.Text = Result
        Label6.Text = Stamp
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
