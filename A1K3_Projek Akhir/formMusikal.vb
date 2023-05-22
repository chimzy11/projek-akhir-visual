Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml.Serialization
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class formMusikal
    Sub TampilDataTeater()
        Dim queryString As String = "SELECT COUNT(*) FROM JadwalTeater"

        CMD = New MySqlCommand(queryString, CONN)
        Dim jumlahBaris As Integer = CInt(CMD.ExecuteScalar())

        Dim queryString1 As String = "SELECT * FROM JadwalTeater where genre = @musikal"
        CMD = New MySqlCommand(queryString1, CONN)
        CMD.Parameters.AddWithValue("@musikal", "musikal")
        RD = CMD.ExecuteReader()

        Dim startX As Integer = 35
        Dim startY As Integer = 140
        Dim panelSpacing As Integer = 10
        Dim StartLabelX As Integer = 40
        Dim StartLabelY As Integer = 108
        Dim i As Integer

        While RD.Read()
            Dim judul As String = RD.GetString(1)
            Dim labelJudul As New Label()
            labelJudul.BackColor = Color.FromArgb(221, 212, 199)
            labelJudul.ForeColor = Color.FromArgb(132, 123, 112)
            labelJudul.TextAlign = ContentAlignment.MiddleCenter
            labelJudul.Font = New Font("microsoft yahei", 12, FontStyle.Bold)
            labelJudul.Text = judul
            labelJudul.Size = New Size(150, 30)
            labelJudul.Location = New Point(StartLabelX + i * 210, StartLabelY)
            Me.Controls.Add(labelJudul)

            Dim labelHarga As New Label()
            labelHarga.Text = RD.GetString(8)
            labelHarga.BackColor = Color.FromArgb(185, 174, 169)
            labelHarga.ForeColor = Color.White
            labelHarga.Font = New Font("microsoft yahei", 11, FontStyle.Bold)
            labelHarga.Size = New Size(60, 25)
            labelHarga.TextAlign = ContentAlignment.MiddleCenter
            labelHarga.Location = New Point((StartLabelX + 42) + (i) * 210, (StartLabelY + 37))
            Me.Controls.Add(labelHarga)

            Dim pictureBox As New PictureBox()
            pictureBox.Size = New Size(120, 120)
            pictureBox.Image = Image.FromFile("C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads\" + RD.GetString(9))
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            pictureBox.Location = New Point((startX + 20) + (200 + panelSpacing) * (i), (startY + 20))
            Me.Controls.Add(pictureBox)

            Dim myPanel As New Panel()
            myPanel.Size = New Size(160, 160)
            myPanel.BackColor = Color.FromArgb(185, 174, 169)
            myPanel.Location = New Point(startX + (200 + panelSpacing) * (i), startY)

            Me.Controls.Add(myPanel)
            i += 1
            If (i + 1) Mod 7 = 0 Then
                StartLabelX = -1225
                StartLabelY += 200
                startX = -1225
                startY += 200
            End If
        End While
        RD.Close()
    End Sub

    Private Sub formMusikal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        lblTanggal.Text = Today.ToString("dd/MM/yyyy")
        TampilDataTeater()

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Tombol diklik!")
    End Sub

    Private Sub bDetail_Click(sender As Object, e As EventArgs) Handles bDetail.Click
        formDetailTicket.Close()
        formPembayaran.Close()
        formPesan.Close()
        formDetailMusikal.Close()
        PopUpDataJadwal.Close()
        PopUpDataJadwal.Show()
    End Sub
End Class