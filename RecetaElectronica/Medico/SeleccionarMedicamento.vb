Public Class SeleccionarMedicamento

    Dim MedicamentosSource As New BindingSource()

    Private Sub SeleccionarMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MedicamentoAdaptador.Fill(Me.dbRecetaElectronica.Medicamento)
        SendMessage(tbFiltrarMedicamentos.Handle, &H1501, 0, "Filtrar receta por Número Medicamento...")
        MedicamentosSource.DataSource = dgvMedicamentos.DataSource
        cbFiltroMedicamentos.SelectedIndex = 0
    End Sub

    Private Sub dgvMedicamentos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicamentos.CellContentDoubleClick
        NuevaReceta.Medicamento = MedicamentoAdaptador.GetMedicamento(dgvMedicamentos.SelectedRows.Item(0).Cells(0).Value)
        NuevaReceta.RefrescarMedicamentos()
        Me.Close()
    End Sub

    Private Sub tbFiltrarMedicamentos_TextChanged(sender As Object, e As EventArgs) Handles tbFiltrarMedicamentos.TextChanged
        Dim opcion = cbFiltroMedicamentos.SelectedIndex
        If tbFiltrarMedicamentos.Text = "" Then
            dgvMedicamentos.DataSource = MedicamentoAdaptador.GetData()
        Else
            Select Case opcion
                Case 0
                    MedicamentosSource.Filter = "Convert(CNMedicamento, System.String) LIKE '%" & tbFiltrarMedicamentos.Text & "%'"
                Case 1
                    MedicamentosSource.Filter = "Nombre LIKE '%" & tbFiltrarMedicamentos.Text & "%'"
            End Select
            dgvMedicamentos.DataSource = MedicamentosSource.DataSource
        End If
    End Sub

    Private Sub cbFiltroMedicamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFiltroMedicamentos.SelectedIndexChanged
        Dim opcion = cbFiltroMedicamentos.SelectedIndex
        Select Case opcion
            Case 0
                SendMessage(tbFiltrarMedicamentos.Handle, &H1501, 0, "Filtrar paciente por Número Medicamento...")
            Case 1
                SendMessage(tbFiltrarMedicamentos.Handle, &H1501, 0, "Filtrar paciente por Nombre Medicamento...")
        End Select
    End Sub
End Class