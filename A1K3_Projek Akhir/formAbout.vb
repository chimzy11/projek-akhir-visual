Public Class formAbout
    'supaya bisa scroll
    Private Sub formAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True
    End Sub
End Class