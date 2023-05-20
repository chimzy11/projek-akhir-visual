<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fProfilUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fProfilUser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lUsername = New System.Windows.Forms.Label()
        Me.pSampul = New System.Windows.Forms.Panel()
        Me.bLogOut = New System.Windows.Forms.Button()
        Me.bHapusAkun = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.bBatal = New System.Windows.Forms.Button()
        Me.bSimpan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tNotelp = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tEmail = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tNamaLengkap = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.bEdit = New System.Windows.Forms.Button()
        Me.lNamaLengkap = New System.Windows.Forms.Label()
        Me.pChangeProfil = New System.Windows.Forms.PictureBox()
        Me.pProfil = New System.Windows.Forms.PictureBox()
        Me.pKembali = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.pSampul.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.pChangeProfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pProfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pKembali)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1710, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Stencil", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(818, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 32)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Profil"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lUsername
        '
        Me.lUsername.AutoSize = True
        Me.lUsername.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lUsername.Location = New System.Drawing.Point(124, 446)
        Me.lUsername.Name = "lUsername"
        Me.lUsername.Size = New System.Drawing.Size(167, 40)
        Me.lUsername.TabIndex = 9
        Me.lUsername.Text = "Username"
        '
        'pSampul
        '
        Me.pSampul.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.pSampul.Controls.Add(Me.bLogOut)
        Me.pSampul.Controls.Add(Me.bHapusAkun)
        Me.pSampul.Dock = System.Windows.Forms.DockStyle.Top
        Me.pSampul.Location = New System.Drawing.Point(0, 64)
        Me.pSampul.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pSampul.Name = "pSampul"
        Me.pSampul.Size = New System.Drawing.Size(1710, 1600)
        Me.pSampul.TabIndex = 9
        '
        'bLogOut
        '
        Me.bLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bLogOut.FlatAppearance.BorderSize = 0
        Me.bLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLogOut.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bLogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.bLogOut.Location = New System.Drawing.Point(64, 626)
        Me.bLogOut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bLogOut.Name = "bLogOut"
        Me.bLogOut.Size = New System.Drawing.Size(275, 38)
        Me.bLogOut.TabIndex = 12
        Me.bLogOut.Text = "Logout"
        Me.bLogOut.UseVisualStyleBackColor = False
        '
        'bHapusAkun
        '
        Me.bHapusAkun.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bHapusAkun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bHapusAkun.FlatAppearance.BorderSize = 0
        Me.bHapusAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHapusAkun.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bHapusAkun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bHapusAkun.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.bHapusAkun.Location = New System.Drawing.Point(64, 571)
        Me.bHapusAkun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bHapusAkun.Name = "bHapusAkun"
        Me.bHapusAkun.Size = New System.Drawing.Size(275, 38)
        Me.bHapusAkun.TabIndex = 56
        Me.bHapusAkun.Text = "Hapus Akun"
        Me.bHapusAkun.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(407, 326)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1304, 599)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(34, 27)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1304, 599)
        Me.Panel4.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Panel5.Controls.Add(Me.bBatal)
        Me.Panel5.Controls.Add(Me.bSimpan)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.tPassword)
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.tNotelp)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.tEmail)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.tNamaLengkap)
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Location = New System.Drawing.Point(40, 34)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1304, 599)
        Me.Panel5.TabIndex = 12
        '
        'bBatal
        '
        Me.bBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBatal.FlatAppearance.BorderSize = 0
        Me.bBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBatal.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bBatal.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.bBatal.Location = New System.Drawing.Point(1065, 9)
        Me.bBatal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bBatal.Name = "bBatal"
        Me.bBatal.Size = New System.Drawing.Size(155, 41)
        Me.bBatal.TabIndex = 57
        Me.bBatal.Text = "Batal"
        Me.bBatal.UseVisualStyleBackColor = False
        Me.bBatal.Visible = False
        '
        'bSimpan
        '
        Me.bSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bSimpan.FlatAppearance.BorderSize = 0
        Me.bSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSimpan.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSimpan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bSimpan.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.bSimpan.Location = New System.Drawing.Point(860, 9)
        Me.bSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(155, 41)
        Me.bSimpan.TabIndex = 56
        Me.bSimpan.Text = "Simpan"
        Me.bSimpan.UseVisualStyleBackColor = False
        Me.bSimpan.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(178, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 27)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Password"
        '
        'tPassword
        '
        Me.tPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tPassword.Enabled = False
        Me.tPassword.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tPassword.Location = New System.Drawing.Point(387, 390)
        Me.tPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.Size = New System.Drawing.Size(424, 22)
        Me.tPassword.TabIndex = 53
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(380, 382)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(434, 38)
        Me.Button5.TabIndex = 54
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(178, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 27)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "No Hp"
        '
        'tNotelp
        '
        Me.tNotelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tNotelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tNotelp.Enabled = False
        Me.tNotelp.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNotelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tNotelp.Location = New System.Drawing.Point(387, 294)
        Me.tNotelp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tNotelp.Name = "tNotelp"
        Me.tNotelp.Size = New System.Drawing.Size(424, 22)
        Me.tNotelp.TabIndex = 50
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(380, 286)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(434, 38)
        Me.Button4.TabIndex = 51
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(178, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 27)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Email"
        '
        'tEmail
        '
        Me.tEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tEmail.Enabled = False
        Me.tEmail.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tEmail.Location = New System.Drawing.Point(387, 196)
        Me.tEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tEmail.Name = "tEmail"
        Me.tEmail.Size = New System.Drawing.Size(424, 22)
        Me.tEmail.TabIndex = 47
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(380, 186)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(434, 38)
        Me.Button2.TabIndex = 48
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(174, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 27)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Lengkap"
        '
        'tNamaLengkap
        '
        Me.tNamaLengkap.AcceptsReturn = True
        Me.tNamaLengkap.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tNamaLengkap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tNamaLengkap.Enabled = False
        Me.tNamaLengkap.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNamaLengkap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.tNamaLengkap.Location = New System.Drawing.Point(382, 94)
        Me.tNamaLengkap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tNamaLengkap.Name = "tNamaLengkap"
        Me.tNamaLengkap.Size = New System.Drawing.Size(424, 22)
        Me.tNamaLengkap.TabIndex = 44
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Stencil", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(382, 86)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(434, 38)
        Me.Button3.TabIndex = 45
        Me.Button3.UseVisualStyleBackColor = False
        '
        'bEdit
        '
        Me.bEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.bEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEdit.FlatAppearance.BorderSize = 0
        Me.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEdit.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.bEdit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.bEdit.Location = New System.Drawing.Point(64, 581)
        Me.bEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bEdit.Name = "bEdit"
        Me.bEdit.Size = New System.Drawing.Size(275, 38)
        Me.bEdit.TabIndex = 11
        Me.bEdit.Text = "Edit Profile"
        Me.bEdit.UseVisualStyleBackColor = False
        '
        'lNamaLengkap
        '
        Me.lNamaLengkap.AutoSize = True
        Me.lNamaLengkap.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNamaLengkap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lNamaLengkap.Location = New System.Drawing.Point(125, 490)
        Me.lNamaLengkap.Name = "lNamaLengkap"
        Me.lNamaLengkap.Size = New System.Drawing.Size(165, 27)
        Me.lNamaLengkap.TabIndex = 55
        Me.lNamaLengkap.Text = "Nama Lengkap"
        '
        'pChangeProfil
        '
        Me.pChangeProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pChangeProfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pChangeProfil.Image = CType(resources.GetObject("pChangeProfil.Image"), System.Drawing.Image)
        Me.pChangeProfil.Location = New System.Drawing.Point(260, 372)
        Me.pChangeProfil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pChangeProfil.Name = "pChangeProfil"
        Me.pChangeProfil.Size = New System.Drawing.Size(44, 41)
        Me.pChangeProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pChangeProfil.TabIndex = 0
        Me.pChangeProfil.TabStop = False
        '
        'pProfil
        '
        Me.pProfil.BackColor = System.Drawing.Color.Transparent
        Me.pProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pProfil.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.pProfil.Location = New System.Drawing.Point(94, 229)
        Me.pProfil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pProfil.Name = "pProfil"
        Me.pProfil.Size = New System.Drawing.Size(208, 199)
        Me.pProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pProfil.TabIndex = 8
        Me.pProfil.TabStop = False
        '
        'pKembali
        '
        Me.pKembali.BackgroundImage = CType(resources.GetObject("pKembali.BackgroundImage"), System.Drawing.Image)
        Me.pKembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pKembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pKembali.Location = New System.Drawing.Point(30, 20)
        Me.pKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pKembali.Name = "pKembali"
        Me.pKembali.Size = New System.Drawing.Size(34, 28)
        Me.pKembali.TabIndex = 106
        Me.pKembali.TabStop = False
        '
        'fProfilUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1710, 840)
        Me.Controls.Add(Me.pChangeProfil)
        Me.Controls.Add(Me.lNamaLengkap)
        Me.Controls.Add(Me.bEdit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lUsername)
        Me.Controls.Add(Me.pProfil)
        Me.Controls.Add(Me.pSampul)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "fProfilUser"
        Me.Text = "fProfilUser"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pSampul.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.pChangeProfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pProfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents pProfil As PictureBox
    Friend WithEvents lUsername As Label
    Friend WithEvents pSampul As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bEdit As Button
    Friend WithEvents bLogOut As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tEmail As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tNamaLengkap As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tPassword As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tNotelp As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents lNamaLengkap As Label
    Friend WithEvents bBatal As Button
    Friend WithEvents bSimpan As Button
    Friend WithEvents pKembali As PictureBox
    Friend WithEvents bHapusAkun As Button
    Friend WithEvents pChangeProfil As PictureBox
End Class
