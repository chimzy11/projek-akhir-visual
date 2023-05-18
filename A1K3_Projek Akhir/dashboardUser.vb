Imports System.Drawing.Drawing2D

Public Class DashboardUser
    Private Sub dashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStripHome.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripTeater.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripAbout.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripProfile.ForeColor = Color.FromArgb(185, 174, 169)
        Dim radiusTop As Integer = 20
        'utk panel 2
        Dim borderRectTop2 As New Rectangle(0, 0, Panel4.Width, Panel4.Height)
        Panel4.Region = New Region(CreateRoundRectPath(borderRectTop2, radiusTop))
        Dim rectBottom As New Rectangle(0, Panel4.Height - radiusTop, Panel4.Width, radiusTop)
        Panel4.Region.Union(rectBottom)


    End Sub


    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.FromArgb(250, 246, 243)
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub MenuProfil_Click(sender As Object, e As EventArgs) Handles MenuProfil.Click
        Me.Close()
        fProfilUser.Show()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Dim X As String
        X = MessageBox.Show("Yakin keluar dari program ini?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If X = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

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