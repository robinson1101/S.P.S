Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class ConsultarEP
    Sub cargarDatagridConsultar()
        Try
            Dim conexion3 As New conexion
            Dim cmd3 As New MySqlCommand("CALL CargarDataConsulta();", conexion3.conexion)
            conexion3.AbrirConexion()
            Dim datas0 As New DataSet
            Dim adaptador1 As New MySqlDataAdapter(cmd3)
            adaptador1.Fill(datas0, "pagos")

            DataGridViewConsultar.DataSource = datas0.Tables("pagos")
            '  DataGridViewConsultar.Columns(9)

            DataGridViewConsultar.Columns(6).Width = 240
            DataGridViewConsultar.Columns(3).Width = 100
            DataGridViewConsultar.Columns(4).Width = 70
            DataGridViewConsultar.Columns(2).Width = 30
            DataGridViewConsultar.Columns(5).Width = 130
            DataGridViewConsultar.Columns(9).Width = 80
            DataGridViewConsultar.Columns(10).Width = 100
            DataGridViewConsultar.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsultar.Columns(0).Width = 35
            DataGridViewConsultar.Columns(1).DisplayIndex = 10

            conexion3.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub ConsultarEP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Principal.LabelTipoU.Text = "SUBDISTRIBUIDOR" Then

            ComboBoxSub.Text = Principal.LabelUsuarioU.Text
            ComboBoxSub.Enabled = False
            Dim conexion9 As New conexion
            Dim cmd9 As New MySqlCommand("CALL BusquedaSub('" & ComboBoxSub.Text & "');", conexion9.conexion)
            conexion9.AbrirConexion()
            Dim datas9 As New DataSet
            Dim adaptador9 As New MySqlDataAdapter(cmd9)
            adaptador9.Fill(datas9, "pagos")
            DataGridViewConsultar.DataSource = datas9.Tables("pagos")

            DataGridViewConsultar.Columns(6).Width = 240
            DataGridViewConsultar.Columns(3).Width = 100
            DataGridViewConsultar.Columns(4).Width = 70
            DataGridViewConsultar.Columns(2).Width = 30
            DataGridViewConsultar.Columns(5).Width = 130
            DataGridViewConsultar.Columns(9).Width = 80
            DataGridViewConsultar.Columns(10).Width = 100
            DataGridViewConsultar.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsultar.Columns(0).Width = 35
            DataGridViewConsultar.Columns(1).DisplayIndex = 10

            conexion9.CerrarConexion()
        Else
            ComboBoxSub.Text = "TODOS"
            cargarDatagridConsultar()
            CargarComboSub()

        End If

    End Sub

    Private Sub DataGridViewConsultar_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridViewConsultar.CellBeginEdit
        'metodo utilizado para evitar la edicion de ciertas columnas
        If DataGridViewConsultar.Columns(e.ColumnIndex).Name = "ID" Or DataGridViewConsultar.Columns(e.ColumnIndex).Name = "ID REGISTRO" Or
           DataGridViewConsultar.Columns(e.ColumnIndex).Name = "No.DOC" Or DataGridViewConsultar.Columns(e.ColumnIndex).Name = "FECHA" Or
            DataGridViewConsultar.Columns(e.ColumnIndex).Name = "VENDEDOR" Or DataGridViewConsultar.Columns(e.ColumnIndex).Name = "No.MIN" Or
            DataGridViewConsultar.Columns(e.ColumnIndex).Name = "REFERENCIA" Or DataGridViewConsultar.Columns(e.ColumnIndex).Name = "TIPO" Or
           DataGridViewConsultar.Columns(e.ColumnIndex).Name = "VALOR" Or DataGridViewConsultar.Columns(e.ColumnIndex).Name = "ESTADO ACTUAL" And
            Principal.LabelTipoU.Text = "ADMINISTRADOR" Then
            e.Cancel = True

        ElseIf Principal.LabelTipoU.Text = "SUBDISTRIBUIDOR" Then
            e.Cancel = True
        End If

    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        cargarDatagridConsultar()
        CargarComboSub()
    End Sub

    Private Sub DataGridViewConsultar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewConsultar.CellClick
        ''BLOQUE UTILIZADO PARA actualizar FILA AL DAR CLICK EN EL BOTON actualizar ALOJADO EN EL DATAGRIDVIEWIG.
        Dim cell As DataGridViewCell = DataGridViewConsultar.CurrentCell
        If Not ((TypeOf cell Is DataGridViewImageCell) And (DataGridViewConsultar.Columns(e.ColumnIndex).Name = "Column1") And Principal.LabelTipoU.Text = "ADMINISTRADOR") Then Return
        Try
            Dim conexion4 As New conexion

            Dim cmd4 As New MySqlCommand("CALL ActualizarEstado('" & DataGridViewConsultar.SelectedCells(2).Value & "','" & DataGridViewConsultar.SelectedCells(1).Value & "');", conexion4.conexion)

            conexion4.AbrirConexion()
            If Convert.ToString(DataGridViewConsultar.CurrentRow.Cells("Column2").Value).Equals("") Then
                MsgBox("SELECCIONE UN ESTADO VALIDO", MsgBoxStyle.Information, "INFORMACION")

            Else
                'Codigo para validar si el sub esta excediendo el cupo asignado
                Dim cupo As Integer = 0
                Dim saldoPConsignar As Integer = 0

                If DataGridViewConsultar.Rows(e.RowIndex).Cells(1).Value = "PAGO" Then
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

                    Dim valorCelda As String = DataGridViewConsultar.Rows(e.RowIndex).Cells(10).Value.ToString()
                    saldoPConsignar += valorCelda
                End If

                MsgBox(saldoPConsignar & "<=" & cupo)

                If saldoPConsignar <= cupo Then
                        Dim Result As DialogResult = MessageBox.Show("¿DESEA ACTUALIZAR EL ESTADO?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If Result = DialogResult.Yes Then

                            cmd4.ExecuteNonQuery()
                            MsgBox("ESTADO ACTUALIZADO CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")

                        End If
                        conexion4.CerrarConexion()
                        cargarDatagridConsultar()

                    Else
                        cargarDatagridConsultar()
                        FormGif.ShowDialog()

                    End If

                End If


        Catch ex As Exception
            MsgBox("ERROR DE CONEXION" & vbCrLf & ex.Message)
        End Try
    End Sub

    Sub CargarComboSub()
        Try
            Dim contador As Integer = 0
            Dim conexion5 As New conexion
            Dim cmd5 As New MySqlCommand("CALL LlenarComboboxSub();", conexion5.conexion)
            conexion5.AbrirConexion()
            Dim leer4 As MySqlDataReader = cmd5.ExecuteReader()
            ComboBoxSub.Items.Clear()
            ComboBoxSub.Items.Add("TODOS")
            While leer4.Read
                ComboBoxSub.Items.Add(leer4(contador))
            End While
            conexion5.CerrarConexion()
        Catch ex As Exception
            MsgBox("ERROR DE CONEXION" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub ButtonExportar_Click(sender As Object, e As EventArgs) Handles ButtonExportar.Click
        Try
            If ((DataGridViewConsultar.Columns.Count = 0) Or (DataGridViewConsultar.Rows.Count = 0)) Then
                Exit Sub
            End If

            'Creando Dataset para Exportar
            Dim dset As New DataSet
            'Agregar tabla al Dataset
            dset.Tables.Add()
            'AGregar Columna a la tabla
            For i As Integer = 2 To ((DataGridViewConsultar.ColumnCount - 1))

                dset.Tables(0).Columns.Add(DataGridViewConsultar.Columns(i).HeaderText)
            Next
            'Agregar filas a la tabla
            Dim dr1 As DataRow
            For i As Integer = 0 To (DataGridViewConsultar.RowCount) - 1


                dr1 = dset.Tables(0).NewRow

                For j As Integer = 2 To 9

                    dr1(j) = DataGridViewConsultar.Rows(i).Cells(j).Value

                Next
                dset.Tables(0).Rows.Add(dr1)

            Next

            Dim aplicacion As New Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            wBook = aplicacion.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                aplicacion.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    aplicacion.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

                Next
            Next
            'Configurar la orientacion de la  hoja y el tamaño
            ''''''''' wSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape
            ''''''  wSheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperLegal
            'Configurar con negrilla la cabecera y tenga autofit
            wSheet.Rows.Item(1).Font.Bold = 1
            wSheet.Columns.AutoFit()

            'este metodo crea una carpeta en documentos
            Dim strFileName As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\ExportadoSdPS"
            '  Dim strFileName As String = "C:\Users\CVR\Desktop\Reporte .xlsx"
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If
            MessageBox.Show("DOCUMENTO EXPORTADO CORRECTAMENTE.", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            wBook.SaveAs(strFileName)
            aplicacion.Workbooks.Open(strFileName)
            aplicacion.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "S.P.S", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBoxNumReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNumReferencia.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then

            e.Handled = False

        ElseIf (Char.IsControl(e.KeyChar)) Then

            e.Handled = False

        Else

            e.Handled = True
        End If

        If (e.KeyChar = ChrW(Keys.Space) And TextBoxNumReferencia.Text = "") Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click


        If ComboBoxSub.SelectedItem <> "TODOS" And TextBoxNumReferencia.Text <> "" And MaskedTextBoxDesde.Text <> "" And MaskedTextBoxHasta.Text <> "" Then
            Dim conexion10 As New conexion
            Dim cmd10 As New MySqlCommand("CALL BusquedaSubReferenciaFecha('" & ComboBoxSub.Text & "','" & TextBoxNumReferencia.Text & "','" & MaskedTextBoxDesde.Text & "','" & MaskedTextBoxHasta.Text & "');", conexion10.conexion)
            conexion10.AbrirConexion()
            Dim datas10 As New DataSet
            Dim adaptador10 As New MySqlDataAdapter(cmd10)
            adaptador10.Fill(datas10, "pagos")
            DataGridViewConsultar.DataSource = datas10.Tables("pagos")

            DataGridViewConsultar.Columns(6).Width = 240
            DataGridViewConsultar.Columns(3).Width = 100
            DataGridViewConsultar.Columns(4).Width = 70
            DataGridViewConsultar.Columns(2).Width = 30
            DataGridViewConsultar.Columns(5).Width = 130
            DataGridViewConsultar.Columns(9).Width = 80
            DataGridViewConsultar.Columns(10).Width = 100
            DataGridViewConsultar.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsultar.Columns(0).Width = 35
            DataGridViewConsultar.Columns(1).DisplayIndex = 10

            conexion10.CerrarConexion()

        ElseIf TextBoxNumReferencia.Text <> "" And ComboBoxSub.Text <> "" Then

            Dim conexion10 As New conexion
            Dim cmd10 As New MySqlCommand("CALL BusquedaSubReferencia('" & TextBoxNumReferencia.Text & "','" & ComboBoxSub.Text & "');", conexion10.conexion)
            conexion10.AbrirConexion()
            Dim datas10 As New DataSet
            Dim adaptador10 As New MySqlDataAdapter(cmd10)
            adaptador10.Fill(datas10, "pagos")
            DataGridViewConsultar.DataSource = datas10.Tables("pagos")

            DataGridViewConsultar.Columns(6).Width = 240
            DataGridViewConsultar.Columns(3).Width = 100
            DataGridViewConsultar.Columns(4).Width = 70
            DataGridViewConsultar.Columns(2).Width = 30
            DataGridViewConsultar.Columns(5).Width = 130
            DataGridViewConsultar.Columns(9).Width = 80
            DataGridViewConsultar.Columns(10).Width = 100
            DataGridViewConsultar.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsultar.Columns(0).Width = 35
            DataGridViewConsultar.Columns(1).DisplayIndex = 10

            conexion10.CerrarConexion()
        ElseIf TextBoxNumReferencia.Text <> "" And MaskedTextBoxDesde.Text <> "" And MaskedTextBoxHasta.Text <> "" Then

            Dim conexion10 As New conexion
            Dim cmd10 As New MySqlCommand("CALL BusquedaReferenciaFecha('" & TextBoxNumReferencia.Text & "','" & MaskedTextBoxDesde.Text & "','" & MaskedTextBoxHasta.Text & "');", conexion10.conexion)
            conexion10.AbrirConexion()
            Dim datas10 As New DataSet
            Dim adaptador10 As New MySqlDataAdapter(cmd10)
            adaptador10.Fill(datas10, "pagos")
            DataGridViewConsultar.DataSource = datas10.Tables("pagos")

            DataGridViewConsultar.Columns(6).Width = 240
            DataGridViewConsultar.Columns(3).Width = 100
            DataGridViewConsultar.Columns(4).Width = 70
            DataGridViewConsultar.Columns(2).Width = 30
            DataGridViewConsultar.Columns(5).Width = 130
            DataGridViewConsultar.Columns(9).Width = 80
            DataGridViewConsultar.Columns(10).Width = 100
            DataGridViewConsultar.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsultar.Columns(0).Width = 35
            DataGridViewConsultar.Columns(1).DisplayIndex = 10

            conexion10.CerrarConexion()

        ElseIf ComboBoxSub.Text <> "" And MaskedTextBoxDesde.Text <> "" And MaskedTextBoxHasta.Text <> "" Then

            Dim conexion10 As New conexion
            Dim cmd10 As New MySqlCommand("CALL BusquedaSubFecha('" & ComboBoxSub.Text & "','" & MaskedTextBoxDesde.Text & "','" & MaskedTextBoxHasta.Text & "');", conexion10.conexion)
            conexion10.AbrirConexion()
            Dim datas10 As New DataSet
            Dim adaptador10 As New MySqlDataAdapter(cmd10)
            adaptador10.Fill(datas10, "pagos")
            DataGridViewConsultar.DataSource = datas10.Tables("pagos")

            DataGridViewConsultar.Columns(6).Width = 240
            DataGridViewConsultar.Columns(3).Width = 100
            DataGridViewConsultar.Columns(4).Width = 70
            DataGridViewConsultar.Columns(2).Width = 30
            DataGridViewConsultar.Columns(5).Width = 130
            DataGridViewConsultar.Columns(9).Width = 80
            DataGridViewConsultar.Columns(10).Width = 100
            DataGridViewConsultar.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsultar.Columns(0).Width = 35
            DataGridViewConsultar.Columns(1).DisplayIndex = 10

            conexion10.CerrarConexion()

        ElseIf ComboBoxSub.Text <> "TODOS" Then

            Dim conexion9 As New conexion
            Dim cmd9 As New MySqlCommand("CALL BusquedaSub('" & ComboBoxSub.Text & "');", conexion9.conexion)
            conexion9.AbrirConexion()
            Dim datas9 As New DataSet
            Dim adaptador9 As New MySqlDataAdapter(cmd9)
            adaptador9.Fill(datas9, "pagos")
            DataGridViewConsultar.DataSource = datas9.Tables("pagos")

            DataGridViewConsultar.Columns(6).Width = 240
            DataGridViewConsultar.Columns(3).Width = 100
            DataGridViewConsultar.Columns(4).Width = 70
            DataGridViewConsultar.Columns(2).Width = 30
            DataGridViewConsultar.Columns(5).Width = 130
            DataGridViewConsultar.Columns(9).Width = 80
            DataGridViewConsultar.Columns(10).Width = 100
            DataGridViewConsultar.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsultar.Columns(0).Width = 35
            DataGridViewConsultar.Columns(1).DisplayIndex = 10

            conexion9.CerrarConexion()

        ElseIf TextBoxNumReferencia.Text <> "" Then

            Dim conexion9 As New conexion
            Dim cmd9 As New MySqlCommand("CALL BusquedaReferencia('" & TextBoxNumReferencia.Text & "');", conexion9.conexion)
            conexion9.AbrirConexion()
            Dim datas9 As New DataSet
            Dim adaptador9 As New MySqlDataAdapter(cmd9)
            adaptador9.Fill(datas9, "pagos")
            DataGridViewConsultar.DataSource = datas9.Tables("pagos")

            DataGridViewConsultar.Columns(6).Width = 240
            DataGridViewConsultar.Columns(3).Width = 100
            DataGridViewConsultar.Columns(4).Width = 70
            DataGridViewConsultar.Columns(2).Width = 30
            DataGridViewConsultar.Columns(5).Width = 130
            DataGridViewConsultar.Columns(9).Width = 80
            DataGridViewConsultar.Columns(10).Width = 100
            DataGridViewConsultar.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsultar.Columns(0).Width = 35
            DataGridViewConsultar.Columns(1).DisplayIndex = 10

            conexion9.CerrarConexion()
        ElseIf MaskedTextBoxDesde.Text <> "" And MaskedTextBoxHasta.Text <> "" Then
            Dim conexion8 As New conexion
            Dim cmd8 As New MySqlCommand("CALL BusquedaFecha('" & MaskedTextBoxDesde.Text & "','" & MaskedTextBoxHasta.Text & "');", conexion8.conexion)
            conexion8.AbrirConexion()
            Dim datas8 As New DataSet
            Dim adaptador8 As New MySqlDataAdapter(cmd8)
            adaptador8.Fill(datas8, "pagos")
            DataGridViewConsultar.DataSource = datas8.Tables("pagos")

            DataGridViewConsultar.Columns(6).Width = 240
            DataGridViewConsultar.Columns(3).Width = 100
            DataGridViewConsultar.Columns(4).Width = 70
            DataGridViewConsultar.Columns(2).Width = 30
            DataGridViewConsultar.Columns(5).Width = 130
            DataGridViewConsultar.Columns(9).Width = 80
            DataGridViewConsultar.Columns(10).Width = 100
            DataGridViewConsultar.Columns(0).DisplayIndex = 11 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsultar.Columns(0).Width = 35
            DataGridViewConsultar.Columns(1).DisplayIndex = 10

            conexion8.CerrarConexion()



        ElseIf ComboBoxSub.Text = "TODOS" Then

            cargarDatagridConsultar()

        Else

            MsgBox("LOS PARAMETROS DE BUSQUEDA NO SON VALIDOS", MsgBoxStyle.Exclamation, "AVISO")
            TextBoxNumReferencia.Focus()
        End If


    End Sub

End Class