Imports System.Diagnostics.Eventing.Reader

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtuser.Text = "" Then
            MessageBox.Show("Input Username!")
        ElseIf txtuser.Text = "" And txtpass.Text = "" Then
            MessageBox.Show("Username and Password is Incomplete")
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Input Password!")
        ElseIf txtuser.Text = "admin" And txtpass.Text = "admin" Then
            Form3.Show()
            Form3.Label1.Text = "You're logged in as Administrator"
            Me.Hide()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
        checkboxpass.Parent = PictureBox1
        checkboxpass.BackColor = Color.Transparent

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        txtpass.Clear()
        txtuser.Clear()
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub checkboxpass_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxpass.CheckedChanged
        If checkboxpass.Checked = True Then
            txtpass.UseSystemPasswordChar = False

        Else
            txtpass.UseSystemPasswordChar = True

        End If
    End Sub
End Class