Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FLogin
    Sub ProgramHide()
        Me.Hide()
    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        Dim input As String = tUsername.Text.Trim()
        Dim Username As String = tUsername.Text
        Dim password As String = tPassword.Text


        Dim isEmail As Boolean = input.Contains("@")

        Dim queryString As String
        If isEmail Then
            queryString = "SELECT * FROM akun WHERE email='" & input & "' AND psw='" & password & "'"
        Else
            queryString = "SELECT * FROM akun WHERE username='" & input & "' AND psw='" & password & "'"
        End If

        CMD = New MySqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader()
        If RD.Read() Then
            If RD.GetString(2) = "equiter" And RD.GetString(3) = "equiter" Then
                Me.Visible = False
                RD.Close()
                Call ProgramHide()
                dashboardAdmin.Show()
            Else
                RD.Close()
                Call ProgramHide()
            End If
        Else
            RD.Close()
            MessageBox.Show("Periksa kembali username dan password", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tUsername.Focus()
            tUsername.Text = ""
            tPassword.Text = ""
        End If
    End Sub

    Private Sub FLogin_Load(sender As Object, e As EventArgs)
        Koneksi.KoneksiDatabase()
    End Sub
End Class