Public Class frmNuevoProveedor

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
End Class