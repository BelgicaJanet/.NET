Imports Microsoft.Office.Interop
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

    Private Sub btnExcel_click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Dim objExcel As New Excel.Application
        Dim objLibro As Excel.Workbook = objExcel.Workbooks.Add()
        Dim objhoja As Excel.Worksheet = objLibro.Worksheets(1)

        objhoja.Columns(1).ColumnWidth = 10

        objhoja.Cells(1, 1) = "Hola"
        objhoja.Cells(5, 1) = "Nro. Pedido"

        objhoja.Range("a1:e1").Merge()
        objhoja.Range("a1:e1").Font.FontStyle = "Arial"
        objhoja.Range("a1:e1").Font.Size = 16
        objhoja.Range("a1:e1").Font.Bold = "true"


        objExcel.Visible = True
    End Sub


    Private Sub btnWord_click(sender As Object, e As EventArgs) Handles btnWord.Click
        Dim objWord As New Word.Application
        Dim objDoc As Word.Document = objWord.Documents.Add()
        Dim objTable As Word.Table = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, 5, 5)

        objTable.Cell(1, 1).Range.Text = "PEDIDO"
        objTable.Cell(1, 2).Range.Text = "FECHA"
        objTable.Cell(1, 1).Range.Font.Bold = True
        objTable.Cell(1, 2).Range.Font.Bold = True
        objWord.Visible = True
    End Sub


    End Class