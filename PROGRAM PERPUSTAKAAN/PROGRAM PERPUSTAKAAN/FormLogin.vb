Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Pastikan data terisi semua")
            Else
                Call koneksi()
                cmd = New MySqlCommand("Select * From login where Kode='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'", con)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    If rd("status").ToString = "Admin" Then
                        FormMenuUtama.Show()
                        Me.Hide()
                    Else
                        FormUser.Show()
                        Me.Hide()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        Call koneksi()
        cmd = New MySqlCommand("Select * From tbl_petugas where KodePetugas='" & TextBox1.Text & "' and PasswordPetugas='" & TextBox2.Text & "'", con)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            FormMenuUtama.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
