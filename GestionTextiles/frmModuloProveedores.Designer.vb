<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuloProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModuloProveedores))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNProveedor = New System.Windows.Forms.Button()
        Me.btnLProveedores = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(60, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(287, 29)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Módulo de Proveedores"
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 255)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(423, 22)
        Me.stsBarra.TabIndex = 7
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
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(91, 153)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(214, 64)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNProveedor
        '
        Me.btnNProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNProveedor.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNProveedor.Image = CType(resources.GetObject("btnNProveedor.Image"), System.Drawing.Image)
        Me.btnNProveedor.Location = New System.Drawing.Point(91, 50)
        Me.btnNProveedor.Name = "btnNProveedor"
        Me.btnNProveedor.Size = New System.Drawing.Size(97, 77)
        Me.btnNProveedor.TabIndex = 0
        Me.btnNProveedor.Text = "Nuevo Proveedor"
        Me.btnNProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNProveedor.UseVisualStyleBackColor = False
        '
        'btnLProveedores
        '
        Me.btnLProveedores.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLProveedores.Image = CType(resources.GetObject("btnLProveedores.Image"), System.Drawing.Image)
        Me.btnLProveedores.Location = New System.Drawing.Point(208, 50)
        Me.btnLProveedores.Name = "btnLProveedores"
        Me.btnLProveedores.Size = New System.Drawing.Size(97, 77)
        Me.btnLProveedores.TabIndex = 1
        Me.btnLProveedores.Text = "Lista Proveedores"
        Me.btnLProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLProveedores.UseVisualStyleBackColor = False
        '
        'frmModuloProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(423, 277)
        Me.Controls.Add(Me.btnLProveedores)
        Me.Controls.Add(Me.btnNProveedor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmModuloProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo de Proveedores"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNProveedor As System.Windows.Forms.Button
    Friend WithEvents btnLProveedores As System.Windows.Forms.Button
End Class
