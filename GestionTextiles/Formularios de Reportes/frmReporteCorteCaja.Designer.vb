﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCorteCaja
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
        Me.lblTitulo1 = New System.Windows.Forms.Label()
        Me.gbParametros1 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblFin = New System.Windows.Forms.Label()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.crvReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CierreDeCajaFinal1 = New GestionTextiles.CierreDeCajaFinal()
        Me.gbParametros1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo1.Location = New System.Drawing.Point(189, -79)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(161, 29)
        Me.lblTitulo1.TabIndex = 10
        Me.lblTitulo1.Text = "Reporte de..."
        '
        'gbParametros1
        '
        Me.gbParametros1.Controls.Add(Me.btnCancelar)
        Me.gbParametros1.Controls.Add(Me.btnAceptar)
        Me.gbParametros1.Controls.Add(Me.lblFin)
        Me.gbParametros1.Controls.Add(Me.lblInicio)
        Me.gbParametros1.Controls.Add(Me.dtpFin)
        Me.gbParametros1.Controls.Add(Me.dtpInicio)
        Me.gbParametros1.Location = New System.Drawing.Point(2, 96)
        Me.gbParametros1.Name = "gbParametros1"
        Me.gbParametros1.Size = New System.Drawing.Size(1332, 77)
        Me.gbParametros1.TabIndex = 12
        Me.gbParametros1.TabStop = False
        Me.gbParametros1.Text = "Parámetros"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(1141, 48)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(1239, 48)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 30
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblFin
        '
        Me.lblFin.AutoSize = True
        Me.lblFin.Location = New System.Drawing.Point(697, 32)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(21, 13)
        Me.lblFin.TabIndex = 3
        Me.lblFin.Text = "Fin"
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(381, 32)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(32, 13)
        Me.lblInicio.TabIndex = 2
        Me.lblInicio.Text = "Inicio"
        '
        'dtpFin
        '
        Me.dtpFin.Location = New System.Drawing.Point(724, 32)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(206, 20)
        Me.dtpFin.TabIndex = 1
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(419, 32)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(197, 20)
        Me.dtpInicio.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitulo.Location = New System.Drawing.Point(635, 50)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(321, 29)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "Reporte de Cierre de Caja"
        '
        'crvReporte
        '
        Me.crvReporte.ActiveViewIndex = -1
        Me.crvReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReporte.Location = New System.Drawing.Point(25, 179)
        Me.crvReporte.Name = "crvReporte"
        Me.crvReporte.Size = New System.Drawing.Size(1322, 435)
        Me.crvReporte.TabIndex = 14
        '
        'frmReporteCorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 613)
        Me.Controls.Add(Me.crvReporte)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gbParametros1)
        Me.Controls.Add(Me.lblTitulo1)
        Me.Name = "frmReporteCorteCaja"
        Me.Text = "Reporte Cierre de Caja"
        Me.gbParametros1.ResumeLayout(False)
        Me.gbParametros1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo1 As System.Windows.Forms.Label
    Friend WithEvents gbParametros1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblFin As System.Windows.Forms.Label
    Friend WithEvents lblInicio As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents crvReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CierreDeCajaFinal1 As GestionTextiles.CierreDeCajaFinal


End Class
