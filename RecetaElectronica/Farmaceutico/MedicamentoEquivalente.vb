Public Class MedicamentoEquivalente
    Friend Grupo As Integer
    Friend Receta As Integer

    Dim MedicamentosSource As New BindingSource()

    Private Sub MedicamentoEquivalente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMedicamentosEquivalentes.DataSource = MedicamentoAdaptador.GetEquivalentes(Grupo)
        SendMessage(tbFiltrarMedicamentos.Handle, &H1501, 0, "Filtrar paciente por Número Medicamento...")
        MedicamentosSource.DataSource = dgvMedicamentosEquivalentes.DataSource
        cbFiltroMedicamentos.SelectedIndex = 0
    End Sub

    Private Sub dgvMedicamentosEquivalentes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicamentosEquivalentes.CellContentClick
        If Farmacia_MedicamentoAdaptador.GetStockAlt(dgvMedicamentosEquivalentes.SelectedRows.Item(0).Cells(0).Value, FarmaceuticoAdaptador.GetFarmacia(CodigoFarmaceutico)) > 0 Then
            Dim code = MsgBox("¿Desea seleccionar " & dgvMedicamentosEquivalentes.SelectedRows.Item(0).Cells(1).Value & " como el nuevo medicamento?", MsgBoxStyle.YesNo, "Nuevo Medicamento")
            If code = MsgBoxResult.Yes Then
                PagarMedicamento.Receta = Receta
                PagarMedicamento.Medicamento = dgvMedicamentosEquivalentes.SelectedRows.Item(0).Cells(0).Value
                PagarMedicamento.Show()
                Me.Close()
            End If
        Else
            MsgBox("No hay stock de este medicamento.")
        End If
    End Sub

    Private Sub tbFiltrarMedicamentos_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarMedicamentos.TextChanged
        Dim opcion = cbFiltroMedicamentos.SelectedIndex
        If tbFiltrarMedicamentos.Text = "" Then
            dgvMedicamentosEquivalentes.DataSource = MedicamentoAdaptador.GetEquivalentes(Grupo)
        Else
            Select Case opcion
                Case 0
                    MedicamentosSource.Filter = "Convert(CNMedicamento, System.String) LIKE '%" & tbFiltrarMedicamentos.Text & "%'"
                Case 1
                    MedicamentosSource.Filter = "Nombre LIKE '%" & tbFiltrarMedicamentos.Text & "%'"
            End Select
            dgvMedicamentosEquivalentes.DataSource = MedicamentosSource.DataSource
        End If
    End Sub

    Private Sub cbFiltroMedicamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroMedicamentos.SelectedIndexChanged
        Dim opcion = cbFiltroMedicamentos.SelectedIndex
        Select Case opcion
            Case 0
                SendMessage(tbFiltrarMedicamentos.Handle, &H1501, 0, "Filtrar paciente por Número Medicamento...")
            Case 1
                SendMessage(tbFiltrarMedicamentos.Handle, &H1501, 0, "Filtrar paciente por Nombre...")
        End Select
    End Sub
End Class