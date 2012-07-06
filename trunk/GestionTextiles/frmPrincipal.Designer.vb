<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrRefrescarBarra = New System.Windows.Forms.Timer(Me.components)
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 215)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(841, 22)
        Me.stsBarra.TabIndex = 2
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
        'tmrRefrescarBarra
        '
        Me.tmrRefrescarBarra.Enabled = True
        Me.tmrRefrescarBarra.Interval = 1000
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.Location = New System.Drawing.Point(31, 49)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(138, 148)
        Me.BtnVentas.TabIndex = 3
        Me.BtnVentas.Text = "Módulo de Ventas"
        Me.BtnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'BtnProveedores
        '
        Me.BtnProveedores.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedores.Image = CType(resources.GetObject("BtnProveedores.Image"), System.Drawing.Image)
        Me.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProveedores.Location = New System.Drawing.Point(480, 49)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(128, 148)
        Me.BtnProveedores.TabIndex = 4
        Me.BtnProveedores.Text = "Modulo Proveedores"
        Me.BtnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProveedores.UseVisualStyleBackColor = False
        '
        'BtnCompras
        '
        Me.BtnCompras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.Image = CType(resources.GetObject("BtnCompras.Image"), System.Drawing.Image)
        Me.BtnCompras.Location = New System.Drawing.Point(184, 49)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(125, 148)
        Me.BtnCompras.TabIndex = 5
        Me.BtnCompras.Text = "Modulo Compras"
        Me.BtnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCompras.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.Location = New System.Drawing.Point(327, 49)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(132, 148)
        Me.BtnClientes.TabIndex = 6
        Me.BtnClientes.Text = "Modulo Clientes"
        Me.BtnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.Image = CType(resources.GetObject("BtnEmpleados.Image"), System.Drawing.Image)
        Me.BtnEmpleados.Location = New System.Drawing.Point(627, 49)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(126, 148)
        Me.BtnEmpleados.TabIndex = 7
        Me.BtnEmpleados.Text = "Modulo Empleados"
        Me.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEmpleados.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(762, 49)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(67, 148)
        Me.BtnSalir.TabIndex = 39
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(285, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(205, 29)
        Me.lblTitulo.TabIndex = 40
        Me.lblTitulo.Text = "Menú Principal"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 237)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEmpleados)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.BtnCompras)
        Me.Controls.Add(Me.BtnProveedores)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.stsBarra)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrRefrescarBarra As System.Windows.Forms.Timer
    Friend WithEvents BtnVentas As System.Windows.Forms.Button
    Friend WithEvents BtnProveedores As System.Windows.Forms.Button
    Friend WithEvents BtnCompras As System.Windows.Forms.Button
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents BtnEmpleados As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
