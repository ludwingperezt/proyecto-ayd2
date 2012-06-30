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
        Me.btningresarcliente = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbllistaclientes = New System.Windows.Forms.Label()
        Me.btnmodificarclientes = New System.Windows.Forms.Button()
        Me.btneliminarcliente = New System.Windows.Forms.Button()
        Me.lblbusqueda = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(215, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(108, 29)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "Clientes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btningresarcliente
        '
        Me.btningresarcliente.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btningresarcliente.Image = CType(resources.GetObject("btningresarcliente.Image"), System.Drawing.Image)
        Me.btningresarcliente.Location = New System.Drawing.Point(78, 305)
        Me.btningresarcliente.Name = "btningresarcliente"
        Me.btningresarcliente.Size = New System.Drawing.Size(102, 72)
        Me.btningresarcliente.TabIndex = 30
        Me.btningresarcliente.Text = "&Ingresar cliente"
        Me.btningresarcliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btningresarcliente.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(1, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 132)
        Me.DataGridView1.TabIndex = 31
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
        'lbllistaclientes
        '
        Me.lbllistaclientes.AutoSize = True
        Me.lbllistaclientes.Location = New System.Drawing.Point(12, 116)
        Me.lbllistaclientes.Name = "lbllistaclientes"
        Me.lbllistaclientes.Size = New System.Drawing.Size(87, 13)
        Me.lbllistaclientes.TabIndex = 32
        Me.lbllistaclientes.Text = "Listado Clientes: "
        '
        'btnmodificarclientes
        '
        Me.btnmodificarclientes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmodificarclientes.Image = CType(resources.GetObject("btnmodificarclientes.Image"), System.Drawing.Image)
        Me.btnmodificarclientes.Location = New System.Drawing.Point(202, 305)
        Me.btnmodificarclientes.Name = "btnmodificarclientes"
        Me.btnmodificarclientes.Size = New System.Drawing.Size(104, 72)
        Me.btnmodificarclientes.TabIndex = 33
        Me.btnmodificarclientes.Text = "&Modificar Cliente"
        Me.btnmodificarclientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificarclientes.UseVisualStyleBackColor = False
        '
        'btneliminarcliente
        '
        Me.btneliminarcliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btneliminarcliente.Image = CType(resources.GetObject("btneliminarcliente.Image"), System.Drawing.Image)
        Me.btneliminarcliente.Location = New System.Drawing.Point(330, 305)
        Me.btneliminarcliente.Name = "btneliminarcliente"
        Me.btneliminarcliente.Size = New System.Drawing.Size(98, 71)
        Me.btneliminarcliente.TabIndex = 34
        Me.btneliminarcliente.Text = "&Eliminar Cliente"
        Me.btneliminarcliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminarcliente.UseVisualStyleBackColor = False
        '
        'lblbusqueda
        '
        Me.lblbusqueda.AutoSize = True
        Me.lblbusqueda.Location = New System.Drawing.Point(12, 52)
        Me.lblbusqueda.Name = "lblbusqueda"
        Me.lblbusqueda.Size = New System.Drawing.Size(129, 13)
        Me.lblbusqueda.TabIndex = 35
        Me.lblbusqueda.Text = "Ingrese el texto a buscar: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(400, 20)
        Me.TextBox1.TabIndex = 36
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbuscar.Location = New System.Drawing.Point(427, 74)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnbuscar.TabIndex = 37
        Me.btnbuscar.Text = "B&uscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(78, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(350, 64)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "&Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 468)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblbusqueda)
        Me.Controls.Add(Me.btneliminarcliente)
        Me.Controls.Add(Me.btnmodificarclientes)
        Me.Controls.Add(Me.lbllistaclientes)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btningresarcliente)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btningresarcliente As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbllistaclientes As System.Windows.Forms.Label
    Friend WithEvents btnmodificarclientes As System.Windows.Forms.Button
    Friend WithEvents btneliminarcliente As System.Windows.Forms.Button
    Friend WithEvents lblbusqueda As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
