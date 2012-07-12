<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtipocliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtipocliente))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.lblbusqueda = New System.Windows.Forms.Label()
        Me.dgvtiposcliente = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btneliminartipocliente = New System.Windows.Forms.Button()
        Me.btnmodificartipocliente = New System.Windows.Forms.Button()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.gpListadoClientes = New System.Windows.Forms.GroupBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvtiposcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsBarra.SuspendLayout()
        Me.gpListadoClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(164, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(249, 29)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "Getion Tipo Cliente"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Location = New System.Drawing.Point(466, 124)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 1
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(70, 129)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(369, 20)
        Me.txtbusqueda.TabIndex = 0
        '
        'lblbusqueda
        '
        Me.lblbusqueda.AutoSize = True
        Me.lblbusqueda.Location = New System.Drawing.Point(22, 130)
        Me.lblbusqueda.Name = "lblbusqueda"
        Me.lblbusqueda.Size = New System.Drawing.Size(40, 13)
        Me.lblbusqueda.TabIndex = 40
        Me.lblbusqueda.Text = "Buscar"
        '
        'dgvtiposcliente
        '
        Me.dgvtiposcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtiposcliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4})
        Me.dgvtiposcliente.Location = New System.Drawing.Point(15, 50)
        Me.dgvtiposcliente.Name = "dgvtiposcliente"
        Me.dgvtiposcliente.Size = New System.Drawing.Size(544, 89)
        Me.dgvtiposcliente.TabIndex = 3
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripción"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.FillWeight = 75.0!
        Me.Column4.HeaderText = "Descuento"
        Me.Column4.Name = "Column4"
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 473)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(592, 22)
        Me.stsBarra.TabIndex = 47
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
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsalir.Location = New System.Drawing.Point(426, 436)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(131, 31)
        Me.btnsalir.TabIndex = 7
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btneliminartipocliente
        '
        Me.btneliminartipocliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btneliminartipocliente.Image = CType(resources.GetObject("btneliminartipocliente.Image"), System.Drawing.Image)
        Me.btneliminartipocliente.Location = New System.Drawing.Point(426, 346)
        Me.btneliminartipocliente.Name = "btneliminartipocliente"
        Me.btneliminartipocliente.Size = New System.Drawing.Size(131, 62)
        Me.btneliminartipocliente.TabIndex = 6
        Me.btneliminartipocliente.Text = "&Eliminar tipo cliente"
        Me.btneliminartipocliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminartipocliente.UseVisualStyleBackColor = False
        '
        'btnmodificartipocliente
        '
        Me.btnmodificartipocliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmodificartipocliente.Image = CType(resources.GetObject("btnmodificartipocliente.Image"), System.Drawing.Image)
        Me.btnmodificartipocliente.Location = New System.Drawing.Point(282, 346)
        Me.btnmodificartipocliente.Name = "btnmodificartipocliente"
        Me.btnmodificartipocliente.Size = New System.Drawing.Size(129, 62)
        Me.btnmodificartipocliente.TabIndex = 5
        Me.btnmodificartipocliente.Text = "&Modificar tipo cliente"
        Me.btnmodificartipocliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificartipocliente.UseVisualStyleBackColor = False
        '
        'btningresar
        '
        Me.btningresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btningresar.Image = CType(resources.GetObject("btningresar.Image"), System.Drawing.Image)
        Me.btningresar.Location = New System.Drawing.Point(134, 346)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(131, 62)
        Me.btningresar.TabIndex = 4
        Me.btningresar.Text = "&Ingresar tipo cliente"
        Me.btningresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btningresar.UseVisualStyleBackColor = False
        '
        'gpListadoClientes
        '
        Me.gpListadoClientes.Controls.Add(Me.btnActualizar)
        Me.gpListadoClientes.Controls.Add(Me.dgvtiposcliente)
        Me.gpListadoClientes.Location = New System.Drawing.Point(10, 174)
        Me.gpListadoClientes.Name = "gpListadoClientes"
        Me.gpListadoClientes.Size = New System.Drawing.Size(570, 166)
        Me.gpListadoClientes.TabIndex = 61
        Me.gpListadoClientes.TabStop = False
        Me.gpListadoClientes.Text = "Listado Clientes"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnActualizar.Image = Global.GestionTextiles.My.Resources.Resources.refresh
        Me.btnActualizar.Location = New System.Drawing.Point(520, 19)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(27, 25)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Items.AddRange(New Object() {"Nombre", "Descripción", "Descuento"})
        Me.cmbCliente.Location = New System.Drawing.Point(164, 91)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(127, 21)
        Me.cmbCliente.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Parametro de busqueda: "
        '
        'frmtipocliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 495)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpListadoClientes)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btneliminartipocliente)
        Me.Controls.Add(Me.btnmodificartipocliente)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.lblbusqueda)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmtipocliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Cliente"
        CType(Me.dgvtiposcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.gpListadoClientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lblbusqueda As System.Windows.Forms.Label
    Friend WithEvents dgvtiposcliente As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btningresar As System.Windows.Forms.Button
    Friend WithEvents btnmodificartipocliente As System.Windows.Forms.Button
    Friend WithEvents btneliminartipocliente As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gpListadoClientes As System.Windows.Forms.GroupBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
