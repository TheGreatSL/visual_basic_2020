Public Class Form1
    Dim num1, num2, num11, Result, Result1 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        num11 = TextBox4.Text
        Result = num1 * num2
        Result1 = num11 - Result
        TextBox3.Text = Result
        TextBox5.Text = Result1

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class