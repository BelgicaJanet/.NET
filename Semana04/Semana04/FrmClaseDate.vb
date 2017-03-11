Public Class FrmClaseDate
    Dim fechaHoy As Date

    Private Sub BtnCapturar_Click(sender As Object, e As EventArgs) Handles BtnCapturar.Click
        fechaHoy = Date.Now
        TxtFecha.Text = fechaHoy
    End Sub
End Class