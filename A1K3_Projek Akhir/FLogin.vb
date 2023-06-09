﻿Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FLogin
    Sub ProgramHide()
        Me.Hide()
    End Sub
    Function CekDataKosong()
        If tUsername.Text = "" Then
            MessageBox.Show("Username belum diisi!", "Konfirmasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            tUsername.Focus()
        ElseIf tPassword.Text = "" Then
            MessageBox.Show("Password belum diisi", "Konfirmasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            tPassword.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub FLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        DashboardUser.Close()
        DashboardAdmin.Close()
        tUsername.Text = ""
        tPassword.Text = ""
        cRememberMe.Checked = False

        If My.Computer.FileSystem.FileExists("RememberMe.txt") Then
            Dim loginData() As String = My.Computer.FileSystem.ReadAllText("RememberMe.txt").Split(",")
            tUsername.Text = loginData(0)
            tPassword.Text = loginData(1)
            cRememberMe.Checked = True
        End If
        lForgotPassword.Enabled = Not cRememberMe.Checked
    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        Call KoneksiDatabase()
        If CekDataKosong() = True Then
            Dim input As String = tUsername.Text.Trim()
            Dim username As String = tUsername.Text
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
                If RD.GetString(3) = "Equiter" And RD.GetString(4) = "equiter" Then
                    DashboardAdmin.lUsername.Text = RD.GetString(1)
                    Me.Visible = False
                    RD.Close()
                    Call ProgramHide()
                    DashboardAdmin.Show()
                Else
                    DashboardUser.lUsername.Text = RD.GetString(3)
                    RD.Close()
                    Call ProgramHide()
                    DashboardUser.Show()
                End If

                If cRememberMe.Checked = True Then
                    My.Computer.FileSystem.WriteAllText("RememberMe.txt", tUsername.Text & "," & tPassword.Text, False)
                Else
                    If My.Computer.FileSystem.FileExists("RememberMe.txt") Then
                        My.Computer.FileSystem.DeleteFile("RememberMe.txt")
                    End If
                End If
            Else
                RD.Close()
                MessageBox.Show("Periksa kembali username dan password", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tUsername.Focus()
            End If
        End If
    End Sub

    Private Sub lSignUp_Click(sender As Object, e As EventArgs) Handles lSignUp.Click
        Call ProgramHide()
        FRegistrasi.Show()
    End Sub

    Private Sub lForgotPassword_Click(sender As Object, e As EventArgs) Handles lForgotPassword.Click
        formLupaPass.KodeKeamanan()
        formLupaPass.Show()
    End Sub

    Private Sub pPasswordHide_Click(sender As Object, e As EventArgs) Handles pPasswordHide.Click
        If tPassword.PasswordChar = "●" Then
            tPassword.PasswordChar = ""
            pPasswordHide.BackgroundImage = My.Resources.eye_on
        Else
            tPassword.PasswordChar = "●"
            pPasswordHide.BackgroundImage = My.Resources.eye_of
        End If
    End Sub

    Private Sub tUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles tUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            tPassword.Focus()
        End If
    End Sub

    Private Sub tPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            bLogin.PerformClick()
        End If
    End Sub

    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Close()
        LandingPage.Show()
    End Sub
End Class