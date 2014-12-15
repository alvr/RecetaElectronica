Public Class IniciarSesion

    Private Sub IniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.Network.IsAvailable Then
            MsgBox("Se requiere conexión a internet para funcionar. Contacte con un administrador.")
            Me.Close()
        End If
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceder.Click
        If rbMedico.Checked Then
            If String.IsNullOrEmpty(tbCodigo.Text) Or String.IsNullOrEmpty(tbContraseña.Text) Then
                MsgBox("El campo de código y/o contraseña está vacío.")
            Else
                Try
                    If Not Medico.Login(tbCodigo.Text, tbContraseña.Text) Is Nothing Then
                        System.Configuration.ConfigurationManager.AppSettings.Set("CodigoMedico", tbCodigo.Text)
                        PrincipalMedico.Show()
                        Me.Close()
                    Else
                        MsgBox("Datos incorrectos, compruébalos de nuevo.")
                    End If
                Catch ex As Exception
                    MsgBox("Error al iniciar sesión. Contacte con un administrador.")
                End Try
            End If
        ElseIf rbFarmaceutico.Checked Then
            If String.IsNullOrEmpty(tbCodigo.Text) Or String.IsNullOrEmpty(tbContraseña.Text) Then
                MsgBox("El campo de código y/o contraseña está vacío.")
            Else
                Try
                    If Not Farmaceutico.Login(tbCodigo.Text, tbContraseña.Text) Is Nothing Then
                        System.Configuration.ConfigurationManager.AppSettings.Set("CodigoFarmaceutico", tbCodigo.Text)
                        PrincipalFarmaceutico.Show()
                        Farmaceutico.ActRegistro(Now(), tbCodigo.Text)
                        Me.Close()
                    Else
                        MsgBox("Datos incorrectos, compruébalos de nuevo.")
                    End If
                Catch ex As Exception
                    MsgBox("Error al iniciar sesión. Contacte con un administrador.")
                End Try
            End If
        Else
            MsgBox("Selecciona el tipo de usuario.")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_MouseDown(sender As Object, e As MouseEventArgs) Handles lpbLogo.MouseDown
        If e.Button = MouseButtons.Middle Then
            AdministracionLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub lbMasInfo_Click(sender As Object, e As EventArgs) Handles lbMasInfo.Click
        SobreRE.Show()
    End Sub
End Class
