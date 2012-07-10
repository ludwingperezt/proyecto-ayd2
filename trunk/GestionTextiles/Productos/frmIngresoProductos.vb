Imports negocios
Public Class frmIngresoProductos
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim lnpNuevoProducto As negociosProducto = New negociosProducto()
        lnpNuevoProducto.setNombre(txtNombre.Text)
        lnpNuevoProducto.setCodigo(txtCodigo.Text)
        lnpNuevoProducto.setStock(Convert.ToDouble(txtCantidad.Text))
        lnpNuevoProducto.setPrecioCompra(Convert.ToDecimal(txtPrecioCompra.Text))
        lnpNuevoProducto.setPrecioVenta(Convert.ToDecimal(txtPrecioVenta.Text))
        lnpNuevoProducto.setColor(txtColor.Text)
        Try
            lnpNuevoProducto.fnvdInsertarDescripcionProducto()
            MessageBox.Show("La operación de insersión del producto se llevó a cabo con éxito", "Insersión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmIngresoProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class