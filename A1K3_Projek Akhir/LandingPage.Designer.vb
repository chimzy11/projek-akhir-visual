<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LandingPage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lSignIn = New System.Windows.Forms.Label()
        Me.lSignUp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(96, 214)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 736)
        Me.Panel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Stencil", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(86, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(241, 59)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "equiter"
        '
        'lSignIn
        '
        Me.lSignIn.AutoSize = True
        Me.lSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lSignIn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.lSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lSignIn.Location = New System.Drawing.Point(1595, 53)
        Me.lSignIn.Name = "lSignIn"
        Me.lSignIn.Size = New System.Drawing.Size(123, 37)
        Me.lSignIn.TabIndex = 9
        Me.lSignIn.Text = "Sign In"
        '
        'lSignUp
        '
        Me.lSignUp.AutoSize = True
        Me.lSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lSignUp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.lSignUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lSignUp.Location = New System.Drawing.Point(1749, 53)
        Me.lSignUp.Name = "lSignUp"
        Me.lSignUp.Size = New System.Drawing.Size(133, 37)
        Me.lSignUp.TabIndex = 10
        Me.lSignUp.Text = "Sign up"
        '
        'LandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.lSignUp)
        Me.Controls.Add(Me.lSignIn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LandingPage"
        Me.Text = "LandingPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lSignIn As Label
    Friend WithEvents lSignUp As Label
End Class
