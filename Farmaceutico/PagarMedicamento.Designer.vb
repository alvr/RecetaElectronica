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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpReceta = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbNumeroEnvase = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbFormato = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbVia = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tbDosis = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbDenominacion = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tbGrupoEquivalencia = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbNombreMedicamento = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.tbMedicamento = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Farmacia_MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador()
        Me.FarmaceuticoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador()
        Me.GroupBox4.SuspendLayout()
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpReceta)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.tbNumeroEnvase)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.tbFormato)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.tbVia)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.tbDosis)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.tbDenominacion)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.tbGrupoEquivalencia)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.tbNombreMedicamento)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.tbMedicamento)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Location = New System.Drawing.Point(51, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(372, 159)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Medicamento"
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
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 129)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 13)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "Fecha:"
        '
        'tbNumeroEnvase
        '
        Me.tbNumeroEnvase.Location = New System.Drawing.Point(257, 98)
        Me.tbNumeroEnvase.Name = "tbNumeroEnvase"
        Me.tbNumeroEnvase.ReadOnly = True
        Me.tbNumeroEnvase.Size = New System.Drawing.Size(100, 20)
        Me.tbNumeroEnvase.TabIndex = 15
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(177, 101)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 13)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Núm. Envase:"
        '
        'tbFormato
        '
        Me.tbFormato.Location = New System.Drawing.Point(60, 98)
        Me.tbFormato.Name = "tbFormato"
        Me.tbFormato.ReadOnly = True
        Me.tbFormato.Size = New System.Drawing.Size(100, 20)
        Me.tbFormato.TabIndex = 13
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 101)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 13)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "Formato:"
        '
        'tbVia
        '
        Me.tbVia.Location = New System.Drawing.Point(257, 69)
        Me.tbVia.Name = "tbVia"
        Me.tbVia.ReadOnly = True
        Me.tbVia.Size = New System.Drawing.Size(100, 20)
        Me.tbVia.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(224, 72)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(27, 13)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Vía:"
        '
        'tbDosis
        '
        Me.tbDosis.Location = New System.Drawing.Point(48, 69)
        Me.tbDosis.Name = "tbDosis"
        Me.tbDosis.ReadOnly = True
        Me.tbDosis.Size = New System.Drawing.Size(100, 20)
        Me.tbDosis.TabIndex = 9
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 72)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 13)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Dosis:"
        '
        'tbDenominacion
        '
        Me.tbDenominacion.Location = New System.Drawing.Point(257, 41)
        Me.tbDenominacion.Name = "tbDenominacion"
        Me.tbDenominacion.ReadOnly = True
        Me.tbDenominacion.Size = New System.Drawing.Size(100, 20)
        Me.tbDenominacion.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(173, 44)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(78, 13)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Denominación:"
        '
        'tbGrupoEquivalencia
        '
        Me.tbGrupoEquivalencia.Location = New System.Drawing.Point(70, 41)
        Me.tbGrupoEquivalencia.Name = "tbGrupoEquivalencia"
        Me.tbGrupoEquivalencia.ReadOnly = True
        Me.tbGrupoEquivalencia.Size = New System.Drawing.Size(83, 20)
        Me.tbGrupoEquivalencia.TabIndex = 5
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 44)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(58, 13)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "Grupo Eq.:"
        '
        'tbNombreMedicamento
        '
        Me.tbNombreMedicamento.Location = New System.Drawing.Point(257, 13)
        Me.tbNombreMedicamento.Name = "tbNombreMedicamento"
        Me.tbNombreMedicamento.ReadOnly = True
        Me.tbNombreMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbNombreMedicamento.TabIndex = 3
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(204, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 13)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Nombre:"
        '
        'tbMedicamento
        '
        Me.tbMedicamento.Location = New System.Drawing.Point(98, 13)
        Me.tbMedicamento.Name = "tbMedicamento"
        Me.tbMedicamento.ReadOnly = True
        Me.tbMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbMedicamento.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(4, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 13)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "N. Medicamento:"
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
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lbPrecio)
        Me.Controls.Add(Me.btnPagar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PagarMedicamento"
        Me.Text = "Pagar Medicamento"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents lbPrecio As System.Windows.Forms.Label
    Friend WithEvents RecetaAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents PacienteAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpReceta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents tbNumeroEnvase As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents tbFormato As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tbVia As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tbDosis As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents tbDenominacion As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents tbGrupoEquivalencia As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents tbNombreMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents tbMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Farmacia_MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador
    Friend WithEvents FarmaceuticoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador
End Class
