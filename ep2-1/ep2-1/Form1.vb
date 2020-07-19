Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Label3.Text
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Firstname As String
        Firstname = "wanitchar"
        Label1.Text = Firstname
        Firstname = "makthepwong"
        Label3.Text = Firstname
        Firstname = "guitar"
        Label2.Text = Firstname

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prompt, FullName As String
        prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(prompt)
        Label1.Text = FullName
        prompt = "กรุณาป้อนชื่อเล่น"
        FullName = InputBox(prompt)
        Label2.Text = FullName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prompt, FullName As String
        prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(prompt)
        MsgBox(FullName, , "ชื่อและนามสกุลของคุณ")
    End Sub
End Class
