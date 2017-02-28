Public Class CD3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim curso As String

        If txtNotas.Text.Trim <> "" Then
            With lstNota
                .Items.Add(txtNotas.Text)

            End With
        End If

    End Sub
End Class