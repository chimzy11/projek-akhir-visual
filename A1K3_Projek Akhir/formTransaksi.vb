Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class formTransaksi

    Sub TampilDataRiwayatTransaksi()
        DA = New MySqlDataAdapter("SELECT kode_pembayaran, nama, email, judul, jumlah, harga, gambar_bukti FROM transaksi", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Data User")
        DGVTransaksiUser.DataSource = DS.Tables("Data User")
        DGVTransaksiUser.Refresh()
    End Sub

    Sub GridDataRiwayatTransaksi()
        DGVTransaksiUser.Columns(0).Width = 90
        DGVTransaksiUser.Columns(1).Width = 100
        DGVTransaksiUser.Columns(2).Width = 100
        DGVTransaksiUser.Columns(3).Width = 100
        DGVTransaksiUser.Columns(4).Width = 100
        DGVTransaksiUser.Columns(5).Width = 70
        DGVTransaksiUser.Columns(6).Width = 70

        DGVTransaksiUser.Columns(0).HeaderText = "Kode Pembayaran"
        DGVTransaksiUser.Columns(1).HeaderText = "Nama Lengkap"
        DGVTransaksiUser.Columns(2).HeaderText = "E-Mail"
        DGVTransaksiUser.Columns(3).HeaderText = "Judul"
        DGVTransaksiUser.Columns(4).HeaderText = "Jumlah Tiket"
        DGVTransaksiUser.Columns(5).HeaderText = "Harga"
        DGVTransaksiUser.Columns(6).HeaderText = "Gambar Bukti"
    End Sub




    Private Sub formTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        TampilDataRiwayatTransaksi()
        GridDataRiwayatTransaksi()
    End Sub

    Private Sub DGVTransaksiUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTransaksiUser.CellContentClick

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class
