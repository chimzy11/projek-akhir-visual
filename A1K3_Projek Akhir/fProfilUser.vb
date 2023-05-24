Imports System.IO
Imports MySql.Data.MySqlClient

Public Class fProfilUser
    Sub enabledform()
        tEmail.Enabled = False
        tNamaLengkap.Enabled = False
        tNotelp.Enabled = False
        tPassword.Enabled = False
        bBatal.Visible = False
        bSimpan.Visible = False
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        tEmail.Enabled = True
        tNamaLengkap.Enabled = True
        tNotelp.Enabled = True
        tPassword.Enabled = True
        bBatal.Visible = True
        bSimpan.Visible = True
    End Sub
    Private Sub bBatal_Click(sender As Object, e As EventArgs) Handles bBatal.Click
        enabledform()
    End Sub

    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Hide()
        DashboardUser.Show()
    End Sub

    Private Sub fProfilUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        TampilProfil()
        Dim queryString As String = "SELECT * FROM akun WHERE username='" & FLogin.tUsername.Text & "'"

        CMD = New MySqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            tNamaLengkap.Text = RD.GetString(1)
            lNamaLengkap.Text = RD.GetString(1)
            tEmail.Text = RD.GetString(2)
            lUsername.Text = RD.GetString(3)
            tPassword.Text = RD.GetString(4)
            tNotelp.Text = RD.GetString(5)
        End If
        RD.Close()
    End Sub

    Private Function CropToCircle(ByVal image As Image) As Image
        Dim diameter As Integer = Math.Min(image.Width, image.Height)
        Dim bitmap As New Bitmap(diameter, diameter)
        Using g As Graphics = Graphics.FromImage(bitmap)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.Clear(Color.Transparent)

            Dim rectangle As New Rectangle(0, 0, diameter, diameter)
            Dim path As New Drawing2D.GraphicsPath()
            path.AddEllipse(rectangle)
            g.SetClip(path)

            Dim offsetX As Integer = (image.Width - diameter) \ 2
            Dim offsetY As Integer = (image.Height - diameter) \ 2
            g.DrawImage(image, -offsetX, -offsetY)
        End Using

        Return bitmap
    End Function
    Sub TampilProfil()
        Call KoneksiDatabase()
        CMD = New MySqlCommand("SELECT foto FROM akun WHERE username = @username", CONN)
        CMD.Parameters.AddWithValue("@username", FLogin.tUsername.Text)

        RD = CMD.ExecuteReader()
        If RD.Read() Then
            Dim imageName As String = RD("foto").ToString()
            Dim imagePath As String = Path.Combine("C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads", imageName)
            If File.Exists(imagePath) Then
                Dim image As Image = Image.FromFile(imagePath)
                pProfil.SizeMode = PictureBoxSizeMode.StretchImage
                pProfil.Image = CropToCircle(image)
                pSampul.BackgroundImage = image
            End If
        End If

        RD.Close()
    End Sub

    Private Sub bLogOut_Click(sender As Object, e As EventArgs) Handles bLogOut.Click
        Dim X As String
        X = MessageBox.Show("Yakin Untuk Logout?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If X = MsgBoxResult.Yes Then
            Me.Close()
            LandingPage.Show()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        Dim Email As String = tEmail.Text
        If Not Email.Contains("@") Then
            MsgBox("Invalid email address!", MsgBoxStyle.Exclamation, "Attention")
            tEmail.Text = ""
            tEmail.Focus()
            Exit Sub
        End If

        Call KoneksiDatabase()
        Dim Update As String = "UPDATE akun SET namalengkap = '" & tNamaLengkap.Text & "', " &
            "email = '" & tEmail.Text & "', " &
            "psw = '" & tPassword.Text & "', " &
            "nohp = '" & tNotelp.Text & "' " &
            "WHERE username = '" & FLogin.tUsername.Text & "'"

        CMD = New MySqlCommand(Update, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data anda berhasil diubah!", MsgBoxStyle.Information, "Attention")
        enabledform()
    End Sub

    Private Sub bHapusAkun_Click(sender As Object, e As EventArgs) Handles bHapusAkun.Click
        Dim X As String

        X = MessageBox.Show("Yakin hapus akun anda?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If X = MsgBoxResult.Yes Then
            CMD = New MySqlCommand("DELETE FROM akun WHERE username = '" & FLogin.tUsername.Text & "'", CONN)
            CMD.ExecuteNonQuery()

            Me.Close()
            LandingPage.Show()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub pChangeProfil_Click(sender As Object, e As EventArgs) Handles pChangeProfil.Click
        Dim OpenProfil As New OpenFileDialog()
        OpenProfil.Filter = "File Gambar|*.jpg;*.jpeg;*.png"

        If OpenProfil.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = OpenProfil.FileName
            Dim image As Image = Image.FromFile(imagePath)
            pProfil.SizeMode = PictureBoxSizeMode.StretchImage
            pProfil.Image = CropToCircle(image)
            pSampul.BackgroundImage = image

            Dim fileName As String = Path.GetFileName(imagePath)
            Dim extension As String = Path.GetExtension(imagePath)
            Dim username As String = FLogin.tUsername.Text
            Dim uploadPath As String = "C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads\"

            Dim destinationPath As String = Path.Combine(uploadPath, fileName)
            File.Copy(imagePath, destinationPath, True)

            CMD = New MySqlCommand("UPDATE akun SET foto = @foto WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@foto", fileName)
            CMD.Parameters.AddWithValue("@username", username)
            CMD.ExecuteNonQuery()
        End If
    End Sub

    Private Sub tNotelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tNotelp.KeyPress
        If Not (((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Or e.KeyChar = "+") Then
            MsgBox("Hanya Boleh Angka!", MsgBoxStyle.Information, "Attention")
            e.Handled = True
            tNotelp.Focus()
        End If
    End Sub

End Class