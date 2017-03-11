Public Class FrmUsoList

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtDato.Text.Trim <> "" Then
            With LstDatos
                .Items.Add(TxtDato.Text)
                LblNroElem.Text = .Items.Count
            End With
        Else
            MessageBox.Show("Ingrese un dato", "Mensaje")
        End If
        TxtDato.Text = ""
        TxtDato.Focus()
    End Sub

    Private Sub LstDatos_Click(sender As Object, e As EventArgs) Handles LstDatos.Click
        If LstDatos.SelectedIndex > -1 Then
            TxtElemento.Text = LstDatos.SelectedItem()
            TxtIndice.Text = LstDatos.SelectedIndex
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If LstDatos.SelectedIndex > -1 Then
            LstDatos.Items.RemoveAt(LstDatos.SelectedIndex)
            LblNroElem.Text = LstDatos.Items.Count
        End If
    End Sub

    Private Sub BtnEliminarTodo_Click(sender As Object, e As EventArgs) Handles BtnEliminarTodo.Click
        LstDatos.Items.Clear()
        LblNroElem.Text = LstDatos.Items.Count
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        Dim ind As Integer
        ind = InputBox("Ingrese Indice:", "Mensaje")
        LstDatos.SetSelected(ind, True)
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Dim ind As Integer
        ind = InputBox("Ingrese Indice:", "Mensaje")
        LstDatos.SetSelected(ind, False)
    End Sub
End Class
