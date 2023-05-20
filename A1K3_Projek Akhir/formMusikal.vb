Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml.Serialization
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class formMusikal

    Private Sub formMusikal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTanggal.Text = Today.ToString("dd/MM/yyyy") ' atau DateTime.Now.ToString("dd/MM/yyyy")

        For i As Integer = 1 To 4
            Dim labelJudul As New Label()
            labelJudul.BackColor = Color.FromArgb(221, 212, 199)
            labelJudul.ForeColor = Color.FromArgb(132, 123, 112)
            labelJudul.Font = New Font("microsoft yahei", 14.25, FontStyle.Bold)
            labelJudul.Text = "Judul" & i
            labelJudul.Size = New Size(80, 31)
            labelJudul.Location = New Point(180 + (i - 1) * 210, 220)
            Me.Controls.Add(labelJudul)
        Next i

        Dim startX As Integer = 120 ' Posisi awal X
        Dim startY As Integer = 255 ' Posisi awal Y
        Dim panelSpacing As Integer = 10 ' Jarak antar panel

        For i As Integer = 1 To 4 ' Ubah 5 dengan jumlah panel yang diinginkan
            Dim labelHarga As New Label()
            labelHarga.BackColor = Color.FromArgb(185, 174, 169)
            labelHarga.ForeColor = Color.White
            labelHarga.Font = New Font("microsoft yahei", 11, FontStyle.Bold)
            labelHarga.Text = "Harga"
            labelHarga.Size = New Size(60, 25)
            labelHarga.TextAlign = ContentAlignment.MiddleCenter
            labelHarga.Location = New Point(185 + (i - 1) * 210, 255)
            Me.Controls.Add(labelHarga)

            Dim pictureBox As New PictureBox()
            pictureBox.Size = New Size(160, 170)
            pictureBox.Image = Image.FromFile("C:\Users\Asus Gk\Pictures\Saved Pictures\dekstop.jpg") ' Ganti dengan path gambar yang sesuai
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage ' Sesuaikan tata letak gambar
            pictureBox.Location = New Point((startX + 20) + (200 + panelSpacing) * (i - 1), (startY + 15))
            Me.Controls.Add(pictureBox)

            Dim button As New Button()
            button.Text = "Detail" ' Teks yang akan ditampilkan pada tombol
            button.ForeColor = Color.FromArgb(132, 123, 112)
            button.BackColor = Color.FromArgb(185, 174, 169)
            button.Size = New Size(80, 25)
            button.Font = New Font("microsoft yahei", 9, FontStyle.Bold)
            button.FlatStyle = FlatStyle.Flat
            button.Location = New Point(180 + (i - 1) * 210, 465)

            ' Atur event handler untuk tombol
            AddHandler button.Click, AddressOf Button_Click

            Me.Controls.Add(button)

            Dim myPanel As New Panel()
            myPanel.Size = New Size(200, 200)
            myPanel.BackColor = Color.FromArgb(185, 174, 169)
            myPanel.Location = New Point(startX + (200 + panelSpacing) * (i - 1), startY)

            Me.Controls.Add(myPanel)

        Next


    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        ' Logika yang akan dijalankan saat tombol diklik
        MessageBox.Show("Tombol diklik!")
    End Sub


End Class