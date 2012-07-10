Imports negocios

Public Class frmNuevoProveedor
    Friend Shared actualizar As Boolean
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim lbooBandera As Boolean = True
        Dim lsMensaje As String
        Dim lnpProveedorNuevo As negociosProveedores

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

        If lbooBandera Then
            If actualizar Then
                '' si es un update...
                frmListarProveedores.gnpProveedor.setNit(Me.txtNIT.Text)
                frmListarProveedores.gnpProveedor.setDireccion(Me.txtDireccion.Text)
                frmListarProveedores.gnpProveedor.setEmpresa(Me.txtEmpresa.Text)
                frmListarProveedores.gnpProveedor.setNombre(Me.txtNombre.Text)
                frmListarProveedores.gnpProveedor.setPropietario(Me.txtPropietario.Text)
                frmListarProveedores.gnpProveedor.setTelefono(Me.txtTelefono.Text)
                frmListarProveedores.gnpProveedor.setCelular(Me.txtCelular.Text)

                If MessageBox.Show("¿Está seguro de modificar los datos de este proveedor?", "Precaución", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Try
                        lsMensaje = frmListarProveedores.gnpProveedor.fnsModificarProveedor()
                        MessageBox.Show(lsMensaje, "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Else
                '' si es un insert...
                lnpProveedorNuevo = New negociosProveedores(Me.txtNombre.Text, Me.txtNIT.Text, Me.txtDireccion.Text, Me.txtEmpresa.Text, Me.txtPropietario.Text, Me.txtTelefono.Text, Me.txtCelular.Text)
                Try

                    lsMensaje = lnpProveedorNuevo.fnsInsertarProveedor()
                    MessageBox.Show(lsMensaje, "Insersión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
            ' todo es válido se procede a guardar en la BD y luego a cerrar el form!
            Me.Dispose()
        End If
    End Sub

    Private Sub txtNIT_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNIT.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNombre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtDireccion_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtEmpresa_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmpresa.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtPropietario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPropietario.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtTelefono_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCelular_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtNIT_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNIT.MouseHover
        slblDescripcion.Text = "Ingrese el NIT del proveedor, sin guiones"
    End Sub

    Private Sub txtNombre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.MouseHover
        slblDescripcion.Text = "Ingrese el nombre"
    End Sub

    Private Sub txtDireccion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDireccion.MouseHover
        slblDescripcion.Text = "Ingrese la dirección del proveedor"
    End Sub

    Private Sub txtPropietario_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPropietario.MouseHover
        slblDescripcion.Text = "Ingrese el nombre del propietario o contacto de la empresa proveedora"
    End Sub

    Private Sub txtTelefono_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.MouseHover
        slblDescripcion.Text = "Si tiene telefono, ingrese el número, sin guiones ni letras"
    End Sub

    Private Sub txtCelular_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCelular.MouseHover
        slblDescripcion.Text = "Si tiene celular, ingrese el número, sin guiones ni letras"
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        slblDescripcion.Text = "Cierra y no guarda cambios"
    End Sub

    Private Sub btnAceptar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseHover
        slblDescripcion.Text = "Cierra y guarda el proveedor"
    End Sub

    Private Sub btnAceptar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub frmNuevoProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If actualizar = True Then
            Me.txtNIT.Text = frmListarProveedores.gnpProveedor.getNit()
            Me.txtDireccion.Text = frmListarProveedores.gnpProveedor.getDireccion()
            Me.txtEmpresa.Text = frmListarProveedores.gnpProveedor.getEmpresa()
            Me.txtNombre.Text = frmListarProveedores.gnpProveedor.getNombre()
            Me.txtPropietario.Text = frmListarProveedores.gnpProveedor.getPropietario()
            Me.txtTelefono.Text = frmListarProveedores.gnpProveedor.getTelefono()
            Me.txtCelular.Text = frmListarProveedores.gnpProveedor.getCelular()


        End If
    End Sub
End Class