Imports System.Drawing.Drawing2D

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

    Private Sub txtNoAdmin_TextChanged(sender As Object, e As EventArgs) Handles txtNoAdmin.TextChanged

    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub



    Private Sub formProfilAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengatur sudut tumpul pada Panel4 (hanya bagian atas)
        Dim radiusTop As Integer = 20
        Dim borderRectTop As New Rectangle(0, 0, Panel4.Width, Panel4.Height)
        Panel4.Region = New Region(CreateRoundRectPath(borderRectTop, radiusTop))

        ' Mengatur sudut lurus pada Panel4 (bagian bawah)
        Dim rectBottom As New Rectangle(0, Panel4.Height - radiusTop, Panel4.Width, radiusTop)
        Panel4.Region.Union(rectBottom)
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
End Class



