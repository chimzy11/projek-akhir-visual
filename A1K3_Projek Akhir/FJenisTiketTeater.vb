Public Class FJenisTiketTeater
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub FJenisTiketTeater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtHargaVIP_TextChanged(sender As Object, e As EventArgs) Handles txtHargaVIP.TextChanged

    End Sub

    Private Sub txtHargaVIP_Enter(sender As Object, e As EventArgs) Handles txtHargaVIP.Enter
        If txtHargaVIP.Text = "Rp" Then
            txtHargaVIP.Text = ""
            txtHargaVIP.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub txtHargaVIP_Leave(sender As Object, e As EventArgs) Handles txtHargaVIP.Leave
        If txtHargaVIP.Text = "" Then
            txtHargaVIP.Text = "Rp"
            txtHargaVIP.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub txtHargaPremium_TextChanged(sender As Object, e As EventArgs) Handles txtHargaPremium.TextChanged

    End Sub

    Private Sub txtHargaPremium_Enter(sender As Object, e As EventArgs) Handles txtHargaPremium.Enter
        If txtHargaPremium.Text = "Rp" Then
            txtHargaPremium.Text = ""
            txtHargaPremium.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub txtHargaPremium_Leave(sender As Object, e As EventArgs) Handles txtHargaPremium.Leave
        If txtHargaPremium.Text = "" Then
            txtHargaPremium.Text = "Rp"
            txtHargaPremium.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub txtHargaReguler_TextChanged(sender As Object, e As EventArgs) Handles txtHargaReguler.TextChanged

    End Sub

    Private Sub txtHargaReguler_Enter(sender As Object, e As EventArgs) Handles txtHargaReguler.Enter
        If txtHargaReguler.Text = "Rp" Then
            txtHargaReguler.Text = ""
            txtHargaReguler.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub txtHargaReguler_Leave(sender As Object, e As EventArgs) Handles txtHargaReguler.Leave
        If txtHargaReguler.Text = "" Then
            txtHargaReguler.Text = "Rp"
            txtHargaReguler.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub
End Class