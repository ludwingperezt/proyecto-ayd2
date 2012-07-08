Public Class frmReporteFacturasEliminadas

    Private Sub txtNit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNit.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub dtpInicio_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dtpFin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub rptvReporte_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptvReporte.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub chFecha_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFecha.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub chNit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chNit.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub chFecha_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chFecha.MouseHover
        slblDescripcion.Text = "Opción para habilitar la busqueda de facturas eliminadas por fecha"
    End Sub

    Private Sub chNit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chNit.MouseHover
        slblDescripcion.Text = "Opción para habilitar la busqueda de facturas eliminadas por cliente"
    End Sub

    Private Sub dtpInicio_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.MouseHover
        slblDescripcion.Text = "Seleccióne la fecha de inicio para la busqueda"
    End Sub

    Private Sub dtpFin_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.MouseHover
        slblDescripcion.Text = "Seleccióne la fecha de fin para la busqueda"
    End Sub

    Private Sub txtNit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.MouseHover
        slblDescripcion.Text = "Ingrese el nit del cliente a buscar"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Sale del reporte actual"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Muestra el reporte requerido"
    End Sub

    Private Sub rptvReporte_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptvReporte.MouseHover
        slblDescripcion.Text = "Reporte de las facturas eliminadas"
    End Sub
End Class