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

            Dim valorCorte As Integer = 1
            Try



                Dim fechaBD As Date
                Dim fechaNow As Date

                Dim conexion12 As New conexion
                Dim cmd12 As New MySqlCommand("CALL CargarFechaRDoc();", conexion12.conexion)
                conexion12.AbrirConexion()
                Dim leer12 As MySqlDataReader = cmd12.ExecuteReader()
                If leer12.Read Then
                    fechaBD = leer12(0)
                End If

                conexion12.CerrarConexion()



                Dim conexion13 As New conexion
                Dim cmd13 As New MySqlCommand("CALL CargarFechaNDoc();", conexion13.conexion)
                conexion13.AbrirConexion()
                Dim leer13 As MySqlDataReader = cmd13.ExecuteReader()
                If leer13.Read Then
                    fechaNow = leer13(0)
                End If

                conexion13.CerrarConexion()



                Dim conexion14 As New conexion
                Dim cmd14 As New MySqlCommand("CALL CargarNoDoc();", conexion14.conexion)
                conexion14.AbrirConexion()
                Dim leer14 As MySqlDataReader = cmd14.ExecuteReader()
                If leer14.Read Then
                    If fechaBD < fechaNow Then
                        valorCorte = leer14(0) + 1
                    Else
                        valorCorte = leer14(0)
                    End If
                End If

                conexion14.CerrarConexion()

            Catch ex As Exception

            End Try


            saldoPConsignar = Consignaciones.Deuda() - Consignaciones.Consignaciones()


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


                    If saldoPConsignar <= cupo Or cupo = 0 Then
                        Dim Result As DialogResult = MessageBox.Show("¿DESEA SUBIR LOS DATOS INGRESADOS EN LA TABLA?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If Result = DialogResult.Yes Then

                            Dim cmd1 As New MySqlCommand("CALL IngresarPago(?IdR,?NoDoc,?FechaR,?Vendedor,?NoMin,?Referencia,?Tipo,?Valor,?EstadoActual)", conexion1.conexion)
                            conexion1.AbrirConexion()


                            For Each fila In DataGridViewPagos.Rows


                                cmd1.Parameters.Clear()
                                cmd1.Parameters.Add("?IdR", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column1").Value)
                            cmd1.Parameters.Add("?NoDoc", MySqlDbType.VarChar).Value = valorCorte
                            MsgBox(Convert.ToDateTime(fila.Cells("Column3").Value))
                            cmd1.Parameters.Add("?FechaR", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column3").Value)
                            cmd1.Parameters.Add("?Vendedor", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column4").Value)
                                cmd1.Parameters.Add("?NoMin", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column5").Value)
                                cmd1.Parameters.Add("?Referencia", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column6").Value)
                                cmd1.Parameters.Add("?Tipo", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column7").Value)
                                cmd1.Parameters.Add("?Valor", MySqlDbType.VarChar).Value = Convert.ToInt32(fila.Cells("Column8").Value)
                                cmd1.Parameters.Add("?EstadoActual", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column9").Value)

                                cmd1.ExecuteNonQuery()


                            Next

                            DataGridViewPagos.Rows.Clear()
                            MsgBox("DATOS CARGADOS CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")


                            a = Consignaciones.Cupo() - (Consignaciones.Deuda() - Consignaciones.Consignaciones())
                            LabelCupoNeto.Text = a
                            LabelCupoRestante.Text = a
                            LabelValorTotal.Text = "0"
                            Label6.Visible = False


                        End If

                    Else
                        DataGridViewPagos.Rows.Clear()

                        a = Consignaciones.Cupo() - (Consignaciones.Deuda() - Consignaciones.Consignaciones())
                        LabelCupoNeto.Text = a
                        LabelCupoRestante.Text = a
                        LabelValorTotal.Text = "0"
                        Label6.Visible = False
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
        DataGridViewPagos.Rows.Add(ID, LabelIdSub.Text, "", Format$(Now(), "yyyy-MM-dd HH:mm:ss"), LabelNombreP.Text & " - " & LabelCedulaP.Text, "", "", "SERVICIO", "", "EN PROCESO")

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
    Public a As Integer = 0
    Public b As Integer = 0
    Public c As Integer = 0
    Private Sub Cargar_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        a = Consignaciones.Cupo() - (Consignaciones.Deuda() - Consignaciones.Consignaciones())
        LabelCupoNeto.Text = a
        LabelCupoRestante.Text = LabelCupoNeto.Text


    End Sub
    Private Sub DataGridViewPagos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPagos.CellValueChanged

        If DataGridViewPagos.Rows.Count > 0 Then
            Dim Total As Single
            Dim cont As Integer = 0 'PARA CONTADOR DE PARTIDAS

            For Each row As DataGridViewRow In Me.DataGridViewPagos.Rows
                Total += Val(row.Cells(8).Value) 'ROW.CELLS (NUMERO DE LA COLUMNA A SUMAR).VALUE
            Next
            b = Total.ToString
            LabelValorTotal.Text = b
        End If

        c = a - b
        LabelCupoRestante.Text = c
        If LabelCupoRestante.Text < 0 Then
            Label6.Visible = True
        Else
            Label6.Visible = False
        End If

    End Sub

    Private Sub LabelCupoNeto_TextChanged(sender As Object, e As EventArgs) Handles LabelCupoNeto.TextChanged
        LabelCupoNeto.Text = FormatCurrency(LabelCupoNeto.Text)
    End Sub

    Private Sub LabelValorTotal_TextChanged(sender As Object, e As EventArgs) Handles LabelValorTotal.TextChanged
        LabelValorTotal.Text = FormatCurrency(LabelValorTotal.Text)
    End Sub

    Private Sub LabelCupoRestante_TextChanged(sender As Object, e As EventArgs) Handles LabelCupoRestante.TextChanged
        LabelCupoRestante.Text = FormatCurrency(LabelCupoRestante.Text)
    End Sub
End Class