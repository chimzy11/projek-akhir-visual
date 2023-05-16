Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FJenisTiketTeater

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

    Private Sub lExit_Click(sender As Object, e As EventArgs) Handles lExit.Click
        Me.Close()
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        formTambah.bSimpan.Enabled = True
        MsgBox("Jenis Tiket Berhasil Ditambahkan",
        MsgBoxStyle.Information, "Perhatian")
        Me.Hide()
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click

    End Sub

    Private Sub FJenisTiketTeater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class