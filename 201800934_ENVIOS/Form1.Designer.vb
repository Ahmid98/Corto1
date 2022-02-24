<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_envio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.r_norte = New System.Windows.Forms.RadioButton()
        Me.r_oriente = New System.Windows.Forms.RadioButton()
        Me.r_sur = New System.Windows.Forms.RadioButton()
        Me.r_occidente = New System.Windows.Forms.RadioButton()
        Me.r_vehiculo = New System.Windows.Forms.RadioButton()
        Me.r_accidente = New System.Windows.Forms.RadioButton()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global._201800934_ENVIOS.My.Resources.Resources.Fondo
        Me.GroupBox1.Controls.Add(Me.btn_limpiar)
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_calcular)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txt_envio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Pepper Sauce", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 512)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Mensajero:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(223, 47)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(112, 33)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_envio
        '
        Me.txt_envio.Location = New System.Drawing.Point(223, 112)
        Me.txt_envio.Name = "txt_envio"
        Me.txt_envio.Size = New System.Drawing.Size(112, 33)
        Me.txt_envio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monto del envio:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.r_occidente)
        Me.GroupBox2.Controls.Add(Me.r_sur)
        Me.GroupBox2.Controls.Add(Me.r_oriente)
        Me.GroupBox2.Controls.Add(Me.r_norte)
        Me.GroupBox2.Location = New System.Drawing.Point(107, 199)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 220)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Region:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.r_accidente)
        Me.GroupBox3.Controls.Add(Me.r_vehiculo)
        Me.GroupBox3.Location = New System.Drawing.Point(401, 199)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(295, 210)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seguro:"
        '
        'r_norte
        '
        Me.r_norte.AutoSize = True
        Me.r_norte.Location = New System.Drawing.Point(29, 47)
        Me.r_norte.Name = "r_norte"
        Me.r_norte.Size = New System.Drawing.Size(87, 29)
        Me.r_norte.TabIndex = 0
        Me.r_norte.TabStop = True
        Me.r_norte.Text = "Norte"
        Me.r_norte.UseVisualStyleBackColor = True
        '
        'r_oriente
        '
        Me.r_oriente.AutoSize = True
        Me.r_oriente.Location = New System.Drawing.Point(29, 145)
        Me.r_oriente.Name = "r_oriente"
        Me.r_oriente.Size = New System.Drawing.Size(103, 29)
        Me.r_oriente.TabIndex = 1
        Me.r_oriente.TabStop = True
        Me.r_oriente.Text = "Oriente"
        Me.r_oriente.UseVisualStyleBackColor = True
        '
        'r_sur
        '
        Me.r_sur.AutoSize = True
        Me.r_sur.Location = New System.Drawing.Point(29, 91)
        Me.r_sur.Name = "r_sur"
        Me.r_sur.Size = New System.Drawing.Size(64, 29)
        Me.r_sur.TabIndex = 2
        Me.r_sur.TabStop = True
        Me.r_sur.Text = "Sur"
        Me.r_sur.UseVisualStyleBackColor = True
        '
        'r_occidente
        '
        Me.r_occidente.AutoSize = True
        Me.r_occidente.Location = New System.Drawing.Point(29, 186)
        Me.r_occidente.Name = "r_occidente"
        Me.r_occidente.Size = New System.Drawing.Size(125, 29)
        Me.r_occidente.TabIndex = 3
        Me.r_occidente.TabStop = True
        Me.r_occidente.Text = "Occidente"
        Me.r_occidente.UseVisualStyleBackColor = True
        '
        'r_vehiculo
        '
        Me.r_vehiculo.AutoSize = True
        Me.r_vehiculo.Location = New System.Drawing.Point(55, 47)
        Me.r_vehiculo.Name = "r_vehiculo"
        Me.r_vehiculo.Size = New System.Drawing.Size(114, 29)
        Me.r_vehiculo.TabIndex = 1
        Me.r_vehiculo.TabStop = True
        Me.r_vehiculo.Text = "Vehiculo"
        Me.r_vehiculo.UseVisualStyleBackColor = True
        '
        'r_accidente
        '
        Me.r_accidente.AutoSize = True
        Me.r_accidente.Location = New System.Drawing.Point(55, 109)
        Me.r_accidente.Name = "r_accidente"
        Me.r_accidente.Size = New System.Drawing.Size(126, 29)
        Me.r_accidente.TabIndex = 2
        Me.r_accidente.TabStop = True
        Me.r_accidente.Text = "Accidente"
        Me.r_accidente.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Pepper Sauce", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(60, 462)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(149, 50)
        Me.btn_calcular.TabIndex = 6
        Me.btn_calcular.Text = "CALCULAR"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Pepper Sauce", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(536, 462)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(149, 50)
        Me.btn_salir.TabIndex = 7
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Font = New System.Drawing.Font("Pepper Sauce", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(299, 462)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(149, 50)
        Me.btn_limpiar.TabIndex = 8
        Me.btn_limpiar.Text = "LIMPIAR"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(800, 537)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "SISTEMA MENSAJERIA "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents r_accidente As RadioButton
    Friend WithEvents r_vehiculo As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents r_occidente As RadioButton
    Friend WithEvents r_sur As RadioButton
    Friend WithEvents r_oriente As RadioButton
    Friend WithEvents r_norte As RadioButton
    Friend WithEvents txt_envio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
End Class
