﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarProveedores
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
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvListaProveedores = New System.Windows.Forms.DataGridView()
        Me.dgvtxtNIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtPropietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtxtTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvCelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvListaProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 427)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(609, 22)
        Me.stsBarra.TabIndex = 9
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
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(195, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(260, 29)
        Me.lblTitulo.TabIndex = 8
        Me.lblTitulo.Text = "Lista de Proveedores"
        '
        'dgvListaProveedores
        '
        Me.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvtxtNIT, Me.dgvtxtEmpresa, Me.dgvtxtDescripcion, Me.dgvtxtDireccion, Me.dgvtxtPropietario, Me.dgvtxtTelefono, Me.dgvCelular})
        Me.dgvListaProveedores.Location = New System.Drawing.Point(30, 141)
        Me.dgvListaProveedores.Name = "dgvListaProveedores"
        Me.dgvListaProveedores.Size = New System.Drawing.Size(557, 200)
        Me.dgvListaProveedores.TabIndex = 2
        '
        'dgvtxtNIT
        '
        Me.dgvtxtNIT.HeaderText = "NIT"
        Me.dgvtxtNIT.Name = "dgvtxtNIT"
        '
        'dgvtxtEmpresa
        '
        Me.dgvtxtEmpresa.HeaderText = "Empresa"
        Me.dgvtxtEmpresa.Name = "dgvtxtEmpresa"
        '
        'dgvtxtDescripcion
        '
        Me.dgvtxtDescripcion.HeaderText = "Descripción"
        Me.dgvtxtDescripcion.Name = "dgvtxtDescripcion"
        '
        'dgvtxtDireccion
        '
        Me.dgvtxtDireccion.HeaderText = "Dirección"
        Me.dgvtxtDireccion.Name = "dgvtxtDireccion"
        '
        'dgvtxtPropietario
        '
        Me.dgvtxtPropietario.HeaderText = "Propietario"
        Me.dgvtxtPropietario.Name = "dgvtxtPropietario"
        '
        'dgvtxtTelefono
        '
        Me.dgvtxtTelefono.HeaderText = "Telefono"
        Me.dgvtxtTelefono.Name = "dgvtxtTelefono"
        '
        'dgvCelular
        '
        Me.dgvCelular.HeaderText = "Celular"
        Me.dgvCelular.Name = "dgvCelular"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(512, 361)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"NIT", "Empresa", "Propietario"})
        Me.cmbFiltro.Location = New System.Drawing.Point(91, 50)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 0
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(91, 82)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(194, 20)
        Me.txtBusqueda.TabIndex = 1
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(27, 53)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(39, 13)
        Me.lblFiltro.TabIndex = 14
        Me.lblFiltro.Text = "Criterio"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(27, 85)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 14
        Me.lblBuscar.Text = "Buscar"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(420, 361)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'frmListarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 449)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.dgvListaProveedores)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmListarProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Proveedores"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        CType(Me.dgvListaProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dgvListaProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgvtxtNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtEmpresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtPropietario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtxtTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvCelular As System.Windows.Forms.DataGridViewTextBoxColumn
End Class