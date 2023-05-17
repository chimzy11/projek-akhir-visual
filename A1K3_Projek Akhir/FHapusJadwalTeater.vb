Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml.Serialization
Public Class FHapusJadwalTeater
    Private currentChildForm As Form
    Private Sub OpenChildForm(childForm As Form)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        dashboardAdmin.panelDesktop.Controls.Add(childForm)
        dashboardAdmin.panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub tIdTeater_Enter(sender As Object, e As EventArgs) Handles tIdTeater.Enter
        If tIdTeater.Text = "ID " Then
            tIdTeater.Text = ""
            tIdTeater.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub tIdTeater_Leave(sender As Object, e As EventArgs) Handles tIdTeater.Leave
        If tIdTeater.Text = "" Then
            tIdTeater.Text = "ID "
            tIdTeater.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub
    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Try
            Dim idTeater As Integer = Integer.Parse(tIdTeater.Text)
            CMD = New MySqlCommand("DELETE FROM JadwalTeater WHERE id_teater = " & idTeater, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Perhatian")
            Me.Close()
            OpenChildForm(New formJadwal)
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menghapus data: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try
    End Sub

    Private Sub FHapusJadwalTeater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
    End Sub
    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Close()
    End Sub
End Class