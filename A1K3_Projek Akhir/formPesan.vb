Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Public Class formPesan

    Dim Total As Integer = 0
    Dim HargaPerTiket As Integer = 0
    Dim jumlahTiket As Integer = 0
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

            Dim fileMusikal As String = "Musikal_" + PopUpDataJadwal.cJudul.Text.Replace(" ", "_") + ".txt"
            If File.Exists(fileMusikal) Then
                Dim lines As String() = File.ReadAllLines(fileMusikal)

                For Each line As String In lines
                    Dim values As String() = line.Split(","c)
                    If values.Length = 2 AndAlso values(1).Trim().Equals("False") Then
                        Dim checkBox As New CheckBox()
                        checkBox.Name = "chkKursi" & values(0).Trim()
                        checkBox.Text = values(0).Trim()
                        checkBox.AutoSize = True
                        Dim row As Integer = Panel2.Controls.Count \ checkBoxesPerRow
                        Dim col As Integer = Panel2.Controls.Count Mod checkBoxesPerRow
                        Dim x As Integer = 33 + col * (checkBoxWidth + 5)
                        Dim y As Integer = 43 + row * (checkBoxHeight + 5)
                        checkBox.Location = New Point(x, y)
                        checkBox.Width = checkBoxWidth
                        checkBox.Enabled = False
                        Panel2.Controls.Add(checkBox)
                    End If
                Next
            Else
                MessageBox.Show("File tidak ditemukan.")
            End If

            RD.Close()
        End If
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
                tBanyakTiket.Text = ""
                tBanyakTiket.Focus()
                Return
            End If

            For Each checkBox As CheckBox In Panel2.Controls.OfType(Of CheckBox)()
                checkBox.Enabled = True
            Next

            Total = BanyakTiket * HargaPerTiket
            lTotalHarga.Text = Total.ToString()
        Else
            lTotalHarga.Text = "0"
        End If

        If BanyakTiket = 0 Then
            For Each checkBox As CheckBox In Panel2.Controls.OfType(Of CheckBox)()
                checkBox.Enabled = False
                tBanyakTiket.Focus()
            Next
        End If
    End Sub

    Function GetSelectedSeatCount() As Integer
        Dim selectedCount As Integer = 0

        For Each control As Control In Panel2.Controls
            If TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked Then
                selectedCount += 1
            End If
        Next

        Return selectedCount
    End Function

    Private Sub bPembayaran_Click(sender As Object, e As EventArgs)
        If (tBanyakTiket.Text = "" Or tBanyakTiket.Text = "0") Then
            MessageBox.Show("Masukkan Jumlah Tiket Dahulu")
        Else
            Dim selectedCount As Integer = GetSelectedSeatCount()

            If selectedCount <> CInt(tBanyakTiket.Text) Then
                MessageBox.Show("Jumlah kursi yang dipilih tidak sesuai dengan jumlah tiket yang dibeli.")
            Else
                Me.Hide()
                formPembayaran.Show()
            End If
        End If
    End Sub

    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Hide()
        formDetailMusikal.Show()
    End Sub

    Private Sub tBanyakTiket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tBanyakTiket.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MessageBox.Show("Hanya Untuk Inputan Angka")
            e.Handled = True
        End If
    End Sub
End Class