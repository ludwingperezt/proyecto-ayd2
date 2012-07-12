Public Class frmModificarDatosPropiosEmpleado

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        For Each ctrlIterador As Control In Me.Controls
            '' Validación de textbox
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White
                End If
            End If
        Next
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtCelular_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If
    End Sub

    Private Sub txtNombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtApellido_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApellido.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDireccion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDPI_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDPI.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtTelefono_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCelular_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Nombre del Empleado. Ej. Luis Armando"
    End Sub

    Private Sub txtApellido_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApellido.MouseHover
        slblDescripcion.Text = "Apellidos del Empleado. Ej. Perez Gonon"
    End Sub

    Private Sub txtDireccion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseHover
        slblDescripcion.Text = "Direccion del empleado."
    End Sub

    Private Sub txtDPI_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDPI.MouseHover
        slblDescripcion.Text = "Cedula o DPI del Empleado. Ej: A-1 1320096 ó 5678 31187 1234"
    End Sub

    Private Sub txtTelefono_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.MouseHover
        slblDescripcion.Text = "Numero de Telefono del Empleado."
    End Sub

    Private Sub txtCelular_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular.MouseHover
        slblDescripcion.Text = "Numero de Celular del Empleado."
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cancelar la Modificacion del Empleado"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Confirmar la Modificacion del Empleado"
    End Sub
End Class