Public Class FrnAlumno
    Dim objAlumno As New ClsAlumno
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        Dim genero As String

        If rdM.Checked Then
            genero = "MASCULINO"
        ElseIf rdFeme.Checked Then
            genero = "FEMENINO"
        End If

        With objAlumno
            .codigo = txtCodigo.Text
            .nombre = txtNombre.Text
            .apePaterno = txtApeP.Text
            .apeMaterno = txtApeM.Text
            .sexo = genero
            .edad = txtEdad.Text
            txtGeneral.Text = .nombreCompleto(1) & vbCrLf & .datosAlumno()
        End With

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Text = " "
        txtNombre.Text = " "
        txtApeP.Text = " "
        txtApeM.Text = " "
        rdM.Checked = False
        rdFeme.Checked = False
        txtEdad.Text = " "
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class