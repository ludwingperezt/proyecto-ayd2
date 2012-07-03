Public Class frmModuloProveedores

    Private Sub btnNProveedor_Click(sender As System.Object, e As System.EventArgs) Handles btnNProveedor.Click
        frmNuevoProveedor.ShowDialog()

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()

    End Sub

    Private Sub btnNProveedor_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnNProveedor.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnLProveedores_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnLProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNProveedor_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnNProveedor.MouseHover
        slblDescripcion.Text = "Permite el ingreso de un nuevo proveedor"
    End Sub

    Private Sub btnLProveedores_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnLProveedores.MouseHover
        slblDescripcion.Text = "Lista los proveedores"
    End Sub

    Private Sub btnSalir_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Cierra el módulo de proveedores"
    End Sub
End Class