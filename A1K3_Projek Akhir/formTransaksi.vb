Public Class formTransaksi
    Private Sub btnClose_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) 
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub
    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) 
        If e.RowIndex Mod 2 = 0 Then
            ' Mengatur warna latar belakang baris untuk baris genap
            e.CellStyle.BackColor = Color.FromArgb(250, 246, 243)
        Else
            ' Mengatur warna latar belakang baris untuk baris ganjil
            e.CellStyle.BackColor = Color.FromArgb(185, 174, 169)
        End If
    End Sub

    Private Sub formTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridDataTransaksi()
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

    Sub GridDataTransaksi()
        DataGridView2.Columns(0).Width = 90
        DataGridView2.Columns(1).Width = 90
        DataGridView2.Columns(2).Width = 80
        DataGridView2.Columns(3).Width = 150
        DataGridView2.Columns(4).Width = 150
        DataGridView2.Columns(5).Width = 150
        DataGridView2.Columns(6).Width = 80

        DataGridView2.Columns(0).HeaderText = "Nama Pengirim"
        DataGridView2.Columns(1).HeaderText = "Nama Penerima"
        DataGridView2.Columns(2).HeaderText = "Jumlah Tiket"
        DataGridView2.Columns(3).HeaderText = "Judul Teater"
        DataGridView2.Columns(4).HeaderText = "No Rekening Pengirim"
        DataGridView2.Columns(5).HeaderText = "No Rekening Penerima"
        DataGridView2.Columns(6).HeaderText = "No Rekening Pengirim"

    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
