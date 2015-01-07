<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SobreRE
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

    Friend WithEvents tlpContenido As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lpbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lbProducto As System.Windows.Forms.Label
    Friend WithEvents lbVersion As System.Windows.Forms.Label
    Friend WithEvents lbCompañia As System.Windows.Forms.Label
    Friend WithEvents tbDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lbCopyright As System.Windows.Forms.Label

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SobreRE))
        Me.tlpContenido = New System.Windows.Forms.TableLayoutPanel()
        Me.lpbLogo = New System.Windows.Forms.PictureBox()
        Me.lbProducto = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbCopyright = New System.Windows.Forms.Label()
        Me.lbCompañia = New System.Windows.Forms.Label()
        Me.tbDescripcion = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.tlpContenido.SuspendLayout()
        CType(Me.lpbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpContenido
        '
        Me.tlpContenido.ColumnCount = 2
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.tlpContenido.Controls.Add(Me.lpbLogo, 0, 0)
        Me.tlpContenido.Controls.Add(Me.lbProducto, 1, 0)
        Me.tlpContenido.Controls.Add(Me.lbVersion, 1, 1)
        Me.tlpContenido.Controls.Add(Me.lbCopyright, 1, 2)
        Me.tlpContenido.Controls.Add(Me.lbCompañia, 1, 3)
        Me.tlpContenido.Controls.Add(Me.tbDescripcion, 1, 4)
        Me.tlpContenido.Controls.Add(Me.btnAceptar, 1, 5)
        Me.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenido.Location = New System.Drawing.Point(9, 9)
        Me.tlpContenido.Name = "tlpContenido"
        Me.tlpContenido.RowCount = 6
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tlpContenido.Size = New System.Drawing.Size(396, 258)
        Me.tlpContenido.TabIndex = 0
        '
        'lpbLogo
        '
        Me.lpbLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lpbLogo.Image = Global.RecetaElectronica.My.Resources.Resources.icon
        Me.lpbLogo.Location = New System.Drawing.Point(3, 3)
        Me.lpbLogo.Name = "lpbLogo"
        Me.tlpContenido.SetRowSpan(Me.lpbLogo, 6)
        Me.lpbLogo.Size = New System.Drawing.Size(124, 252)
        Me.lpbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.lpbLogo.TabIndex = 0
        Me.lpbLogo.TabStop = False
        '
        'lbProducto
        '
        Me.lbProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbProducto.Location = New System.Drawing.Point(136, 0)
        Me.lbProducto.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lbProducto.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lbProducto.Name = "lbProducto"
        Me.lbProducto.Size = New System.Drawing.Size(257, 17)
        Me.lbProducto.TabIndex = 0
        Me.lbProducto.Text = "Nombre de producto"
        Me.lbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbVersion
        '
        Me.lbVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbVersion.Location = New System.Drawing.Point(136, 25)
        Me.lbVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lbVersion.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(257, 17)
        Me.lbVersion.TabIndex = 0
        Me.lbVersion.Text = "Versión"
        Me.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCopyright
        '
        Me.lbCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbCopyright.Location = New System.Drawing.Point(136, 50)
        Me.lbCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lbCopyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lbCopyright.Name = "lbCopyright"
        Me.lbCopyright.Size = New System.Drawing.Size(257, 17)
        Me.lbCopyright.TabIndex = 0
        Me.lbCopyright.Text = "Copyright"
        Me.lbCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCompañia
        '
        Me.lbCompañia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbCompañia.Location = New System.Drawing.Point(136, 75)
        Me.lbCompañia.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.lbCompañia.MaximumSize = New System.Drawing.Size(0, 17)
        Me.lbCompañia.Name = "lbCompañia"
        Me.lbCompañia.Size = New System.Drawing.Size(257, 17)
        Me.lbCompañia.TabIndex = 0
        Me.lbCompañia.Text = "Nombre de la compañía"
        Me.lbCompañia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbDescripcion
        '
        Me.tbDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbDescripcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbDescripcion.Enabled = False
        Me.tbDescripcion.Location = New System.Drawing.Point(136, 103)
        Me.tbDescripcion.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.tbDescripcion.Multiline = True
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.ReadOnly = True
        Me.tbDescripcion.Size = New System.Drawing.Size(257, 123)
        Me.tbDescripcion.TabIndex = 0
        Me.tbDescripcion.TabStop = False
        Me.tbDescripcion.Text = resources.GetString("tbDescripcion.Text")
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAceptar.Location = New System.Drawing.Point(318, 232)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "&Aceptar"
        '
        'SobreRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAceptar
        Me.ClientSize = New System.Drawing.Size(414, 276)
        Me.Controls.Add(Me.tlpContenido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SobreRE"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sobre Receta Electrónica"
        Me.tlpContenido.ResumeLayout(False)
        Me.tlpContenido.PerformLayout()
        CType(Me.lpbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
