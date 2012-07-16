<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarFacturaProveedor
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
        Me.lblEmpleado = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblCorrelativo = New System.Windows.Forms.Label()
        Me.lblserie = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnit = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.dgvDetalleFactura = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.dgvDetalleFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmpleado
        '
        Me.lblEmpleado.AutoSize = True
        Me.lblEmpleado.Location = New System.Drawing.Point(423, 95)
        Me.lblEmpleado.Name = "lblEmpleado"
        Me.lblEmpleado.Size = New System.Drawing.Size(66, 13)
        Me.lblEmpleado.TabIndex = 71
        Me.lblEmpleado.Text = "EMPLEADO"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 88)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 60
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.Location = New System.Drawing.Point(295, 50)
        Me.txtCorrelativo.MaxLength = 20
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(86, 20)
        Me.txtCorrelativo.TabIndex = 59
        Me.txtCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(82, 50)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(53, 20)
        Me.txtSerie.TabIndex = 58
        Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(71, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(365, 29)
        Me.lblTitulo.TabIndex = 70
        Me.lblTitulo.Text = "Eliminar Factura de Compra"
        '
        'lblCorrelativo
        '
        Me.lblCorrelativo.AutoSize = True
        Me.lblCorrelativo.Location = New System.Drawing.Point(236, 50)
        Me.lblCorrelativo.Name = "lblCorrelativo"
        Me.lblCorrelativo.Size = New System.Drawing.Size(44, 13)
        Me.lblCorrelativo.TabIndex = 68
        Me.lblCorrelativo.Text = "Numero"
        '
        'lblserie
        '
        Me.lblserie.AutoSize = True
        Me.lblserie.Location = New System.Drawing.Point(12, 50)
        Me.lblserie.Name = "lblserie"
        Me.lblserie.Size = New System.Drawing.Size(31, 13)
        Me.lblserie.TabIndex = 69
        Me.lblserie.Text = "Serie"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(81, 172)
        Me.txtDireccion.MaxLength = 60
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(408, 20)
        Me.txtDireccion.TabIndex = 63
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(80, 144)
        Me.txtNombre.MaxLength = 70
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(409, 20)
        Me.txtNombre.TabIndex = 62
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(12, 172)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbldireccion.TabIndex = 67
        Me.lbldireccion.Text = "Dirección"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Fecha"
        '
        'lblnit
        '
        Me.lblnit.AutoSize = True
        Me.lblnit.Location = New System.Drawing.Point(12, 117)
        Me.lblnit.Name = "lblnit"
        Me.lblnit.Size = New System.Drawing.Size(20, 13)
        Me.lblnit.TabIndex = 65
        Me.lblnit.Text = "Nit"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(12, 147)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.Lblnombre.TabIndex = 64
        Me.Lblnombre.Text = "Nombre"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(80, 114)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(113, 20)
        Me.txtNit.TabIndex = 61
        '
        'dgvDetalleFactura
        '
        Me.dgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleFactura.Location = New System.Drawing.Point(12, 198)
        Me.dgvDetalleFactura.Name = "dgvDetalleFactura"
        Me.dgvDetalleFactura.Size = New System.Drawing.Size(482, 201)
        Me.dgvDetalleFactura.TabIndex = 72
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(321, 416)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 73
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(419, 416)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 74
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'frmEliminarFacturaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 449)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvDetalleFactura)
        Me.Controls.Add(Me.lblEmpleado)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblCorrelativo)
        Me.Controls.Add(Me.lblserie)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblnit)
        Me.Controls.Add(Me.Lblnombre)
        Me.Name = "frmEliminarFacturaProveedor"
        Me.Text = "Eliminacion de Factura de Compra"
        CType(Me.dgvDetalleFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmpleado As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblCorrelativo As System.Windows.Forms.Label
    Friend WithEvents lblserie As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblnit As System.Windows.Forms.Label
    Friend WithEvents Lblnombre As System.Windows.Forms.Label
    Friend WithEvents txtNit As System.Windows.Forms.TextBox
    Friend WithEvents dgvDetalleFactura As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
