Public Class NuevaReceta

    Friend Paciente As Integer
    Friend Medicamento As Integer

    Private Sub NuevaReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbTarjeta.Text = Paciente
        tbNombre.Text = PacienteAdaptador.GetNombre(Paciente)
        tbApellidos.Text = PacienteAdaptador.GetApellidos(Paciente)
        tbDNI.Text = PacienteAdaptador.GetDNI(Paciente)
        dtpFechaNacimiento.Value = PacienteAdaptador.GetFechaNacimiento(Paciente)
        cbCronico.Checked = PacienteAdaptador.GetCronico(Paciente).Value
        tbBaremo.Text = PacienteAdaptador.GetBaremo(Paciente)
        tbSituacion.Text = PacienteAdaptador.GetSituacion(Paciente)
        rtbHistorial.Text = PacienteAdaptador.GetHistorial(Paciente)
    End Sub

    Private Sub btnSelMedicamento_Click(sender As Object, e As EventArgs) Handles btnSelMedicamento.Click
        SeleccionarMedicamento.Show()
    End Sub

    Private Sub btnAñadirReceta_Click(sender As Object, e As EventArgs) Handles btnAñadirReceta.Click
        PacienteAdaptador.ActHistorial(rtbHistorial.Text, Paciente)
        RecetaAdaptador.NuevaReceta(Paciente, Medicamento, Today())
        Recetas_MedicoAdaptador.NuevaReceta(RecetaAdaptador.UltimaReceta(), CodigoMedico)
        MsgBox("Receta añadida.")
        Me.Close()
    End Sub

    Friend Sub RefrescarMedicamentos()
        tbNumMedicamento.Text = Medicamento
        tbMedicamento.Text = MedicamentoAdaptador.GetNombre(Medicamento)
        tbEquivalencia.Text = MedicamentoAdaptador.GetEquivalencia(Medicamento)
        tbDenominacion.Text = MedicamentoAdaptador.GetDenominacion(Medicamento)
        tbDosis.Text = MedicamentoAdaptador.GetDosis(Medicamento)
        tbVia.Text = MedicamentoAdaptador.GetVia(Medicamento)
        tbFormato.Text = MedicamentoAdaptador.GetFormato(Medicamento)
        tbEnvase.Text = MedicamentoAdaptador.GetEnvase(Medicamento)
    End Sub

End Class