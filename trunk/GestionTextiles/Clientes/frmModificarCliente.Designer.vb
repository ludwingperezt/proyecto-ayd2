<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCliente
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
        Me.btntipocliente = New System.Windows.Forms.Button()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmbtipocliente = New System.Windows.Forms.ComboBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.lbltipocliente = New System.Windows.Forms.Label()
        Me.lblnit = New System.Windows.Forms.Label()
        Me.lbdireccion = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'btntipocliente
        '
        Me.btntipocliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntipocliente.Location = New System.Drawing.Point(272, 172)
        Me.btntipocliente.Name = "btntipocliente"
        Me.btntipocliente.Size = New System.Drawing.Size(175, 24)
        Me.btntipocliente.TabIndex = 5
        Me.btntipocliente.Text = "Gestion  tipo cliente"
        Me.btntipocliente.UseVisualStyleBackColor = False
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 305)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(454, 22)
        Me.stsBarra.TabIndex = 57
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
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(262, 254)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(355, 254)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'cmbtipocliente
        '
        Me.cmbtipocliente.FormattingEnabled = True
        Me.cmbtipocliente.ItemHeight = 13
        Me.cmbtipocliente.Location = New System.Drawing.Point(116, 175)
        Me.cmbtipocliente.Name = "cmbtipocliente"
        Me.cmbtipocliente.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipocliente.TabIndex = 54
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(113, 140)
        Me.txtnit.MaxLength = 12
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(124, 20)
        Me.txtnit.TabIndex = 3
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(113, 107)
        Me.txtdireccion.MaxLength = 60
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(274, 20)
        Me.txtdireccion.TabIndex = 2
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(113, 69)
        Me.txtnombre.MaxLength = 40
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(274, 20)
        Me.txtnombre.TabIndex = 0
        '
        'lbltipocliente
        '
        Me.lbltipocliente.AutoSize = True
        Me.lbltipocliente.Location = New System.Drawing.Point(41, 178)
        Me.lbltipocliente.Name = "lbltipocliente"
        Me.lbltipocliente.Size = New System.Drawing.Size(68, 13)
        Me.lbltipocliente.TabIndex = 49
        Me.lbltipocliente.Text = "Tipo cliente: "
        '
        'lblnit
        '
        Me.lblnit.AutoSize = True
        Me.lblnit.Location = New System.Drawing.Point(41, 143)
        Me.lblnit.Name = "lblnit"
        Me.lblnit.Size = New System.Drawing.Size(26, 13)
        Me.lblnit.TabIndex = 48
        Me.lblnit.Text = "Nit: "
        '
        'lbdireccion
        '
        Me.lbdireccion.AutoSize = True
        Me.lbdireccion.Location = New System.Drawing.Point(41, 110)
        Me.lbdireccion.Name = "lbdireccion"
        Me.lbdireccion.Size = New System.Drawing.Size(58, 13)
        Me.lbdireccion.TabIndex = 47
        Me.lbdireccion.Text = "Direccion: "
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(41, 69)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(50, 13)
        Me.lblnombre.TabIndex = 45
        Me.lblnombre.Text = "Nombre: "
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(96, 20)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(266, 29)
        Me.lblTitulo.TabIndex = 44
        Me.lblTitulo.Text = "Modificación Cliente"
        '
        'frmModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 327)
        Me.Controls.Add(Me.btntipocliente)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbtipocliente)
        Me.Controls.Add(Me.txtnit)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.lbltipocliente)
        Me.Controls.Add(Me.lblnit)
        Me.Controls.Add(Me.lbdireccion)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmModificarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Cliente"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btntipocliente As System.Windows.Forms.Button
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents cmbtipocliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtnit As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lbltipocliente As System.Windows.Forms.Label
    Friend WithEvents lblnit As System.Windows.Forms.Label
    Friend WithEvents lbdireccion As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
