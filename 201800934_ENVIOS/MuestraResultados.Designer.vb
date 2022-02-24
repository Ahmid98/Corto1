<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuestraResultados
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_seguro = New System.Windows.Forms.Label()
        Me.lb_suedofinal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global._201800934_ENVIOS.My.Resources.Resources.Fondo
        Me.GroupBox1.Controls.Add(Me.btn_aceptar)
        Me.GroupBox1.Controls.Add(Me.lb_suedofinal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lb_seguro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Pepper Sauce", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RESULTADOS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto del seguro:"
        '
        'lb_seguro
        '
        Me.lb_seguro.AutoSize = True
        Me.lb_seguro.Location = New System.Drawing.Point(230, 61)
        Me.lb_seguro.Name = "lb_seguro"
        Me.lb_seguro.Size = New System.Drawing.Size(0, 25)
        Me.lb_seguro.TabIndex = 2
        '
        'lb_suedofinal
        '
        Me.lb_suedofinal.AutoSize = True
        Me.lb_suedofinal.Font = New System.Drawing.Font("Pepper Sauce", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_suedofinal.Location = New System.Drawing.Point(230, 118)
        Me.lb_suedofinal.Name = "lb_suedofinal"
        Me.lb_suedofinal.Size = New System.Drawing.Size(0, 30)
        Me.lb_suedofinal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Sueldo Final:"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Font = New System.Drawing.Font("Pepper Sauce", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aceptar.Location = New System.Drawing.Point(141, 206)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(146, 55)
        Me.btn_aceptar.TabIndex = 5
        Me.btn_aceptar.Text = "ACEPTAR"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'MuestraResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(412, 320)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MuestraResultados"
        Me.Text = "SISTEMA MENSAJERIA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents lb_suedofinal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_seguro As Label
    Friend WithEvents Label1 As Label
End Class
