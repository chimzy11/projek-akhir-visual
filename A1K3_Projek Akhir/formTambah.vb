Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports MySql.Data.MySqlClient

Public Class formTambah
    Dim gambar As Object
    Sub Clear()
        tJudul.Clear()
        tPemain.Clear()
        dTanggal.Value = DateTime.Today
        rJamPertama.Checked = False
        rJamKedua.Checked = False
        rJamKetiga.Checked = False
        rJamKeempat.Checked = False
        cGenre.SelectedIndex = -1
        cHari.SelectedIndex = -1
        tTiket.Clear()
        tHargaTiket.Clear()
        bPilihGambarTiket.Text = "Pilih Gambar Teater"
    End Sub

    Private Function CekData()
        Dim Cek = False

        If tJudul.Text = "" Then
            Cek = True
        ElseIf tPemain.Text = "" Then
            Cek = True
        ElseIf rJamPertama.Checked = False And rJamKedua.Checked = False And rJamKetiga.Checked = False And rJamKeempat.Checked = False Then
            Cek = True
        ElseIf cGenre.Text = "" Then
            Cek = True
        ElseIf cHari.Text = "" Then
            Cek = True
        Else
            Cek = False
        End If

        Return Cek
    End Function
    Private Function GetLastID() As Integer
        Dim lastID As Integer = 0
        Dim commandText As String = "SELECT MAX(id_teater) FROM JadwalTeater"
        Dim command As MySqlCommand = New MySqlCommand(commandText, CONN)

        Dim result As Object = command.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            lastID = Convert.ToInt32(result)
        End If

        Return lastID
    End Function

    Sub Simpan(ByVal gambar As Object)
        Dim JamTayang As String = ""
        Dim IdTeater As Integer

        If rJamPertama.Checked Then
            JamTayang = rJamPertama.Text
        ElseIf rJamKedua.Checked Then
            JamTayang = rJamKedua.Text
        ElseIf rJamKetiga.Checked Then
            JamTayang = rJamKetiga.Text
        ElseIf rJamKeempat.Checked Then
            JamTayang = rJamKeempat.Text
        End If

        Dim lastID As Integer = GetLastID()
        If lastID = 0 Then
            IdTeater = 2109106020
        Else
            IdTeater = lastID + 1
        End If

        CMD = New MySqlCommand("Select * From JadwalTeater where id_teater ='" & IdTeater & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If Not RD.HasRows Then
            RD.Close()

            Dim Simpan As String = "INSERT INTO JadwalTeater (id_teater, judul, pemain, tanggal_pertunjukan, waktu, genre, hari, gambar, tiket, harga_tiket) VALUES
                        ('" & IdTeater & "', '" & tJudul.Text & "', '" & tPemain.Text & "', '" & dTanggal.Value.ToString("yyyy-MM-dd") & "', '" & JamTayang & "', '" & cGenre.Text & "', '" & cHari.Text & "', @gambar, '" & tTiket.Text & "', '" & tHargaTiket.Text & "')"

            CMD = New MySqlCommand(Simpan, CONN)
            CMD.Parameters.Add("@gambar", MySqlDbType.LongBlob).Value = gambar ' Parameter gambar dengan tipe data LongBlob
            CMD.ExecuteNonQuery()
            MsgBox("Jadwal Teater Berhasil Ditambahkan", MsgBoxStyle.Information, "Perhatian")
        Else
            MsgBox("ID sudah ada!", MsgBoxStyle.Exclamation, "Attention")
        End If
        RD.Close()
    End Sub
    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        Simpan(gambar)
    End Sub

    Private Sub lExit_Click(sender As Object, e As EventArgs) Handles lExit.Click
        Me.Close()
    End Sub


    Private Sub formTambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bSimpan.Enabled = False
    End Sub

    Private Sub bPilihGambarTiket_Click(sender As Object, e As EventArgs) Handles bPilihGambarTiket.Click
        Dim Kosong As Boolean = CekData()

        If Kosong = True Then
            MessageBox.Show("Lengkapi Data Dahulu")
            Exit Sub
        Else
            Dim imagePath As String = ""

            Dim OpenProfil As New OpenFileDialog()
            OpenProfil.Filter = "File Gambar|*.jpg;*.jpeg;*.png"

            If OpenProfil.ShowDialog() = DialogResult.OK Then
                imagePath = OpenProfil.FileName
                bPilihGambarTiket.Text = Path.GetFileName(imagePath) ' Hanya menampilkan nama file

                ' Konversi gambar menjadi byte array
                Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)

                ' Simpan byte array gambar ke variabel global
                gambar = imageBytes
            End If

            bSimpan.Enabled = True
        End If
    End Sub

    Private Sub tHargaTiket_Enter(sender As Object, e As EventArgs) Handles tHargaTiket.Enter
        If tHargaTiket.Text = "Rp" Then
            tHargaTiket.Text = ""
            tHargaTiket.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub tHargaTiket_Leave(sender As Object, e As EventArgs) Handles tHargaTiket.Leave
        If tHargaTiket.Text = "" Then
            tHargaTiket.Text = "Rp"
            tHargaTiket.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tHargaTiket.KeyPress, tTiket.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Data harus berupa angka!", MsgBoxStyle.Information, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        Clear()
    End Sub

    Private Sub tJudulKeyDown(sender As Object, e As KeyEventArgs) Handles tJudul.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            tPemain.Focus()
        End If
    End Sub
    Private Sub tPemain_KeyDown(sender As Object, e As KeyEventArgs) Handles tPemain.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dTanggal.Select()
        End If
    End Sub
    Private Sub dTanggal_KeyDown(sender As Object, e As KeyEventArgs) Handles dTanggal.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cGenre.Focus()
            cGenre.DroppedDown = True
        End If
    End Sub
    Private Sub cGenre_KeyDown(sender As Object, e As KeyEventArgs) Handles cGenre.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            rJamPertama.Focus()
        End If
    End Sub
    Private Sub gJam_KeyDown(sender As Object, e As KeyEventArgs) Handles rJamPertama.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cHari.Focus()
            cHari.DroppedDown = True
        ElseIf e.KeyCode = Keys.Down Then
            Dim checkedButton As RadioButton = gJam.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked)
            If checkedButton IsNot Nothing Then
                Dim index As Integer = gJam.Controls.IndexOf(checkedButton)
                If index < gJam.Controls.Count - 1 Then
                    Dim nextRadioButton As RadioButton = gJam.Controls(index + 1)
                    nextRadioButton.Checked = True
                End If
            End If
        End If
    End Sub
    Private Sub cHari_KeyDown(sender As Object, e As KeyEventArgs) Handles cHari.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            tTiket.Focus()
        End If
    End Sub
    
    Private Sub tTiket_KeyDown(sender As Object, e As KeyEventArgs) Handles tTiket.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            tHargaTiket.Focus()
        End If
    End Sub
    Private Sub tHargaTiket_KeyDown(sender As Object, e As KeyEventArgs) Handles tHargaTiket.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            bPilihGambarTiket.PerformClick()
        End If
    End Sub
    Private Sub bPilihGambarTiket_KeyDown(sender As Object, e As KeyEventArgs) Handles bPilihGambarTiket.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            bSimpan.PerformClick()
        End If
    End Sub
End Class