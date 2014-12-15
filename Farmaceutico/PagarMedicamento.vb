Public Class PagarMedicamento
    Friend Receta As Integer
    Friend Medicamento As Integer

    Dim Paciente As Integer
    Dim Cronico As Boolean
    Dim Precio As Single
    Dim Exento As Boolean
    Dim Acumulado As Single
    Dim Baremo As String
    Dim Situacion As String

    Private Sub PagarMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Paciente = RecetaAdaptador.GetPaciente(Receta)
        Precio = MedicamentoAdaptador.GetPrecio(Medicamento)

        tbMedicamento.Text = Medicamento
        tbNombreMedicamento.Text = MedicamentoAdaptador.GetNombre(Medicamento)
        tbGrupoEquivalencia.Text = MedicamentoAdaptador.GetEquivalencia(Medicamento)
        tbDenominacion.Text = MedicamentoAdaptador.GetDenominacion(Medicamento)
        tbDosis.Text = MedicamentoAdaptador.GetDosis(Medicamento)
        tbVia.Text = MedicamentoAdaptador.GetVia(Medicamento)
        tbFormato.Text = MedicamentoAdaptador.GetFormato(Medicamento)
        tbNumeroEnvase.Text = MedicamentoAdaptador.GetEnvase(Medicamento)

        CalcularPrecio(Paciente)

        lbPrecio.Text = "Precio: " & CalcularPrecio(Paciente) & "€"
    End Sub

    Friend Sub ActualizarDatos(Medicamento As Integer, Receta As Integer)
        tbMedicamento.Text = Medicamento
        tbNombreMedicamento.Text = MedicamentoAdaptador.GetNombre(Medicamento)
        tbGrupoEquivalencia.Text = MedicamentoAdaptador.GetEquivalencia(Medicamento)
        tbDenominacion.Text = MedicamentoAdaptador.GetDenominacion(Medicamento)
        tbDosis.Text = MedicamentoAdaptador.GetDosis(Medicamento)
        tbVia.Text = MedicamentoAdaptador.GetVia(Medicamento)
        tbFormato.Text = MedicamentoAdaptador.GetFormato(Medicamento)
        tbNumeroEnvase.Text = MedicamentoAdaptador.GetEnvase(Medicamento)

        lbPrecio.Text = "Precio: " & CalcularPrecio(Paciente) & "€"
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        Dim acumulado = PacienteAdaptador.GetAcumulado(Paciente)
        PacienteAdaptador.ActAcumulado(acumulado + CalcularPrecio(Paciente), Paciente)
        RecetaAdaptador.ActDispensada(1, Receta)
        RecetaAdaptador.ActMedicamento(Medicamento, Receta)
        Farmacia_MedicamentoAdaptador.ActStock(Farmacia_MedicamentoAdaptador.GetStockAlt(Medicamento, FarmaceuticoAdaptador.GetFarmacia(CodigoFarmaceutico)) - 1, FarmaceuticoAdaptador.GetFarmacia(CodigoFarmaceutico), Medicamento)
        MsgBox("Medicamento pagado y dispensado.")
        Me.Close()
    End Sub

    Private Function CalcularPrecio(Paciente As Integer) As Single
        Cronico = PacienteAdaptador.GetCronico(Paciente)
        Exento = PacienteAdaptador.GetExento(Paciente)
        Acumulado = PacienteAdaptador.GetAcumulado(Paciente)
        Baremo = PacienteAdaptador.GetBaremo(Paciente)
        Situacion = PacienteAdaptador.GetSituacion(Paciente)
        Precio = MedicamentoAdaptador.GetPrecio(Medicamento)

        If Cronico Then
            If Precio > 4.13 Then
                Precio = 4.13
            End If
        ElseIf Exento Then
            Precio = 0.0
        ElseIf Exento And Cronico Then
            Precio = 0.0
        Else
            If Situacion = "Activo" Then
                If Baremo = "<18.000" Then
                    Precio = Precio * 0.4
                ElseIf Baremo = "18.000-100.000" Then
                    Precio = Precio * 0.5
                ElseIf Baremo = ">100.000" Then
                    Precio = Precio * 0.6
                End If
            ElseIf Situacion = "Pensionista" Then
                If Baremo = "<18.000" And Acumulado >= 8 Then
                    Precio = 0.0
                ElseIf Situacion = "<18.000" And Acumulado < 8 Then
                    Precio = Precio * 0.1
                ElseIf Baremo = "18.000-100.000" And Acumulado >= 18 Then
                    Precio = 0.0
                ElseIf Baremo = "18.000-100.000" And Acumulado < 18 Then
                    Precio = Precio * 0.1
                ElseIf Baremo = ">100.000" And Acumulado >= 60 Then
                    Precio = 0.0
                ElseIf Baremo = ">100.000" And Acumulado < 60 Then
                    Precio = Precio * 0.6
                End If
            ElseIf Situacion = "Mutualidad" Then
                Precio = Precio * 0.3
            End If
        End If
        Return Math.Round(Precio, 2)
    End Function
End Class