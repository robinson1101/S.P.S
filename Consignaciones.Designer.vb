<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consignaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewConsignaciones = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxCupoDisponible = New System.Windows.Forms.TextBox()
        Me.TextBoxSaldoInicial = New System.Windows.Forms.TextBox()
        Me.TextBoxCupo = New System.Windows.Forms.TextBox()
        Me.TextBoxSaldoPConsignar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxSub2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxBusquedaPorFecha = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxNumReferencia = New System.Windows.Forms.TextBox()
        Me.PanelIngresarDatos = New System.Windows.Forms.Panel()
        Me.LabelRuta = New System.Windows.Forms.Label()
        Me.LinkLabelSeleccionar = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonIngrearDatos = New System.Windows.Forms.Button()
        Me.ComboBoxBanco = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxValorAingresar = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PictureBoxParaGuardar = New System.Windows.Forms.PictureBox()
        Me.ToolTipConsignaciones = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonExportar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DataGridViewConsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxBusquedaPorFecha.SuspendLayout()
        Me.PanelIngresarDatos.SuspendLayout()
        CType(Me.PictureBoxParaGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GESTIONAR CONSIGNACIONES"
        '
        'DataGridViewConsignaciones
        '
        Me.DataGridViewConsignaciones.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewConsignaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewConsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewConsignaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewConsignaciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewConsignaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewConsignaciones.Location = New System.Drawing.Point(0, 196)
        Me.DataGridViewConsignaciones.Name = "DataGridViewConsignaciones"
        Me.DataGridViewConsignaciones.RowHeadersVisible = False
        Me.DataGridViewConsignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewConsignaciones.Size = New System.Drawing.Size(1028, 486)
        Me.DataGridViewConsignaciones.TabIndex = 1
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.LinkColor = System.Drawing.Color.DarkViolet
        Me.Column3.Name = "Column3"
        Me.Column3.Text = "DOWNLOAD"
        Me.Column3.UseColumnTextForLinkValue = True
        Me.Column3.VisitedLinkColor = System.Drawing.Color.Red
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.Image = Global.Legar.Resources.Actualizar50
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 35
        '
        'Column2
        '
        Me.Column2.HeaderText = "CAMBIAR A:"
        Me.Column2.Items.AddRange(New Object() {"PAGO", "NO PAGO", "R. ANULADO"})
        Me.Column2.Name = "Column2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SALDO POR CONSIGNAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SALDO INICIAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CUPO DISPONIBLE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "CUPO ACTUAL"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBoxCupoDisponible)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxSaldoInicial)
        Me.Panel1.Controls.Add(Me.TextBoxCupo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBoxSaldoPConsignar)
        Me.Panel1.Location = New System.Drawing.Point(3, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 153)
        Me.Panel1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(138, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "VALORES"
        '
        'TextBoxCupoDisponible
        '
        Me.TextBoxCupoDisponible.Enabled = False
        Me.TextBoxCupoDisponible.Location = New System.Drawing.Point(155, 64)
        Me.TextBoxCupoDisponible.Name = "TextBoxCupoDisponible"
        Me.TextBoxCupoDisponible.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxCupoDisponible.TabIndex = 10
        '
        'TextBoxSaldoInicial
        '
        Me.TextBoxSaldoInicial.Enabled = False
        Me.TextBoxSaldoInicial.Location = New System.Drawing.Point(155, 93)
        Me.TextBoxSaldoInicial.Name = "TextBoxSaldoInicial"
        Me.TextBoxSaldoInicial.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxSaldoInicial.TabIndex = 5
        '
        'TextBoxCupo
        '
        Me.TextBoxCupo.Enabled = False
        Me.TextBoxCupo.Location = New System.Drawing.Point(155, 33)
        Me.TextBoxCupo.Name = "TextBoxCupo"
        Me.TextBoxCupo.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxCupo.TabIndex = 9
        '
        'TextBoxSaldoPConsignar
        '
        Me.TextBoxSaldoPConsignar.Enabled = False
        Me.TextBoxSaldoPConsignar.Location = New System.Drawing.Point(155, 122)
        Me.TextBoxSaldoPConsignar.Name = "TextBoxSaldoPConsignar"
        Me.TextBoxSaldoPConsignar.Size = New System.Drawing.Size(149, 20)
        Me.TextBoxSaldoPConsignar.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 0
        '
        'ComboBoxSub2
        '
        Me.ComboBoxSub2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ComboBoxSub2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSub2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxSub2.FormattingEnabled = True
        Me.ComboBoxSub2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ComboBoxSub2.Location = New System.Drawing.Point(344, 50)
        Me.ComboBoxSub2.Name = "ComboBoxSub2"
        Me.ComboBoxSub2.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxSub2.TabIndex = 15
        Me.ToolTipConsignaciones.SetToolTip(Me.ComboBoxSub2, "Seleccionar SUB")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(341, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SELECCIONAR SUB"
        '
        'GroupBoxBusquedaPorFecha
        '
        Me.GroupBoxBusquedaPorFecha.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.Label3)
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.Label13)
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBoxBusquedaPorFecha.ForeColor = System.Drawing.Color.Red
        Me.GroupBoxBusquedaPorFecha.Location = New System.Drawing.Point(344, 79)
        Me.GroupBoxBusquedaPorFecha.Name = "GroupBoxBusquedaPorFecha"
        Me.GroupBoxBusquedaPorFecha.Size = New System.Drawing.Size(157, 114)
        Me.GroupBoxBusquedaPorFecha.TabIndex = 23
        Me.GroupBoxBusquedaPorFecha.TabStop = False
        Me.GroupBoxBusquedaPorFecha.Text = "Formato: Año/Mes/Dia"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(24, 35)
        Me.MaskedTextBox1.Mask = "0000/00/00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(102, 20)
        Me.MaskedTextBox1.TabIndex = 5
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DESDE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "HASTA:"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(26, 75)
        Me.MaskedTextBox2.Mask = "0000/00/00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 6
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(517, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "N° DE REFERENCIA"
        '
        'TextBoxNumReferencia
        '
        Me.TextBoxNumReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumReferencia.Location = New System.Drawing.Point(518, 51)
        Me.TextBoxNumReferencia.MaxLength = 10
        Me.TextBoxNumReferencia.Name = "TextBoxNumReferencia"
        Me.TextBoxNumReferencia.Size = New System.Drawing.Size(154, 22)
        Me.TextBoxNumReferencia.TabIndex = 20
        Me.TextBoxNumReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelIngresarDatos
        '
        Me.PanelIngresarDatos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelIngresarDatos.Controls.Add(Me.LabelRuta)
        Me.PanelIngresarDatos.Controls.Add(Me.LinkLabelSeleccionar)
        Me.PanelIngresarDatos.Controls.Add(Me.Label9)
        Me.PanelIngresarDatos.Controls.Add(Me.ButtonIngrearDatos)
        Me.PanelIngresarDatos.Controls.Add(Me.ComboBoxBanco)
        Me.PanelIngresarDatos.Controls.Add(Me.Label19)
        Me.PanelIngresarDatos.Controls.Add(Me.Label20)
        Me.PanelIngresarDatos.Controls.Add(Me.TextBoxValorAingresar)
        Me.PanelIngresarDatos.Controls.Add(Me.Label23)
        Me.PanelIngresarDatos.Location = New System.Drawing.Point(689, 40)
        Me.PanelIngresarDatos.Name = "PanelIngresarDatos"
        Me.PanelIngresarDatos.Size = New System.Drawing.Size(336, 153)
        Me.PanelIngresarDatos.TabIndex = 19
        '
        'LabelRuta
        '
        Me.LabelRuta.AutoEllipsis = True
        Me.LabelRuta.Location = New System.Drawing.Point(140, 128)
        Me.LabelRuta.Name = "LabelRuta"
        Me.LabelRuta.Size = New System.Drawing.Size(179, 19)
        Me.LabelRuta.TabIndex = 24
        '
        'LinkLabelSeleccionar
        '
        Me.LinkLabelSeleccionar.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabelSeleccionar.AutoSize = True
        Me.LinkLabelSeleccionar.DisabledLinkColor = System.Drawing.Color.Blue
        Me.LinkLabelSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelSeleccionar.LinkColor = System.Drawing.Color.Red
        Me.LinkLabelSeleccionar.Location = New System.Drawing.Point(15, 131)
        Me.LinkLabelSeleccionar.Name = "LinkLabelSeleccionar"
        Me.LinkLabelSeleccionar.Size = New System.Drawing.Size(119, 12)
        Me.LinkLabelSeleccionar.TabIndex = 23
        Me.LinkLabelSeleccionar.TabStop = True
        Me.LinkLabelSeleccionar.Text = "SELECCIONAR SOPORTE"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(15, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 21)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "$"
        '
        'ButtonIngrearDatos
        '
        Me.ButtonIngrearDatos.BackColor = System.Drawing.Color.Black
        Me.ButtonIngrearDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonIngrearDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIngrearDatos.ForeColor = System.Drawing.Color.White
        Me.ButtonIngrearDatos.Location = New System.Drawing.Point(198, 80)
        Me.ButtonIngrearDatos.Name = "ButtonIngrearDatos"
        Me.ButtonIngrearDatos.Size = New System.Drawing.Size(112, 37)
        Me.ButtonIngrearDatos.TabIndex = 20
        Me.ButtonIngrearDatos.Text = "INGRESAR DATOS"
        Me.ToolTipConsignaciones.SetToolTip(Me.ButtonIngrearDatos, "Ingresar datos")
        Me.ButtonIngrearDatos.UseVisualStyleBackColor = False
        '
        'ComboBoxBanco
        '
        Me.ComboBoxBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxBanco.FormattingEnabled = True
        Me.ComboBoxBanco.Location = New System.Drawing.Point(17, 49)
        Me.ComboBoxBanco.Name = "ComboBoxBanco"
        Me.ComboBoxBanco.Size = New System.Drawing.Size(293, 21)
        Me.ComboBoxBanco.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(104, 1)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(140, 18)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "INGRESAR DATOS"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "INGRESAR VALOR"
        '
        'TextBoxValorAingresar
        '
        Me.TextBoxValorAingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxValorAingresar.Location = New System.Drawing.Point(30, 96)
        Me.TextBoxValorAingresar.MaxLength = 20
        Me.TextBoxValorAingresar.Name = "TextBoxValorAingresar"
        Me.TextBoxValorAingresar.Size = New System.Drawing.Size(150, 21)
        Me.TextBoxValorAingresar.TabIndex = 10
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(129, 13)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "SELECCCIONAR BANCO"
        '
        'PictureBoxParaGuardar
        '
        Me.PictureBoxParaGuardar.Location = New System.Drawing.Point(731, 201)
        Me.PictureBoxParaGuardar.Name = "PictureBoxParaGuardar"
        Me.PictureBoxParaGuardar.Size = New System.Drawing.Size(462, 473)
        Me.PictureBoxParaGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxParaGuardar.TabIndex = 22
        Me.PictureBoxParaGuardar.TabStop = False
        Me.PictureBoxParaGuardar.Visible = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonActualizar.FlatAppearance.BorderSize = 0
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.Image = Global.Legar.Resources.icons8_actualizar_en_la_nube_50
        Me.ButtonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonActualizar.Location = New System.Drawing.Point(518, 160)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(154, 34)
        Me.ButtonActualizar.TabIndex = 10
        Me.ButtonActualizar.Text = "REFRESCAR"
        Me.ButtonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'ButtonExportar
        '
        Me.ButtonExportar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonExportar.FlatAppearance.BorderSize = 0
        Me.ButtonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportar.Image = Global.Legar.Resources.icons8_microsoft_excel_2019_50
        Me.ButtonExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonExportar.Location = New System.Drawing.Point(518, 119)
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(154, 37)
        Me.ButtonExportar.TabIndex = 13
        Me.ButtonExportar.Text = "EXPORTAR"
        Me.ButtonExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExportar.UseVisualStyleBackColor = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonBuscar.FlatAppearance.BorderSize = 0
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscar.Image = Global.Legar.Resources.búsqueda50px
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBuscar.Location = New System.Drawing.Point(518, 76)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(154, 39)
        Me.ButtonBuscar.TabIndex = 22
        Me.ButtonBuscar.Text = "BUSCAR"
        Me.ButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Consignaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 682)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonExportar)
        Me.Controls.Add(Me.PanelIngresarDatos)
        Me.Controls.Add(Me.GroupBoxBusquedaPorFecha)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBoxNumReferencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxSub2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewConsignaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxParaGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Consignaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consignaciones"
        CType(Me.DataGridViewConsignaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBoxBusquedaPorFecha.ResumeLayout(False)
        Me.GroupBoxBusquedaPorFecha.PerformLayout()
        Me.PanelIngresarDatos.ResumeLayout(False)
        Me.PanelIngresarDatos.PerformLayout()
        CType(Me.PictureBoxParaGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewConsignaciones As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxCupoDisponible As TextBox
    Friend WithEvents TextBoxSaldoInicial As TextBox
    Friend WithEvents TextBoxCupo As TextBox
    Friend WithEvents TextBoxSaldoPConsignar As TextBox

    Friend WithEvents Panel2 As Panel

    Friend WithEvents ComboBoxSub2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonExportar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents GroupBoxBusquedaPorFecha As GroupBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxNumReferencia As TextBox
    Friend WithEvents PanelIngresarDatos As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxValorAingresar As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents ToolTipConsignaciones As ToolTip
    Protected WithEvents ComboBoxBanco As ComboBox
    Friend WithEvents ButtonIngrearDatos As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBoxParaGuardar As PictureBox
    Friend WithEvents LinkLabelSeleccionar As LinkLabel
    Friend WithEvents LabelRuta As Label
    Friend WithEvents Column3 As DataGridViewLinkColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewComboBoxColumn
End Class
