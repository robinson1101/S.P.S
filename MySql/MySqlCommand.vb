Imports MySql.Data.MySqlClient

Namespace MySql
    Friend Class MySqlCommand
        Private v As String
        Private conexion As MySqlConnection

        Public Sub New(v As String, conexion As MySqlConnection)
            Me.v = v
            Me.conexion = conexion
        End Sub
    End Class
End Namespace
