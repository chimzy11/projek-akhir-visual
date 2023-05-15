Imports MySql.Data.MySqlClient

Public Class FRegistrasi

    Sub ProgramHide()
        Me.Hide()
    End Sub
    Private Function GetLastID() As Integer
        Dim lastID As Integer = 0
        Dim commandText As String = "SELECT MAX(id_akun) FROM akun"
        Dim command As MySqlCommand = New MySqlCommand(commandText, CONN)

        Dim result As Object = command.ExecuteScalar()
        If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
            lastID = Convert.ToInt32(result)
        End If

        Return lastID
    End Function
    Function CekDataKosong()
        If tNamaLengkap.Text = "" Then
            MessageBox.Show("Nama Lengkap Tidak Boleh Kosong", "Konfirmasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            tNamaLengkap.Focus()
        ElseIf tUsername.Text = "" Then
            MessageBox.Show("Username Tidak Boleh Kosong", "Konfirmasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            tUsername.Focus()
        ElseIf tEmail.Text = "" Then
            MessageBox.Show("Email Tidak Boleh Kosong", "Konfirmasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            tEmail.Focus()
        ElseIf tPassword.Text = "" Then
            MessageBox.Show("Password Tidak Boleh Kosong", "Konfirmasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            tPassword.Focus()
        ElseIf tKonfirmasi.Text = "" Then
            MessageBox.Show("Konfirmasi Password Tidak Boleh Kosong", "Konfirmasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            tKonfirmasi.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub FRegistrasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        tNamaLengkap.Focus()
    End Sub
    Private Sub bSignUp_Click(sender As Object, e As EventArgs) Handles bSignUp.Click
        Dim IDAkun As Integer
        Dim NamaLengkap As String = tNamaLengkap.Text
        Dim Email As String = tEmail.Text
        Dim Username As String = tUsername.Text
        Dim Psw As String = tPassword.Text
        Dim KonfirPsw As String = tKonfirmasi.Text
        Dim NoHP As String = "null"
        Dim Foto As String = "null"
        Dim Status As String = "User"

        If CekDataKosong() = True Then
            If Not Email.Contains("@") Then
                MsgBox("Invalid email address!", MsgBoxStyle.Exclamation, "Attention")
                tEmail.Text = ""
                tEmail.Focus()
                Exit Sub
            End If

            If Psw <> KonfirPsw Then
                MsgBox("Password and confirmation password do not match!", MsgBoxStyle.Exclamation, "Attention")
                tPassword.Text = ""
                tKonfirmasi.Text = ""
                tPassword.Focus()
                Exit Sub
            End If
            Dim lastID As Integer = GetLastID()
            If lastID = 0 Then
                IDAkun = 14052002
            Else
                IDAkun = lastID + 1
            End If

            CMD = New MySqlCommand("SELECT * FROM akun WHERE username ='" & Username & "'", CONN)
            RD = CMD.ExecuteReader()
            If RD.Read() Then
                RD.Close()
                MsgBox("Username already exists!", MsgBoxStyle.Exclamation, "Attention")
            Else
                RD.Close()

                Dim Simpan As String = "INSERT INTO akun(id_akun, namalengkap, email, username, psw, nohp, foto, status) VALUES ('" &
            IDAkun & "','" & NamaLengkap & "','" & Email & "','" & Username & "','" & Psw & "','" & NoHP & "','" & Foto & "','" & Status & "')"
                CMD = New MySqlCommand(Simpan, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Create account successfully!", MsgBoxStyle.Information, "Attention")
                ProgramHide()
                FLogin.Show()
            End If
        End If
    End Sub

    Private Sub lSignIn_Click(sender As Object, e As EventArgs) Handles lSignIn.Click
        Call ProgramHide()
        FLogin.Show()
    End Sub
    Private Sub tNamaLengkap_KeyDown(sender As Object, e As KeyEventArgs) Handles tNamaLengkap.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            tEmail.Focus()
        End If
    End Sub
    Private Sub tEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles tEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            tUsername.Focus()
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
            tKonfirmasi.Focus()
        End If
    End Sub
    Private Sub tKonfirmasi_KeyDown(sender As Object, e As KeyEventArgs) Handles tKonfirmasi.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            bSignUp.PerformClick()
        End If
    End Sub

End Class