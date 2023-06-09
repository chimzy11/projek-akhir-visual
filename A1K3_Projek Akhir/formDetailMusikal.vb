﻿Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class formDetailMusikal
    Private currentChildForm As Form

    Sub FileMusikal()
        Dim jumlahTiket As Integer = 0
        Dim queryString As String = "SELECT * FROM JadwalTeater WHERE judul = @judul"

        CMD = New MySqlCommand(queryString, CONN)
        CMD.Parameters.AddWithValue("@judul", PopUpDataJadwal.cJudul.Text)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            jumlahTiket = RD.GetInt32(7)

            Dim fileMusikal As String = "Musikal_" + PopUpDataJadwal.cJudul.Text.Replace(" ", "_") + ".txt"
            If Not File.Exists(fileMusikal) Then
                Dim nama As Char = "A"c
                Dim nomorKursi As Integer = 1

                Dim writer As New StreamWriter(fileMusikal)

                For i As Integer = 0 To jumlahTiket - 1
                    Dim kursi As String = nama.ToString() & nomorKursi.ToString()
                    writer.WriteLine(kursi & ",False")

                    nomorKursi += 1
                    If nomorKursi > 9 Then
                        nomorKursi = 1
                        If nama < "Z"c Then
                            nama = Chr(Asc(nama) + 1)
                        End If
                    End If
                Next

                writer.Close()
            End If
        End If

        RD.Close()
    End Sub
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
        FileMusikal()
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

    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Hide()
        PopUpDataJadwal.Close()
        OpenChildForm(New formMusikal)
    End Sub
End Class