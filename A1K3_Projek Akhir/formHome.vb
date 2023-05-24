Imports System.Xml.Serialization
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Public Class formHome

    Private Sub formHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim radiusTop As Integer = 10
        Dim borderRectTop2 As New Rectangle(0, 0, Panel4.Width, Panel4.Height)
        Panel4.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        Dim rectBottom As New Rectangle(0, Panel4.Height - radiusTop, Panel4.Width, radiusTop)
        Panel4.Region.Union(rectBottom)

        Dim radiusTop3 As Integer = 10
        Dim borderRectTop3 As New Rectangle(0, 0, Panel5.Width, Panel5.Height)
        Panel5.Region = New Region(CreateRoundRectPath1(borderRectTop3, radiusTop3))
        Dim rectBottom3 As New Rectangle(0, Panel5.Height - radiusTop3, Panel5.Width, radiusTop3)
        Panel5.Region.Union(rectBottom3)


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

    Private Function CreateRoundRectPath1(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90)
        path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height - radius)
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90)

        path.AddLine(rect.X, rect.Y + rect.Height - radius, rect.X, rect.Y + radius)

        path.CloseFigure()
        Return path
    End Function
End Class


