Imports System.Xml.Serialization
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class formHome

    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'utk panel 2
        Dim radiusTop As Integer = 10
        Dim borderRectTop2 As New Rectangle(0, 0, Panel4.Width, Panel4.Height)
        Panel4.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        Dim rectBottom As New Rectangle(0, Panel4.Height - radiusTop, Panel4.Width, radiusTop)
        Panel4.Region.Union(rectBottom)


    End Sub
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


