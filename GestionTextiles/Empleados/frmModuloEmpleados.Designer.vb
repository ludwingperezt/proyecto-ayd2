﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuloEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModuloEmpleados))
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.lblbusqueda = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnEliminarEmpleados = New System.Windows.Forms.Button()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnIngresarEmpleado = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbListaEmpleados = New System.Windows.Forms.GroupBox()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.lblFiltroCriterio = New System.Windows.Forms.Label()
        Me.cmbFiltroCriterio = New System.Windows.Forms.ComboBox()
        Me.lblFiltradoEstados = New System.Windows.Forms.Label()
        Me.cmbFiltradoEstados = New System.Windows.Forms.ComboBox()
        Me.stsBarra.SuspendLayout()
        Me.gbListaEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 504)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(619, 22)
        Me.stsBarra.TabIndex = 45
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
        Me.btnbuscar.Location = New System.Drawing.Point(437, 112)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(111, 117)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(314, 20)
        Me.txtbusqueda.TabIndex = 2
        '
        'lblbusqueda
        '
        Me.lblbusqueda.AutoSize = True
        Me.lblbusqueda.Location = New System.Drawing.Point(62, 120)
        Me.lblbusqueda.Name = "lblbusqueda"
        Me.lblbusqueda.Size = New System.Drawing.Size(43, 13)
        Me.lblbusqueda.TabIndex = 42
        Me.lblbusqueda.Text = "Buscar:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(195, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(240, 29)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "Módulo Empleados"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEliminarEmpleados
        '
        Me.btnEliminarEmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarEmpleados.Image = CType(resources.GetObject("btnEliminarEmpleados.Image"), System.Drawing.Image)
        Me.btnEliminarEmpleados.Location = New System.Drawing.Point(464, 370)
        Me.btnEliminarEmpleados.Name = "btnEliminarEmpleados"
        Me.btnEliminarEmpleados.Size = New System.Drawing.Size(107, 71)
        Me.btnEliminarEmpleados.TabIndex = 7
        Me.btnEliminarEmpleados.Text = "&Eliminar Empleado"
        Me.btnEliminarEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarEmpleados.UseVisualStyleBackColor = False
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarEmpleado.Image = CType(resources.GetObject("btnModificarEmpleado.Image"), System.Drawing.Image)
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(340, 370)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(108, 72)
        Me.btnModificarEmpleado.TabIndex = 6
        Me.btnModificarEmpleado.Text = "&Modificar Empleado"
        Me.btnModificarEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarEmpleado.UseVisualStyleBackColor = False
        '
        'btnIngresarEmpleado
        '
        Me.btnIngresarEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnIngresarEmpleado.Image = CType(resources.GetObject("btnIngresarEmpleado.Image"), System.Drawing.Image)
        Me.btnIngresarEmpleado.Location = New System.Drawing.Point(211, 370)
        Me.btnIngresarEmpleado.Name = "btnIngresarEmpleado"
        Me.btnIngresarEmpleado.Size = New System.Drawing.Size(106, 72)
        Me.btnIngresarEmpleado.TabIndex = 5
        Me.btnIngresarEmpleado.Text = "&Ingresar Empleado"
        Me.btnIngresarEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIngresarEmpleado.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(464, 463)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(107, 30)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'gbListaEmpleados
        '
        Me.gbListaEmpleados.Controls.Add(Me.dgvEmpleados)
        Me.gbListaEmpleados.Controls.Add(Me.btnRegresar)
        Me.gbListaEmpleados.Location = New System.Drawing.Point(16, 152)
        Me.gbListaEmpleados.Name = "gbListaEmpleados"
        Me.gbListaEmpleados.Size = New System.Drawing.Size(568, 199)
        Me.gbListaEmpleados.TabIndex = 51
        Me.gbListaEmpleados.TabStop = False
        Me.gbListaEmpleados.Text = "Listado Empleados"
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(19, 55)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(536, 131)
        Me.dgvEmpleados.TabIndex = 5
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegresar.Image = Global.GestionTextiles.My.Resources.Resources.refresh
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.Location = New System.Drawing.Point(465, 19)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(90, 25)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'lblFiltroCriterio
        '
        Me.lblFiltroCriterio.AutoSize = True
        Me.lblFiltroCriterio.Location = New System.Drawing.Point(62, 86)
        Me.lblFiltroCriterio.Name = "lblFiltroCriterio"
        Me.lblFiltroCriterio.Size = New System.Drawing.Size(39, 13)
        Me.lblFiltroCriterio.TabIndex = 53
        Me.lblFiltroCriterio.Text = "Criterio"
        '
        'cmbFiltroCriterio
        '
        Me.cmbFiltroCriterio.FormattingEnabled = True
        Me.cmbFiltroCriterio.Items.AddRange(New Object() {"Nombre", "Apellido", "Usuario", "Cedula / DPI"})
        Me.cmbFiltroCriterio.Location = New System.Drawing.Point(107, 83)
        Me.cmbFiltroCriterio.Name = "cmbFiltroCriterio"
        Me.cmbFiltroCriterio.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroCriterio.TabIndex = 0
        '
        'lblFiltradoEstados
        '
        Me.lblFiltradoEstados.AutoSize = True
        Me.lblFiltradoEstados.Location = New System.Drawing.Point(253, 86)
        Me.lblFiltradoEstados.Name = "lblFiltradoEstados"
        Me.lblFiltradoEstados.Size = New System.Drawing.Size(45, 13)
        Me.lblFiltradoEstados.TabIndex = 55
        Me.lblFiltradoEstados.Text = "Estados"
        Me.lblFiltradoEstados.Visible = False
        '
        'cmbFiltradoEstados
        '
        Me.cmbFiltradoEstados.FormattingEnabled = True
        Me.cmbFiltradoEstados.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cmbFiltradoEstados.Location = New System.Drawing.Point(304, 83)
        Me.cmbFiltradoEstados.Name = "cmbFiltradoEstados"
        Me.cmbFiltradoEstados.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltradoEstados.TabIndex = 1
        Me.cmbFiltradoEstados.Visible = False
        '
        'frmModuloEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(619, 526)
        Me.Controls.Add(Me.lblFiltradoEstados)
        Me.Controls.Add(Me.cmbFiltradoEstados)
        Me.Controls.Add(Me.lblFiltroCriterio)
        Me.Controls.Add(Me.cmbFiltroCriterio)
        Me.Controls.Add(Me.gbListaEmpleados)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminarEmpleados)
        Me.Controls.Add(Me.btnModificarEmpleado)
        Me.Controls.Add(Me.btnIngresarEmpleado)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.lblbusqueda)
        Me.MaximizeBox = False
        Me.Name = "frmModuloEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo de Empleados"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.gbListaEmpleados.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lblbusqueda As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnEliminarEmpleados As System.Windows.Forms.Button
    Friend WithEvents btnModificarEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnIngresarEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gbListaEmpleados As System.Windows.Forms.GroupBox
    Friend WithEvents lblFiltroCriterio As System.Windows.Forms.Label
    Friend WithEvents cmbFiltroCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents lblFiltradoEstados As System.Windows.Forms.Label
    Friend WithEvents cmbFiltradoEstados As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
End Class
