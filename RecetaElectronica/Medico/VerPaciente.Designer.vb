<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerPaciente))
        Me.PacienteAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador()
        Me.lbCronico = New System.Windows.Forms.Label()
        Me.tbSituacionLab = New System.Windows.Forms.TextBox()
        Me.lbSituacion = New System.Windows.Forms.Label()
        Me.tbBaremo = New System.Windows.Forms.TextBox()
        Me.lbBaremo = New System.Windows.Forms.Label()
        Me.cbCronico = New System.Windows.Forms.CheckBox()
        Me.lbFechaNacimiento = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.lbDNI = New System.Windows.Forms.Label()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.lbApellidos = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbTarjeta = New System.Windows.Forms.TextBox()
        Me.lbTarjeta = New System.Windows.Forms.Label()
        Me.lbEntidad = New System.Windows.Forms.Label()
        Me.lbAcumulado = New System.Windows.Forms.Label()
        Me.lbHistorial = New System.Windows.Forms.Label()
        Me.tbEntidad = New System.Windows.Forms.TextBox()
        Me.tbAcumulado = New System.Windows.Forms.TextBox()
        Me.rtbHistorial = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'PacienteAdaptador
        '
        Me.PacienteAdaptador.ClearBeforeFill = True
        '
        'lbCronico
        '
        Me.lbCronico.AutoSize = True
        Me.lbCronico.Location = New System.Drawing.Point(302, 9)
        Me.lbCronico.Name = "lbCronico"
        Me.lbCronico.Size = New System.Drawing.Size(46, 13)
        Me.lbCronico.TabIndex = 33
        Me.lbCronico.Text = "Crónico:"
        '
        'tbSituacionLab
        '
        Me.tbSituacionLab.Location = New System.Drawing.Point(114, 162)
        Me.tbSituacionLab.Name = "tbSituacionLab"
        Me.tbSituacionLab.ReadOnly = True
        Me.tbSituacionLab.Size = New System.Drawing.Size(162, 20)
        Me.tbSituacionLab.TabIndex = 32
        '
        'lbSituacion
        '
        Me.lbSituacion.AutoSize = True
        Me.lbSituacion.Location = New System.Drawing.Point(12, 165)
        Me.lbSituacion.Name = "lbSituacion"
        Me.lbSituacion.Size = New System.Drawing.Size(63, 13)
        Me.lbSituacion.TabIndex = 31
        Me.lbSituacion.Text = "Sit. Laboral:"
        '
        'tbBaremo
        '
        Me.tbBaremo.Location = New System.Drawing.Point(114, 136)
        Me.tbBaremo.Name = "tbBaremo"
        Me.tbBaremo.ReadOnly = True
        Me.tbBaremo.Size = New System.Drawing.Size(162, 20)
        Me.tbBaremo.TabIndex = 30
        '
        'lbBaremo
        '
        Me.lbBaremo.AutoSize = True
        Me.lbBaremo.Location = New System.Drawing.Point(12, 139)
        Me.lbBaremo.Name = "lbBaremo"
        Me.lbBaremo.Size = New System.Drawing.Size(85, 13)
        Me.lbBaremo.TabIndex = 29
        Me.lbBaremo.Text = "Bar. Económico:"
        '
        'cbCronico
        '
        Me.cbCronico.AutoSize = True
        Me.cbCronico.Enabled = False
        Me.cbCronico.Location = New System.Drawing.Point(354, 10)
        Me.cbCronico.Name = "cbCronico"
        Me.cbCronico.Size = New System.Drawing.Size(15, 14)
        Me.cbCronico.TabIndex = 28
        Me.cbCronico.UseVisualStyleBackColor = True
        '
        'lbFechaNacimiento
        '
        Me.lbFechaNacimiento.AutoSize = True
        Me.lbFechaNacimiento.Location = New System.Drawing.Point(12, 113)
        Me.lbFechaNacimiento.Name = "lbFechaNacimiento"
        Me.lbFechaNacimiento.Size = New System.Drawing.Size(96, 13)
        Me.lbFechaNacimiento.TabIndex = 27
        Me.lbFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Enabled = False
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(114, 110)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(162, 20)
        Me.dtpFechaNacimiento.TabIndex = 26
        '
        'tbDNI
        '
        Me.tbDNI.Location = New System.Drawing.Point(114, 32)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.ReadOnly = True
        Me.tbDNI.Size = New System.Drawing.Size(162, 20)
        Me.tbDNI.TabIndex = 25
        '
        'lbDNI
        '
        Me.lbDNI.AutoSize = True
        Me.lbDNI.Location = New System.Drawing.Point(12, 35)
        Me.lbDNI.Name = "lbDNI"
        Me.lbDNI.Size = New System.Drawing.Size(29, 13)
        Me.lbDNI.TabIndex = 24
        Me.lbDNI.Text = "DNI:"
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(114, 84)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.ReadOnly = True
        Me.tbApellidos.Size = New System.Drawing.Size(162, 20)
        Me.tbApellidos.TabIndex = 23
        '
        'lbApellidos
        '
        Me.lbApellidos.AutoSize = True
        Me.lbApellidos.Location = New System.Drawing.Point(12, 87)
        Me.lbApellidos.Name = "lbApellidos"
        Me.lbApellidos.Size = New System.Drawing.Size(52, 13)
        Me.lbApellidos.TabIndex = 22
        Me.lbApellidos.Text = "Apellidos:"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(12, 61)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 21
        Me.lbNombre.Text = "Nombre:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(114, 58)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.ReadOnly = True
        Me.tbNombre.Size = New System.Drawing.Size(162, 20)
        Me.tbNombre.TabIndex = 20
        '
        'tbTarjeta
        '
        Me.tbTarjeta.Location = New System.Drawing.Point(114, 6)
        Me.tbTarjeta.Name = "tbTarjeta"
        Me.tbTarjeta.ReadOnly = True
        Me.tbTarjeta.Size = New System.Drawing.Size(162, 20)
        Me.tbTarjeta.TabIndex = 19
        '
        'lbTarjeta
        '
        Me.lbTarjeta.AutoSize = True
        Me.lbTarjeta.Location = New System.Drawing.Point(12, 9)
        Me.lbTarjeta.Name = "lbTarjeta"
        Me.lbTarjeta.Size = New System.Drawing.Size(64, 13)
        Me.lbTarjeta.TabIndex = 18
        Me.lbTarjeta.Text = "T. Sanitaria:"
        '
        'lbEntidad
        '
        Me.lbEntidad.AutoSize = True
        Me.lbEntidad.Location = New System.Drawing.Point(12, 192)
        Me.lbEntidad.Name = "lbEntidad"
        Me.lbEntidad.Size = New System.Drawing.Size(46, 13)
        Me.lbEntidad.TabIndex = 34
        Me.lbEntidad.Text = "Entidad:"
        '
        'lbAcumulado
        '
        Me.lbAcumulado.AutoSize = True
        Me.lbAcumulado.Location = New System.Drawing.Point(12, 219)
        Me.lbAcumulado.Name = "lbAcumulado"
        Me.lbAcumulado.Size = New System.Drawing.Size(63, 13)
        Me.lbAcumulado.TabIndex = 35
        Me.lbAcumulado.Text = "Acumulado:"
        '
        'lbHistorial
        '
        Me.lbHistorial.AutoSize = True
        Me.lbHistorial.Location = New System.Drawing.Point(12, 242)
        Me.lbHistorial.Name = "lbHistorial"
        Me.lbHistorial.Size = New System.Drawing.Size(47, 13)
        Me.lbHistorial.TabIndex = 36
        Me.lbHistorial.Text = "Historial:"
        '
        'tbEntidad
        '
        Me.tbEntidad.Location = New System.Drawing.Point(114, 189)
        Me.tbEntidad.Name = "tbEntidad"
        Me.tbEntidad.ReadOnly = True
        Me.tbEntidad.Size = New System.Drawing.Size(162, 20)
        Me.tbEntidad.TabIndex = 37
        '
        'tbAcumulado
        '
        Me.tbAcumulado.Location = New System.Drawing.Point(114, 216)
        Me.tbAcumulado.Name = "tbAcumulado"
        Me.tbAcumulado.ReadOnly = True
        Me.tbAcumulado.Size = New System.Drawing.Size(162, 20)
        Me.tbAcumulado.TabIndex = 38
        '
        'rtbHistorial
        '
        Me.rtbHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbHistorial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rtbHistorial.Location = New System.Drawing.Point(12, 258)
        Me.rtbHistorial.Name = "rtbHistorial"
        Me.rtbHistorial.ReadOnly = True
        Me.rtbHistorial.Size = New System.Drawing.Size(471, 158)
        Me.rtbHistorial.TabIndex = 39
        Me.rtbHistorial.Text = ""
        '
        'VerPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 428)
        Me.Controls.Add(Me.rtbHistorial)
        Me.Controls.Add(Me.tbAcumulado)
        Me.Controls.Add(Me.tbEntidad)
        Me.Controls.Add(Me.lbHistorial)
        Me.Controls.Add(Me.lbAcumulado)
        Me.Controls.Add(Me.lbEntidad)
        Me.Controls.Add(Me.lbCronico)
        Me.Controls.Add(Me.tbSituacionLab)
        Me.Controls.Add(Me.lbSituacion)
        Me.Controls.Add(Me.tbBaremo)
        Me.Controls.Add(Me.lbBaremo)
        Me.Controls.Add(Me.cbCronico)
        Me.Controls.Add(Me.lbFechaNacimiento)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.tbDNI)
        Me.Controls.Add(Me.lbDNI)
        Me.Controls.Add(Me.tbApellidos)
        Me.Controls.Add(Me.lbApellidos)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbTarjeta)
        Me.Controls.Add(Me.lbTarjeta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "VerPaciente"
        Me.Text = "Ver Paciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PacienteAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador
    Friend WithEvents lbCronico As System.Windows.Forms.Label
    Friend WithEvents tbSituacionLab As System.Windows.Forms.TextBox
    Friend WithEvents lbSituacion As System.Windows.Forms.Label
    Friend WithEvents tbBaremo As System.Windows.Forms.TextBox
    Friend WithEvents lbBaremo As System.Windows.Forms.Label
    Friend WithEvents cbCronico As System.Windows.Forms.CheckBox
    Friend WithEvents lbFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbDNI As System.Windows.Forms.TextBox
    Friend WithEvents lbDNI As System.Windows.Forms.Label
    Friend WithEvents tbApellidos As System.Windows.Forms.TextBox
    Friend WithEvents lbApellidos As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Public WithEvents tbTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents lbTarjeta As System.Windows.Forms.Label
    Friend WithEvents lbEntidad As System.Windows.Forms.Label
    Friend WithEvents lbAcumulado As System.Windows.Forms.Label
    Friend WithEvents lbHistorial As System.Windows.Forms.Label
    Friend WithEvents tbEntidad As System.Windows.Forms.TextBox
    Friend WithEvents tbAcumulado As System.Windows.Forms.TextBox
    Friend WithEvents rtbHistorial As System.Windows.Forms.RichTextBox
End Class
