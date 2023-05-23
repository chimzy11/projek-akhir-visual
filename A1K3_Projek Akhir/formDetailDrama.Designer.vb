<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDetailDrama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDetailDrama))
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
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pTeater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.pKembali)
        Me.Panel1.Controls.Add(Me.bPesan)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblLokaso)
        Me.Panel1.Controls.Add(Me.lHarga)
        Me.Panel1.Controls.Add(Me.lJudul)
        Me.Panel1.Location = New System.Drawing.Point(48, 37)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 451)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
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
        Me.lStokTiket.Location = New System.Drawing.Point(446, 14)
        Me.lStokTiket.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lStokTiket.Name = "lStokTiket"
        Me.lStokTiket.Size = New System.Drawing.Size(138, 31)
        Me.lStokTiket.TabIndex = 92
        Me.lStokTiket.Text = "Kelompok"
        '
        'lWaktu
        '
        Me.lWaktu.AutoSize = True
        Me.lWaktu.BackColor = System.Drawing.Color.Transparent
        Me.lWaktu.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lWaktu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lWaktu.Location = New System.Drawing.Point(243, 162)
        Me.lWaktu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lWaktu.Name = "lWaktu"
        Me.lWaktu.Size = New System.Drawing.Size(138, 31)
        Me.lWaktu.TabIndex = 91
        Me.lWaktu.Text = "Kelompok"
        '
        'lTanggal
        '
        Me.lTanggal.AutoSize = True
        Me.lTanggal.BackColor = System.Drawing.Color.Transparent
        Me.lTanggal.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTanggal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lTanggal.Location = New System.Drawing.Point(243, 131)
        Me.lTanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTanggal.Name = "lTanggal"
        Me.lTanggal.Size = New System.Drawing.Size(138, 31)
        Me.lTanggal.TabIndex = 90
        Me.lTanggal.Text = "Kelompok"
        '
        'lHari
        '
        Me.lHari.AutoSize = True
        Me.lHari.BackColor = System.Drawing.Color.Transparent
        Me.lHari.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHari.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lHari.Location = New System.Drawing.Point(243, 100)
        Me.lHari.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lHari.Name = "lHari"
        Me.lHari.Size = New System.Drawing.Size(138, 31)
        Me.lHari.TabIndex = 89
        Me.lHari.Text = "Kelompok"
        '
        'lGenre
        '
        Me.lGenre.AutoSize = True
        Me.lGenre.BackColor = System.Drawing.Color.Transparent
        Me.lGenre.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lGenre.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lGenre.Location = New System.Drawing.Point(243, 55)
        Me.lGenre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lGenre.Name = "lGenre"
        Me.lGenre.Size = New System.Drawing.Size(138, 31)
        Me.lGenre.TabIndex = 89
        Me.lGenre.Text = "Kelompok"
        '
        'lKelompok
        '
        Me.lKelompok.AutoSize = True
        Me.lKelompok.BackColor = System.Drawing.Color.Transparent
        Me.lKelompok.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lKelompok.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lKelompok.Location = New System.Drawing.Point(243, 14)
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
        Me.pTeater.Size = New System.Drawing.Size(224, 235)
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
        Me.lSignIn.Location = New System.Drawing.Point(302, 551)
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
        Me.pKembali.Location = New System.Drawing.Point(20, 409)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(32, 26)
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
        Me.bPesan.Location = New System.Drawing.Point(638, 360)
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
        Me.lblLokaso.Size = New System.Drawing.Size(282, 31)
        Me.lblLokaso.TabIndex = 3
        Me.lblLokaso.Text = "Gedung Teater Drama"
        '
        'lHarga
        '
        Me.lHarga.AutoSize = True
        Me.lHarga.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lHarga.Location = New System.Drawing.Point(80, 315)
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
        Me.lJudul.Location = New System.Drawing.Point(80, 22)
        Me.lJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lJudul.Name = "lJudul"
        Me.lJudul.Size = New System.Drawing.Size(300, 34)
        Me.lJudul.TabIndex = 0
        Me.lJudul.Text = "Judul Teater Drama"
        '
        'formDetailDrama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(974, 523)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "formDetailDrama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formDetailDrama"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pTeater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lStokTiket As Label
    Friend WithEvents lWaktu As Label
    Friend WithEvents lTanggal As Label
    Friend WithEvents lHari As Label
    Friend WithEvents lGenre As Label
    Friend WithEvents lKelompok As Label
    Friend WithEvents pTeater As PictureBox
    Friend WithEvents lSignIn As Label
    Friend WithEvents pKembali As PictureBox
    Friend WithEvents bPesan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblLokaso As Label
    Friend WithEvents lHarga As Label
    Friend WithEvents lJudul As Label
End Class
