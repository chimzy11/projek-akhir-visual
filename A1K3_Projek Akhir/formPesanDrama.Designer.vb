﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPesanDrama
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
        Dim bPembayaran As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPesanDrama))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pKembali = New System.Windows.Forms.PictureBox()
        Me.lJudul = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lTotalHarga = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lUsername = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tBanyakTiket = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        bPembayaran = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'bPembayaran
        '
        bPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        bPembayaran.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        bPembayaran.FlatAppearance.BorderSize = 0
        bPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        bPembayaran.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        bPembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        bPembayaran.Image = CType(resources.GetObject("bPembayaran.Image"), System.Drawing.Image)
        bPembayaran.Location = New System.Drawing.Point(587, 2)
        bPembayaran.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        bPembayaran.Name = "bPembayaran"
        bPembayaran.Padding = New System.Windows.Forms.Padding(4, 15, 0, 0)
        bPembayaran.Size = New System.Drawing.Size(213, 98)
        bPembayaran.TabIndex = 57
        bPembayaran.Text = "Checkout"
        bPembayaran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        bPembayaran.UseVisualStyleBackColor = False
        AddHandler bPembayaran.Click, AddressOf Me.bPembayaran_Click
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pKembali)
        Me.Panel1.Controls.Add(Me.lJudul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 76)
        Me.Panel1.TabIndex = 53
        '
        'pKembali
        '
        Me.pKembali.BackgroundImage = CType(resources.GetObject("pKembali.BackgroundImage"), System.Drawing.Image)
        Me.pKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pKembali.Location = New System.Drawing.Point(3, 20)
        Me.pKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(37, 35)
        Me.pKembali.TabIndex = 106
        Me.pKembali.TabStop = False
        '
        'lJudul
        '
        Me.lJudul.AutoSize = True
        Me.lJudul.Font = New System.Drawing.Font("Stencil", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lJudul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.lJudul.Location = New System.Drawing.Point(274, 18)
        Me.lJudul.Name = "lJudul"
        Me.lJudul.Size = New System.Drawing.Size(197, 38)
        Me.lJudul.TabIndex = 108
        Me.lJudul.Text = "Judul Film"
        Me.lJudul.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(212, 108)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(328, 32)
        Me.FlowLayoutPanel1.TabIndex = 52
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel3.Controls.Add(bPembayaran)
        Me.Panel3.Controls.Add(Me.lTotalHarga)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lUsername)
        Me.Panel3.Location = New System.Drawing.Point(-1, 670)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(803, 110)
        Me.Panel3.TabIndex = 58
        '
        'lTotalHarga
        '
        Me.lTotalHarga.AutoSize = True
        Me.lTotalHarga.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotalHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lTotalHarga.Location = New System.Drawing.Point(368, 54)
        Me.lTotalHarga.Name = "lTotalHarga"
        Me.lTotalHarga.Size = New System.Drawing.Size(72, 27)
        Me.lTotalHarga.TabIndex = 56
        Me.lTotalHarga.Text = "50000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(328, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 22)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(317, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 27)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Rp."
        '
        'lUsername
        '
        Me.lUsername.AutoSize = True
        Me.lUsername.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lUsername.Location = New System.Drawing.Point(18, 42)
        Me.lUsername.Name = "lUsername"
        Me.lUsername.Size = New System.Drawing.Size(115, 27)
        Me.lUsername.TabIndex = 52
        Me.lUsername.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 578)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 22)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Jumlah Tiket"
        '
        'tBanyakTiket
        '
        Me.tBanyakTiket.AcceptsReturn = True
        Me.tBanyakTiket.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tBanyakTiket.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tBanyakTiket.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tBanyakTiket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tBanyakTiket.Location = New System.Drawing.Point(22, 618)
        Me.tBanyakTiket.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tBanyakTiket.Name = "tBanyakTiket"
        Me.tBanyakTiket.Size = New System.Drawing.Size(183, 26)
        Me.tBanyakTiket.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(17, 608)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 42)
        Me.Button1.TabIndex = 57
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(22, 168)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(757, 374)
        Me.Panel2.TabIndex = 54
        '
        'formPesanDrama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 778)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tBanyakTiket)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "formPesanDrama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formPesanDrama"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pKembali As PictureBox
    Friend WithEvents lJudul As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lTotalHarga As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lUsername As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tBanyakTiket As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
