Public NotInheritable Class Intro

    Private Sub Intro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Application.Info.Title <> "" Then
            lbTitulo.Text = My.Application.Info.Title
        Else
            lbTitulo.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        lbVersion.Text = System.String.Format(lbVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        lbCopyright.Text = My.Application.Info.Copyright
    End Sub
End Class
