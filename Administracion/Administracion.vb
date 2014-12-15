Public Class Administracion

    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FarmaciaAdaptador.Fill(Me.dbRecetaElectronica.Farmacia)
        Me.AmbulatorioAdaptador.Fill(Me.dbRecetaElectronica.Ambulatorio)
        Me.MedicamentoAdaptador.Fill(Me.dbRecetaElectronica.Medicamento)
        Me.PacienteAdaptador.Fill(Me.dbRecetaElectronica.Paciente)
        Me.FarmaceuticoAdaptador.Fill(Me.dbRecetaElectronica.Farmaceutico)
        Me.MedicoAdaptador.Fill(Me.dbRecetaElectronica.Medico)
    End Sub

    Private Sub actDatos_Click(sender As Object, e As EventArgs) Handles btnActDatos.Click
        If tcAdministracion.SelectedTab.Text Is "Médicos" Then
            MedicoAdaptador.Update(Me.dbRecetaElectronica.Medico)
            MsgBox("Tabla de médicos actualizada.")
        ElseIf tcAdministracion.SelectedTab.Text Is "Farmacéuticos" Then
            FarmaceuticoAdaptador.Update(Me.dbRecetaElectronica.Farmaceutico)
            MsgBox("Tabla de farmacéuticos actualizada.")
        ElseIf tcAdministracion.SelectedTab.Text Is "Pacientes" Then
            PacienteAdaptador.Update(Me.dbRecetaElectronica.Paciente)
            MsgBox("Tabla de pacientes actualizada.")
        ElseIf tcAdministracion.SelectedTab.Text Is "Medicamentos" Then
            MedicamentoAdaptador.Update(Me.dbRecetaElectronica.Medicamento)
            MsgBox("Tabla de médicamentos actualizada.")
        ElseIf tcAdministracion.SelectedTab.Text Is "Ambulatorios" Then
            AmbulatorioAdaptador.Update(Me.dbRecetaElectronica.Ambulatorio)
            MsgBox("Tabla de ambulatorios actualizada.")
        ElseIf tcAdministracion.SelectedTab.Text Is "Farmacias" Then
            FarmaciaAdaptador.Update(Me.dbRecetaElectronica.Farmacia)
            MsgBox("Tabla de farmacias actualizada.")
        End If
    End Sub
End Class