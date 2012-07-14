Public Class frmReporteCorteCaja

    Private Sub frmReporteCorteCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dtpInicio_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.MouseLeave
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dtpFin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.MouseLeave
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dtpInicio_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.MouseHover
        ''slblDescripcion.Text = "Selección de la fecha de incio de corte de caja"
    End Sub

    Private Sub dtpFin_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFin.MouseHover
        ''slblDescripcion.Text = "Selección de la fecha final del corte de caja"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''slblDescripcion.Text = "Muestra el reporte de caja en las fechas seleccionadas"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        ''slblDescripcion.Text = "Cierra el reporte presente"
    End Sub

    Private Sub btnAceptar_MouseHover_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        ''slblDescripcion.Text = "Muestra el reporte de cierre de caja en las fechas seleccionadas"
    End Sub

    Private Sub rptvReporte_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub rptvReporte_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''slblDescripcion.Text = "Reporte de cierre de caja"
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    End Sub
End Class