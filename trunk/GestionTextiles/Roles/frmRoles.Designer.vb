<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoles))
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.dgvRoles = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbListaRoles = New System.Windows.Forms.GroupBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSeleccionarPermiso = New System.Windows.Forms.Button()
        Me.btnEliminarPermiso = New System.Windows.Forms.Button()
        Me.btnAsignarPermiso = New System.Windows.Forms.Button()
        Me.btnNPermiso = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListaRoles.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 538)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(598, 22)
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
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(98, 89)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(332, 20)
        Me.txtBusqueda.TabIndex = 0
        '
        'dgvRoles
        '
        Me.dgvRoles.AllowUserToAddRows = False
        Me.dgvRoles.AllowUserToDeleteRows = False
        Me.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoles.Location = New System.Drawing.Point(14, 50)
        Me.dgvRoles.Name = "dgvRoles"
        Me.dgvRoles.ReadOnly = True
        Me.dgvRoles.Size = New System.Drawing.Size(514, 170)
        Me.dgvRoles.TabIndex = 3
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(448, 84)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "B&uscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'gbListaRoles
        '
        Me.gbListaRoles.Controls.Add(Me.btnRegresar)
        Me.gbListaRoles.Controls.Add(Me.dgvRoles)
        Me.gbListaRoles.Location = New System.Drawing.Point(24, 137)
        Me.gbListaRoles.Name = "gbListaRoles"
        Me.gbListaRoles.Size = New System.Drawing.Size(542, 236)
        Me.gbListaRoles.TabIndex = 40
        Me.gbListaRoles.TabStop = False
        Me.gbListaRoles.Text = "Lista Roles"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(177, 22)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(253, 29)
        Me.lblTitulo.TabIndex = 39
        Me.lblTitulo.Text = "Módulo de Permisos"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(454, 496)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 34)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnSeleccionarPermiso
        '
        Me.btnSeleccionarPermiso.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSeleccionarPermiso.Image = Global.GestionTextiles.My.Resources.Resources.wintick1
        Me.btnSeleccionarPermiso.Location = New System.Drawing.Point(454, 405)
        Me.btnSeleccionarPermiso.Name = "btnSeleccionarPermiso"
        Me.btnSeleccionarPermiso.Size = New System.Drawing.Size(97, 85)
        Me.btnSeleccionarPermiso.TabIndex = 7
        Me.btnSeleccionarPermiso.Text = "Seleccionar permiso"
        Me.btnSeleccionarPermiso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSeleccionarPermiso.UseVisualStyleBackColor = False
        '
        'btnEliminarPermiso
        '
        Me.btnEliminarPermiso.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarPermiso.Image = Global.GestionTextiles.My.Resources.Resources.wincross1
        Me.btnEliminarPermiso.Location = New System.Drawing.Point(351, 405)
        Me.btnEliminarPermiso.Name = "btnEliminarPermiso"
        Me.btnEliminarPermiso.Size = New System.Drawing.Size(97, 85)
        Me.btnEliminarPermiso.TabIndex = 6
        Me.btnEliminarPermiso.Text = "Eliminar permiso"
        Me.btnEliminarPermiso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarPermiso.UseVisualStyleBackColor = False
        '
        'btnAsignarPermiso
        '
        Me.btnAsignarPermiso.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAsignarPermiso.Image = Global.GestionTextiles.My.Resources.Resources.winhand1
        Me.btnAsignarPermiso.Location = New System.Drawing.Point(248, 405)
        Me.btnAsignarPermiso.Name = "btnAsignarPermiso"
        Me.btnAsignarPermiso.Size = New System.Drawing.Size(97, 85)
        Me.btnAsignarPermiso.TabIndex = 5
        Me.btnAsignarPermiso.Text = "Modificar permisos"
        Me.btnAsignarPermiso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAsignarPermiso.UseVisualStyleBackColor = False
        '
        'btnNPermiso
        '
        Me.btnNPermiso.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNPermiso.Image = Global.GestionTextiles.My.Resources.Resources.winarrow1
        Me.btnNPermiso.Location = New System.Drawing.Point(145, 405)
        Me.btnNPermiso.Name = "btnNPermiso"
        Me.btnNPermiso.Size = New System.Drawing.Size(97, 85)
        Me.btnNPermiso.TabIndex = 4
        Me.btnNPermiso.Text = "Nuevo permiso"
        Me.btnNPermiso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNPermiso.UseVisualStyleBackColor = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(38, 92)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 41
        Me.lblBuscar.Text = "Buscar"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegresar.Image = Global.GestionTextiles.My.Resources.Resources.refresh
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.Location = New System.Drawing.Point(439, 19)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(88, 23)
        Me.btnRegresar.TabIndex = 6
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'frmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(598, 560)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gbListaRoles)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnSeleccionarPermiso)
        Me.Controls.Add(Me.btnEliminarPermiso)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAsignarPermiso)
        Me.Controls.Add(Me.btnNPermiso)
        Me.Controls.Add(Me.stsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definición de Roles"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbListaRoles.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnNPermiso As System.Windows.Forms.Button
    Friend WithEvents btnAsignarPermiso As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminarPermiso As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionarPermiso As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dgvRoles As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbListaRoles As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
End Class
