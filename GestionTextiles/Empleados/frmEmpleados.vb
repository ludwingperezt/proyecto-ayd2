Imports negocios
Public Class frmEmpleados

    Private Sub slblDescripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slblDescripcion.Click

    End Sub

    Private Sub txtNombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Nombre completo del Empleado."
    End Sub

    Private Sub txtDPI_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDPI.MouseHover
        slblDescripcion.Text = "Cedula o DPI del Empleado. Ej: A-1 1320096 ó 5678 31187 1234"
    End Sub

    Private Sub txtDireccion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseHover
        slblDescripcion.Text = "Direccion del empleado."
    End Sub

    Private Sub txtTelefono_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.MouseHover
        slblDescripcion.Text = "Numero de Telefono del Empleado."
    End Sub

    Private Sub txtCelular_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular.MouseHover
        slblDescripcion.Text = "Numero de Celular del Empleado."
    End Sub

    Private Sub txtSueldo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSueldo.MouseHover
        slblDescripcion.Text = "Sueldo del Empleado"
    End Sub

    Private Sub dtpFechaContrato_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaContrato.MouseHover
        slblDescripcion.Text = "Elegir Fecha de Contrato del Empleado."
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cancelar Ingreso del Empleado"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Confirmar Ingreso del Empleado"
    End Sub

    Private Sub txtNombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDPI_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDPI.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDireccion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtTelefono_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCelular_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dtpFechaContrato_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaContrato.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtSueldo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSueldo.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        For Each ctrlIterador As Control In Me.Controls
            '' Validación de textbox
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                Else
                    ctrlIterador.BackColor = Color.White
                    ''ingreso de empleado nuevo
                    ''hay que setear el id del empleado
                    Dim lnpNuevoEmpleado As negociosEmpleado = New negociosEmpleado()
                    lnpNuevoEmpleado.setApellidoEmpleado(txtApellido.Text)
                    lnpNuevoEmpleado.setNombreEmpleado(txtNombre.Text)
                    lnpNuevoEmpleado.setDireccionEmpleado(txtDireccion.Text)
                    lnpNuevoEmpleado.setTelefonoCliente(Convert.ToInt16(txtTelefono.Text))
                    ''hay que quitar del formulario el textbox que se llamda cedula/dpi
                    lnpNuevoEmpleado.setCelularEmpleado(Convert.ToInt16(txtCelular.Text))
                    lnpNuevoEmpleado.setPuestoEmpleado(cmbPuesto.SelectedItem.ToString)
                    lnpNuevoEmpleado.setSalarioEmpleado(Convert.ToDecimal(txtSueldo.Text))
                    lnpNuevoEmpleado.setUsuarioEmpleado(txtUsuario.Text)
                    ''falta setear la fecha de contratacion lnpNuevoEmpleado.setFechaContratacionEmpleado(dtpFechaContrato.
                    Try
                        lnpNuevoEmpleado.fnsInsertarEmpleado()
                        MessageBox.Show("La operación de insersión de empleado se llevó a cabo con éxito", "Insersión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
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

    Private Sub cmbPuesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPuesto.SelectedIndexChanged

    End Sub

    Private Sub dtpFechaContrato_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaContrato.ValueChanged

    End Sub
End Class