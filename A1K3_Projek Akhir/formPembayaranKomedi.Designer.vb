<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPembayaranKomedi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPembayaranKomedi))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tKodePembayaran = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bCetak = New System.Windows.Forms.Button()
        Me.cValid = New System.Windows.Forms.CheckBox()
        Me.bChsBuktiPembayaran = New System.Windows.Forms.Button()
        Me.pKembali = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(501, 87)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(128, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 38)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Pembayaran"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tKodePembayaran
        '
        Me.tKodePembayaran.AcceptsReturn = True
        Me.tKodePembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tKodePembayaran.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tKodePembayaran.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tKodePembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tKodePembayaran.Location = New System.Drawing.Point(27, 95)
        Me.tKodePembayaran.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tKodePembayaran.Name = "tKodePembayaran"
        Me.tKodePembayaran.Size = New System.Drawing.Size(432, 61)
        Me.tKodePembayaran.TabIndex = 45
        Me.tKodePembayaran.Text = "Kode Pembayaran"
        Me.tKodePembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(-9, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 445)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel3.Controls.Add(Me.bCetak)
        Me.Panel3.Controls.Add(Me.cValid)
        Me.Panel3.Controls.Add(Me.pKembali)
        Me.Panel3.Controls.Add(Me.bChsBuktiPembayaran)
        Me.Panel3.Controls.Add(Me.tKodePembayaran)
        Me.Panel3.Location = New System.Drawing.Point(30, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(480, 414)
        Me.Panel3.TabIndex = 2
        '
        'bCetak
        '
        Me.bCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bCetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCetak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bCetak.FlatAppearance.BorderSize = 0
        Me.bCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCetak.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCetak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bCetak.Location = New System.Drawing.Point(276, 354)
        Me.bCetak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bCetak.Name = "bCetak"
        Me.bCetak.Size = New System.Drawing.Size(183, 44)
        Me.bCetak.TabIndex = 109
        Me.bCetak.Text = "Cetak Tiket"
        Me.bCetak.UseVisualStyleBackColor = False
        '
        'cValid
        '
        Me.cValid.AutoSize = True
        Me.cValid.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cValid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cValid.Location = New System.Drawing.Point(235, 288)
        Me.cValid.Name = "cValid"
        Me.cValid.Size = New System.Drawing.Size(218, 25)
        Me.cValid.TabIndex = 108
        Me.cValid.Text = "Bukti Pembayaran Valid"
        Me.cValid.UseVisualStyleBackColor = True
        '
        'bChsBuktiPembayaran
        '
        Me.bChsBuktiPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bChsBuktiPembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bChsBuktiPembayaran.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bChsBuktiPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bChsBuktiPembayaran.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bChsBuktiPembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.bChsBuktiPembayaran.Location = New System.Drawing.Point(54, 225)
        Me.bChsBuktiPembayaran.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bChsBuktiPembayaran.Name = "bChsBuktiPembayaran"
        Me.bChsBuktiPembayaran.Size = New System.Drawing.Size(384, 48)
        Me.bChsBuktiPembayaran.TabIndex = 46
        Me.bChsBuktiPembayaran.Text = "Choose Gambar"
        Me.bChsBuktiPembayaran.UseVisualStyleBackColor = False
        '
        'pKembali
        '
        Me.pKembali.BackgroundImage = CType(resources.GetObject("pKembali.BackgroundImage"), System.Drawing.Image)
        Me.pKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pKembali.Location = New System.Drawing.Point(27, 363)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(37, 35)
        Me.pKembali.TabIndex = 107
        Me.pKembali.TabStop = False
        '
        'formPembayaranKomedi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "formPembayaranKomedi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formPembayaranKomedi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tKodePembayaran As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bCetak As Button
    Friend WithEvents cValid As CheckBox
    Friend WithEvents pKembali As PictureBox
    Friend WithEvents bChsBuktiPembayaran As Button
End Class
