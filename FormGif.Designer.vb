<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGif
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
        Me.PictureBoxGif = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxGif
        '
        Me.PictureBoxGif.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxGif.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBoxGif.Image = Global.Legar.Resources.giphy
        Me.PictureBoxGif.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxGif.Name = "PictureBoxGif"
        Me.PictureBoxGif.Size = New System.Drawing.Size(375, 308)
        Me.PictureBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxGif.TabIndex = 0
        Me.PictureBoxGif.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(29, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CUPO EXCEDIDO, POR FAVOR CONSIGNE."
        '
        'FormGif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(375, 346)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxGif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormGif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBoxGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxGif As PictureBox
    Friend WithEvents Label1 As Label
End Class
