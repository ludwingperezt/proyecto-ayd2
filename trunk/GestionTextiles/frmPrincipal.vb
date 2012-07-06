Public Class frmPrincipal

    '' TODOS LAS FECHAS SE DEBEN GESTIONAR DESDE ESTE TIMER
    Private Sub tmrRefrescarBarra_Tick(sender As System.Object, e As System.EventArgs) Handles tmrRefrescarBarra.Tick
        Me.slblFecha.Text = Date.Now
        frmAnular.slblFecha.Text = Date.Now
        frmVentas.slblFecha.Text = Date.Now
        frmFacturar.slblFecha.Text = Date.Now
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVentas.Click
        frmVentas.ShowDialog(Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedores.Click
        frmModuloProveedores.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCompras.Click
        frmCompras.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClientes.Click
        frmClientes.Show()

    End Sub

    Private Sub BtnEmpleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpleados.Click
        frmEmpleados.Show()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        this.Dispose()
    End Sub
End Class