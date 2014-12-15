﻿Public NotInheritable Class SobreRE

    Private Sub SobreRE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TituloAplicacion As String
        If My.Application.Info.Title <> "" Then
            TituloAplicacion = My.Application.Info.Title
        Else
            TituloAplicacion = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Acerca de {0}", TituloAplicacion)
        Me.lbProducto.Text = My.Application.Info.ProductName
        Me.lbVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        Me.lbCopyright.Text = My.Application.Info.Copyright
        Me.lbCompañia.Text = My.Application.Info.CompanyName
        Me.tbDescripcion.Text = My.Application.Info.Description
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub
End Class
