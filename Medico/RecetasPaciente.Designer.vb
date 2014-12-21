<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecetasPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecetasPaciente))
        Me.TablaRecetas = New System.Windows.Forms.DataGridView()
        Me.MedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DispensadaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RecetaDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbRecetaElectronica = New RecetaElectronica.dbRecetaElectronica()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me._dtpFechaReceta = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me._tbEnvase = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me._tbFormato = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me._tbVia = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me._tbDosis = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me._tbDenominacion = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me._tbEquivalencia = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me._tbNombreMed = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me._tbNumeroMed = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusMedicamento = New System.Windows.Forms.ToolStripStatusLabel()
        Me.actualizarMed = New System.ComponentModel.BackgroundWorker()
        Me.RecetaAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador()
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        CType(Me.TablaRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TablaRecetas
        '
        Me.TablaRecetas.AllowUserToAddRows = False
        Me.TablaRecetas.AllowUserToDeleteRows = False
        Me.TablaRecetas.AllowUserToResizeColumns = False
        Me.TablaRecetas.AllowUserToResizeRows = False
        Me.TablaRecetas.AutoGenerateColumns = False
        Me.TablaRecetas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TablaRecetas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TablaRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaRecetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicamentoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.DispensadaDataGridViewTextBoxColumn})
        Me.TablaRecetas.DataSource = Me.RecetaDatos
        Me.TablaRecetas.Dock = System.Windows.Forms.DockStyle.Top
        Me.TablaRecetas.Location = New System.Drawing.Point(0, 0)
        Me.TablaRecetas.Name = "TablaRecetas"
        Me.TablaRecetas.ReadOnly = True
        Me.TablaRecetas.RowHeadersVisible = False
        Me.TablaRecetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaRecetas.Size = New System.Drawing.Size(540, 189)
        Me.TablaRecetas.TabIndex = 0
        '
        'MedicamentoDataGridViewTextBoxColumn
        '
        Me.MedicamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MedicamentoDataGridViewTextBoxColumn.DataPropertyName = "Medicamento"
        Me.MedicamentoDataGridViewTextBoxColumn.HeaderText = "Medicamento"
        Me.MedicamentoDataGridViewTextBoxColumn.Name = "MedicamentoDataGridViewTextBoxColumn"
        Me.MedicamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DispensadaDataGridViewTextBoxColumn
        '
        Me.DispensadaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DispensadaDataGridViewTextBoxColumn.DataPropertyName = "Dispensada"
        Me.DispensadaDataGridViewTextBoxColumn.HeaderText = "Dispensada"
        Me.DispensadaDataGridViewTextBoxColumn.Name = "DispensadaDataGridViewTextBoxColumn"
        Me.DispensadaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DispensadaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DispensadaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'RecetaDatos
        '
        Me.RecetaDatos.DataMember = "Receta"
        Me.RecetaDatos.DataSource = Me.dbRecetaElectronica
        '
        'dbRecetaElectronica
        '
        Me.dbRecetaElectronica.DataSetName = "dbRecetaElectronica"
        Me.dbRecetaElectronica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me._dtpFechaReceta)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me._tbEnvase)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me._tbFormato)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me._tbVia)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me._tbDosis)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me._tbDenominacion)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me._tbEquivalencia)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me._tbNombreMed)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me._tbNumeroMed)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(517, 94)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Medicamento"
        '
        '_dtpFechaReceta
        '
        Me._dtpFechaReceta.Enabled = False
        Me._dtpFechaReceta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me._dtpFechaReceta.Location = New System.Drawing.Point(395, 65)
        Me._dtpFechaReceta.Name = "_dtpFechaReceta"
        Me._dtpFechaReceta.Size = New System.Drawing.Size(115, 20)
        Me._dtpFechaReceta.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(349, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Fecha:"
        '
        '_tbEnvase
        '
        Me._tbEnvase.Location = New System.Drawing.Point(243, 65)
        Me._tbEnvase.Name = "_tbEnvase"
        Me._tbEnvase.ReadOnly = True
        Me._tbEnvase.Size = New System.Drawing.Size(100, 20)
        Me._tbEnvase.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(163, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Núm. Envase:"
        '
        '_tbFormato
        '
        Me._tbFormato.Location = New System.Drawing.Point(57, 65)
        Me._tbFormato.Name = "_tbFormato"
        Me._tbFormato.ReadOnly = True
        Me._tbFormato.Size = New System.Drawing.Size(100, 20)
        Me._tbFormato.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Formato:"
        '
        '_tbVia
        '
        Me._tbVia.Location = New System.Drawing.Point(375, 39)
        Me._tbVia.Name = "_tbVia"
        Me._tbVia.ReadOnly = True
        Me._tbVia.Size = New System.Drawing.Size(100, 20)
        Me._tbVia.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(342, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(27, 13)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "Vía:"
        '
        '_tbDosis
        '
        Me._tbDosis.Location = New System.Drawing.Point(235, 39)
        Me._tbDosis.Name = "_tbDosis"
        Me._tbDosis.ReadOnly = True
        Me._tbDosis.Size = New System.Drawing.Size(100, 20)
        Me._tbDosis.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(193, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Dosis:"
        '
        '_tbDenominacion
        '
        Me._tbDenominacion.Location = New System.Drawing.Point(87, 39)
        Me._tbDenominacion.Name = "_tbDenominacion"
        Me._tbDenominacion.ReadOnly = True
        Me._tbDenominacion.Size = New System.Drawing.Size(100, 20)
        Me._tbDenominacion.TabIndex = 7
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Denominación:"
        '
        '_tbEquivalencia
        '
        Me._tbEquivalencia.Location = New System.Drawing.Point(427, 13)
        Me._tbEquivalencia.Name = "_tbEquivalencia"
        Me._tbEquivalencia.ReadOnly = True
        Me._tbEquivalencia.Size = New System.Drawing.Size(83, 20)
        Me._tbEquivalencia.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(363, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 13)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Grupo Eq.:"
        '
        '_tbNombreMed
        '
        Me._tbNombreMed.Location = New System.Drawing.Point(257, 13)
        Me._tbNombreMed.Name = "_tbNombreMed"
        Me._tbNombreMed.ReadOnly = True
        Me._tbNombreMed.Size = New System.Drawing.Size(100, 20)
        Me._tbNombreMed.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(204, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 13)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "Nombre:"
        '
        '_tbNumeroMed
        '
        Me._tbNumeroMed.Location = New System.Drawing.Point(98, 13)
        Me._tbNumeroMed.Name = "_tbNumeroMed"
        Me._tbNumeroMed.ReadOnly = True
        Me._tbNumeroMed.Size = New System.Drawing.Size(100, 20)
        Me._tbNumeroMed.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(4, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "N. Medicamento:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusMedicamento})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 296)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(540, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusMedicamento
        '
        Me.statusMedicamento.Name = "statusMedicamento"
        Me.statusMedicamento.Size = New System.Drawing.Size(112, 17)
        Me.statusMedicamento.Text = "statusMedicamento"
        '
        'actualizarMed
        '
        '
        'RecetaAdaptador
        '
        Me.RecetaAdaptador.ClearBeforeFill = True
        '
        'MedicamentoAdaptador
        '
        Me.MedicamentoAdaptador.ClearBeforeFill = True
        '
        'RecetasPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 318)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TablaRecetas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RecetasPaciente"
        Me.Text = "Recetas Paciente"
        CType(Me.TablaRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TablaRecetas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents _dtpFechaReceta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents _tbEnvase As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents _tbFormato As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents _tbVia As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents _tbDosis As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents _tbDenominacion As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents _tbEquivalencia As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents _tbNombreMed As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents _tbNumeroMed As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dbRecetaElectronica As RecetaElectronica.dbRecetaElectronica
    Friend WithEvents RecetaDatos As System.Windows.Forms.BindingSource
    Friend WithEvents RecetaAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statusMedicamento As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents actualizarMed As System.ComponentModel.BackgroundWorker
    Friend WithEvents MedicamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DispensadaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
