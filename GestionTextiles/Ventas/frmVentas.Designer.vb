<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.stsBarra = New System.Windows.Forms.StatusStrip()
        Me.slblDescripcion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.slblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbListaSeries = New System.Windows.Forms.GroupBox()
        Me.dgvSeries = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.btnFacturar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.stsBarra.SuspendLayout()
        Me.gbListaSeries.SuspendLayout()
        CType(Me.dgvSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 503)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(634, 22)
        Me.stsBarra.TabIndex = 0
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
        'btnAnular
        '
        Me.btnAnular.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.Location = New System.Drawing.Point(505, 384)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(97, 77)
        Me.btnAnular.TabIndex = 6
        Me.btnAnular.Text = "An&ular Factura"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnular.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.Location = New System.Drawing.Point(505, 467)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(97, 29)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "Anula una factura, utilizando la serie y su correlativo"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(207, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(226, 29)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Módulo de Ventas"
        '
        'gbListaSeries
        '
        Me.gbListaSeries.Controls.Add(Me.btnRegresar)
        Me.gbListaSeries.Controls.Add(Me.dgvSeries)
        Me.gbListaSeries.Location = New System.Drawing.Point(12, 138)
        Me.gbListaSeries.Name = "gbListaSeries"
        Me.gbListaSeries.Size = New System.Drawing.Size(610, 240)
        Me.gbListaSeries.TabIndex = 63
        Me.gbListaSeries.TabStop = False
        Me.gbListaSeries.Text = "Listado Facturas"
        '
        'dgvSeries
        '
        Me.dgvSeries.AllowUserToAddRows = False
        Me.dgvSeries.AllowUserToDeleteRows = False
        Me.dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeries.Location = New System.Drawing.Point(12, 37)
        Me.dgvSeries.Name = "dgvSeries"
        Me.dgvSeries.ReadOnly = True
        Me.dgvSeries.Size = New System.Drawing.Size(578, 188)
        Me.dgvSeries.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(294, 96)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 25)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "B&uscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(146, 99)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 1
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(92, 102)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(44, 13)
        Me.lblNumero.TabIndex = 11
        Me.lblNumero.Text = "Numero"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Location = New System.Drawing.Point(92, 73)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(31, 13)
        Me.lblSerie.TabIndex = 10
        Me.lblSerie.Text = "Serie"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(146, 70)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtSerie.TabIndex = 0
        '
        'btnFacturar
        '
        Me.btnFacturar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFacturar.Image = CType(resources.GetObject("btnFacturar.Image"), System.Drawing.Image)
        Me.btnFacturar.Location = New System.Drawing.Point(389, 384)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(98, 77)
        Me.btnFacturar.TabIndex = 5
        Me.btnFacturar.Text = "&Facturar"
        Me.btnFacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFacturar.UseVisualStyleBackColor = False
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegresar.Image = Global.GestionTextiles.My.Resources.Resources.refresh
        Me.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegresar.Location = New System.Drawing.Point(502, 8)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(88, 23)
        Me.btnRegresar.TabIndex = 5
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(634, 525)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.gbListaSeries)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblSerie)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.stsBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        Me.gbListaSeries.ResumeLayout(False)
        CType(Me.dgvSeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stsBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDescripcion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents gbListaSeries As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSeries As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblSerie As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button

End Class
