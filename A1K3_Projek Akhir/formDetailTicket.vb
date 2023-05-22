Imports MySql.Data.MySqlClient

Public Class formDetailTicket
    Private currentChildForm As Form

    Private Sub OpenChildForm(childForm As Form)
        'open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        DashboardUser.panelDesktop.Controls.Add(childForm)
        DashboardUser.panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub formDetailTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Dim queryString As String = "SELECT * FROM JadwalTeater WHERE judul ='" & PopUpDataJadwal.cJudul.Text & "'"

        CMD = New MySqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            lJudul.Text = RD.GetString(1)
            lHari.Text = RD.GetString(4)
            lWaktu.Text = RD.GetString(6)
            lHarga.Text = RD.GetString(8)
        End If

        RD.Close()
    End Sub

    Private Sub lExit_Click(sender As Object, e As EventArgs) Handles lExit.Click
        'Dim queryString As String = "DELETE FROM JadwalTeater WHERE judul = @judul AND tiket = 0"

        'CMD = New MySqlCommand(queryString, CONN)
        'CMD.Parameters.AddWithValue("@judul", formPesan.lJudul.Text)
        'CMD.ExecuteNonQuery()

        Me.Close()
        formPembayaran.Close()
        formPesan.Close()
        formDetailMusikal.Close()
        PopUpDataJadwal.Close()
        OpenChildForm(New formHome)
    End Sub
End Class