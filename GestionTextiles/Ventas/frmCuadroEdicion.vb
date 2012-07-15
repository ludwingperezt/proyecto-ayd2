Public Class frmCuadroEdicion

    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        If (Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = "." Or e.KeyChar = vbBack)) Then
            e.KeyChar = vbNullChar
        End If
        If e.KeyChar = "." Then
            If txtCantidad.Text.Contains(".") Then
                e.KeyChar = ""
            End If
        End If

    End Sub
    Public Function fnDuObtenerNuevaCantidad(ByVal ventana As System.Windows.Forms.IWin32Window) As Double
        Me.ShowDialog(ventana)
        Dim duRet As Double
        If txtCantidad.Text = "" Then
            duRet = 0
        Else
            duRet = Convert.ToDouble(txtCantidad.Text)
        End If
        Return duRet
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtCantidad.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub frmCuadroEdicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCantidad.Text = "0"
    End Sub
End Class