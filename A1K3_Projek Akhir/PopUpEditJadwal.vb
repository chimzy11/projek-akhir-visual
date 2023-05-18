Imports MySql.Data.MySqlClient

Public Class PopUpEditJadwal
    Private Sub FIdEditFormTeater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        Dim queryString As String = "SELECT id_teater FROM JadwalTeater"

        CMD = New MySqlCommand(queryString, CONN)
        RD = CMD.ExecuteReader()

        While RD.Read()
            cIdTeater.Items.Add(RD.GetString("id_teater"))
        End While

        RD.Close()

        If cIdTeater.Items.Count > 0 Then
            cIdTeater.SelectedIndex = 0
        End If
    End Sub
    Private Sub bPilih_Click(sender As Object, e As EventArgs) Handles bPilih.Click

        If Not String.IsNullOrEmpty(cIdTeater.Text) Then
            If cIdTeater.SelectedIndex = 0 Then
                MessageBox.Show("Pilih ID teater yang akan diperbarui", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.Hide()
                formEdit.Show()
            End If
        Else
            MessageBox.Show("Pilih ID teater yang akan diperbarui", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class