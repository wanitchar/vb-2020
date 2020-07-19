Public Class Form1
    Dim Username As String
    Dim Password As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String

        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาป้อนรหัสผ่านของคุณ")
        If Username = "นุ๊กเน็ต" And Password = "1234" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-07\Downloads\All_Images\All_Images\kid02.jpg")
        ElseIf Username = "กีต้าร์" And Password = "4567" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-07\Downloads\All_Images\All_Images\photo05.jpg")
        ElseIf Username = "คิง" And Password = "8910" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-07\Downloads\All_Images\All_Images\kid03.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
