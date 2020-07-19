Public Class Form1
    Dim FirstNum, SecondNum, Result As Double
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FirstNum = TextBox1.Text
        SecondNum = TextBox2.Text
        If RadioButton1.Checked = True Then
            Result = FirstNum + SecondNum
        ElseIf RadioButton2.Checked Then
            Result = FirstNum - SecondNum
        ElseIf RadioButton3.Checked Then
            Result = FirstNum * SecondNum
        ElseIf RadioButton4.Checked Then
            Result = FirstNum / SecondNum
        ElseIf RadioButton5.Checked Then
            Result = FirstNum ^ SecondNum
        End If
        TextBox3.Text = Result
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
