Public Class Loading
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub TimerLoading_Tick(sender As Object, e As EventArgs) Handles TimerLoading.Tick

        ProgressBarConsignaciones.Increment(1)
        Labelporcentaje.Text = ProgressBarConsignaciones.Value & (" %")
        If ProgressBarConsignaciones.Value = 95 Then
            LabelFinalizado.Visible = True

            LabelMensaje.Visible = True
        ElseIf ProgressBarConsignaciones.Value = 100 Then

            TimerLoading.Stop()
            Consignaciones.ShowDialog()
            'Me.Hide()

            ' MsgBox("ARCHIVO ALMACENADO CORRECTAMENTE", MsgBoxStyle.Information, "AVISO")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
End Class