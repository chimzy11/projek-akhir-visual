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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotalUser = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel14.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel14.Controls.Add(Me.Button10)
        Me.Panel14.Controls.Add(Me.Label15)
        Me.Panel14.Controls.Add(Me.Label16)
        Me.Panel14.Location = New System.Drawing.Point(700, 29)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(284, 139)
        Me.Panel14.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(65, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(161, 31)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Total Teater"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(123, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 37)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "1829"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Button9)
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Controls.Add(Me.Label14)
        Me.Panel13.Location = New System.Drawing.Point(397, 27)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(284, 139)
        Me.Panel13.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(49, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(201, 31)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Total Transaksi"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(124, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 37)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "1829"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Button8)
        Me.Panel12.Controls.Add(Me.Label11)
        Me.Panel12.Controls.Add(Me.lblTotalUser)
        Me.Panel12.Location = New System.Drawing.Point(86, 27)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(284, 139)
        Me.Panel12.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(77, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 31)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Total User"
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(362, 209)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "nnti disini grafik penjualan"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Chart1.BorderlineColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(86, 231)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(898, 334)
        Me.Chart1.TabIndex = 11
        Me.Chart1.Text = "Chart1"
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
        'formDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 487)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Chart1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formDashboard"
        Me.Text = "formDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel14 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotalUser As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
