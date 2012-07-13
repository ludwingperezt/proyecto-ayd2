<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarPermiso
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
        Me.lblModulo = New System.Windows.Forms.Label()
        Me.lblRoles = New System.Windows.Forms.Label()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.lblProveedores = New System.Windows.Forms.Label()
        Me.lblProductos = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.clbRoles = New System.Windows.Forms.CheckedListBox()
        Me.clbEmpleados = New System.Windows.Forms.CheckedListBox()
        Me.clbProveedores = New System.Windows.Forms.CheckedListBox()
        Me.clbProductos = New System.Windows.Forms.CheckedListBox()
        Me.lblCompras = New System.Windows.Forms.Label()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.lblVentas = New System.Windows.Forms.Label()
        Me.lblReportes = New System.Windows.Forms.Label()
        Me.lblTalonario = New System.Windows.Forms.Label()
        Me.lblTipos = New System.Windows.Forms.Label()
        Me.clbCompras = New System.Windows.Forms.CheckedListBox()
        Me.clbClientes = New System.Windows.Forms.CheckedListBox()
        Me.clbVentas = New System.Windows.Forms.CheckedListBox()
        Me.clbCliente = New System.Windows.Forms.CheckedListBox()
        Me.clbReportes = New System.Windows.Forms.CheckedListBox()
        Me.clbTalonario = New System.Windows.Forms.CheckedListBox()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblModulo
        '
        Me.lblModulo.AutoSize = True
        Me.lblModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModulo.Location = New System.Drawing.Point(38, 130)
        Me.lblModulo.Name = "lblModulo"
        Me.lblModulo.Size = New System.Drawing.Size(59, 16)
        Me.lblModulo.TabIndex = 0
        Me.lblModulo.Text = "Módulo"
        '
        'lblRoles
        '
        Me.lblRoles.AutoSize = True
        Me.lblRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoles.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblRoles.Location = New System.Drawing.Point(38, 175)
        Me.lblRoles.Name = "lblRoles"
        Me.lblRoles.Size = New System.Drawing.Size(126, 16)
        Me.lblRoles.TabIndex = 0
        Me.lblRoles.Text = "Módulo de Roles"
        '
        'lblEmpleados
        '
        Me.lblEmpleados.AutoSize = True
        Me.lblEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblEmpleados.Location = New System.Drawing.Point(38, 245)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(164, 16)
        Me.lblEmpleados.TabIndex = 0
        Me.lblEmpleados.Text = "Módulo de Empleados"
        '
        'lblProveedores
        '
        Me.lblProveedores.AutoSize = True
        Me.lblProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedores.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblProveedores.Location = New System.Drawing.Point(38, 316)
        Me.lblProveedores.Name = "lblProveedores"
        Me.lblProveedores.Size = New System.Drawing.Size(175, 16)
        Me.lblProveedores.TabIndex = 0
        Me.lblProveedores.Text = "Módulo de Proveedores"
        '
        'lblProductos
        '
        Me.lblProductos.AutoSize = True
        Me.lblProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblProductos.Location = New System.Drawing.Point(390, 180)
        Me.lblProductos.Name = "lblProductos"
        Me.lblProductos.Size = New System.Drawing.Size(155, 16)
        Me.lblProductos.TabIndex = 0
        Me.lblProductos.Text = "Módulo de Productos"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(132, 73)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(294, 20)
        Me.txtNombre.TabIndex = 0
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(38, 76)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'clbRoles
        '
        Me.clbRoles.CheckOnClick = True
        Me.clbRoles.FormattingEnabled = True
        Me.clbRoles.Items.AddRange(New Object() {"Insertar", "Modificar", "Listar", "Eliminar"})
        Me.clbRoles.Location = New System.Drawing.Point(217, 175)
        Me.clbRoles.Name = "clbRoles"
        Me.clbRoles.Size = New System.Drawing.Size(120, 64)
        Me.clbRoles.TabIndex = 1
        '
        'clbEmpleados
        '
        Me.clbEmpleados.CheckOnClick = True
        Me.clbEmpleados.FormattingEnabled = True
        Me.clbEmpleados.Items.AddRange(New Object() {"Insertar", "Modificar", "Listar", "Eliminar"})
        Me.clbEmpleados.Location = New System.Drawing.Point(217, 245)
        Me.clbEmpleados.Name = "clbEmpleados"
        Me.clbEmpleados.Size = New System.Drawing.Size(120, 64)
        Me.clbEmpleados.TabIndex = 2
        '
        'clbProveedores
        '
        Me.clbProveedores.CheckOnClick = True
        Me.clbProveedores.FormattingEnabled = True
        Me.clbProveedores.Items.AddRange(New Object() {"Insertar", "Modificar", "Listar", "Eliminar", "Buscar"})
        Me.clbProveedores.Location = New System.Drawing.Point(217, 316)
        Me.clbProveedores.Name = "clbProveedores"
        Me.clbProveedores.Size = New System.Drawing.Size(120, 79)
        Me.clbProveedores.TabIndex = 3
        '
        'clbProductos
        '
        Me.clbProductos.CheckOnClick = True
        Me.clbProductos.FormattingEnabled = True
        Me.clbProductos.Items.AddRange(New Object() {"Insertar", "Modificar", "Listar", "Eliminar", "Buscar", "Cargar Productos", "Descargar Productos"})
        Me.clbProductos.Location = New System.Drawing.Point(560, 180)
        Me.clbProductos.Name = "clbProductos"
        Me.clbProductos.Size = New System.Drawing.Size(158, 109)
        Me.clbProductos.TabIndex = 5
        '
        'lblCompras
        '
        Me.lblCompras.AutoSize = True
        Me.lblCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompras.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCompras.Location = New System.Drawing.Point(390, 305)
        Me.lblCompras.Name = "lblCompras"
        Me.lblCompras.Size = New System.Drawing.Size(147, 16)
        Me.lblCompras.TabIndex = 0
        Me.lblCompras.Text = "Módulo de Compras"
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblClientes.Location = New System.Drawing.Point(390, 352)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(141, 16)
        Me.lblClientes.TabIndex = 0
        Me.lblClientes.Text = "Módulo de Clientes"
        '
        'lblVentas
        '
        Me.lblVentas.AutoSize = True
        Me.lblVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentas.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblVentas.Location = New System.Drawing.Point(390, 414)
        Me.lblVentas.Name = "lblVentas"
        Me.lblVentas.Size = New System.Drawing.Size(133, 16)
        Me.lblVentas.TabIndex = 0
        Me.lblVentas.Text = "Módulo de Ventas"
        '
        'lblReportes
        '
        Me.lblReportes.AutoSize = True
        Me.lblReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportes.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblReportes.Location = New System.Drawing.Point(759, 252)
        Me.lblReportes.Name = "lblReportes"
        Me.lblReportes.Size = New System.Drawing.Size(72, 16)
        Me.lblReportes.TabIndex = 0
        Me.lblReportes.Text = "Reportes"
        '
        'lblTalonario
        '
        Me.lblTalonario.AutoSize = True
        Me.lblTalonario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTalonario.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTalonario.Location = New System.Drawing.Point(38, 401)
        Me.lblTalonario.Name = "lblTalonario"
        Me.lblTalonario.Size = New System.Drawing.Size(148, 16)
        Me.lblTalonario.TabIndex = 0
        Me.lblTalonario.Text = "Gestión de talonario"
        '
        'lblTipos
        '
        Me.lblTipos.AutoSize = True
        Me.lblTipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTipos.Location = New System.Drawing.Point(759, 175)
        Me.lblTipos.Name = "lblTipos"
        Me.lblTipos.Size = New System.Drawing.Size(122, 16)
        Me.lblTipos.TabIndex = 0
        Me.lblTipos.Text = "Tipos de Cliente"
        '
        'clbCompras
        '
        Me.clbCompras.CheckOnClick = True
        Me.clbCompras.FormattingEnabled = True
        Me.clbCompras.Items.AddRange(New Object() {"Hacer Compras", "Devolver Productos"})
        Me.clbCompras.Location = New System.Drawing.Point(560, 305)
        Me.clbCompras.Name = "clbCompras"
        Me.clbCompras.Size = New System.Drawing.Size(158, 34)
        Me.clbCompras.TabIndex = 6
        '
        'clbClientes
        '
        Me.clbClientes.CheckOnClick = True
        Me.clbClientes.FormattingEnabled = True
        Me.clbClientes.Items.AddRange(New Object() {"Insertar", "Modificar", "Listar"})
        Me.clbClientes.Location = New System.Drawing.Point(560, 352)
        Me.clbClientes.Name = "clbClientes"
        Me.clbClientes.Size = New System.Drawing.Size(158, 49)
        Me.clbClientes.TabIndex = 7
        '
        'clbVentas
        '
        Me.clbVentas.CheckOnClick = True
        Me.clbVentas.FormattingEnabled = True
        Me.clbVentas.Items.AddRange(New Object() {"Hacer Ventas", "Eliminar facturas de ventas"})
        Me.clbVentas.Location = New System.Drawing.Point(560, 414)
        Me.clbVentas.Name = "clbVentas"
        Me.clbVentas.Size = New System.Drawing.Size(158, 34)
        Me.clbVentas.TabIndex = 8
        '
        'clbCliente
        '
        Me.clbCliente.CheckOnClick = True
        Me.clbCliente.FormattingEnabled = True
        Me.clbCliente.Items.AddRange(New Object() {"Insertar", "Modificar", "Listar", "Eliminar"})
        Me.clbCliente.Location = New System.Drawing.Point(906, 175)
        Me.clbCliente.Name = "clbCliente"
        Me.clbCliente.Size = New System.Drawing.Size(206, 64)
        Me.clbCliente.TabIndex = 9
        '
        'clbReportes
        '
        Me.clbReportes.CheckOnClick = True
        Me.clbReportes.FormattingEnabled = True
        Me.clbReportes.Items.AddRange(New Object() {"Corte de caja", "Listar facturas de ventas eliminadas", "Devoluciones por proveedor", "Historial de costos", "Historial de ventas del mes", "Historial del compras del mes"})
        Me.clbReportes.Location = New System.Drawing.Point(906, 248)
        Me.clbReportes.Name = "clbReportes"
        Me.clbReportes.Size = New System.Drawing.Size(206, 94)
        Me.clbReportes.TabIndex = 10
        '
        'clbTalonario
        '
        Me.clbTalonario.CheckOnClick = True
        Me.clbTalonario.FormattingEnabled = True
        Me.clbTalonario.Items.AddRange(New Object() {"Insertar", "Modificar", "Listar", "Eliminar"})
        Me.clbTalonario.Location = New System.Drawing.Point(217, 401)
        Me.clbTalonario.Name = "clbTalonario"
        Me.clbTalonario.Size = New System.Drawing.Size(120, 64)
        Me.clbTalonario.TabIndex = 4
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 493)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(1156, 22)
        Me.stsBarra.TabIndex = 15
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
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(766, 467)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 58
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(859, 467)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 57
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(386, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(192, 29)
        Me.lblTitulo.TabIndex = 59
        Me.lblTitulo.Text = "Nuevo Permiso"
        '
        'frmModificarPermiso
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(1156, 515)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.clbCompras)
        Me.Controls.Add(Me.clbReportes)
        Me.Controls.Add(Me.clbVentas)
        Me.Controls.Add(Me.clbClientes)
        Me.Controls.Add(Me.clbProductos)
        Me.Controls.Add(Me.clbProveedores)
        Me.Controls.Add(Me.clbEmpleados)
        Me.Controls.Add(Me.clbCliente)
        Me.Controls.Add(Me.clbTalonario)
        Me.Controls.Add(Me.clbRoles)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblTipos)
        Me.Controls.Add(Me.lblTalonario)
        Me.Controls.Add(Me.lblReportes)
        Me.Controls.Add(Me.lblVentas)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.lblCompras)
        Me.Controls.Add(Me.lblProductos)
        Me.Controls.Add(Me.lblProveedores)
        Me.Controls.Add(Me.lblEmpleados)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblRoles)
        Me.Controls.Add(Me.lblModulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmModificarPermiso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Permiso"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblModulo As System.Windows.Forms.Label
    Friend WithEvents lblRoles As System.Windows.Forms.Label
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents lblProveedores As System.Windows.Forms.Label
    Friend WithEvents lblProductos As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents clbRoles As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbEmpleados As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbProveedores As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbProductos As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblCompras As System.Windows.Forms.Label
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents lblVentas As System.Windows.Forms.Label
    Friend WithEvents lblReportes As System.Windows.Forms.Label
    Friend WithEvents lblTalonario As System.Windows.Forms.Label
    Friend WithEvents lblTipos As System.Windows.Forms.Label
    Friend WithEvents clbCompras As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbClientes As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbVentas As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbCliente As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbReportes As System.Windows.Forms.CheckedListBox
    Friend WithEvents clbTalonario As System.Windows.Forms.CheckedListBox
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
