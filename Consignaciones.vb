Imports MySql.Data.MySqlClient

Public Class Consignaciones
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 0 Then
            LabelConsignar.ForeColor = Color.Black
            LabelConsultar.ForeColor = Color.Red
        End If

    End Sub
    Sub cargarDatagridConsignaciones()
        Try
            Dim conexion6 As New conexion
            Dim cmd5 As New MySqlCommand("CALL IngresarConsignacion();", conexion6.conexion)
            conexion6.AbrirConexion()
            Dim datas6 As New DataSet
            Dim adaptador6 As New MySqlDataAdapter(cmd5)
            adaptador6.Fill(datas6, "pagos")

            DataGridViewConsignaciones.DataSource = datas6.Tables("pagos")
            '  DataGridViewConsultar.Columns(9)

            'DataGridViewConsignaciones.Columns(6).Width = 250
            'DataGridViewConsignaciones.Columns(4).Width = 70
            'DataGridViewConsignaciones.Columns(2).Width = 30
            'DataGridViewConsignaciones.Columns(5).Width = 120
            'DataGridViewConsignaciones.Columns(9).Width = 80
            'DataGridViewConsignaciones.Columns(10).Width = 100
            'DataGridViewConsignaciones.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            'DataGridViewConsignaciones.Columns(0).Width = 35
            'DataGridViewConsignaciones.Columns(1).DisplayIndex = 10

            conexion6.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub Consignaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatagridConsignaciones()
    End Sub
End Class