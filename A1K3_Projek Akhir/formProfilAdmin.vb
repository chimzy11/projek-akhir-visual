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
        ' Mengatur sudut tumpul pada Panel4 (hanya bagian atas)
        Dim radiusTop As Integer = 20
        Dim borderRectTop As New Rectangle(0, 0, Panel4.Width, Panel4.Height)
        Panel4.Region = New Region(CreateRoundRectPath(borderRectTop, radiusTop))

        ' Mengatur sudut lurus pada Panel4 (bagian bawah)
        Dim rectBottom As New Rectangle(0, Panel4.Height - radiusTop, Panel4.Width, radiusTop)
        Panel4.Region.Union(rectBottom)


        Dim queryString As String = "SELECT * FROM akun WHERE username='" & FLogin.tUsername.Text & "'"

        CMD = New MySqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            lNama.Text = RD.GetString(1)
            lEmail.Text = RD.GetString(2)
            lNomorTelpon.Text = RD.GetString(5)
        End If
        RD.Close()


    End Sub

    ' Fungsi untuk membuat sudut tumpul
    Private Function CreateRoundRectPath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        ' Sudut tumpul atas kiri
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)

        ' Sudut tumpul atas kanan
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)

        ' Garis lurus ke sudut kanan bawah
        path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height)

        ' Garis lurus ke sudut kiri bawah
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
            Dim imagePath As String = Path.Combine(Application.StartupPath, imageName)
            If File.Exists(imagePath) Then
                pProfilAdmin.Image = Image.FromFile(imagePath)
            End If
        End If

        RD.Close()
    End Sub
    Private Sub pProfilAdmin_Click(sender As Object, e As EventArgs) Handles pProfilAdmin.Click
        Dim OpenProfil As New OpenFileDialog()
        OpenProfil.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If OpenProfil.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = OpenProfil.FileName

            pProfilAdmin.Image = Image.FromFile(imagePath)
            CMD = New MySqlCommand("UPDATE akun SET foto = @foto WHERE id_akun = @id_akun", CONN)
            CMD.Parameters.AddWithValue("@foto", imagePath)
            CMD.Parameters.AddWithValue("@id_akun", "1")
            CMD.ExecuteNonQuery()
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class



