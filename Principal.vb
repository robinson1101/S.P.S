Imports MySql.Data.MySqlClient

Public Class Principal


    Private Sub ButtonCargarP_Click(sender As Object, e As EventArgs) Handles ButtonCargarP.Click
        Try
            Dim conexionPrueba As New conexion
            Dim cmdPrueba As New MySqlCommand("select * from bancos ", conexionPrueba.conexion)
            conexionPrueba.AbrirConexion()
            cmdPrueba.ExecuteNonQuery()
            conexionPrueba.CerrarConexion()
            Cargar_pago.ShowDialog()
        Catch ex As Exception

            MsgBox("ERROR DE CONEXION", MsgBoxStyle.Critical, "AVISO")

        End Try



    End Sub

    Private Sub ButtonConsultarEstP_Click(sender As Object, e As EventArgs) Handles ButtonConsultarEstP.Click
        Try
            Dim conexionPrueba As New conexion
            Dim cmdPrueba As New MySqlCommand("select * from bancos ", conexionPrueba.conexion)
            conexionPrueba.AbrirConexion()
            cmdPrueba.ExecuteNonQuery()
            conexionPrueba.CerrarConexion()
            ConsultarEP.ShowDialog()
        Catch ex As Exception

            MsgBox("ERROR DE CONEXION", MsgBoxStyle.Critical, "AVISO")

        End Try


    End Sub

    Private Sub ButtonGestionarConsig_Click(sender As Object, e As EventArgs) Handles ButtonGestionarConsig.Click
        Try
            Dim conexionPrueba As New conexion
            Dim cmdPrueba As New MySqlCommand("select * from bancos ", conexionPrueba.conexion)
            conexionPrueba.AbrirConexion()
            cmdPrueba.ExecuteNonQuery()
            conexionPrueba.CerrarConexion()

            'llamando al loading

            Loading.Show()
            Loading.TimerLoading.Start()
        Catch ex As Exception

            MsgBox("ERROR DE CONEXION", MsgBoxStyle.Critical, "AVISO")

        End Try




    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If LabelTipoU.Text <> "ADMINISTRADOR" Then
            LinkLabelUsuarios.Visible = False

        Else
            ButtonCargarP.Enabled = False
        End If
    End Sub

    Private Sub LinkLabelUsuarios_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelUsuarios.LinkClicked

        Try
            Dim conexionPrueba As New conexion
            Dim cmdPrueba As New MySqlCommand("select * from bancos ", conexionPrueba.conexion)
            conexionPrueba.AbrirConexion()
            cmdPrueba.ExecuteNonQuery()
            conexionPrueba.CerrarConexion()

            Usuarios.ShowDialog()

        Catch ex As Exception

            MsgBox("ERROR DE CONEXION", MsgBoxStyle.Critical, "AVISO")

        End Try


    End Sub
End Class