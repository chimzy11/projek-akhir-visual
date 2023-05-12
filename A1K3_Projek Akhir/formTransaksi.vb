Public Class formTransaksi
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            ' Mengatur warna latar belakang baris untuk baris genap
            e.CellStyle.BackColor = Color.FromArgb(250, 246, 243)
        Else
            ' Mengatur warna latar belakang baris untuk baris ganjil
            e.CellStyle.BackColor = Color.FromArgb(250, 246, 243)
        End If
    End Sub

    Private Sub formTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 174, 169)
        DataGridView1.EnableHeadersVisualStyles = False

        AddHandler DataGridView1.CellFormatting, AddressOf DataGridView1_CellFormatting
    End Sub
End Class
