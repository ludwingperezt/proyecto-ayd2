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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.BtnGestionTalonarios = New System.Windows.Forms.Button()
        Me.BtnRoles = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 407)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(801, 22)
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
        'BtnGestionTalonarios
        '
        Me.BtnGestionTalonarios.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGestionTalonarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionTalonarios.Image = CType(resources.GetObject("BtnGestionTalonarios.Image"), System.Drawing.Image)
        Me.BtnGestionTalonarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGestionTalonarios.Location = New System.Drawing.Point(337, 231)
        Me.BtnGestionTalonarios.Name = "BtnGestionTalonarios"
        Me.BtnGestionTalonarios.Size = New System.Drawing.Size(125, 148)
        Me.BtnGestionTalonarios.TabIndex = 44
        Me.BtnGestionTalonarios.Text = "Gestión de Talonario"
        Me.BtnGestionTalonarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGestionTalonarios.UseVisualStyleBackColor = False
        '
        'BtnRoles
        '
        Me.BtnRoles.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRoles.Image = CType(resources.GetObject("BtnRoles.Image"), System.Drawing.Image)
        Me.BtnRoles.Location = New System.Drawing.Point(184, 231)
        Me.BtnRoles.Name = "BtnRoles"
        Me.BtnRoles.Size = New System.Drawing.Size(138, 148)
        Me.BtnRoles.TabIndex = 43
        Me.BtnRoles.Text = "Módulo de Roles"
        Me.BtnRoles.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRoles.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnReportes.Location = New System.Drawing.Point(480, 231)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(132, 148)
        Me.btnReportes.TabIndex = 42
        Me.btnReportes.Text = "Módulo de Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Image = CType(resources.GetObject("BtnLogin.Image"), System.Drawing.Image)
        Me.BtnLogin.Location = New System.Drawing.Point(36, 64)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(126, 148)
        Me.BtnLogin.TabIndex = 41
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.Location = New System.Drawing.Point(633, 231)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(128, 148)
        Me.BtnSalir.TabIndex = 39
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.Image = CType(resources.GetObject("BtnEmpleados.Image"), System.Drawing.Image)
        Me.BtnEmpleados.Location = New System.Drawing.Point(36, 231)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(126, 148)
        Me.BtnEmpleados.TabIndex = 7
        Me.BtnEmpleados.Text = "Modulo Empleados"
        Me.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEmpleados.UseVisualStyleBackColor = False
        '
        'BtnClientes
        '
        Me.BtnClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.Location = New System.Drawing.Point(480, 64)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(132, 148)
        Me.BtnClientes.TabIndex = 6
        Me.BtnClientes.Text = "Modulo Clientes"
        Me.BtnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnClientes.UseVisualStyleBackColor = False
        '
        'BtnCompras
        '
        Me.BtnCompras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.Image = CType(resources.GetObject("BtnCompras.Image"), System.Drawing.Image)
        Me.BtnCompras.Location = New System.Drawing.Point(337, 64)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(125, 148)
        Me.BtnCompras.TabIndex = 5
        Me.BtnCompras.Text = "Modulo Compras"
        Me.BtnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCompras.UseVisualStyleBackColor = False
        '
        'BtnProveedores
        '
        Me.BtnProveedores.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedores.Image = CType(resources.GetObject("BtnProveedores.Image"), System.Drawing.Image)
        Me.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProveedores.Location = New System.Drawing.Point(633, 64)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(128, 148)
        Me.BtnProveedores.TabIndex = 4
        Me.BtnProveedores.Text = "Modulo Proveedores"
        Me.BtnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnProveedores.UseVisualStyleBackColor = False
        '
        'BtnVentas
        '
        Me.BtnVentas.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BtnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.Location = New System.Drawing.Point(184, 64)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(138, 148)
        Me.BtnVentas.TabIndex = 3
        Me.BtnVentas.Text = "Módulo de Ventas"
        Me.BtnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnVentas.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(801, 429)
        Me.Controls.Add(Me.BtnGestionTalonarios)
        Me.Controls.Add(Me.BtnRoles)
        Me.Controls.Add(Me.btnReportes)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEmpleados)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.BtnCompras)
        Me.Controls.Add(Me.BtnProveedores)
        Me.Controls.Add(Me.BtnVentas)
        Me.Controls.Add(Me.stsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
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
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents btnReportes As System.Windows.Forms.Button
    Friend WithEvents BtnRoles As System.Windows.Forms.Button
    Friend WithEvents BtnGestionTalonarios As System.Windows.Forms.Button
End Class
