Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class formDetailMusikal

    Sub TampilProfilJadwal()
        Call KoneksiDatabase()
        Dim queryString As String = "SELECT gambar FROM JadwalTeater WHERE judul = @judul"

        CMD = New MySqlCommand(queryString, CONN)
        CMD.Parameters.AddWithValue("@judul", PopUpDataJadwal.cJudul.Text)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            Dim imageName As String = RD.GetString(0)
            Dim imagePath As String = Path.Combine("C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads", imageName)

            If File.Exists(imagePath) Then
                Dim image As Image = Image.FromFile(imagePath)
                pTeater.SizeMode = PictureBoxSizeMode.StretchImage
                pTeater.Image = image
            End If
        End If

        RD.Close()
    End Sub

    Private Sub formDetailMusikal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Call TampilProfilJadwal()

        Dim queryString As String = "SELECT * FROM JadwalTeater WHERE judul ='" & PopUpDataJadwal.cJudul.Text & "'"

        CMD = New MySqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            lJudul.Text = RD.GetString(1)
            lKelompok.Text = RD.GetString(2)
            lGenre.Text = RD.GetString(3)
            lHari.Text = RD.GetString(4)
            lTanggal.Text = RD.GetString(5)
            lWaktu.Text = RD.GetString(6)
            lStokTiket.Text = RD.GetString(7)
            lHarga.Text = RD.GetString(8)
        End If

        RD.Close()
    End Sub

    Private Sub bPesan_Click(sender As Object, e As EventArgs) Handles bPesan.Click
        Me.Hide()
        formPesan.Show()
    End Sub
End Class