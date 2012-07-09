Public Class frmNuevoProveedor

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Dim lbooBandera As Boolean = True

        For Each ctrlIterador As Control In Me.Controls
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If ctrlIterador.Name <> "txtTelefono" And ctrlIterador.Name <> "txtCelular" Then
                    If (ctrlIterador.Text = "") Then
                        ctrlIterador.BackColor = Color.Yellow
                        lbooBandera = False
                    Else
                        ctrlIterador.BackColor = Color.White
                    End If
                End If
            End If
        Next
        ''Proveedores a = New Proveedores();

        If lbooBandera Then
            ' todo es válido se procede a guardar en la BD y luego a cerrar el form!
            Me.Dispose()
        End If
    End Sub

    Private Sub txtNIT_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtNIT.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDireccion_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtDireccion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtEmpresa_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtEmpresa.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtPropietario_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtPropietario.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtTelefono_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtTelefono.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCelular_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtCelular.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNIT_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtNIT.MouseHover
        slblDescripcion.Text = "Ingrese el NIT del proveedor, sin guiones"
    End Sub

    Private Sub txtNombre_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Ingrese el nombre"
    End Sub

    Private Sub txtDireccion_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtDireccion.MouseHover
        slblDescripcion.Text = "Ingrese la dirección del proveedor"
    End Sub

    Private Sub txtPropietario_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtPropietario.MouseHover
        slblDescripcion.Text = "Ingrese el nombre del propietario o contacto de la empresa proveedora"
    End Sub

    Private Sub txtTelefono_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtTelefono.MouseHover
        slblDescripcion.Text = "Si tiene telefono, ingrese el número, sin guiones ni letras"
    End Sub

    Private Sub txtCelular_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtCelular.MouseHover
        slblDescripcion.Text = "Si tiene celular, ingrese el número, sin guiones ni letras"
    End Sub

    Private Sub btnCancelar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cierra y no guarda cambios"
    End Sub

    Private Sub btnAceptar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Cierra y guarda el proveedor"
    End Sub

    Private Sub btnAceptar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class