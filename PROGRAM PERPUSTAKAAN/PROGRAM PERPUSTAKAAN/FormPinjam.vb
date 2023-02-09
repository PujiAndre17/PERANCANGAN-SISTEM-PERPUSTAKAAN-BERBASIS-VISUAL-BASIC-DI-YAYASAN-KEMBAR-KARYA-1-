Imports MySql.Data.MySqlClient
Public Class FormPinjam
    Sub bersih()
        Call tampildata()
        Call nomor()
        TextBoxKodeBuku.Text = ""
        TextBoxNIS.Text = ""
        TextBoxJumlah.Text = ""
        TextBoxPetugas.Text = FormLogin.TextBox1.Text
        TextBoxTGL.Text = Today
        TextBoxKodePinjam.Enabled = False
        TextBoxTgl.Enabled = False
        TextBoxPetugas.Enabled = False
    End Sub
    Sub tampildata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_pinjam", con)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_pinjam")
        DataGridView1.DataSource = (ds.Tables("tbl_pinjam"))
    End Sub
    Sub nomor()
        Dim DR As DataRow
        Dim otomatis As String
        DR = SQLTable("select max(right(KodePinjam,1)) as nomor from tbl_pinjam").Rows(0)
        If DR.IsNull("Nomor") Then
            otomatis = "PJM01"
        Else
            otomatis = "PJM0" & Format(DR("Nomor") + 1, "0")
        End If
        TextBoxKodePinjam.Text = otomatis
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub FormPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxKodeBuku.Text = "" Or TextBoxNIS.Text = "" Then
            MsgBox("Pastikan data terisi")
        Else
            Call koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            TextBoxTgl.Text = tglsql
            Dim pinjambuku As String = "insert into tbl_pinjam values('" & TextBoxKodePinjam.Text & "','" & TextBoxKodeBuku.Text & "','" & TextBoxNIS.Text & "','" & TextBoxJumlah.Text & "','" & tglsql & "','" & TextBoxPetugas.Text & "')"
            cmd = New MySqlCommand(pinjambuku, con)
            cmd.ExecuteNonQuery()
            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call koneksi()
                cmd = New MySqlCommand("Select * from tbl_buku where KodeBuku='" & DataGridView1.Rows(baris).Cells(1).Value & "'", con)
                rd = cmd.ExecuteReader
                rd.Read()
                'Call koneksi()
                'Dim stokberkurang As String = "Update tbl_buku set StokBuku ='" & rd.Item("StokBuku") - DataGridView1.Rows(baris).Cells(3).Value & "' where KodeBuku='" & DataGridView1.Rows(baris).Cells(1).Value & "'"
                'cmd = New MySqlCommand(stokberkurang, con)
                'cmd.ExecuteNonQuery()
            Next
            Call bersih()
            MsgBox("Peminjaman Berhasil disimpan")
        End If
    End Sub


End Class