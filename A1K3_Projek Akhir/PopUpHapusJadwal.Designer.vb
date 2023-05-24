<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopUpHapusJadwal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopUpHapusJadwal))
        Me.bHapus = New System.Windows.Forms.Button()
        Me.pKembali = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cIdTeater = New System.Windows.Forms.ComboBox()
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
        Me.bHapus.Location = New System.Drawing.Point(141, 106)
        Me.bHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bHapus.Name = "bHapus"
        Me.bHapus.Size = New System.Drawing.Size(115, 30)
        Me.bHapus.TabIndex = 80
        Me.bHapus.Text = "Hapus"
        Me.bHapus.UseVisualStyleBackColor = False
        '
        'pKembali
        '
        Me.pKembali.BackgroundImage = CType(resources.GetObject("pKembali.BackgroundImage"), System.Drawing.Image)
        Me.pKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pKembali.Location = New System.Drawing.Point(27, 110)
        Me.pKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(28, 21)
        Me.pKembali.TabIndex = 85
        Me.pKembali.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 31)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Hapus Jadwal teater"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cIdTeater
        '
        Me.cIdTeater.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.cIdTeater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cIdTeater.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cIdTeater.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cIdTeater.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cIdTeater.FormattingEnabled = True
        Me.cIdTeater.IntegralHeight = False
        Me.cIdTeater.Items.AddRange(New Object() {"-- Pilih ID --"})
        Me.cIdTeater.Location = New System.Drawing.Point(36, 58)
        Me.cIdTeater.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cIdTeater.Name = "cIdTeater"
        Me.cIdTeater.Size = New System.Drawing.Size(214, 31)
        Me.cIdTeater.TabIndex = 115
        '
        'PopUpHapusJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.cIdTeater)
        Me.Controls.Add(Me.pKembali)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bHapus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PopUpHapusJadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih ID Jadwal"
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bHapus As Button
    Friend WithEvents pKembali As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cIdTeater As ComboBox
End Class
