<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagarMedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagarMedicamento))
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.RecetaAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador()
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        Me.PacienteAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador()
        Me.gbMedicamento = New System.Windows.Forms.GroupBox()
        Me.dtpReceta = New System.Windows.Forms.DateTimePicker()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.tbNumeroEnvase = New System.Windows.Forms.TextBox()
        Me.lbEnvase = New System.Windows.Forms.Label()
        Me.tbFormato = New System.Windows.Forms.TextBox()
        Me.lbFormato = New System.Windows.Forms.Label()
        Me.tbVia = New System.Windows.Forms.TextBox()
        Me.lbVia = New System.Windows.Forms.Label()
        Me.tbDosis = New System.Windows.Forms.TextBox()
        Me.lbDosis = New System.Windows.Forms.Label()
        Me.tbDenominacion = New System.Windows.Forms.TextBox()
        Me.lbDenominacion = New System.Windows.Forms.Label()
        Me.tbGrupoEquivalencia = New System.Windows.Forms.TextBox()
        Me.lbEquivalencia = New System.Windows.Forms.Label()
        Me.tbNombreMedicamento = New System.Windows.Forms.TextBox()
        Me.lbMedicamento = New System.Windows.Forms.Label()
        Me.tbMedicamento = New System.Windows.Forms.TextBox()
        Me.lbNumMedicamento = New System.Windows.Forms.Label()
        Me.Farmacia_MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador()
        Me.FarmaceuticoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador()
        Me.gbMedicamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPagar
        '
        Me.btnPagar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Location = New System.Drawing.Point(12, 306)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(451, 30)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Pagar Medicamento"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrecio.Location = New System.Drawing.Point(12, 258)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(108, 45)
        Me.lbPrecio.TabIndex = 1
        Me.lbPrecio.Text = "Precio"
        '
        'RecetaAdaptador
        '
        Me.RecetaAdaptador.ClearBeforeFill = True
        '
        'MedicamentoAdaptador
        '
        Me.MedicamentoAdaptador.ClearBeforeFill = True
        '
        'PacienteAdaptador
        '
        Me.PacienteAdaptador.ClearBeforeFill = True
        '
        'gbMedicamento
        '
        Me.gbMedicamento.Controls.Add(Me.dtpReceta)
        Me.gbMedicamento.Controls.Add(Me.lbFecha)
        Me.gbMedicamento.Controls.Add(Me.tbNumeroEnvase)
        Me.gbMedicamento.Controls.Add(Me.lbEnvase)
        Me.gbMedicamento.Controls.Add(Me.tbFormato)
        Me.gbMedicamento.Controls.Add(Me.lbFormato)
        Me.gbMedicamento.Controls.Add(Me.tbVia)
        Me.gbMedicamento.Controls.Add(Me.lbVia)
        Me.gbMedicamento.Controls.Add(Me.tbDosis)
        Me.gbMedicamento.Controls.Add(Me.lbDosis)
        Me.gbMedicamento.Controls.Add(Me.tbDenominacion)
        Me.gbMedicamento.Controls.Add(Me.lbDenominacion)
        Me.gbMedicamento.Controls.Add(Me.tbGrupoEquivalencia)
        Me.gbMedicamento.Controls.Add(Me.lbEquivalencia)
        Me.gbMedicamento.Controls.Add(Me.tbNombreMedicamento)
        Me.gbMedicamento.Controls.Add(Me.lbMedicamento)
        Me.gbMedicamento.Controls.Add(Me.tbMedicamento)
        Me.gbMedicamento.Controls.Add(Me.lbNumMedicamento)
        Me.gbMedicamento.Location = New System.Drawing.Point(51, 12)
        Me.gbMedicamento.Name = "gbMedicamento"
        Me.gbMedicamento.Size = New System.Drawing.Size(372, 159)
        Me.gbMedicamento.TabIndex = 3
        Me.gbMedicamento.TabStop = False
        Me.gbMedicamento.Text = "Datos Medicamento"
        '
        'dtpReceta
        '
        Me.dtpReceta.Enabled = False
        Me.dtpReceta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReceta.Location = New System.Drawing.Point(52, 126)
        Me.dtpReceta.Name = "dtpReceta"
        Me.dtpReceta.Size = New System.Drawing.Size(115, 20)
        Me.dtpReceta.TabIndex = 17
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(6, 129)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(40, 13)
        Me.lbFecha.TabIndex = 16
        Me.lbFecha.Text = "Fecha:"
        '
        'tbNumeroEnvase
        '
        Me.tbNumeroEnvase.Location = New System.Drawing.Point(257, 98)
        Me.tbNumeroEnvase.Name = "tbNumeroEnvase"
        Me.tbNumeroEnvase.ReadOnly = True
        Me.tbNumeroEnvase.Size = New System.Drawing.Size(100, 20)
        Me.tbNumeroEnvase.TabIndex = 15
        '
        'lbEnvase
        '
        Me.lbEnvase.AutoSize = True
        Me.lbEnvase.Location = New System.Drawing.Point(177, 101)
        Me.lbEnvase.Name = "lbEnvase"
        Me.lbEnvase.Size = New System.Drawing.Size(74, 13)
        Me.lbEnvase.TabIndex = 14
        Me.lbEnvase.Text = "Núm. Envase:"
        '
        'tbFormato
        '
        Me.tbFormato.Location = New System.Drawing.Point(60, 98)
        Me.tbFormato.Name = "tbFormato"
        Me.tbFormato.ReadOnly = True
        Me.tbFormato.Size = New System.Drawing.Size(100, 20)
        Me.tbFormato.TabIndex = 13
        '
        'lbFormato
        '
        Me.lbFormato.AutoSize = True
        Me.lbFormato.Location = New System.Drawing.Point(6, 101)
        Me.lbFormato.Name = "lbFormato"
        Me.lbFormato.Size = New System.Drawing.Size(48, 13)
        Me.lbFormato.TabIndex = 12
        Me.lbFormato.Text = "Formato:"
        '
        'tbVia
        '
        Me.tbVia.Location = New System.Drawing.Point(257, 69)
        Me.tbVia.Name = "tbVia"
        Me.tbVia.ReadOnly = True
        Me.tbVia.Size = New System.Drawing.Size(100, 20)
        Me.tbVia.TabIndex = 11
        '
        'lbVia
        '
        Me.lbVia.AutoSize = True
        Me.lbVia.Location = New System.Drawing.Point(224, 72)
        Me.lbVia.Name = "lbVia"
        Me.lbVia.Size = New System.Drawing.Size(27, 13)
        Me.lbVia.TabIndex = 10
        Me.lbVia.Text = "Vía:"
        '
        'tbDosis
        '
        Me.tbDosis.Location = New System.Drawing.Point(48, 69)
        Me.tbDosis.Name = "tbDosis"
        Me.tbDosis.ReadOnly = True
        Me.tbDosis.Size = New System.Drawing.Size(100, 20)
        Me.tbDosis.TabIndex = 9
        '
        'lbDosis
        '
        Me.lbDosis.AutoSize = True
        Me.lbDosis.Location = New System.Drawing.Point(6, 72)
        Me.lbDosis.Name = "lbDosis"
        Me.lbDosis.Size = New System.Drawing.Size(36, 13)
        Me.lbDosis.TabIndex = 8
        Me.lbDosis.Text = "Dosis:"
        '
        'tbDenominacion
        '
        Me.tbDenominacion.Location = New System.Drawing.Point(257, 41)
        Me.tbDenominacion.Name = "tbDenominacion"
        Me.tbDenominacion.ReadOnly = True
        Me.tbDenominacion.Size = New System.Drawing.Size(100, 20)
        Me.tbDenominacion.TabIndex = 7
        '
        'lbDenominacion
        '
        Me.lbDenominacion.AutoSize = True
        Me.lbDenominacion.Location = New System.Drawing.Point(173, 44)
        Me.lbDenominacion.Name = "lbDenominacion"
        Me.lbDenominacion.Size = New System.Drawing.Size(78, 13)
        Me.lbDenominacion.TabIndex = 6
        Me.lbDenominacion.Text = "Denominación:"
        '
        'tbGrupoEquivalencia
        '
        Me.tbGrupoEquivalencia.Location = New System.Drawing.Point(70, 41)
        Me.tbGrupoEquivalencia.Name = "tbGrupoEquivalencia"
        Me.tbGrupoEquivalencia.ReadOnly = True
        Me.tbGrupoEquivalencia.Size = New System.Drawing.Size(83, 20)
        Me.tbGrupoEquivalencia.TabIndex = 5
        '
        'lbEquivalencia
        '
        Me.lbEquivalencia.AutoSize = True
        Me.lbEquivalencia.Location = New System.Drawing.Point(6, 44)
        Me.lbEquivalencia.Name = "lbEquivalencia"
        Me.lbEquivalencia.Size = New System.Drawing.Size(58, 13)
        Me.lbEquivalencia.TabIndex = 4
        Me.lbEquivalencia.Text = "Grupo Eq.:"
        '
        'tbNombreMedicamento
        '
        Me.tbNombreMedicamento.Location = New System.Drawing.Point(257, 13)
        Me.tbNombreMedicamento.Name = "tbNombreMedicamento"
        Me.tbNombreMedicamento.ReadOnly = True
        Me.tbNombreMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbNombreMedicamento.TabIndex = 3
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
        'tbMedicamento
        '
        Me.tbMedicamento.Location = New System.Drawing.Point(98, 13)
        Me.tbMedicamento.Name = "tbMedicamento"
        Me.tbMedicamento.ReadOnly = True
        Me.tbMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbMedicamento.TabIndex = 1
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
        'Farmacia_MedicamentoAdaptador
        '
        Me.Farmacia_MedicamentoAdaptador.ClearBeforeFill = True
        '
        'FarmaceuticoAdaptador
        '
        Me.FarmaceuticoAdaptador.ClearBeforeFill = True
        '
        'PagarMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 348)
        Me.Controls.Add(Me.gbMedicamento)
        Me.Controls.Add(Me.lbPrecio)
        Me.Controls.Add(Me.btnPagar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PagarMedicamento"
        Me.Text = "Pagar Medicamento"
        Me.gbMedicamento.ResumeLayout(False)
        Me.gbMedicamento.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents lbPrecio As System.Windows.Forms.Label
    Friend WithEvents RecetaAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents PacienteAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador
    Friend WithEvents gbMedicamento As System.Windows.Forms.GroupBox
    Friend WithEvents dtpReceta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbFecha As System.Windows.Forms.Label
    Friend WithEvents tbNumeroEnvase As System.Windows.Forms.TextBox
    Friend WithEvents lbEnvase As System.Windows.Forms.Label
    Friend WithEvents tbFormato As System.Windows.Forms.TextBox
    Friend WithEvents lbFormato As System.Windows.Forms.Label
    Friend WithEvents tbVia As System.Windows.Forms.TextBox
    Friend WithEvents lbVia As System.Windows.Forms.Label
    Friend WithEvents tbDosis As System.Windows.Forms.TextBox
    Friend WithEvents lbDosis As System.Windows.Forms.Label
    Friend WithEvents tbDenominacion As System.Windows.Forms.TextBox
    Friend WithEvents lbDenominacion As System.Windows.Forms.Label
    Friend WithEvents tbGrupoEquivalencia As System.Windows.Forms.TextBox
    Friend WithEvents lbEquivalencia As System.Windows.Forms.Label
    Friend WithEvents tbNombreMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents lbMedicamento As System.Windows.Forms.Label
    Friend WithEvents tbMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents lbNumMedicamento As System.Windows.Forms.Label
    Friend WithEvents Farmacia_MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador
    Friend WithEvents FarmaceuticoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador
End Class
