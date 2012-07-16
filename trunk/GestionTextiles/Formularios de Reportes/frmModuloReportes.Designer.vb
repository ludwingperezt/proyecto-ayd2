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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.gpAdministrador = New System.Windows.Forms.GroupBox()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnFacturasEliminadasNit = New System.Windows.Forms.Button()
        Me.btnFacturasEliminadasFecha = New System.Windows.Forms.Button()
        Me.btnReporteFacturasasEliminadas = New System.Windows.Forms.Button()
        Me.btnFactura = New System.Windows.Forms.Button()
        Me.btnCorte = New System.Windows.Forms.Button()
        Me.gpCompras = New System.Windows.Forms.GroupBox()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnCostos = New System.Windows.Forms.Button()
        Me.gpProveedores = New System.Windows.Forms.GroupBox()
        Me.btnDevolucionesProveedorFecha = New System.Windows.Forms.Button()
        Me.btnProv = New System.Windows.Forms.Button()
        Me.btnDevolucionesProveedorNit = New System.Windows.Forms.Button()
        Me.btnReporteDevolucionesProveedor = New System.Windows.Forms.Button()
        Me.gpClientes = New System.Windows.Forms.GroupBox()
        Me.btnClientesXTipo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        Me.gpAdministrador.SuspendLayout()
        Me.gpCompras.SuspendLayout()
        Me.gpProveedores.SuspendLayout()
        Me.gpClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(325, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(213, 29)
        Me.lblTitulo.TabIndex = 9
        Me.lblTitulo.Text = "Modulo Reportes"
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 576)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(839, 22)
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
        'gpAdministrador
        '
        Me.gpAdministrador.Controls.Add(Me.btnVentas)
        Me.gpAdministrador.Controls.Add(Me.btnFacturasEliminadasNit)
        Me.gpAdministrador.Controls.Add(Me.btnFacturasEliminadasFecha)
        Me.gpAdministrador.Controls.Add(Me.btnReporteFacturasasEliminadas)
        Me.gpAdministrador.Controls.Add(Me.btnFactura)
        Me.gpAdministrador.Controls.Add(Me.btnCorte)
        Me.gpAdministrador.Location = New System.Drawing.Point(30, 66)
        Me.gpAdministrador.Name = "gpAdministrador"
        Me.gpAdministrador.Size = New System.Drawing.Size(764, 115)
        Me.gpAdministrador.TabIndex = 11
        Me.gpAdministrador.TabStop = False
        Me.gpAdministrador.Text = "Ventas"
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVentas.Image = CType(resources.GetObject("btnVentas.Image"), System.Drawing.Image)
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnVentas.Location = New System.Drawing.Point(58, 78)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(310, 26)
        Me.btnVentas.TabIndex = 5
        Me.btnVentas.Text = "&Ventas Por Rango de Fecha"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnFacturasEliminadasNit
        '
        Me.btnFacturasEliminadasNit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFacturasEliminadasNit.Image = CType(resources.GetObject("btnFacturasEliminadasNit.Image"), System.Drawing.Image)
        Me.btnFacturasEliminadasNit.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnFacturasEliminadasNit.Location = New System.Drawing.Point(413, 19)
        Me.btnFacturasEliminadasNit.Name = "btnFacturasEliminadasNit"
        Me.btnFacturasEliminadasNit.Size = New System.Drawing.Size(310, 24)
        Me.btnFacturasEliminadasNit.TabIndex = 3
        Me.btnFacturasEliminadasNit.Text = "&Listado de Facturas Eliminadas por Nit"
        Me.btnFacturasEliminadasNit.UseVisualStyleBackColor = False
        '
        'btnFacturasEliminadasFecha
        '
        Me.btnFacturasEliminadasFecha.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFacturasEliminadasFecha.Image = CType(resources.GetObject("btnFacturasEliminadasFecha.Image"), System.Drawing.Image)
        Me.btnFacturasEliminadasFecha.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnFacturasEliminadasFecha.Location = New System.Drawing.Point(58, 49)
        Me.btnFacturasEliminadasFecha.Name = "btnFacturasEliminadasFecha"
        Me.btnFacturasEliminadasFecha.Size = New System.Drawing.Size(310, 24)
        Me.btnFacturasEliminadasFecha.TabIndex = 2
        Me.btnFacturasEliminadasFecha.Text = "&Listado de Facturas Eliminadas por Fecha "
        Me.btnFacturasEliminadasFecha.UseVisualStyleBackColor = False
        '
        'btnReporteFacturasasEliminadas
        '
        Me.btnReporteFacturasasEliminadas.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReporteFacturasasEliminadas.Image = CType(resources.GetObject("btnReporteFacturasasEliminadas.Image"), System.Drawing.Image)
        Me.btnReporteFacturasasEliminadas.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnReporteFacturasasEliminadas.Location = New System.Drawing.Point(58, 22)
        Me.btnReporteFacturasasEliminadas.Name = "btnReporteFacturasasEliminadas"
        Me.btnReporteFacturasasEliminadas.Size = New System.Drawing.Size(310, 24)
        Me.btnReporteFacturasasEliminadas.TabIndex = 1
        Me.btnReporteFacturasasEliminadas.Text = "&Listado de Facturas Eliminadas por Fecha y Nit"
        Me.btnReporteFacturasasEliminadas.UseVisualStyleBackColor = False
        '
        'btnFactura
        '
        Me.btnFactura.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFactura.Image = CType(resources.GetObject("btnFactura.Image"), System.Drawing.Image)
        Me.btnFactura.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnFactura.Location = New System.Drawing.Point(413, 78)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(310, 24)
        Me.btnFactura.TabIndex = 0
        Me.btnFactura.Text = "&Factura"
        Me.btnFactura.UseVisualStyleBackColor = False
        '
        'btnCorte
        '
        Me.btnCorte.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCorte.Image = CType(resources.GetObject("btnCorte.Image"), System.Drawing.Image)
        Me.btnCorte.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCorte.Location = New System.Drawing.Point(413, 49)
        Me.btnCorte.Name = "btnCorte"
        Me.btnCorte.Size = New System.Drawing.Size(310, 24)
        Me.btnCorte.TabIndex = 0
        Me.btnCorte.Text = "&Corte de Caja"
        Me.btnCorte.UseVisualStyleBackColor = False
        '
        'gpCompras
        '
        Me.gpCompras.Controls.Add(Me.btnCompras)
        Me.gpCompras.Controls.Add(Me.btnCostos)
        Me.gpCompras.Location = New System.Drawing.Point(30, 187)
        Me.gpCompras.Name = "gpCompras"
        Me.gpCompras.Size = New System.Drawing.Size(764, 88)
        Me.gpCompras.TabIndex = 12
        Me.gpCompras.TabStop = False
        Me.gpCompras.Text = "Compras"
        '
        'btnCompras
        '
        Me.btnCompras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCompras.Location = New System.Drawing.Point(58, 19)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(310, 25)
        Me.btnCompras.TabIndex = 5
        Me.btnCompras.Text = "C&ompras Por Rango de Fecha"
        Me.btnCompras.UseVisualStyleBackColor = False
        '
        'btnCostos
        '
        Me.btnCostos.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCostos.Image = CType(resources.GetObject("btnCostos.Image"), System.Drawing.Image)
        Me.btnCostos.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnCostos.Location = New System.Drawing.Point(413, 19)
        Me.btnCostos.Name = "btnCostos"
        Me.btnCostos.Size = New System.Drawing.Size(310, 25)
        Me.btnCostos.TabIndex = 4
        Me.btnCostos.Text = "Co&stos Por Rango de Fecha"
        Me.btnCostos.UseVisualStyleBackColor = False
        '
        'gpProveedores
        '
        Me.gpProveedores.Controls.Add(Me.btnDevolucionesProveedorFecha)
        Me.gpProveedores.Controls.Add(Me.btnProv)
        Me.gpProveedores.Controls.Add(Me.btnDevolucionesProveedorNit)
        Me.gpProveedores.Controls.Add(Me.btnReporteDevolucionesProveedor)
        Me.gpProveedores.Location = New System.Drawing.Point(30, 298)
        Me.gpProveedores.Name = "gpProveedores"
        Me.gpProveedores.Size = New System.Drawing.Size(764, 87)
        Me.gpProveedores.TabIndex = 15
        Me.gpProveedores.TabStop = False
        Me.gpProveedores.Text = "Proveedores"
        '
        'btnDevolucionesProveedorFecha
        '
        Me.btnDevolucionesProveedorFecha.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDevolucionesProveedorFecha.Image = CType(resources.GetObject("btnDevolucionesProveedorFecha.Image"), System.Drawing.Image)
        Me.btnDevolucionesProveedorFecha.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnDevolucionesProveedorFecha.Location = New System.Drawing.Point(58, 53)
        Me.btnDevolucionesProveedorFecha.Name = "btnDevolucionesProveedorFecha"
        Me.btnDevolucionesProveedorFecha.Size = New System.Drawing.Size(310, 28)
        Me.btnDevolucionesProveedorFecha.TabIndex = 3
        Me.btnDevolucionesProveedorFecha.Text = "D&evoluciónes Proveedor Por Fecha"
        Me.btnDevolucionesProveedorFecha.UseVisualStyleBackColor = False
        '
        'btnProv
        '
        Me.btnProv.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProv.Image = CType(resources.GetObject("btnProv.Image"), System.Drawing.Image)
        Me.btnProv.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnProv.Location = New System.Drawing.Point(413, 53)
        Me.btnProv.Name = "btnProv"
        Me.btnProv.Size = New System.Drawing.Size(310, 28)
        Me.btnProv.TabIndex = 4
        Me.btnProv.Text = "Todos Pr&oveedores"
        Me.btnProv.UseVisualStyleBackColor = False
        '
        'btnDevolucionesProveedorNit
        '
        Me.btnDevolucionesProveedorNit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDevolucionesProveedorNit.Image = CType(resources.GetObject("btnDevolucionesProveedorNit.Image"), System.Drawing.Image)
        Me.btnDevolucionesProveedorNit.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnDevolucionesProveedorNit.Location = New System.Drawing.Point(413, 19)
        Me.btnDevolucionesProveedorNit.Name = "btnDevolucionesProveedorNit"
        Me.btnDevolucionesProveedorNit.Size = New System.Drawing.Size(310, 28)
        Me.btnDevolucionesProveedorNit.TabIndex = 4
        Me.btnDevolucionesProveedorNit.Text = "De&voluciones Proveedor Por Nit"
        Me.btnDevolucionesProveedorNit.UseVisualStyleBackColor = False
        '
        'btnReporteDevolucionesProveedor
        '
        Me.btnReporteDevolucionesProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReporteDevolucionesProveedor.Image = CType(resources.GetObject("btnReporteDevolucionesProveedor.Image"), System.Drawing.Image)
        Me.btnReporteDevolucionesProveedor.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnReporteDevolucionesProveedor.Location = New System.Drawing.Point(58, 19)
        Me.btnReporteDevolucionesProveedor.Name = "btnReporteDevolucionesProveedor"
        Me.btnReporteDevolucionesProveedor.Size = New System.Drawing.Size(310, 28)
        Me.btnReporteDevolucionesProveedor.TabIndex = 2
        Me.btnReporteDevolucionesProveedor.Text = "&Devoluciónes Proveedor por Fecha y Nit"
        Me.btnReporteDevolucionesProveedor.UseVisualStyleBackColor = False
        '
        'gpClientes
        '
        Me.gpClientes.Controls.Add(Me.btnClientesXTipo)
        Me.gpClientes.Controls.Add(Me.Button2)
        Me.gpClientes.Location = New System.Drawing.Point(30, 410)
        Me.gpClientes.Name = "gpClientes"
        Me.gpClientes.Size = New System.Drawing.Size(764, 88)
        Me.gpClientes.TabIndex = 13
        Me.gpClientes.TabStop = False
        Me.gpClientes.Text = "Clientes"
        '
        'btnClientesXTipo
        '
        Me.btnClientesXTipo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClientesXTipo.Image = CType(resources.GetObject("btnClientesXTipo.Image"), System.Drawing.Image)
        Me.btnClientesXTipo.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnClientesXTipo.Location = New System.Drawing.Point(58, 19)
        Me.btnClientesXTipo.Name = "btnClientesXTipo"
        Me.btnClientesXTipo.Size = New System.Drawing.Size(310, 25)
        Me.btnClientesXTipo.TabIndex = 5
        Me.btnClientesXTipo.Text = "Clientes Por Tipo"
        Me.btnClientesXTipo.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button2.Location = New System.Drawing.Point(413, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(310, 25)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Clientes Ordenados Por Compras"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnSalir.Location = New System.Drawing.Point(539, 537)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(214, 36)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmModuloReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(839, 598)
        Me.Controls.Add(Me.gpClientes)
        Me.Controls.Add(Me.gpProveedores)
        Me.Controls.Add(Me.gpCompras)
        Me.Controls.Add(Me.gpAdministrador)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmModuloReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo Reportes"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.gpAdministrador.ResumeLayout(False)
        Me.gpCompras.ResumeLayout(False)
        Me.gpProveedores.ResumeLayout(False)
        Me.gpClientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCorte As System.Windows.Forms.Button
    Friend WithEvents btnReporteFacturasasEliminadas As System.Windows.Forms.Button
    Friend WithEvents btnReporteDevolucionesProveedor As System.Windows.Forms.Button
    Friend WithEvents btnCostos As System.Windows.Forms.Button
    Friend WithEvents btnCompras As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gpAdministrador As System.Windows.Forms.GroupBox
    Friend WithEvents gpCompras As System.Windows.Forms.GroupBox
    Friend WithEvents btnVentas As System.Windows.Forms.Button
    Friend WithEvents gpProveedores As System.Windows.Forms.GroupBox
    Friend WithEvents btnDevolucionesProveedorFecha As System.Windows.Forms.Button
    Friend WithEvents btnDevolucionesProveedorNit As System.Windows.Forms.Button
    Friend WithEvents btnFacturasEliminadasNit As System.Windows.Forms.Button
    Friend WithEvents btnFacturasEliminadasFecha As System.Windows.Forms.Button
    Friend WithEvents btnFactura As System.Windows.Forms.Button
    Friend WithEvents btnProv As System.Windows.Forms.Button
    Friend WithEvents gpClientes As System.Windows.Forms.GroupBox
    Friend WithEvents btnClientesXTipo As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
