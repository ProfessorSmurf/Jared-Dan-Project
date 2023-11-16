Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = "" Then
            MessageBox.Show("Username is Missing")
        ElseIf txtuser.Text = "" And txtpass.Text = "" Then
            MessageBox.Show("Username and Password is Missing")
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Password is Missing")
        ElseIf txtuser.Text = "admin" And txtpass.Text = "admin" Then
            Form3.Show()
            Form3.Label1.Text = "You're logged in as Administrator"
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txtuser.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        checkboxpass.Parent = PictureBox1
        checkboxpass.BackColor = Color.Transparent

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class