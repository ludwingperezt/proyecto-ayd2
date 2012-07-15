Public Class frmCambio
    Private lbooBanderaPunto As Boolean


    Private Sub txtEfectivo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEfectivo.KeyPress
        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "." Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If
        If e.KeyChar = "." Then
            If txtEfectivo.Text.Contains(".") Then
                e.KeyChar = ""
            End If
        End If
    End Sub

    Private Sub txtEfectivo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEfectivo.TextChanged
        If txtEfectivo.Text = "" Then
            lblVuelto.Text = "-" + lblTotal.Text
        Else
            lblVuelto.Text = (Decimal.Parse(txtEfectivo.Text) - Decimal.Parse(lblTotal.Text))
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If (Decimal.Parse(lblVuelto.Text) >= 0) Then
            Me.Dispose()
        End If
    End Sub
End Class