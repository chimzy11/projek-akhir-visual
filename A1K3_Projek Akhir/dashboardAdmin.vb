Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml.Serialization
Imports MySql.Data.MySqlClient
Public Class dashboardAdmin
    Private currentChildForm As Form


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelDesktop.Controls.Add(childForm)
        panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub


    ' Private Sub Label10_Click(sender As Object, e As EventArgs)
    ' Label10.Font = New Font(Label10.Font, FontStyle.Underline)
    ' End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpenChildForm(New formDashboard)
    End Sub

    Private Sub btnJadwal_Click(sender As Object, e As EventArgs) Handles btnJadwal.Click
        OpenChildForm(New formJadwal)
    End Sub

    Private Sub bLogout_Click(sender As Object, e As EventArgs) Handles bLogout.Click
        Dim X As String
        X = MessageBox.Show("Yakin keluar dari program ini?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If X = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
    Sub TampilProfil()
        CMD = New MySqlCommand("SELECT foto FROM akun WHERE id_akun = @id_akun", CONN)
        CMD.Parameters.AddWithValue("@id_akun", "1") ' Gantilah 'ID_Akun' dengan ID akun yang sesuai

        RD = CMD.ExecuteReader()
        If RD.Read() Then
            Dim imageName As String = RD("foto").ToString()
            Dim imagePath As String = Path.Combine(Application.StartupPath, imageName)
            If File.Exists(imagePath) Then
                pProfil.Image = Image.FromFile(imagePath)

                ' Mengubah bentuk PictureBox menjadi lingkaran
                MakePictureBoxCircular(pProfil)
            End If
        End If

        RD.Close()
    End Sub

    Private Sub dashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        TampilProfil()
        OpenChildForm(New formDashboard)
    End Sub

    Private Sub pProfil_Click(sender As Object, e As EventArgs) Handles pProfil.Click
        Dim OpenProfil As New OpenFileDialog()
        OpenProfil.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If OpenProfil.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = OpenProfil.FileName

            pProfil.Image = Image.FromFile(imagePath)
            CMD = New MySqlCommand("UPDATE akun SET foto = @foto WHERE id_akun = @id_akun", CONN)
            CMD.Parameters.AddWithValue("@foto", imagePath)
            CMD.Parameters.AddWithValue("@id_akun", "1")
            CMD.ExecuteNonQuery()
            MakePictureBoxCircular(pProfil)
        End If
    End Sub

    Private Sub MakePictureBoxCircular(pictureBox As PictureBox)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height)
        pictureBox.Region = New Region(path)
    End Sub

    Private Sub btnProfil_Click(sender As Object, e As EventArgs) Handles btnProfil.Click
        OpenChildForm(New formProfilAdmin)
    End Sub

    Private Sub panelDesktop_Paint(sender As Object, e As PaintEventArgs) Handles panelDesktop.Paint

    End Sub
End Class