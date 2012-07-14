Imports negocios


Public Class frmModuloCompras
    Private glstCompras As List(Of negociosFacturasProveedores) = New List(Of negociosFacturasProveedores)
    Private glstComprasFiltrada As List(Of negociosFacturasProveedores) = New List(Of negociosFacturasProveedores)
    Public Shared gnpComprasSeleccionado As negociosFacturasProveedores
    Private banderaBusqueda As Boolean = False
    Private Sub btnNCompra_Click(sender As System.Object, e As System.EventArgs) Handles btnNCompra.Click
        frmCompras.ShowDialog()
    End Sub

    Private Sub btnbuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnbuscar.Click

    End Sub

    Private Sub cmbFiltro_MouseLeave(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtBusqueda_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnbuscar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnbuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaCompras_MouseLeave(sender As System.Object, e As System.EventArgs) Handles dgvListaCompras.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNCompra_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnNCompra.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnEliminarEmpleados_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAnularCompra.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub cmbFiltro_MouseHover(sender As System.Object, e As System.EventArgs) Handles cmbFiltro.MouseHover
        slblDescripcion.Text = "Debe elegir un criterio de búsqueda"
    End Sub

    Private Sub txtBusqueda_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseHover
        slblDescripcion.Text = "Ingrese el texto a buscar según el criterio seleccionado"
    End Sub

    Private Sub btnbuscar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnbuscar.MouseHover
        slblDescripcion.Text = "Haga clic para obtener resultados"
    End Sub

    Private Sub btnAnularCompra_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAnularCompra.MouseHover
        slblDescripcion.Text = "Haga clic para anular la compra que ha seleccionado"
    End Sub

    Private Sub btnSalir_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Salir del módulo de compras"
    End Sub

    Private Sub chkAnuladas_MouseLeave(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvListaCompras_MouseHover(sender As System.Object, e As System.EventArgs) Handles dgvListaCompras.MouseHover
        slblDescripcion.Text = "Lista de facturas de compras"
    End Sub

    Private Sub chkAnuladas_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Si está habilitada esta opción, se hara una búsqueda solamente entre las facturas anuladas"
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub frmModuloCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fnvdRecargar()
        ' Establecer permisos del modulo de Compras
        Dim lnegPermisos As negociosRol = frmPrincipal.gnegPermisos

        If lnegPermisos.getPermisoCompra() Then
            btnNCompra.Enabled = True
        Else
            btnNCompra.Enabled = False
        End If

        If lnegPermisos.getPermisoDevolverProductosProveedores() Then
            btnAnularCompra.Enabled = True
        Else
            btnAnularCompra.Enabled = False
        End If
    End Sub
    Private Sub fnvdRecargar()
        Try
            dgvListaCompras.DataSource = ""
            frmModuloCompras.gnpComprasSeleccionado = Nothing
            Me.glstComprasFiltrada.Clear()
            Me.banderaBusqueda = False
            Me.glstCompras = negociosFacturasProveedores.fnslListarUltimasVeinteCompras()
            Me.fnvCrearDataTable(Me.glstCompras)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvListaCompras.DataSource = Nothing
        End Try
    End Sub

    Private Sub fnvCrearDataTable(ByRef lista As List(Of negociosFacturasProveedores))
        Dim ldtTabla As DataTable = New DataTable()
        Dim ldrFila As DataRow
        Dim lnpCompras As negociosFacturasProveedores
        ldtTabla.Columns.Add("Serie")
        ldtTabla.Columns.Add("Numero")
        ldtTabla.Columns.Add("Fecha")
        ldtTabla.Columns.Add("Total")
        For i = 0 To lista.Count - 1 Step 1
            ldrFila = ldtTabla.NewRow()
            lnpCompras = lista(i)
            ldrFila(3) = lnpCompras.getSerie()
            ldrFila(4) = lnpCompras.getNumero()
            ldrFila(5) = lnpCompras.getFecha()
            ldrFila(6) = lnpCompras.getTotal()
            ldtTabla.Rows.Add(ldrFila)
        Next
        Me.dgvListaCompras.DataSource = ldtTabla
    End Sub
End Class