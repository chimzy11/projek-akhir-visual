Public Class formTransaksi
    Private Sub GridDataTransaksi()
        DataGridView1.Columns.Clear() ' Hapus semua kolom sebelum menambahkan kolom baru

        DataGridView1.Columns.Add("NamaPengirim", "Nama Pengirim")
        DataGridView1.Columns.Add("NamaPenerima", "Nama Penerima")
        DataGridView1.Columns.Add("JumlahTiket", "Jumlah Tiket")
        DataGridView1.Columns.Add("JudulTeater", "Judul Teater")
        DataGridView1.Columns.Add("NoRekeningPengirim", "No Rekening Pengirim")
        DataGridView1.Columns.Add("NoRekeningPenerima", "No Rekening Penerima")
        DataGridView1.Columns.Add("Total", "Total")

        DataGridView1.Columns(0).Width = 140
        DataGridView1.Columns(1).Width = 140
        DataGridView1.Columns(2).Width = 70
        DataGridView1.Columns(3).Width = 160
        DataGridView1.Columns(4).Width = 180
        DataGridView1.Columns(5).Width = 190
        DataGridView1.Columns(6).Width = 90
    End Sub



    Private Sub formTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridDataTransaksi()
    End Sub
End Class
