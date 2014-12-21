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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeleccionarMedicamento))
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        Me.dgvMedicamentos = New System.Windows.Forms.DataGridView()
        Me.CNMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DenominacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroEnvaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posologia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentoDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbRecetaElectronica = New RecetaElectronica.dbRecetaElectronica()
        Me.tbFiltrarMedicamentos = New System.Windows.Forms.TextBox()
        Me.cbFiltroMedicamentos = New System.Windows.Forms.ComboBox()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentoDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicamentoAdaptador
        '
        Me.MedicamentoAdaptador.ClearBeforeFill = True
        '
        'dgvMedicamentos
        '
        Me.dgvMedicamentos.AllowUserToAddRows = False
        Me.dgvMedicamentos.AllowUserToDeleteRows = False
        Me.dgvMedicamentos.AllowUserToResizeColumns = False
        Me.dgvMedicamentos.AllowUserToResizeRows = False
        Me.dgvMedicamentos.AutoGenerateColumns = False
        Me.dgvMedicamentos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedicamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNMedicamentoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DenominacionDataGridViewTextBoxColumn, Me.GrupoEquivalenciaDataGridViewTextBoxColumn, Me.DosisDataGridViewTextBoxColumn, Me.ViaDataGridViewTextBoxColumn, Me.FormatoDataGridViewTextBoxColumn, Me.NumeroEnvaseDataGridViewTextBoxColumn, Me.Posologia, Me.Precio})
        Me.dgvMedicamentos.DataSource = Me.MedicamentoDatos
        Me.dgvMedicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvMedicamentos.Location = New System.Drawing.Point(0, 0)
        Me.dgvMedicamentos.Name = "dgvMedicamentos"
        Me.dgvMedicamentos.ReadOnly = True
        Me.dgvMedicamentos.RowHeadersVisible = False
        Me.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicamentos.Size = New System.Drawing.Size(804, 351)
        Me.dgvMedicamentos.TabIndex = 0
        '
        'CNMedicamentoDataGridViewTextBoxColumn
        '
        Me.CNMedicamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CNMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "CNMedicamento"
        Me.CNMedicamentoDataGridViewTextBoxColumn.HeaderText = "Núm. Medicamento"
        Me.CNMedicamentoDataGridViewTextBoxColumn.Name = "CNMedicamentoDataGridViewTextBoxColumn"
        Me.CNMedicamentoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CNMedicamentoDataGridViewTextBoxColumn.Width = 124
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
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.Width = 125
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
        Me.NumeroEnvaseDataGridViewTextBoxColumn.Width = 108
        '
        'Posologia
        '
        Me.Posologia.DataPropertyName = "Posologia"
        Me.Posologia.HeaderText = "Posología"
        Me.Posologia.Name = "Posologia"
        Me.Posologia.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "Precio"
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
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
        'tbFiltrarMedicamentos
        '
        Me.tbFiltrarMedicamentos.Location = New System.Drawing.Point(12, 357)
        Me.tbFiltrarMedicamentos.Name = "tbFiltrarMedicamentos"
        Me.tbFiltrarMedicamentos.Size = New System.Drawing.Size(653, 20)
        Me.tbFiltrarMedicamentos.TabIndex = 1
        '
        'cbFiltroMedicamentos
        '
        Me.cbFiltroMedicamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFiltroMedicamentos.FormattingEnabled = True
        Me.cbFiltroMedicamentos.Items.AddRange(New Object() {"Número Medicamento", "Nombre Medicamento"})
        Me.cbFiltroMedicamentos.Location = New System.Drawing.Point(671, 357)
        Me.cbFiltroMedicamentos.Name = "cbFiltroMedicamentos"
        Me.cbFiltroMedicamentos.Size = New System.Drawing.Size(121, 21)
        Me.cbFiltroMedicamentos.TabIndex = 2
        '
        'SeleccionarMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 389)
        Me.Controls.Add(Me.cbFiltroMedicamentos)
        Me.Controls.Add(Me.tbFiltrarMedicamentos)
        Me.Controls.Add(Me.dgvMedicamentos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SeleccionarMedicamento"
        Me.Text = "Seleccionar Medicamento"
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentoDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents dgvMedicamentos As System.Windows.Forms.DataGridView
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
    Friend WithEvents Posologia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbFiltrarMedicamentos As System.Windows.Forms.TextBox
    Friend WithEvents cbFiltroMedicamentos As System.Windows.Forms.ComboBox
End Class
