Module Resultados
    Const sueldoBase As Integer = 3800
    Const v_norte As Integer = 150
    Const v_sur As Integer = 200
    Const v_oriente As Integer = 175
    Const v_occidente As Integer = 225

    Function MontoSeguro() As Double
        Dim monto As Double

        If Form1.r_vehiculo.Checked = True Then
            monto = sueldoBase * 0.03
        ElseIf Form1.r_accidente.Checked = True Then
            monto = sueldoBase * 0.05
        End If


        Return monto
    End Function

    Function SueldoFinal() As Double
        Dim monto As Double

        If Form1.r_norte.Checked = True Then
            monto = sueldoBase + v_norte
        ElseIf Form1.r_sur.Checked = True Then
            monto = sueldoBase + v_sur
        ElseIf Form1.r_oriente.Checked = True Then
            monto = sueldoBase + v_oriente
        ElseIf Form1.r_occidente.Checked = True Then
            monto = sueldoBase + v_occidente
        End If


        Return monto
    End Function

    Sub Limpiar()
        Form1.txt_nombre.Clear()
        Form1.txt_envio.Clear()
        Form1.txt_nombre.Focus()
        Form1.r_norte.Checked = False
        Form1.r_sur.Checked = False
        Form1.r_oriente.Checked = False
        Form1.r_occidente.Checked = False
        Form1.r_vehiculo.Checked = False
        Form1.r_accidente.Checked = False
    End Sub
End Module
