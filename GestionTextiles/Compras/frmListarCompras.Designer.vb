<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarCompras
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
        Me.dgvtxtNIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvtxtPropietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvtxtDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.dgvCelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvListaProveedores = New System.Windows.Forms.DataGridView()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.dgvListaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvtxtNIT
        '
        Me.dgvtxtNIT.HeaderText = "NIT"
        Me.dgvtxtNIT.Name = "dgvtxtNIT"
        '
        'dgvtxtTelefono
        '
        Me.dgvtxtTelefono.HeaderText = "Telefono"
        Me.dgvtxtTelefono.Name = "dgvtxtTelefono"
        '
        'dgvtxtEmpresa
        '
        Me.dgvtxtEmpresa.HeaderText = "Empresa"
        Me.dgvtxtEmpresa.Name = "dgvtxtEmpresa"
        '
        'slblFecha
        '
        Me.slblFecha.Name = "slblFecha"
        Me.slblFecha.Size = New System.Drawing.Size(90, 17)
        Me.slblFecha.Text = "FECHA Y HORA"
        '
        'dgvtxtPropietario
        '
        Me.dgvtxtPropietario.HeaderText = "Propietario"
        Me.dgvtxtPropietario.Name = "dgvtxtPropietario"
        '
        'dgvtxtDescripcion
        '
        Me.dgvtxtDescripcion.HeaderText = "Descripción"
        Me.dgvtxtDescripcion.Name = "dgvtxtDescripcion"
        '
        'slblDescripcion
        '
        Me.slblDescripcion.AutoToolTip = True
        Me.slblDescripcion.Name = "slblDescripcion"
        Me.slblDescripcion.Size = New System.Drawing.Size(69, 17)
        Me.slblDescripcion.Text = "Descripción"
        '
        'dgvtxtDireccion
        '
        Me.dgvtxtDireccion.HeaderText = "Dirección"
        Me.dgvtxtDireccion.Name = "dgvtxtDireccion"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(512, 357)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(27, 80)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 22
        Me.lblBuscar.Text = "Buscar"
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(27, 48)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(39, 13)
        Me.lblFiltro.TabIndex = 23
        Me.lblFiltro.Text = "Criterio"
        '
        'dgvCelular
        '
        Me.dgvCelular.HeaderText = "Celular"
        Me.dgvCelular.Name = "dgvCelular"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(91, 77)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(194, 20)
        Me.txtBusqueda.TabIndex = 21
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"NIT", "Empresa", "Propietario"})
        Me.cmbFiltro.Location = New System.Drawing.Point(91, 45)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 20
        '
        'dgvListaProveedores
        '
        Me.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvtxtNIT, Me.dgvtxtEmpresa, Me.dgvtxtDescripcion, Me.dgvtxtDireccion, Me.dgvtxtPropietario, Me.dgvtxtTelefono, Me.dgvCelular})
        Me.dgvListaProveedores.Location = New System.Drawing.Point(30, 136)
        Me.dgvListaProveedores.Name = "dgvListaProveedores"
        Me.dgvListaProveedores.Size = New System.Drawing.Size(557, 200)
        Me.dgvListaProveedores.TabIndex = 18
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 395)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(609, 22)
        Me.stsBarra.TabIndex = 17
        Me.stsBarra.Text = "StatusStrip1"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(127, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(368, 29)
        Me.lblTitulo.TabIndex = 16
        Me.lblTitulo.Text = "Lista de Facturas de Compras"
        '
        'frmListarCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 417)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.dgvListaProveedores)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblTitulo)
        Me.MaximizeBox = False
        Me.Name = "frmListarCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Compras"
        CType(Me.dgvListaProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvtxtNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtEmpresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgvtxtPropietario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgvtxtDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents dgvCelular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents dgvListaProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
