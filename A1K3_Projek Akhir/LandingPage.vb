Public Class LandingPage
    Private Sub lSignIn_Click(sender As Object, e As EventArgs) Handles lSignIn.Click
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub lSignUp_Click(sender As Object, e As EventArgs) Handles lSignUp.Click
        Me.Hide()
        FRegistrasi.Show()
    End Sub

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call KoneksiDatabase()
        Label9.BackColor = Color.Transparent
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        Label5.BackColor = Color.Transparent
        Label6.BackColor = Color.Transparent
        Button1.BackColor = Color.Transparent
        Button2.BackColor = Color.Transparent
        Button3.BackColor = Color.Transparent
        lSignIn.BackColor = Color.Transparent
        lSignUp.BackColor = Color.Transparent
        PictureBox1.BackColor = Color.Transparent
        Panel1.BackColor = Color.FromArgb(200, 221, 212, 199)
        Panel2.BackColor = Color.FromArgb(230, 132, 123, 112)
    End Sub

    Private Sub lSignOut_Click(sender As Object, e As EventArgs) Handles lSignOut.Click
        Dim X As String
        X = MessageBox.Show("Yakin keluar dari program ini?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If X = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class