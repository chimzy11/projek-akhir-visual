Imports MySql.Data.MySqlClient

Public Class PopUpDataJadwal
    Private Sub pKembali_Click(sender As Object, e As EventArgs) Handles pKembali.Click
        Me.Close()
    End Sub

    Private Sub PopUpDataJadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()

        Dim queryString1 As String = "SELECT * FROM JadwalTeater where genre = @musikal"
        CMD = New MySqlCommand(queryString1, CONN)
        CMD.Parameters.AddWithValue("@musikal", "musikal")
        RD = CMD.ExecuteReader()

        While RD.Read()
            cJudul.Items.Add(RD.GetString("judul"))
        End While

        RD.Close()

        If cJudul.Items.Count > 0 Then
            cJudul.SelectedIndex = 0
        End If
    End Sub

    Private Sub bLihat_Click(sender As Object, e As EventArgs) Handles bLihat.Click
        If Not String.IsNullOrEmpty(cJudul.Text) Then
            If cJudul.SelectedIndex = 0 Then
                MessageBox.Show("Pilih ID teater yang akan diperbarui", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.Hide()
                formDetailMusikal.Show()
            End If
        Else
            MessageBox.Show("Pilih ID teater yang akan diperbarui", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class