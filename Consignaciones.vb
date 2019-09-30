Imports System.IO
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
        If Principal.LabelTipoU.Text = "ADMINISTRADOR" Then
            PanelIngresarDatos.Visible = False
        End If
        cargarDatagridConsignaciones()
        CargarComboSub2()
        CargarComboBanco()


        TextBoxCupo.Text = Cupo()
        TextBoxCupoDisponible.Text = Cupo() - (Deuda() - Consignaciones())
        TextBoxSaldoInicial.Text = Deuda()
        TextBoxSaldoPConsignar.Text = Deuda() - Consignaciones()



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
                        cargarDatagridConsignaciones()

                    TextBoxCupo.Text = Cupo()
                    TextBoxCupoDisponible.Text = Cupo() - (Deuda() - Consignaciones())
                    TextBoxSaldoInicial.Text = Deuda()
                    TextBoxSaldoPConsignar.Text = Deuda() - Consignaciones()


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

        TextBoxCupo.Text = Cupo()
        TextBoxCupoDisponible.Text = Cupo() - (Deuda() - Consignaciones())
        TextBoxSaldoInicial.Text = Deuda()
        TextBoxSaldoPConsignar.Text = Deuda() - Consignaciones()

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
        Dim cupoSub As Integer
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
        Dim deudaSub As Integer
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
        Dim consignacionesSub As Integer
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


End Class