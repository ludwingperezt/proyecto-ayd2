﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarEmpleado
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.dtpFechaContrato = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaContrato = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDPI = New System.Windows.Forms.Label()
        Me.txtDPI = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.cmbPuesto = New System.Windows.Forms.ComboBox()
        Me.lblPuesto = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(75, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(389, 29)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "Modificar Datos Del Empleado"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(324, 373)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 51
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(422, 373)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 50
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'dtpFechaContrato
        '
        Me.dtpFechaContrato.Location = New System.Drawing.Point(143, 267)
        Me.dtpFechaContrato.Name = "dtpFechaContrato"
        Me.dtpFechaContrato.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaContrato.TabIndex = 49
        '
        'lblFechaContrato
        '
        Me.lblFechaContrato.AutoSize = True
        Me.lblFechaContrato.Location = New System.Drawing.Point(26, 267)
        Me.lblFechaContrato.Name = "lblFechaContrato"
        Me.lblFechaContrato.Size = New System.Drawing.Size(95, 13)
        Me.lblFechaContrato.TabIndex = 48
        Me.lblFechaContrato.Text = "Fecha de Contrato"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(143, 188)
        Me.txtTelefono.MaxLength = 15
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 47
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(28, 296)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(40, 13)
        Me.lblSueldo.TabIndex = 46
        Me.lblSueldo.Text = "Sueldo"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(143, 136)
        Me.txtDireccion.MaxLength = 60
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(354, 20)
        Me.txtDireccion.TabIndex = 45
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(26, 136)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 44
        Me.lblDireccion.Text = "Dirección"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(143, 293)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 42
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(143, 214)
        Me.txtCelular.MaxLength = 15
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(100, 20)
        Me.txtCelular.TabIndex = 43
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(26, 217)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 40
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(24, 191)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 41
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(143, 84)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(354, 20)
        Me.txtNombre.TabIndex = 0
        '
        'lblDPI
        '
        Me.lblDPI.AutoSize = True
        Me.lblDPI.Location = New System.Drawing.Point(26, 165)
        Me.lblDPI.Name = "lblDPI"
        Me.lblDPI.Size = New System.Drawing.Size(69, 13)
        Me.lblDPI.TabIndex = 38
        Me.lblDPI.Text = "Cedula / DPI"
        '
        'txtDPI
        '
        Me.txtDPI.Location = New System.Drawing.Point(143, 162)
        Me.txtDPI.MaxLength = 70
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.Size = New System.Drawing.Size(100, 20)
        Me.txtDPI.TabIndex = 37
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(26, 87)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 36
        Me.lblNombre.Text = "Nombre"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(26, 348)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 71
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(143, 345)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 70
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(26, 322)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 69
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(143, 319)
        Me.txtUsuario.MaxLength = 12
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 68
        '
        'cmbPuesto
        '
        Me.cmbPuesto.FormattingEnabled = True
        Me.cmbPuesto.Location = New System.Drawing.Point(143, 240)
        Me.cmbPuesto.Name = "cmbPuesto"
        Me.cmbPuesto.Size = New System.Drawing.Size(121, 21)
        Me.cmbPuesto.TabIndex = 67
        '
        'lblPuesto
        '
        Me.lblPuesto.AutoSize = True
        Me.lblPuesto.Location = New System.Drawing.Point(26, 240)
        Me.lblPuesto.Name = "lblPuesto"
        Me.lblPuesto.Size = New System.Drawing.Size(40, 13)
        Me.lblPuesto.TabIndex = 66
        Me.lblPuesto.Text = "Puesto"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(143, 110)
        Me.txtApellido.MaxLength = 40
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(354, 20)
        Me.txtApellido.TabIndex = 65
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(26, 113)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(44, 13)
        Me.lblApellido.TabIndex = 64
        Me.lblApellido.Text = "Apellido"
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 411)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(509, 22)
        Me.stsBarra.TabIndex = 72
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
        'frmModificarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 433)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.cmbPuesto)
        Me.Controls.Add(Me.lblPuesto)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dtpFechaContrato)
        Me.Controls.Add(Me.lblFechaContrato)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblSueldo)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDPI)
        Me.Controls.Add(Me.txtDPI)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmModificarEmpleado"
        Me.Text = "Modificar Empleado"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents dtpFechaContrato As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaContrato As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblSueldo As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDPI As System.Windows.Forms.Label
    Friend WithEvents txtDPI As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents cmbPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents lblPuesto As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
End Class
