
Public Class Form1
    Structure CustomerMessage
        Dim CustomerId As String
        Dim Password As String
        Dim Balance As Double
    End Structure
    Public IdBase(3) As CustomerMessage
    Public IdNumber As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        IdBase(0).CustomerId = "111111"
        IdBase(0).Password = "111111"
        IdBase(0).Balance = 40
        IdBase(1).CustomerId = "222222"
        IdBase(1).Password = "222222"
        IdBase(1).Balance = 30
        IdBase(2).CustomerId = "333333"
        IdBase(2).Password = "333333"
        IdBase(2).Balance = 20
        IdBase(3).CustomerId = "444444"
        IdBase(3).Password = "444444"
        IdBase(3).Balance = 10
        lblOpeningHours.BackColor = Color.Transparent
        lblWelcome.BackColor = Color.Transparent
        lblId.BackColor = Color.Transparent
        lblPassword.BackColor = Color.Transparent
    End Sub

    '用户登录
    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim userId As String
        Dim userPassword As String
        userId = txtId.Text
        userPassword = txtPassword.Text
        Dim result, i As Integer
        result = 0
        If userId = "" Or userPassword = "" Then
            MessageBox.Show("用户名或密码不能为空，请重新输入！")
        Else
            For i = 0 To 3
                If userId = IdBase(i).CustomerId And userPassword = IdBase(i).Password Then
                    result = 1
                    IdNumber = i
                End If
            Next
            If result = 1 Then
                MessageBox.Show("登录成功！")
                OrderingSystem.Show()
                Me.Hide()
            Else
                MessageBox.Show("用户名或密码错误，请重新输入！")
            End If
        End If

    End Sub

End Class
