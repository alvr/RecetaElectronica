<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class AdministracionLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents lpbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lbCodigo As System.Windows.Forms.Label
    Friend WithEvents lbContraseña As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.TextBox
    Friend WithEvents contraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnAcceder As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministracionLogin))
        Me.lbCodigo = New System.Windows.Forms.Label()
        Me.lbContraseña = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lpbLogo = New System.Windows.Forms.PictureBox()
        Me.Administrador = New RecetaElectronica.dbRecetaElectronicaTableAdapters.AdministradorAdaptador()
        CType(Me.lpbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbCodigo
        '
        Me.lbCodigo.Location = New System.Drawing.Point(172, 24)
        Me.lbCodigo.Name = "lbCodigo"
        Me.lbCodigo.Size = New System.Drawing.Size(220, 23)
        Me.lbCodigo.TabIndex = 0
        Me.lbCodigo.Text = "&Código de Usuario:"
        Me.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbContraseña
        '
        Me.lbContraseña.Location = New System.Drawing.Point(172, 81)
        Me.lbContraseña.Name = "lbContraseña"
        Me.lbContraseña.Size = New System.Drawing.Size(220, 23)
        Me.lbContraseña.TabIndex = 2
        Me.lbContraseña.Text = "&Contraseña:"
        Me.lbContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(174, 44)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(220, 20)
        Me.codigo.TabIndex = 1
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(174, 101)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contraseña.Size = New System.Drawing.Size(220, 20)
        Me.contraseña.TabIndex = 3
        '
        'btnAcceder
        '
        Me.btnAcceder.Location = New System.Drawing.Point(197, 161)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(94, 23)
        Me.btnAcceder.TabIndex = 4
        Me.btnAcceder.Text = "&Acceder"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(300, 161)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "&Cancelar"
        '
        'lpbLogo
        '
        Me.lpbLogo.Image = Global.RecetaElectronica.My.Resources.Resources.login
        Me.lpbLogo.Location = New System.Drawing.Point(0, 0)
        Me.lpbLogo.Name = "lpbLogo"
        Me.lpbLogo.Size = New System.Drawing.Size(165, 193)
        Me.lpbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.lpbLogo.TabIndex = 0
        Me.lpbLogo.TabStop = False
        '
        'Administrador
        '
        Me.Administrador.ClearBeforeFill = True
        '
        'AdministracionLogin
        '
        Me.AcceptButton = Me.btnAcceder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.lbContraseña)
        Me.Controls.Add(Me.lbCodigo)
        Me.Controls.Add(Me.lpbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdministracionLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administración - Iniciar Sesión"
        CType(Me.lpbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Administrador As RecetaElectronica.dbRecetaElectronicaTableAdapters.AdministradorAdaptador

End Class
