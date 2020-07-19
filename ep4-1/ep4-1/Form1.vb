Public Class Form1
    Dim Point, Grtade As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Point, Grade As String
        Point = TextBox1.Text
        If Point >= 80 Then
            Grade = "A"
        ElseIf Point >= 70 Then
            Grade = "B"
        ElseIf Point >= 60 Then
            Grade = "c"
        ElseIf Point >= 50 Then
            Grade = "D"
        Else
            Grade = "F"
        End If
        Label3.Text = Grade
    End Sub
End Class
