Imports MySql.Data.MySqlClient

Public Class Usuarios
    Sub CargarDataUsuarios()
        Try
            Dim conexion6 As New conexion
            Dim cmd5 As New MySqlCommand("CALL CargarDataUsuarios();", conexion6.conexion)
            conexion6.AbrirConexion()
            Dim datas6 As New DataSet
            Dim adaptador6 As New MySqlDataAdapter(cmd5)
            adaptador6.Fill(datas6, "usuarios")

            DataGridViewUsuarios.DataSource = datas6.Tables("usuarios")

            'DataGridViewUsuarios.Columns(0).Width = 35
            'DataGridViewUsuarios.Columns(1).Width = 100
            'DataGridViewUsuarios.Columns(2).Width = 150
            'DataGridViewUsuarios.Columns(3).Width = 250
            'DataGridViewUsuarios.Columns(4).Width = 360
            'DataGridViewUsuarios.Columns(5).Width = 100
            'DataGridViewUsuarios.Columns(6).Width = 207

            conexion6.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDataUsuarios()
    End Sub
End Class