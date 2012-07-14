Imports negocios
Public Class frmModificarEmpleado
    Dim lbooBanderaPunto As Boolean = False
    Friend Shared actualizar As Boolean
    Private glstRolFiltrada As List(Of negociosRol) = New List(Of negociosRol)
    Public Shared gnpRolSeleccionado As negociosRol
    Private glstRol As List(Of negociosRol) = New List(Of negociosRol)
    Private banderaBusqueda As Boolean = False
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim lbooBandera As Boolean = True

        For Each ctrlIterador As Control In Me.Controls
            '' Validación de textbox
            If TypeOf (ctrlIterador) Is Windows.Forms.TextBox Then
                If (ctrlIterador.Text = "") Then
                    ctrlIterador.BackColor = Color.Yellow
                    lbooBandera = False
                Else
                    ctrlIterador.BackColor = Color.White
                End If
            End If
        Next
        If lbooBandera Then
            Dim lnpNuevoEmpleado As negociosEmpleado = New negociosEmpleado()
            lnpNuevoEmpleado.setApellidoEmpleado(txtApellido.Text)
            lnpNuevoEmpleado.setNombreEmpleado(txtNombre.Text)
            lnpNuevoEmpleado.setDireccionEmpleado(txtDireccion.Text)
            lnpNuevoEmpleado.setTelefonoEmpleado(Convert.ToString(txtTelefono.Text))
            lnpNuevoEmpleado.setDpiCedula(txtDPI.Text)
            lnpNuevoEmpleado.setCelularEmpleado(Convert.ToString(txtCelular.Text))
            lnpNuevoEmpleado.setPuestoEmpleado(txtPuesto.Text)
            lnpNuevoEmpleado.setSalarioEmpleado(Convert.ToDecimal(txtSueldo.Text))
            lnpNuevoEmpleado.setUsuarioEmpleado(txtUsuario.Text)
            lnpNuevoEmpleado.setFechaContratacionEmpleado(dtpFechaContrato.Value)
            lnpNuevoEmpleado.setHabilitadoEmpleado(1)
            lnpNuevoEmpleado.setPasswordEmpleado(frmModuloEmpleados.gnpEmpleadoSeleccionado.getPasswordEmpleado())
            lnpNuevoEmpleado.setIdRolEmpleado(Convert.ToByte(cmbRolEmpleado.SelectedValue))
            lnpNuevoEmpleado.setIdEmpleado(frmModuloEmpleados.gnpEmpleadoSeleccionado.getIdEmpleado())
            Try
                lnpNuevoEmpleado.fnsModificarEmpleado()
                MessageBox.Show("La operación de modificacion de empleado se llevó a cabo con éxito", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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

    Private Sub cmbPuesto_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub txtPassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub cmbPuesto_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub txtPassword_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Contraseña de Ingreso al Sistema para el Empleado"
    End Sub

    Private Sub frmModificarEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.glstRol = negociosRol.fnlstListarRoles()
        Me.fnvdRecargar()
        If actualizar = True Then
            Me.txtNombre.Text = frmModuloEmpleados.gnpEmpleadoSeleccionado.getNombreEmpleado()
            Me.txtApellido.Text = frmModuloEmpleados.gnpEmpleadoSeleccionado.getApellidoEmpleado()
            Me.txtDireccion.Text = frmModuloEmpleados.gnpEmpleadoSeleccionado.getDireccionEmpleado()
            Me.txtDPI.Text = frmModuloEmpleados.gnpEmpleadoSeleccionado.getDpiCedula()
            Me.txtTelefono.Text = frmModuloEmpleados.gnpEmpleadoSeleccionado.getTelefonoEmpleado()
            Me.txtCelular.Text = frmModuloEmpleados.gnpEmpleadoSeleccionado.getCelularEmpleado()
            Me.txtPuesto.Text = frmModuloEmpleados.gnpEmpleadoSeleccionado.getPuestoEmpleado()
            Me.txtSueldo.Text = frmModuloEmpleados.gnpEmpleadoSeleccionado.getSalarioEmpleado()
            Me.txtUsuario.Text = frmModuloEmpleados.gnpEmpleadoSeleccionado.getUsuarioEmpleado()
        End If
    End Sub
    Private Sub fnvdRecargar()
        Try
            frmEmpleados.gnpRolSeleccionado = Nothing
            Me.glstRolFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstRol = negociosRol.fnlstListarRoles()
            Me.fnvCrearDataTable(Me.glstRol)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub fnvCrearDataTable(ByRef lista As List(Of negociosRol))
        Dim ldtTabla As DataTable = New DataTable()
        Dim ldrFila As DataRow
        Dim lnpRol As negociosRol
        ldtTabla.Columns.Add("IdRol")
        ldtTabla.Columns.Add("Nombre")

        For i = 0 To lista.Count - 1 Step 1
            ldrFila = ldtTabla.NewRow()
            lnpRol = lista(i)
            ldrFila(0) = lnpRol.getIdRol()
            ldrFila(1) = lnpRol.getNombre()
            ldtTabla.Rows.Add(ldrFila)
        Next
        cmbRolEmpleado.DataSource = ldtTabla
        cmbRolEmpleado.DisplayMember = "Nombre"
        cmbRolEmpleado.ValueMember = "IdRol"
    End Sub
    Private Sub cmbRolEmpleado_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRolEmpleado.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbRolEmpleado_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRolEmpleado.MouseHover
        slblDescripcion.Text = "Seleccione un Rol para el Empleado."
    End Sub

    Private Sub btnComprobar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnComprobar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComprobar.MouseHover
        slblDescripcion.Text = "Comprobar si el Usuario ya Existe."
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cancelar la Modificacion del Empleado"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Confirmar la Modificacion del Empleado"
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

    Private Sub txtSueldo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSueldo.KeyPress

        If txtSueldo.Text.Contains(".") Then
            lbooBanderaPunto = True
        Else
            lbooBanderaPunto = False
        End If

        If lbooBanderaPunto = True Then
            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
                e.KeyChar = vbNullChar
            End If
        Else
            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = ".")) Then
                e.KeyChar = vbNullChar
            End If
        End If
        
    End Sub
End Class