Public Class frmReporteDevolucionesProveedor

    Private Sub txtNit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNit.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub dtpInicio_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.MouseLeave
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dtpFin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.MouseLeave
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.MouseLeave
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub chFecha_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub chNit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub rptvReporte_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub chFecha_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' slblDescripcion.Text = "Seleccióne para buscar las devoluciones de los proveedores por fecha"
    End Sub

    Private Sub chNit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '' slblDescripcion.Text = "Seleccióne para buscar las devoluciones de un proveedor especifico"
    End Sub

    Private Sub dtpInicio_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.MouseHover
        ''slblDescripcion.Text = "Seleccióne la fecha inicial de busqueda"
    End Sub

    Private Sub dtpFin_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.MouseHover
        ''slblDescripcion.Text = "Seleccióne la fecha final de busqueda"
    End Sub

    Private Sub txtNit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.MouseHover
        ''slblDescripcion.Text = "Ingrese el Nit del proveedor para buscar las devoluciones que a hecho"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        ''slblDescripcion.Text = "Salir del reporte actual"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        ''slblDescripcion.Text = "Mostrar el Reporte requerido"
    End Sub

    Private Sub rptvReporte_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''slblDescripcion.Text = "Reporte de devoluciónes por proveedor"
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    End Sub
End Class