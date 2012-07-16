<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteDevolucionesProveedorNit
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
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.devolucionesProveedorFechaNitFinal1 = New GestionTextiles.devolucionesProveedorFechaNitFinal()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbParametros1 = New System.Windows.Forms.GroupBox()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.lblNitCLiente = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.gbParametros1.SuspendLayout()
        Me.SuspendLayout()
        '
        'crvReporte
        '
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReporte.Location = New System.Drawing.Point(12, 144)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.Size = New System.Drawing.Size(1024, 649)
        Me.crvReporte.TabIndex = 23
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(273, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(504, 29)
        Me.lblTitulo.TabIndex = 22
        Me.lblTitulo.Text = "Reporte Devoluciónes  Proveedor por Nit"
        '
        'gbParametros1
        '
        Me.gbParametros1.Controls.Add(Me.txtNit)
        Me.gbParametros1.Controls.Add(Me.lblNitCLiente)
        Me.gbParametros1.Controls.Add(Me.btnCancelar)
        Me.gbParametros1.Controls.Add(Me.btnAceptar)
        Me.gbParametros1.Location = New System.Drawing.Point(12, 61)
        Me.gbParametros1.Name = "gbParametros1"
        Me.gbParametros1.Size = New System.Drawing.Size(835, 77)
        Me.gbParametros1.TabIndex = 21
        Me.gbParametros1.TabStop = False
        Me.gbParametros1.Text = "Parámetros"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(287, 32)
        Me.txtNit.MaxLength = 12
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(188, 20)
        Me.txtNit.TabIndex = 33
        '
        'lblNitCLiente
        '
        Me.lblNitCLiente.AutoSize = True
        Me.lblNitCLiente.Location = New System.Drawing.Point(189, 32)
        Me.lblNitCLiente.Name = "lblNitCLiente"
        Me.lblNitCLiente.Size = New System.Drawing.Size(78, 13)
        Me.lblNitCLiente.TabIndex = 32
        Me.lblNitCLiente.Text = "Nit Proveedor: "
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(656, 48)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(754, 48)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 30
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'frmReporteDevolucionesProveedorNit
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(1038, 658)
        Me.Controls.Add(Me.crvReporte)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gbParametros1)
        Me.MaximizeBox = False
        Me.Name = "frmReporteDevolucionesProveedorNit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devoluciónes Proveedor por Nit"
        Me.gbParametros1.ResumeLayout(False)
        Me.gbParametros1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents gbParametros1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNit As System.Windows.Forms.TextBox
    Friend WithEvents lblNitCLiente As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents devolucionesProveedorFechaNitFinal1 As GestionTextiles.devolucionesProveedorFechaNitFinal

End Class
