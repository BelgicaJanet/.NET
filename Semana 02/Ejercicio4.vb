Public Class Ejercicio4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSerie.Click
        Dim numero As Integer
        Dim intervalo As Integer


        numero = txtNumero.Text
        intervalo = txtIntervalo.Text

        '  listSerie.Items.Add(numero)

        For ind = 1 To 10
            listSerie.Items.Add(numero)
            numero = numero + intervalo

        Next
      
        

    End Sub

    Private Sub listSerie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listSerie.SelectedIndexChanged

    End Sub
End Class