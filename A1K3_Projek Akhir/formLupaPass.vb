Imports MySql.Data.MySqlClient

Public Class formLupaPass
    Public Sub KodeKeamanan()
        Dim KodeRandom As String
        Dim Kode As String
        Kode = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Randomize()

        For i = 1 To 6
            KodeRandom = KodeRandom & Mid(Kode, Int(Rnd() * Len(Kode) + 1), 1)
        Next i
        lKodeKeamanan.Text = KodeRandom
    End Sub
    Function CekDataKosong()
        If tEmail.Text = "" Then
            MessageBox.Show("EMail belum diisi!", "Konfirmasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            tEmail.Focus()
        ElseIf tKodeKeamanan.Text = "" Then
            MessageBox.Show("Kode Keamanan belum diisi", "Konfirmasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            tKodeKeamanan.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub formLupaPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        Call KoneksiDatabase()
        If CekDataKosong() = True Then
            Dim Email As String = tEmail.Text
            Dim Psw As String = lPassword.Text
            Dim KodeKeamanan As String = tKodeKeamanan.Text

            Dim isEmail As Boolean = Email.Contains("@")
            Dim isKodeKeamananCorrect As Boolean = KodeKeamanan = lKodeKeamanan.Text

            If isEmail And isKodeKeamananCorrect Then
                Dim queryString As String = "SELECT * FROM akun WHERE email='" & Email & "'"
                CMD = New MySqlCommand(queryString, CONN)
                RD = CMD.ExecuteReader()

                If RD.HasRows Then
                    RD.Read()
                    lTextPassword.Text = "Password anda adalah"
                    lPassword.Text = RD("psw").ToString()
                Else
                    MessageBox.Show("Email tidak ditemukan.")
                End If

                CONN.Close()
            Else
                MessageBox.Show("Email atau kode keamanan salah.")
            End If
        End If
    End Sub
    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        tEmail.Clear()
        tKodeKeamanan.Clear()
        lKodeKeamanan.Text = ""
        KodeKeamanan()
        lPassword.Text = ""
        lTextPassword.Text = ""
    End Sub
    Private Sub tEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles tEmail.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            tKodeKeamanan.Focus()
        End If
    End Sub


    Private Sub tKodeKeamanan_KeyDown(sender As Object, e As KeyEventArgs) Handles tKodeKeamanan.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            bSimpan.PerformClick()
        End If
    End Sub

    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Close()
    End Sub
End Class