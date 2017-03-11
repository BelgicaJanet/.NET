Public Class FrmClaseString
    Dim cadena As String

    Private Sub BtnGenrar_Click(sender As Object, e As EventArgs) Handles BtnGenrar.Click
        cadena = TxtCadena.Text
        txtMayuscula.Text = cadena.ToUpper
        txtMinuscula.Text = cadena.ToLower
        txtCentro.Text = cadena.Substring(2, 2)

        For idx = 0 To cadena.Length - 1
            lstCaracteres.Items.Add(cadena.Substring(0, idx + 1).ToUpper)
        Next
        txtPrueba.Text = txtMayuscula.Text.IndexOf("E")


    End Sub

    
End Class