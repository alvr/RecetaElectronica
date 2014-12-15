<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicamentoEquivalente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicamentoEquivalente))
        Me.dgvMedicamentosEquivalentes = New System.Windows.Forms.DataGridView()
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        Me.tbFiltrarMedicamentos = New System.Windows.Forms.TextBox()
        Me.Farmacia_MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador()
        Me.FarmaceuticoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador()
        Me.RecetaAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador()
        CType(Me.dgvMedicamentosEquivalentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMedicamentosEquivalentes
        '
        Me.dgvMedicamentosEquivalentes.AllowUserToAddRows = False
        Me.dgvMedicamentosEquivalentes.AllowUserToDeleteRows = False
        Me.dgvMedicamentosEquivalentes.AllowUserToResizeColumns = False
        Me.dgvMedicamentosEquivalentes.AllowUserToResizeRows = False
        Me.dgvMedicamentosEquivalentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedicamentosEquivalentes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMedicamentosEquivalentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicamentosEquivalentes.Location = New System.Drawing.Point(0, 0)
        Me.dgvMedicamentosEquivalentes.Name = "dgvMedicamentosEquivalentes"
        Me.dgvMedicamentosEquivalentes.ReadOnly = True
        Me.dgvMedicamentosEquivalentes.RowHeadersVisible = False
        Me.dgvMedicamentosEquivalentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicamentosEquivalentes.Size = New System.Drawing.Size(661, 320)
        Me.dgvMedicamentosEquivalentes.TabIndex = 0
        '
        'MedicamentoAdaptador
        '
        Me.MedicamentoAdaptador.ClearBeforeFill = True
        '
        'tbFiltrarMedicamentos
        '
        Me.tbFiltrarMedicamentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFiltrarMedicamentos.Location = New System.Drawing.Point(12, 326)
        Me.tbFiltrarMedicamentos.Name = "tbFiltrarMedicamentos"
        Me.tbFiltrarMedicamentos.Size = New System.Drawing.Size(637, 20)
        Me.tbFiltrarMedicamentos.TabIndex = 1
        '
        'Farmacia_MedicamentoAdaptador
        '
        Me.Farmacia_MedicamentoAdaptador.ClearBeforeFill = True
        '
        'FarmaceuticoAdaptador
        '
        Me.FarmaceuticoAdaptador.ClearBeforeFill = True
        '
        'RecetaAdaptador
        '
        Me.RecetaAdaptador.ClearBeforeFill = True
        '
        'MedicamentoEquivalente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 351)
        Me.Controls.Add(Me.tbFiltrarMedicamentos)
        Me.Controls.Add(Me.dgvMedicamentosEquivalentes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MedicamentoEquivalente"
        Me.Text = "Seleccionar Medicamento Equivalente"
        CType(Me.dgvMedicamentosEquivalentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMedicamentosEquivalentes As System.Windows.Forms.DataGridView
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents Farmacia_MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador
    Friend WithEvents FarmaceuticoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador
    Friend WithEvents tbFiltrarMedicamentos As System.Windows.Forms.TextBox
    Friend WithEvents RecetaAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador
End Class
