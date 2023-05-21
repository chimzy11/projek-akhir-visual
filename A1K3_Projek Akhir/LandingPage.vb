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
        Panel1.BackColor = Color.FromArgb(200, 221, 212, 199)
        Panel2.BackColor = Color.FromArgb(230, 132, 123, 112)

        ' Mengatur warna latar belakang dengan tingkat transparansi setengah


    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub
End Class