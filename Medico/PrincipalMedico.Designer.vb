<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrincipalMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincipalMedico))
        Me.tcMédico = New System.Windows.Forms.TabControl()
        Me.tpPacientes = New System.Windows.Forms.TabPage()
        Me.tbFiltrarPacientes = New System.Windows.Forms.TextBox()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.cmsPacientes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiVerPaciente = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiNuevaReceta = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiVerRecetas = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbRecetaElectronica = New RecetaElectronica.dbRecetaElectronica()
        Me.tpRecetas = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbMedicamento = New System.Windows.Forms.GroupBox()
        Me.dtpRecetaMed = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbEnvaseMed = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbFormatoMed = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbViaMed = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbDosisMed = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbDenominacionMed = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbGrupoEquivalencia = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbNombreMedicamento = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbMedicamento = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.dtpReceta = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbEnvase = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbFormato = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbVia = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbDosis = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbDenominacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbEquivalencia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbNombreMed = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbNumeroMed = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbPaciente = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rtbHistorial = New System.Windows.Forms.RichTextBox()
        Me.tbSituacionLab = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbBaremo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCronico = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbTarjeta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvRecetas = New System.Windows.Forms.DataGridView()
        Me.PacienteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DispensadaDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RecetaDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbFiltrarRecetas = New System.Windows.Forms.TextBox()
        Me.ssStatus = New System.Windows.Forms.StatusStrip()
        Me.statusPacientes = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusRecetas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusRecetasPaciente = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BgWorker = New System.ComponentModel.BackgroundWorker()
        Me.PacienteAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador()
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        Me.RecetaAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador()
        Me.RecetasMedicoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.Recetas_MedicoAdaptador()
        Me.IdRecetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicamentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DispensadaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaremoEconomico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CronicoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SituacionLaboralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistorialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acumulado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tcMédico.SuspendLayout()
        Me.tpPacientes.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPacientes.SuspendLayout()
        CType(Me.PacienteDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRecetas.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbMedicamento.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbPaciente.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgvRecetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecetaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMédico
        '
        Me.tcMédico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcMédico.Controls.Add(Me.tpPacientes)
        Me.tcMédico.Controls.Add(Me.tpRecetas)
        Me.tcMédico.Location = New System.Drawing.Point(0, 0)
        Me.tcMédico.Name = "tcMédico"
        Me.tcMédico.SelectedIndex = 0
        Me.tcMédico.Size = New System.Drawing.Size(843, 411)
        Me.tcMédico.TabIndex = 0
        '
        'tpPacientes
        '
        Me.tpPacientes.Controls.Add(Me.tbFiltrarPacientes)
        Me.tpPacientes.Controls.Add(Me.dgvPacientes)
        Me.tpPacientes.Location = New System.Drawing.Point(4, 22)
        Me.tpPacientes.Name = "tpPacientes"
        Me.tpPacientes.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPacientes.Size = New System.Drawing.Size(835, 385)
        Me.tpPacientes.TabIndex = 1
        Me.tpPacientes.Text = "Pacientes"
        Me.tpPacientes.UseVisualStyleBackColor = True
        '
        'tbFiltrarPacientes
        '
        Me.tbFiltrarPacientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFiltrarPacientes.Location = New System.Drawing.Point(3, 359)
        Me.tbFiltrarPacientes.Name = "tbFiltrarPacientes"
        Me.tbFiltrarPacientes.Size = New System.Drawing.Size(829, 20)
        Me.tbFiltrarPacientes.TabIndex = 1
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AllowUserToDeleteRows = False
        Me.dgvPacientes.AllowUserToResizeRows = False
        Me.dgvPacientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPacientes.AutoGenerateColumns = False
        Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPacientes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.BaremoEconomico, Me.CronicoDataGridViewCheckBoxColumn, Me.SituacionLaboralDataGridViewTextBoxColumn, Me.HistorialDataGridViewTextBoxColumn, Me.Entidad, Me.Acumulado})
        Me.dgvPacientes.ContextMenuStrip = Me.cmsPacientes
        Me.dgvPacientes.DataSource = Me.PacienteDatos
        Me.dgvPacientes.Location = New System.Drawing.Point(3, 3)
        Me.dgvPacientes.MultiSelect = False
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.RowHeadersVisible = False
        Me.dgvPacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(829, 350)
        Me.dgvPacientes.TabIndex = 0
        '
        'cmsPacientes
        '
        Me.cmsPacientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiVerPaciente, Me.tsmiNuevaReceta, Me.tsmiVerRecetas})
        Me.cmsPacientes.Name = "MenuContextual"
        Me.cmsPacientes.Size = New System.Drawing.Size(202, 70)
        '
        'tsmiVerPaciente
        '
        Me.tsmiVerPaciente.Name = "tsmiVerPaciente"
        Me.tsmiVerPaciente.Size = New System.Drawing.Size(201, 22)
        Me.tsmiVerPaciente.Text = "Ver Paciente"
        '
        'tsmiNuevaReceta
        '
        Me.tsmiNuevaReceta.Name = "tsmiNuevaReceta"
        Me.tsmiNuevaReceta.Size = New System.Drawing.Size(201, 22)
        Me.tsmiNuevaReceta.Text = "Nueva Receta"
        '
        'tsmiVerRecetas
        '
        Me.tsmiVerRecetas.Name = "tsmiVerRecetas"
        Me.tsmiVerRecetas.Size = New System.Drawing.Size(201, 22)
        Me.tsmiVerRecetas.Text = "Ver Recetas del paciente"
        '
        'PacienteDatos
        '
        Me.PacienteDatos.DataMember = "Paciente"
        Me.PacienteDatos.DataSource = Me.dbRecetaElectronica
        '
        'dbRecetaElectronica
        '
        Me.dbRecetaElectronica.DataSetName = "dbRecetaElectronica"
        Me.dbRecetaElectronica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tpRecetas
        '
        Me.tpRecetas.Controls.Add(Me.TableLayoutPanel1)
        Me.tpRecetas.Location = New System.Drawing.Point(4, 22)
        Me.tpRecetas.Name = "tpRecetas"
        Me.tpRecetas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRecetas.Size = New System.Drawing.Size(835, 385)
        Me.tpRecetas.TabIndex = 0
        Me.tpRecetas.Text = "Recetas"
        Me.tpRecetas.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 534.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(845, 385)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbMedicamento)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.gbPaciente)
        Me.Panel1.Location = New System.Drawing.Point(314, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 379)
        Me.Panel1.TabIndex = 0
        '
        'gbMedicamento
        '
        Me.gbMedicamento.Controls.Add(Me.dtpRecetaMed)
        Me.gbMedicamento.Controls.Add(Me.Label18)
        Me.gbMedicamento.Controls.Add(Me.tbEnvaseMed)
        Me.gbMedicamento.Controls.Add(Me.Label19)
        Me.gbMedicamento.Controls.Add(Me.tbFormatoMed)
        Me.gbMedicamento.Controls.Add(Me.Label20)
        Me.gbMedicamento.Controls.Add(Me.tbViaMed)
        Me.gbMedicamento.Controls.Add(Me.Label21)
        Me.gbMedicamento.Controls.Add(Me.tbDosisMed)
        Me.gbMedicamento.Controls.Add(Me.Label22)
        Me.gbMedicamento.Controls.Add(Me.tbDenominacionMed)
        Me.gbMedicamento.Controls.Add(Me.Label23)
        Me.gbMedicamento.Controls.Add(Me.tbGrupoEquivalencia)
        Me.gbMedicamento.Controls.Add(Me.Label24)
        Me.gbMedicamento.Controls.Add(Me.tbNombreMedicamento)
        Me.gbMedicamento.Controls.Add(Me.Label25)
        Me.gbMedicamento.Controls.Add(Me.tbMedicamento)
        Me.gbMedicamento.Controls.Add(Me.Label26)
        Me.gbMedicamento.Location = New System.Drawing.Point(0, 285)
        Me.gbMedicamento.Name = "gbMedicamento"
        Me.gbMedicamento.Size = New System.Drawing.Size(517, 94)
        Me.gbMedicamento.TabIndex = 1
        Me.gbMedicamento.TabStop = False
        Me.gbMedicamento.Text = "Datos Medicamento"
        '
        'dtpRecetaMed
        '
        Me.dtpRecetaMed.Enabled = False
        Me.dtpRecetaMed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRecetaMed.Location = New System.Drawing.Point(395, 65)
        Me.dtpRecetaMed.Name = "dtpRecetaMed"
        Me.dtpRecetaMed.Size = New System.Drawing.Size(115, 20)
        Me.dtpRecetaMed.TabIndex = 17
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
        'tbEnvaseMed
        '
        Me.tbEnvaseMed.Location = New System.Drawing.Point(243, 65)
        Me.tbEnvaseMed.Name = "tbEnvaseMed"
        Me.tbEnvaseMed.ReadOnly = True
        Me.tbEnvaseMed.Size = New System.Drawing.Size(100, 20)
        Me.tbEnvaseMed.TabIndex = 15
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
        'tbFormatoMed
        '
        Me.tbFormatoMed.Location = New System.Drawing.Point(57, 65)
        Me.tbFormatoMed.Name = "tbFormatoMed"
        Me.tbFormatoMed.ReadOnly = True
        Me.tbFormatoMed.Size = New System.Drawing.Size(100, 20)
        Me.tbFormatoMed.TabIndex = 13
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
        'tbViaMed
        '
        Me.tbViaMed.Location = New System.Drawing.Point(375, 39)
        Me.tbViaMed.Name = "tbViaMed"
        Me.tbViaMed.ReadOnly = True
        Me.tbViaMed.Size = New System.Drawing.Size(100, 20)
        Me.tbViaMed.TabIndex = 11
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
        'tbDosisMed
        '
        Me.tbDosisMed.Location = New System.Drawing.Point(235, 39)
        Me.tbDosisMed.Name = "tbDosisMed"
        Me.tbDosisMed.ReadOnly = True
        Me.tbDosisMed.Size = New System.Drawing.Size(100, 20)
        Me.tbDosisMed.TabIndex = 9
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
        'tbDenominacionMed
        '
        Me.tbDenominacionMed.Location = New System.Drawing.Point(87, 39)
        Me.tbDenominacionMed.Name = "tbDenominacionMed"
        Me.tbDenominacionMed.ReadOnly = True
        Me.tbDenominacionMed.Size = New System.Drawing.Size(100, 20)
        Me.tbDenominacionMed.TabIndex = 7
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
        'tbGrupoEquivalencia
        '
        Me.tbGrupoEquivalencia.Location = New System.Drawing.Point(427, 13)
        Me.tbGrupoEquivalencia.Name = "tbGrupoEquivalencia"
        Me.tbGrupoEquivalencia.ReadOnly = True
        Me.tbGrupoEquivalencia.Size = New System.Drawing.Size(83, 20)
        Me.tbGrupoEquivalencia.TabIndex = 5
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
        'tbNombreMedicamento
        '
        Me.tbNombreMedicamento.Location = New System.Drawing.Point(257, 13)
        Me.tbNombreMedicamento.Name = "tbNombreMedicamento"
        Me.tbNombreMedicamento.ReadOnly = True
        Me.tbNombreMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbNombreMedicamento.TabIndex = 3
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
        'tbMedicamento
        '
        Me.tbMedicamento.Location = New System.Drawing.Point(98, 13)
        Me.tbMedicamento.Name = "tbMedicamento"
        Me.tbMedicamento.ReadOnly = True
        Me.tbMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbMedicamento.TabIndex = 1
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.dtpReceta)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.tbEnvase)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.tbFormato)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.tbVia)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tbDosis)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tbDenominacion)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.tbEquivalencia)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tbNombreMed)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbNumeroMed)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 285)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(517, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Medicamento"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.TextBox4)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.TextBox5)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.TextBox6)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.TextBox7)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(517, 94)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Medicamento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(395, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(349, 68)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(40, 13)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "Fecha:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(243, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(163, 68)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 13)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Núm. Envase:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(57, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(3, 68)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 13)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "Formato:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(375, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(342, 42)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(27, 13)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "Vía:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(235, 39)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 9
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(193, 42)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(36, 13)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Dosis:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(87, 39)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(3, 42)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(78, 13)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "Denominación:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(427, 13)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(83, 20)
        Me.TextBox6.TabIndex = 5
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(363, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(58, 13)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "Grupo Eq.:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(257, 13)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 3
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
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(98, 13)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 1
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
        'dtpReceta
        '
        Me.dtpReceta.Enabled = False
        Me.dtpReceta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReceta.Location = New System.Drawing.Point(395, 65)
        Me.dtpReceta.Name = "dtpReceta"
        Me.dtpReceta.Size = New System.Drawing.Size(115, 20)
        Me.dtpReceta.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(349, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Fecha:"
        '
        'tbEnvase
        '
        Me.tbEnvase.Location = New System.Drawing.Point(243, 65)
        Me.tbEnvase.Name = "tbEnvase"
        Me.tbEnvase.ReadOnly = True
        Me.tbEnvase.Size = New System.Drawing.Size(100, 20)
        Me.tbEnvase.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(163, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Núm. Envase:"
        '
        'tbFormato
        '
        Me.tbFormato.Location = New System.Drawing.Point(57, 65)
        Me.tbFormato.Name = "tbFormato"
        Me.tbFormato.ReadOnly = True
        Me.tbFormato.Size = New System.Drawing.Size(100, 20)
        Me.tbFormato.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Formato:"
        '
        'tbVia
        '
        Me.tbVia.Location = New System.Drawing.Point(375, 39)
        Me.tbVia.Name = "tbVia"
        Me.tbVia.ReadOnly = True
        Me.tbVia.Size = New System.Drawing.Size(100, 20)
        Me.tbVia.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(342, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Vía:"
        '
        'tbDosis
        '
        Me.tbDosis.Location = New System.Drawing.Point(235, 39)
        Me.tbDosis.Name = "tbDosis"
        Me.tbDosis.ReadOnly = True
        Me.tbDosis.Size = New System.Drawing.Size(100, 20)
        Me.tbDosis.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(193, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Dosis:"
        '
        'tbDenominacion
        '
        Me.tbDenominacion.Location = New System.Drawing.Point(87, 39)
        Me.tbDenominacion.Name = "tbDenominacion"
        Me.tbDenominacion.ReadOnly = True
        Me.tbDenominacion.Size = New System.Drawing.Size(100, 20)
        Me.tbDenominacion.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Denominación:"
        '
        'tbEquivalencia
        '
        Me.tbEquivalencia.Location = New System.Drawing.Point(427, 13)
        Me.tbEquivalencia.Name = "tbEquivalencia"
        Me.tbEquivalencia.ReadOnly = True
        Me.tbEquivalencia.Size = New System.Drawing.Size(83, 20)
        Me.tbEquivalencia.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(363, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Grupo Eq.:"
        '
        'tbNombreMed
        '
        Me.tbNombreMed.Location = New System.Drawing.Point(257, 13)
        Me.tbNombreMed.Name = "tbNombreMed"
        Me.tbNombreMed.ReadOnly = True
        Me.tbNombreMed.Size = New System.Drawing.Size(100, 20)
        Me.tbNombreMed.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(204, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Nombre:"
        '
        'tbNumeroMed
        '
        Me.tbNumeroMed.Location = New System.Drawing.Point(98, 13)
        Me.tbNumeroMed.Name = "tbNumeroMed"
        Me.tbNumeroMed.ReadOnly = True
        Me.tbNumeroMed.Size = New System.Drawing.Size(100, 20)
        Me.tbNumeroMed.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "N. Medicamento:"
        '
        'gbPaciente
        '
        Me.gbPaciente.Controls.Add(Me.Label16)
        Me.gbPaciente.Controls.Add(Me.rtbHistorial)
        Me.gbPaciente.Controls.Add(Me.tbSituacionLab)
        Me.gbPaciente.Controls.Add(Me.Label7)
        Me.gbPaciente.Controls.Add(Me.tbBaremo)
        Me.gbPaciente.Controls.Add(Me.Label6)
        Me.gbPaciente.Controls.Add(Me.cbCronico)
        Me.gbPaciente.Controls.Add(Me.Label5)
        Me.gbPaciente.Controls.Add(Me.dtpFechaNacimiento)
        Me.gbPaciente.Controls.Add(Me.tbDNI)
        Me.gbPaciente.Controls.Add(Me.Label4)
        Me.gbPaciente.Controls.Add(Me.tbApellidos)
        Me.gbPaciente.Controls.Add(Me.Label3)
        Me.gbPaciente.Controls.Add(Me.Label2)
        Me.gbPaciente.Controls.Add(Me.tbNombre)
        Me.gbPaciente.Controls.Add(Me.tbTarjeta)
        Me.gbPaciente.Controls.Add(Me.Label1)
        Me.gbPaciente.Location = New System.Drawing.Point(0, 3)
        Me.gbPaciente.Name = "gbPaciente"
        Me.gbPaciente.Size = New System.Drawing.Size(517, 276)
        Me.gbPaciente.TabIndex = 0
        Me.gbPaciente.TabStop = False
        Me.gbPaciente.Text = "Datos Paciente"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Crónico:"
        '
        'rtbHistorial
        '
        Me.rtbHistorial.Location = New System.Drawing.Point(7, 92)
        Me.rtbHistorial.Name = "rtbHistorial"
        Me.rtbHistorial.ReadOnly = True
        Me.rtbHistorial.Size = New System.Drawing.Size(504, 178)
        Me.rtbHistorial.TabIndex = 16
        Me.rtbHistorial.Text = ""
        '
        'tbSituacionLab
        '
        Me.tbSituacionLab.Location = New System.Drawing.Point(345, 66)
        Me.tbSituacionLab.Name = "tbSituacionLab"
        Me.tbSituacionLab.ReadOnly = True
        Me.tbSituacionLab.Size = New System.Drawing.Size(100, 20)
        Me.tbSituacionLab.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Sit. Laboral:"
        '
        'tbBaremo
        '
        Me.tbBaremo.Location = New System.Drawing.Point(170, 66)
        Me.tbBaremo.Name = "tbBaremo"
        Me.tbBaremo.ReadOnly = True
        Me.tbBaremo.Size = New System.Drawing.Size(100, 20)
        Me.tbBaremo.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Bar. Económico:"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha Nacimiento:"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DNI:"
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(64, 40)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.ReadOnly = True
        Me.tbApellidos.Size = New System.Drawing.Size(162, 20)
        Me.tbApellidos.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellidos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "T. Sanitaria:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgvRecetas, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbFiltrarRecetas, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(305, 379)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'dgvRecetas
        '
        Me.dgvRecetas.AllowUserToAddRows = False
        Me.dgvRecetas.AllowUserToDeleteRows = False
        Me.dgvRecetas.AllowUserToResizeColumns = False
        Me.dgvRecetas.AllowUserToResizeRows = False
        Me.dgvRecetas.AutoGenerateColumns = False
        Me.dgvRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PacienteDataGridViewTextBoxColumn1, Me.MedicamentoDataGridViewTextBoxColumn1, Me.FechaDataGridViewTextBoxColumn1, Me.DispensadaDataGridViewCheckBoxColumn1})
        Me.dgvRecetas.DataSource = Me.RecetaDatos
        Me.dgvRecetas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecetas.Location = New System.Drawing.Point(3, 3)
        Me.dgvRecetas.Name = "dgvRecetas"
        Me.dgvRecetas.ReadOnly = True
        Me.dgvRecetas.RowHeadersVisible = False
        Me.dgvRecetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecetas.Size = New System.Drawing.Size(299, 347)
        Me.dgvRecetas.TabIndex = 1
        '
        'PacienteDataGridViewTextBoxColumn1
        '
        Me.PacienteDataGridViewTextBoxColumn1.DataPropertyName = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn1.HeaderText = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn1.Name = "PacienteDataGridViewTextBoxColumn1"
        Me.PacienteDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MedicamentoDataGridViewTextBoxColumn1
        '
        Me.MedicamentoDataGridViewTextBoxColumn1.DataPropertyName = "Medicamento"
        Me.MedicamentoDataGridViewTextBoxColumn1.HeaderText = "Medicamento"
        Me.MedicamentoDataGridViewTextBoxColumn1.Name = "MedicamentoDataGridViewTextBoxColumn1"
        Me.MedicamentoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn1
        '
        Me.FechaDataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn1.Name = "FechaDataGridViewTextBoxColumn1"
        Me.FechaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DispensadaDataGridViewCheckBoxColumn1
        '
        Me.DispensadaDataGridViewCheckBoxColumn1.DataPropertyName = "Dispensada"
        Me.DispensadaDataGridViewCheckBoxColumn1.HeaderText = "Dispensada"
        Me.DispensadaDataGridViewCheckBoxColumn1.Name = "DispensadaDataGridViewCheckBoxColumn1"
        Me.DispensadaDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'RecetaDatos
        '
        Me.RecetaDatos.DataMember = "Receta"
        Me.RecetaDatos.DataSource = Me.dbRecetaElectronica
        '
        'tbFiltrarRecetas
        '
        Me.tbFiltrarRecetas.Location = New System.Drawing.Point(3, 356)
        Me.tbFiltrarRecetas.Name = "tbFiltrarRecetas"
        Me.tbFiltrarRecetas.Size = New System.Drawing.Size(299, 20)
        Me.tbFiltrarRecetas.TabIndex = 2
        '
        'ssStatus
        '
        Me.ssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusPacientes, Me.statusRecetas, Me.statusRecetasPaciente})
        Me.ssStatus.Location = New System.Drawing.Point(0, 413)
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.Size = New System.Drawing.Size(843, 22)
        Me.ssStatus.Stretch = False
        Me.ssStatus.TabIndex = 1
        Me.ssStatus.Text = "Status"
        '
        'statusPacientes
        '
        Me.statusPacientes.Name = "statusPacientes"
        Me.statusPacientes.Size = New System.Drawing.Size(88, 17)
        Me.statusPacientes.Text = "statusPacientes"
        '
        'statusRecetas
        '
        Me.statusRecetas.Name = "statusRecetas"
        Me.statusRecetas.Size = New System.Drawing.Size(78, 17)
        Me.statusRecetas.Text = "statusRecetas"
        '
        'statusRecetasPaciente
        '
        Me.statusRecetasPaciente.Name = "statusRecetasPaciente"
        Me.statusRecetasPaciente.Size = New System.Drawing.Size(113, 17)
        Me.statusRecetasPaciente.Text = "statusCargadoDatos"
        '
        'BgWorker
        '
        '
        'PacienteAdaptador
        '
        Me.PacienteAdaptador.ClearBeforeFill = True
        '
        'MedicamentoAdaptador
        '
        Me.MedicamentoAdaptador.ClearBeforeFill = True
        '
        'RecetaAdaptador
        '
        Me.RecetaAdaptador.ClearBeforeFill = True
        '
        'RecetasMedicoAdaptador
        '
        Me.RecetasMedicoAdaptador.ClearBeforeFill = True
        '
        'IdRecetaDataGridViewTextBoxColumn
        '
        Me.IdRecetaDataGridViewTextBoxColumn.DataPropertyName = "idReceta"
        Me.IdRecetaDataGridViewTextBoxColumn.HeaderText = "idReceta"
        Me.IdRecetaDataGridViewTextBoxColumn.Name = "IdRecetaDataGridViewTextBoxColumn"
        Me.IdRecetaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PacienteDataGridViewTextBoxColumn
        '
        Me.PacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.HeaderText = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.Name = "PacienteDataGridViewTextBoxColumn"
        Me.PacienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MedicamentoDataGridViewTextBoxColumn
        '
        Me.MedicamentoDataGridViewTextBoxColumn.DataPropertyName = "Medicamento"
        Me.MedicamentoDataGridViewTextBoxColumn.HeaderText = "Medicamento"
        Me.MedicamentoDataGridViewTextBoxColumn.Name = "MedicamentoDataGridViewTextBoxColumn"
        Me.MedicamentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DispensadaDataGridViewCheckBoxColumn
        '
        Me.DispensadaDataGridViewCheckBoxColumn.DataPropertyName = "Dispensada"
        Me.DispensadaDataGridViewCheckBoxColumn.HeaderText = "Dispensada"
        Me.DispensadaDataGridViewCheckBoxColumn.Name = "DispensadaDataGridViewCheckBoxColumn"
        Me.DispensadaDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'NumeroTarjetaSanitariaDataGridViewTextBoxColumn
        '
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn.DataPropertyName = "NumeroTarjetaSanitaria"
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn.HeaderText = "Tarjeta Sanitaria"
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn.Name = "NumeroTarjetaSanitariaDataGridViewTextBoxColumn"
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeroTarjetaSanitariaDataGridViewTextBoxColumn.Width = 109
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 69
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidosDataGridViewTextBoxColumn.Width = 74
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        Me.DNIDataGridViewTextBoxColumn.ReadOnly = True
        Me.DNIDataGridViewTextBoxColumn.Width = 51
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        Me.FechaNacimientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaNacimientoDataGridViewTextBoxColumn.Width = 118
        '
        'BaremoEconomico
        '
        Me.BaremoEconomico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BaremoEconomico.DataPropertyName = "BaremoEconomico"
        Me.BaremoEconomico.HeaderText = "Baremo Económico"
        Me.BaremoEconomico.Name = "BaremoEconomico"
        Me.BaremoEconomico.ReadOnly = True
        Me.BaremoEconomico.Width = 124
        '
        'CronicoDataGridViewCheckBoxColumn
        '
        Me.CronicoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CronicoDataGridViewCheckBoxColumn.DataPropertyName = "Cronico"
        Me.CronicoDataGridViewCheckBoxColumn.HeaderText = "Crónico"
        Me.CronicoDataGridViewCheckBoxColumn.Name = "CronicoDataGridViewCheckBoxColumn"
        Me.CronicoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CronicoDataGridViewCheckBoxColumn.Width = 49
        '
        'SituacionLaboralDataGridViewTextBoxColumn
        '
        Me.SituacionLaboralDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.SituacionLaboralDataGridViewTextBoxColumn.DataPropertyName = "SituacionLaboral"
        Me.SituacionLaboralDataGridViewTextBoxColumn.HeaderText = "Situación Laboral"
        Me.SituacionLaboralDataGridViewTextBoxColumn.Name = "SituacionLaboralDataGridViewTextBoxColumn"
        Me.SituacionLaboralDataGridViewTextBoxColumn.ReadOnly = True
        Me.SituacionLaboralDataGridViewTextBoxColumn.Width = 114
        '
        'HistorialDataGridViewTextBoxColumn
        '
        Me.HistorialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HistorialDataGridViewTextBoxColumn.DataPropertyName = "Historial"
        Me.HistorialDataGridViewTextBoxColumn.HeaderText = "Historial"
        Me.HistorialDataGridViewTextBoxColumn.Name = "HistorialDataGridViewTextBoxColumn"
        Me.HistorialDataGridViewTextBoxColumn.ReadOnly = True
        Me.HistorialDataGridViewTextBoxColumn.Width = 69
        '
        'Entidad
        '
        Me.Entidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Entidad.DataPropertyName = "Entidad"
        Me.Entidad.HeaderText = "Entidad"
        Me.Entidad.Name = "Entidad"
        Me.Entidad.ReadOnly = True
        Me.Entidad.Width = 68
        '
        'Acumulado
        '
        Me.Acumulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Acumulado.DataPropertyName = "Acumulado"
        Me.Acumulado.HeaderText = "Acumulado"
        Me.Acumulado.Name = "Acumulado"
        Me.Acumulado.ReadOnly = True
        Me.Acumulado.Width = 85
        '
        'PrincipalMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 435)
        Me.Controls.Add(Me.ssStatus)
        Me.Controls.Add(Me.tcMédico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrincipalMedico"
        Me.Text = "Panel Médico"
        Me.tcMédico.ResumeLayout(False)
        Me.tpPacientes.ResumeLayout(False)
        Me.tpPacientes.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPacientes.ResumeLayout(False)
        CType(Me.PacienteDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRecetas.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.gbMedicamento.ResumeLayout(False)
        Me.gbMedicamento.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbPaciente.ResumeLayout(False)
        Me.gbPaciente.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dgvRecetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecetaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssStatus.ResumeLayout(False)
        Me.ssStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcMédico As System.Windows.Forms.TabControl
    Friend WithEvents tpRecetas As System.Windows.Forms.TabPage
    Friend WithEvents tpPacientes As System.Windows.Forms.TabPage
    Friend WithEvents dgvPacientes As System.Windows.Forms.DataGridView
    Friend WithEvents dbRecetaElectronica As RecetaElectronica.dbRecetaElectronica
    Friend WithEvents PacienteDatos As System.Windows.Forms.BindingSource
    Friend WithEvents PacienteAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador
    Friend WithEvents cmsPacientes As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiNuevaReceta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiVerRecetas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents rtbHistorial As System.Windows.Forms.RichTextBox
    Friend WithEvents tbSituacionLab As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbBaremo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbCronico As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbEnvase As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbFormato As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbVia As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbDosis As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbDenominacion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbEquivalencia As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbNombreMed As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbNumeroMed As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents RecetaDatos As System.Windows.Forms.BindingSource
    Friend WithEvents RecetaAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador
    Friend WithEvents RecetasMedicoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.Recetas_MedicoAdaptador
    Friend WithEvents dtpReceta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ssStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents statusPacientes As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusRecetas As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusRecetasPaciente As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BgWorker As System.ComponentModel.BackgroundWorker
    Public WithEvents tbTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents gbMedicamento As System.Windows.Forms.GroupBox
    Friend WithEvents dtpRecetaMed As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbEnvaseMed As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbFormatoMed As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tbViaMed As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tbDosisMed As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tbDenominacionMed As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tbGrupoEquivalencia As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tbNombreMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents tbMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents tbFiltrarPacientes As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvRecetas As System.Windows.Forms.DataGridView
    Friend WithEvents IdRecetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PacienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicamentoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DispensadaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PacienteDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicamentoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DispensadaDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents tbFiltrarRecetas As System.Windows.Forms.TextBox
    Friend WithEvents tsmiVerPaciente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumeroTarjetaSanitariaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaremoEconomico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CronicoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SituacionLaboralDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HistorialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Acumulado As System.Windows.Forms.DataGridViewTextBoxColumn

End Class