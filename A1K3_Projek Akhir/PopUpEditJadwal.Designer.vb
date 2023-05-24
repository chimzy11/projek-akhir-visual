<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopUpEditJadwal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PopUpEditJadwal))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bPilih = New System.Windows.Forms.Button()
        Me.pKembali = New System.Windows.Forms.PictureBox()
        Me.cIdTeater = New System.Windows.Forms.ComboBox()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 39)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Edit Jadwal teater"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bPilih
        '
        Me.bPilih.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bPilih.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPilih.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bPilih.FlatAppearance.BorderSize = 0
        Me.bPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPilih.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPilih.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bPilih.Location = New System.Drawing.Point(151, 131)
        Me.bPilih.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bPilih.Name = "bPilih"
        Me.bPilih.Size = New System.Drawing.Size(129, 38)
        Me.bPilih.TabIndex = 86
        Me.bPilih.Text = "Pilih"
        Me.bPilih.UseVisualStyleBackColor = False
        '
        'pKembali
        '
        Me.pKembali.BackgroundImage = CType(resources.GetObject("pKembali.BackgroundImage"), System.Drawing.Image)
        Me.pKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pKembali.Location = New System.Drawing.Point(40, 143)
        Me.pKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(32, 26)
        Me.pKembali.TabIndex = 90
        Me.pKembali.TabStop = False
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
        Me.cIdTeater.Location = New System.Drawing.Point(40, 72)
        Me.cIdTeater.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cIdTeater.Name = "cIdTeater"
        Me.cIdTeater.Size = New System.Drawing.Size(240, 35)
        Me.cIdTeater.TabIndex = 114
        '
        'PopUpEditJadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 180)
        Me.ControlBox = False
        Me.Controls.Add(Me.cIdTeater)
        Me.Controls.Add(Me.pKembali)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bPilih)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PopUpEditJadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilih ID Jadwal"
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pKembali As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bPilih As Button
    Friend WithEvents cIdTeater As ComboBox
End Class
