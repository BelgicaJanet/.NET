Public Class FrmUsoCheckedList

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If TxtDato.Text.Trim <> "" Then
            With CklbDatos
                .Items.Add(TxtDato.Text)
            End With
        Else
            MessageBox.Show("Ingrese un dato", "Mensaje")
        End If
        TxtDato.Text = ""
        TxtDato.Focus()
    End Sub

    Private Sub BtnElemSel_Click(sender As Object, e As EventArgs) Handles BtnElemSel.Click
        Dim strElem As String = "", strInd As String = ""
        With CklbDatos
            For ind = 0 To .Items.Count - 1
                If .GetItemChecked(ind) Then
                    strElem &= CklbDatos.Items.Item(ind) & ", "
                    strInd &= ind & ", "
                End If
            Next
        End With
        TxtElementos.Text = strElem
        TxtIndices.Text = strInd
    End Sub

    Private Sub FrmUsoCheckedList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For ind = 100 To 105
            CklbDatos.Items.Add(ind)
        Next
    End Sub

    Private Sub BtnElimElem_Click(sender As Object, e As EventArgs) Handles BtnElimElem.Click
        With CklbDatos
            For ind = .Items.Count - 1 To 0 Step -1
                If .GetItemChecked(ind) Then
                    .Items.RemoveAt(ind)
                End If
            Next
        End With
    End Sub

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        Dim ind As Integer
        ind = InputBox("Ingrese Indice:", "Mensaje")
        CklbDatos.SetItemChecked(ind, True)
    End Sub

    Private Sub BtnLiberar_Click(sender As Object, e As EventArgs) Handles BtnLiberar.Click
        Dim ind As Integer
        ind = InputBox("Ingrese Indice:", "Mensaje")
        CklbDatos.SetItemChecked(ind, False)
    End Sub
End Class