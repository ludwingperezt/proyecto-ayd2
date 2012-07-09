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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminarEmpleados = New System.Windows.Forms.Button()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnIngresarEmpleado = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.lblbusqueda = New System.Windows.Forms.Label()
        Me.lbllistaclientes = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(126, 381)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(350, 64)
        Me.btnSalir.TabIndex = 61
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnEliminarEmpleados
        '
        Me.btnEliminarEmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarEmpleados.Image = CType(resources.GetObject("btnEliminarEmpleados.Image"), System.Drawing.Image)
        Me.btnEliminarEmpleados.Location = New System.Drawing.Point(369, 303)
        Me.btnEliminarEmpleados.Name = "btnEliminarEmpleados"
        Me.btnEliminarEmpleados.Size = New System.Drawing.Size(107, 71)
        Me.btnEliminarEmpleados.TabIndex = 60
        Me.btnEliminarEmpleados.Text = "&Eliminar Producto"
        Me.btnEliminarEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarEmpleados.UseVisualStyleBackColor = False
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarEmpleado.Image = CType(resources.GetObject("btnModificarEmpleado.Image"), System.Drawing.Image)
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(245, 303)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(108, 72)
        Me.btnModificarEmpleado.TabIndex = 59
        Me.btnModificarEmpleado.Text = "&Modificar Producto"
        Me.btnModificarEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarEmpleado.UseVisualStyleBackColor = False
        '
        'btnIngresarEmpleado
        '
        Me.btnIngresarEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIngresarEmpleado.Image = CType(resources.GetObject("btnIngresarEmpleado.Image"), System.Drawing.Image)
        Me.btnIngresarEmpleado.Location = New System.Drawing.Point(116, 303)
        Me.btnIngresarEmpleado.Name = "btnIngresarEmpleado"
        Me.btnIngresarEmpleado.Size = New System.Drawing.Size(106, 72)
        Me.btnIngresarEmpleado.TabIndex = 58
        Me.btnIngresarEmpleado.Text = "&Ingresar Producto"
        Me.btnIngresarEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIngresarEmpleado.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(195, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(227, 29)
        Me.lblTitulo.TabIndex = 57
        Me.lblTitulo.Text = "Módulo Productos"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 456)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(641, 22)
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
        Me.btnbuscar.Location = New System.Drawing.Point(447, 80)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 55
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(35, 85)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(400, 20)
        Me.txtbusqueda.TabIndex = 54
        '
        'lblbusqueda
        '
        Me.lblbusqueda.AutoSize = True
        Me.lblbusqueda.Location = New System.Drawing.Point(32, 58)
        Me.lblbusqueda.Name = "lblbusqueda"
        Me.lblbusqueda.Size = New System.Drawing.Size(129, 13)
        Me.lblbusqueda.TabIndex = 53
        Me.lblbusqueda.Text = "Ingrese el texto a buscar: "
        '
        'lbllistaclientes
        '
        Me.lbllistaclientes.AutoSize = True
        Me.lbllistaclientes.Location = New System.Drawing.Point(32, 122)
        Me.lbllistaclientes.Name = "lbllistaclientes"
        Me.lbllistaclientes.Size = New System.Drawing.Size(87, 13)
        Me.lbllistaclientes.TabIndex = 52
        Me.lbllistaclientes.Text = "Listado Clientes: "
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column4, Me.Column3, Me.Column5, Me.Column6, Me.Column7})
        Me.dgvEmpleados.Location = New System.Drawing.Point(23, 147)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(544, 132)
        Me.dgvEmpleados.TabIndex = 51
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Cedula / DPI"
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        Me.Column4.FillWeight = 75.0!
        Me.Column4.HeaderText = "Dirección"
        Me.Column4.Name = "Column4"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Telefono"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Celular"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha Contrato"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Sueldo"
        Me.Column7.Name = "Column7"
        '
        'frmModuloProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 478)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminarEmpleados)
        Me.Controls.Add(Me.btnModificarEmpleado)
        Me.Controls.Add(Me.btnIngresarEmpleado)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.lblbusqueda)
        Me.Controls.Add(Me.lbllistaclientes)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Name = "frmModuloProductos"
        Me.Text = "frmModuloProductos"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminarEmpleados As System.Windows.Forms.Button
    Friend WithEvents btnModificarEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnIngresarEmpleado As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lblbusqueda As System.Windows.Forms.Label
    Friend WithEvents lbllistaclientes As System.Windows.Forms.Label
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
