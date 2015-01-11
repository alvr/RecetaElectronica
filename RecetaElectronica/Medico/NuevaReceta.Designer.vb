<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaReceta
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevaReceta))
        Me.gbMedicamento = New System.Windows.Forms.GroupBox()
        Me.dtpRecetada = New System.Windows.Forms.DateTimePicker()
        Me.lbRecetada = New System.Windows.Forms.Label()
        Me.tbEnvase = New System.Windows.Forms.TextBox()
        Me.lbEnvase = New System.Windows.Forms.Label()
        Me.tbFormato = New System.Windows.Forms.TextBox()
        Me.lbFormato = New System.Windows.Forms.Label()
        Me.tbVia = New System.Windows.Forms.TextBox()
        Me.lbVia = New System.Windows.Forms.Label()
        Me.tbDosis = New System.Windows.Forms.TextBox()
        Me.lbDosis = New System.Windows.Forms.Label()
        Me.tbDenominacion = New System.Windows.Forms.TextBox()
        Me.lbDenominacion = New System.Windows.Forms.Label()
        Me.tbEquivalencia = New System.Windows.Forms.TextBox()
        Me.lbEquivalencia = New System.Windows.Forms.Label()
        Me.tbMedicamento = New System.Windows.Forms.TextBox()
        Me.lbMedicamento = New System.Windows.Forms.Label()
        Me.tbNumMedicamento = New System.Windows.Forms.TextBox()
        Me.lbNumMedicamento = New System.Windows.Forms.Label()
        Me.gbPaciente = New System.Windows.Forms.GroupBox()
        Me.lbCronico = New System.Windows.Forms.Label()
        Me.rtbHistorial = New System.Windows.Forms.RichTextBox()
        Me.tbSituacion = New System.Windows.Forms.TextBox()
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
        Me.btnAñadirReceta = New System.Windows.Forms.Button()
        Me.btnSelMedicamento = New System.Windows.Forms.Button()
        Me.PacienteAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador()
        Me.RecetaAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador()
        Me.Recetas_MedicoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.Recetas_MedicoAdaptador()
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        Me.PacienteDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbMedicamento.SuspendLayout()
        Me.gbPaciente.SuspendLayout()
        CType(Me.PacienteDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMedicamento
        '
        Me.gbMedicamento.Controls.Add(Me.dtpRecetada)
        Me.gbMedicamento.Controls.Add(Me.lbRecetada)
        Me.gbMedicamento.Controls.Add(Me.tbEnvase)
        Me.gbMedicamento.Controls.Add(Me.lbEnvase)
        Me.gbMedicamento.Controls.Add(Me.tbFormato)
        Me.gbMedicamento.Controls.Add(Me.lbFormato)
        Me.gbMedicamento.Controls.Add(Me.tbVia)
        Me.gbMedicamento.Controls.Add(Me.lbVia)
        Me.gbMedicamento.Controls.Add(Me.tbDosis)
        Me.gbMedicamento.Controls.Add(Me.lbDosis)
        Me.gbMedicamento.Controls.Add(Me.tbDenominacion)
        Me.gbMedicamento.Controls.Add(Me.lbDenominacion)
        Me.gbMedicamento.Controls.Add(Me.tbEquivalencia)
        Me.gbMedicamento.Controls.Add(Me.lbEquivalencia)
        Me.gbMedicamento.Controls.Add(Me.tbMedicamento)
        Me.gbMedicamento.Controls.Add(Me.lbMedicamento)
        Me.gbMedicamento.Controls.Add(Me.tbNumMedicamento)
        Me.gbMedicamento.Controls.Add(Me.lbNumMedicamento)
        Me.gbMedicamento.Location = New System.Drawing.Point(12, 294)
        Me.gbMedicamento.Name = "gbMedicamento"
        Me.gbMedicamento.Size = New System.Drawing.Size(517, 94)
        Me.gbMedicamento.TabIndex = 3
        Me.gbMedicamento.TabStop = False
        Me.gbMedicamento.Text = "Datos Medicamento"
        '
        'dtpRecetada
        '
        Me.dtpRecetada.Enabled = False
        Me.dtpRecetada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRecetada.Location = New System.Drawing.Point(395, 65)
        Me.dtpRecetada.Name = "dtpRecetada"
        Me.dtpRecetada.Size = New System.Drawing.Size(115, 20)
        Me.dtpRecetada.TabIndex = 17
        '
        'lbRecetada
        '
        Me.lbRecetada.AutoSize = True
        Me.lbRecetada.Location = New System.Drawing.Point(349, 68)
        Me.lbRecetada.Name = "lbRecetada"
        Me.lbRecetada.Size = New System.Drawing.Size(40, 13)
        Me.lbRecetada.TabIndex = 16
        Me.lbRecetada.Text = "Fecha:"
        '
        'tbEnvase
        '
        Me.tbEnvase.Location = New System.Drawing.Point(243, 65)
        Me.tbEnvase.Name = "tbEnvase"
        Me.tbEnvase.ReadOnly = True
        Me.tbEnvase.Size = New System.Drawing.Size(100, 20)
        Me.tbEnvase.TabIndex = 15
        '
        'lbEnvase
        '
        Me.lbEnvase.AutoSize = True
        Me.lbEnvase.Location = New System.Drawing.Point(163, 68)
        Me.lbEnvase.Name = "lbEnvase"
        Me.lbEnvase.Size = New System.Drawing.Size(74, 13)
        Me.lbEnvase.TabIndex = 14
        Me.lbEnvase.Text = "Núm. Envase:"
        '
        'tbFormato
        '
        Me.tbFormato.Location = New System.Drawing.Point(57, 65)
        Me.tbFormato.Name = "tbFormato"
        Me.tbFormato.ReadOnly = True
        Me.tbFormato.Size = New System.Drawing.Size(100, 20)
        Me.tbFormato.TabIndex = 13
        '
        'lbFormato
        '
        Me.lbFormato.AutoSize = True
        Me.lbFormato.Location = New System.Drawing.Point(3, 68)
        Me.lbFormato.Name = "lbFormato"
        Me.lbFormato.Size = New System.Drawing.Size(48, 13)
        Me.lbFormato.TabIndex = 12
        Me.lbFormato.Text = "Formato:"
        '
        'tbVia
        '
        Me.tbVia.Location = New System.Drawing.Point(375, 39)
        Me.tbVia.Name = "tbVia"
        Me.tbVia.ReadOnly = True
        Me.tbVia.Size = New System.Drawing.Size(100, 20)
        Me.tbVia.TabIndex = 11
        '
        'lbVia
        '
        Me.lbVia.AutoSize = True
        Me.lbVia.Location = New System.Drawing.Point(342, 42)
        Me.lbVia.Name = "lbVia"
        Me.lbVia.Size = New System.Drawing.Size(27, 13)
        Me.lbVia.TabIndex = 10
        Me.lbVia.Text = "Vía:"
        '
        'tbDosis
        '
        Me.tbDosis.Location = New System.Drawing.Point(235, 39)
        Me.tbDosis.Name = "tbDosis"
        Me.tbDosis.ReadOnly = True
        Me.tbDosis.Size = New System.Drawing.Size(100, 20)
        Me.tbDosis.TabIndex = 9
        '
        'lbDosis
        '
        Me.lbDosis.AutoSize = True
        Me.lbDosis.Location = New System.Drawing.Point(193, 42)
        Me.lbDosis.Name = "lbDosis"
        Me.lbDosis.Size = New System.Drawing.Size(36, 13)
        Me.lbDosis.TabIndex = 8
        Me.lbDosis.Text = "Dosis:"
        '
        'tbDenominacion
        '
        Me.tbDenominacion.Location = New System.Drawing.Point(87, 39)
        Me.tbDenominacion.Name = "tbDenominacion"
        Me.tbDenominacion.ReadOnly = True
        Me.tbDenominacion.Size = New System.Drawing.Size(100, 20)
        Me.tbDenominacion.TabIndex = 7
        '
        'lbDenominacion
        '
        Me.lbDenominacion.AutoSize = True
        Me.lbDenominacion.Location = New System.Drawing.Point(3, 42)
        Me.lbDenominacion.Name = "lbDenominacion"
        Me.lbDenominacion.Size = New System.Drawing.Size(78, 13)
        Me.lbDenominacion.TabIndex = 6
        Me.lbDenominacion.Text = "Denominación:"
        '
        'tbEquivalencia
        '
        Me.tbEquivalencia.Location = New System.Drawing.Point(427, 13)
        Me.tbEquivalencia.Name = "tbEquivalencia"
        Me.tbEquivalencia.ReadOnly = True
        Me.tbEquivalencia.Size = New System.Drawing.Size(83, 20)
        Me.tbEquivalencia.TabIndex = 5
        '
        'lbEquivalencia
        '
        Me.lbEquivalencia.AutoSize = True
        Me.lbEquivalencia.Location = New System.Drawing.Point(363, 16)
        Me.lbEquivalencia.Name = "lbEquivalencia"
        Me.lbEquivalencia.Size = New System.Drawing.Size(58, 13)
        Me.lbEquivalencia.TabIndex = 4
        Me.lbEquivalencia.Text = "Grupo Eq.:"
        '
        'tbMedicamento
        '
        Me.tbMedicamento.Location = New System.Drawing.Point(257, 13)
        Me.tbMedicamento.Name = "tbMedicamento"
        Me.tbMedicamento.ReadOnly = True
        Me.tbMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbMedicamento.TabIndex = 3
        '
        'lbMedicamento
        '
        Me.lbMedicamento.AutoSize = True
        Me.lbMedicamento.Location = New System.Drawing.Point(204, 16)
        Me.lbMedicamento.Name = "lbMedicamento"
        Me.lbMedicamento.Size = New System.Drawing.Size(47, 13)
        Me.lbMedicamento.TabIndex = 2
        Me.lbMedicamento.Text = "Nombre:"
        '
        'tbNumMedicamento
        '
        Me.tbNumMedicamento.Location = New System.Drawing.Point(98, 13)
        Me.tbNumMedicamento.Name = "tbNumMedicamento"
        Me.tbNumMedicamento.ReadOnly = True
        Me.tbNumMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbNumMedicamento.TabIndex = 1
        '
        'lbNumMedicamento
        '
        Me.lbNumMedicamento.AutoSize = True
        Me.lbNumMedicamento.Location = New System.Drawing.Point(4, 16)
        Me.lbNumMedicamento.Name = "lbNumMedicamento"
        Me.lbNumMedicamento.Size = New System.Drawing.Size(88, 13)
        Me.lbNumMedicamento.TabIndex = 0
        Me.lbNumMedicamento.Text = "N. Medicamento:"
        '
        'gbPaciente
        '
        Me.gbPaciente.Controls.Add(Me.lbCronico)
        Me.gbPaciente.Controls.Add(Me.rtbHistorial)
        Me.gbPaciente.Controls.Add(Me.tbSituacion)
        Me.gbPaciente.Controls.Add(Me.lbSituacion)
        Me.gbPaciente.Controls.Add(Me.tbBaremo)
        Me.gbPaciente.Controls.Add(Me.lbBaremo)
        Me.gbPaciente.Controls.Add(Me.cbCronico)
        Me.gbPaciente.Controls.Add(Me.lbFechaNacimiento)
        Me.gbPaciente.Controls.Add(Me.dtpFechaNacimiento)
        Me.gbPaciente.Controls.Add(Me.tbDNI)
        Me.gbPaciente.Controls.Add(Me.lbDNI)
        Me.gbPaciente.Controls.Add(Me.tbApellidos)
        Me.gbPaciente.Controls.Add(Me.lbApellidos)
        Me.gbPaciente.Controls.Add(Me.lbNombre)
        Me.gbPaciente.Controls.Add(Me.tbNombre)
        Me.gbPaciente.Controls.Add(Me.tbTarjeta)
        Me.gbPaciente.Controls.Add(Me.lbTarjeta)
        Me.gbPaciente.Location = New System.Drawing.Point(12, 12)
        Me.gbPaciente.Name = "gbPaciente"
        Me.gbPaciente.Size = New System.Drawing.Size(517, 276)
        Me.gbPaciente.TabIndex = 2
        Me.gbPaciente.TabStop = False
        Me.gbPaciente.Text = "Datos Paciente"
        '
        'lbCronico
        '
        Me.lbCronico.AutoSize = True
        Me.lbCronico.Location = New System.Drawing.Point(6, 69)
        Me.lbCronico.Name = "lbCronico"
        Me.lbCronico.Size = New System.Drawing.Size(46, 13)
        Me.lbCronico.TabIndex = 17
        Me.lbCronico.Text = "Crónico:"
        '
        'rtbHistorial
        '
        Me.rtbHistorial.Location = New System.Drawing.Point(1, 92)
        Me.rtbHistorial.Name = "rtbHistorial"
        Me.rtbHistorial.Size = New System.Drawing.Size(516, 178)
        Me.rtbHistorial.TabIndex = 16
        Me.rtbHistorial.Text = ""
        '
        'tbSituacion
        '
        Me.tbSituacion.Location = New System.Drawing.Point(345, 66)
        Me.tbSituacion.Name = "tbSituacion"
        Me.tbSituacion.ReadOnly = True
        Me.tbSituacion.Size = New System.Drawing.Size(100, 20)
        Me.tbSituacion.TabIndex = 15
        '
        'lbSituacion
        '
        Me.lbSituacion.AutoSize = True
        Me.lbSituacion.Location = New System.Drawing.Point(276, 69)
        Me.lbSituacion.Name = "lbSituacion"
        Me.lbSituacion.Size = New System.Drawing.Size(63, 13)
        Me.lbSituacion.TabIndex = 14
        Me.lbSituacion.Text = "Sit. Laboral:"
        '
        'tbBaremo
        '
        Me.tbBaremo.Location = New System.Drawing.Point(170, 66)
        Me.tbBaremo.Name = "tbBaremo"
        Me.tbBaremo.ReadOnly = True
        Me.tbBaremo.Size = New System.Drawing.Size(100, 20)
        Me.tbBaremo.TabIndex = 13
        '
        'lbBaremo
        '
        Me.lbBaremo.AutoSize = True
        Me.lbBaremo.Location = New System.Drawing.Point(79, 69)
        Me.lbBaremo.Name = "lbBaremo"
        Me.lbBaremo.Size = New System.Drawing.Size(85, 13)
        Me.lbBaremo.TabIndex = 12
        Me.lbBaremo.Text = "Bar. Económico:"
        '
        'cbCronico
        '
        Me.cbCronico.AutoSize = True
        Me.cbCronico.Enabled = False
        Me.cbCronico.Location = New System.Drawing.Point(58, 70)
        Me.cbCronico.Name = "cbCronico"
        Me.cbCronico.Size = New System.Drawing.Size(15, 14)
        Me.cbCronico.TabIndex = 11
        Me.cbCronico.UseVisualStyleBackColor = True
        '
        'lbFechaNacimiento
        '
        Me.lbFechaNacimiento.AutoSize = True
        Me.lbFechaNacimiento.Location = New System.Drawing.Point(232, 43)
        Me.lbFechaNacimiento.Name = "lbFechaNacimiento"
        Me.lbFechaNacimiento.Size = New System.Drawing.Size(96, 13)
        Me.lbFechaNacimiento.TabIndex = 9
        Me.lbFechaNacimiento.Text = "Fecha Nacimiento:"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Enabled = False
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(334, 40)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(146, 20)
        Me.dtpFechaNacimiento.TabIndex = 8
        '
        'tbDNI
        '
        Me.tbDNI.Location = New System.Drawing.Point(221, 13)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.ReadOnly = True
        Me.tbDNI.Size = New System.Drawing.Size(100, 20)
        Me.tbDNI.TabIndex = 7
        '
        'lbDNI
        '
        Me.lbDNI.AutoSize = True
        Me.lbDNI.Location = New System.Drawing.Point(186, 16)
        Me.lbDNI.Name = "lbDNI"
        Me.lbDNI.Size = New System.Drawing.Size(29, 13)
        Me.lbDNI.TabIndex = 6
        Me.lbDNI.Text = "DNI:"
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(64, 40)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.ReadOnly = True
        Me.tbApellidos.Size = New System.Drawing.Size(162, 20)
        Me.tbApellidos.TabIndex = 5
        '
        'lbApellidos
        '
        Me.lbApellidos.AutoSize = True
        Me.lbApellidos.Location = New System.Drawing.Point(6, 43)
        Me.lbApellidos.Name = "lbApellidos"
        Me.lbApellidos.Size = New System.Drawing.Size(52, 13)
        Me.lbApellidos.TabIndex = 4
        Me.lbApellidos.Text = "Apellidos:"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(327, 16)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 3
        Me.lbNombre.Text = "Nombre:"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(380, 13)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.ReadOnly = True
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 2
        '
        'tbTarjeta
        '
        Me.tbTarjeta.Location = New System.Drawing.Point(76, 13)
        Me.tbTarjeta.Name = "tbTarjeta"
        Me.tbTarjeta.ReadOnly = True
        Me.tbTarjeta.Size = New System.Drawing.Size(100, 20)
        Me.tbTarjeta.TabIndex = 1
        '
        'lbTarjeta
        '
        Me.lbTarjeta.AutoSize = True
        Me.lbTarjeta.Location = New System.Drawing.Point(6, 16)
        Me.lbTarjeta.Name = "lbTarjeta"
        Me.lbTarjeta.Size = New System.Drawing.Size(64, 13)
        Me.lbTarjeta.TabIndex = 0
        Me.lbTarjeta.Text = "T. Sanitaria:"
        '
        'btnAñadirReceta
        '
        Me.btnAñadirReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadirReceta.Location = New System.Drawing.Point(255, 394)
        Me.btnAñadirReceta.Name = "btnAñadirReceta"
        Me.btnAñadirReceta.Size = New System.Drawing.Size(274, 22)
        Me.btnAñadirReceta.TabIndex = 4
        Me.btnAñadirReceta.Text = "Añadir Receta"
        Me.btnAñadirReceta.UseVisualStyleBackColor = True
        '
        'btnSelMedicamento
        '
        Me.btnSelMedicamento.Location = New System.Drawing.Point(12, 394)
        Me.btnSelMedicamento.Name = "btnSelMedicamento"
        Me.btnSelMedicamento.Size = New System.Drawing.Size(237, 22)
        Me.btnSelMedicamento.TabIndex = 6
        Me.btnSelMedicamento.Text = "Seleccionar Medicamento"
        Me.btnSelMedicamento.UseVisualStyleBackColor = True
        '
        'PacienteAdaptador
        '
        Me.PacienteAdaptador.ClearBeforeFill = True
        '
        'RecetaAdaptador
        '
        Me.RecetaAdaptador.ClearBeforeFill = True
        '
        'Recetas_MedicoAdaptador
        '
        Me.Recetas_MedicoAdaptador.ClearBeforeFill = True
        '
        'MedicamentoAdaptador
        '
        Me.MedicamentoAdaptador.ClearBeforeFill = True
        '
        'PacienteDatos
        '
        Me.PacienteDatos.DataMember = "Paciente"
        '
        'NuevaReceta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 429)
        Me.Controls.Add(Me.btnSelMedicamento)
        Me.Controls.Add(Me.btnAñadirReceta)
        Me.Controls.Add(Me.gbMedicamento)
        Me.Controls.Add(Me.gbPaciente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NuevaReceta"
        Me.Text = "Nueva Receta"
        Me.gbMedicamento.ResumeLayout(False)
        Me.gbMedicamento.PerformLayout()
        Me.gbPaciente.ResumeLayout(False)
        Me.gbPaciente.PerformLayout()
        CType(Me.PacienteDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbMedicamento As System.Windows.Forms.GroupBox
    Friend WithEvents dtpRecetada As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbRecetada As System.Windows.Forms.Label
    Friend WithEvents tbEnvase As System.Windows.Forms.TextBox
    Friend WithEvents lbEnvase As System.Windows.Forms.Label
    Friend WithEvents tbFormato As System.Windows.Forms.TextBox
    Friend WithEvents lbFormato As System.Windows.Forms.Label
    Friend WithEvents tbVia As System.Windows.Forms.TextBox
    Friend WithEvents lbVia As System.Windows.Forms.Label
    Friend WithEvents tbDosis As System.Windows.Forms.TextBox
    Friend WithEvents lbDosis As System.Windows.Forms.Label
    Friend WithEvents tbDenominacion As System.Windows.Forms.TextBox
    Friend WithEvents lbDenominacion As System.Windows.Forms.Label
    Friend WithEvents tbEquivalencia As System.Windows.Forms.TextBox
    Friend WithEvents lbEquivalencia As System.Windows.Forms.Label
    Friend WithEvents tbMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents lbMedicamento As System.Windows.Forms.Label
    Friend WithEvents tbNumMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents lbNumMedicamento As System.Windows.Forms.Label
    Friend WithEvents gbPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents lbCronico As System.Windows.Forms.Label
    Friend WithEvents rtbHistorial As System.Windows.Forms.RichTextBox
    Friend WithEvents tbSituacion As System.Windows.Forms.TextBox
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
    Friend WithEvents tbTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents lbTarjeta As System.Windows.Forms.Label
    Friend WithEvents btnAñadirReceta As System.Windows.Forms.Button
    Friend WithEvents btnSelMedicamento As System.Windows.Forms.Button
    Friend WithEvents PacienteDatos As System.Windows.Forms.BindingSource
    Friend WithEvents PacienteAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador
    Friend WithEvents RecetaAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador
    Friend WithEvents Recetas_MedicoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.Recetas_MedicoAdaptador
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
End Class
