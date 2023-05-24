Imports MySql.Data.MySqlClient

Public Class formRiwayatUser
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
    Private Sub formRiwayatUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        formMusikal.Close()
        formKomedi.Close()
        formDrama.Close()
        fProfilUser.Close()
        DashboardUser.Close()
        TampilDataRiwayatTransaksi()
        GridDataRiwayatTransaksi()
    End Sub
    Sub TampilDataRiwayatTransaksi()
        CMD = New MySqlCommand("SELECT * FROM akun WHERE username = @Username", CONN)
        CMD.Parameters.AddWithValue("@Username", FLogin.tUsername.Text)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            Dim id_akun As Integer = RD.GetInt32(0)
            RD.Close()

            Dim query As String = "SELECT kode_pembayaran, judul, jumlah, harga, total_transaksi, seat, tanggal, gambar_bukti FROM transaksi WHERE id_akun = @id_akun"
            DA = New MySqlDataAdapter(query, CONN)
            DA.SelectCommand.Parameters.AddWithValue("@id_akun", id_akun)

            DS = New DataSet
            DS.Clear()
            DA.Fill(DS, "Data User")
            DGVTransaksiUser.DataSource = DS.Tables("Data User")
            DGVTransaksiUser.Refresh()
        Else
            RD.Close()
        End If

    End Sub
    Sub GridDataRiwayatTransaksi()

        DGVTransaksiUser.Columns(0).Width = 120
        DGVTransaksiUser.Columns(1).Width = 180
        DGVTransaksiUser.Columns(2).Width = 100
        DGVTransaksiUser.Columns(3).Width = 120
        DGVTransaksiUser.Columns(4).Width = 100
        DGVTransaksiUser.Columns(5).Width = 120
        DGVTransaksiUser.Columns(6).Width = 150
        DGVTransaksiUser.Columns(7).Width = 150

        DGVTransaksiUser.Columns(0).HeaderText = "Kode Pembayaran"
        DGVTransaksiUser.Columns(1).HeaderText = "Judul"
        DGVTransaksiUser.Columns(2).HeaderText = "Jumlah Tiket"
        DGVTransaksiUser.Columns(3).HeaderText = "Harga"
        DGVTransaksiUser.Columns(4).HeaderText = "Total Transaksi"
        DGVTransaksiUser.Columns(5).HeaderText = "Seat"
        DGVTransaksiUser.Columns(6).HeaderText = "Tanggal"
        DGVTransaksiUser.Columns(7).HeaderText = "Gambar Bukti"
    End Sub

    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Hide()
        DashboardUser.Show()
    End Sub

    Private Sub DGVTransaksiUser_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVTransaksiUser.CellDoubleClick
        Dim result As DialogResult = MessageBox.Show("Cetak Tiket?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim i As Integer
            i = Me.DGVTransaksiUser.CurrentRow.Index
            With DGVTransaksiUser.Rows.Item(i)
                formTiketUser.lJudul.Text = .Cells(1).Value
                formTiketUser.lSeat.Text = .Cells(5).Value
                formTiketUser.lHarga.Text = .Cells(3).Value

                CMD = New MySqlCommand("SELECT j.hari, j.waktu FROM jadwalteater j INNER JOIN transaksi t ON j.id_teater = t.id_teater WHERE j.judul = @judul AND t.judul = @judul", CONN)
                CMD.Parameters.AddWithValue("@judul", .Cells(1).Value)
                RD = CMD.ExecuteReader()

                If RD.Read() Then
                    Dim hari As String = RD.GetString(0)
                    Dim waktu As String = RD.GetString(1)
                    formTiketUser.lHari.Text = hari
                    formTiketUser.lWaktu.Text = waktu
                End If

                RD.Close()
            End With

            formTiketUser.Show()
        Else
            Exit Sub
        End If
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

        CMD = New MySqlCommand("SELECT * FROM akun WHERE username = @Username", CONN)
        CMD.Parameters.AddWithValue("@Username", FLogin.tUsername.Text)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            Dim id_akun As Integer = RD.GetInt32(0)
            RD.Close()

            If e.KeyChar = Chr(13) Then
                CMD = New MySqlCommand("SELECT kode_pembayaran, nama, email, judul, jumlah, harga, total_transaksi, seat, tanggal, gambar_bukti FROM transaksi WHERE judul LIKE @Search AND id_akun = @id_akun", CONN)
                CMD.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")
                CMD.Parameters.AddWithValue("@id_akun", id_akun)
                RD = CMD.ExecuteReader()

                If RD.HasRows Then
                    RD.Close()
                    DA = New MySqlDataAdapter("SELECT kode_pembayaran, nama, email, judul, jumlah, harga, total_transaksi, seat, tanggal, gambar_bukti FROM transaksi WHERE judul LIKE @Search AND id_akun = @id_akun", CONN)
                    DA.SelectCommand.Parameters.AddWithValue("@Search", "%" & txtSearch.Text & "%")
                    DA.SelectCommand.Parameters.AddWithValue("@id_akun", id_akun)
                    DS = New DataSet
                    DA.Fill(DS, "Found")
                    DGVTransaksiUser.DataSource = DS.Tables("Found")
                    DGVTransaksiUser.ReadOnly = True
                Else
                    RD.Close()
                    MsgBox("Data tidak ditemukan!", MsgBoxStyle.Information, "Attention")
                End If
            End If
        End If

    End Sub
End Class