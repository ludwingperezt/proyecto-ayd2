Imports negocios

Public Class frmListarProveedores
    Dim glstProveedores As IList(Of negociosProveedores)
    Public Shared gnpProveedor As negociosProveedores

    Private Sub ComboBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltro.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEditar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbFiltro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltro.MouseHover
        slblDescripcion.Text = "Permite elegir un filtro de búsqueda"
    End Sub

    Private Sub txtCriterio_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.MouseHover
        slblDescripcion.Text = "Es el texto a buscar, según el criterio de busqueda"
    End Sub

    Private Sub btnEditar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.MouseHover
        slblDescripcion.Text = "Edita el proveedor seleccionado"
    End Sub

    Private Sub dgvListaProveedores_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListaProveedores.CellClick
        gnpProveedor = glstProveedores(e.RowIndex)
    End Sub

    Private Sub dgvListaProveedores_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListaProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaProveedores_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListaProveedores.MouseHover
        slblDescripcion.Text = "Listado de proveedores disponibles"
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If IsNothing(frmModuloProductos.gnpProductoSeleccionado) Then
            MessageBox.Show("Debe seleccionar un proveedor de la lista para poder modificar sus datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            frmNuevoProveedor.actualizar = True
            frmNuevoProveedor.Show(Me)
            Me.fnvdRecargar()
        End If

        frmNuevoProveedor.ShowDialog()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim lsMensaje As String
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
    End Sub

    Private Sub btnEliminar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseHover
        slblDescripcion.Text = "Elimina el Proveedor seleccionado de la lista"
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
            ldtTabla.Rows.Add(ldrFila)

        Next

        Me.dgvListaProveedores.DataSource = ldtTabla

    End Sub

    Private Sub fnvdRecargar()
        frmListarProveedores.gnpProveedor = Nothing
        Me.glstProveedores = negociosProveedores.fnslListarProveedores()
        Me.fnvCrearDataTable(Me.glstProveedores)

    End Sub

    Private Sub frmListarProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            fnvdRecargar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class