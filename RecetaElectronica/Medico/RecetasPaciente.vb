Public Class RecetasPaciente

    Friend Paciente As Integer

    Private Sub RecetasPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RecetaAdaptador.FillRecetasPaciente(Me.dbRecetaElectronica.Receta, Paciente)
        statusMedicamento.Text = "Datos sin cargar."
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub TablaRecetas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaRecetas.CellClick
        statusMedicamento.Text = "Cargando datos de la receta del paciente..."
        actualizarMed.RunWorkerAsync()
    End Sub

    Private Sub actualizarMed_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles actualizarMed.DoWork
        Dim CodMedicamento As Integer = MedicamentoAdaptador.GetMedicamento(TablaRecetas.SelectedRows.Item(0).Cells(0).Value)

        _tbNumeroMed.Text = CodMedicamento
        _tbNombreMed.Text = MedicamentoAdaptador.GetNombre(CodMedicamento)
        _tbEquivalencia.Text = MedicamentoAdaptador.GetEquivalencia(CodMedicamento).ToString
        _tbDenominacion.Text = MedicamentoAdaptador.GetDenominacion(CodMedicamento)
        _tbDosis.Text = MedicamentoAdaptador.GetDosis(CodMedicamento)
        _tbVia.Text = MedicamentoAdaptador.GetVia(CodMedicamento)
        _tbFormato.Text = MedicamentoAdaptador.GetFormato(CodMedicamento)
        _tbEnvase.Text = MedicamentoAdaptador.GetEnvase(CodMedicamento)
        _dtpFechaReceta.Value = TablaRecetas.SelectedRows.Item(0).Cells(1).Value
    End Sub

    Private Sub actualizarMed_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles actualizarMed.RunWorkerCompleted
        statusMedicamento.Text = "Datos de la receta del paciente cargados."
    End Sub
End Class