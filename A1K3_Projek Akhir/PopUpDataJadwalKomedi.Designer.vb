<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUpDataJadwalKomedi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopUpDataJadwalKomedi))
        Me.cJudul = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bLihat = New System.Windows.Forms.Button()
        Me.pKembali = New System.Windows.Forms.PictureBox()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cJudul
        '
        Me.cJudul.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cJudul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cJudul.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cJudul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cJudul.FormattingEnabled = True
        Me.cJudul.IntegralHeight = False
        Me.cJudul.Items.AddRange(New Object() {"-- Pilih ID --"})
        Me.cJudul.Location = New System.Drawing.Point(40, 72)
        Me.cJudul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cJudul.Name = "cJudul"
        Me.cJudul.Size = New System.Drawing.Size(240, 35)
        Me.cJudul.TabIndex = 126
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 39)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Pilih Data Jadwal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bLihat
        '
        Me.bLihat.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bLihat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bLihat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bLihat.FlatAppearance.BorderSize = 0
        Me.bLihat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLihat.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLihat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bLihat.Location = New System.Drawing.Point(132, 126)
        Me.bLihat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bLihat.Name = "bLihat"
        Me.bLihat.Size = New System.Drawing.Size(176, 37)
        Me.bLihat.TabIndex = 123
        Me.bLihat.Text = "Lihat Detail"
        Me.bLihat.UseVisualStyleBackColor = False
        '
        'pKembali
        '
        Me.pKembali.BackgroundImage = CType(resources.GetObject("pKembali.BackgroundImage"), System.Drawing.Image)
        Me.pKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pKembali.Location = New System.Drawing.Point(29, 130)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(31, 26)
        Me.pKembali.TabIndex = 125
        Me.pKembali.TabStop = False
        '
        'PopUpDataJadwalKomedi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 180)
        Me.Controls.Add(Me.cJudul)
        Me.Controls.Add(Me.pKembali)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bLihat)
        Me.Name = "PopUpDataJadwalKomedi"
        Me.Text = "PopUpDataJadwalKomedi"
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cJudul As ComboBox
    Friend WithEvents pKembali As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bLihat As Button
End Class
