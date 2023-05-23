Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class formTransaksi

    Sub TampilDataRiwayatTransaksi()
        DA = New MySqlDataAdapter("SELECT kode_pembayaran, nama, email, judul, jumlah, harga, total_transaksi, seat, tanggal, gambar_bukti FROM transaksi", CONN)
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
        DGVTransaksiUser.Columns(7).Width = 70
        DGVTransaksiUser.Columns(8).Width = 70
        DGVTransaksiUser.Columns(9).Width = 70

        DGVTransaksiUser.Columns(0).HeaderText = "Kode Pembayaran"
        DGVTransaksiUser.Columns(1).HeaderText = "Nama Lengkap"
        DGVTransaksiUser.Columns(2).HeaderText = "E-Mail"
        DGVTransaksiUser.Columns(3).HeaderText = "Judul"
        DGVTransaksiUser.Columns(4).HeaderText = "Jumlah Tiket"
        DGVTransaksiUser.Columns(5).HeaderText = "Harga"
        DGVTransaksiUser.Columns(6).HeaderText = "Total Transaksi"
        DGVTransaksiUser.Columns(7).HeaderText = "Seat"
        DGVTransaksiUser.Columns(7).HeaderText = "Tanggal"
        DGVTransaksiUser.Columns(8).HeaderText = "Gambar Bukti"
    End Sub

    Private Sub formTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        TampilDataRiwayatTransaksi()
        GridDataRiwayatTransaksi()
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DarkGray
            TampilDataRiwayatTransaksi()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.FromArgb(132, 123, 112)
        End If

        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("SELECT kode_pembayaran, nama, email, judul, jumlah, harga, total_transaksi, seat, tanggal, gambar_bukti FROM transaksi where judul like '%" & txtSearch.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("SELECT kode_pembayaran, nama, email, judul, jumlah, harga, total_transaksi, seat, tanggal, gambar_bukti FROM transaksi where judul like '%" & txtSearch.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "Found")
                DGVTransaksiUser.DataSource = DS.Tables("Found")
                DGVTransaksiUser.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan!", MsgBoxStyle.Information, "Attention")
            End If
        End If
    End Sub

    Private Sub DGVTransaksiUser_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVTransaksiUser.CellDoubleClick
        Dim result As DialogResult = MessageBox.Show("Yakin ingin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim rowIndex As Integer = e.RowIndex
            Dim Kode_Pembayaran As String = DGVTransaksiUser.Rows(rowIndex).Cells(0).Value
            DGVTransaksiUser.Rows.RemoveAt(rowIndex)
            CMD = New MySqlCommand("DELETE FROM transaksi WHERE kode_pembayaran = " & Kode_Pembayaran, CONN)
            CMD.ExecuteNonQuery()
            formDashboard.DataTransaksiChanged()
        Else
            Exit Sub
        End If
    End Sub
End Class
