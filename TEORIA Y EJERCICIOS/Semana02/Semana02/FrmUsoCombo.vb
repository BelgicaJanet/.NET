<<<<<<< HEAD
﻿Public Class FrmUsoCombo
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtDato.Text.Trim <> "" Then
            With CboDatos
                .Items.Add(TxtDato.Text)
                LblNroElem.Text = .Items.Count
            End With
        Else
            MessageBox.Show("Ingrese un dato", "Mensaje")
        End If
        TxtDato.Text = ""
        TxtDato.Focus()
    End Sub

    Private Sub BtnEliminarTodo_Click(sender As Object, e As EventArgs) Handles BtnEliminarTodo.Click
        CboDatos.Items.Clear()
        LblNroElem.Text = CboDatos.Items.Count
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If CboDatos.SelectedIndex > -1 Then
            CboDatos.Items.RemoveAt(CboDatos.SelectedIndex)
            LblNroElem.Text = CboDatos.Items.Count
        End If
    End Sub

    Private Sub CboDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDatos.SelectedIndexChanged
        If CboDatos.SelectedIndex > -1 Then
            TxtElemento.Text = CboDatos.SelectedItem()
            TxtIndice.Text = CboDatos.SelectedIndex
        End If
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        Dim ind As Integer
        ind = InputBox("Ingrese Indice:", "Mensaje")
        CboDatos.SelectedIndex = ind
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        CboDatos.SelectedIndex = -1
    End Sub
=======
﻿Public Class FrmUsoCombo
    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtDato.Text.Trim <> "" Then
            With CboDatos
                .Items.Add(TxtDato.Text)
                LblNroElem.Text = .Items.Count
            End With
        Else
            MessageBox.Show("Ingrese un dato", "Mensaje")
        End If
        TxtDato.Text = ""
        TxtDato.Focus()
    End Sub

    Private Sub BtnEliminarTodo_Click(sender As Object, e As EventArgs) Handles BtnEliminarTodo.Click
        CboDatos.Items.Clear()
        LblNroElem.Text = CboDatos.Items.Count
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If CboDatos.SelectedIndex > -1 Then
            CboDatos.Items.RemoveAt(CboDatos.SelectedIndex)
            LblNroElem.Text = CboDatos.Items.Count
        End If
    End Sub

    Private Sub CboDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDatos.SelectedIndexChanged
        If CboDatos.SelectedIndex > -1 Then
            TxtElemento.Text = CboDatos.SelectedItem()
            TxtIndice.Text = CboDatos.SelectedIndex
        End If
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        Dim ind As Integer
        ind = InputBox("Ingrese Indice:", "Mensaje")
        CboDatos.SelectedIndex = ind
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        CboDatos.SelectedIndex = -1
    End Sub
>>>>>>> 64b580890980be05fe093352e7379d408227b737
End Class