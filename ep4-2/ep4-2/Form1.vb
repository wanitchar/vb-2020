Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        If Username = "นุ๊กเน็ต" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-07\Downloads\All_Images\All_Images\kid02.jpg")
        ElseIf Username = "กีต้าร์" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-07\Downloads\All_Images\All_Images\photo05.jpg")
        ElseIf Username = "คิง" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-07\Downloads\All_Images\All_Images\kid03.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
