Public Class Administracion

    Private Sub Administracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbRecetaElectronica.GrupoEquivalencias' Puede moverla o quitarla según sea necesario.
        Me.GrupoEquivalenciasAdaptador.Fill(Me.dbRecetaElectronica.GrupoEquivalencias)
        Me.GrupoEquivalenciasAdaptador.Fill(Me.dbRecetaElectronica.GrupoEquivalencias)
        Me.FarmaciaAdaptador.Fill(Me.dbRecetaElectronica.Farmacia)
        Me.AmbulatorioAdaptador.Fill(Me.dbRecetaElectronica.Ambulatorio)
        Me.MedicamentoAdaptador.Fill(Me.dbRecetaElectronica.Medicamento)
        Me.PacienteAdaptador.Fill(Me.dbRecetaElectronica.Paciente)
        Me.FarmaceuticoAdaptador.Fill(Me.dbRecetaElectronica.Farmaceutico)
        Me.MedicoAdaptador.Fill(Me.dbRecetaElectronica.Medico)
    End Sub

    Private Sub actDatos_Click(sender As Object, e As EventArgs) Handles btnActDatos.Click
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
                AmbulatorioAdaptador.Update(dbRecetaElectronica.Ambulatorio)
                MsgBox("Tabla de ambulatorios actualizada.")
            Case 5
                FarmaciaAdaptador.Update(dbRecetaElectronica.Farmacia)
                MsgBox("Tabla de farmacias actualizada.")
        End Select
    End Sub
End Class