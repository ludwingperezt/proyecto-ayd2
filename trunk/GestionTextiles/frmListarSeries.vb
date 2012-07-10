Public Class frmListarSeries

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        frmSerie.txtSerie.Enabled = False
        ''Acá se llenan los textbox
        'frmSerie.txtSerie.Text = SERIE
        'frmSerie.txtCorrelativo.Text=CORRELATIVO
        frmSerie.actualizar = True
    End Sub
End Class