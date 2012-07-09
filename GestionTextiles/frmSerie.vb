Public Class frmSerie

    Private Sub txtSerie_Leave(sender As System.Object, e As System.EventArgs) Handles txtSerie.Leave
        '' Validar si no existe la serie indicada...
        picbValidacion.Image = imglValidacion.Images(1)
        '' else
        picbValidacion.Image = imglValidacion.Images(0)
        txtSerie.Focus()
        ''End if
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
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
            ' todo es válido se procede a guardar en la BD y luego a cerrar el form!
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class