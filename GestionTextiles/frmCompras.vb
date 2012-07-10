Public Class frmCompras

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        frmModuloProductos.ShowDialog()
        ' ahora se procede a obtener el objeto estático que está en el frmModuloProductos...
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub txtnit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtnombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtdireccion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub TextBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub DataGridView1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDetalleFactura.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtTotal_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDescuento_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtnumero_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Número de la factura"
    End Sub

    Private Sub txtnit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNit.MouseHover
        slblDescripcion.Text = "Se debe ingresar el nit del cliente. Ej: 1269264-5"
    End Sub

    Private Sub txtnombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Nombre del cliente"
    End Sub

    Private Sub txtdireccion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseHover
        slblDescripcion.Text = "Dirección del cliente"
    End Sub

    Private Sub txtCodigo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Se debe ingresar el codigo de tela  Ej: 7486"
    End Sub

    Private Sub txtTela_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "tipo de tela "
    End Sub

    Private Sub txtCantidad_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Se debe ingresar la cantidad de yardas de tela  Ej. 5"
    End Sub

    Private Sub btnagregar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Ingreso de la tela selecciónada"
    End Sub

    Private Sub DataGridView1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDetalleFactura.MouseHover
        slblDescripcion.Text = "Descripcion de los productos a facturar"
    End Sub

    Private Sub txtTotal_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Total a pagar"
    End Sub

    Private Sub txtDescuento_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descuento total"
    End Sub

    Private Sub btnCancelar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cancelar facturación"
    End Sub

    Private Sub btnAceptar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Inicia impresión de factura"
    End Sub

    Private Sub lblnumerofac_MouseLeave(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lbltotal_MouseLeave(sender As System.Object, e As System.EventArgs) Handles lblTotal.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub lbltotal_MouseHover(sender As System.Object, e As System.EventArgs) Handles lblTotal.MouseHover
        slblDescripcion.Text = "Total a pagar"
    End Sub

    Private Sub lblnumerofac_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Numero de factura"
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
            '' Validación de combobox
            If TypeOf (ctrlIterador) Is Windows.Forms.ComboBox Then
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

        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "." Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If
        If e.KeyChar = "." Then
            If txtCantidad.Text.Contains(".") Then
                e.KeyChar = ""
            End If
        End If

    End Sub
    Private Sub txtnit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNit.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = " ")) Then
            e.KeyChar = vbNullChar

        End If
    End Sub
End Class