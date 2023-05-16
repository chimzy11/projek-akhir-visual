Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class formJadwal


    Sub TampilJadwalTeater()
        DA = New MySqlDataAdapter("SELECT * FROM JadwalTeater", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Jadwal Teater")
        DGVJadwalTeater.DataSource = DS.Tables("Jadwal Teater")
        DGVJadwalTeater.Refresh()

        Dim imageColumn As New DataGridViewImageColumn()
        imageColumn.HeaderText = "Gambar"
        imageColumn.Name = "Gambar"
        imageColumn.DataPropertyName = "Gambar"
        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        DGVJadwalTeater.Columns.Insert(7, imageColumn)

        TampilkanGambarPadaGrid()
        GridJadwalTeater()
    End Sub

    Sub TampilkanGambarPadaGrid()
        For Each row As DataGridViewRow In DGVJadwalTeater.Rows
            Dim imagePath As String = row.Cells("Gambar").Value.ToString()

            If File.Exists(imagePath) Then
                Dim imageColumn As New DataGridViewImageColumn()
                imageColumn.HeaderText = "Gambar"
                imageColumn.Name = "Gambar"
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom

                Dim image As Image = Image.FromFile(imagePath)

                Dim bitmap As New Bitmap(image, 20, 20)
                row.Cells("Gambar").Value = bitmap

                DGVJadwalTeater.Columns.Insert(7, imageColumn)
            Else
                row.Cells("Gambar").Value = Nothing
            End If
        Next
    End Sub



    Sub GridJadwalTeater()
        DGVJadwalTeater.Columns(0).Width = 90
        DGVJadwalTeater.Columns(1).Width = 190
        DGVJadwalTeater.Columns(2).Width = 176
        DGVJadwalTeater.Columns(3).Width = 120
        DGVJadwalTeater.Columns(4).Width = 100
        DGVJadwalTeater.Columns(5).Width = 100
        DGVJadwalTeater.Columns(6).Width = 70
        DGVJadwalTeater.Columns(8).Width = 70
        DGVJadwalTeater.Columns(9).Width = 120

        DGVJadwalTeater.Columns(0).HeaderText = "ID Teater"
        DGVJadwalTeater.Columns(1).HeaderText = "Judul Teater"
        DGVJadwalTeater.Columns(2).HeaderText = "Kelompok Pemain"
        DGVJadwalTeater.Columns(3).HeaderText = "Tanggal Pertunjukkan"
        DGVJadwalTeater.Columns(4).HeaderText = "Waktu"
        DGVJadwalTeater.Columns(5).HeaderText = "Genre"
        DGVJadwalTeater.Columns(6).HeaderText = "Hari"
        DGVJadwalTeater.Columns(8).HeaderText = "Stok Tiket"
        DGVJadwalTeater.Columns(9).HeaderText = "Harga Tiket"
    End Sub


    Sub buttonrounded(btn As Button)
        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()
        radius.AddArc(New Rectangle(0, 0, 30, 30), 180, 90)
        radius.AddLine(30, 0, btn.Width - 30, 0)
        radius.AddArc(New Rectangle(btn.Width - 30, 0, 30, 30), -90, 90)
        radius.AddLine(btn.Width, 30, btn.Width, btn.Height - 30)
        radius.AddArc(New Rectangle(btn.Width - 30, btn.Height - 30, 30, 30), 0, 90)
        radius.AddLine(btn.Width - 30, btn.Height, 30, btn.Height)
        radius.AddArc(New Rectangle(0, btn.Height - 30, 30, 30), 90, 90)
        radius.CloseAllFigures()
        btn.Region = New Region(radius)
    End Sub
    Private Sub formJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        TampilJadwalTeater()
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub bTambahJadwal_Click(sender As Object, e As EventArgs) Handles bTambahJadwal.Click
        formTambah.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class