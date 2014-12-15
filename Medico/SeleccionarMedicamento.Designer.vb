<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarMedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeleccionarMedicamento))
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        Me.TablaMedicamento = New System.Windows.Forms.DataGridView()
        Me.CNMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DenominacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroEnvaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentoDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbRecetaElectronica = New RecetaElectronica.dbRecetaElectronica()
        CType(Me.TablaMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentoDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicamentoAdaptador
        '
        Me.MedicamentoAdaptador.ClearBeforeFill = True
        '
        'TablaMedicamento
        '
        Me.TablaMedicamento.AllowUserToAddRows = False
        Me.TablaMedicamento.AllowUserToDeleteRows = False
        Me.TablaMedicamento.AllowUserToResizeColumns = False
        Me.TablaMedicamento.AllowUserToResizeRows = False
        Me.TablaMedicamento.AutoGenerateColumns = False
        Me.TablaMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaMedicamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNMedicamentoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DenominacionDataGridViewTextBoxColumn, Me.GrupoEquivalenciaDataGridViewTextBoxColumn, Me.DosisDataGridViewTextBoxColumn, Me.ViaDataGridViewTextBoxColumn, Me.FormatoDataGridViewTextBoxColumn, Me.NumeroEnvaseDataGridViewTextBoxColumn})
        Me.TablaMedicamento.DataSource = Me.MedicamentoDatos
        Me.TablaMedicamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablaMedicamento.Location = New System.Drawing.Point(0, 0)
        Me.TablaMedicamento.Name = "TablaMedicamento"
        Me.TablaMedicamento.ReadOnly = True
        Me.TablaMedicamento.RowHeadersVisible = False
        Me.TablaMedicamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TablaMedicamento.Size = New System.Drawing.Size(804, 389)
        Me.TablaMedicamento.TabIndex = 0
        '
        'CNMedicamentoDataGridViewTextBoxColumn
        '
        Me.CNMedicamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CNMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "CNMedicamento"
        Me.CNMedicamentoDataGridViewTextBoxColumn.HeaderText = "Núm. Medicamento"
        Me.CNMedicamentoDataGridViewTextBoxColumn.Name = "CNMedicamentoDataGridViewTextBoxColumn"
        Me.CNMedicamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CNMedicamentoDataGridViewTextBoxColumn.Width = 114
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 69
        '
        'DenominacionDataGridViewTextBoxColumn
        '
        Me.DenominacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DenominacionDataGridViewTextBoxColumn.DataPropertyName = "Denominacion"
        Me.DenominacionDataGridViewTextBoxColumn.HeaderText = "Denominación"
        Me.DenominacionDataGridViewTextBoxColumn.Name = "DenominacionDataGridViewTextBoxColumn"
        Me.DenominacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GrupoEquivalenciaDataGridViewTextBoxColumn
        '
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.DataPropertyName = "GrupoEquivalencia"
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.HeaderText = "Grupo Equivalencia"
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.Name = "GrupoEquivalenciaDataGridViewTextBoxColumn"
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.Width = 114
        '
        'DosisDataGridViewTextBoxColumn
        '
        Me.DosisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DosisDataGridViewTextBoxColumn.DataPropertyName = "Dosis"
        Me.DosisDataGridViewTextBoxColumn.HeaderText = "Dosis"
        Me.DosisDataGridViewTextBoxColumn.Name = "DosisDataGridViewTextBoxColumn"
        Me.DosisDataGridViewTextBoxColumn.ReadOnly = True
        Me.DosisDataGridViewTextBoxColumn.Width = 58
        '
        'ViaDataGridViewTextBoxColumn
        '
        Me.ViaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ViaDataGridViewTextBoxColumn.DataPropertyName = "Via"
        Me.ViaDataGridViewTextBoxColumn.HeaderText = "Vía"
        Me.ViaDataGridViewTextBoxColumn.Name = "ViaDataGridViewTextBoxColumn"
        Me.ViaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ViaDataGridViewTextBoxColumn.Width = 49
        '
        'FormatoDataGridViewTextBoxColumn
        '
        Me.FormatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FormatoDataGridViewTextBoxColumn.DataPropertyName = "Formato"
        Me.FormatoDataGridViewTextBoxColumn.HeaderText = "Formato"
        Me.FormatoDataGridViewTextBoxColumn.Name = "FormatoDataGridViewTextBoxColumn"
        Me.FormatoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FormatoDataGridViewTextBoxColumn.Width = 70
        '
        'NumeroEnvaseDataGridViewTextBoxColumn
        '
        Me.NumeroEnvaseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroEnvaseDataGridViewTextBoxColumn.DataPropertyName = "NumeroEnvase"
        Me.NumeroEnvaseDataGridViewTextBoxColumn.HeaderText = "Número Envase"
        Me.NumeroEnvaseDataGridViewTextBoxColumn.Name = "NumeroEnvaseDataGridViewTextBoxColumn"
        Me.NumeroEnvaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroEnvaseDataGridViewTextBoxColumn.Width = 99
        '
        'MedicamentoDatos
        '
        Me.MedicamentoDatos.DataMember = "Medicamento"
        Me.MedicamentoDatos.DataSource = Me.dbRecetaElectronica
        '
        'dbRecetaElectronica
        '
        Me.dbRecetaElectronica.DataSetName = "dbRecetaElectronica"
        Me.dbRecetaElectronica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SeleccionarMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 389)
        Me.Controls.Add(Me.TablaMedicamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SeleccionarMedicamento"
        Me.Text = "Seleccionar Medicamento"
        CType(Me.TablaMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentoDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents TablaMedicamento As System.Windows.Forms.DataGridView
    Friend WithEvents MedicamentoDatos As System.Windows.Forms.BindingSource
    Friend WithEvents dbRecetaElectronica As RecetaElectronica.dbRecetaElectronica
    Friend WithEvents CNMedicamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DenominacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoEquivalenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DosisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroEnvaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
