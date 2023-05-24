Imports System.IO
Imports MySql.Data.MySqlClient

Public Class formEdit
    Private currentChildForm As Form
    Private Sub OpenChildForm(childForm As Form)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        dashboardAdmin.panelDesktop.Controls.Add(childForm)
        dashboardAdmin.panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Sub Clear()
        tJudul.Clear()
        tKelompok.Clear()

        rJamPertama.Checked = False
        rJamKedua.Checked = False
        cGenre.SelectedIndex = -1
        tTiket.Clear()
        tHari.Clear()
        tHargaTiket.Clear()
        bPilihGambarTiket.Text = "Pilih Gambar Teater"
    End Sub

    Private Function CekData()
        Dim Cek = False

        If tJudul.Text = "" Then
            Cek = True
        ElseIf tKelompok.Text = "" Then
            Cek = True
        ElseIf rJamPertama.Checked = False And rJamKedua.Checked = False Then
            Cek = True
        ElseIf cGenre.Text = "" Then
            Cek = True
        ElseIf tHari.Text = "" Then
            Cek = True
        ElseIf tTiket.Text = "" Then
            Cek = True
        ElseIf tHargaTiket.Text = "" Or tHargaTiket.Text = "Rp" Then
            Cek = True
        Else
            Cek = False
        End If

        Return Cek
    End Function
    Sub Simpan()
        If (tHari.Text = "Monday") Then
            MsgBox("Tidak bisa memilih hari Monday", MsgBoxStyle.Information, "Perhatian")
        Else
            Dim JamTayang As String = ""

            If rJamPertama.Checked Then
                JamTayang = rJamPertama.Text
            ElseIf rJamKedua.Checked Then
                JamTayang = rJamKedua.Text
            End If

            CMD = New MySqlCommand("SELECT * FROM JadwalTeater WHERE id_teater = '" & PopUpEditJadwal.cIdTeater.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()

                Dim UpdateQuery As String = "UPDATE JadwalTeater SET judul = '" & tJudul.Text & "', kelompok = '" & tKelompok.Text & "', genre = '" & cGenre.Text & "', hari = '" & tHari.Text & "', tanggal_pertunjukkan = '" & dTanggal.Value.ToString("yyyy-MM-dd") & "', waktu = '" & JamTayang & "', tiket = '" & tTiket.Text & "', harga_tiket = '" & tHargaTiket.Text & "', gambar = '" & bPilihGambarTiket.Text & "' WHERE id_teater = '" & PopUpEditJadwal.cIdTeater.Text & "'"

                CMD = New MySqlCommand(UpdateQuery, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Jadwal Teater Berhasil Diperbarui", MsgBoxStyle.Information, "Perhatian")
                PopUpEditJadwal.Close()
                Me.Close()
                OpenChildForm(New formJadwal)
            Else
                RD.Close()
                MsgBox("ID tidak ditemukan!", MsgBoxStyle.Exclamation, "Perhatian")
            End If
        End If
    End Sub

    Private Sub formEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        bSimpan.Enabled = False
        dTanggal.MinDate = DateTime.Today
        dTanggal.Value = DateTime.Today

        Dim queryString As String = "SELECT * FROM JadwalTeater WHERE id_teater='" & PopUpEditJadwal.cIdTeater.Text & "'"

        CMD = New MySqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            tJudul.Text = RD.GetString(1)
            tKelompok.Text = RD.GetString(2)
            cGenre.Text = RD.GetString(3)
            tHari.Text = RD.GetString(4)
            dTanggal.Value = RD.GetDateTime(5)

            Select Case RD.GetString(6)
                Case rJamPertama.Text
                    rJamPertama.Checked = True
                Case rJamKedua.Text
                    rJamKedua.Checked = True
            End Select

            tTiket.Text = RD.GetString(7)
            tHargaTiket.Text = RD.GetString(8)
        End If

        RD.Close()

        dTanggal.MinDate = DateTime.Today.AddDays(2)

        Dim maxDate As DateTime = DateTime.Today.AddDays(8)

        Do While maxDate.DayOfWeek = DayOfWeek.Monday
            maxDate = maxDate.AddDays(1)
        Loop

        If maxDate.DayOfWeek = DayOfWeek.Monday Then
            maxDate = maxDate.AddDays(1)
        End If

        dTanggal.MaxDate = maxDate
        dTanggal.Value = maxDate
    End Sub


    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Close()
        PopUpEditJadwal.Close()
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        Dim Kosong As Boolean = CekData()

        If Kosong = True Then
            MessageBox.Show("Lengkapi Data Dahulu")
            Exit Sub
        Else
            Simpan()
        End If
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
                Dim fileName As String = Path.GetFileName(imagePath)
                Dim fileExtension As String = Path.GetExtension(imagePath)

                Dim i As Integer = 1
                Dim newFileName As String = "Jadwal_Teater_" & tJudul.Text & i.ToString() & fileExtension
                Dim destinationPath As String = "C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads\" & newFileName

                While File.Exists(destinationPath)
                    i += 1
                    newFileName = FLogin.tUsername.Text & "_musikal_" & i.ToString() & fileExtension
                    destinationPath = "C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads\" & newFileName
                End While

                File.Copy(imagePath, destinationPath)

                bPilihGambarTiket.Text = newFileName
            End If

            bSimpan.Enabled = True
        End If

    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        Clear()
    End Sub

    Private Sub textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tHargaTiket.KeyPress, tTiket.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            MsgBox("Data harus berupa angka!", MsgBoxStyle.Information, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub dTanggal_ValueChanged(sender As Object, e As EventArgs) Handles dTanggal.ValueChanged
        tHari.Text = dTanggal.Value.DayOfWeek.ToString()
        If (tHari.Text = "Monday") Then
            MsgBox("Tidak bisa memilih hari Monday", MsgBoxStyle.Information, "Perhatian")
        End If
    End Sub
End Class