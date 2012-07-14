<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvclientes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblbusqueda = New System.Windows.Forms.Label()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btneliminarcliente = New System.Windows.Forms.Button()
        Me.btnmodificarclientes = New System.Windows.Forms.Button()
        Me.btningresarcliente = New System.Windows.Forms.Button()
        Me.gpListadoClientes = New System.Windows.Forms.GroupBox()
        Me.lblParametro = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsBarra.SuspendLayout()
        Me.gpListadoClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(196, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(206, 29)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "Módulo Clientes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvclientes
        '
        Me.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvclientes.Location = New System.Drawing.Point(3, 50)
        Me.dgvclientes.Name = "dgvclientes"
        Me.dgvclientes.Size = New System.Drawing.Size(544, 145)
        Me.dgvclientes.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo Cliente"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellido"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.FillWeight = 75.0!
        Me.Column4.HeaderText = "Dirección"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.FillWeight = 50.0!
        Me.Column5.HeaderText = "Nit"
        Me.Column5.Name = "Column5"
        '
        'lblbusqueda
        '
        Me.lblbusqueda.AutoSize = True
        Me.lblbusqueda.Location = New System.Drawing.Point(12, 127)
        Me.lblbusqueda.Name = "lblbusqueda"
        Me.lblbusqueda.Size = New System.Drawing.Size(46, 13)
        Me.lblbusqueda.TabIndex = 35
        Me.lblbusqueda.Text = "Buscar: "
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(76, 124)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(372, 20)
        Me.txtbusqueda.TabIndex = 0
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Location = New System.Drawing.Point(467, 121)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 1
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 552)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(595, 22)
        Me.stsBarra.TabIndex = 39
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(452, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "&Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btneliminarcliente
        '
        Me.btneliminarcliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btneliminarcliente.Image = CType(resources.GetObject("btneliminarcliente.Image"), System.Drawing.Image)
        Me.btneliminarcliente.Location = New System.Drawing.Point(452, 406)
        Me.btneliminarcliente.Name = "btneliminarcliente"
        Me.btneliminarcliente.Size = New System.Drawing.Size(107, 71)
        Me.btneliminarcliente.TabIndex = 6
        Me.btneliminarcliente.Text = "&Eliminar Cliente"
        Me.btneliminarcliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminarcliente.UseVisualStyleBackColor = False
        '
        'btnmodificarclientes
        '
        Me.btnmodificarclientes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmodificarclientes.Image = CType(resources.GetObject("btnmodificarclientes.Image"), System.Drawing.Image)
        Me.btnmodificarclientes.Location = New System.Drawing.Point(327, 406)
        Me.btnmodificarclientes.Name = "btnmodificarclientes"
        Me.btnmodificarclientes.Size = New System.Drawing.Size(107, 72)
        Me.btnmodificarclientes.TabIndex = 5
        Me.btnmodificarclientes.Text = "&Modificar Cliente"
        Me.btnmodificarclientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificarclientes.UseVisualStyleBackColor = False
        '
        'btningresarcliente
        '
        Me.btningresarcliente.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btningresarcliente.Image = CType(resources.GetObject("btningresarcliente.Image"), System.Drawing.Image)
        Me.btningresarcliente.Location = New System.Drawing.Point(201, 406)
        Me.btningresarcliente.Name = "btningresarcliente"
        Me.btningresarcliente.Size = New System.Drawing.Size(109, 72)
        Me.btningresarcliente.TabIndex = 4
        Me.btningresarcliente.Text = "&Ingresar cliente"
        Me.btningresarcliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btningresarcliente.UseVisualStyleBackColor = False
        '
        'gpListadoClientes
        '
        Me.gpListadoClientes.Controls.Add(Me.btnActualizar)
        Me.gpListadoClientes.Controls.Add(Me.dgvclientes)
        Me.gpListadoClientes.Location = New System.Drawing.Point(12, 174)
        Me.gpListadoClientes.Name = "gpListadoClientes"
        Me.gpListadoClientes.Size = New System.Drawing.Size(562, 215)
        Me.gpListadoClientes.TabIndex = 60
        Me.gpListadoClientes.TabStop = False
        Me.gpListadoClientes.Text = "Listado Clientes"
        '
        'lblParametro
        '
        Me.lblParametro.AutoSize = True
        Me.lblParametro.Location = New System.Drawing.Point(9, 84)
        Me.lblParametro.Name = "lblParametro"
        Me.lblParametro.Size = New System.Drawing.Size(126, 13)
        Me.lblParametro.TabIndex = 61
        Me.lblParametro.Text = "Parametro de busqueda: "
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Items.AddRange(New Object() {"Tipo Cliente", "Nombre", "Apellido", "Dirección", "Nit"})
        Me.cmbCliente.Location = New System.Drawing.Point(151, 84)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(127, 21)
        Me.cmbCliente.TabIndex = 62
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnActualizar.Image = Global.GestionTextiles.My.Resources.Resources.refresh
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.Location = New System.Drawing.Point(467, 19)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(80, 23)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Regresar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 574)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.lblParametro)
        Me.Controls.Add(Me.gpListadoClientes)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.lblbusqueda)
        Me.Controls.Add(Me.btneliminarcliente)
        Me.Controls.Add(Me.btnmodificarclientes)
        Me.Controls.Add(Me.btningresarcliente)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo Clientes"
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.gpListadoClientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btningresarcliente As System.Windows.Forms.Button
    Friend WithEvents dgvclientes As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnmodificarclientes As System.Windows.Forms.Button
    Friend WithEvents btneliminarcliente As System.Windows.Forms.Button
    Friend WithEvents lblbusqueda As System.Windows.Forms.Label
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gpListadoClientes As System.Windows.Forms.GroupBox
    Friend WithEvents lblParametro As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
