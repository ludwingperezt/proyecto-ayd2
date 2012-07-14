<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuloProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModuloProductos))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.lblbusqueda = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.gbListaProductos = New System.Windows.Forms.GroupBox()
        Me.lblCriterioBusqueda = New System.Windows.Forms.Label()
        Me.chCodigo = New System.Windows.Forms.CheckBox()
        Me.chNombre = New System.Windows.Forms.CheckBox()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSeleccionarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnIngresarProducto = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListaProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(195, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(248, 31)
        Me.lblTitulo.TabIndex = 57
        Me.lblTitulo.Text = "Módulo Productos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 625)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(617, 22)
        Me.stsBarra.TabIndex = 56
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
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Location = New System.Drawing.Point(492, 75)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 1
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(166, 78)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(320, 20)
        Me.txtbusqueda.TabIndex = 0
        '
        'lblbusqueda
        '
        Me.lblbusqueda.AutoSize = True
        Me.lblbusqueda.Location = New System.Drawing.Point(31, 81)
        Me.lblbusqueda.Name = "lblbusqueda"
        Me.lblbusqueda.Size = New System.Drawing.Size(129, 13)
        Me.lblbusqueda.TabIndex = 53
        Me.lblbusqueda.Text = "Ingrese el texto a buscar: "
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(14, 48)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.Size = New System.Drawing.Size(544, 298)
        Me.dgvEmpleados.TabIndex = 51
        '
        'gbListaProductos
        '
        Me.gbListaProductos.Controls.Add(Me.btnSiguiente)
        Me.gbListaProductos.Controls.Add(Me.btnAnterior)
        Me.gbListaProductos.Controls.Add(Me.dgvEmpleados)
        Me.gbListaProductos.Controls.Add(Me.btnRegresar)
        Me.gbListaProductos.Location = New System.Drawing.Point(20, 111)
        Me.gbListaProductos.Name = "gbListaProductos"
        Me.gbListaProductos.Size = New System.Drawing.Size(575, 381)
        Me.gbListaProductos.TabIndex = 65
        Me.gbListaProductos.TabStop = False
        Me.gbListaProductos.Text = "Lista Productos:"
        '
        'lblCriterioBusqueda
        '
        Me.lblCriterioBusqueda.AutoSize = True
        Me.lblCriterioBusqueda.Location = New System.Drawing.Point(31, 54)
        Me.lblCriterioBusqueda.Name = "lblCriterioBusqueda"
        Me.lblCriterioBusqueda.Size = New System.Drawing.Size(104, 13)
        Me.lblCriterioBusqueda.TabIndex = 67
        Me.lblCriterioBusqueda.Text = "Criterio de búsqueda"
        '
        'chCodigo
        '
        Me.chCodigo.AutoSize = True
        Me.chCodigo.Checked = True
        Me.chCodigo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chCodigo.Location = New System.Drawing.Point(168, 51)
        Me.chCodigo.Name = "chCodigo"
        Me.chCodigo.Size = New System.Drawing.Size(59, 17)
        Me.chCodigo.TabIndex = 68
        Me.chCodigo.Text = "Código"
        Me.chCodigo.UseVisualStyleBackColor = True
        '
        'chNombre
        '
        Me.chNombre.AutoSize = True
        Me.chNombre.Location = New System.Drawing.Point(233, 53)
        Me.chNombre.Name = "chNombre"
        Me.chNombre.Size = New System.Drawing.Size(63, 17)
        Me.chNombre.TabIndex = 69
        Me.chNombre.Text = "Nombre"
        Me.chNombre.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSiguiente.Image = Global.GestionTextiles.My.Resources.Resources.bluesharp1
        Me.btnSiguiente.Location = New System.Drawing.Point(483, 352)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 53
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAnterior.Image = Global.GestionTextiles.My.Resources.Resources.bluesharp2
        Me.btnAnterior.Location = New System.Drawing.Point(400, 352)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 23)
        Me.btnAnterior.TabIndex = 52
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegresar.Image = Global.GestionTextiles.My.Resources.Resources.refresh
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.Location = New System.Drawing.Point(470, 19)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(88, 23)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(492, 586)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 30)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnSeleccionarProducto
        '
        Me.btnSeleccionarProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSeleccionarProducto.Image = Global.GestionTextiles.My.Resources.Resources.wintick1
        Me.btnSeleccionarProducto.Location = New System.Drawing.Point(492, 509)
        Me.btnSeleccionarProducto.Name = "btnSeleccionarProducto"
        Me.btnSeleccionarProducto.Size = New System.Drawing.Size(103, 71)
        Me.btnSeleccionarProducto.TabIndex = 6
        Me.btnSeleccionarProducto.Text = "&Seleccionar "
        Me.btnSeleccionarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSeleccionarProducto.UseVisualStyleBackColor = False
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarProducto.Image = CType(resources.GetObject("btnEliminarProducto.Image"), System.Drawing.Image)
        Me.btnEliminarProducto.Location = New System.Drawing.Point(379, 509)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(107, 71)
        Me.btnEliminarProducto.TabIndex = 5
        Me.btnEliminarProducto.Text = "&Eliminar Producto"
        Me.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarProducto.UseVisualStyleBackColor = False
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarProducto.Image = CType(resources.GetObject("btnModificarProducto.Image"), System.Drawing.Image)
        Me.btnModificarProducto.Location = New System.Drawing.Point(256, 509)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(108, 72)
        Me.btnModificarProducto.TabIndex = 4
        Me.btnModificarProducto.Text = "&Modificar Producto"
        Me.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarProducto.UseVisualStyleBackColor = False
        '
        'btnIngresarProducto
        '
        Me.btnIngresarProducto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIngresarProducto.Image = CType(resources.GetObject("btnIngresarProducto.Image"), System.Drawing.Image)
        Me.btnIngresarProducto.Location = New System.Drawing.Point(126, 509)
        Me.btnIngresarProducto.Name = "btnIngresarProducto"
        Me.btnIngresarProducto.Size = New System.Drawing.Size(106, 72)
        Me.btnIngresarProducto.TabIndex = 3
        Me.btnIngresarProducto.Text = "&Ingresar Producto"
        Me.btnIngresarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIngresarProducto.UseVisualStyleBackColor = False
        '
        'frmModuloProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 647)
        Me.Controls.Add(Me.chNombre)
        Me.Controls.Add(Me.chCodigo)
        Me.Controls.Add(Me.lblCriterioBusqueda)
        Me.Controls.Add(Me.gbListaProductos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSeleccionarProducto)
        Me.Controls.Add(Me.btnEliminarProducto)
        Me.Controls.Add(Me.btnModificarProducto)
        Me.Controls.Add(Me.btnIngresarProducto)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.lblbusqueda)
        Me.Name = "frmModuloProductos"
        Me.Text = "frmModuloProductos"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbListaProductos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEliminarProducto As System.Windows.Forms.Button
    Friend WithEvents btnModificarProducto As System.Windows.Forms.Button
    Friend WithEvents btnIngresarProducto As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lblbusqueda As System.Windows.Forms.Label
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionarProducto As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbListaProductos As System.Windows.Forms.GroupBox
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents lblCriterioBusqueda As System.Windows.Forms.Label
    Friend WithEvents chCodigo As System.Windows.Forms.CheckBox
    Friend WithEvents chNombre As System.Windows.Forms.CheckBox
End Class
