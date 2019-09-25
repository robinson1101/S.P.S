Imports MySql.Data.MySqlClient

Public Class Consignaciones

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
    Sub CargarComboSub2()
        Try
            Dim contador As Integer = 0
            Dim conexion5 As New conexion
            Dim cmd5 As New MySqlCommand("CALL LlenarComboboxSub();", conexion5.conexion)
            conexion5.AbrirConexion()
            Dim leer4 As MySqlDataReader = cmd5.ExecuteReader()
            ComboBoxSub2.Items.Clear()
            ComboBoxSub2.Items.Add("TODOS")
            If leer4.Read Then
                ComboBoxSub2.Items.Add(leer4(contador))
            End If
            conexion5.CerrarConexion()
        Catch ex As Exception
            MsgBox("ERROR DE CONEXION" & vbCrLf & ex.Message)
        End Try

    End Sub
    Private Sub Consignaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatagridConsignaciones()
        CargarComboSub2()
    End Sub

    Private Sub TextBoxValorAingresar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxValorAingresar.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
        End If

        If (e.KeyChar = ChrW(Keys.Space) And TextBoxValorAingresar.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub TextBoxNumReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNumReferencia.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
        End If

        If (e.KeyChar = ChrW(Keys.Space) And TextBoxValorAingresar.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub RadioButtonCargarD_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCargarD.CheckedChanged
        If RadioButtonCargarD.Checked = True Then
            PanelIngresarDatos.Enabled = False
        Else
            PanelIngresarDatos.Enabled = True
        End If

    End Sub
End Class