﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtDPI = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDPI = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.lblFechaContrato = New System.Windows.Forms.Label()
        Me.dtpFechaContrato = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 309)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(522, 22)
        Me.stsBarra.TabIndex = 8
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
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(143, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(214, 29)
        Me.lblTitulo.TabIndex = 28
        Me.lblTitulo.Text = "Nuevo Empleado"
        '
        'txtDPI
        '
        Me.txtDPI.Location = New System.Drawing.Point(148, 97)
        Me.txtDPI.MaxLength = 70
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.Size = New System.Drawing.Size(100, 20)
        Me.txtDPI.TabIndex = 19
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(31, 74)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(148, 71)
        Me.txtNombre.MaxLength = 70
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(354, 20)
        Me.txtNombre.TabIndex = 21
        '
        'lblDPI
        '
        Me.lblDPI.AutoSize = True
        Me.lblDPI.Location = New System.Drawing.Point(31, 100)
        Me.lblDPI.Name = "lblDPI"
        Me.lblDPI.Size = New System.Drawing.Size(69, 13)
        Me.lblDPI.TabIndex = 20
        Me.lblDPI.Text = "Cedula / DPI"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(146, 203)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 26
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(146, 177)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(100, 20)
        Me.txtCelular.TabIndex = 27
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(29, 180)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 23
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(29, 154)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 24
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(148, 123)
        Me.txtDireccion.MaxLength = 60
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(354, 20)
        Me.txtDireccion.TabIndex = 29
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(31, 123)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lblDireccion.TabIndex = 28
        Me.lblDireccion.Text = "Dirección"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(148, 151)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 31
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(31, 206)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(40, 13)
        Me.lblSueldo.TabIndex = 30
        Me.lblSueldo.Text = "Sueldo"
        '
        'lblFechaContrato
        '
        Me.lblFechaContrato.AutoSize = True
        Me.lblFechaContrato.Location = New System.Drawing.Point(31, 229)
        Me.lblFechaContrato.Name = "lblFechaContrato"
        Me.lblFechaContrato.Size = New System.Drawing.Size(95, 13)
        Me.lblFechaContrato.TabIndex = 32
        Me.lblFechaContrato.Text = "Fecha de Contrato"
        '
        'dtpFechaContrato
        '
        Me.dtpFechaContrato.Location = New System.Drawing.Point(148, 229)
        Me.dtpFechaContrato.Name = "dtpFechaContrato"
        Me.dtpFechaContrato.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaContrato.TabIndex = 33
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(329, 266)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(427, 266)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 331)
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
        Me.Controls.Add(Me.stsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmpleados"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtDPI As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDPI As System.Windows.Forms.Label
    Friend WithEvents txtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lblSueldo As System.Windows.Forms.Label
    Friend WithEvents lblFechaContrato As System.Windows.Forms.Label
    Friend WithEvents dtpFechaContrato As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class