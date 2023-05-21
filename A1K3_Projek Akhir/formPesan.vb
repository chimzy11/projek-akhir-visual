Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Public Class formPesan

    Dim Total As Integer = 0
    Dim HargaPerTiket As Integer = 0
    Dim jumlahTiket As Integer = 0
    Dim selectedSeats As New List(Of CheckBox)()

    Sub PilihanKursi()
        Dim queryString As String = "SELECT * FROM JadwalTeater WHERE judul = @judul"

        CMD = New MySqlCommand(queryString, CONN)
        CMD.Parameters.AddWithValue("@judul", PopUpDataJadwal.cJudul.Text)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            jumlahTiket = RD.GetInt32(7)
            Dim numCheckboxes As Integer = jumlahTiket
            Dim checkBoxesPerRow As Integer = 10
            Dim checkBoxWidth As Integer = 40
            Dim checkBoxHeight As Integer = 30

            Dim nama As Char = "A"c

            For i As Integer = 0 To numCheckboxes - 1
                Dim checkBox As New CheckBox()
                checkBox.Name = "A" & i.ToString()
                checkBox.Text = nama.ToString() & i.ToString()
                checkBox.AutoSize = True ' Mengatur AutoSize ke True
                Dim row As Integer = i \ checkBoxesPerRow
                Dim col As Integer = i Mod checkBoxesPerRow
                Dim x As Integer = 33 + col * (checkBoxWidth + 5)
                Dim y As Integer = 43 + row * (checkBoxHeight + 5)
                checkBox.Location = New Point(x, y)
                checkBox.Width = checkBoxWidth ' Mengatur lebar CheckBox
                checkBox.Enabled = False
                AddHandler checkBox.CheckedChanged, AddressOf CheckBox_CheckedChanged ' Menambahkan event handler CheckedChanged
                Panel2.Controls.Add(checkBox)

                If (i + 1) Mod 10 = 0 Then
                    If nama < "Z"c Then
                        nama = Chr(Asc(nama) + 1)
                    End If
                End If
            Next
        End If

        RD.Close()
    End Sub
    Private Sub formPesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        PilihanKursi()

        tBanyakTiket.Focus()

        Dim queryString As String = "SELECT * FROM JadwalTeater WHERE judul = @judul"

        CMD = New MySqlCommand(queryString, CONN)
        CMD.Parameters.AddWithValue("@judul", PopUpDataJadwal.cJudul.Text)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            lJudul.Text = RD.GetString(1)
            HargaPerTiket = RD.GetInt32(8) ' Simpan harga per tiket dari database
        End If

        RD.Close()

        Dim queryString1 As String = "SELECT * FROM akun WHERE username = @username"

        CMD = New MySqlCommand(queryString1, CONN)
        CMD.Parameters.AddWithValue("@username", FLogin.tUsername.Text)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            lUsername.Text = RD.GetString(3)
        End If

        RD.Close()
    End Sub

    Private Sub tBanyakTiket_TextChanged(sender As Object, e As EventArgs) Handles tBanyakTiket.TextChanged
        Dim BanyakTiket As Integer = 0

        If Integer.TryParse(tBanyakTiket.Text, BanyakTiket) Then
            If (BanyakTiket > jumlahTiket) Then
                MessageBox.Show("Banyak tiket tidak boleh lebih dari banyak kursi yang tersisa", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tBanyakTiket.Focus()
                Return
            End If

            For Each checkBox As CheckBox In Panel2.Controls.OfType(Of CheckBox)()
                checkBox.Enabled = True ' Mengaktifkan semua cekbox
            Next

            Total = BanyakTiket * HargaPerTiket ' Hitung total harga
            lTotalHarga.Text = Total.ToString()
        Else
            lTotalHarga.Text = "0" ' Tampilkan 0 jika input tidak valid
        End If

        If BanyakTiket = 0 Then
            For Each checkBox As CheckBox In Panel2.Controls.OfType(Of CheckBox)()
                checkBox.Enabled = False ' Mengaktifkan semua cekbox
                tBanyakTiket.Focus()
            Next
        End If
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) 
        Dim checkBox As CheckBox = CType(sender, CheckBox)

        If checkBox.Checked Then
            If selectedSeats.Count >= jumlahTiket Then
                MessageBox.Show("Jumlah tiket yang dipilih melebihi jumlah kursi yang tersedia", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
                checkBox.Checked = False
            Else
                selectedSeats.Add(checkBox)
            End If
        Else
            selectedSeats.Remove(checkBox)
        End If
    End Sub

    Private Sub bPembayaran_Click(sender As Object, e As EventArgs)
        Me.Hide()
        formPembayaran.Show()
    End Sub
End Class