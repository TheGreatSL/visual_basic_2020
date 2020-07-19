Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Label1.Text
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String
        FirstName = "Kanniga"
        Label1.Text = FirstName
        FirstName = "Saelek"
        Label2.Text = FirstName
        FirstName = "Great"
        Label3.Text = FirstName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(Prompt)
        Label1.Text = FullName
        MsgBox(FullName, , "ชื่อเล่นของคุณ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(Prompt)
        Label1.Text = FullName
        Prompt = "กรุณาป้อนชื่อเล่น"
        FullName = InputBox(Prompt)
        Label3.Text = FullName
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อเล่น"
        FullName = InputBox(Prompt)
        MsgBox(FullName, , "ชื่อเล่นของคุณ")
    End Sub
End Class
