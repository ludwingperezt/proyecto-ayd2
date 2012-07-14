Imports negocios
Public Class frmIngresoProductos
    Dim lbooBanderaPunto As Boolean = False
    Dim lbooBanderaPunto2 As Boolean = False
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim lbooBandera As Boolean = True

        For Each ctrlIterador As Control In Me.Controls
            '' Validación de textbox
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                    lbooBandera = False
                Else
                    ctrlIterador.BackColor = Color.White
                End If
            End If
        Next

        If lbooBandera Then
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
        End If

    End Sub

    Private Sub frmIngresoProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtPrecioCompra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCompra.KeyPress
        If txtPrecioCompra.Text.Contains(".") Then
            lbooBanderaPunto = True
        Else
            lbooBanderaPunto = False
        End If

        If lbooBanderaPunto = True Then
            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
                e.KeyChar = vbNullChar
            End If
        Else
            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = ".")) Then
                e.KeyChar = vbNullChar
            End If
        End If
    End Sub

    Private Sub txtPrecioVenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioVenta.KeyPress
        If txtPrecioCompra.Text.Contains(".") Then
            lbooBanderaPunto2 = True
        Else
            lbooBanderaPunto2 = False
        End If

        If lbooBanderaPunto2 = True Then
            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
                e.KeyChar = vbNullChar
            End If
        Else
            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = ".")) Then
                e.KeyChar = vbNullChar
            End If
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

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
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

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cancelar Cambios del Producto."
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Confirmar Cambios del Producto."
    End Sub
End Class