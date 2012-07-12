Imports negocios

Public Class frmModuloProveedores
    Dim glstProveedores As IList(Of negociosProveedores)
    Public Shared gnpProveedor As negociosProveedores
    Private Sub btnNProveedor_Click(sender As System.Object, e As System.EventArgs) Handles btnNProveedor.Click
        ''frmNuevoProveedor.actualizar = False
        frmNuevoProveedor.ShowDialog()

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()

    End Sub

    Private Sub btnNProveedor_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnNProveedor.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnLProveedores_MouseLeave(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNProveedor_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnNProveedor.MouseHover
        slblDescripcion.Text = "Permite el ingreso de un nuevo proveedor"
    End Sub

    Private Sub btnLProveedores_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Lista los proveedores"
    End Sub

    Private Sub btnSalir_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Cierra el módulo de proveedores"
    End Sub

    Private Sub btnLProveedores_Click(sender As System.Object, e As System.EventArgs)
        frmListarProveedores.ShowDialog()
    End Sub

    Private Sub btnModificarProv_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnModificarProv.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminarProv_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnEliminarProv.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnModificarProv_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnModificarProv.MouseHover
        slblDescripcion.Text = "Modifica los datos del proveedor seleccionado"
    End Sub

    Private Sub btnEliminarProv_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnEliminarProv.MouseHover
        slblDescripcion.Text = "Elimina al proveedor seleccionado"
    End Sub

    Private Sub dgvListaProveedores_MouseLeave(sender As System.Object, e As System.EventArgs) Handles dgvListaProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaProveedores_MouseHover(sender As System.Object, e As System.EventArgs) Handles dgvListaProveedores.MouseHover
        slblDescripcion.Text = "Lista de los proveedores existentes"
    End Sub

    Private Sub frmModuloProveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'dgvListaProveedores.DataSource = negociosProveedores.fnsDTListarProveedores
        'dgvListaProveedores.Columns(0).Visible = False
        'dgvListaProveedores.Columns(8).Visible = False
        Try
            fnvdRecargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fnvCrearDataTable(ByRef lista As List(Of negociosProveedores))
        Dim ldtTabla As DataTable = New DataTable()
        Dim ldrFila As DataRow
        Dim lnpProveedor As negociosProveedores
        ldtTabla.Columns.Add("NIT")
        ldtTabla.Columns.Add("Empresa")
        ldtTabla.Columns.Add("Descripcion")
        ldtTabla.Columns.Add("Direccion")
        ldtTabla.Columns.Add("Propietario")
        ldtTabla.Columns.Add("Teléfono")
        ldtTabla.Columns.Add("Celular")
        ldtTabla.Columns.Add("Activo")

        For i = 0 To lista.Count - 1 Step 1
            ldrFila = ldtTabla.NewRow()
            lnpProveedor = lista(i)
            ldrFila(0) = lnpProveedor.getNit()
            ldrFila(1) = lnpProveedor.getEmpresa()
            ldrFila(2) = lnpProveedor.getNombre()
            ldrFila(3) = lnpProveedor.getDireccion()
            ldrFila(4) = lnpProveedor.getPropietario()
            ldrFila(5) = lnpProveedor.getTelefono()
            ldrFila(6) = lnpProveedor.getCelular()
            ldrFila(7) = lnpProveedor.getEstado()
            ldtTabla.Rows.Add(ldrFila)

        Next

        Me.dgvListaProveedores.DataSource = ldtTabla

    End Sub

    Private Sub fnvdRecargar()
        frmListarProveedores.gnpProveedor = Nothing
        Me.glstProveedores = negociosProveedores.fnslListarProveedores()
        Me.fnvCrearDataTable(Me.glstProveedores)

    End Sub

    Private Sub btnModificarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProv.Click
        If IsNothing(frmModuloProductos.gnpProductoSeleccionado) Then
            MessageBox.Show("Debe seleccionar un proveedor de la lista para poder modificar sus datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            frmNuevoProveedor.actualizar = True
            frmNuevoProveedor.Show(Me)

            Me.fnvdRecargar()
        End If

    End Sub

    Private Sub btnEliminarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProv.Click
        Dim lsMensaje As String
        If IsNothing(frmModuloProductos.gnpProductoSeleccionado) Then
            MessageBox.Show("Debe seleccionar un producto de la lista para poder eliminarlo", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If MessageBox.Show("Desea desactivar el registro seleccionado?", "Elminar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                If IsNothing(frmListarProveedores.gnpProveedor) Then
                    MessageBox.Show("Debe seleccionar un proveedor para poder eliminarlo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    If MessageBox.Show("¿Está seguro que desa desactivar al proveedor " + frmListarProveedores.gnpProveedor.getEmpresa() + " de la base de datos?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Try
                            lsMensaje = gnpProveedor.fnsDarDeBajaProveedor()
                            MessageBox.Show(lsMensaje, "Proveedor desactivado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                        Me.fnvdRecargar()
                    End If
                End If
                MessageBox.Show("Eliminar")
            End If
        End If

    End Sub
End Class