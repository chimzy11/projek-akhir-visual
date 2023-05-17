Public Class fProfilUser
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        txtEmail.Enabled = True
        txtNamaLengkap.Enabled = True
        txtNo.Enabled = True
        txtPass.Enabled = True
        btnBatal.Visible = True
        btnSimpan.Visible = True
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtEmail.Enabled = False
        txtNamaLengkap.Enabled = False
        txtNo.Enabled = False
        txtPass.Enabled = False
        btnBatal.Visible = False
        btnSimpan.Visible = False
    End Sub
End Class