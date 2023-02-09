Imports MySql.Data.MySqlClient
Public Class FormMasterAnggota
    Sub bersih()
        Call tampildata()
        TextBoxNIS.Text = ""
        TextBoxNama.Text = ""
        TextBoxNoHp.Text = ""
        ComboBoxKelas.Text = ""
        ComboBoxKelamin.Text = ""
        ComboBoxKelas.Items.Clear()
        ComboBoxKelamin.Items.Clear()
        ComboBoxKelas.Items.Add("10")
        ComboBoxKelas.Items.Add("11")
        ComboBoxKelas.Items.Add("12")
        ComboBoxKelamin.Items.Add("Laki-Laki")
        ComboBoxKelamin.Items.Add("Perempuan")
    End Sub
    Sub tampildata()
        Call koneksi()
        da = New MySqlDataAdapter("select * from tbl_siswa", con)
        ds = New DataSet
        da.Fill(ds, "tbl_siswa")
        DataGridView1.DataSource = (ds.Tables("tbl_siswa"))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub FormMasterAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bersih()
        TextBoxNIS.MaxLength = 4
        TextBoxNoHp.MaxLength = 13
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxNIS.Text = "" Or TextBoxNama.Text = "" Or ComboBoxKelas.Text = "" Or ComboBoxKelamin.Text = "" Or TextBoxNoHp.Text = "" Then
            MsgBox("Data Tidak Lengkap")
        Else
            Call koneksi()
            Dim simpandata As String = "Insert into tbl_siswa values('" & TextBoxNIS.Text & "','" & TextBoxNama.Text & "','" & ComboBoxKelas.Text & "','" & ComboBoxKelamin.Text & "','" & TextBoxNoHp.Text & "')"
            cmd = New MySqlCommand(simpandata, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil disimpan")
            Call bersih()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBoxNIS.Text = "" Or TextBoxNama.Text = "" Or ComboBoxKelas.Text = "" Or ComboBoxKelamin.Text = "" Or TextBoxNoHp.Text = "" Then
            MsgBox("Data Tidak Lengkap")
        Else
            Call koneksi()
            Dim editdata As String = "update tbl_siswa set NamaAnggota='" & TextBoxNama.Text & "',NoHp='" & TextBoxNoHp.Text & "',Kelas='" & ComboBoxKelas.Text & "',JenisKelamin='" & ComboBoxKelamin.Text & "' where NIS='" & TextBoxNIS.Text & "'"
            cmd = New MySqlCommand(editdata, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil diedit")
            Call bersih()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim klikmuncul
        klikmuncul = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBoxNIS.Text = klikmuncul
        TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ComboBoxKelas.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        ComboBoxKelamin.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBoxNoHp.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBoxNIS.Text = "" Or TextBoxNama.Text = "" Or ComboBoxKelas.Text = "" Or ComboBoxKelamin.Text = "" Or TextBoxNoHp.Text = "" Then
            MsgBox("Data Tidak Lengkap")
        Else
            Call koneksi()
            Dim hapusdata As String = "delete from tbl_siswa where NIS = '" & Me.TextBoxNIS.Text & "'"
            cmd = New MySqlCommand(hapusdata, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil dihapus")
            Call bersih()
        End If
    End Sub
End Class