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
        Me.btnEliminarSerie = New System.Windows.Forms.Button()
        Me.btnmSerie = New System.Windows.Forms.Button()
        Me.btnNSerie = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbListaSeries = New System.Windows.Forms.GroupBox()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListaSeries.SuspendLayout()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 468)
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
        Me.dgvSeries.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeries.Location = New System.Drawing.Point(12, 39)
        Me.dgvSeries.Name = "dgvSeries"
        Me.dgvSeries.ReadOnly = True
        Me.dgvSeries.Size = New System.Drawing.Size(443, 172)
        Me.dgvSeries.TabIndex = 3
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(89, 69)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(279, 20)
        Me.txtBusqueda.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(380, 66)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "B&uscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminarSerie
        '
        Me.btnEliminarSerie.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarSerie.Image = CType(resources.GetObject("btnEliminarSerie.Image"), System.Drawing.Image)
        Me.btnEliminarSerie.Location = New System.Drawing.Point(386, 348)
        Me.btnEliminarSerie.Name = "btnEliminarSerie"
        Me.btnEliminarSerie.Size = New System.Drawing.Size(97, 77)
        Me.btnEliminarSerie.TabIndex = 6
        Me.btnEliminarSerie.Text = "&Eliminar Serie"
        Me.btnEliminarSerie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarSerie.UseVisualStyleBackColor = False
        '
        'btnmSerie
        '
        Me.btnmSerie.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmSerie.Image = CType(resources.GetObject("btnmSerie.Image"), System.Drawing.Image)
        Me.btnmSerie.Location = New System.Drawing.Point(271, 348)
        Me.btnmSerie.Name = "btnmSerie"
        Me.btnmSerie.Size = New System.Drawing.Size(97, 77)
        Me.btnmSerie.TabIndex = 5
        Me.btnmSerie.Text = "M&odificar Serie"
        Me.btnmSerie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmSerie.UseVisualStyleBackColor = False
        '
        'btnNSerie
        '
        Me.btnNSerie.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNSerie.Enabled = False
        Me.btnNSerie.Image = Global.GestionTextiles.My.Resources.Resources.numberhash1
        Me.btnNSerie.Location = New System.Drawing.Point(158, 348)
        Me.btnNSerie.Name = "btnNSerie"
        Me.btnNSerie.Size = New System.Drawing.Size(97, 77)
        Me.btnNSerie.TabIndex = 4
        Me.btnNSerie.Text = "&Nueva Serie"
        Me.btnNSerie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNSerie.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(385, 431)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 30)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'gbListaSeries
        '
        Me.gbListaSeries.Controls.Add(Me.btnRegresar)
        Me.gbListaSeries.Controls.Add(Me.dgvSeries)
        Me.gbListaSeries.Location = New System.Drawing.Point(28, 116)
        Me.gbListaSeries.Name = "gbListaSeries"
        Me.gbListaSeries.Size = New System.Drawing.Size(469, 226)
        Me.gbListaSeries.TabIndex = 25
        Me.gbListaSeries.TabStop = False
        Me.gbListaSeries.Text = "Listado Series"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegresar.Image = Global.GestionTextiles.My.Resources.Resources.refresh
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.Location = New System.Drawing.Point(367, 10)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(88, 23)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(63, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(408, 29)
        Me.lblTitulo.TabIndex = 30
        Me.lblTitulo.Text = "Modulo de Gestión de Talonarios"
        '
        'frmModuloSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(521, 490)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gbListaSeries)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEliminarSerie)
        Me.Controls.Add(Me.txtBusqueda)
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
        Me.gbListaSeries.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnmSerie As System.Windows.Forms.Button
    Friend WithEvents btnNSerie As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dgvSeries As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarSerie As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents gbListaSeries As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
