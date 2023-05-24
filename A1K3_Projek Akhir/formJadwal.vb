Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing
Public Class formJadwal
    Private Sub HapusDataTanggalLewat()
        Dim currentDate As Date = Date.Now.Date

        CMD = New MySqlCommand("DELETE FROM JadwalTeater WHERE tanggal_pertunjukkan < @currentDate", CONN)
        CMD.Parameters.AddWithValue("@currentDate", currentDate)
        CMD.ExecuteNonQuery()
    End Sub

    Sub TampilJadwalTeater()
        Call KoneksiDatabase()
        HapusDataTanggalLewat()
        DA = New MySqlDataAdapter("SELECT * FROM JadwalTeater", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Jadwal Teater")
        DGVJadwalTeater.DataSource = DS.Tables("Jadwal Teater")
        DGVJadwalTeater.Refresh()
    End Sub

    Sub GridJadwalTeater()
        DGVJadwalTeater.Columns(0).Width = 90
        DGVJadwalTeater.Columns(1).Width = 135
        DGVJadwalTeater.Columns(2).Width = 125
        DGVJadwalTeater.Columns(3).Width = 60
        DGVJadwalTeater.Columns(4).Width = 60
        DGVJadwalTeater.Columns(5).Width = 80
        DGVJadwalTeater.Columns(6).Width = 110
        DGVJadwalTeater.Columns(7).Width = 85
        DGVJadwalTeater.Columns(8).Width = 95
        DGVJadwalTeater.Columns(9).Width = 125

        DGVJadwalTeater.Columns(0).HeaderText = "ID Teater"
        DGVJadwalTeater.Columns(1).HeaderText = "Judul Teater"
        DGVJadwalTeater.Columns(2).HeaderText = "Kelompok Teater"
        DGVJadwalTeater.Columns(3).HeaderText = "Genre"
        DGVJadwalTeater.Columns(4).HeaderText = "Hari"
        DGVJadwalTeater.Columns(5).HeaderText = "Tanggal"
        DGVJadwalTeater.Columns(6).HeaderText = "Waktu"
        DGVJadwalTeater.Columns(7).HeaderText = "Stok Tiket"
        DGVJadwalTeater.Columns(8).HeaderText = "Harga Tiket"
        DGVJadwalTeater.Columns(9).HeaderText = "Gambar"

    End Sub
    Private Sub formJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()

        TampilJadwalTeater()
        GridJadwalTeater()
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
    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DarkGray
            TampilJadwalTeater()
        End If
    End Sub

    Private Sub bTambahJadwal_Click(sender As Object, e As EventArgs) Handles bTambahJadwal.Click
        formTambah.Show()
    End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.FromArgb(132, 123, 112)
        End If

        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From JadwalTeater where judul like '%" & txtSearch.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From JadwalTeater where judul like '%" & txtSearch.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "Found")
                DGVJadwalTeater.DataSource = DS.Tables("Found")
                DGVJadwalTeater.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan!", MsgBoxStyle.Information, "Attention")
            End If
        End If

    End Sub
    Private Sub DGVJadwalTeater_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVJadwalTeater.CellDoubleClick
        Dim result As DialogResult = MessageBox.Show("Yakin ingin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim rowIndex As Integer = e.RowIndex
            Dim IdTeater As Integer = DGVJadwalTeater.Rows(rowIndex).Cells(0).Value
            DGVJadwalTeater.Rows.RemoveAt(rowIndex)
            CMD = New MySqlCommand("DELETE FROM JadwalTeater WHERE id_teater = " & IdTeater, CONN)
            CMD.ExecuteNonQuery()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        PopUpHapusJadwal.Show()
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        PopUpEditJadwal.Show()
    End Sub
End Class