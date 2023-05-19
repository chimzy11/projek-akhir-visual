Imports System.Drawing.Drawing2D

Public Class DashboardUser

    'buat buka formnya di panel
    Private currentChildForm As Form

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

    'tulisan di search
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
    'click menu profil
    Private Sub MenuProfil_Click(sender As Object, e As EventArgs) Handles MenuProfil.Click
        Me.Close()
        fProfilUser.Show()
    End Sub

    'keluar program
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


    Private Sub dashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'warna buat menunya
        MenuStripHome.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripTeater.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripAbout.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripProfile.ForeColor = Color.FromArgb(185, 174, 169)

        'langsung manggil form home
        OpenChildForm(New formHome)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        OpenChildForm(New formHome)
    End Sub

    Private Sub MusikalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusikalToolStripMenuItem.Click
        OpenChildForm(New formMusikal)
    End Sub

    Private Sub DramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DramaToolStripMenuItem.Click
        OpenChildForm(New formDrama)
    End Sub

    Private Sub KomediToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KomediToolStripMenuItem.Click
        OpenChildForm(New formKomedi)
    End Sub
End Class