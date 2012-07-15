Imports System.Xml
Imports negocios
Public Class frmtipocliente
    Dim lnpTipoCliente As negociosTipoCliente = New negociosTipoCliente()

    Private glstTipoCliente As List(Of negociosTipoCliente) = New List(Of negociosTipoCliente)
    Dim lbooBanderaPunto As Boolean = False
    Private glstTipoClienteFiltrada As List(Of negociosTipoCliente) = New List(Of negociosTipoCliente)
    Public Shared gnpTipoClienteSeleccionado As negociosTipoCliente
    Private banderaBusqueda As Boolean = False
    Private Sub txtbusqueda_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtbusqueda_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.MouseHover
        slblDescripcion.Text = "Ingrese una descripción para buscar el tipo de cliente ej. 'especial'"
    End Sub

    Private Sub dgvtiposcliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvtiposcliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        slblDescripcion.Text = "Listado de los tipos de cliente existentes "
    End Sub

    Private Sub btnbuscar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Realiza la busqueda dentro de los tipos de cliente existentes"
    End Sub

    Private Sub btningresar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnmodificartipocliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificartipocliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btneliminartipocliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminartipocliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    
    Private Sub btnsalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btningresar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.MouseHover
        slblDescripcion.Text = "Ingresa un nuevo tipo de cliente"
    End Sub

    Private Sub btnmodificartipocliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificartipocliente.MouseHover
        slblDescripcion.Text = "Modifica un tipo de cliente existente"
    End Sub

    Private Sub btneliminartipocliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminartipocliente.MouseHover
        slblDescripcion.Text = "Elimnina un tipo de cliente existente"
    End Sub

    Private Sub btnsalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.MouseHover
        slblDescripcion.Text = "Salir de la aplicación"
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If txtbusqueda.Text = "" Then
            MessageBox.Show("Ingrese una descripción para realizar la busqueda")
        Else
            ' codigo para realizar la busqueda
            dgvtiposcliente.DataSource = negociosCliente.fnDbBuscarClienteNombre(txtbusqueda.Text)
        End If
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        frmingresotipocliente.Show()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Dispose()
        frmingresoclientes.Show()
    End Sub

    Private Sub btnmodificartipocliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificartipocliente.Click
        If IsNothing(frmtipocliente.gnpTipoClienteSeleccionado) Then
            MessageBox.Show("Debe seleccionar un tipo de Cliente de la lista para poder modificar sus datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            frmModificarTipoCliente.actualizar = True
            frmModificarTipoCliente.ShowDialog(Me)
            Me.fnvdRecargar()
            txtbusqueda.Text = ""
        End If


        frmModificarTipoCliente.Show()
    End Sub

    Private Sub txtbusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.Text = "" Then
            btnbuscar.Enabled = False
        Else
            btnbuscar.Enabled = True
        End If
    End Sub

    Private Sub btnActualizar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnActualizar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.MouseHover
        slblDescripcion.Text = "Actualiza el  listado de los tipos de cliente en sistema"
    End Sub

    Private Sub dgvtiposcliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub cmbCliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbCliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCliente.MouseHover
        slblDescripcion.Text = "Seleccióne el parametro por el que desea buscar"
    End Sub

    Private Sub frmtipocliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establecer permisos
        Dim lnegPermisos As negociosRol = frmPrincipal.gnegPermisos

        If lnegPermisos.getPermisoCreacionTiposCliente() Then
            btningresar.Enabled = True
        Else
            btningresar.Enabled = False
        End If
        If lnegPermisos.getPermisoListarTiposCliente() Then
            cmbCliente.Enabled = True
            txtbusqueda.Enabled = True
            btnbuscar.Enabled = True
            btnActualizar.Enabled = True
            dgvtiposcliente.Enabled = True

        Else
            cmbCliente.Enabled = False
            txtbusqueda.Enabled = False
            btnbuscar.Enabled = False
            btnActualizar.Enabled = False
            dgvtiposcliente.Enabled = False
        End If

        If lnegPermisos.getPermisoModificacionTiposCliente() Then
            btnmodificartipocliente.Enabled = True
        Else
            btnmodificartipocliente.Enabled = False
        End If

        If lnegPermisos.getPermisoEliminacionTiposCliente() Then
            btneliminartipocliente.Enabled = True
        Else
            btneliminartipocliente.Enabled = False
        End If

        ''
        fnvdRecargar()
    End Sub
    Public Sub fnvdRecargar()
        Try
            frmingresoclientes.gnpTipoClienteSeleccionado = Nothing
            Me.glstTipoClienteFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstTipoCliente = negociosTipoCliente.fnslListarTipoClientes()
            Me.fnvCrearDataTable(Me.glstTipoCliente)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgvtiposcliente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvtiposcliente.CellClick
        If banderaBusqueda Then
            frmtipocliente.gnpTipoClienteSeleccionado = glstTipoClienteFiltrada(e.RowIndex)
        Else
            frmtipocliente.gnpTipoClienteSeleccionado = glstTipoCliente(e.RowIndex)
        End If
    End Sub
    Private Sub fnvCrearDataTable(ByRef lista As List(Of negociosTipoCliente))
        Dim ldtTabla As DataTable = New DataTable()
        Dim ldrFila As DataRow
        Dim lnpTipoClientes As negociosTipoCliente
        ldtTabla.Columns.Add("IdTipoCliente")
        ldtTabla.Columns.Add("Nombre")
        ldtTabla.Columns.Add("Descripcion")
        ldtTabla.Columns.Add("Descuento")

        For i = 0 To lista.Count - 1 Step 1
            ldrFila = ldtTabla.NewRow()
            lnpTipoClientes = lista(i)
            ldrFila(0) = lnpTipoClientes.getIdTipoCliente()
            ldrFila(1) = lnpTipoClientes.getNombreTipoCliente()
            ldrFila(2) = lnpTipoClientes.getDescripcionTipoCliente()
            ldrFila(3) = lnpTipoClientes.getDescuentoTipoCliente()
            ldtTabla.Rows.Add(ldrFila)
        Next
        dgvtiposcliente.DataSource = ldtTabla
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        fnvdRecargar()
    End Sub

    Private Sub dgvtiposcliente_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvtiposcliente.CellContentClick

    End Sub
End Class