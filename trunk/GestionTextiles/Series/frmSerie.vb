Imports negocios
Public Class frmSerie

    Friend Shared actualizar As Boolean 'si esta bandera es TRUE entonces es insertar, sino, modificar

    Private Sub txtSerie_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Leave
        '' Validar si no existe la serie indicada...
        picbValidacion.Image = imglValidacion.Images(1)
        '' else
        picbValidacion.Image = imglValidacion.Images(0)
        ''txtSerie.Focus()
        ''End if
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim lbooBandera As Boolean = True

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
                frmModuloSeries.gnsSerieSeleccionada.setNumeroActual(Convert.ToInt32(txtCorrelativo.Text))
                Try
                    If MessageBox.Show("¿Está seguro de modificar los datos del talonario?", "Precaución", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                        Try
                            frmModuloSeries.gnsSerieSeleccionada.fnvModificarSerie()
                            MessageBox.Show("La operación de modificación finalizó con éxito", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            frmModuloSeries.gnsSerieSeleccionada = Nothing
                            Me.Dispose()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                '' si es un insert...
                Dim lnsSerieLocal As negociosSerie = New negociosSerie()
                lnsSerieLocal.setSerie(txtSerie.Text)
                lnsSerieLocal.setNumeroActual(Convert.ToInt32(txtCorrelativo.Text))
                Try
                    lnsSerieLocal.fnvInsertarSerie()
                    MessageBox.Show("La operación de insersión del talonario se llevó a cabo con éxito", "Insersión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            ' todo es válido se procede a guardar en la BD y luego a cerrar el form!

        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtSerie_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCorrelativo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorrelativo.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub frmSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If actualizar = False Then
            Me.lblTitulo.Text = "Nueva serie"
            Me.Text = "Nueva serie"
        Else
            MessageBox.Show("La modificación de datos en esta parte del programa puede dañar la integridad de la base de datos", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.lblTitulo.Text = "Modificar serie"
            Me.Text = "Modificar serie"
            Me.txtSerie.Text = frmModuloSeries.gnsSerieSeleccionada.getSerie()
            Me.txtCorrelativo.Text = Convert.ToString(frmModuloSeries.gnsSerieSeleccionada.getNumeroActual())
        End If
    End Sub
End Class