Imports MySql.Data.MySqlClient

Public Class Cargar_pago
    Private Sub ButtonSubirP_Click(sender As Object, e As EventArgs) Handles ButtonSubirP.Click
        Try
            'Codigo para validar si el sub esta excediendo el cupo asignado
            Dim cupo As Integer = 0
            Dim saldoPConsignar As Integer = 0

            Dim conexion7 As New conexion
            Dim cmd6 As New MySqlCommand("CALL CargarCupo('" & Principal.LabelUsuarioU.Text & "','" & Principal.LabelTipoU.Text & "');", conexion7.conexion)
            conexion7.AbrirConexion()
            Dim leer6 As MySqlDataReader = cmd6.ExecuteReader()
            If leer6.Read Then
                cupo = leer6(0)
            End If
            conexion7.CerrarConexion()

            Dim conexion10 As New conexion
            Dim cmd9 As New MySqlCommand("CALL CargarSaldoPConsignar('" & Principal.LabelUsuarioU.Text & "');", conexion10.conexion)
            conexion10.AbrirConexion()
            Dim leer9 As MySqlDataReader = cmd9.ExecuteReader()
            If leer9.Read Then
                saldoPConsignar = leer9(0)
            End If
            conexion10.CerrarConexion()


            'codigo para validar que el datagrid no guarde campos vacios
            Dim numLineas As Integer = DataGridViewPagos.RowCount - 1

            Dim contador As Integer = 0
            Dim validador As String = "verdadero"
            Dim numeroOletra As Integer = 1

            For variable1 = 0 To numLineas Step 1

                For variable2 = 1 To 9 Step 1
                    If (Convert.ToString(DataGridViewPagos.Rows(contador).Cells(5).Value)).Equals("") Then
                        validador = "falso"
                    End If
                    Try
                        If (IsNumeric(((DataGridViewPagos.Rows(contador).Cells(5).Value)) = False)) Then

                        End If
                    Catch ex As Exception
                        numeroOletra = 0
                    End Try


                    If (Convert.ToString(DataGridViewPagos.Rows(contador).Cells(6).Value)).Equals("") Then
                        validador = "falso"
                    End If
                    Try
                        If (IsNumeric(((DataGridViewPagos.Rows(contador).Cells(6).Value)) = False)) Then

                        End If
                    Catch ex As Exception
                        numeroOletra = 0
                    End Try


                    If (Convert.ToString(DataGridViewPagos.Rows(contador).Cells(7).Value)).Equals("") Then
                        validador = "falso"

                    End If

                    If (Convert.ToString(DataGridViewPagos.Rows(contador).Cells(8).Value)).Equals("") Then
                        validador = "falso"

                    End If
                    Try
                        If (IsNumeric(((DataGridViewPagos.Rows(contador).Cells(8).Value)) = False)) Then

                        End If
                    Catch ex As Exception
                        numeroOletra = 0
                    End Try



                Next
                contador = contador + 1
            Next




            Dim conexion1 As New conexion
            If validador = "verdadero" And numeroOletra = 1 And (DataGridViewPagos.Rows.Count > 0) Then
                Dim fila As New DataGridViewRow()

                Dim CONT As Integer = 0
                For Each row As DataGridViewRow In Me.DataGridViewPagos.Rows
                    saldoPConsignar += Val(row.Cells(8).Value)
                Next


                If saldoPConsignar <= cupo Then
                    Dim Result As DialogResult = MessageBox.Show("¿DESEA SUBIR LOS DATOS INGRESADOS EN LA TABLA?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If Result = DialogResult.Yes Then

                        Dim cmd1 As New MySqlCommand("CALL IngresarPago(?IdR,?NoDoc,?FechaR,?Vendedor,?NoMin,?Referencia,?Tipo,?Valor,?EstadoActual)", conexion1.conexion)
                        conexion1.AbrirConexion()


                        For Each fila In DataGridViewPagos.Rows


                            cmd1.Parameters.Clear()
                            cmd1.Parameters.Add("?IdR", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column1").Value)
                            cmd1.Parameters.Add("?NoDoc", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column2").Value)
                            cmd1.Parameters.Add("?FechaR", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column3").Value)
                            cmd1.Parameters.Add("?Vendedor", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column4").Value)
                            cmd1.Parameters.Add("?NoMin", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column5").Value)
                            cmd1.Parameters.Add("?Referencia", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column6").Value)
                            cmd1.Parameters.Add("?Tipo", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column7").Value)
                            cmd1.Parameters.Add("?Valor", MySqlDbType.VarChar).Value = Convert.ToInt16(fila.Cells("Column8").Value)
                            cmd1.Parameters.Add("?EstadoActual", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column9").Value)

                            cmd1.ExecuteNonQuery()


                        Next

                        DataGridViewPagos.Rows.Clear()
                        MsgBox("DATOS CARGADOS CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")

                    End If

                Else
                    DataGridViewPagos.Rows.Clear()
                    FormGif.ShowDialog()

                End If


            ElseIf validador = "falso" Then
                MsgBox("POR FAVOR DILIGENCIE TODOS LOS CAMPOS", MsgBoxStyle.Exclamation, "AVISO")

            ElseIf numeroOletra = 0 Then
                MsgBox("LOS CAMPOS NO.MIN , REFERENCIA Y VALOR DEBEN SER DATOS NUMERICOS", MsgBoxStyle.Exclamation, "AVISO")
            ElseIf DataGridViewPagos.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS EN LA TABLA", MsgBoxStyle.Exclamation, "AVISO")
            End If

            conexion1.CerrarConexion()
        Catch ex As Exception
            MsgBox("ERROR DE CONEXION." & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub ButtonIngresarR_Click(sender As Object, e As EventArgs) Handles ButtonIngresarR.Click


        Dim ID As String = ""

        Dim conexion2 As New conexion
        Dim cmd2 As New MySqlCommand("select count(IdPago) from pagos", conexion2.conexion)
        conexion2.AbrirConexion()
        Dim leer1 As MySqlDataReader = cmd2.ExecuteReader()
        If leer1.Read Then
            ID = leer1(0) + (DataGridViewPagos.Rows.Count + 1)
        End If

        conexion2.CerrarConexion()
        DataGridViewPagos.Rows.Add(ID, LabelIdSub.Text, "", Format$(Now(), "yyyy-MM-dd hh:mm:ss"), LabelNombreP.Text & " - " & LabelCedulaP.Text, "", "", "SERVICIO", "", "EN PROCESO")

    End Sub

    Private Sub DataGridViewPagos_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridViewPagos.CellBeginEdit
        If DataGridViewPagos.Columns(e.ColumnIndex).Name = "Column1" Or DataGridViewPagos.Columns(e.ColumnIndex).Name = "Column10" Or
            DataGridViewPagos.Columns(e.ColumnIndex).Name = "Column2" Or DataGridViewPagos.Columns(e.ColumnIndex).Name = "Column3" Or
            DataGridViewPagos.Columns(e.ColumnIndex).Name = "Column4" Or DataGridViewPagos.Columns(e.ColumnIndex).Name = "Column9" Then

            e.Cancel = True
        End If

    End Sub

    Private Sub DataGridViewPagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPagos.CellClick
        ''BLOQUE UTILIZADO PARA ELIMINAR FILA AL DAR CLICK EN EL BOTON ELIMINAR ALOJADO EN EL DATAGRIDVIEWIG.
        Dim cell As DataGridViewCell = DataGridViewPagos.CurrentCell
        If Not ((TypeOf cell Is DataGridViewImageCell) And (DataGridViewPagos.Columns(e.ColumnIndex).Name = "Column11")) Then Return
        Try
            DataGridViewPagos.Rows.Remove(DataGridViewPagos.CurrentRow)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class