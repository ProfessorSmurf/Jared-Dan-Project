Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub formstart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnguest.Click
        Form3.Show()
        Form3.Label1.Text = "You're logged in as Guest"
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
