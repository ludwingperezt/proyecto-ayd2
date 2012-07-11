Imports negocios
Public Class frmModificarEmpleado

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim lnpNuevoEmpleado As negociosEmpleado = New negociosEmpleado()
        lnpNuevoEmpleado.setApellidoEmpleado(txtApellido.Text)
        lnpNuevoEmpleado.setNombreEmpleado(txtNombre.Text)
        lnpNuevoEmpleado.setDireccionEmpleado(txtDireccion.Text)
        lnpNuevoEmpleado.setTelefonoEmpleado(Convert.ToInt16(txtTelefono.Text))
        lnpNuevoEmpleado.setDpiCedula(txtDPI.Text)
        lnpNuevoEmpleado.setCelularEmpleado(Convert.ToInt16(txtCelular.Text))
        lnpNuevoEmpleado.setPuestoEmpleado(cmbPuesto.SelectedItem.ToString)
        lnpNuevoEmpleado.setSalarioEmpleado(Convert.ToDecimal(txtSueldo.Text))
        lnpNuevoEmpleado.setUsuarioEmpleado(txtUsuario.Text)
        Dim bytes() As Byte
        bytes = System.Text.Encoding.Unicode.GetBytes(txtPassword.Text)
        lnpNuevoEmpleado.setFechaContratacionEmpleado(Convert.ToDateTime(dtpFechaContrato.ToString))

        Try
            lnpNuevoEmpleado.fnsModificarEmpleado()
            MessageBox.Show("La operación de modificacion de empleado se llevó a cabo con éxito", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub cmbPuesto_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPuesto.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dtpFechaContrato_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaContrato.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtSueldo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSueldo.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtUsuario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtPassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.MouseLeave
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

    Private Sub cmbPuesto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPuesto.MouseHover
        slblDescripcion.Text = "Selecciones el Puesto del Empleado"
    End Sub

    Private Sub dtpFechaContrato_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaContrato.MouseHover
        slblDescripcion.Text = "Elegir Fecha de Contrato del Empleado."
    End Sub

    Private Sub txtSueldo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSueldo.MouseHover
        slblDescripcion.Text = "Sueldo del Empleado"
    End Sub

    Private Sub txtUsuario_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.MouseHover
        slblDescripcion.Text = "Usuario del Empleado"
    End Sub

    Private Sub txtPassword_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.MouseHover
        slblDescripcion.Text = "Contraseña de Ingreso al Sistema para el Empleado"
    End Sub
End Class