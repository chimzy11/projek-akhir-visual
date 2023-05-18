Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class formMusikal
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        txtCari.BorderStyle = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub formMusikal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Today.ToString("dd/MM/yyyy") ' atau DateTime.Now.ToString("dd/MM/yyyy")

        ' Mengatur sudut tumpul pada Panel4 (hanya bagian atas)
        Dim radiusTop As Integer = 20
        Dim borderRectTop As New Rectangle(0, 0, Panel2.Width, Panel2.Height)
        Panel2.Region = New Region(CreateRoundRectPath(borderRectTop, radiusTop))

        ' Mengatur sudut lurus pada Panel4 (bagian bawah)
        Dim rectBottom As New Rectangle(0, Panel2.Height - radiusTop, Panel2.Width, radiusTop)
        Panel2.Region.Union(rectBottom)

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


    Private Sub btnPesan_Click(sender As Object, e As EventArgs)

    End Sub
End Class