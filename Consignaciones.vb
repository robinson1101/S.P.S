Imports System.IO
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class Consignaciones

    Sub cargarDatagridConsignaciones()
        Try
            Dim conexion6 As New conexion
            Dim cmd5 As New MySqlCommand("CALL CargarDataConsignaciones();", conexion6.conexion)
            conexion6.AbrirConexion()
            Dim datas6 As New DataSet
            Dim adaptador6 As New MySqlDataAdapter(cmd5)
            adaptador6.Fill(datas6, "consignaciones")

            DataGridViewConsignaciones.DataSource = datas6.Tables("consignaciones")

            DataGridViewConsignaciones.Columns(0).Width = 100
            'DataGridViewConsignaciones.Columns(1).Width = 100
            DataGridViewConsignaciones.Columns(2).Width = 100
            DataGridViewConsignaciones.Columns(3).Width = 35
            DataGridViewConsignaciones.Columns(4).Width = 100
            DataGridViewConsignaciones.Columns(5).Width = 130
            DataGridViewConsignaciones.Columns(6).Width = 200
            DataGridViewConsignaciones.Columns(7).Width = 300
            DataGridViewConsignaciones.Columns(0).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsignaciones.Columns(1).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsignaciones.Columns(2).DisplayIndex = 7 'posicionar el boton actualizar en la ultima posicion del datagrid

            conexion6.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Sub CargarComboBanco()
        Try

            Dim conexion5 As New conexion
            Dim cmd5 As New MySqlCommand("CALL LlenarComboboxBancos();", conexion5.conexion)
            conexion5.AbrirConexion()
            Dim leer4 As MySqlDataReader = cmd5.ExecuteReader()
            ComboBoxBanco.Items.Clear()

            While leer4.Read
                ComboBoxBanco.Items.Add(leer4(0))
            End While

            conexion5.CerrarConexion()
        Catch ex As Exception
            MsgBox("ERROR DE CONEXION" & vbCrLf & ex.Message)
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
            While leer4.Read
                ComboBoxSub2.Items.Add(leer4(contador))
            End While
            conexion5.CerrarConexion()
        Catch ex As Exception
            MsgBox("ERROR DE CONEXION" & vbCrLf & ex.Message)
        End Try

    End Sub
    Private Sub Consignaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If Principal.LabelTipoU.Text = "SUBDISTRIBUIDOR" Then
            TextBoxCupo.Text = Cupo()
            TextBoxCupoDisponible.Text = Cupo() - (Deuda() - Consignaciones())
            TextBoxSaldoInicial.Text = Deuda()
            TextBoxSaldoPConsignar.Text = Deuda() - Consignaciones()
            CargarComboBanco()

            ComboBoxSub2.Text = Principal.LabelUsuarioU.Text
            ComboBoxSub2.Enabled = False
            Dim conexion9 As New conexion
            Dim cmd9 As New MySqlCommand("CALL BusquedaSubC('" & ComboBoxSub2.Text & "');", conexion9.conexion)
            conexion9.AbrirConexion()
            Dim datas9 As New DataSet
            Dim adaptador9 As New MySqlDataAdapter(cmd9)
            adaptador9.Fill(datas9, "consignaciones")
            DataGridViewConsignaciones.DataSource = datas9.Tables("consignaciones")

            DataGridViewConsignaciones.Columns(0).Width = 100
            'DataGridViewConsignaciones.Columns(1).Width = 100
            DataGridViewConsignaciones.Columns(2).Width = 100
            DataGridViewConsignaciones.Columns(3).Width = 35
            DataGridViewConsignaciones.Columns(4).Width = 100
            DataGridViewConsignaciones.Columns(5).Width = 130
            DataGridViewConsignaciones.Columns(6).Width = 200
            DataGridViewConsignaciones.Columns(7).Width = 300
            DataGridViewConsignaciones.Columns(0).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsignaciones.Columns(1).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsignaciones.Columns(2).DisplayIndex = 7 'posicionar el boton actualizar en la ultima posicion del datagrid

            conexion9.CerrarConexion()



        ElseIf Principal.LabelTipoU.Text = "ADMINISTRADOR" Then
            PanelIngresarDatos.Visible = False
            TextBoxCupo.Text = 0
            TextBoxCupoDisponible.Text = 0
            TextBoxSaldoInicial.Text = 0
            TextBoxSaldoPConsignar.Text = 0

            CargarComboBanco()

            ComboBoxSub2.Text = "TODOS"

            CargarComboSub2()



            cargarDatagridConsignaciones()
        End If


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

    Private Sub TextBoxNumReferencia_KeyPress(sender As Object, e As KeyPressEventArgs)
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


    Private Sub TextBoxCA_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCupo.TextChanged
        TextBoxCupo.Text = FormatCurrency(TextBoxCupo.Text)
    End Sub

    Private Sub TextBoxCupoDisponible_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCupoDisponible.TextChanged
        TextBoxCupoDisponible.Text = FormatCurrency(TextBoxCupoDisponible.Text)
    End Sub

    Private Sub TextBoxSaldoInicial_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSaldoInicial.TextChanged
        TextBoxSaldoInicial.Text = FormatCurrency(TextBoxSaldoInicial.Text)
    End Sub

    Private Sub TextBoxSaldoPConsignar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSaldoPConsignar.TextChanged
        TextBoxSaldoPConsignar.Text = FormatCurrency(TextBoxSaldoPConsignar.Text)

    End Sub

    Private Sub DataGridViewConsignaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewConsignaciones.CellClick
        ''BLOQUE UTILIZADO PARA actualizar FILA AL DAR CLICK EN EL BOTON actualizar ALOJADO EN EL DATAGRIDVIEWIG.
        Dim cell As DataGridViewCell = DataGridViewConsignaciones.CurrentCell
        Dim paso As Integer = 0
        If (Not ((TypeOf cell Is DataGridViewImageCell) And (DataGridViewConsignaciones.Columns(e.ColumnIndex).Name = "Column1") And Principal.LabelTipoU.Text = "ADMINISTRADOR")) Then Return

        Try
            Dim conexion4 As New conexion
            MsgBox(DataGridViewConsignaciones.SelectedCells(2).Value & "','" & DataGridViewConsignaciones.SelectedCells(3).Value)
            Dim cmd4 As New MySqlCommand("CALL ActualizarEstadoConsig('" & DataGridViewConsignaciones.SelectedCells(3).Value & "','" & DataGridViewConsignaciones.SelectedCells(2).Value & "');", conexion4.conexion)

            conexion4.AbrirConexion()
            If Convert.ToString(DataGridViewConsignaciones.CurrentRow.Cells("Column2").Value).Equals("") Then
                MsgBox("SELECCIONE UN ESTADO VALIDO", MsgBoxStyle.Information, "INFORMACION")

            Else

                Dim Result As DialogResult = MessageBox.Show("¿DESEA ACTUALIZAR EL ESTADO?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If Result = DialogResult.Yes Then

                    cmd4.ExecuteNonQuery()


                    TextBoxCupo.Text = 0
                    TextBoxCupoDisponible.Text = 0
                    TextBoxSaldoInicial.Text = 0
                    TextBoxSaldoPConsignar.Text = 0

                    ComboBoxSub2.Text = "TODOS"
                    cargarDatagridConsignaciones()
                    MsgBox("ESTADO ACTUALIZADO CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")

                End If
                conexion4.CerrarConexion()
            End If

        Catch ex As Exception
            MsgBox("ERROR DE CONEXION" & vbCrLf & ex.Message)
        End Try

    End Sub
    Shared Function Imagen_Bytes(ByVal Foto As Image) As Byte()
        If Not Foto Is Nothing Then
            Dim Codi As New IO.MemoryStream
            Foto.Save(Codi, Imaging.ImageFormat.Jpeg)
            Return Codi.GetBuffer
        Else
            Return Nothing
        End If
    End Function
    Private Sub ButtonIngrearDatos_Click(sender As Object, e As EventArgs) Handles ButtonIngrearDatos.Click
        If (ComboBoxBanco.Text <> "" And TextBoxValorAingresar.Text <> "" And LabelRuta.Text <> "") Then

            Try
                Dim conexion10 As New conexion
                Dim cmd9 As New MySqlCommand("CALL IngresarConsignacion('" & Principal.LabelUsuarioU.Text & "','" & ComboBoxBanco.SelectedItem.ToString & "','" & TextBoxValorAingresar.Text & "',?imagen);", conexion10.conexion)
                conexion10.AbrirConexion()



                Dim fs As New FileStream(ruta1, FileMode.Open, FileAccess.Read)

                Dim imag = Image.FromStream(fs)

                cmd9.Parameters.AddWithValue("?imagen", Imagen_Bytes(imag))
                cmd9.ExecuteNonQuery()
                conexion10.CerrarConexion()
                imag.Dispose()
                fs.Dispose()
                ComboBoxBanco.Text = ""
                LabelRuta.Text = ""
                TextBoxValorAingresar.Text = ""


                TextBoxCupo.Text = Cupo()
                TextBoxCupoDisponible.Text = Cupo() - (Deuda() - Consignaciones())
                TextBoxSaldoInicial.Text = Deuda()
                TextBoxSaldoPConsignar.Text = Deuda() - Consignaciones()

                Dim conexion12 As New conexion
                Dim cmd12 As New MySqlCommand("CALL BusquedaSubC('" & ComboBoxSub2.Text & "');", conexion12.conexion)
                conexion12.AbrirConexion()
                Dim datas12 As New DataSet
                Dim adaptador12 As New MySqlDataAdapter(cmd12)
                adaptador12.Fill(datas12, "consignaciones")
                DataGridViewConsignaciones.DataSource = datas12.Tables("consignaciones")

                DataGridViewConsignaciones.Columns(0).Width = 100
                'DataGridViewConsignaciones.Columns(1).Width = 100
                DataGridViewConsignaciones.Columns(2).Width = 100
                DataGridViewConsignaciones.Columns(3).Width = 35
                DataGridViewConsignaciones.Columns(4).Width = 100
                DataGridViewConsignaciones.Columns(5).Width = 130
                DataGridViewConsignaciones.Columns(6).Width = 200
                DataGridViewConsignaciones.Columns(7).Width = 300
                DataGridViewConsignaciones.Columns(0).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
                DataGridViewConsignaciones.Columns(1).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
                DataGridViewConsignaciones.Columns(2).DisplayIndex = 7 'posicionar el boton actualizar en la ultima posicion del datagrid

                conexion12.CerrarConexion()

                MsgBox("DATOS GUARDADOS CORRECTAMENTE", MsgBoxStyle.Information, "INFORMACION")

            Catch ex As Exception
                MsgBox("ERROR DE CONEXION" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "AVISO")
            End Try
        Else
            MsgBox("TODOS LOS CAMPOS DEBEN SER DEBIDAMENTE DILIGENCIADOS", MsgBoxStyle.Information, "INFORMACION")
        End If



    End Sub

    Private Sub DataGridViewConsignaciones_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridViewConsignaciones.CellBeginEdit


        If (DataGridViewConsignaciones.Columns(e.ColumnIndex).Name = "ID" Or DataGridViewConsignaciones.Columns(e.ColumnIndex).Name = "ID REGISTRO" Or
            DataGridViewConsignaciones.Columns(e.ColumnIndex).Name = "FECHA CONSIGNACION" Or DataGridViewConsignaciones.Columns(e.ColumnIndex).Name = "VENDEDOR" Or
            DataGridViewConsignaciones.Columns(e.ColumnIndex).Name = "BANCO" Or DataGridViewConsignaciones.Columns(e.ColumnIndex).Name = "VALOR" Or
            DataGridViewConsignaciones.Columns(e.ColumnIndex).Name = "ESTADO PAGO") And Principal.LabelTipoU.Text = "ADMINISTRADOR" Then

            e.Cancel = True
        ElseIf Principal.LabelTipoU.Text = "SUBDISTRIBUIDOR" Then

            e.Cancel = True
        End If
    End Sub

    Public ruta1 As String = ""
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelSeleccionar.LinkClicked
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "C:\"
        openFileDialog1.Filter = "Archivo JPG|*.jpg|PDF|*.pdf|PNG|*.png"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


            PictureBoxParaGuardar.Tag = openFileDialog1.FileName
            LabelRuta.Text = Path.GetFileName(PictureBoxParaGuardar.Tag.ToString)
            ruta1 = openFileDialog1.FileName



        End If
    End Sub
    Shared Function Bytes_Imagen(ByVal Foto As Byte()) As Image
        If Not Foto Is Nothing Then
            Dim Codi As New IO.MemoryStream(Foto)
            Dim resultado As Image = Image.FromStream(Codi)
            Return resultado
        Else
            Return Nothing
        End If
    End Function
    Private bmp As Bitmap
    Private Sub DataGridViewConsignaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewConsignaciones.CellContentClick

        Dim cell2 As DataGridViewCell = DataGridViewConsignaciones.CurrentCell
        If Not ((TypeOf cell2 Is DataGridViewLinkCell) And (DataGridViewConsignaciones.Columns(e.ColumnIndex).Name = "Column3")) Then Return

        Try
            Dim bin As String
            Dim conexion6 As New conexion
            Dim cmd5 As New MySqlCommand("CALL TraerImagen('" & Convert.ToString(DataGridViewConsignaciones.CurrentRow.Cells(3).Value) & "');", conexion6.conexion)
            conexion6.AbrirConexion()
            Dim leer11 As MySqlDataReader = cmd5.ExecuteReader()
            If leer11.Read Then
                PictureBoxParaGuardar.Image = Bytes_Imagen(leer11(0))

            End If

            Dim A As Integer
            Randomize()
            A = Int(Rnd() * 100) * 1

            'este metodo crea una carpeta en documentos
            Dim CarpetaDestino As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\soportes"
            MsgBox("Se almacenara en la ruta.. " & CarpetaDestino, MsgBoxStyle.Information, "INFORMACION")



            Try
                ':::Validamos si la carpeta existe
                If My.Computer.FileSystem.DirectoryExists(CarpetaDestino) Then

                    'este metodo se utiliza para modificar el tamaño del panel a guardar
                    bmp = New Bitmap(PictureBoxParaGuardar.Width, PictureBoxParaGuardar.Height)
                    Dim G As Graphics = Graphics.FromImage(bmp)
                    PictureBoxParaGuardar.DrawToBitmap(bmp, PictureBoxParaGuardar.ClientRectangle)


                    'Guardamos el mapa de bits como archivo JPEG.

                    bmp.Save(CarpetaDestino & "\picture" & A & ".jpg", Imaging.ImageFormat.Jpeg)
                    bmp.Dispose()


                Else
                    'Si la carpeta no existe la creamos
                    My.Computer.FileSystem.CreateDirectory(CarpetaDestino)

                    'este metodo se utiliza para modificar el tamaño del panel a guardar
                    bmp = New Bitmap(PictureBoxParaGuardar.Width, PictureBoxParaGuardar.Height)
                    Dim G As Graphics = Graphics.FromImage(bmp)
                    PictureBoxParaGuardar.DrawToBitmap(bmp, PictureBoxParaGuardar.ClientRectangle)


                    ' Guardamos el mapa de bits como archivo JPEG.

                    bmp.Save(CarpetaDestino & "\picture" & A & ".jpg", Imaging.ImageFormat.Jpeg)
                    bmp.Dispose()

                End If
            Catch ex As Exception
                MsgBox("Error al realizar el proceso debido a: " & ex.Message)
            End Try



            conexion6.CerrarConexion()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Function Cupo()
        Dim cupoSub As Integer = 0
        Try

            Dim conexion7 As New conexion
            Dim cmd6 As New MySqlCommand("CALL CargarCupo('" & Principal.LabelUsuarioU.Text & "','" & Principal.LabelTipoU.Text & "');", conexion7.conexion)
            conexion7.AbrirConexion()
            Dim leer6 As MySqlDataReader = cmd6.ExecuteReader()
            If leer6.Read Then
                cupoSub = leer6(0)
            End If
            conexion7.CerrarConexion()
        Catch ex As Exception
            cupoSub = 0
        End Try
        Return cupoSub
    End Function
    Function Deuda()
        Dim deudaSub As Integer = 0
        Try

            Dim conexion7 As New conexion
            Dim cmd6 As New MySqlCommand("CALL CargarDeuda('" & Principal.LabelUsuarioU.Text & "');", conexion7.conexion)
            conexion7.AbrirConexion()
            Dim leer6 As MySqlDataReader = cmd6.ExecuteReader()
            If leer6.Read Then
                deudaSub = leer6(0)
            End If
            conexion7.CerrarConexion()
        Catch ex As Exception
            deudaSub = 0
        End Try
        Return deudaSub
    End Function
    Function Consignaciones()
        Dim consignacionesSub As Integer = 0
        Try

            Dim conexion7 As New conexion
            Dim cmd6 As New MySqlCommand("CALL CargarConsignacionesPagas('" & Principal.LabelUsuarioU.Text & "');", conexion7.conexion)
            conexion7.AbrirConexion()
            Dim leer6 As MySqlDataReader = cmd6.ExecuteReader()
            If leer6.Read Then
                consignacionesSub = leer6(0)
            End If
            conexion7.CerrarConexion()
        Catch ex As Exception
            consignacionesSub = 0
        End Try
        Return consignacionesSub
    End Function

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Try
            MsgBox(MaskedTextBoxDesdeC.Text & " " & MaskedTextBoxDesdeC.Text)
            If MaskedTextBoxDesdeC.Text <> "" And MaskedTextBoxHastaC.Text <> "" And ComboBoxSub2.Text <> "TODOS" Then
                Dim conexion6 As New conexion
                Dim cmd5 As New MySqlCommand("CALL BusquedaSubFechaC('" & ComboBoxSub2.Text & "','" & MaskedTextBoxDesdeC.Text & "','" & MaskedTextBoxHastaC.Text & "');", conexion6.conexion)
                conexion6.AbrirConexion()
                Dim datas6 As New DataSet
                Dim adaptador6 As New MySqlDataAdapter(cmd5)
                adaptador6.Fill(datas6, "consignaciones")

                DataGridViewConsignaciones.DataSource = datas6.Tables("consignaciones")

                TextBoxCupo.Text = Cupo()
                TextBoxCupoDisponible.Text = Cupo() - (Deuda() - Consignaciones())
                TextBoxSaldoInicial.Text = Deuda()
                TextBoxSaldoPConsignar.Text = Deuda() - Consignaciones()

                conexion6.CerrarConexion()
            ElseIf MaskedTextBoxDesdeC.Text <> "" And MaskedTextBoxHastaC.Text <> "" And ComboBoxSub2.Text = "TODOS" Then
                Dim conexion8 As New conexion
                Dim cmd8 As New MySqlCommand("CALL BusquedaFechaC('" & MaskedTextBoxDesdeC.Text & "','" & MaskedTextBoxHastaC.Text & "');", conexion8.conexion)
                conexion8.AbrirConexion()
                Dim datas8 As New DataSet
                Dim adaptador8 As New MySqlDataAdapter(cmd8)
                adaptador8.Fill(datas8, "consignaciones")

                DataGridViewConsignaciones.DataSource = datas8.Tables("consignaciones")


                conexion8.CerrarConexion()

                TextBoxCupo.Text = CupoSub()
                TextBoxCupoDisponible.Text = CupoSub() - (DeudaSub() - ConsignacionesSub())
                TextBoxSaldoInicial.Text = DeudaSub()
                TextBoxSaldoPConsignar.Text = DeudaSub() - ConsignacionesSub()

            ElseIf ComboBoxSub2.Text <> "TODOS" Then

                Dim conexion7 As New conexion
                Dim cmd7 As New MySqlCommand("CALL BusquedaSubC('" & ComboBoxSub2.Text & "');", conexion7.conexion)
                conexion7.AbrirConexion()
                Dim datas7 As New DataSet
                Dim adaptador7 As New MySqlDataAdapter(cmd7)
                adaptador7.Fill(datas7, "consignaciones")

                DataGridViewConsignaciones.DataSource = datas7.Tables("consignaciones")


                conexion7.CerrarConexion()
                TextBoxCupo.Text = CupoSub()
                TextBoxCupoDisponible.Text = CupoSub() - (DeudaSub() - ConsignacionesSub())
                TextBoxSaldoInicial.Text = DeudaSub()
                TextBoxSaldoPConsignar.Text = DeudaSub() - ConsignacionesSub()

            ElseIf ComboBoxSub2.Text = "TODOS" Then
                cargarDatagridConsignaciones()

                TextBoxCupo.Text = Cupo()
                TextBoxCupoDisponible.Text = Cupo() - (Deuda() - Consignaciones())
                TextBoxSaldoInicial.Text = Deuda()
                TextBoxSaldoPConsignar.Text = Deuda() - Consignaciones()
            End If

            DataGridViewConsignaciones.Columns(0).Width = 100
            'DataGridViewConsignaciones.Columns(1).Width = 100
            DataGridViewConsignaciones.Columns(2).Width = 100
            DataGridViewConsignaciones.Columns(3).Width = 35
            DataGridViewConsignaciones.Columns(4).Width = 100
            DataGridViewConsignaciones.Columns(5).Width = 130
            DataGridViewConsignaciones.Columns(6).Width = 200
            DataGridViewConsignaciones.Columns(7).Width = 300
            DataGridViewConsignaciones.Columns(0).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsignaciones.Columns(1).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsignaciones.Columns(2).DisplayIndex = 7 'posicionar el boton actualizar en la ultima posicion del datagrid


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Function CupoSub()
        Dim cupo As Integer = 0
        Try

            Dim conexion7 As New conexion
            Dim cmd6 As New MySqlCommand("CALL CargarCupo('" & ComboBoxSub2.Text & "','SUBDISTRIBUIDOR');", conexion7.conexion)
            conexion7.AbrirConexion()
            Dim leer6 As MySqlDataReader = cmd6.ExecuteReader()
            If leer6.Read Then
                cupo = leer6(0)
            End If
            cupo += -0
            conexion7.CerrarConexion()
        Catch ex As Exception
            cupo = 0
        End Try
        Return cupo
    End Function
    Function DeudaSub()
        Dim deuda As Integer = 0
        Try

            Dim conexion7 As New conexion
            Dim cmd6 As New MySqlCommand("CALL CargarDeuda('" & ComboBoxSub2.Text & "');", conexion7.conexion)
            conexion7.AbrirConexion()
            Dim leer6 As MySqlDataReader = cmd6.ExecuteReader()
            If leer6.Read Then
                deuda = leer6(0)
            End If
            conexion7.CerrarConexion()
        Catch ex As Exception
            deuda = 0
        End Try
        deuda += -0
        Return deuda
    End Function
    Function ConsignacionesSub()
        Dim consignaciones As Integer = 0
        Try

            Dim conexion7 As New conexion
            Dim cmd6 As New MySqlCommand("CALL CargarConsignacionesPagas('" & ComboBoxSub2.Text & "');", conexion7.conexion)
            conexion7.AbrirConexion()
            Dim leer6 As MySqlDataReader = cmd6.ExecuteReader()
            If leer6.Read Then
                consignaciones = leer6(0)
            End If
            conexion7.CerrarConexion()
        Catch ex As Exception
            consignaciones = 0
        End Try
        consignaciones += -0
        Return consignaciones
    End Function

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        If Principal.LabelTipoU.Text = "ADMINISTRADOR" Then
            cargarDatagridConsignaciones()

        ElseIf Principal.LabelTipoU.Text = "SUBDISTRIBUIDOR" Then

            Dim conexion13 As New conexion
            Dim cmd13 As New MySqlCommand("CALL BusquedaSubC('" & ComboBoxSub2.Text & "');", conexion13.conexion)
            conexion13.AbrirConexion()
            Dim datas13 As New DataSet
            Dim adaptador13 As New MySqlDataAdapter(cmd13)
            adaptador13.Fill(datas13, "consignaciones")
            DataGridViewConsignaciones.DataSource = datas13.Tables("consignaciones")

            DataGridViewConsignaciones.Columns(0).Width = 100
            'DataGridViewConsignaciones.Columns(1).Width = 100
            DataGridViewConsignaciones.Columns(2).Width = 100
            DataGridViewConsignaciones.Columns(3).Width = 35
            DataGridViewConsignaciones.Columns(4).Width = 100
            DataGridViewConsignaciones.Columns(5).Width = 130
            DataGridViewConsignaciones.Columns(6).Width = 200
            DataGridViewConsignaciones.Columns(7).Width = 300
            DataGridViewConsignaciones.Columns(0).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsignaciones.Columns(1).DisplayIndex = 9 'posicionar el boton actualizar en la ultima posicion del datagrid
            DataGridViewConsignaciones.Columns(2).DisplayIndex = 7 'posicionar el boton actualizar en la ultima posicion del datagrid

            conexion13.CerrarConexion()

        End If


    End Sub

    Private Sub ButtonExportar_Click(sender As Object, e As EventArgs) Handles ButtonExportar.Click
        Try
            If ((DataGridViewConsignaciones.Columns.Count = 0) Or (DataGridViewConsignaciones.Rows.Count = 0)) Then
                Exit Sub
            End If

            'Creando Dataset para Exportar
            Dim dset As New DataSet
            'Agregar tabla al Dataset
            dset.Tables.Add()
            'AGregar Columna a la tabla
            For i As Integer = 2 To ((DataGridViewConsignaciones.ColumnCount - 1))

                dset.Tables(0).Columns.Add(DataGridViewConsignaciones.Columns(i).HeaderText)
            Next
            'Agregar filas a la tabla
            Dim dr1 As DataRow
            For i As Integer = 0 To (DataGridViewConsignaciones.RowCount) - 1


                dr1 = dset.Tables(0).NewRow

                For j As Integer = 2 To 9

                    dr1(j) = DataGridViewConsignaciones.Rows(i).Cells(j).Value

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
            ''''''  wSheet.PageSetup.PaperSize = Excel.XlPaperSize.xlPaperLegalDataGridViewConsignaciones
            'Configurar con negrilla la cabecera y tenga autofit
            wSheet.Rows.Item(1).Font.Bold = 1
            wSheet.Columns.AutoFit()

            'este metodo crea una carpeta en documentos
            Dim strFileName As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\ExportadoSPS"
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

    Private Sub ComboBoxSub2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxSub2.KeyPress
        e.Handled = True  'este pequeño codigo se utiliza para deshabilitar la edicion del combobox

        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub ComboBoxBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxBanco.KeyPress
        e.Handled = True
    End Sub
End Class