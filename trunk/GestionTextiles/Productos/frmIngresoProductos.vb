Imports negocios
Public Class frmIngresoProductos
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        For Each ctrlIterador As Control In Me.Controls
            '' Validación de textbox
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White

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
            End If
        Next
    End Sub

    Private Sub frmIngresoProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtPrecioCompra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioCompra.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.Handled = ".")) Then
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtPrecioVenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecioVenta.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.Handled = ".")) Then
            e.KeyChar = vbNullChar
        End If
    End Sub
End Class