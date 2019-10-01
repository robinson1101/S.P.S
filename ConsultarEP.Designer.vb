<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultarEP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultarEP))
        Me.TextBoxNumReferencia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxDesde = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxHasta = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridViewConsultar = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ToolTipConsultar = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ButtonExportar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxSub = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.DataGridViewConsultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxNumReferencia
        '
        Me.TextBoxNumReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNumReferencia.Location = New System.Drawing.Point(12, 41)
        Me.TextBoxNumReferencia.MaxLength = 10
        Me.TextBoxNumReferencia.Name = "TextBoxNumReferencia"
        Me.TextBoxNumReferencia.Size = New System.Drawing.Size(187, 22)
        Me.TextBoxNumReferencia.TabIndex = 1
        Me.TextBoxNumReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'MaskedTextBoxDesde
        '
        Me.MaskedTextBoxDesde.Location = New System.Drawing.Point(24, 35)
        Me.MaskedTextBoxDesde.Mask = "0000/00/00"
        Me.MaskedTextBoxDesde.Name = "MaskedTextBoxDesde"
        Me.MaskedTextBoxDesde.Size = New System.Drawing.Size(84, 20)
        Me.MaskedTextBoxDesde.TabIndex = 5
        Me.MaskedTextBoxDesde.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.ToolTipConsultar.SetToolTip(Me.MaskedTextBoxDesde, "Fecha inicial")
        Me.MaskedTextBoxDesde.ValidatingType = GetType(Date)
        '
        'MaskedTextBoxHasta
        '
        Me.MaskedTextBoxHasta.Location = New System.Drawing.Point(26, 75)
        Me.MaskedTextBoxHasta.Mask = "0000/00/00"
        Me.MaskedTextBoxHasta.Name = "MaskedTextBoxHasta"
        Me.MaskedTextBoxHasta.Size = New System.Drawing.Size(83, 20)
        Me.MaskedTextBoxHasta.TabIndex = 6
        Me.MaskedTextBoxHasta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.ToolTipConsultar.SetToolTip(Me.MaskedTextBoxHasta, "Fecha final")
        Me.MaskedTextBoxHasta.ValidatingType = GetType(Date)
        '
        'DataGridViewConsultar
        '
        Me.DataGridViewConsultar.AllowUserToAddRows = False
        Me.DataGridViewConsultar.AllowUserToDeleteRows = False
        Me.DataGridViewConsultar.AllowUserToResizeColumns = False
        Me.DataGridViewConsultar.AllowUserToResizeRows = False
        Me.DataGridViewConsultar.BackgroundColor = System.Drawing.Color.White
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
        Me.Column1.Image = Global.S.P.S.Resources.Actualizar50
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
        Me.Column2.Width = 116
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonActualizar.Image = Global.S.P.S.Resources.icons8_actualizar_en_la_nube_50
        Me.ButtonActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonActualizar.Location = New System.Drawing.Point(1056, 25)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(137, 97)
        Me.ButtonActualizar.TabIndex = 10
        Me.ButtonActualizar.Text = "REFRESCAR"
        Me.ButtonActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipConsultar.SetToolTip(Me.ButtonActualizar, "Refrescar datos")
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBuscar.Image = Global.S.P.S.Resources.búsqueda50px
        Me.ButtonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBuscar.Location = New System.Drawing.Point(356, 26)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(127, 96)
        Me.ButtonBuscar.TabIndex = 9
        Me.ButtonBuscar.Text = "BUSCAR"
        Me.ButtonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipConsultar.SetToolTip(Me.ButtonBuscar, "Buscar")
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'ButtonExportar
        '
        Me.ButtonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExportar.Image = Global.S.P.S.Resources.icons8_microsoft_excel_2019_50
        Me.ButtonExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonExportar.Location = New System.Drawing.Point(902, 25)
        Me.ButtonExportar.Name = "ButtonExportar"
        Me.ButtonExportar.Size = New System.Drawing.Size(127, 97)
        Me.ButtonExportar.TabIndex = 13
        Me.ButtonExportar.Text = "EXPORTAR"
        Me.ButtonExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTipConsultar.SetToolTip(Me.ButtonExportar, "Exportar")
        Me.ButtonExportar.UseVisualStyleBackColor = False
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
        Me.ComboBoxSub.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBoxSub.FormattingEnabled = True
        Me.ComboBoxSub.Location = New System.Drawing.Point(12, 82)
        Me.ComboBoxSub.Name = "ComboBoxSub"
        Me.ComboBoxSub.Size = New System.Drawing.Size(187, 21)
        Me.ComboBoxSub.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxDesde)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxHasta)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(218, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 100)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formato: Año/Mes/Dia"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.S.P.S.Resources.Actualizar50
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ToolTipText = "Actualizar estado"
        '
        'ConsultarEP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 686)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonExportar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBoxSub)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.DataGridViewConsultar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNumReferencia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultarEP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                                                                                " &
    "     BUSQUEDA DE PAGOS"
        CType(Me.DataGridViewConsultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxNumReferencia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextBoxDesde As MaskedTextBox
    Friend WithEvents MaskedTextBoxHasta As MaskedTextBox
    Friend WithEvents DataGridViewConsultar As DataGridView
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ToolTipConsultar As ToolTip
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxSub As ComboBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ButtonExportar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewComboBoxColumn
End Class
