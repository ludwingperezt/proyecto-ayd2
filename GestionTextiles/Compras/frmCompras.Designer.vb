<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtTela = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblTela = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lbEtiquetaTotal = New System.Windows.Forms.Label()
        Me.gpProducto = New System.Windows.Forms.GroupBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblnit = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lblCorrelativo = New System.Windows.Forms.Label()
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        Me.gpProducto.SuspendLayout()
        CType(Me.dgvDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 653)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(625, 22)
        Me.stsBarra.TabIndex = 40
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
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(81, 57)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(87, 20)
        Me.txtCantidad.TabIndex = 8
        '
        'txtTela
        '
        Me.txtTela.Enabled = False
        Me.txtTela.Location = New System.Drawing.Point(82, 29)
        Me.txtTela.Name = "txtTela"
        Me.txtTela.Size = New System.Drawing.Size(283, 20)
        Me.txtTela.TabIndex = 6
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(16, 57)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 60
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblTela
        '
        Me.lblTela.AutoSize = True
        Me.lblTela.Location = New System.Drawing.Point(16, 29)
        Me.lblTela.Name = "lblTela"
        Me.lblTela.Size = New System.Drawing.Size(28, 13)
        Me.lblTela.TabIndex = 59
        Me.lblTela.Text = "Tela"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Green
        Me.lblTotal.Location = New System.Drawing.Point(485, 562)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(16, 16)
        Me.lblTotal.TabIndex = 56
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(266, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(114, 29)
        Me.lblTitulo.TabIndex = 55
        Me.lblTitulo.Text = "Compras"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(386, 611)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(484, 611)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lbEtiquetaTotal
        '
        Me.lbEtiquetaTotal.AutoSize = True
        Me.lbEtiquetaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEtiquetaTotal.ForeColor = System.Drawing.Color.Green
        Me.lbEtiquetaTotal.Location = New System.Drawing.Point(388, 562)
        Me.lbEtiquetaTotal.Name = "lbEtiquetaTotal"
        Me.lbEtiquetaTotal.Size = New System.Drawing.Size(48, 16)
        Me.lbEtiquetaTotal.TabIndex = 51
        Me.lbEtiquetaTotal.Text = "Total:"
        '
        'gpProducto
        '
        Me.gpProducto.Controls.Add(Me.txtCosto)
        Me.gpProducto.Controls.Add(Me.lblCosto)
        Me.gpProducto.Controls.Add(Me.btnBuscar)
        Me.gpProducto.Controls.Add(Me.txtCantidad)
        Me.gpProducto.Controls.Add(Me.lblTela)
        Me.gpProducto.Controls.Add(Me.lblCantidad)
        Me.gpProducto.Controls.Add(Me.txtTela)
        Me.gpProducto.Location = New System.Drawing.Point(70, 213)
        Me.gpProducto.Name = "gpProducto"
        Me.gpProducto.Size = New System.Drawing.Size(489, 90)
        Me.gpProducto.TabIndex = 50
        Me.gpProducto.TabStop = False
        Me.gpProducto.Text = "Producto"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(228, 56)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(136, 20)
        Me.txtCosto.TabIndex = 62
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Location = New System.Drawing.Point(185, 61)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(34, 13)
        Me.lblCosto.TabIndex = 61
        Me.lblCosto.Text = "Costo"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Location = New System.Drawing.Point(389, 27)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar..."
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'dgvDetalleFactura
        '
        Me.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleFactura.Location = New System.Drawing.Point(70, 362)
        Me.dgvDetalleFactura.Name = "dgvDetalleFactura"
        Me.dgvDetalleFactura.Size = New System.Drawing.Size(489, 187)
        Me.dgvDetalleFactura.TabIndex = 10
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(82, 50)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(31, 13)
        Me.lblserie.TabIndex = 48
        Me.lblserie.Text = "Serie"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(151, 172)
        Me.txtDireccion.MaxLength = 60
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(408, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(150, 114)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(113, 20)
        Me.txtNit.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(150, 144)
        Me.txtNombre.MaxLength = 70
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(409, 20)
        Me.txtNombre.TabIndex = 4
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(82, 172)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbldireccion.TabIndex = 43
        Me.lbldireccion.Text = "Dirección"
        '
        'lblnit
        '
        Me.lblnit.AutoSize = True
        Me.lblnit.Location = New System.Drawing.Point(82, 117)
        Me.lblnit.Name = "lblnit"
        Me.lblnit.Size = New System.Drawing.Size(20, 13)
        Me.lblnit.TabIndex = 42
        Me.lblnit.Text = "Nit"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(82, 147)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.Lblnombre.TabIndex = 41
        Me.Lblnombre.Text = "Nombre"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(152, 50)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(53, 20)
        Me.txtSerie.TabIndex = 0
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCorrelativo
        '
        Me.lblCorrelativo.AutoSize = True
        Me.lblCorrelativo.Location = New System.Drawing.Point(302, 50)
        Me.lblCorrelativo.Name = "lblCorrelativo"
        Me.lblCorrelativo.Size = New System.Drawing.Size(57, 13)
        Me.lblCorrelativo.TabIndex = 48
        Me.lblCorrelativo.Text = "Correlativo"
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.Location = New System.Drawing.Point(372, 50)
        Me.txtCorrelativo.MaxLength = 20
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(86, 20)
        Me.txtCorrelativo.TabIndex = 1
        Me.txtCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(150, 88)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Fecha"
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(493, 95)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(66, 13)
        Me.lblEmpleado.TabIndex = 57
        Me.lblEmpleado.Text = "EMPLEADO"
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnagregar.Location = New System.Drawing.Point(453, 309)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(106, 23)
        Me.btnagregar.TabIndex = 58
        Me.btnagregar.Text = "Agregar a la cesta"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 675)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lbEtiquetaTotal)
        Me.Controls.Add(Me.gpProducto)
        Me.Controls.Add(Me.lblCorrelativo)
        Me.Controls.Add(Me.dgvDetalleFactura)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblnit)
        Me.Controls.Add(Me.Lblnombre)
        Me.Controls.Add(Me.stsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.gpProducto.ResumeLayout(False)
        Me.gpProducto.PerformLayout()
        CType(Me.dgvDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtTela As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblTela As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lbEtiquetaTotal As System.Windows.Forms.Label
    Friend WithEvents gpProducto As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDetalleFactura As System.Windows.Forms.DataGridView
    Friend WithEvents lblserie As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNit As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents lblnit As System.Windows.Forms.Label
    Friend WithEvents Lblnombre As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents lblCorrelativo As System.Windows.Forms.Label
    Friend WithEvents txtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents lblCosto As System.Windows.Forms.Label
End Class
