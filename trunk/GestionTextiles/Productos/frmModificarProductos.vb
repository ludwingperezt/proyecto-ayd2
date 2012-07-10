Public Class frmModificarProductos

    Private Sub frmModificarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBox.Show("La modificación de datos en esta parte del programa puede dañar la integridad de la base de datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Me.txtNombre.Text = frmModuloProductos.gnpProductoSeleccionado.getNombre()
        Me.txtCodigo.Text = frmModuloProductos.gnpProductoSeleccionado.getCodigo()
        Me.txtCantidad.Text = Convert.ToString(frmModuloProductos.gnpProductoSeleccionado.getStock())
        Me.txtPrecioCompra.Text = Convert.ToString(frmModuloProductos.gnpProductoSeleccionado.getPrecioCompra())
        Me.txtPrecioVenta.Text = Convert.ToString(frmModuloProductos.gnpProductoSeleccionado.getPrecioVenta())
        Me.txtColor.Text = Convert.ToString(frmModuloProductos.gnpProductoSeleccionado.getColor())
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        frmModuloProductos.gnpProductoSeleccionado.setNombre(txtNombre.Text)
        frmModuloProductos.gnpProductoSeleccionado.setCodigo(txtCodigo.Text)
        frmModuloProductos.gnpProductoSeleccionado.setStock(Convert.ToDouble(txtCantidad.Text))
        frmModuloProductos.gnpProductoSeleccionado.setPrecioCompra(Convert.ToDecimal(txtPrecioCompra.Text))
        frmModuloProductos.gnpProductoSeleccionado.setPrecioVenta(Convert.ToDecimal(txtPrecioVenta.Text))
        frmModuloProductos.gnpProductoSeleccionado.setColor(txtColor.Text)
        If MessageBox.Show("¿Está seguro de modificar los datos del producto?", "Precaución", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                frmModuloProductos.gnpProductoSeleccionado.fnvdModificarDescripcionProducto()
                MessageBox.Show("La operación de modificación finalizó con éxito", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmModuloProductos.gnpProductoSeleccionado = Nothing
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class