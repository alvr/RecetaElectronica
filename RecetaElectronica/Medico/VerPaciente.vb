Public Class VerPaciente
    Friend Paciente As Integer

    Private Sub VerPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbTarjeta.Text = Paciente
        tbDNI.Text = PacienteAdaptador.GetDNI(Paciente)
        tbNombre.Text = PacienteAdaptador.GetNombre(Paciente)
        tbApellidos.Text = PacienteAdaptador.GetApellidos(Paciente)
        dtpFechaNacimiento.Value = PacienteAdaptador.GetFechaNacimiento(Paciente)
        tbBaremo.Text = PacienteAdaptador.GetBaremo(Paciente)
        tbSituacionLab.Text = PacienteAdaptador.GetSituacion(Paciente)
        tbEntidad.Text = PacienteAdaptador.GetEntidad(Paciente)
        tbAcumulado.Text = PacienteAdaptador.GetAcumulado(Paciente)
        rtbHistorial.Text = PacienteAdaptador.GetHistorial(Paciente)
        cbCronico.Checked = PacienteAdaptador.GetCronico(Paciente)
    End Sub
End Class