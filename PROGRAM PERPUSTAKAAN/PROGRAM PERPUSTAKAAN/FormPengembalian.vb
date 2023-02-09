Imports MySql.Data.MySqlClient
Public Class FormPengembalian
    Sub bersih()
        Call tampildata()
        TextBoxKodePinjam.Text = ""
        TextBoxKodeBuku.Text = ""
        TextBoxNIS.Text = ""
        TextBoxLamaPinjam.Text = ""
        TextBoxDenda.Text = ""
        TextBoxJumlahPinjam.Text = ""
        TextBoxPetugas.Text = FormLogin.TextBox1.Text
        TextBoxTgl.Text = Today
        TextBoxJumlahPinjam.Enabled = False
        TextBoxKodeBuku.Enabled = False
        TextBoxNIS.Enabled = False
        TextBoxPetugas.Enabled = False
        TextBoxTgl.Enabled = False
        TextBoxDenda.Enabled = False
        TextBoxLamaPinjam.Enabled = False
    End Sub
    Sub tampildata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_kembali", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_kembali")
        DataGridView1.DataSource = (ds.Tables("tbl_kembali"))
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub FormPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        TextBoxKodePinjam.MaxLength = 5
    End Sub



    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        If TextBoxKodePinjam.Text = "" Then
            MsgBox("Pastikan data terisi")
        Else
            Call koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            TextBoxTgl.Text = tglsql
            Dim kembalibuku As String = "insert into tbl_kembali values('" & TextBoxKodePinjam.Text & "','" & TextBoxKodeBuku.Text & "','" & TextBoxNIS.Text & "','" & tglsql & "','" & TextBoxLamaPinjam.Text & "','" & TextBoxJumlahPinjam.Text & "','" & TextBoxDenda.Text & "','" & TextBoxPetugas.Text & "')"
            cmd = New MySqlCommand(kembalibuku, con)
            cmd.ExecuteNonQuery()
            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                'UpdateBuku
                Call koneksi()
                cmd = New MySqlCommand("Delete from tbl_pinjam where KodePinjam='" & TextBoxKodePinjam.Text & "'", con)
                rd = cmd.ExecuteReader
                rd.Read()
            Next
            Call bersih()
            MsgBox("Pengembalian Buku Berhasil disimpan")
        End If
    End Sub


    Private Sub TextBoxKodePinjam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxKodePinjam.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New MySqlCommand("Select * from tbl_pinjam where KodePinjam='" & TextBoxKodePinjam.Text & "'", con)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Kode Peminjaman Buku tidak ada")
            Else
                TextBoxKodeBuku.Text = rd.Item("KodeBuku")
                TextBoxNIS.Text = rd.Item("NIS")
                TextBoxPetugas.Text = rd.Item("Petugas")
                TextBoxTgl.Text = rd.Item("TglPinjam")
                TextBoxJumlahPinjam.Text = rd.Item("JumlahPinjam")
                TextBoxLamaPinjam.Text = DateDiff(DateInterval.Day, rd.Item("TglPinjam"), Today())
                If TextBoxLamaPinjam.Text > 7 Then
                    TextBoxDenda.Text = Val((TextBoxLamaPinjam.Text) - 7) * 1000
                Else
                    TextBoxDenda.Text = 0
                End If
            End If
        End If
    End Sub


End Class