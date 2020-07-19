Public Class Form1
    Dim Username As String
    Dim Password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาใส่รหัสผ่านของคุณ")
        If Username = "นุ๊กเน็ต" And Password = "1111" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-13\Pictures\thegreat\All_Images\ChaiYo.jpg")
        ElseIf Username = "ช้าง" And Password = "2222" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-13\Pictures\thegreat\All_Images\Elephant_48x48.png")
        ElseIf Username = "ฮิปโป" And Password = "3333" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-13\Pictures\thegreat\All_Images\Hippopotamus_48x48.png")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
