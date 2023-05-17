Public Class dashboardUser
    Private Sub dashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStripHome.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripTeater.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripAbout.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripProfile.ForeColor = Color.FromArgb(185, 174, 169)
    End Sub


    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.FromArgb(250, 246, 243)
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub MenuProfil_Click(sender As Object, e As EventArgs) Handles MenuProfil.Click
        Me.Close()
        fProfilUser.Show()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
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