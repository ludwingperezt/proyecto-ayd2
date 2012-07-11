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
        Me.btnmSerie = New System.Windows.Forms.Button()
        Me.btnNSerie = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btneSerie = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvSeries = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.stsBarra.SuspendLayout()
        CType(Me.dgvSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblDescripcion, Me.slblFecha})
        Me.stsBarra.Location = New System.Drawing.Point(0, 495)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(1174, 22)
        Me.stsBarra.TabIndex = 11
        Me.stsBarra.Text = "StatusStrip1"
        '
        'slblDescripcion
        '
        Me.slblDescripcion.AutoToolTip = True
        Me.slblDescripcion.Name = "slblDescripcion"
        Me.slblDescripcion.Size = New System.Drawing.Size(61, 17)
        Me.slblDescripcion.Text = "Descripción"
        '
        'slblFecha
        '
        Me.slblFecha.Name = "slblFecha"
        Me.slblFecha.Size = New System.Drawing.Size(81, 17)
        Me.slblFecha.Text = "FECHA Y HORA"
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
        Me.btnSalir.Location = New System.Drawing.Point(458, 411)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(214, 64)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(126, 22)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(442, 31)
        Me.lblTitulo.TabIndex = 14
        Me.lblTitulo.Text = "Módulo de Gestión de Talonarios"
        '
        'btneSerie
        '
        Me.btneSerie.Location = New System.Drawing.Point(274, 337)
        Me.btneSerie.Name = "btneSerie"
        Me.btneSerie.Size = New System.Drawing.Size(154, 47)
        Me.btneSerie.TabIndex = 16
        Me.btneSerie.Text = "Eliminar serie"
        Me.btneSerie.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(503, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(584, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Actualizar lista"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvSeries
        '
        Me.dgvSeries.AllowUserToAddRows = False
        Me.dgvSeries.AllowUserToDeleteRows = False
        Me.dgvSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeries.Location = New System.Drawing.Point(30, 143)
        Me.dgvSeries.Name = "dgvSeries"
        Me.dgvSeries.ReadOnly = True
        Me.dgvSeries.Size = New System.Drawing.Size(453, 150)
        Me.dgvSeries.TabIndex = 19
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(30, 107)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(453, 20)
        Me.txtBusqueda.TabIndex = 20
        '
        'frmModuloSeries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 517)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.dgvSeries)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btneSerie)
        Me.Controls.Add(Me.btnmSerie)
        Me.Controls.Add(Me.btnNSerie)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTitulo)
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
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btneSerie As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvSeries As System.Windows.Forms.DataGridView
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
End Class
