﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnNCredito = New System.Windows.Forms.Button()
        Me.btnNProveedor = New System.Windows.Forms.Button()
        Me.btnNCompra = New System.Windows.Forms.Button()
        Me.btnLProveedores = New System.Windows.Forms.Button()
        Me.btnLCompras = New System.Windows.Forms.Button()
        Me.btnLNCredito = New System.Windows.Forms.Button()
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
        Me.stsBarra.Location = New System.Drawing.Point(0, 407)
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
        Me.btnSalir.Location = New System.Drawing.Point(91, 326)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(234, 64)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNCredito
        '
        Me.btnNCredito.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNCredito.Image = CType(resources.GetObject("btnNCredito.Image"), System.Drawing.Image)
        Me.btnNCredito.Location = New System.Drawing.Point(91, 226)
        Me.btnNCredito.Name = "btnNCredito"
        Me.btnNCredito.Size = New System.Drawing.Size(99, 77)
        Me.btnNCredito.TabIndex = 4
        Me.btnNCredito.Text = "Notas de Crédito"
        Me.btnNCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNCredito.UseVisualStyleBackColor = False
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
        'btnNCompra
        '
        Me.btnNCompra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNCompra.Image = CType(resources.GetObject("btnNCompra.Image"), System.Drawing.Image)
        Me.btnNCompra.Location = New System.Drawing.Point(93, 137)
        Me.btnNCompra.Name = "btnNCompra"
        Me.btnNCompra.Size = New System.Drawing.Size(97, 77)
        Me.btnNCompra.TabIndex = 2
        Me.btnNCompra.Text = "Nueva Compra"
        Me.btnNCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNCompra.UseVisualStyleBackColor = False
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
        'btnLCompras
        '
        Me.btnLCompras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLCompras.Image = CType(resources.GetObject("btnLCompras.Image"), System.Drawing.Image)
        Me.btnLCompras.Location = New System.Drawing.Point(208, 137)
        Me.btnLCompras.Name = "btnLCompras"
        Me.btnLCompras.Size = New System.Drawing.Size(97, 77)
        Me.btnLCompras.TabIndex = 3
        Me.btnLCompras.Text = "Lista &Compras"
        Me.btnLCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLCompras.UseVisualStyleBackColor = False
        '
        'btnLNCredito
        '
        Me.btnLNCredito.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLNCredito.Image = CType(resources.GetObject("btnLNCredito.Image"), System.Drawing.Image)
        Me.btnLNCredito.Location = New System.Drawing.Point(208, 226)
        Me.btnLNCredito.Name = "btnLNCredito"
        Me.btnLNCredito.Size = New System.Drawing.Size(99, 77)
        Me.btnLNCredito.TabIndex = 5
        Me.btnLNCredito.Text = "Lista Notas de Crédito"
        Me.btnLNCredito.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLNCredito.UseVisualStyleBackColor = False
        '
        'frmModuloProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(423, 429)
        Me.Controls.Add(Me.btnLCompras)
        Me.Controls.Add(Me.btnLProveedores)
        Me.Controls.Add(Me.btnNCompra)
        Me.Controls.Add(Me.btnLNCredito)
        Me.Controls.Add(Me.btnNCredito)
        Me.Controls.Add(Me.btnNProveedor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblTitulo)
        Me.MaximizeBox = False
        Me.Name = "frmModuloProveedores"
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
    Friend WithEvents btnNCredito As System.Windows.Forms.Button
    Friend WithEvents btnNProveedor As System.Windows.Forms.Button
    Friend WithEvents btnNCompra As System.Windows.Forms.Button
    Friend WithEvents btnLProveedores As System.Windows.Forms.Button
    Friend WithEvents btnLCompras As System.Windows.Forms.Button
    Friend WithEvents btnLNCredito As System.Windows.Forms.Button
End Class