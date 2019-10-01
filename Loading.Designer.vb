<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.LabelFinalizado = New System.Windows.Forms.Label()
        Me.ProgressBarConsignaciones = New System.Windows.Forms.ProgressBar()
        Me.Labelporcentaje = New System.Windows.Forms.Label()
        Me.TimerLoading = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "En un momento terminamos..."
        '
        'LabelMensaje
        '
        Me.LabelMensaje.AutoSize = True
        Me.LabelMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMensaje.ForeColor = System.Drawing.Color.Blue
        Me.LabelMensaje.Location = New System.Drawing.Point(96, 94)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.Size = New System.Drawing.Size(157, 20)
        Me.LabelMensaje.TabIndex = 9
        Me.LabelMensaje.Text = "CARGA COMPLETA"
        Me.LabelMensaje.Visible = False
        '
        'LabelFinalizado
        '
        Me.LabelFinalizado.AutoSize = True
        Me.LabelFinalizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFinalizado.ForeColor = System.Drawing.Color.Black
        Me.LabelFinalizado.Location = New System.Drawing.Point(272, 71)
        Me.LabelFinalizado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFinalizado.Name = "LabelFinalizado"
        Me.LabelFinalizado.Size = New System.Drawing.Size(64, 15)
        Me.LabelFinalizado.TabIndex = 8
        Me.LabelFinalizado.Text = "Finalizado"
        Me.LabelFinalizado.Visible = False
        '
        'ProgressBarConsignaciones
        '
        Me.ProgressBarConsignaciones.BackColor = System.Drawing.Color.OrangeRed
        Me.ProgressBarConsignaciones.ForeColor = System.Drawing.Color.Red
        Me.ProgressBarConsignaciones.Location = New System.Drawing.Point(24, 49)
        Me.ProgressBarConsignaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBarConsignaciones.MarqueeAnimationSpeed = 1
        Me.ProgressBarConsignaciones.Name = "ProgressBarConsignaciones"
        Me.ProgressBarConsignaciones.Size = New System.Drawing.Size(317, 21)
        Me.ProgressBarConsignaciones.Step = 1
        Me.ProgressBarConsignaciones.TabIndex = 7
        '
        'Labelporcentaje
        '
        Me.Labelporcentaje.AutoSize = True
        Me.Labelporcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelporcentaje.ForeColor = System.Drawing.Color.Black
        Me.Labelporcentaje.Location = New System.Drawing.Point(25, 73)
        Me.Labelporcentaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelporcentaje.Name = "Labelporcentaje"
        Me.Labelporcentaje.Size = New System.Drawing.Size(25, 15)
        Me.Labelporcentaje.TabIndex = 6
        Me.Labelporcentaje.Text = "0%"
        '
        'TimerLoading
        '
        Me.TimerLoading.Interval = 25
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(357, 139)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.LabelFinalizado)
        Me.Controls.Add(Me.ProgressBarConsignaciones)
        Me.Controls.Add(Me.Labelporcentaje)
        Me.ForeColor = System.Drawing.Color.Brown
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents LabelFinalizado As Label
    Friend WithEvents ProgressBarConsignaciones As ProgressBar
    Friend WithEvents Labelporcentaje As Label
    Friend WithEvents TimerLoading As Timer
End Class
