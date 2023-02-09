<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxKodeBuku = New System.Windows.Forms.TextBox()
        Me.TextBoxJudul = New System.Windows.Forms.TextBox()
        Me.TextBoxPenulis = New System.Windows.Forms.TextBox()
        Me.TextBoxPenerbit = New System.Windows.Forms.TextBox()
        Me.TextBoxTahun = New System.Windows.Forms.TextBox()
        Me.TextBoxJumlah = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PROGRAM_PERPUSTAKAAN.My.Resources.Resources.BACK
        Me.PictureBox2.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(229, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 26)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "YAYASAN KEMBAR KARYA 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 26)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "MASTER BUKU PERPUSTAKAAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROGRAM_PERPUSTAKAAN.My.Resources.Resources.buku2
        Me.PictureBox1.Location = New System.Drawing.Point(97, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 286)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Buku"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(388, 252)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBoxJumlah)
        Me.GroupBox3.Controls.Add(Me.TextBoxTahun)
        Me.GroupBox3.Controls.Add(Me.TextBoxPenerbit)
        Me.GroupBox3.Controls.Add(Me.TextBoxPenulis)
        Me.GroupBox3.Controls.Add(Me.TextBoxJudul)
        Me.GroupBox3.Controls.Add(Me.TextBoxKodeBuku)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.ButtonDelete)
        Me.GroupBox3.Controls.Add(Me.ButtonEdit)
        Me.GroupBox3.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(418, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 286)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Input Data Buku"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 21)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tahun"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDelete.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Image = Global.PROGRAM_PERPUSTAKAAN.My.Resources.Resources.DELETE_removebg_preview
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(255, 238)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(109, 42)
        Me.ButtonDelete.TabIndex = 12
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEdit.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.Image = Global.PROGRAM_PERPUSTAKAAN.My.Resources.Resources.EDIT
        Me.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEdit.Location = New System.Drawing.Point(135, 238)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(109, 42)
        Me.ButtonEdit.TabIndex = 11
        Me.ButtonEdit.Text = "EDIT"
        Me.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSimpan.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.Image = Global.PROGRAM_PERPUSTAKAAN.My.Resources.Resources.save2
        Me.ButtonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSimpan.Location = New System.Drawing.Point(11, 238)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(109, 42)
        Me.ButtonSimpan.TabIndex = 10
        Me.ButtonSimpan.Text = "SIMPAN"
        Me.ButtonSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 21)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Penerbit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Penulis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Judul Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Kode Buku"
        '
        'TextBoxKodeBuku
        '
        Me.TextBoxKodeBuku.Location = New System.Drawing.Point(102, 35)
        Me.TextBoxKodeBuku.Multiline = True
        Me.TextBoxKodeBuku.Name = "TextBoxKodeBuku"
        Me.TextBoxKodeBuku.Size = New System.Drawing.Size(121, 27)
        Me.TextBoxKodeBuku.TabIndex = 152
        '
        'TextBoxJudul
        '
        Me.TextBoxJudul.Location = New System.Drawing.Point(101, 68)
        Me.TextBoxJudul.Multiline = True
        Me.TextBoxJudul.Name = "TextBoxJudul"
        Me.TextBoxJudul.Size = New System.Drawing.Size(263, 27)
        Me.TextBoxJudul.TabIndex = 153
        '
        'TextBoxPenulis
        '
        Me.TextBoxPenulis.Location = New System.Drawing.Point(102, 101)
        Me.TextBoxPenulis.Multiline = True
        Me.TextBoxPenulis.Name = "TextBoxPenulis"
        Me.TextBoxPenulis.Size = New System.Drawing.Size(263, 27)
        Me.TextBoxPenulis.TabIndex = 154
        '
        'TextBoxPenerbit
        '
        Me.TextBoxPenerbit.Location = New System.Drawing.Point(101, 135)
        Me.TextBoxPenerbit.Multiline = True
        Me.TextBoxPenerbit.Name = "TextBoxPenerbit"
        Me.TextBoxPenerbit.Size = New System.Drawing.Size(263, 27)
        Me.TextBoxPenerbit.TabIndex = 155
        '
        'TextBoxTahun
        '
        Me.TextBoxTahun.Location = New System.Drawing.Point(101, 169)
        Me.TextBoxTahun.Multiline = True
        Me.TextBoxTahun.Name = "TextBoxTahun"
        Me.TextBoxTahun.Size = New System.Drawing.Size(88, 27)
        Me.TextBoxTahun.TabIndex = 156
        '
        'TextBoxJumlah
        '
        Me.TextBoxJumlah.Location = New System.Drawing.Point(101, 199)
        Me.TextBoxJumlah.Multiline = True
        Me.TextBoxJumlah.Name = "TextBoxJumlah"
        Me.TextBoxJumlah.Size = New System.Drawing.Size(88, 27)
        Me.TextBoxJumlah.TabIndex = 157
        '
        'FormMasterBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormMasterBuku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMasterBuku"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents TextBoxTahun As TextBox
    Friend WithEvents TextBoxPenerbit As TextBox
    Friend WithEvents TextBoxPenulis As TextBox
    Friend WithEvents TextBoxJudul As TextBox
    Friend WithEvents TextBoxKodeBuku As TextBox
End Class
