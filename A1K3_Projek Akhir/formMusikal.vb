Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Xml.Serialization
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class formMusikal

    Private Sub formMusikal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTanggal.Text = Today.ToString("dd/MM/yyyy") ' atau DateTime.Now.ToString("dd/MM/yyyy")

        'For i As Integer = 1 To 5
        '    Dim myLabel As New Label()
        '    myLabel.BackColor = Color.FromArgb(221, 212, 199)
        '    myLabel.ForeColor = Color.FromArgb(132, 123, 112)
        '    myLabel.Font = New Font("Microsoft YaHei", 14.25, FontStyle.Bold)
        '    myLabel.Text = "Judul " & i
        '    myLabel.Size = New Size(80, 31)
        '    myLabel.Location = New Point(350, 220 + (i - 1) * 70)
        '    Me.Controls.Add(myLabel)
        'Next i

        'Dim myLabel As New Label()
        'myLabel.BackColor = Color.FromArgb(221, 212, 199)
        'myLabel.ForeColor = Color.FromArgb(132, 123, 112)
        'myLabel.Font = New Font("Microsoft YaHei", 14.25, FontStyle.Bold)
        'myLabel.Text = "Judul"
        'myLabel.Size = New Size(80, 31)
        'myLabel.Location = New Point(350, 220)
        'Me.Controls.Add(myLabel)


        txtCari.BorderStyle = 0
        Dim radiusTop As Integer = 20
        'utk panel 2
        Dim borderRectTop2 As New Rectangle(0, 0, Panel2.Width, Panel2.Height)
        Panel2.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        'utk panel 3
        Panel3.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        'utk panel 4
        Panel4.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        'utk panel 5
        Panel5.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        Panel6.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        Panel7.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        Panel8.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        Panel9.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))



        ' Mengatur sudut lurus pada Panel4 (bagian bawah)
        Dim rectBottom As New Rectangle(0, Panel2.Height - radiusTop, Panel2.Width, radiusTop)
        Panel2.Region.Union(rectBottom)
    End Sub

    Private Function CreateRoundRectPath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        ' Sudut tumpul atas kiri
        path.AddArc(rect.X, rect.Y, radius, radius, 90, 90)

        ' Sudut tumpul atas kanan
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 0, 90)

        ' Sudut tumpul kanan bawah
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 270, 90)

        ' Sudut tumpul kiri bawah
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 180, 90)

        path.CloseFigure()
        Return path
    End Function


End Class