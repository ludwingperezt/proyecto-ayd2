﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuloProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModuloProveedores))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNProveedor = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvListaProveedores = New System.Windows.Forms.DataGridView()
        Me.btnEliminarProv = New System.Windows.Forms.Button()
        Me.btnModificarProv = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvListaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(182, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(287, 29)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Módulo de Proveedores"
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 489)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(667, 22)
        Me.stsBarra.TabIndex = 7
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
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(444, 398)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 77)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNProveedor
        '
        Me.btnNProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNProveedor.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNProveedor.Image = CType(resources.GetObject("btnNProveedor.Image"), System.Drawing.Image)
        Me.btnNProveedor.Location = New System.Drawing.Point(127, 398)
        Me.btnNProveedor.Name = "btnNProveedor"
        Me.btnNProveedor.Size = New System.Drawing.Size(97, 77)
        Me.btnNProveedor.TabIndex = 4
        Me.btnNProveedor.Text = "Nuevo Proveedor"
        Me.btnNProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNProveedor.UseVisualStyleBackColor = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(50, 124)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 22
        Me.lblBuscar.Text = "Buscar"
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(50, 92)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(39, 13)
        Me.lblFiltro.TabIndex = 21
        Me.lblFiltro.Text = "Criterio"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(114, 121)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(307, 20)
        Me.txtBusqueda.TabIndex = 1
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"NIT", "Empresa", "Propietario"})
        Me.cmbFiltro.Location = New System.Drawing.Point(114, 89)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 0
        '
        'dgvListaProveedores
        '
        Me.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaProveedores.Location = New System.Drawing.Point(53, 161)
        Me.dgvListaProveedores.Name = "dgvListaProveedores"
        Me.dgvListaProveedores.Size = New System.Drawing.Size(557, 219)
        Me.dgvListaProveedores.TabIndex = 3
        '
        'btnEliminarProv
        '
        Me.btnEliminarProv.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarProv.Image = CType(resources.GetObject("btnEliminarProv.Image"), System.Drawing.Image)
        Me.btnEliminarProv.Location = New System.Drawing.Point(340, 398)
        Me.btnEliminarProv.Name = "btnEliminarProv"
        Me.btnEliminarProv.Size = New System.Drawing.Size(98, 77)
        Me.btnEliminarProv.TabIndex = 6
        Me.btnEliminarProv.Text = "&Eliminar Proveedor"
        Me.btnEliminarProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarProv.UseVisualStyleBackColor = False
        '
        'btnModificarProv
        '
        Me.btnModificarProv.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarProv.Image = CType(resources.GetObject("btnModificarProv.Image"), System.Drawing.Image)
        Me.btnModificarProv.Location = New System.Drawing.Point(230, 398)
        Me.btnModificarProv.Name = "btnModificarProv"
        Me.btnModificarProv.Size = New System.Drawing.Size(104, 77)
        Me.btnModificarProv.TabIndex = 5
        Me.btnModificarProv.Text = "&Modificar Proveedor"
        Me.btnModificarProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarProv.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Location = New System.Drawing.Point(468, 121)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'frmModuloProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(667, 511)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnEliminarProv)
        Me.Controls.Add(Me.btnModificarProv)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.dgvListaProveedores)
        Me.Controls.Add(Me.btnNProveedor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmModuloProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo de Proveedores"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        CType(Me.dgvListaProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNProveedor As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents dgvListaProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminarProv As System.Windows.Forms.Button
    Friend WithEvents btnModificarProv As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
End Class
