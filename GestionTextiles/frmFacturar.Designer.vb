<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturar
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
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.lblnit = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.cmbserie = New System.Windows.Forms.ComboBox()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.dgvdetallefactura = New System.Windows.Forms.DataGridView()
        Me.clmCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmTela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpProducto = New System.Windows.Forms.GroupBox()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbldescuentofac = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.lbltela = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtTela = New System.Windows.Forms.TextBox()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        CType(Me.dgvdetallefactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpProducto.SuspendLayout()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(27, 158)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(47, 13)
        Me.Lblnombre.TabIndex = 0
        Me.Lblnombre.Text = "Nombre:"
        '
        'lblnit
        '
        Me.lblnit.AutoSize = True
        Me.lblnit.Location = New System.Drawing.Point(27, 133)
        Me.lblnit.Name = "lblnit"
        Me.lblnit.Size = New System.Drawing.Size(26, 13)
        Me.lblnit.TabIndex = 1
        Me.lblnit.Text = "Nit: "
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(27, 183)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(55, 13)
        Me.lbldireccion.TabIndex = 2
        Me.lbldireccion.Text = "Dirección:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(95, 155)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(308, 20)
        Me.txtnombre.TabIndex = 2
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(95, 125)
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(88, 20)
        Me.txtnit.TabIndex = 1
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(96, 183)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(307, 20)
        Me.txtdireccion.TabIndex = 3
        '
        'cmbserie
        '
        Me.cmbserie.FormattingEnabled = True
        Me.cmbserie.Location = New System.Drawing.Point(95, 76)
        Me.cmbserie.Name = "cmbserie"
        Me.cmbserie.Size = New System.Drawing.Size(110, 21)
        Me.cmbserie.TabIndex = 0
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(27, 84)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(34, 13)
        Me.lblserie.TabIndex = 7
        Me.lblserie.Text = "Serie:"
        '
        'dgvdetallefactura
        '
        Me.dgvdetallefactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetallefactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmCantidad, Me.clmCodigo, Me.clmTela, Me.clmSubtotal})
        Me.dgvdetallefactura.Location = New System.Drawing.Point(15, 352)
        Me.dgvdetallefactura.Name = "dgvdetallefactura"
        Me.dgvdetallefactura.Size = New System.Drawing.Size(388, 187)
        Me.dgvdetallefactura.TabIndex = 8
        '
        'clmCantidad
        '
        Me.clmCantidad.HeaderText = "Cantidad"
        Me.clmCantidad.Name = "clmCantidad"
        Me.clmCantidad.Width = 50
        '
        'clmCodigo
        '
        Me.clmCodigo.HeaderText = "Codigo"
        Me.clmCodigo.Name = "clmCodigo"
        '
        'clmTela
        '
        Me.clmTela.HeaderText = "Tela"
        Me.clmTela.Name = "clmTela"
        '
        'clmSubtotal
        '
        Me.clmSubtotal.HeaderText = "Subtotal"
        Me.clmSubtotal.Name = "clmSubtotal"
        '
        'gpProducto
        '
        Me.gpProducto.Controls.Add(Me.btnBuscar)
        Me.gpProducto.Controls.Add(Me.txtCantidad)
        Me.gpProducto.Controls.Add(Me.txtTela)
        Me.gpProducto.Controls.Add(Me.lblcantidad)
        Me.gpProducto.Controls.Add(Me.lbltela)
        Me.gpProducto.Location = New System.Drawing.Point(15, 221)
        Me.gpProducto.Name = "gpProducto"
        Me.gpProducto.Size = New System.Drawing.Size(388, 75)
        Me.gpProducto.TabIndex = 19
        Me.gpProducto.TabStop = False
        Me.gpProducto.Text = "Producto"
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(189, 562)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(34, 13)
        Me.lbTotal.TabIndex = 20
        Me.lbTotal.Text = "Total:"
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(189, 592)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(62, 13)
        Me.lblDescuento.TabIndex = 24
        Me.lblDescuento.Text = "Descuento:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(230, 624)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(328, 624)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(166, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(119, 29)
        Me.lblTitulo.TabIndex = 28
        Me.lblTitulo.Text = "Facturar"
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 656)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(451, 22)
        Me.stsBarra.TabIndex = 29
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
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(257, 562)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(39, 13)
        Me.lbltotal.TabIndex = 31
        Me.lbltotal.Text = "Label1"
        '
        'lbldescuentofac
        '
        Me.lbldescuentofac.AutoSize = True
        Me.lbldescuentofac.Location = New System.Drawing.Point(257, 592)
        Me.lbldescuentofac.Name = "lbldescuentofac"
        Me.lbldescuentofac.Size = New System.Drawing.Size(39, 13)
        Me.lbldescuentofac.TabIndex = 32
        Me.lbldescuentofac.Text = "Label2"
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnagregar.Location = New System.Drawing.Point(260, 302)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(106, 23)
        Me.btnagregar.TabIndex = 7
        Me.btnagregar.Text = "Agregar a la cesta"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(76, 45)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(92, 20)
        Me.txtCantidad.TabIndex = 6
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(12, 48)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblcantidad.TabIndex = 35
        Me.lblcantidad.Text = "Cantidad:"
        '
        'lbltela
        '
        Me.lbltela.AutoSize = True
        Me.lbltela.Location = New System.Drawing.Point(12, 22)
        Me.lbltela.Name = "lbltela"
        Me.lbltela.Size = New System.Drawing.Size(31, 13)
        Me.lbltela.TabIndex = 34
        Me.lbltela.Text = "Tela:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Location = New System.Drawing.Point(276, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtTela
        '
        Me.txtTela.Enabled = False
        Me.txtTela.Location = New System.Drawing.Point(76, 19)
        Me.txtTela.Name = "txtTela"
        Me.txtTela.Size = New System.Drawing.Size(194, 20)
        Me.txtTela.TabIndex = 4
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(300, 84)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(66, 13)
        Me.lblEmpleado.TabIndex = 58
        Me.lblEmpleado.Text = "EMPLEADO"
        '
        'frmFacturar
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(451, 678)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.lbldescuentofac)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.gpProducto)
        Me.Controls.Add(Me.dgvdetallefactura)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.cmbserie)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblnit)
        Me.Controls.Add(Me.Lblnombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmFacturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturar"
        CType(Me.dgvdetallefactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpProducto.ResumeLayout(False)
        Me.gpProducto.PerformLayout()
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblnit As System.Windows.Forms.Label
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtnit As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents cmbserie As System.Windows.Forms.ComboBox
    Friend WithEvents lblserie As System.Windows.Forms.Label
    Friend WithEvents dgvdetallefactura As System.Windows.Forms.DataGridView
    Friend WithEvents clmCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmTela As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gpProducto As System.Windows.Forms.GroupBox
    Friend WithEvents lbTotal As System.Windows.Forms.Label
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lbldescuentofac As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
    Friend WithEvents lbltela As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtTela As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
End Class
