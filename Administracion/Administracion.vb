Public Class Administracion

    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MedicoAdaptador.Fill(dbRecetaElectronica.Medico)
        FarmaceuticoAdaptador.Fill(dbRecetaElectronica.Farmaceutico)
        PacienteAdaptador.Fill(dbRecetaElectronica.Paciente)
        MedicamentoAdaptador.Fill(dbRecetaElectronica.Medicamento)
        GrupoEquivalenciasAdaptador.Fill(dbRecetaElectronica.GrupoEquivalencias)
        AmbulatorioAdaptador.Fill(dbRecetaElectronica.Ambulatorio)
        FarmaciaAdaptador.Fill(dbRecetaElectronica.Farmacia)
    End Sub

    Private Sub btnActDatos_Click(sender As Object, e As EventArgs) Handles btnActDatos.Click
        Dim tab = tcAdministracion.SelectedIndex
        Select Case tab
            Case 0
                MedicoAdaptador.Update(dbRecetaElectronica.Medico)
                MsgBox("Tabla de médicos actualizada.")
            Case 1
                FarmaceuticoAdaptador.Update(dbRecetaElectronica.Farmaceutico)
                MsgBox("Tabla de farmacéuticos actualizada.")
            Case 2
                PacienteAdaptador.Update(dbRecetaElectronica.Paciente)
                MsgBox("Tabla de pacientes actualizada.")
            Case 3
                MedicamentoAdaptador.Update(dbRecetaElectronica.Medicamento)
                MsgBox("Tabla de medicamentos actualizada.")
            Case 4
                GrupoEquivalenciasAdaptador.Update(dbRecetaElectronica.GrupoEquivalencias)
                MsgBox("Tabla de grupo de equivalencias actualizada.")
            Case 5
                AmbulatorioAdaptador.Update(dbRecetaElectronica.Ambulatorio)
                MsgBox("Tabla de ambulatorios actualizada.")
            Case 6
                FarmaciaAdaptador.Update(dbRecetaElectronica.Farmacia)
                MsgBox("Tabla de farmacias actualizada.")
        End Select
    End Sub
End Class