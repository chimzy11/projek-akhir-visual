﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDashboard))
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.lDataJadwal = New System.Windows.Forms.Label()
        Me.lTotalPertunjukkan = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.lDataTransaksiUser = New System.Windows.Forms.Label()
        Me.lDataTransaksi = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lDataUser = New System.Windows.Forms.Label()
        Me.lblTotalUser = New System.Windows.Forms.Label()
        Me.ChartKeuntungan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.bTanggal = New System.Windows.Forms.Button()
        Me.bBulan = New System.Windows.Forms.Button()
        Me.bTahun = New System.Windows.Forms.Button()
        Me.lTotalKeuntungan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pKeuntungan = New System.Windows.Forms.Panel()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.ChartKeuntungan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pKeuntungan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Button10)
        Me.Panel14.Controls.Add(Me.lDataJadwal)
        Me.Panel14.Controls.Add(Me.lTotalPertunjukkan)
        Me.Panel14.Location = New System.Drawing.Point(1011, 48)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(426, 214)
        Me.Panel14.TabIndex = 15
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.A1K3_Projek_Akhir.My.Resources.Resources.theater
        Me.Button10.Location = New System.Drawing.Point(42, 23)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(96, 109)
        Me.Button10.TabIndex = 2
        Me.Button10.UseVisualStyleBackColor = True
        '
        'lDataJadwal
        '
        Me.lDataJadwal.AutoSize = True
        Me.lDataJadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDataJadwal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lDataJadwal.Location = New System.Drawing.Point(34, 137)
        Me.lDataJadwal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lDataJadwal.Name = "lDataJadwal"
        Me.lDataJadwal.Size = New System.Drawing.Size(365, 47)
        Me.lDataJadwal.TabIndex = 1
        Me.lDataJadwal.Text = "Total Pertunjukkan"
        '
        'lTotalPertunjukkan
        '
        Me.lTotalPertunjukkan.AutoSize = True
        Me.lTotalPertunjukkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotalPertunjukkan.Location = New System.Drawing.Point(184, 45)
        Me.lTotalPertunjukkan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTotalPertunjukkan.Name = "lTotalPertunjukkan"
        Me.lTotalPertunjukkan.Size = New System.Drawing.Size(136, 55)
        Me.lTotalPertunjukkan.TabIndex = 0
        Me.lTotalPertunjukkan.Text = "1829"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Button9)
        Me.Panel13.Controls.Add(Me.lDataTransaksiUser)
        Me.Panel13.Controls.Add(Me.lDataTransaksi)
        Me.Panel13.Location = New System.Drawing.Point(556, 45)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(426, 214)
        Me.Panel13.TabIndex = 14
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.A1K3_Projek_Akhir.My.Resources.Resources.transaction_history
        Me.Button9.Location = New System.Drawing.Point(42, 23)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 109)
        Me.Button9.TabIndex = 2
        Me.Button9.UseVisualStyleBackColor = True
        '
        'lDataTransaksiUser
        '
        Me.lDataTransaksiUser.AutoSize = True
        Me.lDataTransaksiUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lDataTransaksiUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDataTransaksiUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lDataTransaksiUser.Location = New System.Drawing.Point(74, 145)
        Me.lDataTransaksiUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lDataTransaksiUser.Name = "lDataTransaksiUser"
        Me.lDataTransaksiUser.Size = New System.Drawing.Size(304, 47)
        Me.lDataTransaksiUser.TabIndex = 1
        Me.lDataTransaksiUser.Text = "Total Transaksi"
        '
        'lDataTransaksi
        '
        Me.lDataTransaksi.AutoSize = True
        Me.lDataTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDataTransaksi.Location = New System.Drawing.Point(186, 52)
        Me.lDataTransaksi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lDataTransaksi.Name = "lDataTransaksi"
        Me.lDataTransaksi.Size = New System.Drawing.Size(136, 55)
        Me.lDataTransaksi.TabIndex = 0
        Me.lDataTransaksi.Text = "1829"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Button8)
        Me.Panel12.Controls.Add(Me.lDataUser)
        Me.Panel12.Controls.Add(Me.lblTotalUser)
        Me.Panel12.Location = New System.Drawing.Point(90, 45)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(426, 214)
        Me.Panel12.TabIndex = 13
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.A1K3_Projek_Akhir.My.Resources.Resources.group__2_
        Me.Button8.Location = New System.Drawing.Point(56, 35)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 85)
        Me.Button8.TabIndex = 2
        Me.Button8.UseVisualStyleBackColor = True
        '
        'lDataUser
        '
        Me.lDataUser.AutoSize = True
        Me.lDataUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lDataUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDataUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lDataUser.Location = New System.Drawing.Point(105, 140)
        Me.lDataUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lDataUser.Name = "lDataUser"
        Me.lDataUser.Size = New System.Drawing.Size(211, 47)
        Me.lDataUser.TabIndex = 1
        Me.lDataUser.Text = "Total User"
        '
        'lblTotalUser
        '
        Me.lblTotalUser.AutoSize = True
        Me.lblTotalUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUser.Location = New System.Drawing.Point(189, 62)
        Me.lblTotalUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalUser.Name = "lblTotalUser"
        Me.lblTotalUser.Size = New System.Drawing.Size(136, 55)
        Me.lblTotalUser.TabIndex = 0
        Me.lblTotalUser.Text = "1829"
        '
        'ChartKeuntungan
        '
        Me.ChartKeuntungan.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ChartKeuntungan.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.ChartKeuntungan.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartKeuntungan.Legends.Add(Legend1)
        Me.ChartKeuntungan.Location = New System.Drawing.Point(90, 382)
        Me.ChartKeuntungan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChartKeuntungan.Name = "ChartKeuntungan"
        Me.ChartKeuntungan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartKeuntungan.Series.Add(Series1)
        Me.ChartKeuntungan.Size = New System.Drawing.Size(862, 472)
        Me.ChartKeuntungan.TabIndex = 11
        Me.ChartKeuntungan.Text = "Chart1"
        '
        'bTanggal
        '
        Me.bTanggal.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bTanggal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bTanggal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bTanggal.FlatAppearance.BorderSize = 0
        Me.bTanggal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTanggal.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTanggal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bTanggal.Location = New System.Drawing.Point(682, 331)
        Me.bTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bTanggal.Name = "bTanggal"
        Me.bTanggal.Size = New System.Drawing.Size(108, 49)
        Me.bTanggal.TabIndex = 116
        Me.bTanggal.Text = "Tanggal"
        Me.bTanggal.UseVisualStyleBackColor = False
        '
        'bBulan
        '
        Me.bBulan.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bBulan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBulan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bBulan.FlatAppearance.BorderSize = 0
        Me.bBulan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBulan.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBulan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bBulan.Location = New System.Drawing.Point(783, 331)
        Me.bBulan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bBulan.Name = "bBulan"
        Me.bBulan.Size = New System.Drawing.Size(84, 48)
        Me.bBulan.TabIndex = 117
        Me.bBulan.Text = "Bulan"
        Me.bBulan.UseVisualStyleBackColor = False
        '
        'bTahun
        '
        Me.bTahun.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bTahun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bTahun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bTahun.FlatAppearance.BorderSize = 0
        Me.bTahun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bTahun.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTahun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bTahun.Location = New System.Drawing.Point(862, 331)
        Me.bTahun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bTahun.Name = "bTahun"
        Me.bTahun.Size = New System.Drawing.Size(87, 48)
        Me.bTahun.TabIndex = 118
        Me.bTahun.Text = "Tahun"
        Me.bTahun.UseVisualStyleBackColor = False
        '
        'lTotalKeuntungan
        '
        Me.lTotalKeuntungan.AutoSize = True
        Me.lTotalKeuntungan.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotalKeuntungan.Location = New System.Drawing.Point(158, 254)
        Me.lTotalKeuntungan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lTotalKeuntungan.Name = "lTotalKeuntungan"
        Me.lTotalKeuntungan.Size = New System.Drawing.Size(136, 55)
        Me.lTotalKeuntungan.TabIndex = 0
        Me.lTotalKeuntungan.Text = "1829"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 254)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 55)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rp."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 342)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Pendapatan Saat Ini"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.A1K3_Projek_Akhir.My.Resources.Resources.money_flow
        Me.Button1.Location = New System.Drawing.Point(126, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 166)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pKeuntungan
        '
        Me.pKeuntungan.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.pKeuntungan.Controls.Add(Me.Button1)
        Me.pKeuntungan.Controls.Add(Me.Label1)
        Me.pKeuntungan.Controls.Add(Me.Label2)
        Me.pKeuntungan.Controls.Add(Me.lTotalKeuntungan)
        Me.pKeuntungan.Location = New System.Drawing.Point(1011, 382)
        Me.pKeuntungan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pKeuntungan.Name = "pKeuntungan"
        Me.pKeuntungan.Size = New System.Drawing.Size(426, 477)
        Me.pKeuntungan.TabIndex = 16
        '
        'formDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1522, 749)
        Me.Controls.Add(Me.pKeuntungan)
        Me.Controls.Add(Me.bTahun)
        Me.Controls.Add(Me.bBulan)
        Me.Controls.Add(Me.bTanggal)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.ChartKeuntungan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formDashboard"
        Me.Text = "formDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.ChartKeuntungan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pKeuntungan.ResumeLayout(False)
        Me.pKeuntungan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel14 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents lDataJadwal As Label
    Friend WithEvents lTotalPertunjukkan As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents lDataTransaksiUser As Label
    Friend WithEvents lDataTransaksi As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents lDataUser As Label
    Friend WithEvents lblTotalUser As Label
    Friend WithEvents ChartKeuntungan As DataVisualization.Charting.Chart
    Friend WithEvents bTanggal As Button
    Friend WithEvents bBulan As Button
    Friend WithEvents bTahun As Button
    Friend WithEvents lTotalKeuntungan As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pKeuntungan As Panel
End Class
