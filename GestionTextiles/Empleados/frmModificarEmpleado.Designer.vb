<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModificarEmpleado))
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblPuesto = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmbRolEmpleado = New System.Windows.Forms.ComboBox()
        Me.lblRolEmpleado = New System.Windows.Forms.Label()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.picbValidacion = New System.Windows.Forms.PictureBox()
        Me.imglValidacion = New System.Windows.Forms.ImageList(Me.components)
        Me.stsBarra.SuspendLayout()
        CType(Me.picbValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnCancelar.Location = New System.Drawing.Point(326, 389)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 14
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(424, 389)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'dtpFechaContrato
        '
        Me.dtpFechaContrato.Location = New System.Drawing.Point(143, 294)
        Me.dtpFechaContrato.Name = "dtpFechaContrato"
        Me.dtpFechaContrato.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaContrato.TabIndex = 8
        '
        'lblFechaContrato
        '
        Me.lblFechaContrato.AutoSize = True
        Me.lblFechaContrato.Location = New System.Drawing.Point(26, 294)
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
        Me.txtTelefono.TabIndex = 4
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(28, 323)
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
        Me.txtDireccion.TabIndex = 2
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
        Me.txtSueldo.Location = New System.Drawing.Point(143, 320)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 9
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(143, 214)
        Me.txtCelular.MaxLength = 15
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(100, 20)
        Me.txtCelular.TabIndex = 5
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
        Me.txtDPI.TabIndex = 3
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
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(26, 349)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 69
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(143, 346)
        Me.txtUsuario.MaxLength = 12
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 10
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
        Me.txtApellido.TabIndex = 1
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
        Me.stsBarra.Location = New System.Drawing.Point(0, 426)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(509, 22)
        Me.stsBarra.TabIndex = 15
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
        'cmbRolEmpleado
        '
        Me.cmbRolEmpleado.FormattingEnabled = True
        Me.cmbRolEmpleado.Location = New System.Drawing.Point(143, 267)
        Me.cmbRolEmpleado.Name = "cmbRolEmpleado"
        Me.cmbRolEmpleado.Size = New System.Drawing.Size(121, 21)
        Me.cmbRolEmpleado.TabIndex = 7
        '
        'lblRolEmpleado
        '
        Me.lblRolEmpleado.AutoSize = True
        Me.lblRolEmpleado.Location = New System.Drawing.Point(26, 270)
        Me.lblRolEmpleado.Name = "lblRolEmpleado"
        Me.lblRolEmpleado.Size = New System.Drawing.Size(23, 13)
        Me.lblRolEmpleado.TabIndex = 74
        Me.lblRolEmpleado.Text = "Rol"
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(143, 241)
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(100, 20)
        Me.txtPuesto.TabIndex = 75
        '
        'picbValidacion
        '
        Me.picbValidacion.Location = New System.Drawing.Point(262, 339)
        Me.picbValidacion.Name = "picbValidacion"
        Me.picbValidacion.Size = New System.Drawing.Size(33, 29)
        Me.picbValidacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbValidacion.TabIndex = 76
        Me.picbValidacion.TabStop = False
        '
        'imglValidacion
        '
        Me.imglValidacion.ImageStream = CType(resources.GetObject("imglValidacion.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglValidacion.TransparentColor = System.Drawing.Color.Transparent
        Me.imglValidacion.Images.SetKeyName(0, "noOK.jpg")
        Me.imglValidacion.Images.SetKeyName(1, "ok.png")
        '
        'frmModificarEmpleado
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(509, 448)
        Me.Controls.Add(Me.picbValidacion)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.cmbRolEmpleado)
        Me.Controls.Add(Me.lblRolEmpleado)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
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
        Me.MaximizeBox = False
        Me.Name = "frmModificarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Empleado"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        CType(Me.picbValidacion, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblPuesto As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmbRolEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents lblRolEmpleado As System.Windows.Forms.Label
    Friend WithEvents txtPuesto As System.Windows.Forms.TextBox
    Friend WithEvents picbValidacion As System.Windows.Forms.PictureBox
    Friend WithEvents imglValidacion As System.Windows.Forms.ImageList
End Class
