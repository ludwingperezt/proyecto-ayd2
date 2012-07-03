Public Class frmListarProveedores

    Private Sub ComboBox1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub TextBox1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEditar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnEditar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbFiltro_MouseHover(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.MouseHover
        slblDescripcion.Text = "Permite elegir un filtro de búsqueda"
    End Sub

    Private Sub txtCriterio_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseHover
        slblDescripcion.Text = "Es el texto a buscar, según el criterio de busqueda"
    End Sub

    Private Sub btnEditar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnEditar.MouseHover
        slblDescripcion.Text = "Edita el proveedor seleccionado"
    End Sub

    Private Sub dgvListaProveedores_MouseLeave(sender As System.Object, e As System.EventArgs) Handles dgvListaProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaProveedores_MouseHover(sender As System.Object, e As System.EventArgs) Handles dgvListaProveedores.MouseHover
        slblDescripcion.Text = "Listado de proveedores disponibles"
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        frmNuevoProveedor.ShowDialog()

    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Desea elminar el registro seleccionado?", "Elminar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ' PROCEDIMIENTO DE DESHABILITAR PROVEEDOR
            MessageBox.Show("Eliminar")
        End If
    End Sub

    Private Sub btnEliminar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnEliminar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnEliminar.MouseHover
        slblDescripcion.Text = "Elimina el Proveedor seleccionado de la lista"
    End Sub
End Class