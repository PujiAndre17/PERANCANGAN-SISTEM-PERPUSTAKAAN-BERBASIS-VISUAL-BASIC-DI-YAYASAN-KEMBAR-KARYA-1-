Imports MySql.Data.MySqlClient
Public Class FormMasterBuku
    Sub bersih()
        Call tampildata()
        TextBoxKodeBuku.Text = ""
        TextBoxJudul.Text = ""
        TextBoxPenerbit.Text = ""
        TextBoxPenulis.Text = ""
        TextBoxJumlah.Text = ""
        TextBoxTahun.Text = ""
    End Sub
    Sub tampildata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_buku", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_buku")
        DataGridView1.DataSource = (ds.Tables("tbl_buku"))
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
    Private Sub FormMasterBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        TextBoxKodeBuku.MaxLength = 6
        TextBoxJumlah.MaxLength = 2
        TextBoxTahun.MaxLength = 4
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim klikmuncul
        klikmuncul = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBoxKodeBuku.Text = klikmuncul
        TextBoxJudul.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBoxPenulis.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        TextBoxPenerbit.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBoxTahun.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBoxJumlah.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        If TextBoxKodeBuku.Text = "" Or TextBoxJudul.Text = "" Or TextBoxPenulis.Text = "" Or TextBoxPenerbit.Text = "" Or TextBoxTahun.Text = "" Or TextBoxJumlah.Text = "" Then
            MsgBox("Data belum lengkap")
        Else
            Call koneksi()
            Dim simpandata As String = "Insert into tbl_buku values('" & TextBoxKodeBuku.Text & "','" & TextBoxJudul.Text & "','" & TextBoxPenulis.Text & "','" & TextBoxPenerbit.Text & "','" & TextBoxTahun.Text & "','" & TextBoxJumlah.Text & "')"
            cmd = New MySqlCommand(simpandata, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil disimpan")
            Call bersih()
        End If
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        If TextBoxKodeBuku.Text = "" Or TextBoxJudul.Text = "" Or TextBoxPenulis.Text = "" Or TextBoxPenerbit.Text = "" Or TextBoxTahun.Text = "" Or TextBoxJumlah.Text = "" Then
            MsgBox("Data belum lengkap")
        Else
            Call koneksi()
            Dim editdata As String = "update tbl_buku set JudulBuku='" & TextBoxJudul.Text & "',Penulis='" & TextBoxPenulis.Text & "',Penerbit='" & TextBoxPenerbit.Text & "',Tahun='" & TextBoxTahun.Text & "',StokBuku='" & TextBoxJumlah.Text & "' where KodeBuku='" & TextBoxKodeBuku.Text & "'"
            cmd = New MySqlCommand(editdata, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil diedit")
            Call bersih()
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If TextBoxKodeBuku.Text = "" Or TextBoxJudul.Text = "" Or TextBoxPenulis.Text = "" Or TextBoxPenerbit.Text = "" Or TextBoxTahun.Text = "" Or TextBoxJumlah.Text = "" Then
            MsgBox("Data belum lengkap")
        Else
            Call koneksi()
            Dim hapusdata As String = "delete from tbl_buku where KodeBuku = '" & Me.TextBoxKodeBuku.Text & "'"
            cmd = New MySqlCommand(hapusdata, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil dihapus")
            Call bersih()
        End If
    End Sub
End Class