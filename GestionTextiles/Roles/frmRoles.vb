Imports negocios
Public Class frmRoles
    Public Shared nrRolSeleccionado As negociosRol
    Private lstListaRoles As List(Of negociosRol) = New List(Of negociosRol)
    Private lstListaRolesFiltrada As List(Of negociosRol) = New List(Of negociosRol)

    Private Sub btnNCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPermiso.Click
        frmModificarPermiso.actualizar = False
        frmModificarPermiso.ShowDialog()
        Me.fnvCargarLista()
    End Sub

    Private Sub btnNPermiso_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPermiso.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnAsignarPermiso_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPermiso.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNPermiso_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPermiso.MouseHover
        slblDescripcion.Text = "Nueva configuración de permisos"
    End Sub

    Private Sub btnAsignarPermiso_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPermiso.MouseHover
        slblDescripcion.Text = "Asignar permisos a un usuario"
    End Sub

    Private Sub btnAsignarPermiso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarPermiso.Click
        If IsNothing(frmRoles.nrRolSeleccionado) Then
            MessageBox.Show("Debe seleccionar un elemento de la lista para poder modificarlo", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            frmModificarPermiso.actualizar = True
            frmModificarPermiso.ShowDialog()
            Me.fnvCargarLista()
        End If
    End Sub
    Private Sub frmRoles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establecer permisos del modulo de series
        Dim lnegPermisos As negociosRol = frmPrincipal.gnegPermisos

        If lnegPermisos.getPermisoCreacionRol() Then
            btnNPermiso.Enabled = True
        Else
            btnNPermiso.Enabled = False
        End If

        If lnegPermisos.getPermisoEliminacionRol() Then
            btnEliminarPermiso.Enabled = True
        Else
            btnEliminarPermiso.Enabled = False
        End If

        If lnegPermisos.getPermisoModificacionRol() Then
            btnModificarPermiso.Enabled = True
        Else
            btnModificarPermiso.Enabled = False
        End If

        If lnegPermisos.getPermisoListarRoles() Then
            txtBusqueda.Enabled = True
            btnBuscar.Enabled = True
            dgvRoles.Enabled = True
            Me.fnvCargarLista()
        Else
            txtBusqueda.Enabled = False
            btnBuscar.Enabled = False
            dgvRoles.Enabled = False
        End If

    End Sub

    Private Sub fnvCargarLista()
        Try
            txtBusqueda.Text = ""
            frmRoles.nrRolSeleccionado = Nothing
            Me.lstListaRoles = negociosRol.fnlstListarRoles()
            Me.fnvLlenarDataGridView(Me.lstListaRoles)
        Catch ex As Exception
            Me.dgvRoles.DataSource = Nothing
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub fnvLlenarDataGridView(ByRef lst As List(Of negociosRol))
        Dim ldtTabla As DataTable = New DataTable()
        ldtTabla.Columns.Add("Nombre")
        For i = 0 To lst.Count - 1 Step 1
            Dim ldrFila As DataRow = ldtTabla.NewRow()
            Dim lnrRolLocal As negociosRol = lst(i)
            ldrFila(0) = lnrRolLocal.getNombre()
            ldtTabla.Rows.Add(ldrFila)
        Next
        Me.dgvRoles.DataSource = ldtTabla
        Me.lstListaRolesFiltrada = lst
    End Sub
    Private Sub fnvBuscar(ByRef txt As String)
        Dim lstRolLocal As List(Of negociosRol) = New List(Of negociosRol)
        For Each i As negociosRol In lstListaRoles
            If i.getNombre() = txt Then
                lstRolLocal.Add(i)
            End If
        Next
        Me.fnvLlenarDataGridView(lstRolLocal)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgvRoles_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRoles.CellClick
        frmRoles.nrRolSeleccionado = Me.lstListaRolesFiltrada(e.RowIndex)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarPermiso.Click
        If IsNothing(frmRoles.nrRolSeleccionado) Then
            MessageBox.Show("No puede usar esta opción si no ha hecho clic en algun elemento de la lista", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Me.Dispose()
        End If
    End Sub


    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim lsTexto As String = txtBusqueda.Text
        If lsTexto = "" Then
            Me.fnvCargarLista()
        Else
            frmRoles.nrRolSeleccionado = Nothing
            Me.fnvBuscar(lsTexto)
        End If
    End Sub

    Private Sub btnEliminarPermiso_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarPermiso.Click
        If IsNothing(frmRoles.nrRolSeleccionado) Then
            MessageBox.Show("Debe seleccionar un elemento de la lista para poder eliminarlo", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If MessageBox.Show("¿Está seguro de querer eliminar el rol de permisos " + frmRoles.nrRolSeleccionado.getNombre() + "de la base de datos? Esta operación no se puede deshacer", "Precaución", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    frmRoles.nrRolSeleccionado.fnvdEliminarRol()
                    MessageBox.Show("La operación finalizó con éxito", "Rol eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.fnvCargarLista()
                    txtBusqueda.Text = ""
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.TextChanged
        If txtBusqueda.Text = "" Then
            btnBuscar.Enabled = False
        Else
            btnBuscar.Enabled = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub btnRegresar_Click(sender As System.Object, e As System.EventArgs) Handles btnRegresar.Click
        fnvCargarLista()
    End Sub

    Private Sub txtBusqueda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.MouseHover
        slblDescripcion.Text = "Nombre del rol de permisos a buscar"
    End Sub

    Private Sub txtBusqueda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.MouseLeave
        regresarDescripcion()
    End Sub
    Private Sub regresarDescripcion()
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnBuscar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.MouseHover
        slblDescripcion.Text = "Debe  presionar éste botón buscar roles según el nombre especificado"
    End Sub

    Private Sub btnBuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.MouseLeave
        regresarDescripcion()
    End Sub

    Private Sub btnRegresar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.MouseHover
        slblDescripcion.Text = "Carga los nombres de los roles existentes en la base de datos al formulario"
    End Sub

    Private Sub btnRegresar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.MouseLeave
        regresarDescripcion()
    End Sub

    Private Sub dgvRoles_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoles.MouseHover
        slblDescripcion.Text = "Muestra la lista de roles existente"
    End Sub

    Private Sub dgvRoles_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoles.MouseLeave
        regresarDescripcion()
    End Sub

    Private Sub btnEliminarPermiso_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPermiso.MouseHover
        slblDescripcion.Text = "Elimina el rol de la base de datos"
    End Sub

    Private Sub btnEliminarPermiso_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPermiso.MouseLeave
        regresarDescripcion()
    End Sub

    Private Sub btnSeleccionarPermiso_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarPermiso.MouseHover
        slblDescripcion.Text = "Selecciona un rol de la lista"
    End Sub

    Private Sub btnSeleccionarPermiso_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarPermiso.MouseLeave
        regresarDescripcion()
    End Sub

    Private Sub btnSalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Salir de este formulario"
    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
        regresarDescripcion()
    End Sub
End Class