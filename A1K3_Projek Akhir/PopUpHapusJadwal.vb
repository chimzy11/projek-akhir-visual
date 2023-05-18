Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml.Serialization
Public Class PopUpHapusJadwal
    Private currentChildForm As Form
    Private Sub OpenChildForm(childForm As Form)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        DashboardAdmin.panelDesktop.Controls.Add(childForm)
        DashboardAdmin.panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        If Not String.IsNullOrEmpty(cIdTeater.Text) Then
            If cIdTeater.SelectedIndex = 0 Then
                MessageBox.Show("Pilih ID teater yang akan dihapus", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim confirmResult As DialogResult = MessageBox.Show("Anda yakin ingin menghapus data jadwal teater dengan ID " & cIdTeater.Text & "?", "Konfirmasi Hapus Data", MessageBoxButtons.YesNo)

                If confirmResult = DialogResult.Yes Then
                    CMD = New MySqlCommand("DELETE FROM JadwalTeater WHERE id_teater = @idTeater", CONN)
                    CMD.Parameters.AddWithValue("@idTeater", cIdTeater.Text)
                    CMD.ExecuteNonQuery()

                    MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Perhatian")
                    Me.Close()
                    OpenChildForm(New formJadwal)
                End If
            End If
        Else
            MessageBox.Show("Pilih ID teater yang akan dihapus", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub FHapusJadwalTeater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Dim queryString As String = "SELECT id_teater FROM JadwalTeater"

        CMD = New MySqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader()

        While RD.Read()
            cIdTeater.Items.Add(RD.GetString("id_teater"))
        End While

        RD.Close()


        If cIdTeater.Items.Count > 0 Then
            cIdTeater.SelectedIndex = 0
        End If
    End Sub

    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Close()
    End Sub
End Class