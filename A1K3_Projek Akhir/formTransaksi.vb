Public Class formTransaksi
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub
    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            ' Mengatur warna latar belakang baris untuk baris genap
            e.CellStyle.BackColor = Color.FromArgb(250, 246, 243)
        Else
            ' Mengatur warna latar belakang baris untuk baris ganjil
            e.CellStyle.BackColor = Color.FromArgb(185, 174, 169)
        End If
    End Sub

    Private Sub formTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(185, 174, 169)
        DataGridView2.EnableHeadersVisualStyles = False

        AddHandler DataGridView2.CellFormatting, AddressOf DataGridView2_CellFormatting
        AutoResizeColumns()
    End Sub
    Private Sub AutoResizeColumns()
        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Next
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
