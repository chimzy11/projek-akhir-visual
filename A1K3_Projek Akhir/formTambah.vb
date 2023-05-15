Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports MySql.Data.MySqlClient

Public Class formTambah

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

    Sub Simpan()
        Dim JamTayang As String

        If rJamPertama.Checked = True Then
            JamTayang = rJamPertama.Text
        ElseIf rJamKedua.Checked = True Then
            JamTayang = rJamKedua.Text
        ElseIf rJamKetiga.Checked = True Then
            JamTayang = rJamKetiga.Text
        ElseIf rJamKeempat.Checked = True Then
            JamTayang = rJamKeempat.Text
        End If

        Dim Simpan As String = "Insert Into JadwalTeater(judul, pemain, tanggal_pertunjukan, waktu, genre, hari) Values
                                ('" & tJudul.Text & "', '" & tPemain.Text & "', '" & dTanggal.Text & "', '" & JamTayang & "', '" & cGenre.Text & "', '" & cHari.Text & "')"

        CMD = New MySqlCommand(Simpan, CONN)
        CMD.ExecuteNonQuery()
    End Sub

    Private Sub bPilihJenisTiket_Click(sender As Object, e As EventArgs) Handles bPilihJenisTiket.Click
        Dim Kosong As Boolean = CekData()

        If Kosong = True Then
            MessageBox.Show("Lengkapi Data Dahulu")
            Exit Sub
        Else
            Simpan()
            FJenisTiketTeater.Show()
        End If
    End Sub

    Private Sub lExit_Click(sender As Object, e As EventArgs) Handles lExit.Click
        Me.Close()
        Exit Sub
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dTanggal_ValueChanged(sender As Object, e As EventArgs) Handles dTanggal.ValueChanged

    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        Dim Periksa As String = "SELECT COUNT(*) FROM JadwalTeater WHERE judul = '" & tJudul.Text & "'"

        CMD = New MySqlCommand(Periksa, CONN)
        CMD.Parameters.AddWithValue("@Judul", tJudul.Text)

        Dim count As Integer = CInt(CMD.ExecuteScalar())

        If count > 0 Then
            MsgBox("Jadwal Teater Berhasil Ditambahkan",
            MsgBoxStyle.Information, "Perhatian")
        Else
            MsgBox("Jadwal Teater Gagal Ditambahkan",
            MsgBoxStyle.Information, "Perhatian")
        End If
    End Sub

    Private Sub formTambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bSimpan.Enabled = False
    End Sub
End Class