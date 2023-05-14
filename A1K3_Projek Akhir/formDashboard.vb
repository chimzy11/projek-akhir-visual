Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class formDashboard
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub


    Private Sub formDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalUser.Visible = True
        KoneksiDatabase() ' Panggil fungsi koneksi untuk membuka koneksi ke database
        HitungTotalUser()
    End Sub
    Private Sub HitungTotalUser()
        Dim query As String = "SELECT COUNT(*) AS total_baris FROM akun WHERE id_Akun <> ''" ' Mengganti query dengan kondisi yang sesuai

        CMD = New MySqlCommand(query, CONN)

        Try
            Dim totalUser As Integer = Convert.ToInt32(CMD.ExecuteScalar())
            lblTotalUser.Text = totalUser.ToString()
            lblTotalUser.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub lblTotalUser_Click(sender As Object, e As EventArgs) Handles lblTotalUser.Click

    End Sub
End Class


