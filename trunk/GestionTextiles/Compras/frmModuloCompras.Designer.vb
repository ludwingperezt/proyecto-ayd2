<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuloCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModuloCompras))
        Me.btnNCompra = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.dgvListaCompras = New System.Windows.Forms.DataGridView()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnAnularCompra = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.gbListaCompras = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvListaCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListaCompras.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNCompra
        '
        Me.btnNCompra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNCompra.Image = CType(resources.GetObject("btnNCompra.Image"), System.Drawing.Image)
        Me.btnNCompra.Location = New System.Drawing.Point(383, 460)
        Me.btnNCompra.Name = "btnNCompra"
        Me.btnNCompra.Size = New System.Drawing.Size(97, 77)
        Me.btnNCompra.TabIndex = 5
        Me.btnNCompra.Text = "Nueva Compra"
        Me.btnNCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNCompra.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(492, 541)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 37)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 581)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(618, 22)
        Me.stsBarra.TabIndex = 12
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
        Me.lblTitulo.Location = New System.Drawing.Point(186, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(247, 29)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Módulo de Compras"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(31, 108)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 30
        Me.lblBuscar.Text = "Buscar"
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(31, 76)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(39, 13)
        Me.lblFiltro.TabIndex = 31
        Me.lblFiltro.Text = "Criterio"
        '
        'dgvListaCompras
        '
        Me.dgvListaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCompras.Location = New System.Drawing.Point(21, 46)
        Me.dgvListaCompras.Name = "dgvListaCompras"
        Me.dgvListaCompras.Size = New System.Drawing.Size(557, 252)
        Me.dgvListaCompras.TabIndex = 4
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"NIT", "Empresa", "Propietario"})
        Me.cmbFiltro.Location = New System.Drawing.Point(95, 73)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 0
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(95, 105)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(338, 20)
        Me.txtBusqueda.TabIndex = 1
        '
        'btnAnularCompra
        '
        Me.btnAnularCompra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAnularCompra.Image = CType(resources.GetObject("btnAnularCompra.Image"), System.Drawing.Image)
        Me.btnAnularCompra.Location = New System.Drawing.Point(486, 460)
        Me.btnAnularCompra.Name = "btnAnularCompra"
        Me.btnAnularCompra.Size = New System.Drawing.Size(107, 77)
        Me.btnAnularCompra.TabIndex = 6
        Me.btnAnularCompra.Text = "&Anular Compra"
        Me.btnAnularCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnularCompra.UseVisualStyleBackColor = False
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Location = New System.Drawing.Point(484, 102)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'gbListaCompras
        '
        Me.gbListaCompras.Controls.Add(Me.btnActualizar)
        Me.gbListaCompras.Controls.Add(Me.dgvListaCompras)
        Me.gbListaCompras.Location = New System.Drawing.Point(13, 145)
        Me.gbListaCompras.Name = "gbListaCompras"
        Me.gbListaCompras.Size = New System.Drawing.Size(593, 313)
        Me.gbListaCompras.TabIndex = 33
        Me.gbListaCompras.TabStop = False
        Me.gbListaCompras.Text = "Lista Compras"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnActualizar.Location = New System.Drawing.Point(471, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(103, 25)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Recargar Lista"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'frmModuloCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 603)
        Me.Controls.Add(Me.gbListaCompras)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnAnularCompra)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnNCompra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmModuloCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        CType(Me.dgvListaCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbListaCompras.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNCompra As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents lblFiltro As System.Windows.Forms.Label
    Friend WithEvents dgvListaCompras As System.Windows.Forms.DataGridView
    Friend WithEvents cmbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnAnularCompra As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents gbListaCompras As System.Windows.Forms.GroupBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
