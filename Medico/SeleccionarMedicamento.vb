Public Class SeleccionarMedicamento
    Private Sub SeleccionarMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MedicamentoAdaptador.Fill(Me.dbRecetaElectronica.Medicamento)
    End Sub

    Private Sub TablaMedicamento_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaMedicamento.CellContentDoubleClick
        NuevaReceta.Medicamento = MedicamentoAdaptador.GetMedicamento(TablaMedicamento.SelectedRows.Item(0).Cells(0).Value)
        NuevaReceta.RefrescarMedicamentos()
        Me.Close()
    End Sub
End Class