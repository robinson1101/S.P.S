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

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Usuarios.ShowDialog()
    End Sub
End Class