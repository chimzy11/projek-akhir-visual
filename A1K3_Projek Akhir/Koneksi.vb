Imports MySql.Data.MySqlClient
Module Koneksi
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public DA As MySqlDataAdapter
    Public RD As MySqlDataReader
    Public DS As DataSet
    Public STR As String

    Sub KoneksiDatabase()
        Try
            Dim STR As String = "server=localhost;userid=root;password=;database=teatertix"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
