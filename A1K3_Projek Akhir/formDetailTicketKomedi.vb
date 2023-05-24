Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports MySql.Data.MySqlClient
Public Class formDetailTicketKomedi
    Private currentChildForm As Form

    Private Sub OpenChildForm(childForm As Form)
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
    Private Sub formDetailTicketKomedi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Dim queryString As String = "SELECT * FROM JadwalTeater WHERE judul = @judul"

        CMD = New MySqlCommand(queryString, CONN)
        CMD.Parameters.AddWithValue("@judul", PopUpDataJadwalKomedi.cJudul.Text)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            lJudul.Text = RD.GetString(1)
            lHari.Text = RD.GetString(4)
            lWaktu.Text = RD.GetString(6)
            lHarga.Text = RD.GetString(8)
        End If
        RD.Close()

        Dim selectedSeats As New List(Of String)()

        For Each control As Control In formPesanKomedi.Panel2.Controls
            If TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked Then
                selectedSeats.Add(DirectCast(control, CheckBox).Text)
            End If
        Next

        lSeat.Text = String.Join(", ", selectedSeats)

        Dim updateQuery As String = "UPDATE transaksi SET seat = @seat WHERE id_transaksi = (SELECT MAX(id_transaksi) FROM transaksi)"

        CMD = New MySqlCommand(updateQuery, CONN)
        CMD.Parameters.AddWithValue("@seat", lSeat.Text)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub lExit_Click(sender As Object, e As EventArgs) Handles lExit.Click
        Dim queryString As String = "DELETE FROM JadwalTeater WHERE judul = @judul AND tiket = 0"

        CMD = New MySqlCommand(queryString, CONN)
        CMD.Parameters.AddWithValue("@judul", formPesanKomedi.lJudul.Text)
        CMD.ExecuteNonQuery()

        Me.Close()
        formPesanKomedi.Close()
        formDetailKomedi.Close()
        PopUpDataJadwalKomedi.Close()
        OpenChildForm(New formKomedi)
    End Sub
End Class