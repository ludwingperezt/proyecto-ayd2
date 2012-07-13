Imports negocios
Public Class frmLogin
    Public Shared lnpNuevoUsuario As negociosEmpleado = New negociosEmpleado()
    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Salir de la ventana del  ingreso al sistema"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Ingresar al sistema "
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        For Each ctrlIterador As Control In Me.Controls
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White
                    ''buscar al usuario
                    dgvUsuario.DataSource = lnpNuevoUsuario.fnDbBuscarEmpleadoNombre(txtUsuario.Text)
                    Dim cantRegistros As Integer = dgvUsuario.Rows.Count
                    txtcontraseña.Text = Convert.ToString(cantRegistros)
                End If
            End If
        Next
    End Sub

    Private Sub txtUsuario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtcontraseña_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontraseña.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtUsuario_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.MouseHover
        slblDescripcion.Text = "Ingreso del nombre de usuario para tener acceso al sistema"
    End Sub

    Private Sub txtcontraseña_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontraseña.MouseHover
        slblDescripcion.Text = "Ingreso de la contraseña del usuario"
    End Sub
End Class