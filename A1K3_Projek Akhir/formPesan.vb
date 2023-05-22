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

            Dim nama As Char = "A"c
            Dim nomorKursi As Integer = 1

            Dim fileMusikal As String = "Musikal_" + PopUpDataJadwal.cJudul.Text.Replace(" ", "_") + ".txt"
            Dim kursiTerisi As New List(Of String)()

            If File.Exists(fileMusikal) Then
                ' Membaca file Musikal.txt dan mengambil kursi yang telah terisi
                Using reader As New StreamReader(fileMusikal)
                    Dim line As String = reader.ReadLine()
                    While line IsNot Nothing
                        kursiTerisi.Add(line)
                        line = reader.ReadLine()
                    End While
                End Using
            End If

            For i As Integer = 0 To numCheckboxes - 1
                Dim checkBox As New CheckBox()
                checkBox.Name = "chkKursi" & nomorKursi.ToString()
                checkBox.Text = nama.ToString() & nomorKursi.ToString()
                checkBox.AutoSize = True ' Mengatur AutoSize ke True
                Dim row As Integer = i \ checkBoxesPerRow
                Dim col As Integer = i Mod checkBoxesPerRow
                Dim x As Integer = 33 + col * (checkBoxWidth + 5)
                Dim y As Integer = 43 + row * (checkBoxHeight + 5)
                checkBox.Location = New Point(x, y)
                checkBox.Width = checkBoxWidth ' Mengatur lebar CheckBox

                If File.Exists(fileMusikal) Then
                    ' Mengatur keadaan CheckBox berdasarkan apakah kursi telah terisi atau tidak
                    checkBox.Enabled = Not kursiTerisi.Contains(checkBox.Text)
                Else
                    ' Jika file Musikal.txt tidak ada, maka semua kursi tersedia
                    checkBox.Enabled = True
                End If

                Panel2.Controls.Add(checkBox)

                nomorKursi += 1
                If nomorKursi > 9 Then
                    nomorKursi = 1
                    If nama < "Z"c Then
                        nama = Chr(Asc(nama) + 1)
                    End If
                End If
            Next

            ' Menghapus kursi yang telah terisi berdasarkan file Musikal.txt
            If File.Exists(fileMusikal) Then
                Dim checkboxesToRemove As New List(Of CheckBox)()

                For Each checkBox As CheckBox In Panel2.Controls.OfType(Of CheckBox)()
                    If kursiTerisi.Contains(checkBox.Text) Then
                        checkboxesToRemove.Add(checkBox)
                    End If
                Next

                For Each checkBox As CheckBox In checkboxesToRemove
                    Panel2.Controls.Remove(checkBox)
                Next
            End If
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
        Dim selectedCount As Integer = GetSelectedSeatCount()

        If selectedCount = CInt(tBanyakTiket.Text) Then
            ' Remove selected checkboxes

            Me.Hide()
            formPembayaran.Show()
        Else
            MessageBox.Show("Jumlah kursi yang dipilih tidak sesuai dengan jumlah tiket yang dibeli.")
        End If
    End Sub

    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Hide()
        formDetailMusikal.Show()
    End Sub
End Class