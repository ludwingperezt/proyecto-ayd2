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

        For Each ctrlIterador As Control In Me.Controls
            '' Validación de textbox
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White

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

                End If
            End If
        Next
    End Sub

    Private Sub txtPrecioCompra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCompra.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = ".")) Then
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtPrecioVenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioVenta.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = ".")) Then
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtNombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCodigo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCantidad_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtPrecioCompra_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioCompra.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtPrecioVenta_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioVenta.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtColor_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColor.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Nombre del Producto."
    End Sub

    Private Sub txtCodigo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.MouseHover
        slblDescripcion.Text = "Codigo del Producto."
    End Sub

    Private Sub txtCantidad_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.MouseHover
        slblDescripcion.Text = "Cantidad Existente del Producto."
    End Sub

    Private Sub txtPrecioCompra_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioCompra.MouseHover
        slblDescripcion.Text = "Precio de Compra del Producto."
    End Sub

    Private Sub txtPrecioVenta_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecioVenta.MouseHover
        slblDescripcion.Text = "Precio de Venta del Producto."
    End Sub

    Private Sub txtColor_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtColor.MouseHover
        slblDescripcion.Text = "Color del Producto."
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Confirmar Cambios del Producto."
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cancelar Cambios del Producto."
    End Sub
End Class