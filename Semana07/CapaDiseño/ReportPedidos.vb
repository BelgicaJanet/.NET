Imports CapaNegocio
Imports CapaEntidad
Public Class ReportPedidos

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim strFilter As String = ""
        Dim strlistCampos = "PED_ID ,PED_FECHA ,PED_CLIENTE,USR_ID,PED_ESTADO"

        If comboUsuario.SelectedItem > 0 Then
            strFilter = "AND P.USR_ID = '" & comboUsuario.SelectedItem
        End If

        If RadioButton1.Checked Then
            strFilter = strFilter & "AND P.PED_ESTADO = 'D'"
        ElseIf RadioButton2.Checked Then
            strFilter = strFilter & "AND P.PED_ESTADO = 'A'"
        End If

        NePedido.listarPedido(strFilter, strlistCampos)

    End Sub


  
    Private Sub comboDesde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboDesde.SelectedIndexChanged

      
    End Sub
End Class