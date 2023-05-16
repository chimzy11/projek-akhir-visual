<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formJadwal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formJadwal))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bTambahJadwal = New System.Windows.Forms.Button()
        Me.DGVJadwalTeater = New System.Windows.Forms.DataGridView()
        CType(Me.DGVJadwalTeater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSearch.Enabled = False
        Me.btnSearch.Location = New System.Drawing.Point(1022, 62)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(476, 51)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(1034, 72)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(430, 26)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(453, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ini nanti diedit pas udah ada datanya yek"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 4
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(285, 35)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(4, 15, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(112, 98)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Hapus"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(154, 35)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(4, 15, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(112, 98)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Edit "
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bTambahJadwal
        '
        Me.bTambahJadwal.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bTambahJadwal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bTambahJadwal.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTambahJadwal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bTambahJadwal.Image = CType(resources.GetObject("bTambahJadwal.Image"), System.Drawing.Image)
        Me.bTambahJadwal.Location = New System.Drawing.Point(22, 35)
        Me.bTambahJadwal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bTambahJadwal.Name = "bTambahJadwal"
        Me.bTambahJadwal.Padding = New System.Windows.Forms.Padding(4, 15, 0, 0)
        Me.bTambahJadwal.Size = New System.Drawing.Size(112, 98)
        Me.bTambahJadwal.TabIndex = 18
        Me.bTambahJadwal.Text = "Tambah "
        Me.bTambahJadwal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bTambahJadwal.UseVisualStyleBackColor = False
        '
        'DGVJadwalTeater
        '
        Me.DGVJadwalTeater.AllowUserToAddRows = False
        Me.DGVJadwalTeater.AllowUserToDeleteRows = False
        Me.DGVJadwalTeater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVJadwalTeater.Location = New System.Drawing.Point(26, 196)
        Me.DGVJadwalTeater.Name = "DGVJadwalTeater"
        Me.DGVJadwalTeater.ReadOnly = True
        Me.DGVJadwalTeater.RowHeadersWidth = 62
        Me.DGVJadwalTeater.RowTemplate.Height = 28
        Me.DGVJadwalTeater.Size = New System.Drawing.Size(1708, 612)
        Me.DGVJadwalTeater.TabIndex = 23
        '
        'formJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1712, 855)
        Me.Controls.Add(Me.DGVJadwalTeater)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bTambahJadwal)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "formJadwal"
        Me.Text = "A"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVJadwalTeater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents bTambahJadwal As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVJadwalTeater As DataGridView
End Class
