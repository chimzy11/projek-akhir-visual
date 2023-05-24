Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class formProfilAdmin
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub formProfilAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        TampilProfil()
        Dim radiusTop As Integer = 20
        Dim borderRectTop As New Rectangle(0, 0, Panel4.Width, Panel4.Height)
        Panel4.Region = New Region(CreateRoundRectPath(borderRectTop, radiusTop))

        Dim rectBottom As New Rectangle(0, Panel4.Height - radiusTop, Panel4.Width, radiusTop)
        Panel4.Region.Union(rectBottom)


        CMD = New MySqlCommand("SELECT * FROM akun WHERE username = @username", CONN)
        CMD.Parameters.AddWithValue("@username", FLogin.tUsername.Text)

        RD = CMD.ExecuteReader()
        If RD.Read() Then
            lNama.Text = RD.GetString(1)
            lEmail.Text = RD.GetString(2)
            lNomorTelpon.Text = RD.GetString(5)
        End If
        RD.Close()


    End Sub
    Private Function CreateRoundRectPath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height)
        path.AddLine(rect.X, rect.Y + rect.Height, rect.X, rect.Y + radius)

        path.CloseFigure()
        Return path
    End Function
    Sub TampilProfil()
        CMD = New MySqlCommand("SELECT foto FROM akun WHERE username = @username", CONN)
        CMD.Parameters.AddWithValue("@username", FLogin.tUsername.Text)

        RD = CMD.ExecuteReader()
        If RD.Read() Then
            Dim imageName As String = RD("foto").ToString()
            Dim imagePath As String = Path.Combine("C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads", imageName)
            If File.Exists(imagePath) Then
                pProfilAdmin.Image = Image.FromFile(imagePath)
            End If
        End If

        RD.Close()
    End Sub
    Private Sub pProfilAdmin_Click(sender As Object, e As EventArgs) Handles pProfilAdmin.Click
        Dim OpenProfil As New OpenFileDialog()
        OpenProfil.Filter = "File Gambar|*.jpg;*.jpeg;*.png"

        If OpenProfil.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = OpenProfil.FileName
            pProfilAdmin.Image = Image.FromFile(imagePath)

            Dim fileName As String = Path.GetFileName(imagePath)
            Dim extension As String = Path.GetExtension(imagePath)
            Dim username As String = FLogin.tUsername.Text

            Dim destinationPath As String = "C:\Users\Latitude 5480\Documents\Kuliah_Chimss\A1K3-ProjekAkhir\projek-akhir-visual\uploads\" + username + extension

            If Not File.Exists(destinationPath) Then
                File.Copy(imagePath, destinationPath, True)
            End If

            CMD = New MySqlCommand("UPDATE akun SET foto = @foto WHERE username = @username", CONN)
            CMD.Parameters.AddWithValue("@foto", username + extension)
            CMD.Parameters.AddWithValue("@username", username)
            CMD.ExecuteNonQuery()
        End If
    End Sub
End Class



