Public Class frmPreFacturaRep

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        frmReportes.setDatos(txtSerie.Text, Integer.Parse(txtNumero.Text))
        frmReportes.ShowDialog(Me)
        Me.Dispose()
    End Sub
End Class