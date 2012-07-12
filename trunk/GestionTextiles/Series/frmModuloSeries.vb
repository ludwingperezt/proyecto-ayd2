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
            Me.fnvLlenarDataGridView(Me.lstSeries)
        Catch ex As Exception
            'Me.lstSeries.Clear()
            'Me.lstSeriesFiltrada = Nothing
            'Me.fnvLlenarDataGridView(Me.lstSeries)
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
        ldtTabla.Columns.Add("Numero_actual")
        For i = 0 To lst.Count - 1 Step 1
            Dim ldrFila As DataRow = ldtTabla.NewRow()
            Dim lnsSerieLocal As negociosSerie = lst(i)
            ldrFila(0) = lnsSerieLocal.getSerie()
            ldrFila(1) = lnsSerieLocal.getNumeroActual()
            ldtTabla.Rows.Add(ldrFila)
        Next
        Me.dgvSeries.DataSource = ldtTabla
        Me.lstSeriesFiltrada = lst
    End Sub

    Private Sub frmModuloSeries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.fnvCargarLista()
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

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Me.fnvCargarLista()
    End Sub

    Private Sub btnActualizar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnActualizar.MouseLeave
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

    Private Sub btnActualizar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnActualizar.MouseHover
        slblDescripcion.Text = "Carga toda la lista de series"
    End Sub

    Private Sub btnBuscar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnBuscar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub btnBuscar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnBuscar.MouseHover
        slblDescripcion.Text = "Inicia la búsqueda..."
    End Sub
End Class