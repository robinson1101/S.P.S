<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonIngresar = New System.Windows.Forms.RadioButton()
        Me.RadioButtonModificar = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEliminar = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTipoU = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxCupo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolTipUsuarios = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelIdUsuario = New System.Windows.Forms.Label()
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewUsuarios
        '
        Me.DataGridViewUsuarios.AllowUserToAddRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewUsuarios.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewUsuarios.Location = New System.Drawing.Point(3, 50)
        Me.DataGridViewUsuarios.Name = "DataGridViewUsuarios"
        Me.DataGridViewUsuarios.RowHeadersVisible = False
        Me.DataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewUsuarios.Size = New System.Drawing.Size(1200, 332)
        Me.DataGridViewUsuarios.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(442, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADMINISTRAR USUARIOS"
        '
        'RadioButtonIngresar
        '
        Me.RadioButtonIngresar.AutoSize = True
        Me.RadioButtonIngresar.Checked = True
        Me.RadioButtonIngresar.Location = New System.Drawing.Point(479, 423)
        Me.RadioButtonIngresar.Name = "RadioButtonIngresar"
        Me.RadioButtonIngresar.Size = New System.Drawing.Size(81, 17)
        Me.RadioButtonIngresar.TabIndex = 2
        Me.RadioButtonIngresar.TabStop = True
        Me.RadioButtonIngresar.Text = "INGRESAR"
        Me.ToolTipUsuarios.SetToolTip(Me.RadioButtonIngresar, "Ingresar nuevo usuario")
        Me.RadioButtonIngresar.UseVisualStyleBackColor = True
        '
        'RadioButtonModificar
        '
        Me.RadioButtonModificar.AutoSize = True
        Me.RadioButtonModificar.Location = New System.Drawing.Point(587, 423)
        Me.RadioButtonModificar.Name = "RadioButtonModificar"
        Me.RadioButtonModificar.Size = New System.Drawing.Size(84, 17)
        Me.RadioButtonModificar.TabIndex = 3
        Me.RadioButtonModificar.TabStop = True
        Me.RadioButtonModificar.Text = "MODIFICAR"
        Me.ToolTipUsuarios.SetToolTip(Me.RadioButtonModificar, "Modificar usuario")
        Me.RadioButtonModificar.UseVisualStyleBackColor = True
        '
        'RadioButtonEliminar
        '
        Me.RadioButtonEliminar.AutoSize = True
        Me.RadioButtonEliminar.Location = New System.Drawing.Point(683, 423)
        Me.RadioButtonEliminar.Name = "RadioButtonEliminar"
        Me.RadioButtonEliminar.Size = New System.Drawing.Size(76, 17)
        Me.RadioButtonEliminar.TabIndex = 4
        Me.RadioButtonEliminar.TabStop = True
        Me.RadioButtonEliminar.Text = "ELIMINAR"
        Me.ToolTipUsuarios.SetToolTip(Me.RadioButtonEliminar, "Eliminar usuario")
        Me.RadioButtonEliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 494)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NOMBRE(s)"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(3, 510)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(155, 20)
        Me.TextBoxNombre.TabIndex = 6
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(164, 510)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(163, 20)
        Me.TextBoxApellido.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 494)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "APELLIDO(s)"
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Location = New System.Drawing.Point(334, 510)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxCedula.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 494)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "CEDULA"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(484, 510)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(147, 20)
        Me.TextBoxTelefono.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(481, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "TELEFONO"
        '
        'TextBoxTipoU
        '
        Me.TextBoxTipoU.Location = New System.Drawing.Point(637, 510)
        Me.TextBoxTipoU.Name = "TextBoxTipoU"
        Me.TextBoxTipoU.Size = New System.Drawing.Size(161, 20)
        Me.TextBoxTipoU.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(634, 494)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "TIPO DE USUARIO"
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Location = New System.Drawing.Point(804, 510)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(137, 20)
        Me.TextBoxUsuario.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(801, 494)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "USUARIO"
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Location = New System.Drawing.Point(948, 510)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxContraseña.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(946, 494)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "CONTRASEÑA"
        '
        'TextBoxCupo
        '
        Me.TextBoxCupo.Location = New System.Drawing.Point(1090, 510)
        Me.TextBoxCupo.Name = "TextBoxCupo"
        Me.TextBoxCupo.Size = New System.Drawing.Size(113, 20)
        Me.TextBoxCupo.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1087, 494)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "CUPO"
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.BackColor = System.Drawing.Color.White
        Me.ButtonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIngresar.Location = New System.Drawing.Point(228, 596)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(163, 48)
        Me.ButtonIngresar.TabIndex = 21
        Me.ButtonIngresar.Text = "INGRESAR"
        Me.ToolTipUsuarios.SetToolTip(Me.ButtonIngresar, "Ingresar nuevo usuario")
        Me.ButtonIngresar.UseVisualStyleBackColor = False
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.White
        Me.ButtonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificar.Location = New System.Drawing.Point(508, 596)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(163, 48)
        Me.ButtonModificar.TabIndex = 22
        Me.ButtonModificar.Text = "MODIFICAR"
        Me.ToolTipUsuarios.SetToolTip(Me.ButtonModificar, "Modificar datos")
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.White
        Me.ButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEliminar.Location = New System.Drawing.Point(769, 596)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(163, 48)
        Me.ButtonEliminar.TabIndex = 23
        Me.ButtonEliminar.Text = "ELIMINAR"
        Me.ToolTipUsuarios.SetToolTip(Me.ButtonEliminar, "Eliminar datos")
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(320, 423)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 16)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Movimientos a realizar..."
        '
        'LabelIdUsuario
        '
        Me.LabelIdUsuario.AutoSize = True
        Me.LabelIdUsuario.Location = New System.Drawing.Point(0, 399)
        Me.LabelIdUsuario.Name = "LabelIdUsuario"
        Me.LabelIdUsuario.Size = New System.Drawing.Size(51, 13)
        Me.LabelIdUsuario.TabIndex = 25
        Me.LabelIdUsuario.Text = "idUsuario"
        Me.LabelIdUsuario.Visible = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 678)
        Me.Controls.Add(Me.LabelIdUsuario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.TextBoxCupo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxTipoU)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButtonEliminar)
        Me.Controls.Add(Me.RadioButtonModificar)
        Me.Controls.Add(Me.RadioButtonIngresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.DataGridViewUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewUsuarios As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonIngresar As RadioButton
    Friend WithEvents RadioButtonModificar As RadioButton
    Friend WithEvents RadioButtonEliminar As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxTipoU As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxCupo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ToolTipUsuarios As ToolTip
    Friend WithEvents LabelIdUsuario As Label
End Class
