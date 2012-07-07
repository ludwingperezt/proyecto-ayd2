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
        Me.lbllistatipoclientes = New System.Windows.Forms.Label()
        Me.dgvtiposcliente = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.btnmodificartipocliente = New System.Windows.Forms.Button()
        Me.btneliminartipocliente = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgvtiposcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(138, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(249, 29)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "Getion Tipo Cliente"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Location = New System.Drawing.Point(414, 90)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 42
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(14, 95)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(394, 20)
        Me.txtbusqueda.TabIndex = 41
        '
        'lblbusqueda
        '
        Me.lblbusqueda.AutoSize = True
        Me.lblbusqueda.Location = New System.Drawing.Point(11, 68)
        Me.lblbusqueda.Name = "lblbusqueda"
        Me.lblbusqueda.Size = New System.Drawing.Size(129, 13)
        Me.lblbusqueda.TabIndex = 40
        Me.lblbusqueda.Text = "Ingrese el texto a buscar: "
        '
        'lbllistatipoclientes
        '
        Me.lbllistatipoclientes.AutoSize = True
        Me.lbllistatipoclientes.Location = New System.Drawing.Point(11, 132)
        Me.lbllistatipoclientes.Name = "lbllistatipoclientes"
        Me.lbllistatipoclientes.Size = New System.Drawing.Size(116, 13)
        Me.lbllistatipoclientes.TabIndex = 39
        Me.lbllistatipoclientes.Text = "Listado Tipos Clientes: "
        '
        'dgvtiposcliente
        '
        Me.dgvtiposcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtiposcliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4})
        Me.dgvtiposcliente.Location = New System.Drawing.Point(0, 160)
        Me.dgvtiposcliente.Name = "dgvtiposcliente"
        Me.dgvtiposcliente.Size = New System.Drawing.Size(543, 97)
        Me.dgvtiposcliente.TabIndex = 38
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
        'btningresar
        '
        Me.btningresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btningresar.Image = CType(resources.GetObject("btningresar.Image"), System.Drawing.Image)
        Me.btningresar.Location = New System.Drawing.Point(56, 275)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(123, 62)
        Me.btningresar.TabIndex = 43
        Me.btningresar.Text = "&Ingresar tipo cliente"
        Me.btningresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btningresar.UseVisualStyleBackColor = False
        '
        'btnmodificartipocliente
        '
        Me.btnmodificartipocliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmodificartipocliente.Image = CType(resources.GetObject("btnmodificartipocliente.Image"), System.Drawing.Image)
        Me.btnmodificartipocliente.Location = New System.Drawing.Point(196, 275)
        Me.btnmodificartipocliente.Name = "btnmodificartipocliente"
        Me.btnmodificartipocliente.Size = New System.Drawing.Size(125, 62)
        Me.btnmodificartipocliente.TabIndex = 44
        Me.btnmodificartipocliente.Text = "&Modificar tipo cliente"
        Me.btnmodificartipocliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificartipocliente.UseVisualStyleBackColor = False
        '
        'btneliminartipocliente
        '
        Me.btneliminartipocliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btneliminartipocliente.Image = CType(resources.GetObject("btneliminartipocliente.Image"), System.Drawing.Image)
        Me.btneliminartipocliente.Location = New System.Drawing.Point(346, 275)
        Me.btneliminartipocliente.Name = "btneliminartipocliente"
        Me.btneliminartipocliente.Size = New System.Drawing.Size(126, 62)
        Me.btneliminartipocliente.TabIndex = 45
        Me.btneliminartipocliente.Text = "&Eliminar tipo cliente"
        Me.btneliminartipocliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminartipocliente.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), System.Drawing.Image)
        Me.btnsalir.Location = New System.Drawing.Point(88, 343)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(350, 64)
        Me.btnsalir.TabIndex = 46
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 424)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(556, 22)
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
        'frmtipocliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 446)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btneliminartipocliente)
        Me.Controls.Add(Me.btnmodificartipocliente)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.lblbusqueda)
        Me.Controls.Add(Me.lbllistatipoclientes)
        Me.Controls.Add(Me.dgvtiposcliente)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmtipocliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmtipocliente"
        CType(Me.dgvtiposcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lblbusqueda As System.Windows.Forms.Label
    Friend WithEvents lbllistatipoclientes As System.Windows.Forms.Label
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
End Class
