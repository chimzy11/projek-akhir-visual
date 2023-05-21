Imports System.IO

Public Class formPembayaran

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
            Dim destinationPath As String = "C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads\" & fileName

            File.Move(imagePath, destinationPath)

            bChsBuktiPembayaran.Text = fileName
        End If

        cValid.Enabled = True
    End Sub


    Private Sub bCetak_Click(sender As Object, e As EventArgs) Handles bCetak.Click

    End Sub

    Private Sub cValid_CheckedChanged(sender As Object, e As EventArgs) Handles cValid.CheckedChanged
        If cValid.Checked = True Then
            bCetak.Enabled = True
        End If
    End Sub
End Class