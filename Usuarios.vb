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

            DataGridViewUsuarios.Columns(0).Width = 35
            DataGridViewUsuarios.Columns(1).Width = 180
            DataGridViewUsuarios.Columns(2).Width = 100
            DataGridViewUsuarios.Columns(3).Width = 100
            DataGridViewUsuarios.Columns(3).HeaderText = "CONTRASEÑA"
            DataGridViewUsuarios.Columns(4).Width = 160
            DataGridViewUsuarios.Columns(5).Width = 160
            DataGridViewUsuarios.Columns(6).Width = 100
            DataGridViewUsuarios.Columns(7).Width = 120
            DataGridViewUsuarios.Columns(8).Width = 100
            DataGridViewUsuarios.Columns(9).Width = 141

            DataGridViewUsuarios.Columns(0).SortMode = False
            DataGridViewUsuarios.Columns(1).SortMode = False
            DataGridViewUsuarios.Columns(2).SortMode = False
            DataGridViewUsuarios.Columns(3).SortMode = False
            DataGridViewUsuarios.Columns(4).SortMode = False
            DataGridViewUsuarios.Columns(5).SortMode = False
            DataGridViewUsuarios.Columns(6).SortMode = False
            DataGridViewUsuarios.Columns(7).SortMode = False
            DataGridViewUsuarios.Columns(8).SortMode = False
            DataGridViewUsuarios.Columns(9).SortMode = False


            conexion6.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDataUsuarios()
        ComboBoxTipoUsuario.Items.Add("ADMINISTRADOR")
        ComboBoxTipoUsuario.Items.Add("SUBDISTRIBUIDOR")
    End Sub

    Private Sub DataGridViewUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewUsuarios.CellClick
        If Not (RadioButtonIngresar.Checked = True) Then


            Dim va1, va2, va3, va4, va5, va6, va7, va8, va9 As String
            va1 = DataGridViewUsuarios.Item(4, DataGridViewUsuarios.CurrentRow.Index).Value
            va2 = DataGridViewUsuarios.Item(5, DataGridViewUsuarios.CurrentRow.Index).Value
            va3 = DataGridViewUsuarios.Item(6, DataGridViewUsuarios.CurrentRow.Index).Value
            va4 = DataGridViewUsuarios.Item(7, DataGridViewUsuarios.CurrentRow.Index).Value
            va5 = DataGridViewUsuarios.Item(1, DataGridViewUsuarios.CurrentRow.Index).Value
            va6 = DataGridViewUsuarios.Item(2, DataGridViewUsuarios.CurrentRow.Index).Value
            va7 = DataGridViewUsuarios.Item(3, DataGridViewUsuarios.CurrentRow.Index).Value
            va8 = DataGridViewUsuarios.Item(8, DataGridViewUsuarios.CurrentRow.Index).Value
            va9 = DataGridViewUsuarios.Item(0, DataGridViewUsuarios.CurrentRow.Index).Value

            TextBoxNombre.Text = va1
            TextBoxApellido.Text = va2
            TextBoxCedula.Text = va3
            TextBoxTelefono.Text = va4

            ComboBoxTipoUsuario.Text = va5
            TextBoxUsuario.Text = va6
            TextBoxContraseña.Text = va7
            TextBoxCupo.Text = va8
            LabelIdUsuario.Text = va9
        End If

    End Sub

    Private Sub RadioButtonIngresar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonIngresar.CheckedChanged
        ButtonModificar.Enabled = False
        ButtonEliminar.Enabled = False
        ButtonIngresar.Enabled = True


        If RadioButtonIngresar.Checked = True Then

            TextBoxNombre.Text = ""
            TextBoxApellido.Text = ""
            TextBoxCedula.Text = ""
            TextBoxTelefono.Text = ""
            ComboBoxTipoUsuario.Text = ""
            TextBoxUsuario.Text = ""
            TextBoxContraseña.Text = ""
            TextBoxCupo.Text = ""

            TextBoxNombre.Enabled = True
            TextBoxApellido.Enabled = True
            TextBoxCedula.Enabled = True
            TextBoxTelefono.Enabled = True
            ComboBoxTipoUsuario.Enabled = True
            TextBoxUsuario.Enabled = True
            TextBoxContraseña.Enabled = True
            TextBoxCupo.Enabled = True
        End If
    End Sub

    Private Sub RadioButtonModificar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonModificar.CheckedChanged
        ButtonIngresar.Enabled = False
        ButtonEliminar.Enabled = False
        ButtonModificar.Enabled = True

        TextBoxNombre.Enabled = True
        TextBoxApellido.Enabled = True
        TextBoxCedula.Enabled = True
        TextBoxTelefono.Enabled = True
        ComboBoxTipoUsuario.Enabled = True
        TextBoxUsuario.Enabled = True
        TextBoxContraseña.Enabled = True
        TextBoxCupo.Enabled = True
    End Sub

    Private Sub RadioButtonEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEliminar.CheckedChanged
        ButtonIngresar.Enabled = False
        ButtonModificar.Enabled = False
        ButtonEliminar.Enabled = True

        TextBoxNombre.Enabled = False
        TextBoxApellido.Enabled = False
        TextBoxCedula.Enabled = False
        TextBoxTelefono.Enabled = False
        ComboBoxTipoUsuario.Enabled = False
        TextBoxUsuario.Enabled = False
        TextBoxContraseña.Enabled = False
        TextBoxCupo.Enabled = False

    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click

        Try
            Dim conexion6 As New conexion
            Dim cmd5 As New MySqlCommand("CALL GuardarNuevoUsuario('" & ComboBoxTipoUsuario.SelectedItem & "','" & TextBoxUsuario.Text & "','" & TextBoxContraseña.Text & "',
'" & TextBoxNombre.Text & "','" & TextBoxApellido.Text & "','" & TextBoxCedula.Text & "','" & TextBoxTelefono.Text & "','" & TextBoxCupo.Text & "');", conexion6.conexion)
            conexion6.AbrirConexion()

            Dim var1 As String = ""
            Dim conexion7 As New conexion
            Dim cmd7 As New MySqlCommand("CALL TraerUsuario('" & TextBoxUsuario.Text & "');", conexion7.conexion)
            conexion7.AbrirConexion()
            Dim leer7 As MySqlDataReader = cmd7.ExecuteReader()
            If leer7.Read Then
                var1 = var1 + leer7(0)
            End If
            If var1 <> "" Then
                MsgBox("EL USUARIO A CREAR, YA EXISTE EN BASE DE DATOS", MsgBoxStyle.Critical, "AVISO")
                TextBoxUsuario.Focus()
            Else
                cmd5.ExecuteNonQuery()
                MsgBox("USUARIO CREADO CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")
                TextBoxNombre.Text = ""
                TextBoxApellido.Text = ""
                TextBoxCedula.Text = ""
                TextBoxTelefono.Text = ""
                ComboBoxTipoUsuario.Text = ""
                TextBoxUsuario.Text = ""
                TextBoxContraseña.Text = ""
                TextBoxCupo.Text = ""
            End If

            conexion6.CerrarConexion()
            conexion7.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CargarDataUsuarios()
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click

        Try
            Dim conexion6 As New conexion
            Dim cmd5 As New MySqlCommand("CALL ActualizarUsuario('" & ComboBoxTipoUsuario.SelectedItem & "','" & TextBoxUsuario.Text & "','" & TextBoxContraseña.Text & "',
'" & TextBoxNombre.Text & "','" & TextBoxApellido.Text & "','" & TextBoxCedula.Text & "','" & TextBoxTelefono.Text & "','" & TextBoxCupo.Text & "','" & LabelIdUsuario.Text & "');", conexion6.conexion)
            conexion6.AbrirConexion()
            cmd5.ExecuteNonQuery()
            conexion6.CerrarConexion()
            MsgBox("USUARIO MODIFICADO CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")
            TextBoxNombre.Text = ""
            TextBoxApellido.Text = ""
            TextBoxCedula.Text = ""
            TextBoxTelefono.Text = ""
            ComboBoxTipoUsuario.Text = ""
            TextBoxUsuario.Text = ""
            TextBoxContraseña.Text = ""
            TextBoxCupo.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CargarDataUsuarios()

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim Result As DialogResult = MessageBox.Show("REALMENTE DESEA ELIMINAR EL USUARIO SELECCIONADO?.", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Try
            If Result = DialogResult.Yes Then
                If DataGridViewUsuarios.SelectedRows(0).Index = 0 Then
                    MsgBox("EL ADMINISTRADOR NO SE PUEDE ELIMINAR", MsgBoxStyle.Critical)
                Else
                    Dim conexion6 As New conexion
                    Dim cmd5 As New MySqlCommand("CALL EliminarUsuario('" & LabelIdUsuario.Text & "');", conexion6.conexion)
                    conexion6.AbrirConexion()
                    cmd5.ExecuteNonQuery()
                    conexion6.CerrarConexion()
                    MsgBox("USUARIO ELIMINADO CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")
                    TextBoxNombre.Text = ""
                    TextBoxApellido.Text = ""
                    TextBoxCedula.Text = ""
                    TextBoxTelefono.Text = ""
                    ComboBoxTipoUsuario.Text = ""
                    TextBoxUsuario.Text = ""
                    TextBoxContraseña.Text = ""
                    TextBoxCupo.Text = ""
                End If


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CargarDataUsuarios()
    End Sub

    Private Sub TextBoxCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCedula.KeyPress
        'metodo para evitar que se ingresen letras pero que se puedan borrar los numeros
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If
    End Sub

    Private Sub TextBoxTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTelefono.KeyPress
        'metodo para evitar que se ingresen letras pero que se puedan borrar los numeros
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If
    End Sub

    Private Sub TextBoxCupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCupo.KeyPress
        'metodo para evitar que se ingresen letras pero que se puedan borrar los numeros
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        End If
    End Sub


End Class