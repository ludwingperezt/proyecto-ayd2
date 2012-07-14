<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cmbFiltradoEstados = New System.Windows.Forms.ComboBox()
        Me.lblFiltradoEstados = New System.Windows.Forms.Label()
        Me.gbListaProv = New System.Windows.Forms.GroupBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvListaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListaProv.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(182, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(287, 29)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Módulo de Proveedores"
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 554)
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
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(520, 504)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 40)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNProveedor
        '
        Me.btnNProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNProveedor.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNProveedor.Image = CType(resources.GetObject("btnNProveedor.Image"), System.Drawing.Image)
        Me.btnNProveedor.Location = New System.Drawing.Point(307, 421)
        Me.btnNProveedor.Name = "btnNProveedor"
        Me.btnNProveedor.Size = New System.Drawing.Size(97, 77)
        Me.btnNProveedor.TabIndex = 6
        Me.btnNProveedor.Text = "Nuevo Proveedor"
        Me.btnNProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNProveedor.UseVisualStyleBackColor = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(116, 95)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 22
        Me.lblBuscar.Text = "Buscar"
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(116, 63)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(39, 13)
        Me.lblFiltro.TabIndex = 21
        Me.lblFiltro.Text = "Criterio"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(162, 92)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(307, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"NIT", "Empresa", "Propietario", "Estado"})
        Me.cmbFiltro.Location = New System.Drawing.Point(161, 60)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 0
        '
        'dgvListaProveedores
        '
        Me.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaProveedores.Location = New System.Drawing.Point(28, 44)
        Me.dgvListaProveedores.Name = "dgvListaProveedores"
        Me.dgvListaProveedores.Size = New System.Drawing.Size(557, 219)
        Me.dgvListaProveedores.TabIndex = 5
        '
        'btnEliminarProv
        '
        Me.btnEliminarProv.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarProv.Image = CType(resources.GetObject("btnEliminarProv.Image"), System.Drawing.Image)
        Me.btnEliminarProv.Location = New System.Drawing.Point(520, 421)
        Me.btnEliminarProv.Name = "btnEliminarProv"
        Me.btnEliminarProv.Size = New System.Drawing.Size(98, 77)
        Me.btnEliminarProv.TabIndex = 8
        Me.btnEliminarProv.Text = "&Eliminar Proveedor"
        Me.btnEliminarProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarProv.UseVisualStyleBackColor = False
        '
        'btnModificarProv
        '
        Me.btnModificarProv.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarProv.Image = CType(resources.GetObject("btnModificarProv.Image"), System.Drawing.Image)
        Me.btnModificarProv.Location = New System.Drawing.Point(410, 421)
        Me.btnModificarProv.Name = "btnModificarProv"
        Me.btnModificarProv.Size = New System.Drawing.Size(104, 77)
        Me.btnModificarProv.TabIndex = 7
        Me.btnModificarProv.Text = "&Modificar Proveedor"
        Me.btnModificarProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarProv.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Location = New System.Drawing.Point(475, 89)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'cmbFiltradoEstados
        '
        Me.cmbFiltradoEstados.FormattingEnabled = True
        Me.cmbFiltradoEstados.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.cmbFiltradoEstados.Location = New System.Drawing.Point(348, 60)
        Me.cmbFiltradoEstados.Name = "cmbFiltradoEstados"
        Me.cmbFiltradoEstados.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltradoEstados.TabIndex = 1
        Me.cmbFiltradoEstados.Visible = False
        '
        'lblFiltradoEstados
        '
        Me.lblFiltradoEstados.AutoSize = True
        Me.lblFiltradoEstados.Location = New System.Drawing.Point(297, 63)
        Me.lblFiltradoEstados.Name = "lblFiltradoEstados"
        Me.lblFiltradoEstados.Size = New System.Drawing.Size(45, 13)
        Me.lblFiltradoEstados.TabIndex = 24
        Me.lblFiltradoEstados.Text = "Estados"
        Me.lblFiltradoEstados.Visible = False
        '
        'gbListaProv
        '
        Me.gbListaProv.Controls.Add(Me.btnSiguiente)
        Me.gbListaProv.Controls.Add(Me.btnAnterior)
        Me.gbListaProv.Controls.Add(Me.btnRegresar)
        Me.gbListaProv.Controls.Add(Me.dgvListaProveedores)
        Me.gbListaProv.Location = New System.Drawing.Point(33, 132)
        Me.gbListaProv.Name = "gbListaProv"
        Me.gbListaProv.Size = New System.Drawing.Size(610, 283)
        Me.gbListaProv.TabIndex = 25
        Me.gbListaProv.TabStop = False
        Me.gbListaProv.Text = "Lista de Proveedores"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegresar.Image = Global.GestionTextiles.My.Resources.Resources.refresh
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.Location = New System.Drawing.Point(497, 15)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(88, 23)
        Me.btnRegresar.TabIndex = 7
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(286, 15)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 23)
        Me.btnAnterior.TabIndex = 8
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(367, 15)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 9
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'frmModuloProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(667, 576)
        Me.Controls.Add(Me.gbListaProv)
        Me.Controls.Add(Me.lblFiltradoEstados)
        Me.Controls.Add(Me.cmbFiltradoEstados)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnEliminarProv)
        Me.Controls.Add(Me.btnModificarProv)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cmbFiltro)
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
        Me.gbListaProv.ResumeLayout(False)
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
    Friend WithEvents cmbFiltradoEstados As System.Windows.Forms.ComboBox
    Friend WithEvents lblFiltradoEstados As System.Windows.Forms.Label
    Friend WithEvents gbListaProv As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
End Class
