<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuloReportes
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModuloReportes))
        Me.btnCorte = New System.Windows.Forms.Button()
        Me.btnReporteFacturasasEliminadas = New System.Windows.Forms.Button()
        Me.btnReporteDevolucionesProveedor = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnCProveedor = New System.Windows.Forms.Button()
        Me.btnCMes = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCorte
        '
        Me.btnCorte.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCorte.Image = CType(resources.GetObject("btnCorte.Image"), System.Drawing.Image)
        Me.btnCorte.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCorte.Location = New System.Drawing.Point(36, 76)
        Me.btnCorte.Name = "btnCorte"
        Me.btnCorte.Size = New System.Drawing.Size(214, 39)
        Me.btnCorte.TabIndex = 0
        Me.btnCorte.Text = "&Corte de Caja"
        Me.btnCorte.UseVisualStyleBackColor = False
        '
        'btnReporteFacturasasEliminadas
        '
        Me.btnReporteFacturasasEliminadas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReporteFacturasasEliminadas.Image = CType(resources.GetObject("btnReporteFacturasasEliminadas.Image"), System.Drawing.Image)
        Me.btnReporteFacturasasEliminadas.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnReporteFacturasasEliminadas.Location = New System.Drawing.Point(277, 76)
        Me.btnReporteFacturasasEliminadas.Name = "btnReporteFacturasasEliminadas"
        Me.btnReporteFacturasasEliminadas.Size = New System.Drawing.Size(214, 37)
        Me.btnReporteFacturasasEliminadas.TabIndex = 1
        Me.btnReporteFacturasasEliminadas.Text = "&Listado de Facturas Eliminadas"
        Me.btnReporteFacturasasEliminadas.UseVisualStyleBackColor = False
        '
        'btnReporteDevolucionesProveedor
        '
        Me.btnReporteDevolucionesProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReporteDevolucionesProveedor.Image = CType(resources.GetObject("btnReporteDevolucionesProveedor.Image"), System.Drawing.Image)
        Me.btnReporteDevolucionesProveedor.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnReporteDevolucionesProveedor.Location = New System.Drawing.Point(520, 76)
        Me.btnReporteDevolucionesProveedor.Name = "btnReporteDevolucionesProveedor"
        Me.btnReporteDevolucionesProveedor.Size = New System.Drawing.Size(214, 37)
        Me.btnReporteDevolucionesProveedor.TabIndex = 2
        Me.btnReporteDevolucionesProveedor.Text = "&Devoluciónes Proveedor"
        Me.btnReporteDevolucionesProveedor.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button4.Location = New System.Drawing.Point(36, 148)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(214, 38)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button5.Location = New System.Drawing.Point(277, 148)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(214, 38)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button6.Location = New System.Drawing.Point(520, 148)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(214, 38)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnCProveedor
        '
        Me.btnCProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCProveedor.Image = CType(resources.GetObject("btnCProveedor.Image"), System.Drawing.Image)
        Me.btnCProveedor.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCProveedor.Location = New System.Drawing.Point(36, 224)
        Me.btnCProveedor.Name = "btnCProveedor"
        Me.btnCProveedor.Size = New System.Drawing.Size(214, 35)
        Me.btnCProveedor.TabIndex = 6
        Me.btnCProveedor.Text = "Créditos por Proveedor"
        Me.btnCProveedor.UseVisualStyleBackColor = False
        '
        'btnCMes
        '
        Me.btnCMes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCMes.Image = CType(resources.GetObject("btnCMes.Image"), System.Drawing.Image)
        Me.btnCMes.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCMes.Location = New System.Drawing.Point(277, 224)
        Me.btnCMes.Name = "btnCMes"
        Me.btnCMes.Size = New System.Drawing.Size(214, 35)
        Me.btnCMes.TabIndex = 7
        Me.btnCMes.Text = "Créditos Por Mes"
        Me.btnCMes.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSalir.Location = New System.Drawing.Point(520, 224)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(214, 35)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(310, 23)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(213, 29)
        Me.lblTitulo.TabIndex = 9
        Me.lblTitulo.Text = "Modulo Reportes"
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 269)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(779, 22)
        Me.stsBarra.TabIndex = 10
        Me.stsBarra.Text = "StatusStrip1"
        '
        'slblDescripcion
        '
        Me.slblDescripcion.AutoToolTip = True
        Me.slblDescripcion.Name = "slblDescripcion"
        Me.slblDescripcion.Size = New System.Drawing.Size(69, 17)
        Me.slblDescripcion.Text = "Descripción"
        '
        'slblFecha
        '
        Me.slblFecha.Name = "slblFecha"
        Me.slblFecha.Size = New System.Drawing.Size(90, 17)
        Me.slblFecha.Text = "FECHA Y HORA"
        '
        'frmModuloReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(779, 291)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCMes)
        Me.Controls.Add(Me.btnCProveedor)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnReporteDevolucionesProveedor)
        Me.Controls.Add(Me.btnReporteFacturasasEliminadas)
        Me.Controls.Add(Me.btnCorte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmModuloReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo Reportes"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCorte As System.Windows.Forms.Button
    Friend WithEvents btnReporteFacturasasEliminadas As System.Windows.Forms.Button
    Friend WithEvents btnReporteDevolucionesProveedor As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnCProveedor As System.Windows.Forms.Button
    Friend WithEvents btnCMes As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
End Class
