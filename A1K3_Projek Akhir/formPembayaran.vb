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

    Public Sub KodePembayaran()
        Dim KodeRandom As String
        Dim Kode As String
        Kode = "0123456789"
        Randomize()

        For i = 1 To 12
            KodeRandom = KodeRandom & Mid(Kode, Int(Rnd() * Len(Kode) + 1), 1)
        Next i
        tKodePembayaran.Text = KodeRandom
        tKodePembayaran.ReadOnly = True ' Mengatur TextBox menjadi hanya baca
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
            Dim destinationPath As String = "C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads\" & newFileName

            While File.Exists(destinationPath)
                i += 1
                newFileName = FLogin.tUsername.Text & "_musikal_" & i.ToString() & fileExtension
                destinationPath = "C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads\" & newFileName
            End While

            File.Move(imagePath, destinationPath)

            bChsBuktiPembayaran.Text = newFileName
        End If

        cValid.Enabled = True
    End Sub

    Private Sub bCetak_Click(sender As Object, e As EventArgs) Handles bCetak.Click
        Dim selectedCheckboxes As New List(Of CheckBox)

        For Each control As Control In formPesan.Panel2.Controls
            If TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked Then
                selectedCheckboxes.Add(DirectCast(control, CheckBox))
            End If
        Next

        Dim fileMusikal As String = "Musikal_" + formPesan.lJudul.Text.Replace(" ", "_") + ".txt"

        Using writer As New StreamWriter(fileMusikal)
            For Each checkBox As CheckBox In formPesan.Panel2.Controls.OfType(Of CheckBox)()
                writer.WriteLine(checkBox.Text & "," & checkBox.Checked.ToString())
            Next
        End Using

        ' Menghapus checkbox yang dipilih
        For Each checkBox As CheckBox In selectedCheckboxes
            formPesan.Panel2.Controls.Remove(checkBox)
        Next

        ' Dim queryString As String = "UPDATE JadwalTeater SET tiket = tiket - @jumlahTiket WHERE judul = @judul"

        ' CMD = New MySqlCommand(queryString, CONN)
        'CMD.Parameters.AddWithValue("@jumlahTiket", selectedCheckboxes.Count)
        'CMD.Parameters.AddWithValue("@judul", formPesan.lJudul.Text)
        'CMD.ExecuteNonQuery()

        Me.Hide()
        formDetailTicket.Show()
    End Sub






    Private Sub cValid_CheckedChanged(sender As Object, e As EventArgs) Handles cValid.CheckedChanged
        If cValid.Checked = True Then
            bCetak.Enabled = True
        End If
    End Sub
    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Hide()
        formPesan.Show()
    End Sub
End Class