<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModuloSeries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModuloSeries))
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvSeries = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnEliminarSerie = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnmSerie = New System.Windows.Forms.Button()
        Me.btnNSerie = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 438)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(521, 22)
        Me.stsBarra.TabIndex = 11
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
        'dgvSeries
        '
        Me.dgvSeries.AllowUserToAddRows = False
        Me.dgvSeries.AllowUserToDeleteRows = False
        Me.dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeries.Location = New System.Drawing.Point(40, 159)
        Me.dgvSeries.Name = "dgvSeries"
        Me.dgvSeries.ReadOnly = True
        Me.dgvSeries.Size = New System.Drawing.Size(443, 159)
        Me.dgvSeries.TabIndex = 19
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(89, 84)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(279, 20)
        Me.txtBusqueda.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Location = New System.Drawing.Point(380, 81)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnBuscar.TabIndex = 23
        Me.btnBuscar.Text = "B&uscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(84, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(373, 29)
        Me.lblTitulo.TabIndex = 24
        Me.lblTitulo.Text = "Módulo Gestión de Talonarios"
        '
        'btnEliminarSerie
        '
        Me.btnEliminarSerie.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarSerie.Image = CType(resources.GetObject("btnEliminarSerie.Image"), System.Drawing.Image)
        Me.btnEliminarSerie.Location = New System.Drawing.Point(271, 337)
        Me.btnEliminarSerie.Name = "btnEliminarSerie"
        Me.btnEliminarSerie.Size = New System.Drawing.Size(97, 77)
        Me.btnEliminarSerie.TabIndex = 21
        Me.btnEliminarSerie.Text = "&Eliminar Cliente"
        Me.btnEliminarSerie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarSerie.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = Global.GestionTextiles.My.Resources.Resources.refresh
        Me.Button2.Location = New System.Drawing.Point(456, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 25)
        Me.Button2.TabIndex = 18
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnmSerie
        '
        Me.btnmSerie.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmSerie.Image = CType(resources.GetObject("btnmSerie.Image"), System.Drawing.Image)
        Me.btnmSerie.Location = New System.Drawing.Point(156, 337)
        Me.btnmSerie.Name = "btnmSerie"
        Me.btnmSerie.Size = New System.Drawing.Size(97, 77)
        Me.btnmSerie.TabIndex = 13
        Me.btnmSerie.Text = "Modificar Serie"
        Me.btnmSerie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmSerie.UseVisualStyleBackColor = False
        '
        'btnNSerie
        '
        Me.btnNSerie.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNSerie.Image = Global.GestionTextiles.My.Resources.Resources.numberhash1
        Me.btnNSerie.Location = New System.Drawing.Point(40, 337)
        Me.btnNSerie.Name = "btnNSerie"
        Me.btnNSerie.Size = New System.Drawing.Size(97, 77)
        Me.btnNSerie.TabIndex = 12
        Me.btnNSerie.Text = "Nueva Serie"
        Me.btnNSerie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNSerie.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(385, 337)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 77)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmModuloSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 460)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminarSerie)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.dgvSeries)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnmSerie)
        Me.Controls.Add(Me.btnNSerie)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.stsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmModuloSeries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo Series"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        CType(Me.dgvSeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnmSerie As System.Windows.Forms.Button
    Friend WithEvents btnNSerie As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvSeries As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarSerie As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
