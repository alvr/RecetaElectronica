Public Class PrincipalFarmaceutico

    Private Sub PrincipalFarmaceutico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvStock.DataSource = Farmacia_MedicamentoAdaptador.GetMedicamentoFarmacia(Util.CodigoFarmaceutico)
        dgvStock.Columns(0).Visible = False
        dgvStock.Columns(3).Visible = False
        dgvStock.Columns(4).Visible = False
        dgvStock.Columns(5).Visible = False
        dgvStock.Columns(6).Visible = False
        pDatosReceta.Visible = False
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub btnComprobar_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        If Not IsNumeric(tbCodReceta.Text) Then
            MsgBox("Introduzca el código de la receta")
        ElseIf RecetaAdaptador.GetDispensada(tbCodReceta.Text) Then
            MsgBox("La receta ya ha sido dispensada.")
        ElseIf Not RecetaAdaptador.GetDispensada(tbCodReceta.Text) Then
            tbCodReceta.Enabled = False
            tsslDatosReceta.Text = "Cargando datos de la receta..."
            If Not bgWorker.IsBusy Then
                bgWorker.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub btnDispensar_Click(sender As Object, e As EventArgs) Handles btnDispensar.Click
        If Not RecetaAdaptador.GetDispensada(tbCodReceta.Text) Then
            tbCodReceta.Enabled = False
            If (Farmacia_MedicamentoAdaptador.GetStock(tbCodReceta.Text, FarmaceuticoAdaptador.GetFarmacia(Util.CodigoFarmaceutico)) < 1) Then
                Dim code = MsgBox("No hay stock de este medicamento. ¿Elegir otro del mismo grupo de equivalencia?", 4, "Sin stock")
                If code = MsgBoxResult.Yes Then
                    MedicamentoEquivalente.Grupo = MedicamentoAdaptador.GetEquivalencia(RecetaAdaptador.GetMedicamento(tbCodReceta.Text))
                    MedicamentoEquivalente.Receta = tbCodReceta.Text
                    MedicamentoEquivalente.Show()
                Else
                    tbCodReceta.Enabled = True
                End If
            Else
                PagarMedicamento.Receta = tbCodReceta.Text
                PagarMedicamento.Medicamento = tbMedicamento.Text
                PagarMedicamento.Show()
            End If
        End If
    End Sub

    Private Sub ActualizarDatos(Receta As Integer)
        Dim CodPaciente = RecetaAdaptador.GetPaciente(Receta)
        Dim CodMedicamento = RecetaAdaptador.GetMedicamento(Receta)

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
        tbGrupoEquivalencia.Text = MedicamentoAdaptador.GetEquivalencia(CodMedicamento)
        tbDenominacion.Text = MedicamentoAdaptador.GetDenominacion(CodMedicamento)
        tbDosis.Text = MedicamentoAdaptador.GetDosis(CodMedicamento)
        tbVia.Text = MedicamentoAdaptador.GetVia(CodMedicamento)
        tbFormato.Text = MedicamentoAdaptador.GetFormato(CodMedicamento)
        tbNumeroEnvase.Text = MedicamentoAdaptador.GetEnvase(CodMedicamento)
    End Sub

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        ActualizarDatos(tbCodReceta.Text)
        pDatosReceta.Visible = True
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        tsslDatosReceta.Text = "Datos de la receta cargados."
    End Sub

    Private Sub btnAbrirNavegador_Click(sender As Object, e As EventArgs) Handles btnAbrirNavegador.Click
        wbVademecum.Visible = True
        wbVademecum.BringToFront()
        wbVademecum.Navigate(Application.StartupPath & "\Resources\Vademecum.pdf")
    End Sub

    Private Sub btnAbrirPredeterminado_Click(sender As Object, e As EventArgs) Handles btnAbrirPredeterminado.Click
        Process.Start(Application.StartupPath & "\Resources\Vademecum.pdf")
    End Sub

    Private Sub btnOtraReceta_Click(sender As Object, e As EventArgs) Handles btnOtraReceta.Click
        tbCodReceta.Enabled = True
        pDatosReceta.Visible = False
    End Sub
End Class