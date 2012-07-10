Imports negocios

Public Class frmModuloProveedores

    Private Sub btnNProveedor_Click(sender As System.Object, e As System.EventArgs) Handles btnNProveedor.Click
        ''frmNuevoProveedor.actualizar = False
        frmNuevoProveedor.ShowDialog()

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()

    End Sub

    Private Sub btnNProveedor_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnNProveedor.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnLProveedores_MouseLeave(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNProveedor_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnNProveedor.MouseHover
        slblDescripcion.Text = "Permite el ingreso de un nuevo proveedor"
    End Sub

    Private Sub btnLProveedores_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Lista los proveedores"
    End Sub

    Private Sub btnSalir_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Cierra el módulo de proveedores"
    End Sub

    Private Sub btnLProveedores_Click(sender As System.Object, e As System.EventArgs)
        frmListarProveedores.ShowDialog()
    End Sub

    Private Sub btnModificarProv_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnModificarProv.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminarProv_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnEliminarProv.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnModificarProv_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnModificarProv.MouseHover
        slblDescripcion.Text = "Modifica los datos del proveedor seleccionado"
    End Sub

    Private Sub btnEliminarProv_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnEliminarProv.MouseHover
        slblDescripcion.Text = "Elimina al proveedor seleccionado"
    End Sub

    Private Sub dgvListaProveedores_MouseLeave(sender As System.Object, e As System.EventArgs) Handles dgvListaProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaProveedores_MouseHover(sender As System.Object, e As System.EventArgs) Handles dgvListaProveedores.MouseHover
        slblDescripcion.Text = "Lista de los proveedores existentes"
    End Sub

    Private Sub frmModuloProveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvListaProveedores.DataSource = negociosProveedores.fnsListarProveedores
        dgvListaProveedores.Columns(0).Visible = False
        dgvListaProveedores.Columns(8).Visible = False
    End Sub
End Class