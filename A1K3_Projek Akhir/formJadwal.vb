Public Class formJadwal
    'button melengkung
    Sub buttonrounded(btn As Button)
        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()
        radius.AddArc(New Rectangle(0, 0, 30, 30), 180, 90)
        radius.AddLine(30, 0, btn.Width - 30, 0)
        radius.AddArc(New Rectangle(btn.Width - 30, 0, 30, 30), -90, 90)
        radius.AddLine(btn.Width, 30, btn.Width, btn.Height - 30)
        radius.AddArc(New Rectangle(btn.Width - 30, btn.Height - 30, 30, 30), 0, 90)
        radius.AddLine(btn.Width - 30, btn.Height, 30, btn.Height)
        radius.AddArc(New Rectangle(0, btn.Height - 30, 30, 30), 90, 90)
        radius.CloseAllFigures()
        btn.Region = New Region(radius)
    End Sub
    Private Sub formJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'buttonrounded(btnSearch)
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.FromArgb(132, 123, 112)
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub bTambahJadwal_Click(sender As Object, e As EventArgs) Handles bTambahJadwal.Click
        formTambah.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class