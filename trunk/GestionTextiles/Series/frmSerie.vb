Public Class frmSerie

    Friend Shared actualizar As Boolean 'si esta bandera es TRUE entonces es insertar, sino, modificar

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
            If actualizar Then
                '' si es un update...
            Else
                '' si es un insert...
            End If
            ' todo es válido se procede a guardar en la BD y luego a cerrar el form!
            Me.Dispose()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtSerie_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtSerie.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub txtCorrelativo_MouseLeave(sender As System.Object, e As System.EventArgs) Handles txtCorrelativo.MouseLeave
        slblDescripcion.Text = "Descripción"
    End Sub

    Private Sub frmSerie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If actualizar = False Then
            Me.lblTitulo.Text = "Modificar serie"
        Else
            Me.lblTitulo.Text = "Nueva serie"
        End If

    End Sub
End Class