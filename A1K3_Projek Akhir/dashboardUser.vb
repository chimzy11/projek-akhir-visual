Imports System.Drawing.Drawing2D

Public Class DashboardUser

    Private currentChildForm As Form

    Private Sub OpenChildForm(childForm As Form)
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
    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Dim X As String
        X = MessageBox.Show("Yakin Untuk Logout ?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If X = MsgBoxResult.Yes Then
            Me.Close()
            LandingPage.Show()
        Else
            Exit Sub
        End If
    End Sub


    Private Sub dashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStripHome.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripTeater.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStrip1.ForeColor = Color.FromArgb(185, 174, 169)
        MenuStripProfile.ForeColor = Color.FromArgb(185, 174, 169)

        OpenChildForm(New formHome)
        lUsername.Text = FLogin.tUsername.Text
    End Sub
    Private Sub MenuHome_Click(sender As Object, e As EventArgs) Handles MenuHome.Click
        OpenChildForm(New formHome)
    End Sub

    Private Sub MenuMusikal_Click(sender As Object, e As EventArgs) Handles MenuMusikal.Click
        OpenChildForm(New formMusikal)
    End Sub

    Private Sub MenuDrama_Click(sender As Object, e As EventArgs) Handles MenuDrama.Click
        OpenChildForm(New formDrama)
    End Sub

    Private Sub MenuKomedi_Click(sender As Object, e As EventArgs) Handles MenuKomedi.Click
        OpenChildForm(New formKomedi)
    End Sub
    Private Sub MenuAboutUs_Click(sender As Object, e As EventArgs)
        OpenChildForm(New formAbout)
    End Sub
    Private Sub MenuProfil_Click(sender As Object, e As EventArgs) Handles MenuProfil.Click
        Me.Close()
        fProfilUser.Show()
    End Sub
    Private Sub MenuTransaksi_Click(sender As Object, e As EventArgs) Handles MenuTransaksi.Click
        Me.Close()
        formRiwayatUser.Show()
    End Sub

    Private Sub MenuAboutUs_Click_1(sender As Object, e As EventArgs) Handles MenuAboutUs.Click
        OpenChildForm(New formAbout)
    End Sub
End Class