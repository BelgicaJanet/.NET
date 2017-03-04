Public Class CD3

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If LstNotas.Items.Count < 3 Then
            If txtCurso.Text.Trim <> "" Then
                With LstNotas.Items.Add(txtCurso.Text)
                    lblContador.Text = LstNotas.Items.Count
                End With
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEstado.TextChanged

    End Sub
End Class