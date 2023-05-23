<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTransaksi
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTransaksi))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGVTransaksiUser = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVTransaksiUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(16, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1474, 1500)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DGVTransaksiUser)
        Me.Panel2.Location = New System.Drawing.Point(40, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1592, 1500)
        Me.Panel2.TabIndex = 28
        '
        'DGVTransaksiUser
        '
        Me.DGVTransaksiUser.AllowUserToAddRows = False
        Me.DGVTransaksiUser.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.DGVTransaksiUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVTransaksiUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVTransaksiUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVTransaksiUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTransaksiUser.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVTransaksiUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DGVTransaksiUser.Location = New System.Drawing.Point(22, 15)
        Me.DGVTransaksiUser.Name = "DGVTransaksiUser"
        Me.DGVTransaksiUser.ReadOnly = True
        Me.DGVTransaksiUser.RowHeadersVisible = False
        Me.DGVTransaksiUser.RowHeadersWidth = 62
        Me.DGVTransaksiUser.RowTemplate.Height = 28
        Me.DGVTransaksiUser.Size = New System.Drawing.Size(1398, 1500)
        Me.DGVTransaksiUser.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(628, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(415, 46)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Data Transaksi User"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(1014, 54)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(430, 26)
        Me.txtSearch.TabIndex = 29
        Me.txtSearch.Text = "Search"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.btnSearch.Enabled = False
        Me.btnSearch.Location = New System.Drawing.Point(1014, 44)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(476, 51)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'formTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1812, 692)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "formTransaksi"
        Me.Text = "formTransaksi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGVTransaksiUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVTransaksiUser As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
End Class
