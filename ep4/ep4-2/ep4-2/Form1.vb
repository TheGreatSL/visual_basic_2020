Public Class Form1
    Dim Username As String
    Dim Password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาป้อนรหัสของคุณ")
        If Username = "นุ๊กเน็ต" And Password = "1111" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-13\Pictures\thegreat\All_Images\ChaiYo.jpg")
        ElseIf Username = "แพนด้า" And Password = "2222" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-13\Pictures\thegreat\All_Images\Panda_48x48.png")
        ElseIf Username = "ช้าง" And Password = "3333" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-13\Pictures\thegreat\All_Images\Elephant_48x48.png")
        Else
            MsgBox("ไม่มีชื่อคุณอยูในระบบ")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
