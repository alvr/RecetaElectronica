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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincipalFarmaceutico))
        Me.tcFarmaceutico = New System.Windows.Forms.TabControl()
        Me.tpDispensar = New System.Windows.Forms.TabPage()
        Me.pDatosReceta = New System.Windows.Forms.Panel()
        Me.gbMedicamento = New System.Windows.Forms.GroupBox()
        Me.btnOtraReceta = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbEnvase = New System.Windows.Forms.TextBox()
        Me.tbFormato = New System.Windows.Forms.TextBox()
        Me.tbVia = New System.Windows.Forms.TextBox()
        Me.tbNumMedicamento = New System.Windows.Forms.TextBox()
        Me.tbDosis = New System.Windows.Forms.TextBox()
        Me.tbDenominacion = New System.Windows.Forms.TextBox()
        Me.tbEquivalencia = New System.Windows.Forms.TextBox()
        Me.tbMedicamento = New System.Windows.Forms.TextBox()
        Me.gbPaciente = New System.Windows.Forms.GroupBox()
        Me.lbSituacion = New System.Windows.Forms.Label()
        Me.lbBaremo = New System.Windows.Forms.Label()
        Me.lbNacimiento = New System.Windows.Forms.Label()
        Me.lbDNI = New System.Windows.Forms.Label()
        Me.lbApellidos = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.rtbHistorial = New System.Windows.Forms.RichTextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbCronico = New System.Windows.Forms.CheckBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbDNI = New System.Windows.Forms.TextBox()
        Me.tbSituacion = New System.Windows.Forms.TextBox()
        Me.tbBaremo = New System.Windows.Forms.TextBox()
        Me.tbTarjeta = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lbTarjeta = New System.Windows.Forms.Label()
        Me.btnDispensar = New System.Windows.Forms.Button()
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.tbCodReceta = New System.Windows.Forms.TextBox()
        Me.tpStock = New System.Windows.Forms.TabPage()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.tpVademecum = New System.Windows.Forms.TabPage()
        Me.btnAbrirPredeterminado = New System.Windows.Forms.Button()
        Me.btnAbrirNavegador = New System.Windows.Forms.Button()
        Me.wbVademecum = New System.Windows.Forms.WebBrowser()
        Me.IconosPestañas = New System.Windows.Forms.ImageList(Me.components)
        Me.ssStatus = New System.Windows.Forms.StatusStrip()
        Me.tsslDatosReceta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dbRecetaElectronica = New RecetaElectronica.dbRecetaElectronica()
        Me.Farmacia_MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador()
        Me.RecetaAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador()
        Me.FarmaceuticoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador()
        Me.PacienteAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador()
        Me.MedicamentoAdaptador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador()
        Me.FarmaciaMedicamentoDatos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tcFarmaceutico.SuspendLayout()
        Me.tpDispensar.SuspendLayout()
        Me.pDatosReceta.SuspendLayout()
        Me.gbMedicamento.SuspendLayout()
        Me.gbPaciente.SuspendLayout()
        Me.tpStock.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpVademecum.SuspendLayout()
        Me.ssStatus.SuspendLayout()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmaciaMedicamentoDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcFarmaceutico
        '
        Me.tcFarmaceutico.Controls.Add(Me.tpDispensar)
        Me.tcFarmaceutico.Controls.Add(Me.tpStock)
        Me.tcFarmaceutico.Controls.Add(Me.tpVademecum)
        Me.tcFarmaceutico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcFarmaceutico.ImageList = Me.IconosPestañas
        Me.tcFarmaceutico.Location = New System.Drawing.Point(0, 0)
        Me.tcFarmaceutico.Name = "tcFarmaceutico"
        Me.tcFarmaceutico.SelectedIndex = 0
        Me.tcFarmaceutico.Size = New System.Drawing.Size(873, 462)
        Me.tcFarmaceutico.TabIndex = 0
        '
        'tpDispensar
        '
        Me.tpDispensar.Controls.Add(Me.pDatosReceta)
        Me.tpDispensar.Controls.Add(Me.btnComprobar)
        Me.tpDispensar.Controls.Add(Me.tbCodReceta)
        Me.tpDispensar.ImageIndex = 0
        Me.tpDispensar.Location = New System.Drawing.Point(4, 23)
        Me.tpDispensar.Name = "tpDispensar"
        Me.tpDispensar.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDispensar.Size = New System.Drawing.Size(865, 435)
        Me.tpDispensar.TabIndex = 0
        Me.tpDispensar.Text = "Dispensar Medicamento"
        Me.tpDispensar.UseVisualStyleBackColor = True
        '
        'pDatosReceta
        '
        Me.pDatosReceta.BackColor = System.Drawing.Color.Transparent
        Me.pDatosReceta.Controls.Add(Me.gbMedicamento)
        Me.pDatosReceta.Controls.Add(Me.gbPaciente)
        Me.pDatosReceta.Controls.Add(Me.btnDispensar)
        Me.pDatosReceta.Location = New System.Drawing.Point(0, 91)
        Me.pDatosReceta.Name = "pDatosReceta"
        Me.pDatosReceta.Size = New System.Drawing.Size(865, 323)
        Me.pDatosReceta.TabIndex = 2
        Me.pDatosReceta.Visible = False
        '
        'gbMedicamento
        '
        Me.gbMedicamento.Controls.Add(Me.btnOtraReceta)
        Me.gbMedicamento.Controls.Add(Me.Label8)
        Me.gbMedicamento.Controls.Add(Me.Label7)
        Me.gbMedicamento.Controls.Add(Me.Label6)
        Me.gbMedicamento.Controls.Add(Me.Label5)
        Me.gbMedicamento.Controls.Add(Me.Label4)
        Me.gbMedicamento.Controls.Add(Me.Label3)
        Me.gbMedicamento.Controls.Add(Me.Label2)
        Me.gbMedicamento.Controls.Add(Me.Label1)
        Me.gbMedicamento.Controls.Add(Me.tbEnvase)
        Me.gbMedicamento.Controls.Add(Me.tbFormato)
        Me.gbMedicamento.Controls.Add(Me.tbVia)
        Me.gbMedicamento.Controls.Add(Me.tbNumMedicamento)
        Me.gbMedicamento.Controls.Add(Me.tbDosis)
        Me.gbMedicamento.Controls.Add(Me.tbDenominacion)
        Me.gbMedicamento.Controls.Add(Me.tbEquivalencia)
        Me.gbMedicamento.Controls.Add(Me.tbMedicamento)
        Me.gbMedicamento.Location = New System.Drawing.Point(490, 3)
        Me.gbMedicamento.Name = "gbMedicamento"
        Me.gbMedicamento.Size = New System.Drawing.Size(372, 278)
        Me.gbMedicamento.TabIndex = 2
        Me.gbMedicamento.TabStop = False
        Me.gbMedicamento.Text = "Datos Medicamento:"
        '
        'btnOtraReceta
        '
        Me.btnOtraReceta.Location = New System.Drawing.Point(291, 249)
        Me.btnOtraReceta.Name = "btnOtraReceta"
        Me.btnOtraReceta.Size = New System.Drawing.Size(75, 23)
        Me.btnOtraReceta.TabIndex = 16
        Me.btnOtraReceta.Text = "Otra Receta"
        Me.btnOtraReceta.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Medicamento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Equivalencia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Denominación:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Vía:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Dosis:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Formato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Envase:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Núm. Medicamento:"
        '
        'tbEnvase
        '
        Me.tbEnvase.Location = New System.Drawing.Point(114, 204)
        Me.tbEnvase.Name = "tbEnvase"
        Me.tbEnvase.ReadOnly = True
        Me.tbEnvase.Size = New System.Drawing.Size(100, 20)
        Me.tbEnvase.TabIndex = 7
        '
        'tbFormato
        '
        Me.tbFormato.Location = New System.Drawing.Point(114, 178)
        Me.tbFormato.Name = "tbFormato"
        Me.tbFormato.ReadOnly = True
        Me.tbFormato.Size = New System.Drawing.Size(100, 20)
        Me.tbFormato.TabIndex = 6
        '
        'tbVia
        '
        Me.tbVia.Location = New System.Drawing.Point(114, 126)
        Me.tbVia.Name = "tbVia"
        Me.tbVia.ReadOnly = True
        Me.tbVia.Size = New System.Drawing.Size(100, 20)
        Me.tbVia.TabIndex = 5
        '
        'tbNumMedicamento
        '
        Me.tbNumMedicamento.Location = New System.Drawing.Point(114, 22)
        Me.tbNumMedicamento.Name = "tbNumMedicamento"
        Me.tbNumMedicamento.ReadOnly = True
        Me.tbNumMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbNumMedicamento.TabIndex = 4
        '
        'tbDosis
        '
        Me.tbDosis.Location = New System.Drawing.Point(114, 152)
        Me.tbDosis.Name = "tbDosis"
        Me.tbDosis.ReadOnly = True
        Me.tbDosis.Size = New System.Drawing.Size(100, 20)
        Me.tbDosis.TabIndex = 3
        '
        'tbDenominacion
        '
        Me.tbDenominacion.Location = New System.Drawing.Point(114, 100)
        Me.tbDenominacion.Name = "tbDenominacion"
        Me.tbDenominacion.ReadOnly = True
        Me.tbDenominacion.Size = New System.Drawing.Size(100, 20)
        Me.tbDenominacion.TabIndex = 2
        '
        'tbEquivalencia
        '
        Me.tbEquivalencia.Location = New System.Drawing.Point(114, 74)
        Me.tbEquivalencia.Name = "tbEquivalencia"
        Me.tbEquivalencia.ReadOnly = True
        Me.tbEquivalencia.Size = New System.Drawing.Size(100, 20)
        Me.tbEquivalencia.TabIndex = 1
        '
        'tbMedicamento
        '
        Me.tbMedicamento.Location = New System.Drawing.Point(114, 48)
        Me.tbMedicamento.Name = "tbMedicamento"
        Me.tbMedicamento.ReadOnly = True
        Me.tbMedicamento.Size = New System.Drawing.Size(100, 20)
        Me.tbMedicamento.TabIndex = 0
        '
        'gbPaciente
        '
        Me.gbPaciente.Controls.Add(Me.lbSituacion)
        Me.gbPaciente.Controls.Add(Me.lbBaremo)
        Me.gbPaciente.Controls.Add(Me.lbNacimiento)
        Me.gbPaciente.Controls.Add(Me.lbDNI)
        Me.gbPaciente.Controls.Add(Me.lbApellidos)
        Me.gbPaciente.Controls.Add(Me.lbNombre)
        Me.gbPaciente.Controls.Add(Me.rtbHistorial)
        Me.gbPaciente.Controls.Add(Me.dtpFechaNacimiento)
        Me.gbPaciente.Controls.Add(Me.cbCronico)
        Me.gbPaciente.Controls.Add(Me.tbApellidos)
        Me.gbPaciente.Controls.Add(Me.tbDNI)
        Me.gbPaciente.Controls.Add(Me.tbSituacion)
        Me.gbPaciente.Controls.Add(Me.tbBaremo)
        Me.gbPaciente.Controls.Add(Me.tbTarjeta)
        Me.gbPaciente.Controls.Add(Me.tbNombre)
        Me.gbPaciente.Controls.Add(Me.lbTarjeta)
        Me.gbPaciente.Location = New System.Drawing.Point(3, 3)
        Me.gbPaciente.Name = "gbPaciente"
        Me.gbPaciente.Size = New System.Drawing.Size(481, 278)
        Me.gbPaciente.TabIndex = 1
        Me.gbPaciente.TabStop = False
        Me.gbPaciente.Text = "Datos Paciente:"
        '
        'lbSituacion
        '
        Me.lbSituacion.AutoSize = True
        Me.lbSituacion.Location = New System.Drawing.Point(251, 103)
        Me.lbSituacion.Name = "lbSituacion"
        Me.lbSituacion.Size = New System.Drawing.Size(54, 13)
        Me.lbSituacion.TabIndex = 15
        Me.lbSituacion.Text = "Situación:"
        '
        'lbBaremo
        '
        Me.lbBaremo.AutoSize = True
        Me.lbBaremo.Location = New System.Drawing.Point(251, 51)
        Me.lbBaremo.Name = "lbBaremo"
        Me.lbBaremo.Size = New System.Drawing.Size(46, 13)
        Me.lbBaremo.TabIndex = 14
        Me.lbBaremo.Text = "Baremo:"
        '
        'lbNacimiento
        '
        Me.lbNacimiento.AutoSize = True
        Me.lbNacimiento.Location = New System.Drawing.Point(6, 129)
        Me.lbNacimiento.Name = "lbNacimiento"
        Me.lbNacimiento.Size = New System.Drawing.Size(75, 13)
        Me.lbNacimiento.TabIndex = 13
        Me.lbNacimiento.Text = "F. Nacimiento:"
        '
        'lbDNI
        '
        Me.lbDNI.AutoSize = True
        Me.lbDNI.Location = New System.Drawing.Point(6, 103)
        Me.lbDNI.Name = "lbDNI"
        Me.lbDNI.Size = New System.Drawing.Size(29, 13)
        Me.lbDNI.TabIndex = 12
        Me.lbDNI.Text = "DNI:"
        '
        'lbApellidos
        '
        Me.lbApellidos.AutoSize = True
        Me.lbApellidos.Location = New System.Drawing.Point(6, 77)
        Me.lbApellidos.Name = "lbApellidos"
        Me.lbApellidos.Size = New System.Drawing.Size(52, 13)
        Me.lbApellidos.TabIndex = 11
        Me.lbApellidos.Text = "Apellidos:"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(6, 51)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 10
        Me.lbNombre.Text = "Nombre:"
        '
        'rtbHistorial
        '
        Me.rtbHistorial.Location = New System.Drawing.Point(9, 152)
        Me.rtbHistorial.Name = "rtbHistorial"
        Me.rtbHistorial.ReadOnly = True
        Me.rtbHistorial.Size = New System.Drawing.Size(466, 120)
        Me.rtbHistorial.TabIndex = 9
        Me.rtbHistorial.Text = ""
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.CustomFormat = ""
        Me.dtpFechaNacimiento.Enabled = False
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(83, 126)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaNacimiento.TabIndex = 8
        '
        'cbCronico
        '
        Me.cbCronico.AutoSize = True
        Me.cbCronico.Enabled = False
        Me.cbCronico.Location = New System.Drawing.Point(254, 24)
        Me.cbCronico.Name = "cbCronico"
        Me.cbCronico.Size = New System.Drawing.Size(62, 17)
        Me.cbCronico.TabIndex = 7
        Me.cbCronico.Text = "Crónico"
        Me.cbCronico.UseVisualStyleBackColor = True
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(83, 74)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.ReadOnly = True
        Me.tbApellidos.Size = New System.Drawing.Size(195, 20)
        Me.tbApellidos.TabIndex = 6
        '
        'tbDNI
        '
        Me.tbDNI.Location = New System.Drawing.Point(83, 100)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.ReadOnly = True
        Me.tbDNI.Size = New System.Drawing.Size(100, 20)
        Me.tbDNI.TabIndex = 5
        '
        'tbSituacion
        '
        Me.tbSituacion.Location = New System.Drawing.Point(311, 100)
        Me.tbSituacion.Name = "tbSituacion"
        Me.tbSituacion.ReadOnly = True
        Me.tbSituacion.Size = New System.Drawing.Size(100, 20)
        Me.tbSituacion.TabIndex = 4
        '
        'tbBaremo
        '
        Me.tbBaremo.Location = New System.Drawing.Point(311, 48)
        Me.tbBaremo.Name = "tbBaremo"
        Me.tbBaremo.ReadOnly = True
        Me.tbBaremo.Size = New System.Drawing.Size(100, 20)
        Me.tbBaremo.TabIndex = 3
        '
        'tbTarjeta
        '
        Me.tbTarjeta.Location = New System.Drawing.Point(83, 22)
        Me.tbTarjeta.Name = "tbTarjeta"
        Me.tbTarjeta.ReadOnly = True
        Me.tbTarjeta.Size = New System.Drawing.Size(100, 20)
        Me.tbTarjeta.TabIndex = 2
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(83, 48)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.ReadOnly = True
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 1
        '
        'lbTarjeta
        '
        Me.lbTarjeta.AutoSize = True
        Me.lbTarjeta.Location = New System.Drawing.Point(6, 25)
        Me.lbTarjeta.Name = "lbTarjeta"
        Me.lbTarjeta.Size = New System.Drawing.Size(71, 13)
        Me.lbTarjeta.TabIndex = 0
        Me.lbTarjeta.Text = "Núm. Tarjeta:"
        '
        'btnDispensar
        '
        Me.btnDispensar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispensar.Location = New System.Drawing.Point(0, 287)
        Me.btnDispensar.Name = "btnDispensar"
        Me.btnDispensar.Size = New System.Drawing.Size(865, 36)
        Me.btnDispensar.TabIndex = 0
        Me.btnDispensar.Text = "Dispensar Medicamento"
        Me.btnDispensar.UseVisualStyleBackColor = True
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
        'tpStock
        '
        Me.tpStock.Controls.Add(Me.dgvStock)
        Me.tpStock.ImageIndex = 1
        Me.tpStock.Location = New System.Drawing.Point(4, 23)
        Me.tpStock.Name = "tpStock"
        Me.tpStock.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStock.Size = New System.Drawing.Size(865, 435)
        Me.tpStock.TabIndex = 1
        Me.tpStock.Text = "Stock"
        Me.tpStock.UseVisualStyleBackColor = True
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
        Me.dgvStock.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Location = New System.Drawing.Point(3, 3)
        Me.dgvStock.MultiSelect = False
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.RowHeadersVisible = False
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.Size = New System.Drawing.Size(859, 405)
        Me.dgvStock.TabIndex = 0
        '
        'tpVademecum
        '
        Me.tpVademecum.Controls.Add(Me.btnAbrirPredeterminado)
        Me.tpVademecum.Controls.Add(Me.btnAbrirNavegador)
        Me.tpVademecum.Controls.Add(Me.wbVademecum)
        Me.tpVademecum.ImageIndex = 2
        Me.tpVademecum.Location = New System.Drawing.Point(4, 23)
        Me.tpVademecum.Name = "tpVademecum"
        Me.tpVademecum.Size = New System.Drawing.Size(865, 435)
        Me.tpVademecum.TabIndex = 2
        Me.tpVademecum.Text = "Vademecum"
        Me.tpVademecum.UseVisualStyleBackColor = True
        '
        'btnAbrirPredeterminado
        '
        Me.btnAbrirPredeterminado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAbrirPredeterminado.Location = New System.Drawing.Point(331, 215)
        Me.btnAbrirPredeterminado.Name = "btnAbrirPredeterminado"
        Me.btnAbrirPredeterminado.Size = New System.Drawing.Size(210, 33)
        Me.btnAbrirPredeterminado.TabIndex = 2
        Me.btnAbrirPredeterminado.Text = "Abrir en el lector PDF predeterminado"
        Me.btnAbrirPredeterminado.UseVisualStyleBackColor = True
        '
        'btnAbrirNavegador
        '
        Me.btnAbrirNavegador.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAbrirNavegador.Location = New System.Drawing.Point(331, 118)
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
        Me.wbVademecum.Size = New System.Drawing.Size(865, 435)
        Me.wbVademecum.TabIndex = 0
        Me.wbVademecum.Visible = False
        '
        'IconosPestañas
        '
        Me.IconosPestañas.ImageStream = CType(resources.GetObject("IconosPestañas.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconosPestañas.TransparentColor = System.Drawing.Color.Transparent
        Me.IconosPestañas.Images.SetKeyName(0, "medicamentos.png")
        Me.IconosPestañas.Images.SetKeyName(1, "stock.png")
        Me.IconosPestañas.Images.SetKeyName(2, "vademecum.png")
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
        'PrincipalFarmaceutico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 462)
        Me.Controls.Add(Me.ssStatus)
        Me.Controls.Add(Me.tcFarmaceutico)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PrincipalFarmaceutico"
        Me.Text = "Panel Farmacéutico"
        Me.tcFarmaceutico.ResumeLayout(False)
        Me.tpDispensar.ResumeLayout(False)
        Me.tpDispensar.PerformLayout()
        Me.pDatosReceta.ResumeLayout(False)
        Me.gbMedicamento.ResumeLayout(False)
        Me.gbMedicamento.PerformLayout()
        Me.gbPaciente.ResumeLayout(False)
        Me.gbPaciente.PerformLayout()
        Me.tpStock.ResumeLayout(False)
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpVademecum.ResumeLayout(False)
        Me.ssStatus.ResumeLayout(False)
        Me.ssStatus.PerformLayout()
        CType(Me.dbRecetaElectronica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmaciaMedicamentoDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcFarmaceutico As System.Windows.Forms.TabControl
    Friend WithEvents tpDispensar As System.Windows.Forms.TabPage
    Friend WithEvents tpStock As System.Windows.Forms.TabPage
    Friend WithEvents tbCodReceta As System.Windows.Forms.TextBox
    Friend WithEvents dbRecetaElectronica As RecetaElectronica.dbRecetaElectronica
    Friend WithEvents Farmacia_MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.Farmacia_MedicamentoAdaptador
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
    Friend WithEvents btnComprobar As System.Windows.Forms.Button
    Friend WithEvents RecetaAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.RecetaAdaptador
    Friend WithEvents FarmaceuticoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.FarmaceuticoAdaptador
    Friend WithEvents PacienteAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.PacienteAdaptador
    Friend WithEvents MedicamentoAdaptador As RecetaElectronica.dbRecetaElectronicaTableAdapters.MedicamentoAdaptador
    Friend WithEvents tpVademecum As System.Windows.Forms.TabPage
    Friend WithEvents ssStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents tsslDatosReceta As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAbrirPredeterminado As System.Windows.Forms.Button
    Friend WithEvents btnAbrirNavegador As System.Windows.Forms.Button
    Friend WithEvents wbVademecum As System.Windows.Forms.WebBrowser
    Friend WithEvents IconosPestañas As System.Windows.Forms.ImageList
    Friend WithEvents FarmaciaMedicamentoDatos As System.Windows.Forms.BindingSource
    Friend WithEvents pDatosReceta As System.Windows.Forms.Panel
    Friend WithEvents btnDispensar As System.Windows.Forms.Button
    Friend WithEvents gbMedicamento As System.Windows.Forms.GroupBox
    Friend WithEvents gbPaciente As System.Windows.Forms.GroupBox
    Friend WithEvents tbTarjeta As System.Windows.Forms.TextBox
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbTarjeta As System.Windows.Forms.Label
    Friend WithEvents tbSituacion As System.Windows.Forms.TextBox
    Friend WithEvents tbBaremo As System.Windows.Forms.TextBox
    Friend WithEvents rtbHistorial As System.Windows.Forms.RichTextBox
    Friend WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCronico As System.Windows.Forms.CheckBox
    Friend WithEvents tbApellidos As System.Windows.Forms.TextBox
    Friend WithEvents tbDNI As System.Windows.Forms.TextBox
    Friend WithEvents lbNacimiento As System.Windows.Forms.Label
    Friend WithEvents lbDNI As System.Windows.Forms.Label
    Friend WithEvents lbApellidos As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbSituacion As System.Windows.Forms.Label
    Friend WithEvents lbBaremo As System.Windows.Forms.Label
    Friend WithEvents tbEquivalencia As System.Windows.Forms.TextBox
    Friend WithEvents tbMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents tbEnvase As System.Windows.Forms.TextBox
    Friend WithEvents tbFormato As System.Windows.Forms.TextBox
    Friend WithEvents tbVia As System.Windows.Forms.TextBox
    Friend WithEvents tbNumMedicamento As System.Windows.Forms.TextBox
    Friend WithEvents tbDosis As System.Windows.Forms.TextBox
    Friend WithEvents tbDenominacion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOtraReceta As System.Windows.Forms.Button
End Class
