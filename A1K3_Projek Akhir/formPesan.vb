Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Public Class formPesan

    Sub PilihanKursi()
        Dim queryString As String = "SELECT * FROM JadwalTeater WHERE judul = @judul"

        CMD = New MySqlCommand(queryString, CONN)
        CMD.Parameters.AddWithValue("@judul", PopUpDataJadwal.cJudul.Text)
        RD = CMD.ExecuteReader()

        If RD.Read() Then

            Dim jumlahTiket As Integer = RD.GetString(7)

            Dim numCheckboxes As Integer = jumlahTiket
            Dim checkBoxesPerRow As Integer = 5
            Dim checkBoxWidth As Integer = 100
            Dim checkBoxHeight As Integer = 20
            Dim spacing As Integer = 10

            Dim nama As Char = "A"c ' Starting character

            For i As Integer = 0 To numCheckboxes - 1
                Dim checkBox As New CheckBox()
                checkBox.Name = "checkBox" & i.ToString()
                checkBox.Text = nama.ToString() & i.ToString()
                Dim row As Integer = i \ checkBoxesPerRow ' Calculate row
                Dim col As Integer = i Mod checkBoxesPerRow ' Calculate column
                Dim x As Integer = 20 + col * (checkBoxWidth + spacing) ' Calculate X position
                Dim y As Integer = 50 + row * (checkBoxHeight + spacing) ' Calculate Y position
                checkBox.Location = New Point(x, y)
                Panel2.Controls.Add(checkBox)

                ' Update character for every group of 5 CheckBoxes
                If (i + 1) Mod 5 = 0 Then
                    If nama < "Z"c Then
                        nama = Chr(Asc(nama) + 1)
                    End If
                End If
            Next
        End If

        RD.Close()
    End Sub


    Private Sub formPesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        PilihanKursi()
        Dim queryString As String = "SELECT * FROM JadwalTeater WHERE judul ='" & PopUpDataJadwal.cJudul.Text & "'"

        CMD = New MySqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            lJudul.Text = RD.GetString(1)
        End If

        RD.Close()

        Dim queryString1 As String = "SELECT * FROM akun WHERE username ='" & FLogin.tUsername.Text & "'"

        CMD = New MySqlCommand(queryString1, CONN)
        RD = CMD.ExecuteReader()

        If RD.Read() Then
            lUsername.Text = RD.GetString(3)
        End If

        RD.Close()

    End Sub
End Class