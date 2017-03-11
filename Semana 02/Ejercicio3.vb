Public Class Ejercicio3

    Private Sub listNota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listNota.SelectedIndexChanged

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim nota As Integer

            If listNota.Items.Count < 10 Then
                nota = txtNota.Text
                If nota < 21 Then
                    listNota.Items.Add(nota)
                End If
            End If
            lbltxt.Text = listNota.Items.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show(ex.StackTrace)
        Finally
            ' MessageBox.Show("Controlando el Error")
        End Try


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim suma As Integer
        Dim promedio As Double
        For ind = 0 To listNota.Items.Count - 1
            suma += listNota.Items.Item(ind)
        Next
        promedio = suma / 10
        txtPromedio.Text = promedio
        txtPuntaje.Text = suma


    End Sub
End Class