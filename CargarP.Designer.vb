<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargar_pago
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cargar_pago))
        Me.DataGridViewPagos = New System.Windows.Forms.DataGridView()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ButtonSubirP = New System.Windows.Forms.Button()
        Me.ButtonIngresarR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelIdSub = New System.Windows.Forms.Label()
        Me.LabelNombreP = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelCedulaP = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LABLE = New System.Windows.Forms.Label()
        Me.LabelCupoNeto = New System.Windows.Forms.Label()
        Me.LabelValorTotal = New System.Windows.Forms.Label()
        Me.LabelCupoRestante = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewPagos
        '
        Me.DataGridViewPagos.AllowUserToAddRows = False
        Me.DataGridViewPagos.AllowUserToResizeColumns = False
        Me.DataGridViewPagos.AllowUserToResizeRows = False
        Me.DataGridViewPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewPagos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column10, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column11})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPagos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewPagos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridViewPagos.Location = New System.Drawing.Point(0, 118)
        Me.DataGridViewPagos.Name = "DataGridViewPagos"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPagos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewPagos.RowHeadersVisible = False
        Me.DataGridViewPagos.Size = New System.Drawing.Size(1205, 568)
        Me.DataGridViewPagos.TabIndex = 1
        '
        'Column10
        '
        Me.Column10.HeaderText = "ID"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 43
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.FillWeight = 105.0!
        Me.Column1.HeaderText = "ID REGISTRO"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 130
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = "N° DOC"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column3.HeaderText = "FECHA"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.HeaderText = "VENDEDOR"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 198
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column5.HeaderText = "NO° MIN"
        Me.Column5.MaxInputLength = 10
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 130
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column6.HeaderText = "REFERENCIA"
        Me.Column6.MaxInputLength = 10
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column7.HeaderText = "TIPO"
        Me.Column7.Items.AddRange(New Object() {"SERVICIO", "EQUIPO", "CLARO FIJO", "REPOSICION"})
        Me.Column7.Name = "Column7"
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Width = 105
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.HeaderText = "VALOR"
        Me.Column8.MaxInputLength = 8
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column9.HeaderText = "ESTADO ACTUAL"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column11
        '
        Me.Column11.HeaderText = ""
        Me.Column11.Image = Global.Legar.Resources.delete_4_90871
        Me.Column11.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column11.Name = "Column11"
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.Width = 5
        '
        'ButtonSubirP
        '
        Me.ButtonSubirP.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonSubirP.Location = New System.Drawing.Point(1050, 12)
        Me.ButtonSubirP.Name = "ButtonSubirP"
        Me.ButtonSubirP.Size = New System.Drawing.Size(150, 100)
        Me.ButtonSubirP.TabIndex = 2
        Me.ButtonSubirP.Text = "GUARDAR PAGOS"
        Me.ButtonSubirP.UseVisualStyleBackColor = False
        '
        'ButtonIngresarR
        '
        Me.ButtonIngresarR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButtonIngresarR.Location = New System.Drawing.Point(896, 12)
        Me.ButtonIngresarR.Name = "ButtonIngresarR"
        Me.ButtonIngresarR.Size = New System.Drawing.Size(148, 100)
        Me.ButtonIngresarR.TabIndex = 3
        Me.ButtonIngresarR.Text = "INGRESAR REGISTRO"
        Me.ButtonIngresarR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID. SUBDISTRIBUIDOR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NOMBRE:"
        '
        'LabelIdSub
        '
        Me.LabelIdSub.AutoSize = True
        Me.LabelIdSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdSub.Location = New System.Drawing.Point(140, 35)
        Me.LabelIdSub.Name = "LabelIdSub"
        Me.LabelIdSub.Size = New System.Drawing.Size(21, 16)
        Me.LabelIdSub.TabIndex = 6
        Me.LabelIdSub.Text = "ID"
        '
        'LabelNombreP
        '
        Me.LabelNombreP.AutoSize = True
        Me.LabelNombreP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreP.Location = New System.Drawing.Point(140, 61)
        Me.LabelNombreP.Name = "LabelNombreP"
        Me.LabelNombreP.Size = New System.Drawing.Size(67, 16)
        Me.LabelNombreP.TabIndex = 7
        Me.LabelNombreP.Text = "NOMBRE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "CEDULA:"
        '
        'LabelCedulaP
        '
        Me.LabelCedulaP.AutoSize = True
        Me.LabelCedulaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCedulaP.Location = New System.Drawing.Point(140, 85)
        Me.LabelCedulaP.Name = "LabelCedulaP"
        Me.LabelCedulaP.Size = New System.Drawing.Size(62, 16)
        Me.LabelCedulaP.TabIndex = 10
        Me.LabelCedulaP.Text = "CEDULA"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Legar.Resources.delete_4_90871
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.LABLE)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LabelNombreP)
        Me.Panel1.Controls.Add(Me.LabelCedulaP)
        Me.Panel1.Controls.Add(Me.LabelIdSub)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(7, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 110)
        Me.Panel1.TabIndex = 11
        '
        'LABLE
        '
        Me.LABLE.AutoSize = True
        Me.LABLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABLE.Location = New System.Drawing.Point(8, 8)
        Me.LABLE.Name = "LABLE"
        Me.LABLE.Size = New System.Drawing.Size(157, 16)
        Me.LABLE.TabIndex = 11
        Me.LABLE.Text = "DATOS DE USUARIO"
        '
        'LabelCupoNeto
        '
        Me.LabelCupoNeto.AutoSize = True
        Me.LabelCupoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCupoNeto.ForeColor = System.Drawing.Color.Green
        Me.LabelCupoNeto.Location = New System.Drawing.Point(667, 11)
        Me.LabelCupoNeto.Name = "LabelCupoNeto"
        Me.LabelCupoNeto.Size = New System.Drawing.Size(21, 24)
        Me.LabelCupoNeto.TabIndex = 12
        Me.LabelCupoNeto.Text = "0"
        '
        'LabelValorTotal
        '
        Me.LabelValorTotal.AutoSize = True
        Me.LabelValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValorTotal.ForeColor = System.Drawing.Color.Gold
        Me.LabelValorTotal.Location = New System.Drawing.Point(667, 63)
        Me.LabelValorTotal.Name = "LabelValorTotal"
        Me.LabelValorTotal.Size = New System.Drawing.Size(21, 24)
        Me.LabelValorTotal.TabIndex = 13
        Me.LabelValorTotal.Text = "0"
        '
        'LabelCupoRestante
        '
        Me.LabelCupoRestante.AutoSize = True
        Me.LabelCupoRestante.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LabelCupoRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCupoRestante.ForeColor = System.Drawing.Color.Red
        Me.LabelCupoRestante.Location = New System.Drawing.Point(667, 36)
        Me.LabelCupoRestante.Name = "LabelCupoRestante"
        Me.LabelCupoRestante.Size = New System.Drawing.Size(21, 24)
        Me.LabelCupoRestante.TabIndex = 14
        Me.LabelCupoRestante.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(460, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "CUPO RESTANTE ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(491, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "VALOR TOTAL ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(576, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "CUPO ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(566, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "CUPO EXCEDIDO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Cargar_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 686)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelCupoRestante)
        Me.Controls.Add(Me.LabelValorTotal)
        Me.Controls.Add(Me.LabelCupoNeto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonIngresarR)
        Me.Controls.Add(Me.ButtonSubirP)
        Me.Controls.Add(Me.DataGridViewPagos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cargar_pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        CType(Me.DataGridViewPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewPagos As DataGridView
    Friend WithEvents ButtonSubirP As Button
    Friend WithEvents ButtonIngresarR As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelIdSub As Label
    Friend WithEvents LabelNombreP As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelCedulaP As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewComboBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LABLE As Label
    Friend WithEvents LabelCupoNeto As Label
    Friend WithEvents LabelValorTotal As Label
    Friend WithEvents LabelCupoRestante As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
