Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class formPembayaran

    Function GetSelectedSeatCount() As Integer
        Dim selectedCount As Integer = 0

        For Each control As Control In formPesan.Panel2.Controls
            If TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked Then
                selectedCount += 1
            End If
        Next

        Return selectedCount
    End Function

    Private Function GetLastID() As Integer
        Dim lastID As Integer = 0
        Dim commandText As String = "SELECT MAX(id_transaksi) FROM transaksi"
        Dim command As MySqlCommand = New MySqlCommand(commandText, CONN)

        Dim result As Object = command.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            lastID = Convert.ToInt32(result)
        End If

        Return lastID
    End Function

    Sub Simpan()
        Dim IdTransaksi As Integer = 0
        Dim lastID As Integer = GetLastID()

        If lastID = 0 Then
            IdTransaksi = 36911780
        Else
            IdTransaksi = lastID + 1
        End If

        CMD = New MySqlCommand("SELECT * FROM transaksi WHERE id_transaksi = @idtransaksi", CONN)
        CMD.Parameters.AddWithValue("@idtransaksi", IdTransaksi)
        RD = CMD.ExecuteReader()
        RD.Read()

        If Not RD.HasRows Then
            RD.Close()

            CMD = New MySqlCommand("SELECT * FROM akun WHERE username = @Username", CONN)
            CMD.Parameters.AddWithValue("@Username", FLogin.tUsername.Text)
            RD = CMD.ExecuteReader()
            RD.Read()

            Dim Id_Akun As Integer = RD.GetInt32(0)
            Dim Nama As String = RD.GetString(1)
            Dim Email As String = RD.GetString(2)

            RD.Close()

            CMD = New MySqlCommand("SELECT * FROM jadwalteater WHERE judul = @Judul", CONN)
            CMD.Parameters.AddWithValue("@Judul", formPesan.lJudul.Text)
            RD = CMD.ExecuteReader()
            RD.Read()

            Dim Id_Teater As Integer = RD.GetInt32(0)

            RD.Close()

            Dim Simpan As String = "INSERT INTO transaksi (id_transaksi, id_akun, id_teater, kode_pembayaran, nama, email, judul, genre, jumlah, harga, total_transaksi, seat, tanggal, gambar_bukti) VALUES " &
                           "(@idtransaksi, @IdAkun, @IdTeater, @KodePembayaran, @Nama, @Email, @Judul, @Genre, @Jumlah, @Harga, @TotalTransaksi, @Seat, @Tanggal, @GambarBukti)"

            CMD = New MySqlCommand(Simpan, CONN)
            CMD.Parameters.AddWithValue("@idtransaksi", IdTransaksi)
            CMD.Parameters.AddWithValue("@IdAkun", Id_Akun)
            CMD.Parameters.AddWithValue("@IdTeater", Id_Teater)
            CMD.Parameters.AddWithValue("@KodePembayaran", tKodePembayaran.Text)
            CMD.Parameters.AddWithValue("@Nama", Nama)
            CMD.Parameters.AddWithValue("@Email", Email)
            CMD.Parameters.AddWithValue("@Judul", formPesan.lJudul.Text)
            CMD.Parameters.AddWithValue("@Genre", "Musikal")
            CMD.Parameters.AddWithValue("@Jumlah", formPesan.tBanyakTiket.Text)
            CMD.Parameters.AddWithValue("@Harga", formDetailMusikal.lHarga.Text)
            CMD.Parameters.AddWithValue("@TotalTransaksi", formPesan.lTotalHarga.Text)
            CMD.Parameters.AddWithValue("@Seat", "null")
            CMD.Parameters.AddWithValue("@Tanggal", Now.Date)
            CMD.Parameters.AddWithValue("@GambarBukti", bChsBuktiPembayaran.Text)

            CMD.ExecuteNonQuery()
            MsgBox("Anda berhasil melakukan pembelian tiket teater!", MsgBoxStyle.Information, "Perhatian")
            Me.Close()
        Else
            MsgBox("ID sudah ada!", MsgBoxStyle.Exclamation, "Attention")
        End If

        RD.Close()
    End Sub
    Public Sub KodePembayaran()
        Dim KodeRandom As String
        Dim Kode As String
        Kode = "0123456789"
        Randomize()

        For i = 1 To 12
            KodeRandom = KodeRandom & Mid(Kode, Int(Rnd() * Len(Kode) + 1), 1)
        Next i
        tKodePembayaran.Text = KodeRandom
        tKodePembayaran.ReadOnly = True
    End Sub

    Private Sub formPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        KodePembayaran()
        cValid.Enabled = False
        bCetak.Enabled = False
    End Sub

    Private Sub bChsBuktiPembayaran_Click(sender As Object, e As EventArgs) Handles bChsBuktiPembayaran.Click
        Dim imagePath As String = ""

        Dim OpenProfil As New OpenFileDialog()
        OpenProfil.Filter = "File Gambar|*.jpg;*.jpeg;*.png"

        If OpenProfil.ShowDialog() = DialogResult.OK Then
            imagePath = OpenProfil.FileName
            Dim fileName As String = Path.GetFileName(imagePath)
            Dim fileExtension As String = Path.GetExtension(imagePath)

            Dim i As Integer = 1
            Dim newFileName As String = FLogin.tUsername.Text & "_musikal_" & i.ToString() & fileExtension
            Dim destinationPath As String = "C:\Users\ASUS\Documents\PA VISUAL\projek-akhir-visual\uploads\" & newFileName

            While File.Exists(destinationPath)
                i += 1
                newFileName = FLogin.tUsername.Text & "_musikal_" & i.ToString() & fileExtension
                destinationPath = "C:\Users\ASUS\Documents\PA VISUAL\projek-akhir-visual\uploads\" & newFileName
            End While

            File.Copy(imagePath, destinationPath)

            bChsBuktiPembayaran.Text = newFileName
        End If

        cValid.Enabled = True
    End Sub

    Private Sub bCetak_Click(sender As Object, e As EventArgs) Handles bCetak.Click
        Dim selectedCheckboxes As New List(Of CheckBox)

        Simpan()

        For Each control As Control In formPesan.Panel2.Controls
            If TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked Then
                selectedCheckboxes.Add(DirectCast(control, CheckBox))
            End If
        Next

        Dim fileMusikal As String = "Musikal_" + formPesan.lJudul.Text.Replace(" ", "_") + ".txt"

        Using writer As New StreamWriter(fileMusikal)
            For Each checkBox As CheckBox In formPesan.Panel2.Controls.OfType(Of CheckBox)()
                Dim isChecked As Boolean = selectedCheckboxes.Contains(checkBox)
                writer.WriteLine(checkBox.Text & "," & isChecked.ToString())
            Next
        End Using

        Dim queryString As String = "UPDATE JadwalTeater SET tiket = tiket - @jumlahTiket WHERE judul = @judul"

        CMD = New MySqlCommand(queryString, CONN)
        CMD.Parameters.AddWithValue("@jumlahTiket", selectedCheckboxes.Count)
        CMD.Parameters.AddWithValue("@judul", formPesan.lJudul.Text)
        CMD.ExecuteNonQuery()

        Me.Hide()
        formDetailTicket.Show()
    End Sub

    Private Sub cValid_CheckedChanged(sender As Object, e As EventArgs) Handles cValid.CheckedChanged
        If cValid.Checked = True Then
            bCetak.Enabled = True
        Else
            bCetak.Enabled = False
        End If
    End Sub
    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Hide()
        formPesan.Show()
    End Sub
End Class