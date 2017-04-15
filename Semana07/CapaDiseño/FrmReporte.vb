Public Class FrmReporte

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnTorta.Click
        ChtGrafico.Titles.Clear()
        ChtGrafico.Titles.Add("Productos")
        ChtGrafico.Series.Clear()
        ChtGrafico.Series.Add("Dato1")
        ChtGrafico.Series("Dato1").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        ChtGrafico.Series("Dato1").Points.Add(100).LegendText = "AAA"
        ChtGrafico.Series("Dato1").Points.Add(80).LegendText = "BBB"
        ChtGrafico.Series("Dato1").Points.Add(120).LegendText = "CCC"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnColumna.Click
        ChtGrafico.Titles.Clear()
        ChtGrafico.Titles.Add("Productos")
        ChtGrafico.Series.Clear()
        ChtGrafico.Series.Add("Dato1")
        ChtGrafico.Series("Dato1").ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChtGrafico.Series("Dato1").Points.Add(15)
        ChtGrafico.Series("Dato1").Points.Add(25)
        ChtGrafico.Series.Add("Dato2")
        ChtGrafico.Series("Dato2").ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChtGrafico.Series("Dato2").Points.Add(19)
        ChtGrafico.Series("Dato2").Points.Add(23)
    End Sub
End Class
