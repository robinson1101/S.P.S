﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarEP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNumReferencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridViewConsultar = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ToolTipConsultar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxSub = New System.Windows.Forms.ComboBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ButtonExportar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridViewConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(498, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BUSQUEDA DE PAGOS"
        '
        'TextBoxNumReferencia
        '
        Me.TextBoxNumReferencia.Location = New System.Drawing.Point(12, 41)
        Me.TextBoxNumReferencia.Name = "TextBoxNumReferencia"
        Me.TextBoxNumReferencia.Size = New System.Drawing.Size(187, 20)
        Me.TextBoxNumReferencia.TabIndex = 1
        Me.ToolTipConsultar.SetToolTip(Me.TextBoxNumReferencia, "Busqueda por: No.Cedula, Usuario, Min y Referencia")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° DE REFERENCIA"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "HASTA:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(24, 35)
        Me.MaskedTextBox1.Mask = "0000/00/00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(84, 20)
        Me.MaskedTextBox1.TabIndex = 5
        Me.ToolTipConsultar.SetToolTip(Me.MaskedTextBox1, "Fecha inicial")
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(26, 75)
        Me.MaskedTextBox2.Mask = "0000/00/00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(83, 20)
        Me.MaskedTextBox2.TabIndex = 6
        Me.ToolTipConsultar.SetToolTip(Me.MaskedTextBox2, "Fecha final")
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'DataGridViewConsultar
        '
        Me.DataGridViewConsultar.AllowUserToAddRows = False
        Me.DataGridViewConsultar.AllowUserToResizeColumns = False
        Me.DataGridViewConsultar.AllowUserToResizeRows = False
        Me.DataGridViewConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewConsultar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewConsultar.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewConsultar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewConsultar.Location = New System.Drawing.Point(0, 135)
        Me.DataGridViewConsultar.Name = "DataGridViewConsultar"
        Me.DataGridViewConsultar.RowHeadersVisible = False
        Me.DataGridViewConsultar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewConsultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewConsultar.Size = New System.Drawing.Size(1205, 551)
        Me.DataGridViewConsultar.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Image = Global.Legar.Resources.Actualizar50
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column1.Name = "Column1"
        Me.Column1.ToolTipText = "Actualizar estado"
        '
        'Column2
        '
        Me.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column2.HeaderText = "CAMBIAR A:"
        Me.Column2.Items.AddRange(New Object() {"PAGO", "NO PAGO", "R. ANULADO"})
        Me.Column2.Name = "Column2"
        Me.Column2.ToolTipText = "Seleccionar"
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonActualizar.FlatAppearance.BorderSize = 0
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.Image = Global.Legar.Resources.icons8_actualizar_en_la_nube_50
        Me.ButtonActualizar.Location = New System.Drawing.Point(152, 0)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(48, 44)
        Me.ButtonActualizar.TabIndex = 10
        Me.ToolTipConsultar.SetToolTip(Me.ButtonActualizar, "Refrescar datos")
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.FlatAppearance.BorderSize = 0
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscar.Image = Global.Legar.Resources.búsqueda50px
        Me.ButtonBuscar.Location = New System.Drawing.Point(370, 43)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(46, 46)
        Me.ButtonBuscar.TabIndex = 9
        Me.ToolTipConsultar.SetToolTip(Me.ButtonBuscar, "Buscar")
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "SUB"
        '
        'ComboBoxSub
        '
        Me.ComboBoxSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxSub.FormattingEnabled = True
        Me.ComboBoxSub.Location = New System.Drawing.Point(12, 82)
        Me.ComboBoxSub.Name = "ComboBoxSub"
        Me.ComboBoxSub.Size = New System.Drawing.Size(187, 21)
        Me.ComboBoxSub.TabIndex = 12
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Legar.Resources.Actualizar50
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ToolTipText = "Actualizar estado"
        '
        'ButtonExportar
        '
        Me.ButtonExportar.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonExportar.FlatAppearance.BorderSize = 0
        Me.ButtonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportar.Image = Global.Legar.Resources.icons8_microsoft_excel_2019_50
        Me.ButtonExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonExportar.Location = New System.Drawing.Point(0, 0)
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(52, 44)
        Me.ButtonExportar.TabIndex = 13
        Me.ButtonExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExportar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(365, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "BUSCAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(907, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "EXPORTAR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(845, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ACTUALIZAR"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(218, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 100)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formato: Año/Mes/Dia"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.ButtonExportar)
        Me.Panel1.Controls.Add(Me.ButtonActualizar)
        Me.Panel1.Location = New System.Drawing.Point(993, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 44)
        Me.Panel1.TabIndex = 19
        '
        'ConsultarEP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 686)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxSub)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.DataGridViewConsultar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNumReferencia)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ConsultarEP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar"
        CType(Me.DataGridViewConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNumReferencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents DataGridViewConsultar As DataGridView
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ToolTipConsultar As ToolTip
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxSub As ComboBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewComboBoxColumn
    Friend WithEvents ButtonExportar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class