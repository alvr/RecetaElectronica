Public Class PrincipalMedico

    Dim PacientesSource As New BindingSource()
    Dim RecetasSource As New BindingSource()

    Private Sub PrincipalMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PacienteAdaptador.Fill(Me.dbRecetaElectronica.Paciente)
        statusPacientes.Text = "Pacientes cargados."
        Me.RecetaAdaptador.FillRecetasMedico(Me.dbRecetaElectronica.Receta, CodigoMedico)
        statusRecetas.Text = "Recetas cargadas."
        statusRecetasPaciente.Text = "No se ha cargado aún datos de la receta."
        CheckForIllegalCrossThreadCalls = False
        SendMessage(tbFiltrarPacientes.Handle, &H1501, 0, "Filtrar paciente por Tarjeta Sanitaria...")
        SendMessage(tbFiltrarRecetas.Handle, &H1501, 0, "Filtrar receta por Medicamento...")
        PacientesSource.DataSource = dgvPacientes.DataSource
        RecetasSource.DataSource = dgvRecetas.DataSource
        cbFiltroPacientes.SelectedIndex = 0
        cbFiltroRecetas.SelectedIndex = 0
    End Sub

    Private Sub tsmiVerPaciente_Click(sender As Object, e As EventArgs) Handles tsmiVerPaciente.Click
        VerPaciente.Paciente = PacienteAdaptador.GetPaciente(dgvPacientes.SelectedRows.Item(0).Cells(0).Value)
        VerPaciente.Show()
    End Sub

    Private Sub tsmiNuevaReceta_Click(sender As Object, e As EventArgs) Handles tsmiNuevaReceta.Click
        NuevaReceta.Paciente = PacienteAdaptador.GetPaciente(dgvPacientes.SelectedRows.Item(0).Cells(0).Value)
        NuevaReceta.Show()
    End Sub

    Private Sub tsmiVerRecetas_Click(sender As Object, e As EventArgs) Handles tsmiVerRecetas.Click
        RecetasPaciente.Paciente = PacienteAdaptador.GetPaciente(dgvPacientes.SelectedRows.Item(0).Cells(0).Value)
        RecetasPaciente.Show()
    End Sub

    Private Sub dgvPacientes_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPacientes.CellMouseDown
        If e.Button = MouseButtons.Right Then
            dgvPacientes.CurrentCell = dgvPacientes.Rows(e.RowIndex).Cells(e.ColumnIndex)
            dgvPacientes.Rows(e.RowIndex).Selected = True
            dgvPacientes.Focus()
        End If
    End Sub

    Private Sub dgvRecetas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecetas.CellClick
        statusRecetasPaciente.Text = "Cargando datos de la receta del paciente..."
        If Not BgWorker.IsBusy Then
            BgWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub BgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BgWorker.DoWork
        Dim CodPaciente As Integer = PacienteAdaptador.GetPaciente(dgvRecetas.SelectedRows.Item(0).Cells(0).Value)
        Dim CodMedicamento As Integer = MedicamentoAdaptador.GetMedicamento(dgvRecetas.SelectedRows.Item(0).Cells(1).Value)

        tbTarjeta.Text = CodPaciente
        tbNombre.Text = PacienteAdaptador.GetNombre(CodPaciente)
        tbApellidos.Text = PacienteAdaptador.GetApellidos(CodPaciente)
        tbDNI.Text = PacienteAdaptador.GetDNI(CodPaciente)
        dtpFechaNacimiento.Value = PacienteAdaptador.GetFechaNacimiento(CodPaciente)
        cbCronico.Checked = PacienteAdaptador.GetCronico(CodPaciente).Value
        tbBaremo.Text = PacienteAdaptador.GetBaremo(CodPaciente)
        tbSituacionLab.Text = PacienteAdaptador.GetSituacion(CodPaciente)
        rtbHistorial.Text = PacienteAdaptador.GetHistorial(CodPaciente)

        tbMedicamento.Text = CodMedicamento
        tbNombreMedicamento.Text = MedicamentoAdaptador.GetNombre(CodMedicamento)
        tbGrupoEquivalencia.Text = MedicamentoAdaptador.GetEquivalencia(CodMedicamento).ToString
        tbDenominacionMed.Text = MedicamentoAdaptador.GetDenominacion(CodMedicamento)
        tbDosisMed.Text = MedicamentoAdaptador.GetDosis(CodMedicamento)
        tbViaMed.Text = MedicamentoAdaptador.GetVia(CodMedicamento)
        tbFormatoMed.Text = MedicamentoAdaptador.GetFormato(CodMedicamento)
        tbEnvaseMed.Text = MedicamentoAdaptador.GetEnvase(CodMedicamento)
        dtpRecetaMed.Value = dgvRecetas.SelectedRows.Item(0).Cells(2).Value
    End Sub

    Private Sub BgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgWorker.RunWorkerCompleted
        statusRecetasPaciente.Text = "Datos de la receta del paciente cargados."
    End Sub

    Private Sub tbFiltrarPacientes_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarPacientes.TextChanged
        Dim opcion = cbFiltroPacientes.SelectedIndex
        If tbFiltrarPacientes.Text = "" Then
            dgvPacientes.DataSource = PacienteAdaptador.GetData()
        Else
            Select Case opcion
                Case 0
                    PacientesSource.Filter = "Convert(NumeroTarjetaSanitaria, System.String) LIKE '%" & tbFiltrarPacientes.Text & "%'"
                    dgvPacientes.DataSource = PacientesSource.DataSource
                Case 1
                    PacientesSource.Filter = "Nombre LIKE '%" & tbFiltrarPacientes.Text & "%'"
                    dgvPacientes.DataSource = PacientesSource.DataSource
                Case 2
                    PacientesSource.Filter = "Apellidos LIKE '%" & tbFiltrarPacientes.Text & "%'"
                    dgvPacientes.DataSource = PacientesSource.DataSource
                Case 3
                    PacientesSource.Filter = "DNI LIKE '%" & tbFiltrarPacientes.Text & "%'"
                    dgvPacientes.DataSource = PacientesSource.DataSource
                Case 4
                    PacientesSource.Filter = "Convert(FechaNacimiento, System.String) LIKE '%" & tbFiltrarPacientes.Text & "%'"
                    dgvPacientes.DataSource = PacientesSource.DataSource
            End Select
        End If
    End Sub

    Private Sub cbFiltroPacientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroPacientes.SelectedIndexChanged
        Dim opcion = cbFiltroPacientes.SelectedIndex
        Select Case opcion
            Case 0
                SendMessage(tbFiltrarPacientes.Handle, &H1501, 0, "Filtrar paciente por Tarjeta Sanitaria...")
            Case 1
                SendMessage(tbFiltrarPacientes.Handle, &H1501, 0, "Filtrar paciente por Nombre...")
            Case 2
                SendMessage(tbFiltrarPacientes.Handle, &H1501, 0, "Filtrar paciente por Apellidos...")
            Case 3
                SendMessage(tbFiltrarPacientes.Handle, &H1501, 0, "Filtrar paciente por DNI...")
            Case 4
                SendMessage(tbFiltrarPacientes.Handle, &H1501, 0, "Filtrar paciente por Fecha de Nacimiento...")
        End Select
    End Sub

    Private Sub tbFiltrarRecetas_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarRecetas.TextChanged
        Dim opcion = cbFiltroRecetas.SelectedIndex
        If tbFiltrarRecetas.Text = "" Then
            dgvRecetas.DataSource = RecetaAdaptador.GetData()
        Else
            Select Case opcion
                Case 0
                    RecetasSource.Filter = "Convert(Medicamento, System.String) LIKE '%" & tbFiltrarRecetas.Text & "%'"
                    dgvRecetas.DataSource = RecetasSource.DataSource
                Case 1
                    RecetasSource.Filter = "Convert(Paciente, System.String) LIKE '%" & tbFiltrarRecetas.Text & "%'"
                    dgvRecetas.DataSource = RecetasSource.DataSource
                Case 2
                    RecetasSource.Filter = "Convert(FechaNacimiento, System.String) LIKE '%" & tbFiltrarRecetas.Text & "%'"
                    dgvRecetas.DataSource = RecetasSource.DataSource
            End Select
        End If
    End Sub

    Private Sub cbFiltroRecetas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroRecetas.SelectedIndexChanged
        Dim opcion = cbFiltroRecetas.SelectedIndex
        Select Case opcion
            Case 0
                SendMessage(tbFiltrarRecetas.Handle, &H1501, 0, "Filtrar paciente por Medicamento...")
            Case 1
                SendMessage(tbFiltrarRecetas.Handle, &H1501, 0, "Filtrar paciente por Paciente...")
            Case 2
                SendMessage(tbFiltrarRecetas.Handle, &H1501, 0, "Filtrar paciente por Fecha...")
        End Select
    End Sub
End Class