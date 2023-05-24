<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTambah
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTambah))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tHari = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cGenre = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bPilihGambarTiket = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gJam = New System.Windows.Forms.GroupBox()
        Me.rJamKedua = New System.Windows.Forms.RadioButton()
        Me.rJamPertama = New System.Windows.Forms.RadioButton()
        Me.tHargaTiket = New System.Windows.Forms.TextBox()
        Me.x = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tTiket = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.tJudul = New System.Windows.Forms.TextBox()
        Me.tKelompok = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pKembali = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.gJam.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Stencil", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(110, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 40)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tambah Jadwal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dTanggal)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tHari)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cGenre)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.bPilihGambarTiket)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.gJam)
        Me.Panel1.Controls.Add(Me.tHargaTiket)
        Me.Panel1.Controls.Add(Me.x)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tTiket)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.bClear)
        Me.Panel1.Controls.Add(Me.bSimpan)
        Me.Panel1.Controls.Add(Me.tJudul)
        Me.Panel1.Controls.Add(Me.tKelompok)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(528, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 570)
        Me.Panel1.TabIndex = 24
        '
        'dTanggal
        '
        Me.dTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTanggal.Location = New System.Drawing.Point(72, 230)
        Me.dTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dTanggal.Name = "dTanggal"
        Me.dTanggal.Size = New System.Drawing.Size(178, 22)
        Me.dTanggal.TabIndex = 105
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(68, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 18)
        Me.Label11.TabIndex = 104
        Me.Label11.Text = "Tanggal Pertunjukan"
        '
        'tHari
        '
        Me.tHari.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tHari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tHari.Enabled = False
        Me.tHari.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tHari.Location = New System.Drawing.Point(301, 230)
        Me.tHari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tHari.Name = "tHari"
        Me.tHari.Size = New System.Drawing.Size(192, 22)
        Me.tHari.TabIndex = 102
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(293, 222)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 38)
        Me.Button1.TabIndex = 103
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(286, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = " Tiket"
        '
        'cGenre
        '
        Me.cGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cGenre.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cGenre.FormattingEnabled = True
        Me.cGenre.IntegralHeight = False
        Me.cGenre.Items.AddRange(New Object() {"Drama", "Komedi", "Musikal"})
        Me.cGenre.Location = New System.Drawing.Point(293, 292)
        Me.cGenre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cGenre.Name = "cGenre"
        Me.cGenre.Size = New System.Drawing.Size(214, 31)
        Me.cGenre.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(290, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 18)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Genre Teater"
        '
        'bPilihGambarTiket
        '
        Me.bPilihGambarTiket.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bPilihGambarTiket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bPilihGambarTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPilihGambarTiket.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPilihGambarTiket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bPilihGambarTiket.Image = CType(resources.GetObject("bPilihGambarTiket.Image"), System.Drawing.Image)
        Me.bPilihGambarTiket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bPilihGambarTiket.Location = New System.Drawing.Point(72, 382)
        Me.bPilihGambarTiket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bPilihGambarTiket.Name = "bPilihGambarTiket"
        Me.bPilihGambarTiket.Size = New System.Drawing.Size(178, 38)
        Me.bPilihGambarTiket.TabIndex = 96
        Me.bPilihGambarTiket.Text = "    Pilih Gambar"
        Me.bPilihGambarTiket.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(290, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Harga"
        '
        'gJam
        '
        Me.gJam.Controls.Add(Me.rJamKedua)
        Me.gJam.Controls.Add(Me.rJamPertama)
        Me.gJam.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gJam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.gJam.Location = New System.Drawing.Point(72, 269)
        Me.gJam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gJam.Name = "gJam"
        Me.gJam.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gJam.Size = New System.Drawing.Size(178, 98)
        Me.gJam.TabIndex = 95
        Me.gJam.TabStop = False
        Me.gJam.Text = "Jam Pertunjukan"
        '
        'rJamKedua
        '
        Me.rJamKedua.AutoSize = True
        Me.rJamKedua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rJamKedua.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rJamKedua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.rJamKedua.Location = New System.Drawing.Point(11, 68)
        Me.rJamKedua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamKedua.Name = "rJamKedua"
        Me.rJamKedua.Size = New System.Drawing.Size(153, 24)
        Me.rJamKedua.TabIndex = 36
        Me.rJamKedua.TabStop = True
        Me.rJamKedua.Text = "19.00 - 22.00 WITA"
        Me.rJamKedua.UseVisualStyleBackColor = True
        '
        'rJamPertama
        '
        Me.rJamPertama.AutoSize = True
        Me.rJamPertama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rJamPertama.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rJamPertama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.rJamPertama.Location = New System.Drawing.Point(11, 31)
        Me.rJamPertama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamPertama.Name = "rJamPertama"
        Me.rJamPertama.Size = New System.Drawing.Size(153, 24)
        Me.rJamPertama.TabIndex = 35
        Me.rJamPertama.TabStop = True
        Me.rJamPertama.Text = "13.00 - 16.00 WITA"
        Me.rJamPertama.UseVisualStyleBackColor = True
        '
        'tHargaTiket
        '
        Me.tHargaTiket.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tHargaTiket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tHargaTiket.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHargaTiket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tHargaTiket.Location = New System.Drawing.Point(301, 431)
        Me.tHargaTiket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tHargaTiket.MaxLength = 9
        Me.tHargaTiket.Name = "tHargaTiket"
        Me.tHargaTiket.Size = New System.Drawing.Size(142, 17)
        Me.tHargaTiket.TabIndex = 100
        Me.tHargaTiket.Text = "Rp"
        '
        'x
        '
        Me.x.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.x.Enabled = False
        Me.x.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.x.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.x.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.x.Location = New System.Drawing.Point(294, 424)
        Me.x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(212, 31)
        Me.x.TabIndex = 99
        Me.x.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(461, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 23)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "STOK"
        '
        'tTiket
        '
        Me.tTiket.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tTiket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTiket.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTiket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tTiket.Location = New System.Drawing.Point(304, 364)
        Me.tTiket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tTiket.MaxLength = 2
        Me.tTiket.Name = "tTiket"
        Me.tTiket.Size = New System.Drawing.Size(133, 17)
        Me.tTiket.TabIndex = 96
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(72, 230)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(178, 22)
        Me.TextBox4.TabIndex = 90
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button6.Enabled = False
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(295, 358)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(160, 31)
        Me.Button6.TabIndex = 95
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(289, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(255, 18)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Hari"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(72, 222)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(178, 38)
        Me.Button4.TabIndex = 92
        Me.Button4.UseVisualStyleBackColor = False
        '
        'bClear
        '
        Me.bClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClear.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bClear.Location = New System.Drawing.Point(72, 513)
        Me.bClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(434, 38)
        Me.bClear.TabIndex = 46
        Me.bClear.Text = "Clear"
        Me.bClear.UseVisualStyleBackColor = False
        '
        'bSimpan
        '
        Me.bSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bSimpan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSimpan.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSimpan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bSimpan.Location = New System.Drawing.Point(72, 471)
        Me.bSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(434, 38)
        Me.bSimpan.TabIndex = 41
        Me.bSimpan.Text = "Simpan"
        Me.bSimpan.UseVisualStyleBackColor = False
        '
        'tJudul
        '
        Me.tJudul.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tJudul.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tJudul.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJudul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tJudul.Location = New System.Drawing.Point(83, 89)
        Me.tJudul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tJudul.Name = "tJudul"
        Me.tJudul.Size = New System.Drawing.Size(411, 22)
        Me.tJudul.TabIndex = 26
        '
        'tKelompok
        '
        Me.tKelompok.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tKelompok.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tKelompok.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKelompok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tKelompok.Location = New System.Drawing.Point(83, 162)
        Me.tKelompok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tKelompok.Name = "tKelompok"
        Me.tKelompok.Size = New System.Drawing.Size(422, 22)
        Me.tKelompok.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(68, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 18)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Kelompok Teater"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(72, 81)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(434, 38)
        Me.Button2.TabIndex = 42
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(68, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 22)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Judul Teater"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(72, 154)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(434, 38)
        Me.Button3.TabIndex = 43
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(124, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(241, 59)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "equiter"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(69, 58)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(376, 342)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'pKembali
        '
        Me.pKembali.BackgroundImage = CType(resources.GetObject("pKembali.BackgroundImage"), System.Drawing.Image)
        Me.pKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pKembali.Location = New System.Drawing.Point(22, 513)
        Me.pKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(33, 28)
        Me.pKembali.TabIndex = 105
        Me.pKembali.TabStop = False
        '
        'formTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.pKembali)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "formTambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formTambah"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gJam.ResumeLayout(False)
        Me.gJam.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tKelompok As TextBox
    Friend WithEvents tJudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bSimpan As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bClear As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cGenre As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents gJam As GroupBox
    Friend WithEvents rJamKedua As RadioButton
    Friend WithEvents rJamPertama As RadioButton
    Friend WithEvents bPilihGambarTiket As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tHargaTiket As TextBox
    Friend WithEvents x As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tTiket As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents tHari As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents pKembali As PictureBox
    Friend WithEvents dTanggal As DateTimePicker
End Class
