<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelTipoU = New System.Windows.Forms.Label()
        Me.ButtonCargarP = New System.Windows.Forms.Button()
        Me.ButtonConsultarEstP = New System.Windows.Forms.Button()
        Me.ButtonGestionarConsig = New System.Windows.Forms.Button()
        Me.LabelUsuarioU = New System.Windows.Forms.Label()
        Me.Usuar = New System.Windows.Forms.Label()
        Me.LinkLabelUsuarios = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido(a)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sr(a):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo usuario:"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(112, 52)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(63, 20)
        Me.LabelNombre.TabIndex = 3
        Me.LabelNombre.Text = "nombre"
        '
        'LabelTipoU
        '
        Me.LabelTipoU.AutoSize = True
        Me.LabelTipoU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipoU.Location = New System.Drawing.Point(112, 101)
        Me.LabelTipoU.Name = "LabelTipoU"
        Me.LabelTipoU.Size = New System.Drawing.Size(61, 20)
        Me.LabelTipoU.TabIndex = 4
        Me.LabelTipoU.Text = "usuario"
        '
        'ButtonCargarP
        '
        Me.ButtonCargarP.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonCargarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCargarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCargarP.ForeColor = System.Drawing.Color.White
        Me.ButtonCargarP.Location = New System.Drawing.Point(0, 133)
        Me.ButtonCargarP.Name = "ButtonCargarP"
        Me.ButtonCargarP.Size = New System.Drawing.Size(412, 41)
        Me.ButtonCargarP.TabIndex = 5
        Me.ButtonCargarP.Text = "GESTIONAR PAGOS"
        Me.ButtonCargarP.UseVisualStyleBackColor = False
        '
        'ButtonConsultarEstP
        '
        Me.ButtonConsultarEstP.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonConsultarEstP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonConsultarEstP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultarEstP.ForeColor = System.Drawing.Color.White
        Me.ButtonConsultarEstP.Location = New System.Drawing.Point(0, 180)
        Me.ButtonConsultarEstP.Name = "ButtonConsultarEstP"
        Me.ButtonConsultarEstP.Size = New System.Drawing.Size(412, 40)
        Me.ButtonConsultarEstP.TabIndex = 6
        Me.ButtonConsultarEstP.Text = "CONSULTAR ESTADOS PAGOS"
        Me.ButtonConsultarEstP.UseVisualStyleBackColor = False
        '
        'ButtonGestionarConsig
        '
        Me.ButtonGestionarConsig.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtonGestionarConsig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGestionarConsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGestionarConsig.ForeColor = System.Drawing.Color.White
        Me.ButtonGestionarConsig.Location = New System.Drawing.Point(0, 227)
        Me.ButtonGestionarConsig.Name = "ButtonGestionarConsig"
        Me.ButtonGestionarConsig.Size = New System.Drawing.Size(412, 40)
        Me.ButtonGestionarConsig.TabIndex = 7
        Me.ButtonGestionarConsig.Text = "GESTIONAR CONSIGNACIONES"
        Me.ButtonGestionarConsig.UseVisualStyleBackColor = False
        '
        'LabelUsuarioU
        '
        Me.LabelUsuarioU.AutoSize = True
        Me.LabelUsuarioU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarioU.Location = New System.Drawing.Point(112, 77)
        Me.LabelUsuarioU.Name = "LabelUsuarioU"
        Me.LabelUsuarioU.Size = New System.Drawing.Size(70, 20)
        Me.LabelUsuarioU.TabIndex = 9
        Me.LabelUsuarioU.Text = "usuariou"
        '
        'Usuar
        '
        Me.Usuar.AutoSize = True
        Me.Usuar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuar.Location = New System.Drawing.Point(13, 77)
        Me.Usuar.Name = "Usuar"
        Me.Usuar.Size = New System.Drawing.Size(68, 20)
        Me.Usuar.TabIndex = 8
        Me.Usuar.Text = "Usuario:"
        '
        'LinkLabelUsuarios
        '
        Me.LinkLabelUsuarios.AutoSize = True
        Me.LinkLabelUsuarios.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabelUsuarios.Location = New System.Drawing.Point(127, 273)
        Me.LinkLabelUsuarios.Name = "LinkLabelUsuarios"
        Me.LinkLabelUsuarios.Size = New System.Drawing.Size(129, 13)
        Me.LinkLabelUsuarios.TabIndex = 10
        Me.LinkLabelUsuarios.TabStop = True
        Me.LinkLabelUsuarios.Text = "GESTIONAR USUARIOS"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(413, 294)
        Me.Controls.Add(Me.LinkLabelUsuarios)
        Me.Controls.Add(Me.LabelUsuarioU)
        Me.Controls.Add(Me.Usuar)
        Me.Controls.Add(Me.ButtonGestionarConsig)
        Me.Controls.Add(Me.ButtonConsultarEstP)
        Me.Controls.Add(Me.ButtonCargarP)
        Me.Controls.Add(Me.LabelTipoU)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                      PRINCIPAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelTipoU As Label
    Friend WithEvents ButtonCargarP As Button
    Friend WithEvents ButtonConsultarEstP As Button
    Friend WithEvents ButtonGestionarConsig As Button
    Friend WithEvents LabelUsuarioU As Label
    Friend WithEvents Usuar As Label
    Friend WithEvents LinkLabelUsuarios As LinkLabel
End Class
