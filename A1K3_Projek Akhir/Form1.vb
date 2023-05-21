Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numCheckboxes As Integer = 50
        Dim checkBoxesPerRow As Integer = 5
        Dim checkBoxWidth As Integer = 100
        Dim checkBoxHeight As Integer = 20
        Dim spacing As Integer = 10

        Dim nama As Char = "A"c ' Karakter awal

        For i As Integer = 0 To numCheckboxes - 1
            Dim checkBox As New CheckBox()
            checkBox.Name = "checkBox" & i.ToString()
            checkBox.Text = nama.ToString() & i.ToString() ' Menggunakan variabel nama
            Dim row As Integer = i \ checkBoxesPerRow ' Menghitung baris
            Dim col As Integer = i Mod checkBoxesPerRow ' Menghitung kolom
            Dim x As Integer = 150 + col * (checkBoxWidth + spacing) ' Menghitung posisi X
            Dim y As Integer = 150 + row * (checkBoxHeight + spacing) ' Menghitung posisi Y
            checkBox.Location = New Point(x, y)
            Me.Controls.Add(checkBox)

            ' Mengubah karakter nama setiap kelompok 5 CheckBox
            If (i + 1) Mod 5 = 0 Then
                If nama < "Z"c Then
                    nama = Chr(Asc(nama) + 1)
                End If
            End If
        Next
    End Sub

End Class
