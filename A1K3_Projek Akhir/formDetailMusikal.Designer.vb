﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDetailMusikal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDetailMusikal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lStokTiket = New System.Windows.Forms.Label()
        Me.lWaktu = New System.Windows.Forms.Label()
        Me.lTanggal = New System.Windows.Forms.Label()
        Me.lHari = New System.Windows.Forms.Label()
        Me.lGenre = New System.Windows.Forms.Label()
        Me.lKelompok = New System.Windows.Forms.Label()
        Me.pTeater = New System.Windows.Forms.PictureBox()
        Me.lSignIn = New System.Windows.Forms.Label()
        Me.pKembali = New System.Windows.Forms.PictureBox()
        Me.bPesan = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblLokaso = New System.Windows.Forms.Label()
        Me.lHarga = New System.Windows.Forms.Label()
        Me.lJudul = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pTeater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.pKembali)
        Me.Panel1.Controls.Add(Me.bPesan)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblLokaso)
        Me.Panel1.Controls.Add(Me.lHarga)
        Me.Panel1.Controls.Add(Me.lJudul)
        Me.Panel1.Location = New System.Drawing.Point(46, 34)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 451)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lStokTiket)
        Me.Panel3.Controls.Add(Me.lWaktu)
        Me.Panel3.Controls.Add(Me.lTanggal)
        Me.Panel3.Controls.Add(Me.lHari)
        Me.Panel3.Controls.Add(Me.lGenre)
        Me.Panel3.Controls.Add(Me.lKelompok)
        Me.Panel3.Controls.Add(Me.pTeater)
        Me.Panel3.Controls.Add(Me.lSignIn)
        Me.Panel3.Location = New System.Drawing.Point(86, 77)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(699, 235)
        Me.Panel3.TabIndex = 87
        '
        'lStokTiket
        '
        Me.lStokTiket.AutoSize = True
        Me.lStokTiket.BackColor = System.Drawing.Color.Transparent
        Me.lStokTiket.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStokTiket.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lStokTiket.Location = New System.Drawing.Point(434, 193)
        Me.lStokTiket.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lStokTiket.Name = "lStokTiket"
        Me.lStokTiket.Size = New System.Drawing.Size(135, 31)
        Me.lStokTiket.TabIndex = 92
        Me.lStokTiket.Text = "Stok Tiket"
        '
        'lWaktu
        '
        Me.lWaktu.AutoSize = True
        Me.lWaktu.BackColor = System.Drawing.Color.Transparent
        Me.lWaktu.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lWaktu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lWaktu.Location = New System.Drawing.Point(434, 151)
        Me.lWaktu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lWaktu.Name = "lWaktu"
        Me.lWaktu.Size = New System.Drawing.Size(94, 31)
        Me.lWaktu.TabIndex = 91
        Me.lWaktu.Text = "Waktu"
        '
        'lTanggal
        '
        Me.lTanggal.AutoSize = True
        Me.lTanggal.BackColor = System.Drawing.Color.Transparent
        Me.lTanggal.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTanggal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lTanggal.Location = New System.Drawing.Point(497, 10)
        Me.lTanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTanggal.Name = "lTanggal"
        Me.lTanggal.Size = New System.Drawing.Size(112, 31)
        Me.lTanggal.TabIndex = 90
        Me.lTanggal.Text = "Tanggal"
        '
        'lHari
        '
        Me.lHari.AutoSize = True
        Me.lHari.BackColor = System.Drawing.Color.Transparent
        Me.lHari.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHari.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lHari.Location = New System.Drawing.Point(387, 10)
        Me.lHari.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lHari.Name = "lHari"
        Me.lHari.Size = New System.Drawing.Size(65, 31)
        Me.lHari.TabIndex = 89
        Me.lHari.Text = "Hari"
        '
        'lGenre
        '
        Me.lGenre.AutoSize = True
        Me.lGenre.BackColor = System.Drawing.Color.Transparent
        Me.lGenre.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lGenre.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lGenre.Location = New System.Drawing.Point(434, 102)
        Me.lGenre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lGenre.Name = "lGenre"
        Me.lGenre.Size = New System.Drawing.Size(86, 31)
        Me.lGenre.TabIndex = 89
        Me.lGenre.Text = "Genre"
        '
        'lKelompok
        '
        Me.lKelompok.AutoSize = True
        Me.lKelompok.BackColor = System.Drawing.Color.Transparent
        Me.lKelompok.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lKelompok.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lKelompok.Location = New System.Drawing.Point(434, 57)
        Me.lKelompok.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lKelompok.Name = "lKelompok"
        Me.lKelompok.Size = New System.Drawing.Size(138, 31)
        Me.lKelompok.TabIndex = 88
        Me.lKelompok.Text = "Kelompok"
        '
        'pTeater
        '
        Me.pTeater.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pTeater.Location = New System.Drawing.Point(0, 0)
        Me.pTeater.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pTeater.Name = "pTeater"
        Me.pTeater.Size = New System.Drawing.Size(223, 235)
        Me.pTeater.TabIndex = 1
        Me.pTeater.TabStop = False
        '
        'lSignIn
        '
        Me.lSignIn.AutoSize = True
        Me.lSignIn.BackColor = System.Drawing.Color.Transparent
        Me.lSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lSignIn.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.lSignIn.Location = New System.Drawing.Point(302, 550)
        Me.lSignIn.Name = "lSignIn"
        Me.lSignIn.Size = New System.Drawing.Size(75, 25)
        Me.lSignIn.TabIndex = 0
        Me.lSignIn.Text = "Sign In"
        '
        'pKembali
        '
        Me.pKembali.BackgroundImage = CType(resources.GetObject("pKembali.BackgroundImage"), System.Drawing.Image)
        Me.pKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pKembali.Location = New System.Drawing.Point(86, 409)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(31, 26)
        Me.pKembali.TabIndex = 86
        Me.pKembali.TabStop = False
        '
        'bPesan
        '
        Me.bPesan.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bPesan.FlatAppearance.BorderSize = 0
        Me.bPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPesan.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPesan.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.bPesan.Location = New System.Drawing.Point(617, 386)
        Me.bPesan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bPesan.Name = "bPesan"
        Me.bPesan.Size = New System.Drawing.Size(168, 49)
        Me.bPesan.TabIndex = 5
        Me.bPesan.Text = "Pesan"
        Me.bPesan.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.A1K3_Projek_Akhir.My.Resources.Resources.placeholder
        Me.Button1.Location = New System.Drawing.Point(68, 349)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 62)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblLokaso
        '
        Me.lblLokaso.AutoSize = True
        Me.lblLokaso.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLokaso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblLokaso.Location = New System.Drawing.Point(129, 366)
        Me.lblLokaso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLokaso.Name = "lblLokaso"
        Me.lblLokaso.Size = New System.Drawing.Size(296, 31)
        Me.lblLokaso.TabIndex = 3
        Me.lblLokaso.Text = "Gedung Teater Musikal"
        '
        'lHarga
        '
        Me.lHarga.AutoSize = True
        Me.lHarga.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHarga.Location = New System.Drawing.Point(129, 315)
        Me.lHarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lHarga.Name = "lHarga"
        Me.lHarga.Size = New System.Drawing.Size(96, 31)
        Me.lHarga.TabIndex = 2
        Me.lHarga.Text = "50.000"
        '
        'lJudul
        '
        Me.lJudul.AutoSize = True
        Me.lJudul.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lJudul.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lJudul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lJudul.Location = New System.Drawing.Point(80, 21)
        Me.lJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lJudul.Name = "lJudul"
        Me.lJudul.Size = New System.Drawing.Size(319, 34)
        Me.lJudul.TabIndex = 0
        Me.lJudul.Text = "Judul Teater Musikal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 313)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 31)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "RP."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(256, 193)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 31)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Stok Tiket    :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(258, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 31)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Jam              :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(256, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 31)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Genre           :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(253, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 31)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Kelompok    :"
        '
        'formDetailMusikal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(974, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "formDetailMusikal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formDetail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pTeater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bPesan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblLokaso As Label
    Friend WithEvents lHarga As Label
    Friend WithEvents pTeater As PictureBox
    Friend WithEvents lJudul As Label
    Friend WithEvents pKembali As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lKelompok As Label
    Friend WithEvents lSignIn As Label
    Friend WithEvents lStokTiket As Label
    Friend WithEvents lWaktu As Label
    Friend WithEvents lTanggal As Label
    Friend WithEvents lHari As Label
    Friend WithEvents lGenre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
