Public Class frmCompras

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        frmModuloProductos.btnSalir.Visible = False

        frmModuloProductos.ShowDialog()
        frmModuloProductos.Dispose()
        ' ahora se procede a obtener el objeto estático que está en el frmModuloProductos...
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        For Each ctrlIterador As Control In Me.Controls
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White
                End If
            End If
        Next
    End Sub

    Private Sub txtCodigo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar

        End If

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtTela_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not (e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then  'revisar si lleva numeros en los nombres de las telas
            e.KeyChar = vbNullChar

        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If

    End Sub
    Private Sub txtnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNit.KeyPress
        If txtNit.Text.Trim.ToLower.StartsWith("c") Then
            txtNombre.Enabled = True
            txtDireccion.Enabled = True
        Else
            txtNombre.Enabled = False
            txtDireccion.Enabled = False
        End If
    End Sub

    Private Sub txtSerie_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtSerie.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCorrelativo_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtCorrelativo.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub DateTimePicker1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lblEmpleado_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblEmpleado.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNit_Leave(sender As System.Object, e As System.EventArgs) Handles txtNit.Leave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDireccion_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtDireccion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtTela_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtTela.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCantidad_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtCantidad.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnBuscar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnBuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnagregar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnagregar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvDetalleFactura_MouseLeave(sender As System.Object, e As System.EventArgs) Handles dgvDetalleFactura.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtSerie_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtSerie.MouseHover
        slblDescripcion.Text = "Ingrese el número de serie, no más de 4 caracteres"
    End Sub

    Private Sub DateTimePicker1_MouseHover(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.MouseHover
        slblDescripcion.Text = "Seleccione la fecha de la factura"
    End Sub

    Private Sub lblEmpleado_MouseHover(sender As System.Object, e As System.EventArgs) Handles lblEmpleado.MouseHover
        slblDescripcion.Text = "Se muestra el nombre del empleado logueado"
    End Sub

    Private Sub txtNit_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtNit.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNit_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtNit.MouseHover
        slblDescripcion.Text = "Ingrese el nit, sin guión"
    End Sub

    Private Sub txtNombre_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Nombre del proveedor"
    End Sub

    Private Sub txtDireccion_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtDireccion.MouseHover
        slblDescripcion.Text = "Dirección del proveedor"
    End Sub

    Private Sub txtTela_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtTela.MouseHover
        slblDescripcion.Text = "Producto comprado"
    End Sub

    Private Sub txtCantidad_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtCantidad.MouseHover
        slblDescripcion.Text = "Cantidad de tela"
    End Sub

    Private Sub btnagregar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnagregar.MouseHover
        slblDescripcion.Text = "Agregar el producto al detalle de compra"
    End Sub

    Private Sub dgvDetalleFactura_MouseHover(sender As System.Object, e As System.EventArgs) Handles dgvDetalleFactura.MouseHover
        slblDescripcion.Text = "Detalle de compras"
    End Sub

    Private Sub lblTotal_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblTotal.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lblTotal_MouseHover(sender As System.Object, e As System.EventArgs) Handles lblTotal.MouseHover
        slblDescripcion.Text = "El total de la factura de compra"
    End Sub

    Private Sub btnCancelar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cierra la ventana si guardar"
    End Sub

    Private Sub btnAceptar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Cierra la ventana y guarda la factura"
    End Sub
End Class