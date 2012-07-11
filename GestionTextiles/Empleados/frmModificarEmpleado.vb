Imports negocios
Public Class frmModificarEmpleado

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim lnpNuevoEmpleado As negociosEmpleado = New negociosEmpleado()
        ''hay que setear el id del empleado
        ''falta el textbox de apellido del empleado
        ''lnpNuevoEmpleado.setApellidoEmpleado(txtApellido.Text)
        lnpNuevoEmpleado.setNombreEmpleado(txtNombre.Text)
        lnpNuevoEmpleado.setDireccionEmpleado(txtDireccion.Text)
        lnpNuevoEmpleado.setTelefonoCliente(Convert.ToInt16(txtTelefono.Text))
        ''hay que quitar del formulario el textbox que se llamda cedula/dpi
        lnpNuevoEmpleado.setCelularEmpleado(Convert.ToInt16(txtCelular.Text))
        ''falta el textbox del puesto
        ''lnpNuevoEmpleado.setPuestoEmpleado(cmbPuesto.SelectedItem.ToString)
        lnpNuevoEmpleado.setSalarioEmpleado(Convert.ToDecimal(txtSueldo.Text))
        ''se va a modificar usuario????
        ''lnpNuevoEmpleado.setUsuarioEmpleado(txtUsuario.Text)
        ''falta setear la fecha de contratacion lnpNuevoEmpleado.setFechaContratacionEmpleado(dtpFechaContrato.

    End Sub
End Class