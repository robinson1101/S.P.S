Imports MySql.Data.MySqlClient

Public Class Principal
    Private Sub ButtonSolicitarEQ_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonCargarP_Click(sender As Object, e As EventArgs) Handles ButtonCargarP.Click
        Cargar_pago.ShowDialog()

    End Sub

    Private Sub ButtonConsultarEstP_Click(sender As Object, e As EventArgs) Handles ButtonConsultarEstP.Click
        ConsultarEP.ShowDialog()

    End Sub

    Private Sub ButtonGestionarConsig_Click(sender As Object, e As EventArgs) Handles ButtonGestionarConsig.Click
        Consignaciones.ShowDialog()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LabelTipoU.Text <> "ADMINISTRADOR" Then
            LinkLabelUsuarios.Visible = False

        Else
            ButtonCargarP.Enabled = False
        End If
    End Sub

    Private Sub LinkLabelUsuarios_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelUsuarios.LinkClicked
        Usuarios.ShowDialog()
    End Sub
End Class