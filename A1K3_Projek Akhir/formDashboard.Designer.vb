<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.lDataJadwal = New System.Windows.Forms.Label()
        Me.lTotalPertunjukkan = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lDataTransaksiUser = New System.Windows.Forms.Label()
        Me.lDataTransaksi = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lDataUser = New System.Windows.Forms.Label()
        Me.lblTotalUser = New System.Windows.Forms.Label()
        Me.ChartKeuntungan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.bTanggal = New System.Windows.Forms.Button()
        Me.bBulan = New System.Windows.Forms.Button()
        Me.bTahun = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
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
        Me.Panel14.Location = New System.Drawing.Point(674, 31)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(284, 139)
        Me.Panel14.TabIndex = 15
        '
        'lDataJadwal
        '
        Me.lDataJadwal.AutoSize = True
        Me.lDataJadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDataJadwal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lDataJadwal.Location = New System.Drawing.Point(23, 89)
        Me.lDataJadwal.Name = "lDataJadwal"
        Me.lDataJadwal.Size = New System.Drawing.Size(241, 31)
        Me.lDataJadwal.TabIndex = 1
        Me.lDataJadwal.Text = "Total Pertunjukkan"
        '
        'lTotalPertunjukkan
        '
        Me.lTotalPertunjukkan.AutoSize = True
        Me.lTotalPertunjukkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotalPertunjukkan.Location = New System.Drawing.Point(123, 29)
        Me.lTotalPertunjukkan.Name = "lTotalPertunjukkan"
        Me.lTotalPertunjukkan.Size = New System.Drawing.Size(91, 37)
        Me.lTotalPertunjukkan.TabIndex = 0
        Me.lTotalPertunjukkan.Text = "1829"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Button9)
        Me.Panel13.Controls.Add(Me.lDataTransaksiUser)
        Me.Panel13.Controls.Add(Me.lDataTransaksi)
        Me.Panel13.Location = New System.Drawing.Point(371, 29)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(284, 139)
        Me.Panel13.TabIndex = 14
        '
        'lDataTransaksiUser
        '
        Me.lDataTransaksiUser.AutoSize = True
        Me.lDataTransaksiUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lDataTransaksiUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDataTransaksiUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lDataTransaksiUser.Location = New System.Drawing.Point(49, 94)
        Me.lDataTransaksiUser.Name = "lDataTransaksiUser"
        Me.lDataTransaksiUser.Size = New System.Drawing.Size(201, 31)
        Me.lDataTransaksiUser.TabIndex = 1
        Me.lDataTransaksiUser.Text = "Total Transaksi"
        '
        'lDataTransaksi
        '
        Me.lDataTransaksi.AutoSize = True
        Me.lDataTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDataTransaksi.Location = New System.Drawing.Point(124, 34)
        Me.lDataTransaksi.Name = "lDataTransaksi"
        Me.lDataTransaksi.Size = New System.Drawing.Size(91, 37)
        Me.lDataTransaksi.TabIndex = 0
        Me.lDataTransaksi.Text = "1829"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Button8)
        Me.Panel12.Controls.Add(Me.lDataUser)
        Me.Panel12.Controls.Add(Me.lblTotalUser)
        Me.Panel12.Location = New System.Drawing.Point(60, 29)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(284, 139)
        Me.Panel12.TabIndex = 13
        '
        'lDataUser
        '
        Me.lDataUser.AutoSize = True
        Me.lDataUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lDataUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDataUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lDataUser.Location = New System.Drawing.Point(70, 91)
        Me.lDataUser.Name = "lDataUser"
        Me.lDataUser.Size = New System.Drawing.Size(140, 31)
        Me.lDataUser.TabIndex = 1
        Me.lDataUser.Text = "Total User"
        '
        'lblTotalUser
        '
        Me.lblTotalUser.AutoSize = True
        Me.lblTotalUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUser.Location = New System.Drawing.Point(126, 40)
        Me.lblTotalUser.Name = "lblTotalUser"
        Me.lblTotalUser.Size = New System.Drawing.Size(91, 37)
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
        Me.ChartKeuntungan.Location = New System.Drawing.Point(60, 248)
        Me.ChartKeuntungan.Name = "ChartKeuntungan"
        Me.ChartKeuntungan.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartKeuntungan.Series.Add(Series1)
        Me.ChartKeuntungan.Size = New System.Drawing.Size(575, 307)
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
        Me.bTanggal.Location = New System.Drawing.Point(455, 215)
        Me.bTanggal.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.bTanggal.Name = "bTanggal"
        Me.bTanggal.Size = New System.Drawing.Size(72, 32)
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
        Me.bBulan.Location = New System.Drawing.Point(522, 215)
        Me.bBulan.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.bBulan.Name = "bBulan"
        Me.bBulan.Size = New System.Drawing.Size(56, 31)
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
        Me.bTahun.Location = New System.Drawing.Point(575, 215)
        Me.bTahun.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.bTahun.Name = "bTahun"
        Me.bTahun.Size = New System.Drawing.Size(58, 31)
        Me.bTahun.TabIndex = 118
        Me.bTahun.Text = "Tahun"
        Me.bTahun.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.A1K3_Projek_Akhir.My.Resources.Resources.theater
        Me.Button10.Location = New System.Drawing.Point(28, 15)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(64, 71)
        Me.Button10.TabIndex = 2
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.A1K3_Projek_Akhir.My.Resources.Resources.transaction_history
        Me.Button9.Location = New System.Drawing.Point(28, 15)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(64, 71)
        Me.Button9.TabIndex = 2
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Image = Global.A1K3_Projek_Akhir.My.Resources.Resources.group__2_
        Me.Button8.Location = New System.Drawing.Point(37, 23)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(64, 55)
        Me.Button8.TabIndex = 2
        Me.Button8.UseVisualStyleBackColor = True
        '
        'lTotalKeuntungan
        '
        Me.lTotalKeuntungan.AutoSize = True
        Me.lTotalKeuntungan.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTotalKeuntungan.Location = New System.Drawing.Point(136, 165)
        Me.lTotalKeuntungan.Name = "lTotalKeuntungan"
        Me.lTotalKeuntungan.Size = New System.Drawing.Size(91, 37)
        Me.lTotalKeuntungan.TabIndex = 0
        Me.lTotalKeuntungan.Text = "1829"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rp."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Pertunjukkan"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.A1K3_Projek_Akhir.My.Resources.Resources.money_flow
        Me.Button1.Location = New System.Drawing.Point(84, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 108)
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
        Me.pKeuntungan.Location = New System.Drawing.Point(674, 248)
        Me.pKeuntungan.Name = "pKeuntungan"
        Me.pKeuntungan.Size = New System.Drawing.Size(284, 310)
        Me.pKeuntungan.TabIndex = 16
        '
        'formDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 487)
        Me.Controls.Add(Me.pKeuntungan)
        Me.Controls.Add(Me.bTahun)
        Me.Controls.Add(Me.bBulan)
        Me.Controls.Add(Me.bTanggal)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.ChartKeuntungan)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
