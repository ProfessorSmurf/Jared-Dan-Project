Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadmin.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub formstart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnguest.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
