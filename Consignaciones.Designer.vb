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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consignaciones))
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
        Me.MaskedTextBoxDesdeC = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxHastaC = New System.Windows.Forms.MaskedTextBox()
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
        Me.ToolTipConsignaciones = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonExportar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBoxParaGuardar = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewConsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxBusquedaPorFecha.SuspendLayout()
        Me.PanelIngresarDatos.SuspendLayout()
        CType(Me.PictureBoxParaGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewConsignaciones
        '
        Me.DataGridViewConsignaciones.AllowUserToAddRows = False
        Me.DataGridViewConsignaciones.AllowUserToDeleteRows = False
        Me.DataGridViewConsignaciones.AllowUserToResizeColumns = False
        Me.DataGridViewConsignaciones.AllowUserToResizeRows = False
        Me.DataGridViewConsignaciones.BackgroundColor = System.Drawing.Color.White
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
        Me.DataGridViewConsignaciones.Location = New System.Drawing.Point(0, 200)
        Me.DataGridViewConsignaciones.Name = "DataGridViewConsignaciones"
        Me.DataGridViewConsignaciones.RowHeadersVisible = False
        Me.DataGridViewConsignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewConsignaciones.Size = New System.Drawing.Size(1205, 486)
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
        Me.Column1.Image = Global.S.P.S.Resources.Actualizar50
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
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SALDO POR CONSIGNAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "SALDO INICIAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CUPO DISPONIBLE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 16)
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
        Me.Panel1.Location = New System.Drawing.Point(3, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 179)
        Me.Panel1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(165, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "VALORES"
        '
        'TextBoxCupoDisponible
        '
        Me.TextBoxCupoDisponible.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxCupoDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCupoDisponible.Enabled = False
        Me.TextBoxCupoDisponible.Font = New System.Drawing.Font("Lucida Bright", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCupoDisponible.ForeColor = System.Drawing.Color.Black
        Me.TextBoxCupoDisponible.Location = New System.Drawing.Point(177, 67)
        Me.TextBoxCupoDisponible.Multiline = True
        Me.TextBoxCupoDisponible.Name = "TextBoxCupoDisponible"
        Me.TextBoxCupoDisponible.Size = New System.Drawing.Size(231, 31)
        Me.TextBoxCupoDisponible.TabIndex = 10
        '
        'TextBoxSaldoInicial
        '
        Me.TextBoxSaldoInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxSaldoInicial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxSaldoInicial.Enabled = False
        Me.TextBoxSaldoInicial.Font = New System.Drawing.Font("Lucida Bright", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSaldoInicial.ForeColor = System.Drawing.Color.Black
        Me.TextBoxSaldoInicial.Location = New System.Drawing.Point(177, 102)
        Me.TextBoxSaldoInicial.Multiline = True
        Me.TextBoxSaldoInicial.Name = "TextBoxSaldoInicial"
        Me.TextBoxSaldoInicial.Size = New System.Drawing.Size(231, 31)
        Me.TextBoxSaldoInicial.TabIndex = 5
        '
        'TextBoxCupo
        '
        Me.TextBoxCupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxCupo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCupo.Enabled = False
        Me.TextBoxCupo.Font = New System.Drawing.Font("Lucida Bright", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCupo.ForeColor = System.Drawing.Color.Black
        Me.TextBoxCupo.Location = New System.Drawing.Point(177, 32)
        Me.TextBoxCupo.Multiline = True
        Me.TextBoxCupo.Name = "TextBoxCupo"
        Me.TextBoxCupo.Size = New System.Drawing.Size(231, 31)
        Me.TextBoxCupo.TabIndex = 9
        '
        'TextBoxSaldoPConsignar
        '
        Me.TextBoxSaldoPConsignar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxSaldoPConsignar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxSaldoPConsignar.Enabled = False
        Me.TextBoxSaldoPConsignar.Font = New System.Drawing.Font("Lucida Bright", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSaldoPConsignar.ForeColor = System.Drawing.Color.Black
        Me.TextBoxSaldoPConsignar.Location = New System.Drawing.Point(177, 137)
        Me.TextBoxSaldoPConsignar.Multiline = True
        Me.TextBoxSaldoPConsignar.Name = "TextBoxSaldoPConsignar"
        Me.TextBoxSaldoPConsignar.Size = New System.Drawing.Size(231, 30)
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
        Me.ComboBoxSub2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBoxSub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSub2.FormattingEnabled = True
        Me.ComboBoxSub2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ComboBoxSub2.Location = New System.Drawing.Point(462, 23)
        Me.ComboBoxSub2.Name = "ComboBoxSub2"
        Me.ComboBoxSub2.Size = New System.Drawing.Size(157, 23)
        Me.ComboBoxSub2.TabIndex = 15
        Me.ToolTipConsignaciones.SetToolTip(Me.ComboBoxSub2, "Seleccionar SUB")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(459, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SELECCIONAR SUB"
        '
        'GroupBoxBusquedaPorFecha
        '
        Me.GroupBoxBusquedaPorFecha.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.MaskedTextBoxDesdeC)
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.Label3)
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.Label13)
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.MaskedTextBoxHastaC)
        Me.GroupBoxBusquedaPorFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxBusquedaPorFecha.ForeColor = System.Drawing.Color.Red
        Me.GroupBoxBusquedaPorFecha.Location = New System.Drawing.Point(462, 61)
        Me.GroupBoxBusquedaPorFecha.Name = "GroupBoxBusquedaPorFecha"
        Me.GroupBoxBusquedaPorFecha.Size = New System.Drawing.Size(157, 126)
        Me.GroupBoxBusquedaPorFecha.TabIndex = 23
        Me.GroupBoxBusquedaPorFecha.TabStop = False
        Me.GroupBoxBusquedaPorFecha.Text = "Formato: Año/Mes/Dia"
        '
        'MaskedTextBoxDesdeC
        '
        Me.MaskedTextBoxDesdeC.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        Me.MaskedTextBoxDesdeC.Location = New System.Drawing.Point(24, 35)
        Me.MaskedTextBoxDesdeC.Mask = "0000/00/00"
        Me.MaskedTextBoxDesdeC.Name = "MaskedTextBoxDesdeC"
        Me.MaskedTextBoxDesdeC.Size = New System.Drawing.Size(102, 21)
        Me.MaskedTextBoxDesdeC.TabIndex = 5
        Me.MaskedTextBoxDesdeC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MaskedTextBoxDesdeC.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DESDE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "HASTA:"
        '
        'MaskedTextBoxHastaC
        '
        Me.MaskedTextBoxHastaC.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MaskedTextBoxHastaC.Location = New System.Drawing.Point(26, 75)
        Me.MaskedTextBoxHastaC.Mask = "0000/00/00"
        Me.MaskedTextBoxHastaC.Name = "MaskedTextBoxHastaC"
        Me.MaskedTextBoxHastaC.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTextBoxHastaC.TabIndex = 6
        Me.MaskedTextBoxHastaC.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MaskedTextBoxHastaC.ValidatingType = GetType(Date)
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
        Me.PanelIngresarDatos.Location = New System.Drawing.Point(855, 12)
        Me.PanelIngresarDatos.Name = "PanelIngresarDatos"
        Me.PanelIngresarDatos.Size = New System.Drawing.Size(345, 175)
        Me.PanelIngresarDatos.TabIndex = 19
        '
        'LabelRuta
        '
        Me.LabelRuta.AutoEllipsis = True
        Me.LabelRuta.Location = New System.Drawing.Point(147, 138)
        Me.LabelRuta.Name = "LabelRuta"
        Me.LabelRuta.Size = New System.Drawing.Size(179, 19)
        Me.LabelRuta.TabIndex = 24
        '
        'LinkLabelSeleccionar
        '
        Me.LinkLabelSeleccionar.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabelSeleccionar.AutoSize = True
        Me.LinkLabelSeleccionar.DisabledLinkColor = System.Drawing.Color.Blue
        Me.LinkLabelSeleccionar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabelSeleccionar.LinkColor = System.Drawing.Color.Red
        Me.LinkLabelSeleccionar.Location = New System.Drawing.Point(14, 140)
        Me.LinkLabelSeleccionar.Name = "LinkLabelSeleccionar"
        Me.LinkLabelSeleccionar.Size = New System.Drawing.Size(127, 13)
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
        Me.Label9.Size = New System.Drawing.Size(16, 22)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "$"
        '
        'ButtonIngrearDatos
        '
        Me.ButtonIngrearDatos.BackColor = System.Drawing.Color.Teal
        Me.ButtonIngrearDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ButtonIngrearDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIngrearDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIngrearDatos.ForeColor = System.Drawing.Color.White
        Me.ButtonIngrearDatos.Location = New System.Drawing.Point(198, 88)
        Me.ButtonIngrearDatos.Name = "ButtonIngrearDatos"
        Me.ButtonIngrearDatos.Size = New System.Drawing.Size(112, 45)
        Me.ButtonIngrearDatos.TabIndex = 20
        Me.ButtonIngrearDatos.Text = "INGRESAR DATOS"
        Me.ToolTipConsignaciones.SetToolTip(Me.ButtonIngrearDatos, "Ingresar datos")
        Me.ButtonIngrearDatos.UseVisualStyleBackColor = False
        '
        'ComboBoxBanco
        '
        Me.ComboBoxBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBanco.FormattingEnabled = True
        Me.ComboBoxBanco.Location = New System.Drawing.Point(17, 49)
        Me.ComboBoxBanco.Name = "ComboBoxBanco"
        Me.ComboBoxBanco.Size = New System.Drawing.Size(293, 23)
        Me.ComboBoxBanco.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(104, 1)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 20)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "INGRESAR DATOS"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 16)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "INGRESAR VALOR"
        '
        'TextBoxValorAingresar
        '
        Me.TextBoxValorAingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxValorAingresar.Location = New System.Drawing.Point(30, 96)
        Me.TextBoxValorAingresar.MaxLength = 20
        Me.TextBoxValorAingresar.Name = "TextBoxValorAingresar"
        Me.TextBoxValorAingresar.Size = New System.Drawing.Size(150, 22)
        Me.TextBoxValorAingresar.TabIndex = 10
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(14, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(161, 16)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "SELECCCIONAR BANCO"
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonActualizar.FlatAppearance.BorderSize = 0
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.Image = Global.S.P.S.Resources.icons8_actualizar_en_la_nube_50
        Me.ButtonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonActualizar.Location = New System.Drawing.Point(659, 133)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(154, 51)
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
        Me.ButtonExportar.Image = Global.S.P.S.Resources.icons8_microsoft_excel_2019_50
        Me.ButtonExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonExportar.Location = New System.Drawing.Point(659, 73)
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(154, 49)
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
        Me.ButtonBuscar.Image = Global.S.P.S.Resources.búsqueda50px
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBuscar.Location = New System.Drawing.Point(659, 13)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(154, 50)
        Me.ButtonBuscar.TabIndex = 22
        Me.ButtonBuscar.Text = "BUSCAR"
        Me.ButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBoxParaGuardar
        '
        Me.PictureBoxParaGuardar.Location = New System.Drawing.Point(730, 8)
        Me.PictureBoxParaGuardar.Name = "PictureBoxParaGuardar"
        Me.PictureBoxParaGuardar.Size = New System.Drawing.Size(463, 671)
        Me.PictureBoxParaGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxParaGuardar.TabIndex = 22
        Me.PictureBoxParaGuardar.TabStop = False
        Me.PictureBoxParaGuardar.Visible = False
        '
        'Consignaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 686)
        Me.Controls.Add(Me.PictureBoxParaGuardar)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonExportar)
        Me.Controls.Add(Me.PanelIngresarDatos)
        Me.Controls.Add(Me.GroupBoxBusquedaPorFecha)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxSub2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewConsignaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Consignaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                                                                       GESTIONAR" &
    " CONSIGNACIONES"
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
    Friend WithEvents MaskedTextBoxDesdeC As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents MaskedTextBoxHastaC As MaskedTextBox
    Friend WithEvents ButtonBuscar As Button
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
    Friend WithEvents LinkLabelSeleccionar As LinkLabel
    Friend WithEvents LabelRuta As Label
    Friend WithEvents Column3 As DataGridViewLinkColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewComboBoxColumn
    Friend WithEvents PictureBoxParaGuardar As PictureBox
End Class
