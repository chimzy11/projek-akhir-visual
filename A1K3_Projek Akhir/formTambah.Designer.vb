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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bPilihGambarTiket = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gJam = New System.Windows.Forms.GroupBox()
        Me.rJamKeempat = New System.Windows.Forms.RadioButton()
        Me.rJamKetiga = New System.Windows.Forms.RadioButton()
        Me.rJamKedua = New System.Windows.Forms.RadioButton()
        Me.rJamPertama = New System.Windows.Forms.RadioButton()
        Me.tHargaTiket = New System.Windows.Forms.TextBox()
        Me.x = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dTanggal = New System.Windows.Forms.DateTimePicker()
        Me.tTiket = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.gJam.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Stencil", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(124, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 50)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Tambah Jadwal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.bPilihGambarTiket)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.gJam)
        Me.Panel1.Controls.Add(Me.tHargaTiket)
        Me.Panel1.Controls.Add(Me.x)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dTanggal)
        Me.Panel1.Controls.Add(Me.tTiket)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Button6)
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
        Me.Panel1.Location = New System.Drawing.Point(594, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 712)
        Me.Panel1.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(326, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 22)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = " Tiket"
        '
        'bPilihGambarTiket
        '
        Me.bPilihGambarTiket.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bPilihGambarTiket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bPilihGambarTiket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPilihGambarTiket.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPilihGambarTiket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bPilihGambarTiket.Location = New System.Drawing.Point(81, 526)
        Me.bPilihGambarTiket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bPilihGambarTiket.Name = "bPilihGambarTiket"
        Me.bPilihGambarTiket.Size = New System.Drawing.Size(200, 48)
        Me.bPilihGambarTiket.TabIndex = 96
        Me.bPilihGambarTiket.Text = "Pilih Gambar Teater"
        Me.bPilihGambarTiket.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(331, 499)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 26)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Harga"
        '
        'gJam
        '
        Me.gJam.Controls.Add(Me.rJamKeempat)
        Me.gJam.Controls.Add(Me.rJamKetiga)
        Me.gJam.Controls.Add(Me.rJamKedua)
        Me.gJam.Controls.Add(Me.rJamPertama)
        Me.gJam.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gJam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.gJam.Location = New System.Drawing.Point(81, 336)
        Me.gJam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gJam.Name = "gJam"
        Me.gJam.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gJam.Size = New System.Drawing.Size(200, 176)
        Me.gJam.TabIndex = 95
        Me.gJam.TabStop = False
        Me.gJam.Text = "Jam Pertunjukan"
        '
        'rJamKeempat
        '
        Me.rJamKeempat.AutoSize = True
        Me.rJamKeempat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rJamKeempat.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rJamKeempat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.rJamKeempat.Location = New System.Drawing.Point(12, 139)
        Me.rJamKeempat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamKeempat.Name = "rJamKeempat"
        Me.rJamKeempat.Size = New System.Drawing.Size(176, 25)
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
        Me.rJamKetiga.Location = New System.Drawing.Point(12, 105)
        Me.rJamKetiga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamKetiga.Name = "rJamKetiga"
        Me.rJamKetiga.Size = New System.Drawing.Size(176, 25)
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
        Me.rJamKedua.Location = New System.Drawing.Point(12, 66)
        Me.rJamKedua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamKedua.Name = "rJamKedua"
        Me.rJamKedua.Size = New System.Drawing.Size(176, 25)
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
        Me.rJamPertama.Location = New System.Drawing.Point(12, 29)
        Me.rJamPertama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rJamPertama.Name = "rJamPertama"
        Me.rJamPertama.Size = New System.Drawing.Size(176, 25)
        Me.rJamPertama.TabIndex = 35
        Me.rJamPertama.TabStop = True
        Me.rJamPertama.Text = "10.00 - 12.00 WITA"
        Me.rJamPertama.UseVisualStyleBackColor = True
        '
        'tHargaTiket
        '
        Me.tHargaTiket.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tHargaTiket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tHargaTiket.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tHargaTiket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tHargaTiket.Location = New System.Drawing.Point(343, 537)
        Me.tHargaTiket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tHargaTiket.Name = "tHargaTiket"
        Me.tHargaTiket.Size = New System.Drawing.Size(128, 21)
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
        Me.x.Location = New System.Drawing.Point(336, 529)
        Me.x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(234, 39)
        Me.x.TabIndex = 99
        Me.x.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(332, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 22)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Genre Teater"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(523, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 29)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "STOK"
        '
        'dTanggal
        '
        Me.dTanggal.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.dTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dTanggal.Location = New System.Drawing.Point(81, 288)
        Me.dTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dTanggal.Name = "dTanggal"
        Me.dTanggal.Size = New System.Drawing.Size(200, 26)
        Me.dTanggal.TabIndex = 93
        Me.dTanggal.Value = New Date(2023, 5, 15, 20, 35, 0, 0)
        '
        'tTiket
        '
        Me.tTiket.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tTiket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tTiket.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTiket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tTiket.Location = New System.Drawing.Point(343, 454)
        Me.tTiket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tTiket.Name = "tTiket"
        Me.tTiket.Size = New System.Drawing.Size(168, 21)
        Me.tTiket.TabIndex = 96
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(81, 288)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 26)
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
        Me.Button6.Location = New System.Drawing.Point(336, 446)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(180, 39)
        Me.Button6.TabIndex = 95
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(76, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 22)
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
        Me.Button4.Location = New System.Drawing.Point(81, 278)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 48)
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
        Me.cGenre.Items.AddRange(New Object() {"Drama", "Komedi", "Musikal"})
        Me.cGenre.Location = New System.Drawing.Point(336, 280)
        Me.cGenre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cGenre.Name = "cGenre"
        Me.cGenre.Size = New System.Drawing.Size(234, 35)
        Me.cGenre.TabIndex = 88
        '
        'lExit
        '
        Me.lExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lExit.Location = New System.Drawing.Point(576, 5)
        Me.lExit.Name = "lExit"
        Me.lExit.Size = New System.Drawing.Size(150, 52)
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
        Me.bClear.Location = New System.Drawing.Point(81, 641)
        Me.bClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(488, 48)
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
        Me.bSimpan.Location = New System.Drawing.Point(80, 589)
        Me.bSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(488, 48)
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
        Me.Label6.Location = New System.Drawing.Point(332, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 22)
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
        Me.cHari.Location = New System.Drawing.Point(336, 361)
        Me.cHari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cHari.Name = "cHari"
        Me.cHari.Size = New System.Drawing.Size(234, 35)
        Me.cHari.TabIndex = 39
        '
        'tJudul
        '
        Me.tJudul.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tJudul.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tJudul.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tJudul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tJudul.Location = New System.Drawing.Point(81, 111)
        Me.tJudul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tJudul.Name = "tJudul"
        Me.tJudul.Size = New System.Drawing.Size(488, 26)
        Me.tJudul.TabIndex = 26
        '
        'tPemain
        '
        Me.tPemain.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tPemain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tPemain.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPemain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tPemain.Location = New System.Drawing.Point(81, 202)
        Me.tPemain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPemain.Name = "tPemain"
        Me.tPemain.Size = New System.Drawing.Size(488, 26)
        Me.tPemain.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(76, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 22)
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
        Me.Button2.Location = New System.Drawing.Point(81, 101)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(488, 48)
        Me.Button2.TabIndex = 42
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(76, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 28)
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
        Me.Button3.Location = New System.Drawing.Point(81, 192)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(488, 48)
        Me.Button3.TabIndex = 43
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(140, 526)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(288, 71)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "equiter"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(78, 72)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(423, 428)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'formTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1238, 712)
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
        Me.gJam.ResumeLayout(False)
        Me.gJam.PerformLayout()
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
    Friend WithEvents dTanggal As DateTimePicker
    Friend WithEvents gJam As GroupBox
    Friend WithEvents rJamKeempat As RadioButton
    Friend WithEvents rJamKetiga As RadioButton
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
End Class
