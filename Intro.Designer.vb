<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
    Friend WithEvents lbTitulo As System.Windows.Forms.Label
    Friend WithEvents lbVersion As System.Windows.Forms.Label
    Friend WithEvents lbCopyright As System.Windows.Forms.Label
    Friend WithEvents tlpContenido As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpDetalles As System.Windows.Forms.TableLayoutPanel

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Intro))
        Me.tlpContenido = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpDetalles = New System.Windows.Forms.TableLayoutPanel()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbCopyright = New System.Windows.Forms.Label()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.tlpContenido.SuspendLayout()
        Me.tlpDetalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpContenido
        '
        Me.tlpContenido.BackgroundImage = CType(resources.GetObject("tlpContenido.BackgroundImage"), System.Drawing.Image)
        Me.tlpContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tlpContenido.ColumnCount = 2
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243.0!))
        Me.tlpContenido.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253.0!))
        Me.tlpContenido.Controls.Add(Me.tlpDetalles, 1, 1)
        Me.tlpContenido.Controls.Add(Me.lbTitulo, 1, 0)
        Me.tlpContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpContenido.Location = New System.Drawing.Point(0, 0)
        Me.tlpContenido.Name = "tlpContenido"
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218.0!))
        Me.tlpContenido.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpContenido.Size = New System.Drawing.Size(496, 303)
        Me.tlpContenido.TabIndex = 0
        '
        'tlpDetalles
        '
        Me.tlpDetalles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tlpDetalles.BackColor = System.Drawing.Color.Transparent
        Me.tlpDetalles.ColumnCount = 1
        Me.tlpDetalles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247.0!))
        Me.tlpDetalles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142.0!))
        Me.tlpDetalles.Controls.Add(Me.lbVersion, 0, 0)
        Me.tlpDetalles.Controls.Add(Me.lbCopyright, 0, 1)
        Me.tlpDetalles.Location = New System.Drawing.Point(246, 221)
        Me.tlpDetalles.Name = "tlpDetalles"
        Me.tlpDetalles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpDetalles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tlpDetalles.Size = New System.Drawing.Size(247, 79)
        Me.tlpDetalles.TabIndex = 1
        '
        'lbVersion
        '
        Me.lbVersion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbVersion.BackColor = System.Drawing.Color.Transparent
        Me.lbVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVersion.Location = New System.Drawing.Point(3, 9)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(241, 20)
        Me.lbVersion.TabIndex = 1
        Me.lbVersion.Text = "Versión {0}.{1}.{2}.{3}"
        '
        'lbCopyright
        '
        Me.lbCopyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lbCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCopyright.Location = New System.Drawing.Point(3, 39)
        Me.lbCopyright.Name = "lbCopyright"
        Me.lbCopyright.Size = New System.Drawing.Size(241, 40)
        Me.lbCopyright.TabIndex = 2
        Me.lbCopyright.Text = "Copyright"
        '
        'lbTitulo
        '
        Me.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lbTitulo.Font = New System.Drawing.Font("Cocon", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbTitulo.Location = New System.Drawing.Point(246, 3)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(247, 212)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "Título de la aplicación"
        Me.lbTitulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlpContenido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Intro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.tlpContenido.ResumeLayout(False)
        Me.tlpDetalles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

End Class
