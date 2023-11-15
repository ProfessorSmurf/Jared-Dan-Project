Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BlueHouseAppartmentDataSet.tbl_boarders' table. You can move, or remove it, as needed.
        Me.Tbl_boardersTableAdapter.Fill(Me.BlueHouseAppartmentDataSet.tbl_boarders)
        If Form3.Label1.Text = "You're logged in as Administrator" Then

        Else
            btnadd.Hide()
            btnedit.Hide()
            btndelete.Hide()
        End If
    End Sub
End Class