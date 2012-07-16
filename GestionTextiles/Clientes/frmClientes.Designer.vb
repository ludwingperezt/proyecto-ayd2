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
        Me.lblbusqueda = New System.Windows.Forms.Label()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnmodificarclientes = New System.Windows.Forms.Button()
        Me.btningresarcliente = New System.Windows.Forms.Button()
        Me.gpListadoClientes = New System.Windows.Forms.GroupBox()
        Me.dgvclientes = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblParametro = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.stsBarra.SuspendLayout()
        Me.gpListadoClientes.SuspendLayout()
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnmodificarclientes
        '
        Me.btnmodificarclientes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmodificarclientes.Image = CType(resources.GetObject("btnmodificarclientes.Image"), System.Drawing.Image)
        Me.btnmodificarclientes.Location = New System.Drawing.Point(455, 405)
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
        Me.btningresarcliente.Location = New System.Drawing.Point(329, 405)
        Me.btningresarcliente.Name = "btningresarcliente"
        Me.btningresarcliente.Size = New System.Drawing.Size(109, 72)
        Me.btningresarcliente.TabIndex = 4
        Me.btningresarcliente.Text = "&Ingresar cliente"
        Me.btningresarcliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btningresarcliente.UseVisualStyleBackColor = False
        '
        'gpListadoClientes
        '
        Me.gpListadoClientes.Controls.Add(Me.dgvclientes)
        Me.gpListadoClientes.Controls.Add(Me.btnActualizar)
        Me.gpListadoClientes.Location = New System.Drawing.Point(12, 174)
        Me.gpListadoClientes.Name = "gpListadoClientes"
        Me.gpListadoClientes.Size = New System.Drawing.Size(562, 215)
        Me.gpListadoClientes.TabIndex = 60
        Me.gpListadoClientes.TabStop = False
        Me.gpListadoClientes.Text = "Listado Clientes"
        '
        'dgvclientes
        '
        Me.dgvclientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclientes.Location = New System.Drawing.Point(9, 55)
        Me.dgvclientes.Name = "dgvclientes"
        Me.dgvclientes.Size = New System.Drawing.Size(541, 150)
        Me.dgvclientes.TabIndex = 3
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
        Me.cmbCliente.Items.AddRange(New Object() {"Nombre", "Nit", "Direccion"})
        Me.cmbCliente.Location = New System.Drawing.Point(151, 84)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(127, 21)
        Me.cmbCliente.TabIndex = 62
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
        Me.Controls.Add(Me.btnmodificarclientes)
        Me.Controls.Add(Me.btningresarcliente)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo Clientes"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.gpListadoClientes.ResumeLayout(False)
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btningresarcliente As System.Windows.Forms.Button
    Friend WithEvents btnmodificarclientes As System.Windows.Forms.Button
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
    Friend WithEvents dgvclientes As System.Windows.Forms.DataGridView
End Class
