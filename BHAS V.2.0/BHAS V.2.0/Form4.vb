Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BlueHouseAppartmentDataSet3.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.BlueHouseAppartmentDataSet3.Table)
        'TODO: This line of code loads data into the 'BlueHouseAppartmentDataSet.tbl_boarders' table. You can move, or remove it, as needed.
        Me.Tbl_boardersTableAdapter.Fill(Me.BlueHouseAppartmentDataSet.tbl_boarders)
        If Form3.Label1.Text = "You're logged in as Administrator" Then

        Else
            btnadd.Hide()
            btnedit.Hide()
            btndelete.Hide()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class