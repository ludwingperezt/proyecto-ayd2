﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lbllistaclientes = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnIngresarProducto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.slblDescripcion.Size = New System.Drawing.Size(61, 17)
        Me.slblDescripcion.Text = "Descripción"
        '
        'slblFecha
        '
        Me.slblFecha.Name = "slblFecha"
        Me.slblFecha.Size = New System.Drawing.Size(81, 17)
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
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(23, 147)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.Size = New System.Drawing.Size(544, 132)
        Me.dgvEmpleados.TabIndex = 51
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
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarProducto.Image = CType(resources.GetObject("btnEliminarProducto.Image"), System.Drawing.Image)
        Me.btnEliminarProducto.Location = New System.Drawing.Point(369, 303)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(107, 71)
        Me.btnEliminarProducto.TabIndex = 60
        Me.btnEliminarProducto.Text = "&Eliminar Producto"
        Me.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarProducto.UseVisualStyleBackColor = False
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarProducto.Image = CType(resources.GetObject("btnModificarProducto.Image"), System.Drawing.Image)
        Me.btnModificarProducto.Location = New System.Drawing.Point(246, 303)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(108, 72)
        Me.btnModificarProducto.TabIndex = 59
        Me.btnModificarProducto.Text = "&Modificar Producto"
        Me.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarProducto.UseVisualStyleBackColor = False
        '
        'btnIngresarProducto
        '
        Me.btnIngresarProducto.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIngresarProducto.Image = CType(resources.GetObject("btnIngresarProducto.Image"), System.Drawing.Image)
        Me.btnIngresarProducto.Location = New System.Drawing.Point(116, 303)
        Me.btnIngresarProducto.Name = "btnIngresarProducto"
        Me.btnIngresarProducto.Size = New System.Drawing.Size(106, 72)
        Me.btnIngresarProducto.TabIndex = 58
        Me.btnIngresarProducto.Text = "&Ingresar Producto"
        Me.btnIngresarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIngresarProducto.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(420, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(495, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 44)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Seleccionar producto"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmModuloProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 478)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminarProducto)
        Me.Controls.Add(Me.btnModificarProducto)
        Me.Controls.Add(Me.btnIngresarProducto)
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
    Friend WithEvents lbllistaclientes As System.Windows.Forms.Label
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class