Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml.Serialization


Public Class formTambah
    Private currentChildForm As Form
    Dim gambar As Object
    Sub Clear()
        tJudul.Clear()
        tKelompok.Clear()
        dTanggal.Value = DateTime.Today
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
        Else
            Cek = False
        End If

        Return Cek
    End Function
    Private Sub OpenChildForm(childForm As Form)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        DashboardAdmin.panelDesktop.Controls.Add(childForm)
        DashboardAdmin.panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
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

    Sub Simpan()
        Dim JamTayang As String = ""
        Dim IdTeater As Integer

        If rJamPertama.Checked Then
            JamTayang = rJamPertama.Text
        ElseIf rJamKedua.Checked Then
            JamTayang = rJamKedua.Text
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

            Dim Simpan As String = "INSERT INTO JadwalTeater (id_teater, judul, kelompok, genre, hari, tanggal_pertunjukkan, waktu, tiket, harga_tiket, gambar) VALUES
                        ('" & IdTeater & "', '" & tJudul.Text & "', '" & tKelompok.Text & "', '" & cGenre.Text & "', '" & tHari.Text & "', '" & dTanggal.Value.ToString("yyyy-MM-dd") & "', '" & JamTayang & "', '" & tTiket.Text & "', '" & tHargaTiket.Text & "', '" & bPilihGambarTiket.Text & "')"

            CMD = New MySqlCommand(Simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Jadwal Teater Berhasil Ditambahkan", MsgBoxStyle.Information, "Perhatian")
            Me.Close()
            OpenChildForm(New formJadwal)
        Else
            MsgBox("ID sudah ada!", MsgBoxStyle.Exclamation, "Attention")
        End If
        RD.Close()
    End Sub
    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        Simpan()
    End Sub
    Private Sub formTambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bSimpan.Enabled = False
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
                Dim fileName As String = Path.GetFileNameWithoutExtension(imagePath)
                Dim fileExtension As String = Path.GetExtension(imagePath)
                Dim newFileName As String = $"{tJudul.Text}{fileExtension}"
                Dim destinationPath As String = "C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads\" & newFileName

                File.Move(imagePath, destinationPath)

                bPilihGambarTiket.Text = newFileName
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
            tKelompok.Focus()
        End If
    End Sub
    Private Sub tPemain_KeyDown(sender As Object, e As KeyEventArgs) Handles tKelompok.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            dTanggal.Select()
        End If
    End Sub
    Private Sub dTanggal_KeyDown(sender As Object, e As KeyEventArgs) Handles dTanggal.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            rJamPertama.Focus()
        End If
    End Sub

    Private Sub gJam_KeyDown(sender As Object, e As KeyEventArgs) Handles rJamPertama.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            cGenre.Focus()
            cGenre.DroppedDown = True
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

    Private Sub cGenre_KeyDown(sender As Object, e As KeyEventArgs) Handles cGenre.KeyDown
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

    Private Sub dTanggal_ValueChanged(sender As Object, e As EventArgs) Handles dTanggal.ValueChanged
        tHari.Text = dTanggal.Value.DayOfWeek.ToString()
    End Sub

    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Close()
    End Sub
End Class