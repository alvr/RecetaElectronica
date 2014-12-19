<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracion
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administracion))
        Me.MedicoDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbRecetaElectronica = New RecetaElectronica.dbRecetaElectronica()
        Me.FarmaceuticoDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacienteDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicamentoDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmbulatorioDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmaciaDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicoAdaptador()
        Me.FarmaceuticoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador()
        Me.PacienteAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador()
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        Me.AmbulatorioAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.AmbulatorioAdaptador()
        Me.FarmaciaAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaciaAdaptador()
        Me.btnActDatos = New System.Windows.Forms.Button()
        Me.tcAdministracion = New System.Windows.Forms.TabControl()
        Me.tpMedicos = New System.Windows.Forms.TabPage()
        Me.dgvMedicos = New System.Windows.Forms.DataGridView()
        Me.NumeroFacultativoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirmaElectronicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CualificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LugarTrabajoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpFarmaceuticos = New System.Windows.Forms.TabPage()
        Me.dgvFarmaceuticos = New System.Windows.Forms.DataGridView()
        Me.NumeroColegiadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UltimoRegistroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroFarmaciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpPacientes = New System.Windows.Forms.TabPage()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CronicoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ExentoAportacion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BaremoEconomicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SituacionLaboralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EntidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Acumulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistorialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpMedicamentos = New System.Windows.Forms.TabPage()
        Me.dgvMedicamentos = New System.Windows.Forms.DataGridView()
        Me.CNMedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DenominacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DosisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroEnvaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posologia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpAmbulatorios = New System.Windows.Forms.TabPage()
        Me.dgvAmbulatorios = New System.Windows.Forms.DataGridView()
        Me.IdAmbulatorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpFarmacias = New System.Windows.Forms.TabPage()
        Me.dgvFarmacias = New System.Windows.Forms.DataGridView()
        Me.IdFarmaciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconosPestañas = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.MedicoDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmaceuticoDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacienteDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicamentoDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmbulatorioDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmaciaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcAdministracion.SuspendLayout()
        Me.tpMedicos.SuspendLayout()
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFarmaceuticos.SuspendLayout()
        CType(Me.dgvFarmaceuticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPacientes.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMedicamentos.SuspendLayout()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAmbulatorios.SuspendLayout()
        CType(Me.dgvAmbulatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpFarmacias.SuspendLayout()
        CType(Me.dgvFarmacias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedicoDatos
        '
        Me.MedicoDatos.DataMember = "Medico"
        Me.MedicoDatos.DataSource = Me.dbRecetaElectronica
        '
        'dbRecetaElectronica
        '
        Me.dbRecetaElectronica.DataSetName = "dbRecetaElectronica"
        Me.dbRecetaElectronica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FarmaceuticoDatos
        '
        Me.FarmaceuticoDatos.DataMember = "Farmaceutico"
        Me.FarmaceuticoDatos.DataSource = Me.dbRecetaElectronica
        '
        'PacienteDatos
        '
        Me.PacienteDatos.DataMember = "Paciente"
        Me.PacienteDatos.DataSource = Me.dbRecetaElectronica
        '
        'MedicamentoDatos
        '
        Me.MedicamentoDatos.DataMember = "Medicamento"
        Me.MedicamentoDatos.DataSource = Me.dbRecetaElectronica
        '
        'AmbulatorioDatos
        '
        Me.AmbulatorioDatos.DataMember = "Ambulatorio"
        Me.AmbulatorioDatos.DataSource = Me.dbRecetaElectronica
        '
        'FarmaciaDatos
        '
        Me.FarmaciaDatos.DataMember = "Farmacia"
        Me.FarmaciaDatos.DataSource = Me.dbRecetaElectronica
        '
        'MedicoAdaptador
        '
        Me.MedicoAdaptador.ClearBeforeFill = True
        '
        'FarmaceuticoAdaptador
        '
        Me.FarmaceuticoAdaptador.ClearBeforeFill = True
        '
        'PacienteAdaptador
        '
        Me.PacienteAdaptador.ClearBeforeFill = True
        '
        'MedicamentoAdaptador
        '
        Me.MedicamentoAdaptador.ClearBeforeFill = True
        '
        'AmbulatorioAdaptador
        '
        Me.AmbulatorioAdaptador.ClearBeforeFill = True
        '
        'FarmaciaAdaptador
        '
        Me.FarmaciaAdaptador.ClearBeforeFill = True
        '
        'btnActDatos
        '
        Me.btnActDatos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActDatos.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActDatos.Location = New System.Drawing.Point(12, 367)
        Me.btnActDatos.Name = "btnActDatos"
        Me.btnActDatos.Size = New System.Drawing.Size(815, 37)
        Me.btnActDatos.TabIndex = 1
        Me.btnActDatos.Text = "Actualizar Datos"
        Me.btnActDatos.UseVisualStyleBackColor = True
        '
        'tcAdministracion
        '
        Me.tcAdministracion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcAdministracion.Controls.Add(Me.tpMedicos)
        Me.tcAdministracion.Controls.Add(Me.tpFarmaceuticos)
        Me.tcAdministracion.Controls.Add(Me.tpPacientes)
        Me.tcAdministracion.Controls.Add(Me.tpMedicamentos)
        Me.tcAdministracion.Controls.Add(Me.tpAmbulatorios)
        Me.tcAdministracion.Controls.Add(Me.tpFarmacias)
        Me.tcAdministracion.ImageList = Me.IconosPestañas
        Me.tcAdministracion.Location = New System.Drawing.Point(0, 0)
        Me.tcAdministracion.Name = "tcAdministracion"
        Me.tcAdministracion.SelectedIndex = 0
        Me.tcAdministracion.Size = New System.Drawing.Size(839, 361)
        Me.tcAdministracion.TabIndex = 2
        '
        'tpMedicos
        '
        Me.tpMedicos.Controls.Add(Me.dgvMedicos)
        Me.tpMedicos.ImageIndex = 0
        Me.tpMedicos.Location = New System.Drawing.Point(4, 23)
        Me.tpMedicos.Name = "tpMedicos"
        Me.tpMedicos.Size = New System.Drawing.Size(831, 334)
        Me.tpMedicos.TabIndex = 6
        Me.tpMedicos.Text = "Médicos"
        Me.tpMedicos.UseVisualStyleBackColor = True
        '
        'dgvMedicos
        '
        Me.dgvMedicos.AllowUserToResizeColumns = False
        Me.dgvMedicos.AllowUserToResizeRows = False
        Me.dgvMedicos.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroFacultativoDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn1, Me.ApellidosDataGridViewTextBoxColumn1, Me.DNIDataGridViewTextBoxColumn1, Me.FirmaElectronicaDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.CualificacionDataGridViewTextBoxColumn, Me.LugarTrabajoDataGridViewTextBoxColumn})
        Me.dgvMedicos.DataSource = Me.MedicoDatos
        Me.dgvMedicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMedicos.Location = New System.Drawing.Point(0, 0)
        Me.dgvMedicos.Name = "dgvMedicos"
        Me.dgvMedicos.RowHeadersVisible = False
        Me.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicos.Size = New System.Drawing.Size(831, 334)
        Me.dgvMedicos.TabIndex = 0
        '
        'NumeroFacultativoDataGridViewTextBoxColumn
        '
        Me.NumeroFacultativoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroFacultativoDataGridViewTextBoxColumn.DataPropertyName = "NumeroFacultativo"
        Me.NumeroFacultativoDataGridViewTextBoxColumn.HeaderText = "Número Facultativo"
        Me.NumeroFacultativoDataGridViewTextBoxColumn.Name = "NumeroFacultativoDataGridViewTextBoxColumn"
        Me.NumeroFacultativoDataGridViewTextBoxColumn.Width = 124
        '
        'PasswordDataGridViewTextBoxColumn1
        '
        Me.PasswordDataGridViewTextBoxColumn1.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn1.HeaderText = "Contraseña"
        Me.PasswordDataGridViewTextBoxColumn1.Name = "PasswordDataGridViewTextBoxColumn1"
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        '
        'ApellidosDataGridViewTextBoxColumn1
        '
        Me.ApellidosDataGridViewTextBoxColumn1.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn1.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn1.Name = "ApellidosDataGridViewTextBoxColumn1"
        '
        'DNIDataGridViewTextBoxColumn1
        '
        Me.DNIDataGridViewTextBoxColumn1.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn1.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn1.Name = "DNIDataGridViewTextBoxColumn1"
        '
        'FirmaElectronicaDataGridViewTextBoxColumn
        '
        Me.FirmaElectronicaDataGridViewTextBoxColumn.DataPropertyName = "FirmaElectronica"
        Me.FirmaElectronicaDataGridViewTextBoxColumn.HeaderText = "Firma Electrónica"
        Me.FirmaElectronicaDataGridViewTextBoxColumn.Name = "FirmaElectronicaDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        '
        'CualificacionDataGridViewTextBoxColumn
        '
        Me.CualificacionDataGridViewTextBoxColumn.DataPropertyName = "Cualificacion"
        Me.CualificacionDataGridViewTextBoxColumn.HeaderText = "Cualificación"
        Me.CualificacionDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Médico", "Odontólogo", "Podólogo", "Enfermero"})
        Me.CualificacionDataGridViewTextBoxColumn.Name = "CualificacionDataGridViewTextBoxColumn"
        Me.CualificacionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CualificacionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'LugarTrabajoDataGridViewTextBoxColumn
        '
        Me.LugarTrabajoDataGridViewTextBoxColumn.DataPropertyName = "LugarTrabajo"
        Me.LugarTrabajoDataGridViewTextBoxColumn.HeaderText = "Lugar de Trabajo"
        Me.LugarTrabajoDataGridViewTextBoxColumn.Name = "LugarTrabajoDataGridViewTextBoxColumn"
        '
        'tpFarmaceuticos
        '
        Me.tpFarmaceuticos.Controls.Add(Me.dgvFarmaceuticos)
        Me.tpFarmaceuticos.ImageIndex = 1
        Me.tpFarmaceuticos.Location = New System.Drawing.Point(4, 23)
        Me.tpFarmaceuticos.Name = "tpFarmaceuticos"
        Me.tpFarmaceuticos.Size = New System.Drawing.Size(831, 334)
        Me.tpFarmaceuticos.TabIndex = 7
        Me.tpFarmaceuticos.Text = "Farmacéuticos"
        Me.tpFarmaceuticos.UseVisualStyleBackColor = True
        '
        'dgvFarmaceuticos
        '
        Me.dgvFarmaceuticos.AllowUserToResizeColumns = False
        Me.dgvFarmaceuticos.AllowUserToResizeRows = False
        Me.dgvFarmaceuticos.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFarmaceuticos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFarmaceuticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFarmaceuticos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroColegiadoDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.UltimoRegistroDataGridViewTextBoxColumn, Me.NumeroFarmaciaDataGridViewTextBoxColumn})
        Me.dgvFarmaceuticos.DataSource = Me.FarmaceuticoDatos
        Me.dgvFarmaceuticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFarmaceuticos.Location = New System.Drawing.Point(0, 0)
        Me.dgvFarmaceuticos.Name = "dgvFarmaceuticos"
        Me.dgvFarmaceuticos.RowHeadersVisible = False
        Me.dgvFarmaceuticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFarmaceuticos.Size = New System.Drawing.Size(831, 334)
        Me.dgvFarmaceuticos.TabIndex = 0
        '
        'NumeroColegiadoDataGridViewTextBoxColumn
        '
        Me.NumeroColegiadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumeroColegiadoDataGridViewTextBoxColumn.DataPropertyName = "NumeroColegiado"
        Me.NumeroColegiadoDataGridViewTextBoxColumn.HeaderText = "Número Colegiado"
        Me.NumeroColegiadoDataGridViewTextBoxColumn.Name = "NumeroColegiadoDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        '
        'UltimoRegistroDataGridViewTextBoxColumn
        '
        Me.UltimoRegistroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UltimoRegistroDataGridViewTextBoxColumn.DataPropertyName = "UltimoRegistro"
        Me.UltimoRegistroDataGridViewTextBoxColumn.HeaderText = "Último Registro"
        Me.UltimoRegistroDataGridViewTextBoxColumn.Name = "UltimoRegistroDataGridViewTextBoxColumn"
        '
        'NumeroFarmaciaDataGridViewTextBoxColumn
        '
        Me.NumeroFarmaciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumeroFarmaciaDataGridViewTextBoxColumn.DataPropertyName = "NumeroFarmacia"
        Me.NumeroFarmaciaDataGridViewTextBoxColumn.HeaderText = "Número Farmacia"
        Me.NumeroFarmaciaDataGridViewTextBoxColumn.Name = "NumeroFarmaciaDataGridViewTextBoxColumn"
        '
        'tpPacientes
        '
        Me.tpPacientes.Controls.Add(Me.dgvPacientes)
        Me.tpPacientes.ImageIndex = 2
        Me.tpPacientes.Location = New System.Drawing.Point(4, 23)
        Me.tpPacientes.Name = "tpPacientes"
        Me.tpPacientes.Size = New System.Drawing.Size(831, 334)
        Me.tpPacientes.TabIndex = 2
        Me.tpPacientes.Text = "Pacientes"
        Me.tpPacientes.UseVisualStyleBackColor = True
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToResizeColumns = False
        Me.dgvPacientes.AllowUserToResizeRows = False
        Me.dgvPacientes.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn2, Me.ApellidosDataGridViewTextBoxColumn2, Me.DNIDataGridViewTextBoxColumn2, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.CronicoDataGridViewCheckBoxColumn, Me.ExentoAportacion, Me.BaremoEconomicoDataGridViewTextBoxColumn, Me.SituacionLaboralDataGridViewTextBoxColumn, Me.EntidadDataGridViewTextBoxColumn, Me.Acumulado, Me.HistorialDataGridViewTextBoxColumn})
        Me.dgvPacientes.DataSource = Me.PacienteDatos
        Me.dgvPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPacientes.Location = New System.Drawing.Point(0, 0)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.RowHeadersVisible = False
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(831, 334)
        Me.dgvPacientes.TabIndex = 0
        '
        'NumeroTarjetaSanitariaDataGridViewTextBoxColumn
        '
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn.DataPropertyName = "NumeroTarjetaSanitaria"
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn.HeaderText = "Tarjeta Sanitaria"
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn.Name = "NumeroTarjetaSanitariaDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn2
        '
        Me.NombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn2.Name = "NombreDataGridViewTextBoxColumn2"
        '
        'ApellidosDataGridViewTextBoxColumn2
        '
        Me.ApellidosDataGridViewTextBoxColumn2.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn2.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn2.Name = "ApellidosDataGridViewTextBoxColumn2"
        '
        'DNIDataGridViewTextBoxColumn2
        '
        Me.DNIDataGridViewTextBoxColumn2.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn2.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn2.Name = "DNIDataGridViewTextBoxColumn2"
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        '
        'CronicoDataGridViewCheckBoxColumn
        '
        Me.CronicoDataGridViewCheckBoxColumn.DataPropertyName = "Cronico"
        Me.CronicoDataGridViewCheckBoxColumn.HeaderText = "Crónico"
        Me.CronicoDataGridViewCheckBoxColumn.Name = "CronicoDataGridViewCheckBoxColumn"
        '
        'ExentoAportacion
        '
        Me.ExentoAportacion.DataPropertyName = "ExentoAportacion"
        Me.ExentoAportacion.HeaderText = "Exento Aportación"
        Me.ExentoAportacion.Name = "ExentoAportacion"
        '
        'BaremoEconomicoDataGridViewTextBoxColumn
        '
        Me.BaremoEconomicoDataGridViewTextBoxColumn.DataPropertyName = "BaremoEconomico"
        Me.BaremoEconomicoDataGridViewTextBoxColumn.HeaderText = "Baremo Económico"
        Me.BaremoEconomicoDataGridViewTextBoxColumn.Items.AddRange(New Object() {"<18.000", "18.000-100.000", ">100.000"})
        Me.BaremoEconomicoDataGridViewTextBoxColumn.Name = "BaremoEconomicoDataGridViewTextBoxColumn"
        Me.BaremoEconomicoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BaremoEconomicoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SituacionLaboralDataGridViewTextBoxColumn
        '
        Me.SituacionLaboralDataGridViewTextBoxColumn.DataPropertyName = "SituacionLaboral"
        Me.SituacionLaboralDataGridViewTextBoxColumn.HeaderText = "Situación Laboral"
        Me.SituacionLaboralDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Activo", "Pensionista", "Parado", "Mutualidad"})
        Me.SituacionLaboralDataGridViewTextBoxColumn.Name = "SituacionLaboralDataGridViewTextBoxColumn"
        Me.SituacionLaboralDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SituacionLaboralDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'EntidadDataGridViewTextBoxColumn
        '
        Me.EntidadDataGridViewTextBoxColumn.DataPropertyName = "Entidad"
        Me.EntidadDataGridViewTextBoxColumn.HeaderText = "Entidad"
        Me.EntidadDataGridViewTextBoxColumn.Items.AddRange(New Object() {"Seguridad Social", "Muface", "Isfas", "Mutualidad General Judicial"})
        Me.EntidadDataGridViewTextBoxColumn.Name = "EntidadDataGridViewTextBoxColumn"
        Me.EntidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EntidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Acumulado
        '
        Me.Acumulado.DataPropertyName = "Acumulado"
        Me.Acumulado.HeaderText = "Acumulado"
        Me.Acumulado.Name = "Acumulado"
        '
        'HistorialDataGridViewTextBoxColumn
        '
        Me.HistorialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HistorialDataGridViewTextBoxColumn.DataPropertyName = "Historial"
        Me.HistorialDataGridViewTextBoxColumn.HeaderText = "Historial"
        Me.HistorialDataGridViewTextBoxColumn.Name = "HistorialDataGridViewTextBoxColumn"
        '
        'tpMedicamentos
        '
        Me.tpMedicamentos.Controls.Add(Me.dgvMedicamentos)
        Me.tpMedicamentos.ImageIndex = 3
        Me.tpMedicamentos.Location = New System.Drawing.Point(4, 23)
        Me.tpMedicamentos.Name = "tpMedicamentos"
        Me.tpMedicamentos.Size = New System.Drawing.Size(831, 334)
        Me.tpMedicamentos.TabIndex = 3
        Me.tpMedicamentos.Text = "Medicamentos"
        Me.tpMedicamentos.UseVisualStyleBackColor = True
        '
        'dgvMedicamentos
        '
        Me.dgvMedicamentos.AllowUserToResizeColumns = False
        Me.dgvMedicamentos.AllowUserToResizeRows = False
        Me.dgvMedicamentos.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMedicamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNMedicamentoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn3, Me.DenominacionDataGridViewTextBoxColumn, Me.GrupoEquivalenciaDataGridViewTextBoxColumn, Me.DosisDataGridViewTextBoxColumn, Me.ViaDataGridViewTextBoxColumn, Me.FormatoDataGridViewTextBoxColumn, Me.NumeroEnvaseDataGridViewTextBoxColumn, Me.Posologia, Me.Precio})
        Me.dgvMedicamentos.DataSource = Me.MedicamentoDatos
        Me.dgvMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMedicamentos.Location = New System.Drawing.Point(0, 0)
        Me.dgvMedicamentos.Name = "dgvMedicamentos"
        Me.dgvMedicamentos.RowHeadersVisible = False
        Me.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicamentos.Size = New System.Drawing.Size(831, 334)
        Me.dgvMedicamentos.TabIndex = 0
        '
        'CNMedicamentoDataGridViewTextBoxColumn
        '
        Me.CNMedicamentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CNMedicamentoDataGridViewTextBoxColumn.DataPropertyName = "CNMedicamento"
        Me.CNMedicamentoDataGridViewTextBoxColumn.HeaderText = "Medicamento"
        Me.CNMedicamentoDataGridViewTextBoxColumn.Name = "CNMedicamentoDataGridViewTextBoxColumn"
        Me.CNMedicamentoDataGridViewTextBoxColumn.Width = 96
        '
        'NombreDataGridViewTextBoxColumn3
        '
        Me.NombreDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NombreDataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn3.Name = "NombreDataGridViewTextBoxColumn3"
        Me.NombreDataGridViewTextBoxColumn3.Width = 69
        '
        'DenominacionDataGridViewTextBoxColumn
        '
        Me.DenominacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DenominacionDataGridViewTextBoxColumn.DataPropertyName = "Denominacion"
        Me.DenominacionDataGridViewTextBoxColumn.HeaderText = "Denominación"
        Me.DenominacionDataGridViewTextBoxColumn.Name = "DenominacionDataGridViewTextBoxColumn"
        '
        'GrupoEquivalenciaDataGridViewTextBoxColumn
        '
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.DataPropertyName = "GrupoEquivalencia"
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.HeaderText = "Grupo Equivalencia"
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.Name = "GrupoEquivalenciaDataGridViewTextBoxColumn"
        Me.GrupoEquivalenciaDataGridViewTextBoxColumn.Width = 125
        '
        'DosisDataGridViewTextBoxColumn
        '
        Me.DosisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DosisDataGridViewTextBoxColumn.DataPropertyName = "Dosis"
        Me.DosisDataGridViewTextBoxColumn.HeaderText = "Dosis"
        Me.DosisDataGridViewTextBoxColumn.Name = "DosisDataGridViewTextBoxColumn"
        Me.DosisDataGridViewTextBoxColumn.Width = 58
        '
        'ViaDataGridViewTextBoxColumn
        '
        Me.ViaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ViaDataGridViewTextBoxColumn.DataPropertyName = "Via"
        Me.ViaDataGridViewTextBoxColumn.HeaderText = "Vía"
        Me.ViaDataGridViewTextBoxColumn.Name = "ViaDataGridViewTextBoxColumn"
        Me.ViaDataGridViewTextBoxColumn.Width = 49
        '
        'FormatoDataGridViewTextBoxColumn
        '
        Me.FormatoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FormatoDataGridViewTextBoxColumn.DataPropertyName = "Formato"
        Me.FormatoDataGridViewTextBoxColumn.HeaderText = "Formato"
        Me.FormatoDataGridViewTextBoxColumn.Name = "FormatoDataGridViewTextBoxColumn"
        Me.FormatoDataGridViewTextBoxColumn.Width = 70
        '
        'NumeroEnvaseDataGridViewTextBoxColumn
        '
        Me.NumeroEnvaseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroEnvaseDataGridViewTextBoxColumn.DataPropertyName = "NumeroEnvase"
        Me.NumeroEnvaseDataGridViewTextBoxColumn.HeaderText = "Número Envase"
        Me.NumeroEnvaseDataGridViewTextBoxColumn.Name = "NumeroEnvaseDataGridViewTextBoxColumn"
        Me.NumeroEnvaseDataGridViewTextBoxColumn.Width = 108
        '
        'Posologia
        '
        Me.Posologia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Posologia.DataPropertyName = "Posologia"
        Me.Posologia.HeaderText = "Posología"
        Me.Posologia.Name = "Posologia"
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Precio.DataPropertyName = "Precio"
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.Width = 62
        '
        'tpAmbulatorios
        '
        Me.tpAmbulatorios.Controls.Add(Me.dgvAmbulatorios)
        Me.tpAmbulatorios.ImageIndex = 4
        Me.tpAmbulatorios.Location = New System.Drawing.Point(4, 23)
        Me.tpAmbulatorios.Name = "tpAmbulatorios"
        Me.tpAmbulatorios.Size = New System.Drawing.Size(831, 334)
        Me.tpAmbulatorios.TabIndex = 4
        Me.tpAmbulatorios.Text = "Ambulatorios"
        Me.tpAmbulatorios.UseVisualStyleBackColor = True
        '
        'dgvAmbulatorios
        '
        Me.dgvAmbulatorios.AllowUserToResizeColumns = False
        Me.dgvAmbulatorios.AllowUserToResizeRows = False
        Me.dgvAmbulatorios.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAmbulatorios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAmbulatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAmbulatorios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAmbulatorioDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn1})
        Me.dgvAmbulatorios.DataSource = Me.AmbulatorioDatos
        Me.dgvAmbulatorios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAmbulatorios.Location = New System.Drawing.Point(0, 0)
        Me.dgvAmbulatorios.Name = "dgvAmbulatorios"
        Me.dgvAmbulatorios.RowHeadersVisible = False
        Me.dgvAmbulatorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAmbulatorios.Size = New System.Drawing.Size(831, 334)
        Me.dgvAmbulatorios.TabIndex = 0
        '
        'IdAmbulatorioDataGridViewTextBoxColumn
        '
        Me.IdAmbulatorioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdAmbulatorioDataGridViewTextBoxColumn.DataPropertyName = "idAmbulatorio"
        Me.IdAmbulatorioDataGridViewTextBoxColumn.HeaderText = "Ambulatorio"
        Me.IdAmbulatorioDataGridViewTextBoxColumn.Name = "IdAmbulatorioDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn1
        '
        Me.DireccionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DireccionDataGridViewTextBoxColumn1.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn1.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn1.Name = "DireccionDataGridViewTextBoxColumn1"
        '
        'tpFarmacias
        '
        Me.tpFarmacias.Controls.Add(Me.dgvFarmacias)
        Me.tpFarmacias.ImageIndex = 4
        Me.tpFarmacias.Location = New System.Drawing.Point(4, 23)
        Me.tpFarmacias.Name = "tpFarmacias"
        Me.tpFarmacias.Size = New System.Drawing.Size(831, 334)
        Me.tpFarmacias.TabIndex = 5
        Me.tpFarmacias.Text = "Farmacias"
        Me.tpFarmacias.UseVisualStyleBackColor = True
        '
        'dgvFarmacias
        '
        Me.dgvFarmacias.AllowUserToResizeColumns = False
        Me.dgvFarmacias.AllowUserToResizeRows = False
        Me.dgvFarmacias.AutoGenerateColumns = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFarmacias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvFarmacias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFarmacias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFarmaciaDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn2})
        Me.dgvFarmacias.DataSource = Me.FarmaciaDatos
        Me.dgvFarmacias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFarmacias.Location = New System.Drawing.Point(0, 0)
        Me.dgvFarmacias.Name = "dgvFarmacias"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFarmacias.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFarmacias.RowHeadersVisible = False
        Me.dgvFarmacias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFarmacias.Size = New System.Drawing.Size(831, 334)
        Me.dgvFarmacias.TabIndex = 0
        '
        'IdFarmaciaDataGridViewTextBoxColumn
        '
        Me.IdFarmaciaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdFarmaciaDataGridViewTextBoxColumn.DataPropertyName = "idFarmacia"
        Me.IdFarmaciaDataGridViewTextBoxColumn.HeaderText = "Farmacia"
        Me.IdFarmaciaDataGridViewTextBoxColumn.Name = "IdFarmaciaDataGridViewTextBoxColumn"
        '
        'DireccionDataGridViewTextBoxColumn2
        '
        Me.DireccionDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DireccionDataGridViewTextBoxColumn2.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn2.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn2.Name = "DireccionDataGridViewTextBoxColumn2"
        '
        'IconosPestañas
        '
        Me.IconosPestañas.ImageStream = CType(resources.GetObject("IconosPestañas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosPestañas.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosPestañas.Images.SetKeyName(0, "medicos.png")
        Me.IconosPestañas.Images.SetKeyName(1, "farmaceuticos.png")
        Me.IconosPestañas.Images.SetKeyName(2, "pacientes.png")
        Me.IconosPestañas.Images.SetKeyName(3, "medicamentos.png")
        Me.IconosPestañas.Images.SetKeyName(4, "trabajo.png")
        '
        'Administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 416)
        Me.Controls.Add(Me.tcAdministracion)
        Me.Controls.Add(Me.btnActDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Administracion"
        Me.Text = "Administración"
        CType(Me.MedicoDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmaceuticoDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacienteDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicamentoDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmbulatorioDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmaciaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcAdministracion.ResumeLayout(False)
        Me.tpMedicos.ResumeLayout(False)
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFarmaceuticos.ResumeLayout(False)
        CType(Me.dgvFarmaceuticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPacientes.ResumeLayout(False)
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMedicamentos.ResumeLayout(False)
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAmbulatorios.ResumeLayout(False)
        CType(Me.dgvAmbulatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpFarmacias.ResumeLayout(False)
        CType(Me.dgvFarmacias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dbRecetaElectronica As RecetaElectronica.dbRecetaElectronica
    Friend WithEvents MedicoDatos As System.Windows.Forms.BindingSource
    Friend WithEvents MedicoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicoAdaptador
    Friend WithEvents FarmaceuticoDatos As System.Windows.Forms.BindingSource
    Friend WithEvents FarmaceuticoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador
    Friend WithEvents PacienteDatos As System.Windows.Forms.BindingSource
    Friend WithEvents PacienteAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador
    Friend WithEvents MedicamentoDatos As System.Windows.Forms.BindingSource
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents AmbulatorioDatos As System.Windows.Forms.BindingSource
    Friend WithEvents AmbulatorioAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.AmbulatorioAdaptador
    Friend WithEvents FarmaciaDatos As System.Windows.Forms.BindingSource
    Friend WithEvents FarmaciaAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaciaAdaptador
    Friend WithEvents btnActDatos As System.Windows.Forms.Button
    Friend WithEvents tcAdministracion As System.Windows.Forms.TabControl
    Friend WithEvents tpMedicos As System.Windows.Forms.TabPage
    Friend WithEvents dgvMedicos As System.Windows.Forms.DataGridView
    Friend WithEvents tpFarmaceuticos As System.Windows.Forms.TabPage
    Friend WithEvents dgvFarmaceuticos As System.Windows.Forms.DataGridView
    Friend WithEvents tpPacientes As System.Windows.Forms.TabPage
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents tpMedicamentos As System.Windows.Forms.TabPage
    Friend WithEvents dgvMedicamentos As System.Windows.Forms.DataGridView
    Friend WithEvents tpAmbulatorios As System.Windows.Forms.TabPage
    Friend WithEvents dgvAmbulatorios As System.Windows.Forms.DataGridView
    Friend WithEvents tpFarmacias As System.Windows.Forms.TabPage
    Friend WithEvents dgvFarmacias As System.Windows.Forms.DataGridView
    Friend WithEvents CNMedicamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DenominacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrupoEquivalenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DosisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroEnvaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Posologia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdFarmaciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAmbulatorioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroFacultativoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirmaElectronicaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CualificacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents LugarTrabajoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroColegiadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltimoRegistroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroFarmaciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroTarjetaSanitariaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CronicoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ExentoAportacion As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BaremoEconomicoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SituacionLaboralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents EntidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Acumulado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HistorialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IconosPestañas As System.Windows.Forms.ImageList
End Class
