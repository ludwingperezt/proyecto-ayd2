Imports negocios
Public Class frmModuloSeries
    Public Shared gnsSerieSeleccionada As negociosSerie
    Private lstSeries As List(Of negociosSerie) = New List(Of negociosSerie)
    Private lstSeriesFiltrada As List(Of negociosSerie) = New List(Of negociosSerie)
    Private Sub btnNSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNSerie.Click
        frmSerie.actualizar = False
        frmSerie.ShowDialog()
        Me.fnvCargarLista()
        txtBusqueda.Text = ""
    End Sub

    Private Sub btnLProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmSerie.Click
        If IsNothing(frmModuloSeries.gnsSerieSeleccionada) Then
            MessageBox.Show("Debe seleccionar un elemento de la lista para poder modificarlo", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            frmSerie.actualizar = True
            frmSerie.lblTitulo.Text = "Modificar serie"
            frmSerie.txtSerie.Enabled = False
            frmSerie.picbValidacion.Visible = False
            frmSerie.ShowDialog()
            ''recargar lista
            Me.fnvCargarLista()
            txtBusqueda.Text = ""
        End If
    End Sub

    Private Sub btnNSerie_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNSerie.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnLProveedores_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmSerie.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnNSerie_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNSerie.MouseHover
        slblDescripcion.Text = "Permite el ingreso de una nueva Serie"
    End Sub

    Private Sub btnLProveedores_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmSerie.MouseHover
        slblDescripcion.Text = "Muestra el listado de las series "
    End Sub

    Private Sub btnSalir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.MouseHover
        slblDescripcion.Text = "Cierra el módulo de series"
    End Sub

    Private Sub dgvSeries_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSeries.CellClick
        frmModuloSeries.gnsSerieSeleccionada = Me.lstSeriesFiltrada(e.RowIndex)
    End Sub
    Private Sub fnvCargarLista()
        Try
            frmModuloSeries.gnsSerieSeleccionada = Nothing
            Me.lstSeries = negociosSerie.fnlstListaSeries()
            If Me.lstSeries.Count >= 1 Then
                'MessageBox.Show("No se puede tener más de un talonario de facturas activo", "Ingreso de talonarios nuevos desactivado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnNSerie.Enabled = False
            Else
                MessageBox.Show("Debe ingresar un nuevo talonario de facturas", "No hay talonarios disponibles", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnNSerie.Enabled = True
            End If
            Me.fnvLlenarDataGridView(Me.lstSeries)
        Catch ex As Exception
            Me.dgvSeries.DataSource = Nothing
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub fnvBuscar(ByRef txt As String)
        Dim lstSeriesLocal As List(Of negociosSerie) = New List(Of negociosSerie)
        For Each i As negociosSerie In lstSeries
            If i.getSerie() = txt Then
                lstSeriesLocal.Add(i)
            End If
        Next
        Me.fnvLlenarDataGridView(lstSeriesLocal)
    End Sub
    Private Sub fnvLlenarDataGridView(ByRef lst As List(Of negociosSerie))
        Dim ldtTabla As DataTable = New DataTable()
        ldtTabla.Columns.Add("Serie")
        ldtTabla.Columns.Add("Número de la ultima factura emitida")
        ldtTabla.Columns.Add("Número actual")
        ldtTabla.Columns.Add("Límite de facturas")
        ldtTabla.Columns.Add("Facturas restantes")
        For i = 0 To lst.Count - 1 Step 1
            Dim ldrFila As DataRow = ldtTabla.NewRow()
            Dim lnsSerieLocal As negociosSerie = lst(i)
            ldrFila(0) = lnsSerieLocal.getSerie()
            ldrFila(1) = (lnsSerieLocal.getNumeroActual() - 1)
            ldrFila(2) = lnsSerieLocal.getNumeroActual()
            ldrFila(3) = lnsSerieLocal.getLimite()
            ldrFila(4) = (lnsSerieLocal.getLimite() - (lnsSerieLocal.getNumeroActual() - 1))
            ldtTabla.Rows.Add(ldrFila)
        Next
        Me.dgvSeries.DataSource = ldtTabla
        Me.lstSeriesFiltrada = lst
    End Sub

    Private Sub frmModuloSeries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establecer permisos del modulo de series
        Dim lnegPermisos As negociosRol = frmPrincipal.gnegPermisos

        If lnegPermisos.getPermisoCreacionSerieFacturaVenta() Then
            btnNSerie.Enabled = True
        Else
            btnNSerie.Enabled = False
        End If

        If lnegPermisos.getPermisoEliminacionSerieFacturaVenta() Then
            btnEliminarSerie.Enabled = True
        Else
            btnEliminarSerie.Enabled = False
        End If

        If lnegPermisos.getPermisoModificacionSerieFacturaVenta() Then
            btnmSerie.Enabled = True
        Else
            btnmSerie.Enabled = False
        End If

        If lnegPermisos.getPermisoListarSerieFacturaVenta() Then
            txtBusqueda.Enabled = True
            btnBuscar.Enabled = True
            dgvSeries.Enabled = True
            Me.fnvCargarLista()
        Else
            txtBusqueda.Enabled = False
            btnBuscar.Enabled = False
            dgvSeries.Enabled = False
        End If


    End Sub

    Private Sub btnEliminarSerie_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminarSerie.Click
        If IsNothing(frmModuloSeries.gnsSerieSeleccionada) Then
            MessageBox.Show("Debe seleccionar un elemento de la lista para poder eliminarlo", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If MessageBox.Show("¿Está seguro de querer eliminar el talonario " + frmModuloSeries.gnsSerieSeleccionada.getSerie() + "de la base de datos? Esta operación no se puede deshacer", "Precaución", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Try
                    frmModuloSeries.gnsSerieSeleccionada.fnvEliminarSerie()
                    MessageBox.Show("La operación finalizó con éxito", "Talonario eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ''recargar lista
                    Me.fnvCargarLista()
                    txtBusqueda.Text = ""
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim lsTexto As String = txtBusqueda.Text
        If lsTexto = "" Then
            Me.fnvCargarLista()
        Else
            If lsTexto.Length = 1 Then
                lsTexto = lsTexto + "  "
            ElseIf lsTexto.Length = 2 Then
                lsTexto = lsTexto + " "
            End If
            Me.fnvBuscar(lsTexto)
        End If
    End Sub

    Private Sub txtBusqueda_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs)
        Me.fnvCargarLista()
    End Sub

    Private Sub btnActualizar_MouseLeave(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub dgvSeries_MouseLeave(sender As System.Object, e As System.EventArgs) Handles dgvSeries.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtBusqueda_MouseHover(sender As System.Object, e As System.EventArgs) Handles txtBusqueda.MouseHover
        slblDescripcion.Text = "Ingrese una serie específica..."
    End Sub

    Private Sub dgvSeries_MouseHover(sender As System.Object, e As System.EventArgs) Handles dgvSeries.MouseHover
        slblDescripcion.Text = "Lista de series usadas para facturar..."
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

    Private Sub btnActualizar_MouseHover(sender As System.Object, e As System.EventArgs)
        slblDescripcion.Text = "Carga toda la lista de series"
    End Sub

    Private Sub btnBuscar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnBuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnBuscar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnBuscar.MouseHover
        slblDescripcion.Text = "Inicia la búsqueda..."
    End Sub

    Private Sub btnRegresar_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnRegresar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.MouseHover
        slblDescripcion.Text = "Recarga la lista de series"
    End Sub
    Private Sub regresarDescripcion()
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnRegresar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.MouseLeave
        regresarDescripcion()
    End Sub

    Private Sub btnEliminarSerie_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarSerie.MouseHover
        slblDescripcion.Text = "Elimina una serie seleccionada de la lista"
    End Sub

    Private Sub btnEliminarSerie_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarSerie.MouseLeave
        regresarDescripcion()
    End Sub
End Class