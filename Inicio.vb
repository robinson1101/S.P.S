Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxUser.Focus()
    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Dim conexion0 As New conexion
        Dim cmd0 As New MySqlCommand("CALL Ingresar('" & TextBoxUser.Text & "','" & TextBoxPassword.Text & "')", conexion0.conexion)
        conexion0.AbrirConexion()
        cmd0.ExecuteNonQuery()


        Dim leer0 As MySqlDataReader = cmd0.ExecuteReader()

        If leer0.Read Then
            Principal.LabelNombre.Text = leer0(4)
            Principal.LabelTipoU.Text = leer0(1)
            Principal.LabelUsuarioU.Text = leer0(2)
            Principal.LabelNombre.Text += " " & leer0(5)
            Cargar_pago.LabelIdSub.Text = leer0(2)
            Cargar_pago.LabelNombreP.Text = leer0(4) & " "
            Cargar_pago.LabelNombreP.Text += leer0(5)
            Cargar_pago.LabelCedulaP.Text = leer0(6)
            Principal.Show()
            Me.Hide()
        ElseIf Not leer0.Read Then
            MsgBox("USUARIO O CONTRASEÑA INCORRECTOS.", MsgBoxStyle.Exclamation, "AVISO")
            TextBoxPassword.Text = ""
            TextBoxUser.Text = ""
            TextBoxUser.Focus()
        End If

        conexion0.CerrarConexion()


    End Sub

    Private Sub ButtonIngresar_KeyDown(sender As Object, e As KeyEventArgs) Handles ButtonIngresar.KeyDown

    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        If ChrW(Keys.Space) = e.KeyChar Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then

            ButtonIngresar.PerformClick()

        End If

    End Sub


End Class
