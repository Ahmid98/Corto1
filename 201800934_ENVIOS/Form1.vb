Public Class Form1
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click

        If txt_nombre.Text <> "" Then
            If txt_nombre.Text <> "" Then
                If r_accidente.Checked = True Or r_vehiculo.Checked = True Then
                    If r_norte.Checked = True Or r_sur.Checked = True Or r_oriente.Checked = True Or r_occidente.Checked = True Then
                        MuestraResultados.lb_seguro.Text = System.Math.Round(Resultados.MontoSeguro, 2)
                        MuestraResultados.lb_suedofinal.Text = System.Math.Round(Resultados.SueldoFinal, 2)
                    Else
                        MsgBox("Debe seleccionar una region.. ")
                    End If
                Else
                    MsgBox("Debe seleccionar un seguro.. ")
                End If
            Else
                MsgBox("Debe ingresar un nombre.. ")
            End If
        Else
            MsgBox("Debe ingresar un monto.. ")
        End If

        MuestraResultados.Show()
        Me.Hide()
    End Sub

    Private Sub txt_envio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_envio.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Resultados.Limpiar()

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        MsgBox("Desea salir del sistema..", vbYesNo)
        End

    End Sub
End Class
