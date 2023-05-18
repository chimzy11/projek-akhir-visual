Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class formDashboard
    Private currentChildForm As Form
    Private Sub OpenChildForm(childForm As Form)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        dashboardAdmin.panelDesktop.Controls.Add(childForm)
        dashboardAdmin.panelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub


    Private Sub formDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalUser.Visible = True
        KoneksiDatabase()
        HitungTotalUser()
        HitungTotalPertunjukkan()
    End Sub
    Private Sub HitungTotalUser()
        Dim query As String = "SELECT COUNT(*) AS total_baris FROM akun WHERE id_Akun <> ''"

        CMD = New MySqlCommand(query, CONN)

        Try
            Dim totalUser As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            lblTotalUser.Text = totalUser.ToString()
            lblTotalUser.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub HitungTotalPertunjukkan()
        Dim query As String = "SELECT COUNT(*) AS total_baris FROM JadwalTeater"

        CMD = New MySqlCommand(query, CONN)

        Try
            Dim totalUser As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            lTotalPertunjukkan.Text = totalUser.ToString()
            lTotalPertunjukkan.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub lDataUser_Click(sender As Object, e As EventArgs) Handles lDataUser.Click
        OpenChildForm(New FormDataUser)
    End Sub

    Private Sub lDataJadwal_Click(sender As Object, e As EventArgs) Handles lDataJadwal.Click
        OpenChildForm(New formJadwal)
    End Sub
End Class


