Public Class frmModuloProductos

    Private Sub txtbusqueda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvEmpleados_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEmpleados.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnIngresarProducto_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarProducto.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnModificarProducto_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProducto.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminarProducto_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtbusqueda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseHover
        slblDescripcion.Text = "Ingrese  algun dato del Producto a buscar ej. "
    End Sub

    Private Sub btnbuscar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Debe  precionar el boton 'buscar' para inciar la busqueda "
    End Sub

    Private Sub dgvEmpleados_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEmpleados.MouseHover
        slblDescripcion.Text = "Listado de Productos actuales"
    End Sub

    Private Sub btnIngresarProducto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarProducto.MouseHover
        slblDescripcion.Text = "Ingreso de nuevos Productos "
    End Sub

    Private Sub btnModificarProducto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProducto.MouseHover
        slblDescripcion.Text = "Modificación de  Productos"
    End Sub

    Private Sub btnEliminarProducto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.MouseHover
        slblDescripcion.Text = "Eliminacion de Productos"
    End Sub

    Private Sub btnSalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Salir de la aplicación"
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            MessageBox.Show("Ingrese la busqueda deseada ")
        Else
            'codigo para busqueda

        End If
    End Sub

    Private Sub btnIngresarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarProducto.Click
        frmIngresoProductos.ShowDialog(Me)
    End Sub

    Private Sub btnModificarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProducto.Click
        frmModificarProductos.ShowDialog(Me)
    End Sub

    Private Sub btnEliminarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProducto.Click
        frmDarDeBajaProductos.ShowDialog(Me)
    End Sub
End Class