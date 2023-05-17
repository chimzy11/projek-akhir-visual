<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FHapusJadwalTeater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FHapusJadwalTeater))
        Me.bHapus = New System.Windows.Forms.Button()
        Me.tIdTeater = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pKembali = New System.Windows.Forms.PictureBox()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bHapus
        '
        Me.bHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bHapus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bHapus.FlatAppearance.BorderSize = 0
        Me.bHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHapus.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bHapus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bHapus.Location = New System.Drawing.Point(159, 132)
        Me.bHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(129, 37)
        Me.bHapus.TabIndex = 80
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = False
        '
        'tIdTeater
        '
        Me.tIdTeater.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.tIdTeater.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tIdTeater.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tIdTeater.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tIdTeater.Location = New System.Drawing.Point(37, 85)
        Me.tIdTeater.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tIdTeater.Name = "tIdTeater"
        Me.tIdTeater.Size = New System.Drawing.Size(245, 21)
        Me.tIdTeater.TabIndex = 83
        Me.tIdTeater.Text = "ID "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(30, 76)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(257, 39)
        Me.Button1.TabIndex = 82
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(5, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 39)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Hapus Jadwal teater"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pKembali
        '
        Me.pKembali.BackgroundImage = CType(resources.GetObject("pKembali.BackgroundImage"), System.Drawing.Image)
        Me.pKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pKembali.Location = New System.Drawing.Point(30, 137)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(31, 26)
        Me.pKembali.TabIndex = 85
        Me.pKembali.TabStop = False
        '
        'FHapusJadwalTeater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 180)
        Me.Controls.Add(Me.pKembali)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tIdTeater)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bHapus)
        Me.Name = "FHapusJadwalTeater"
        Me.Text = "FHapusJadwalTeater"
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bHapus As Button
    Friend WithEvents tIdTeater As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents pKembali As PictureBox
End Class
