﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewConsignaciones = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxCupoDisponible = New System.Windows.Forms.TextBox()
        Me.TextBoxSaldoInicial = New System.Windows.Forms.TextBox()
        Me.TextBoxCupo = New System.Windows.Forms.TextBox()
        Me.TextBoxSaldoPConsignar = New System.Windows.Forms.TextBox()
        Me.ComboBoxSub2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonExportar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.GroupBoxBusquedaPorFecha = New System.Windows.Forms.GroupBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxNumReferencia = New System.Windows.Forms.TextBox()
        Me.PanelIngresarDatos = New System.Windows.Forms.Panel()
        Me.PictureBoxIngresar = New System.Windows.Forms.PictureBox()
        Me.ComboBoxBanco = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxValorAingresar = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ToolTipConsignaciones = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButtonCargarD = New System.Windows.Forms.RadioButton()
        Me.RadioButtonIngresarD = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewConsignaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxBusquedaPorFecha.SuspendLayout()
        Me.PanelIngresarDatos.SuspendLayout()
        CType(Me.PictureBoxIngresar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridViewConsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewConsignaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewConsignaciones.Location = New System.Drawing.Point(0, 196)
        Me.DataGridViewConsignaciones.Name = "DataGridViewConsignaciones"
        Me.DataGridViewConsignaciones.Size = New System.Drawing.Size(1205, 486)
        Me.DataGridViewConsignaciones.TabIndex = 1
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
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
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
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(142, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 21)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "$"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(141, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 17)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "$"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(141, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 21)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "$"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(141, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "$"
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
        'ComboBoxSub2
        '
        Me.ComboBoxSub2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ComboBoxSub2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSub2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxSub2.FormattingEnabled = True
        Me.ComboBoxSub2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ComboBoxSub2.Location = New System.Drawing.Point(336, 50)
        Me.ComboBoxSub2.Name = "ComboBoxSub2"
        Me.ComboBoxSub2.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxSub2.TabIndex = 15
        Me.ToolTipConsignaciones.SetToolTip(Me.ComboBoxSub2, "Seleccionar SUB")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(333, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SELECCIONAR SUB"
        '
        'ButtonExportar
        '
        Me.ButtonExportar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonExportar.FlatAppearance.BorderSize = 0
        Me.ButtonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportar.Image = Global.Legar.Resources.icons8_microsoft_excel_2019_50
        Me.ButtonExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonExportar.Location = New System.Drawing.Point(502, 147)
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(154, 44)
        Me.ButtonExportar.TabIndex = 13
        Me.ButtonExportar.Text = "EXPORTAR"
        Me.ButtonExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExportar.UseVisualStyleBackColor = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonActualizar.FlatAppearance.BorderSize = 0
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.Image = Global.Legar.Resources.icons8_actualizar_en_la_nube_50
        Me.ButtonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonActualizar.Location = New System.Drawing.Point(678, 147)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(157, 44)
        Me.ButtonActualizar.TabIndex = 10
        Me.ButtonActualizar.Text = "REFRESCAR"
        Me.ButtonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'GroupBoxBusquedaPorFecha
        '
        Me.GroupBoxBusquedaPorFecha.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.Label3)
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.Label13)
        Me.GroupBoxBusquedaPorFecha.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBoxBusquedaPorFecha.ForeColor = System.Drawing.Color.Red
        Me.GroupBoxBusquedaPorFecha.Location = New System.Drawing.Point(336, 79)
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
        Me.Label14.Location = New System.Drawing.Point(501, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "N° DE REFERENCIA"
        '
        'TextBoxNumReferencia
        '
        Me.TextBoxNumReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumReferencia.Location = New System.Drawing.Point(502, 51)
        Me.TextBoxNumReferencia.MaxLength = 10
        Me.TextBoxNumReferencia.Name = "TextBoxNumReferencia"
        Me.TextBoxNumReferencia.Size = New System.Drawing.Size(154, 22)
        Me.TextBoxNumReferencia.TabIndex = 20
        Me.TextBoxNumReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelIngresarDatos
        '
        Me.PanelIngresarDatos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelIngresarDatos.Controls.Add(Me.PictureBoxIngresar)
        Me.PanelIngresarDatos.Controls.Add(Me.ComboBoxBanco)
        Me.PanelIngresarDatos.Controls.Add(Me.Label17)
        Me.PanelIngresarDatos.Controls.Add(Me.Label19)
        Me.PanelIngresarDatos.Controls.Add(Me.Label20)
        Me.PanelIngresarDatos.Controls.Add(Me.TextBoxValorAingresar)
        Me.PanelIngresarDatos.Controls.Add(Me.Label23)
        Me.PanelIngresarDatos.Location = New System.Drawing.Point(859, 37)
        Me.PanelIngresarDatos.Name = "PanelIngresarDatos"
        Me.PanelIngresarDatos.Size = New System.Drawing.Size(327, 153)
        Me.PanelIngresarDatos.TabIndex = 19
        '
        'PictureBoxIngresar
        '
        Me.PictureBoxIngresar.BackColor = System.Drawing.Color.White
        Me.PictureBoxIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxIngresar.Image = Global.Legar.Resources.icons8_agregar_propiedad_50
        Me.PictureBoxIngresar.Location = New System.Drawing.Point(268, 96)
        Me.PictureBoxIngresar.Name = "PictureBoxIngresar"
        Me.PictureBoxIngresar.Size = New System.Drawing.Size(47, 39)
        Me.PictureBoxIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxIngresar.TabIndex = 20
        Me.PictureBoxIngresar.TabStop = False
        Me.ToolTipConsignaciones.SetToolTip(Me.PictureBoxIngresar, "Ingresar registro")
        '
        'ComboBoxBanco
        '
        Me.ComboBoxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxBanco.FormattingEnabled = True
        Me.ComboBoxBanco.Location = New System.Drawing.Point(22, 60)
        Me.ComboBoxBanco.Name = "ComboBoxBanco"
        Me.ComboBoxBanco.Size = New System.Drawing.Size(293, 21)
        Me.ComboBoxBanco.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(23, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "$"
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
        Me.Label20.Location = New System.Drawing.Point(19, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "INGRESAR VALOR"
        '
        'TextBoxValorAingresar
        '
        Me.TextBoxValorAingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxValorAingresar.Location = New System.Drawing.Point(36, 112)
        Me.TextBoxValorAingresar.MaxLength = 20
        Me.TextBoxValorAingresar.Name = "TextBoxValorAingresar"
        Me.TextBoxValorAingresar.Size = New System.Drawing.Size(163, 21)
        Me.TextBoxValorAingresar.TabIndex = 10
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(19, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(129, 13)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "SELECCCIONAR BANCO"
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonBuscar.FlatAppearance.BorderSize = 0
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscar.Image = Global.Legar.Resources.búsqueda50px
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBuscar.Location = New System.Drawing.Point(502, 87)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(154, 39)
        Me.ButtonBuscar.TabIndex = 22
        Me.ButtonBuscar.Text = "BUSCAR"
        Me.ButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'RadioButtonCargarD
        '
        Me.RadioButtonCargarD.AutoSize = True
        Me.RadioButtonCargarD.Location = New System.Drawing.Point(692, 63)
        Me.RadioButtonCargarD.Name = "RadioButtonCargarD"
        Me.RadioButtonCargarD.Size = New System.Drawing.Size(119, 17)
        Me.RadioButtonCargarD.TabIndex = 24
        Me.RadioButtonCargarD.TabStop = True
        Me.RadioButtonCargarD.Text = "MOSTRAR DATOS"
        Me.RadioButtonCargarD.UseVisualStyleBackColor = True
        '
        'RadioButtonIngresarD
        '
        Me.RadioButtonIngresarD.AutoSize = True
        Me.RadioButtonIngresarD.Location = New System.Drawing.Point(692, 90)
        Me.RadioButtonIngresarD.Name = "RadioButtonIngresarD"
        Me.RadioButtonIngresarD.Size = New System.Drawing.Size(121, 17)
        Me.RadioButtonIngresarD.TabIndex = 25
        Me.RadioButtonIngresarD.TabStop = True
        Me.RadioButtonIngresarD.Text = "INGRESAR DATOS"
        Me.RadioButtonIngresarD.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(710, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 15)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "MOVIMIENTO"
        '
        'Consignaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 682)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.RadioButtonIngresarD)
        Me.Controls.Add(Me.RadioButtonCargarD)
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
        CType(Me.PictureBoxIngresar, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxCupoDisponible As TextBox
    Friend WithEvents TextBoxSaldoInicial As TextBox
    Friend WithEvents TextBoxCupo As TextBox
    Friend WithEvents TextBoxSaldoPConsignar As TextBox
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
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxValorAingresar As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents ToolTipConsignaciones As ToolTip
    Friend WithEvents PictureBoxIngresar As PictureBox
    Friend WithEvents RadioButtonCargarD As RadioButton
    Friend WithEvents RadioButtonIngresarD As RadioButton
    Protected WithEvents ComboBoxBanco As ComboBox
    Friend WithEvents Label15 As Label
End Class
