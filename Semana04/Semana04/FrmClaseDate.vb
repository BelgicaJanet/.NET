Public Class FrmClaseDate
    Dim fechaHoy As Date

    Private Sub BtnCapturar_Click(sender As Object, e As EventArgs) Handles BtnCapturar.Click
        fechaHoy = Date.Now
        TxtFecha.Text = fechaHoy
        txtDia.Text = fechaHoy.Day
        txtMes.Text = fechaHoy.Month
        txtAno.Text = fechaHoy.Year
        txtHora.Text = fechaHoy.Hour
        txtMinutos.Text = fechaHoy.Minute
        txtSegundos.Text = fechaHoy.Second

        txt5diasD.Text = 5 + fechaHoy.Day
        txt4h.Text = 4 + fechaHoy.Hour
        txt3Antes.Text = fechaHoy.Day - 3
    End Sub
End Class