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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTambah))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rJamKeempat = New System.Windows.Forms.RadioButton()
        Me.rJamKetiga = New System.Windows.Forms.RadioButton()
        Me.rJamKedua = New System.Windows.Forms.RadioButton()
        Me.rJamPertama = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bPilihJenisTiket = New System.Windows.Forms.Button()
        Me.dTanggal = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cGenre = New System.Windows.Forms.ComboBox()
        Me.lExit = New System.Windows.Forms.Label()
        Me.bClear = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cHari = New System.Windows.Forms.ComboBox()
        Me.tJudul = New System.Windows.Forms.TextBox()
        Me.tPemain = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.bPilihJenisTiket)
        Me.Panel1.Controls.Add(Me.dTanggal)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.cGenre)
        Me.Panel1.Controls.Add(Me.lExit)
        Me.Panel1.Controls.Add(Me.bClear)
        Me.Panel1.Controls.Add(Me.bSimpan)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cHari)
        Me.Panel1.Controls.Add(Me.tJudul)
        Me.Panel1.Controls.Add(Me.tPemain)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rJamKeempat)
        Me.GroupBox1.Controls.Add(Me.rJamKetiga)
        Me.GroupBox1.Controls.Add(Me.rJamKedua)
        Me.GroupBox1.Controls.Add(Me.rJamPertama)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(72, 272)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(178, 138)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jam Pertunjukan"
        '
        'rJamKeempat
        '
        Me.rJamKeempat.AutoSize = True
        Me.rJamKeempat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rJamKeempat.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rJamKeempat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.rJamKeempat.Location = New System.Drawing.Point(11, 103)
        Me.rJamKeempat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamKeempat.Name = "rJamKeempat"
        Me.rJamKeempat.Size = New System.Drawing.Size(153, 24)
        Me.rJamKeempat.TabIndex = 38
        Me.rJamKeempat.TabStop = True
        Me.rJamKeempat.Text = "21.00 - 23.00 WITA"
        Me.rJamKeempat.UseVisualStyleBackColor = True
        '
        'rJamKetiga
        '
        Me.rJamKetiga.AutoSize = True
        Me.rJamKetiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rJamKetiga.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rJamKetiga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.rJamKetiga.Location = New System.Drawing.Point(11, 76)
        Me.rJamKetiga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamKetiga.Name = "rJamKetiga"
        Me.rJamKetiga.Size = New System.Drawing.Size(153, 24)
        Me.rJamKetiga.TabIndex = 37
        Me.rJamKetiga.TabStop = True
        Me.rJamKetiga.Text = "17.00 - 20.00 WITA"
        Me.rJamKetiga.UseVisualStyleBackColor = True
        '
        'rJamKedua
        '
        Me.rJamKedua.AutoSize = True
        Me.rJamKedua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rJamKedua.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rJamKedua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.rJamKedua.Location = New System.Drawing.Point(11, 45)
        Me.rJamKedua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamKedua.Name = "rJamKedua"
        Me.rJamKedua.Size = New System.Drawing.Size(153, 24)
        Me.rJamKedua.TabIndex = 36
        Me.rJamKedua.TabStop = True
        Me.rJamKedua.Text = "14.00 - 16.00 WITA"
        Me.rJamKedua.UseVisualStyleBackColor = True
        '
        'rJamPertama
        '
        Me.rJamPertama.AutoSize = True
        Me.rJamPertama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rJamPertama.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rJamPertama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.rJamPertama.Location = New System.Drawing.Point(11, 15)
        Me.rJamPertama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamPertama.Name = "rJamPertama"
        Me.rJamPertama.Size = New System.Drawing.Size(153, 24)
        Me.rJamPertama.TabIndex = 35
        Me.rJamPertama.TabStop = True
        Me.rJamPertama.Text = "10.00 - 12.00 WITA"
        Me.rJamPertama.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(295, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 18)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Genre Teater"
        '
        'bPilihJenisTiket
        '
        Me.bPilihJenisTiket.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bPilihJenisTiket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bPilihJenisTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPilihJenisTiket.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPilihJenisTiket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bPilihJenisTiket.Location = New System.Drawing.Point(299, 334)
        Me.bPilihJenisTiket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bPilihJenisTiket.Name = "bPilihJenisTiket"
        Me.bPilihJenisTiket.Size = New System.Drawing.Size(207, 38)
        Me.bPilihJenisTiket.TabIndex = 94
        Me.bPilihJenisTiket.Text = "Pilih Jenis Tiket"
        Me.bPilihJenisTiket.UseVisualStyleBackColor = False
        '
        'dTanggal
        '
        Me.dTanggal.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dTanggal.Location = New System.Drawing.Point(72, 230)
        Me.dTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dTanggal.Name = "dTanggal"
        Me.dTanggal.Size = New System.Drawing.Size(178, 22)
        Me.dTanggal.TabIndex = 93
        Me.dTanggal.Value = New Date(2023, 5, 15, 20, 35, 0, 0)
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
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(68, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(255, 18)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Tanggal Pertunjukan"
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
        'cGenre
        '
        Me.cGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cGenre.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cGenre.FormattingEnabled = True
        Me.cGenre.IntegralHeight = False
        Me.cGenre.Items.AddRange(New Object() {"Drama", "Komedi", "Musikal", "Tragedi"})
        Me.cGenre.Location = New System.Drawing.Point(299, 224)
        Me.cGenre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cGenre.Name = "cGenre"
        Me.cGenre.Size = New System.Drawing.Size(208, 31)
        Me.cGenre.TabIndex = 88
        '
        'lExit
        '
        Me.lExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lExit.Location = New System.Drawing.Point(512, 4)
        Me.lExit.Name = "lExit"
        Me.lExit.Size = New System.Drawing.Size(133, 42)
        Me.lExit.TabIndex = 82
        Me.lExit.Text = "x"
        '
        'bClear
        '
        Me.bClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClear.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bClear.Location = New System.Drawing.Point(72, 500)
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
        Me.bSimpan.Location = New System.Drawing.Point(72, 441)
        Me.bSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(434, 38)
        Me.bSimpan.TabIndex = 41
        Me.bSimpan.Text = "Simpan"
        Me.bSimpan.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(295, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 18)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Hari"
        '
        'cHari
        '
        Me.cHari.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cHari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cHari.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cHari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cHari.FormattingEnabled = True
        Me.cHari.IntegralHeight = False
        Me.cHari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"})
        Me.cHari.Location = New System.Drawing.Point(299, 281)
        Me.cHari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cHari.Name = "cHari"
        Me.cHari.Size = New System.Drawing.Size(208, 31)
        Me.cHari.TabIndex = 39
        '
        'tJudul
        '
        Me.tJudul.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tJudul.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tJudul.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJudul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tJudul.Location = New System.Drawing.Point(72, 89)
        Me.tJudul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tJudul.Name = "tJudul"
        Me.tJudul.Size = New System.Drawing.Size(434, 22)
        Me.tJudul.TabIndex = 26
        '
        'tPemain
        '
        Me.tPemain.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tPemain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tPemain.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPemain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tPemain.Location = New System.Drawing.Point(72, 162)
        Me.tPemain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPemain.Name = "tPemain"
        Me.tPemain.Size = New System.Drawing.Size(434, 22)
        Me.tPemain.TabIndex = 27
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
        Me.Label3.Text = "Pemain"
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
        'formTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1100, 570)
        Me.ControlBox = False
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tPemain As TextBox
    Friend WithEvents tJudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cHari As ComboBox
    Friend WithEvents bSimpan As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bClear As Button
    Friend WithEvents lExit As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cGenre As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents bPilihJenisTiket As Button
    Friend WithEvents dTanggal As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rJamKeempat As RadioButton
    Friend WithEvents rJamKetiga As RadioButton
    Friend WithEvents rJamKedua As RadioButton
    Friend WithEvents rJamPertama As RadioButton
End Class
