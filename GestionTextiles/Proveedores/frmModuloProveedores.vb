﻿Imports negocios

Public Class frmModuloProveedores
    Public Shared lstnpProveedores As IList(Of negociosProveedores)
    Public Shared lstnpProveedoresFiltrado As IList(Of negociosProveedores) = New List(Of negociosProveedores)
    Public Shared gnpProveedor As negociosProveedores
    Dim bBusquenda As Boolean = False
    Dim iNumeroPagina As Integer = 1

    Private Sub btnNProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNProveedor.Click
        frmNuevoProveedor.actualizar = False
        frmNuevoProveedor.ShowDialog()
        Me.fnvdRecargar()
        txtBusqueda.Text = ""
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()

    End Sub

    Private Sub btnNProveedor_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNProveedor.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnLProveedores_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNProveedor_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNProveedor.MouseHover
        slblDescripcion.Text = "Permite el ingreso de un nuevo proveedor"
    End Sub

    Private Sub btnLProveedores_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Lista los proveedores"
    End Sub

    Private Sub btnSalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Cierra el módulo de proveedores"
    End Sub

    Private Sub btnLProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmModuloProveedores.ShowDialog()
    End Sub

    Private Sub btnModificarProv_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProv.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminarProv_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProv.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnModificarProv_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProv.MouseHover
        slblDescripcion.Text = "Modifica los datos del proveedor seleccionado"
    End Sub

    Private Sub btnEliminarProv_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProv.MouseHover
        slblDescripcion.Text = "Elimina al proveedor seleccionado"
    End Sub

    Private Sub dgvListaProveedores_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListaProveedores.CellClick
        Try
            If bBusquenda Then
                frmModuloProveedores.gnpProveedor = lstnpProveedoresFiltrado(e.RowIndex)
            Else
                frmModuloProveedores.gnpProveedor = lstnpProveedores(e.RowIndex)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub dgvListaProveedores_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListaProveedores.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaProveedores_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvListaProveedores.MouseHover
        slblDescripcion.Text = "Lista de los proveedores existentes"
    End Sub

    Private Sub frmModuloProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establecer permisos del modulo de series
        Dim lnegPermisos As negociosRol = frmPrincipal.gnegPermisos

        If lnegPermisos.getPermisoCreacionProveedores() Then
            btnNProveedor.Enabled = True
        Else
            btnNProveedor.Enabled = False
        End If

        If lnegPermisos.getPermisoEliminacionProveedores() Then
            btnEliminarProv.Enabled = True
        Else
            btnEliminarProv.Enabled = False
        End If

        If lnegPermisos.getPermisoModificacionProveedores() Then
            btnModificarProv.Enabled = True
        Else
            btnModificarProv.Enabled = False
        End If

        If lnegPermisos.getPermisoListarProveedores() Then
            txtBusqueda.Enabled = True
            btnbuscar.Enabled = True
            dgvListaProveedores.Enabled = True
            Try
                fnvdRecargar()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            txtBusqueda.Enabled = False
            btnbuscar.Enabled = False
            dgvListaProveedores.Enabled = False
        End If

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
        ldtTabla.Columns.Add("Estado")

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
        Try
            frmModuloProveedores.gnpProveedor = Nothing
            frmModuloProveedores.lstnpProveedoresFiltrado.Clear()
            bBusquenda = False
            frmModuloProveedores.lstnpProveedores = negociosProveedores.fnslPaginacionProveedores(20, iNumeroPagina)
            Me.fnvCrearDataTable(frmModuloProveedores.lstnpProveedores)
            If frmModuloProveedores.lstnpProveedores.Count < 20 Then
                btnSiguiente.Enabled = False
            Else
                btnSiguiente.Enabled = True
            End If

            If Me.iNumeroPagina = 1 Then
                btnAnterior.Enabled = False
            Else
                btnAnterior.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvListaProveedores.DataSource = Nothing

        End Try


    End Sub

    Private Sub btnModificarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarProv.Click
        If IsNothing(frmModuloProveedores.gnpProveedor) Then
            MessageBox.Show("Debe seleccionar un proveedor de la lista para poder modificar sus datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            frmNuevoProveedor.actualizar = True
            frmNuevoProveedor.ShowDialog(Me)
            Me.fnvdRecargar()
            txtBusqueda.Text = ""
        End If

    End Sub

    Private Sub btnEliminarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProv.Click
        Dim lsMensaje As String
        If IsNothing(frmModuloProveedores.gnpProveedor) Then
            MessageBox.Show("Debe seleccionar a un proveedor de la lista para poder eliminarlo", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If MessageBox.Show("¿Está seguro que desa desactivar al proveedor: " + frmModuloProveedores.gnpProveedor.getEmpresa() + ", de la base de datos?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    lsMensaje = gnpProveedor.fnsDarDeBajaProveedor()
                    MessageBox.Show(lsMensaje, "Proveedor desactivado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmModuloProveedores.lstnpProveedores = negociosProveedores.fnslListarProveedores()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                txtBusqueda.Text = ""
            End If
        End If
        Me.fnvdRecargar()
    End Sub


    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtBusqueda.Text = "" Then
            Me.fnvdRecargar()
        Else
            bBusquenda = True
            Me.fnsFiltarListaProveedores(txtBusqueda.Text)
            'Me.fnvdRecargar()
        End If
    End Sub

    Private Sub fnsFiltarListaProveedores(ByVal sTextoBuscado As String)
        lstnpProveedoresFiltrado = New List(Of negociosProveedores)
        sTextoBuscado = sTextoBuscado.Trim()
        Try
            If cmbFiltro.SelectedItem = "" Then
                For Each i As negociosProveedores In frmModuloProveedores.lstnpProveedores
                    If i.getNombre().Trim().Contains(sTextoBuscado) Or i.getPropietario().Trim().Contains(sTextoBuscado) Or i.getDireccion().Trim().Contains(sTextoBuscado) Or i.getNit().Trim().Contains(sTextoBuscado) Or i.getEmpresa().Trim().Contains(sTextoBuscado) Or i.getTelefono().Trim().Contains(sTextoBuscado) Or i.getCelular().Trim().Contains(sTextoBuscado) Then
                        lstnpProveedoresFiltrado.Add(i)
                    End If
                Next
            End If

            If cmbFiltro.SelectedItem = "Propietario" Then
                lstnpProveedoresFiltrado = negociosProveedores.fnslBuscarProveedorPorPropietario(sTextoBuscado)
            End If

            If cmbFiltro.SelectedItem = "Empresa" Then
                lstnpProveedoresFiltrado = negociosProveedores.fnslBuscarProveedorPorEmpresa(sTextoBuscado)
            End If

            If cmbFiltro.SelectedItem = "NIT" Then
                lstnpProveedoresFiltrado = negociosProveedores.fnslBuscarProveedorPorNit(sTextoBuscado)
            End If

            If cmbFiltro.SelectedItem = "Estado" Then
                If sTextoBuscado = "Activo" Then
                    lstnpProveedoresFiltrado = negociosProveedores.fnslBuscarProveedorPorEstado(True)
                ElseIf sTextoBuscado = "Inactivo" Then
                    lstnpProveedoresFiltrado = negociosProveedores.fnslBuscarProveedorPorEstado(False)
                End If
            End If

            Me.fnvCrearDataTable(lstnpProveedoresFiltrado)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltro.SelectedIndexChanged

    End Sub

    Private Sub cmbFiltro_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFiltro.SelectedValueChanged
        If cmbFiltro.SelectedItem = "Estado" Then
            lblFiltradoEstados.Visible = True
            cmbFiltradoEstados.Visible = True

            txtBusqueda.Enabled = False
        Else
            lblFiltradoEstados.Visible = False
            cmbFiltradoEstados.Visible = False
            txtBusqueda.Enabled = True

        End If
        Try
            cmbFiltro.Text = ""
            Me.fnvdRecargar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbFiltradoEstados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltradoEstados.SelectedIndexChanged

    End Sub

    Private Sub cmbFiltradoEstados_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFiltradoEstados.SelectedValueChanged
        txtBusqueda.Text = cmbFiltradoEstados.SelectedItem.ToString()
    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text = "" Then
            Me.fnvdRecargar()
        End If
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.fnvdRecargar()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        iNumeroPagina = 1
        fnvdRecargar()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If iNumeroPagina > 1 Then
            iNumeroPagina = iNumeroPagina - 1
            fnvdRecargar()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        iNumeroPagina = iNumeroPagina + 1
        fnvdRecargar()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If iNumeroPagina > 1 Then
            iNumeroPagina = iNumeroPagina - 1
            fnvdRecargar()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        iNumeroPagina = iNumeroPagina + 1
        fnvdRecargar()
    End Sub

    Private Sub cmbFiltro_MouseLeave(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbFiltradoEstados_MouseLeave(sender As System.Object, e As System.EventArgs) Handles cmbFiltradoEstados.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtBusqueda_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAnterior_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAnterior.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSiguiente_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbFiltro_MouseHover(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.MouseHover
        slblDescripcion.Text = "Permite seleccionar el criterio de búsqueda"
    End Sub

    Private Sub txtBusqueda_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseHover
        slblDescripcion.Text = "Ingrese el tecto a buscar"
    End Sub

    Private Sub btnbuscar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Click para iniciar búsqueda"
    End Sub

    Private Sub btnRegresar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnRegresar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnRegresar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnRegresar.MouseHover
        slblDescripcion.Text = "Recarga toda la lista de proveedores"
    End Sub

    Private Sub btnAnterior_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAnterior.MouseHover
        slblDescripcion.Text = "Ver los anteriores resultados"
    End Sub

    Private Sub btnSiguiente_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.MouseHover
        slblDescripcion.Text = "Ver los siguientes resultados"
    End Sub
End Class