<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrincipalFarmaceutico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincipalFarmaceutico))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pDatosReceta = New System.Windows.Forms.Panel()
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
        Me.btnDispensar = New System.Windows.Forms.Button()
        Me.gbMedicamento = New System.Windows.Forms.GroupBox()
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
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.tbCodReceta = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnAbrirPredeterminado = New System.Windows.Forms.Button()
        Me.btnAbrirNavegador = New System.Windows.Forms.Button()
        Me.wbVademecum = New System.Windows.Forms.WebBrowser()
        Me.ssStatus = New System.Windows.Forms.StatusStrip()
        Me.tsslDatosReceta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.dbRecetaElectronica = New RecetaElectronica.dbRecetaElectronica()
        Me.Farmacia_MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador()
        Me.RecetaAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador()
        Me.FarmaceuticoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador()
        Me.PacienteAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador()
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        Me.btnOtraReceta = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pDatosReceta.SuspendLayout()
        Me.gbPaciente.SuspendLayout()
        Me.gbMedicamento.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.ssStatus.SuspendLayout()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(873, 462)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pDatosReceta)
        Me.TabPage1.Controls.Add(Me.btnComprobar)
        Me.TabPage1.Controls.Add(Me.tbCodReceta)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(865, 436)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dispensar Medicamento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pDatosReceta
        '
        Me.pDatosReceta.Controls.Add(Me.gbPaciente)
        Me.pDatosReceta.Controls.Add(Me.btnDispensar)
        Me.pDatosReceta.Controls.Add(Me.gbMedicamento)
        Me.pDatosReceta.Location = New System.Drawing.Point(0, 91)
        Me.pDatosReceta.Name = "pDatosReceta"
        Me.pDatosReceta.Size = New System.Drawing.Size(865, 318)
        Me.pDatosReceta.TabIndex = 2
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
        Me.gbPaciente.Location = New System.Drawing.Point(0, 0)
        Me.gbPaciente.Name = "gbPaciente"
        Me.gbPaciente.Size = New System.Drawing.Size(485, 276)
        Me.gbPaciente.TabIndex = 1
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
        Me.rtbHistorial.Size = New System.Drawing.Size(473, 178)
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
        'btnDispensar
        '
        Me.btnDispensar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDispensar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispensar.Location = New System.Drawing.Point(0, 283)
        Me.btnDispensar.Name = "btnDispensar"
        Me.btnDispensar.Size = New System.Drawing.Size(865, 35)
        Me.btnDispensar.TabIndex = 0
        Me.btnDispensar.Text = "Dispensar Medicamento"
        Me.btnDispensar.UseVisualStyleBackColor = True
        '
        'gbMedicamento
        '
        Me.gbMedicamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMedicamento.Controls.Add(Me.btnOtraReceta)
        Me.gbMedicamento.Controls.Add(Me.dtpReceta)
        Me.gbMedicamento.Controls.Add(Me.Label27)
        Me.gbMedicamento.Controls.Add(Me.tbNumeroEnvase)
        Me.gbMedicamento.Controls.Add(Me.Label28)
        Me.gbMedicamento.Controls.Add(Me.tbFormato)
        Me.gbMedicamento.Controls.Add(Me.Label29)
        Me.gbMedicamento.Controls.Add(Me.tbVia)
        Me.gbMedicamento.Controls.Add(Me.Label30)
        Me.gbMedicamento.Controls.Add(Me.tbDosis)
        Me.gbMedicamento.Controls.Add(Me.Label31)
        Me.gbMedicamento.Controls.Add(Me.tbDenominacion)
        Me.gbMedicamento.Controls.Add(Me.Label32)
        Me.gbMedicamento.Controls.Add(Me.tbGrupoEquivalencia)
        Me.gbMedicamento.Controls.Add(Me.Label33)
        Me.gbMedicamento.Controls.Add(Me.tbNombreMedicamento)
        Me.gbMedicamento.Controls.Add(Me.Label34)
        Me.gbMedicamento.Controls.Add(Me.tbMedicamento)
        Me.gbMedicamento.Controls.Add(Me.Label35)
        Me.gbMedicamento.Location = New System.Drawing.Point(496, 0)
        Me.gbMedicamento.Name = "gbMedicamento"
        Me.gbMedicamento.Size = New System.Drawing.Size(369, 277)
        Me.gbMedicamento.TabIndex = 2
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
        'btnComprobar
        '
        Me.btnComprobar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprobar.Location = New System.Drawing.Point(3, 47)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(859, 38)
        Me.btnComprobar.TabIndex = 1
        Me.btnComprobar.Text = "Comprobar Receta"
        Me.btnComprobar.UseVisualStyleBackColor = True
        '
        'tbCodReceta
        '
        Me.tbCodReceta.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbCodReceta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodReceta.Location = New System.Drawing.Point(3, 3)
        Me.tbCodReceta.Name = "tbCodReceta"
        Me.tbCodReceta.Size = New System.Drawing.Size(859, 38)
        Me.tbCodReceta.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvStock)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(865, 436)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stock"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        Me.dgvStock.AllowUserToResizeColumns = False
        Me.dgvStock.AllowUserToResizeRows = False
        Me.dgvStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Location = New System.Drawing.Point(3, 3)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.RowHeadersVisible = False
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.Size = New System.Drawing.Size(859, 406)
        Me.dgvStock.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnAbrirPredeterminado)
        Me.TabPage3.Controls.Add(Me.btnAbrirNavegador)
        Me.TabPage3.Controls.Add(Me.wbVademecum)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(865, 436)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Vademecum"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnAbrirPredeterminado
        '
        Me.btnAbrirPredeterminado.Location = New System.Drawing.Point(331, 216)
        Me.btnAbrirPredeterminado.Name = "btnAbrirPredeterminado"
        Me.btnAbrirPredeterminado.Size = New System.Drawing.Size(210, 33)
        Me.btnAbrirPredeterminado.TabIndex = 2
        Me.btnAbrirPredeterminado.Text = "Abrir en el lector PDF predeterminado"
        Me.btnAbrirPredeterminado.UseVisualStyleBackColor = True
        '
        'btnAbrirNavegador
        '
        Me.btnAbrirNavegador.Location = New System.Drawing.Point(331, 119)
        Me.btnAbrirNavegador.Name = "btnAbrirNavegador"
        Me.btnAbrirNavegador.Size = New System.Drawing.Size(210, 33)
        Me.btnAbrirNavegador.TabIndex = 1
        Me.btnAbrirNavegador.Text = "Abrir aquí (Requiere Adobe Reader)"
        Me.btnAbrirNavegador.UseVisualStyleBackColor = True
        '
        'wbVademecum
        '
        Me.wbVademecum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbVademecum.Location = New System.Drawing.Point(0, 0)
        Me.wbVademecum.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbVademecum.Name = "wbVademecum"
        Me.wbVademecum.Size = New System.Drawing.Size(865, 436)
        Me.wbVademecum.TabIndex = 0
        Me.wbVademecum.Visible = False
        '
        'ssStatus
        '
        Me.ssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslDatosReceta})
        Me.ssStatus.Location = New System.Drawing.Point(0, 440)
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.Size = New System.Drawing.Size(873, 22)
        Me.ssStatus.TabIndex = 1
        '
        'tsslDatosReceta
        '
        Me.tsslDatosReceta.Name = "tsslDatosReceta"
        Me.tsslDatosReceta.Size = New System.Drawing.Size(222, 17)
        Me.tsslDatosReceta.Text = "No se han cargado los datos de la receta."
        '
        'bgWorker
        '
        '
        'dbRecetaElectronica
        '
        Me.dbRecetaElectronica.DataSetName = "dbRecetaElectronica"
        Me.dbRecetaElectronica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Farmacia_MedicamentoAdaptador
        '
        Me.Farmacia_MedicamentoAdaptador.ClearBeforeFill = True
        '
        'RecetaAdaptador
        '
        Me.RecetaAdaptador.ClearBeforeFill = True
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
        'btnOtraReceta
        '
        Me.btnOtraReceta.Location = New System.Drawing.Point(288, 248)
        Me.btnOtraReceta.Name = "btnOtraReceta"
        Me.btnOtraReceta.Size = New System.Drawing.Size(75, 23)
        Me.btnOtraReceta.TabIndex = 18
        Me.btnOtraReceta.Text = "Otra Receta"
        Me.btnOtraReceta.UseVisualStyleBackColor = True
        '
        'PrincipalFarmaceutico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 462)
        Me.Controls.Add(Me.ssStatus)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrincipalFarmaceutico"
        Me.Text = "Panel Farmacéutico"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.pDatosReceta.ResumeLayout(False)
        Me.gbPaciente.ResumeLayout(False)
        Me.gbPaciente.PerformLayout()
        Me.gbMedicamento.ResumeLayout(False)
        Me.gbMedicamento.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.ssStatus.ResumeLayout(False)
        Me.ssStatus.PerformLayout()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tbCodReceta As System.Windows.Forms.TextBox
    Friend WithEvents dbRecetaElectronica As RecetaElectronica.dbRecetaElectronica
    Friend WithEvents Farmacia_MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
    Friend WithEvents btnComprobar As System.Windows.Forms.Button
    Friend WithEvents RecetaAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador
    Friend WithEvents pDatosReceta As System.Windows.Forms.Panel
    Friend WithEvents btnDispensar As System.Windows.Forms.Button
    Friend WithEvents FarmaceuticoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador
    Friend WithEvents gbMedicamento As System.Windows.Forms.GroupBox
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
    Friend WithEvents gbPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
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
    Public WithEvents tbTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PacienteAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ssStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslDatosReceta As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnAbrirPredeterminado As System.Windows.Forms.Button
    Friend WithEvents btnAbrirNavegador As System.Windows.Forms.Button
    Friend WithEvents wbVademecum As System.Windows.Forms.WebBrowser
    Friend WithEvents btnOtraReceta As System.Windows.Forms.Button
End Class
