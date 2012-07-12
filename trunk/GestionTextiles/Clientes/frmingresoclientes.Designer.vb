<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmingresoclientes
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
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lbdireccion = New System.Windows.Forms.Label()
        Me.lblnit = New System.Windows.Forms.Label()
        Me.lbltipocliente = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnit = New System.Windows.Forms.TextBox()
        Me.cmbtipocliente = New System.Windows.Forms.ComboBox()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btntipocliente = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(142, 31)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(195, 29)
        Me.lblTitulo.TabIndex = 29
        Me.lblTitulo.Text = "Ingreso Cliente"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(54, 85)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(50, 13)
        Me.lblnombre.TabIndex = 30
        Me.lblnombre.Text = "Nombre: "
        '
        'lbdireccion
        '
        Me.lbdireccion.AutoSize = True
        Me.lbdireccion.Location = New System.Drawing.Point(54, 125)
        Me.lbdireccion.Name = "lbdireccion"
        Me.lbdireccion.Size = New System.Drawing.Size(58, 13)
        Me.lbdireccion.TabIndex = 32
        Me.lbdireccion.Text = "Direccion: "
        '
        'lblnit
        '
        Me.lblnit.AutoSize = True
        Me.lblnit.Location = New System.Drawing.Point(54, 158)
        Me.lblnit.Name = "lblnit"
        Me.lblnit.Size = New System.Drawing.Size(26, 13)
        Me.lblnit.TabIndex = 33
        Me.lblnit.Text = "Nit: "
        '
        'lbltipocliente
        '
        Me.lbltipocliente.AutoSize = True
        Me.lbltipocliente.Location = New System.Drawing.Point(54, 196)
        Me.lbltipocliente.Name = "lbltipocliente"
        Me.lbltipocliente.Size = New System.Drawing.Size(68, 13)
        Me.lbltipocliente.TabIndex = 34
        Me.lbltipocliente.Text = "Tipo cliente: "
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(126, 85)
        Me.txtnombre.MaxLength = 40
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(274, 20)
        Me.txtnombre.TabIndex = 0
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(126, 125)
        Me.txtdireccion.MaxLength = 60
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(274, 20)
        Me.txtdireccion.TabIndex = 2
        '
        'txtnit
        '
        Me.txtnit.Location = New System.Drawing.Point(126, 158)
        Me.txtnit.MaxLength = 15
        Me.txtnit.Name = "txtnit"
        Me.txtnit.Size = New System.Drawing.Size(124, 20)
        Me.txtnit.TabIndex = 3
        '
        'cmbtipocliente
        '
        Me.cmbtipocliente.FormattingEnabled = True
        Me.cmbtipocliente.ItemHeight = 13
        Me.cmbtipocliente.Location = New System.Drawing.Point(129, 193)
        Me.cmbtipocliente.Name = "cmbtipocliente"
        Me.cmbtipocliente.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipocliente.TabIndex = 39
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 334)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(494, 22)
        Me.stsBarra.TabIndex = 42
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
        Me.btnCancelar.Location = New System.Drawing.Point(275, 272)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(368, 272)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "&Agregar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btntipocliente
        '
        Me.btntipocliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btntipocliente.Location = New System.Drawing.Point(285, 190)
        Me.btntipocliente.Name = "btntipocliente"
        Me.btntipocliente.Size = New System.Drawing.Size(175, 24)
        Me.btntipocliente.TabIndex = 5
        Me.btntipocliente.Text = "Gestion  tipo cliente"
        Me.btntipocliente.UseVisualStyleBackColor = False
        '
        'frmingresoclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 356)
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
        Me.Name = "frmingresoclientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Clientes"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents lbdireccion As System.Windows.Forms.Label
    Friend WithEvents lblnit As System.Windows.Forms.Label
    Friend WithEvents lbltipocliente As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtnit As System.Windows.Forms.TextBox
    Friend WithEvents cmbtipocliente As System.Windows.Forms.ComboBox
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btntipocliente As System.Windows.Forms.Button
End Class
