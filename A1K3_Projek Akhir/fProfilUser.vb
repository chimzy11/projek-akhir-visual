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
        Me.Close()
        dashboardUser.Show()
    End Sub

    Private Sub fProfilUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KoneksiDatabase()
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
    Private Sub pProfil_Click(sender As Object, e As EventArgs) Handles pProfil.Click
        Dim OpenProfil As New OpenFileDialog()
        OpenProfil.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If OpenProfil.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = OpenProfil.FileName

            pProfil.Image = Image.FromFile(imagePath)
            CMD = New MySqlCommand("UPDATE akun SET foto = @foto WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@foto", imagePath)
            CMD.Parameters.AddWithValue("@username", FLogin.tUsername.Text)
            CMD.ExecuteNonQuery()
        End If
    End Sub
    Sub TampilProfil()
        CMD = New MySqlCommand("SELECT foto FROM akun WHERE username = @username", CONN)
        CMD.Parameters.AddWithValue("@username", FLogin.tUsername.Text)

        RD = CMD.ExecuteReader()
        If RD.Read() Then
            Dim imageName As String = RD("foto").ToString()
            Dim imagePath As String = Path.Combine(Application.StartupPath, imageName)
            If File.Exists(imagePath) Then
                pProfil.Image = Image.FromFile(imagePath)
            End If
        End If

        RD.Close()
    End Sub

    Private Sub bLogOut_Click(sender As Object, e As EventArgs) Handles bLogOut.Click
        Dim X As String
        X = MessageBox.Show("Yakin keluar dari program ini?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If X = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
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
            End
        Else
            Exit Sub
        End If
    End Sub
End Class