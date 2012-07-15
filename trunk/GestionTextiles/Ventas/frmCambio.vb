Public Class frmCambio
    Private lbooBanderaPunto As Boolean


    Private Sub txtEfectivo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEfectivo.KeyPress
        If txtEfectivo.Text.Contains(".") Then
            lbooBanderaPunto = True
        Else
            lbooBanderaPunto = False
        End If

        If lbooBanderaPunto = True Then
            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack)) Then
                e.KeyChar = vbNullChar
            End If
        Else
            If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = ".")) Then
                e.KeyChar = vbNullChar
            End If
        End If
    End Sub
End Class