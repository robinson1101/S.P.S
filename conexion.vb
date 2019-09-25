Imports MySql.Data.MySqlClient

Public Class conexion

    'BLOQUE UTILIZADO PARA INICIAR BD Y ABRIR LA CONEXION.2309-2019
    Public conexion As New MySqlConnection
    Public Sub AbrirConexion()
        Try

            '  conexion.ConnectionString = "server=167.114.216.134;database=BDRecaudos;user id=BDRecaudos;password=recaudosMovilco;"
            conexion.ConnectionString = "server=127.0.0.1;database=bd_recaudos;user id=root;password=;"
            conexion.Open()

        Catch ex As Exception
            MsgBox("ERROR DE CONEXION A BASE DE DATOS " + ex.Message, MsgBoxStyle.Critical, "INFORMACION")
        End Try


    End Sub

    Public Sub CerrarConexion()
        conexion.Close()
    End Sub
End Class
