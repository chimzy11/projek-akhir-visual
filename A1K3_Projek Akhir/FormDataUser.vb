Imports MySql.Data.MySqlClient

Public Class FormDataUser
    Private Sub FormDataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDatabase()
        TampilDataUser()
        GridDataUser()
    End Sub

    Sub TampilDataUser()
        DA = New MySqlDataAdapter("SELECT id_akun, namalengkap, email, username, nohp, status FROM akun", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Data User")
        DGVDataUser.DataSource = DS.Tables("Data User")
        DGVDataUser.Refresh()
    End Sub

    Sub GridDataUser()
        DGVDataUser.Columns(0).Width = 90
        DGVDataUser.Columns(1).Width = 170
        DGVDataUser.Columns(2).Width = 170
        DGVDataUser.Columns(3).Width = 150
        DGVDataUser.Columns(4).Width = 130
        DGVDataUser.Columns(5).Width = 140

        DGVDataUser.Columns(0).HeaderText = "ID User"
        DGVDataUser.Columns(1).HeaderText = "Nama Lengkap"
        DGVDataUser.Columns(2).HeaderText = "E-Mail"
        DGVDataUser.Columns(3).HeaderText = "Username"
        DGVDataUser.Columns(4).HeaderText = "Nomor Telepon"
        DGVDataUser.Columns(5).HeaderText = "Status"

    End Sub
    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search"
            txtSearch.ForeColor = Color.DarkGray
            TampilDataUser()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If txtSearch.Text = "Search" Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.FromArgb(132, 123, 112)
        End If

        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * From akun where username like '%" & txtSearch.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then

                DA = New MySqlDataAdapter("Select * From akun where username like '%" & txtSearch.Text & "%'", CONN)
                DS = New DataSet
                RD.Close()
                DA.Fill(DS, "Found")
                DGVDataUser.DataSource = DS.Tables("Found")
                DGVDataUser.ReadOnly = True
            Else
                RD.Close()
                MsgBox("Data tidak ditemukan!", MsgBoxStyle.Information, "Attention")
            End If
        End If
    End Sub

    Private Sub DGVDataUser_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDataUser.CellDoubleClick
        Dim result As DialogResult = MessageBox.Show("Yakin ingin hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim rowIndex As Integer = e.RowIndex
            Dim IdAkun As Integer = DGVDataUser.Rows(rowIndex).Cells(0).Value
            DGVDataUser.Rows.RemoveAt(rowIndex)
            CMD = New MySqlCommand("DELETE FROM akun WHERE id_akun = " & IdAkun, CONN)
            CMD.ExecuteNonQuery()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub DGVDataUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDataUser.CellContentClick

    End Sub
End Class