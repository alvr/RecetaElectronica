Public Class AdministracionLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceder.Click
        If String.IsNullOrEmpty(codigo.Text) Or String.IsNullOrEmpty(contraseña.Text) Then
            MsgBox("El campo de código y/o contraseña está vacío.")
        Else
            Try
                If Not Administrador.Login(codigo.Text, contraseña.Text) Is Nothing Then
                    Administracion.Show()
                    Me.Close()
                Else
                    MsgBox("Datos incorrectos, compruébalos de nuevo.")
                End If
            Catch ex As Exception
                MsgBox("Error al iniciar sesión. Contacte con un administrador.")
            End Try
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
