Imports MySql.Data.MySqlClient
Public Class FormUser
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_buku", con)
        ds = New DataSet
        da.Fill(ds, "tbl_buku")
        DataGridView1.DataSource = (ds.Tables("tbl_buku"))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub
End Class