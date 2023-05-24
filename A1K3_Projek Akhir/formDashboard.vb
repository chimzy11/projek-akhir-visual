Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Windows
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports MySql.Data.MySqlClient
Public Class formDashboard
    Private currentChildForm As Form
    Private Sub PopulateChartKeuntungan()
        Dim query As String = "SELECT tanggal, SUM(total_transaksi) AS total_keuntungan, AVG(total_transaksi) AS rata_keuntungan FROM transaksi GROUP BY tanggal"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        ChartKeuntungan.Series.Clear()

        Dim seriesPendapatan As New Series("Pendapatan")
        seriesPendapatan.ChartType = SeriesChartType.Column

        Dim seriesRataRata As New Series("Rata-Rata Pendapatan")
        seriesRataRata.ChartType = SeriesChartType.Column

        While RD.Read()
            Dim tanggal As DateTime = Convert.ToDateTime(RD("tanggal"))
            Dim keuntungan As Double = Convert.ToDouble(RD("total_keuntungan"))
            Dim rataKeuntungan As Double = Convert.ToDouble(RD("rata_keuntungan"))

            seriesPendapatan.Points.AddXY(tanggal.ToShortDateString(), keuntungan)
            seriesRataRata.Points.AddXY(tanggal.ToShortDateString(), rataKeuntungan)
        End While

        ChartKeuntungan.Series.Add(seriesPendapatan)
        ChartKeuntungan.Series.Add(seriesRataRata)

        RD.Close()
    End Sub
    Private Function GetMonthName(month As Integer) As String
        Select Case month
            Case 1
                Return "Januari"
            Case 2
                Return "Februari"
            Case 3
                Return "Maret"
            Case 4
                Return "April"
            Case 5
                Return "Mei"
            Case 6
                Return "Juni"
            Case 7
                Return "Juli"
            Case 8
                Return "Agustus"
            Case 9
                Return "September"
            Case 10
                Return "Oktober"
            Case 11
                Return "November"
            Case 12
                Return "Desember"
            Case Else
                Return ""
        End Select
    End Function

    Private Sub PopulateChartKeuntunganBulanan()
        Dim query As String = "SELECT DATE_FORMAT(tanggal, '%Y-%m') AS bulan, SUM(total_transaksi) AS total_keuntungan, AVG(total_transaksi) AS rata_keuntungan FROM transaksi GROUP BY bulan"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        ChartKeuntungan.Series.Clear()

        Dim seriesPendapatan As New Series("Pendapatan")
        seriesPendapatan.ChartType = SeriesChartType.Column

        Dim seriesRataRata As New Series("Rata-Rata Pendapatan")
        seriesRataRata.ChartType = SeriesChartType.Column

        While RD.Read()
            Dim bulan As String = GetMonthName(Month(CDate(RD("bulan"))))
            Dim keuntungan As Double = Convert.ToDouble(RD("total_keuntungan"))
            Dim rataKeuntungan As Double = Convert.ToDouble(RD("rata_keuntungan"))

            seriesPendapatan.Points.AddXY(bulan, keuntungan)
            seriesRataRata.Points.AddXY(bulan, rataKeuntungan)
        End While

        ChartKeuntungan.Series.Add(seriesPendapatan)
        ChartKeuntungan.Series.Add(seriesRataRata)

        RD.Close()
    End Sub

    Private Sub PopulateChartKeuntunganTahunan()
        Dim query As String = "SELECT YEAR(tanggal) AS tahun, SUM(total_transaksi) AS total_keuntungan, AVG(total_transaksi) AS rata_keuntungan FROM transaksi GROUP BY tahun"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()

        ChartKeuntungan.Series.Clear()

        Dim seriesPendapatan As New Series("Pendapatan")
        seriesPendapatan.ChartType = SeriesChartType.Column

        Dim seriesRataRata As New Series("Rata-Rata Pendapatan")
        seriesRataRata.ChartType = SeriesChartType.Column

        While RD.Read()
            Dim tahun As Integer = Convert.ToInt32(RD("tahun"))
            Dim keuntungan As Double = Convert.ToDouble(RD("total_keuntungan"))
            Dim rataKeuntungan As Double = Convert.ToDouble(RD("rata_keuntungan"))

            seriesPendapatan.Points.AddXY(tahun.ToString(), keuntungan)
            seriesRataRata.Points.AddXY(tahun.ToString(), rataKeuntungan)
        End While

        ChartKeuntungan.Series.Add(seriesPendapatan)
        ChartKeuntungan.Series.Add(seriesRataRata)

        RD.Close()
    End Sub




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
    Private Sub formDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalUser.Visible = True
        KoneksiDatabase()
        HitungTotalUser()
        HitungTotalPertunjukkan()
        HitungTotalTransaksi()
        PopulateChartKeuntungan()


        bTanggal.BackColor = Color.Transparent
        bBulan.BackColor = Color.Transparent
        bTahun.BackColor = Color.Transparent

        'untuk panel 12
        Dim radiusTop3 As Integer = 10
        Dim borderRectTop3 As New Rectangle(0, 0, Panel12.Width, Panel12.Height)
        Panel12.Region = New Region(CreateRoundRectPath1(borderRectTop3, radiusTop3))
        Dim rectBottom3 As New Rectangle(0, Panel12.Height - radiusTop3, Panel12.Width, radiusTop3)
        Panel12.Region.Union(rectBottom3)

        Panel13.Region = New Region(CreateRoundRectPath1(borderRectTop3, radiusTop3))
        Panel13.Region.Union(rectBottom3)

        Panel14.Region = New Region(CreateRoundRectPath1(borderRectTop3, radiusTop3))
        Panel14.Region.Union(rectBottom3)






        Dim query As String = "SELECT SUM(total_transaksi) AS total_pendapatan FROM transaksi"
        CMD = New MySqlCommand(query, CONN)
        RD = CMD.ExecuteReader()
        Dim total_pendapatan As Double = 0

        While RD.Read()
            total_pendapatan += RD.GetDouble("total_pendapatan")
        End While

        RD.Close()
        lTotalKeuntungan.Text = total_pendapatan.ToString()

    End Sub

    Private Function CreateRoundRectPath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        ' Sudut tumpul atas kiri
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)

        ' Sudut tumpul atas kanan
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)

        ' Garis lurus ke sudut kanan bawah
        path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)

        ' Sudut tumpul bawah kanan
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)

        ' Sudut tumpul bawah kiri
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)

        ' Garis lurus ke sudut kiri atas
        path.AddLine(rect.X, rect.Bottom - radius, rect.X, rect.Y + radius)

        path.CloseFigure()
        Return path
    End Function

    Private Function CreateRoundRectPath1(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        ' Sudut tumpul atas kiri
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)

        ' Sudut tumpul atas kanan
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)

        ' Garis lurus ke sudut kanan bawah
        path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)

        ' Sudut tumpul bawah kanan
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)

        ' Sudut tumpul bawah kiri
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)

        ' Garis lurus ke sudut kiri atas
        path.AddLine(rect.X, rect.Bottom - radius, rect.X, rect.Y + radius)

        path.CloseFigure()
        Return path
    End Function





    Private Sub HitungTotalUser()
        Dim query As String = "SELECT COUNT(*) AS total_baris FROM akun WHERE id_Akun <> ''"

        CMD = New MySqlCommand(query, CONN)

        Try
            Dim totalUser As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            lblTotalUser.Text = totalUser.ToString()
            lblTotalUser.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub HitungTotalPertunjukkan()
        Dim query As String = "SELECT COUNT(*) AS total_baris FROM JadwalTeater"

        CMD = New MySqlCommand(query, CONN)

        Try
            Dim totalpertunjukkan As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            lTotalPertunjukkan.Text = totalpertunjukkan.ToString()
            lTotalPertunjukkan.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub HitungTotalTransaksi()
        Dim query As String = "SELECT COUNT(*) AS total_baris FROM transaksi"

        CMD = New MySqlCommand(query, CONN)

        Try
            Dim totaltransaksi As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            lDataTransaksi.Text = totaltransaksi.ToString()
            lDataTransaksi.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub lDataUser_Click(sender As Object, e As EventArgs) Handles lDataUser.Click
        OpenChildForm(New FormDataUser)
    End Sub

    Private Sub lDataJadwal_Click(sender As Object, e As EventArgs) Handles lDataJadwal.Click
        OpenChildForm(New formJadwal)
    End Sub

    Private Sub lDataTransaksiUser_Click(sender As Object, e As EventArgs) Handles lDataTransaksiUser.Click
        OpenChildForm(New formTransaksi)
    End Sub

    Sub DataTransaksiChanged()
        PopulateChartKeuntungan()
    End Sub

    Private Sub bTanggal_Click(sender As Object, e As EventArgs) Handles bTanggal.Click
        PopulateChartKeuntungan()
    End Sub

    Private Sub bBulan_Click(sender As Object, e As EventArgs) Handles bBulan.Click
        PopulateChartKeuntunganBulanan()
    End Sub

    Private Sub bTahun_Click(sender As Object, e As EventArgs) Handles bTahun.Click
        PopulateChartKeuntunganTahunan()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pKeuntungan_Paint(sender As Object, e As PaintEventArgs) Handles pKeuntungan.Paint

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs) Handles Panel13.Paint

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub
End Class


