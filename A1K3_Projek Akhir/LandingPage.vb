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
    End Sub
End Class