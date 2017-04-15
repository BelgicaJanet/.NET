<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporte
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BtnTorta = New System.Windows.Forms.Button()
        Me.BtnColumna = New System.Windows.Forms.Button()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.charText = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.charText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTorta
        '
        Me.BtnTorta.Location = New System.Drawing.Point(257, 12)
        Me.BtnTorta.Name = "BtnTorta"
        Me.BtnTorta.Size = New System.Drawing.Size(96, 34)
        Me.BtnTorta.TabIndex = 2
        Me.BtnTorta.Text = "Torta"
        Me.BtnTorta.UseVisualStyleBackColor = True
        '
        'BtnColumna
        '
        Me.BtnColumna.Location = New System.Drawing.Point(359, 11)
        Me.BtnColumna.Name = "BtnColumna"
        Me.BtnColumna.Size = New System.Drawing.Size(95, 35)
        Me.BtnColumna.TabIndex = 4
        Me.BtnColumna.Text = "Columna"
        Me.BtnColumna.UseVisualStyleBackColor = True
        '
        'CboCategoria
        '
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(22, 25)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(162, 21)
        Me.CboCategoria.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Categoria:"
        '
        'charText
        '
        ChartArea1.Name = "ChartArea1"
        Me.charText.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.charText.Legends.Add(Legend1)
        Me.charText.Location = New System.Drawing.Point(22, 52)
        Me.charText.Name = "charText"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.charText.Series.Add(Series1)
        Me.charText.Size = New System.Drawing.Size(432, 300)
        Me.charText.TabIndex = 9
        Me.charText.Text = "Chart1"
        '
        'FrmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 360)
        Me.Controls.Add(Me.charText)
        Me.Controls.Add(Me.CboCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnColumna)
        Me.Controls.Add(Me.BtnTorta)
        Me.Name = "FrmReporte"
        Me.Text = "FrmReporte"
        CType(Me.charText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTorta As System.Windows.Forms.Button
    Friend WithEvents BtnColumna As System.Windows.Forms.Button
    Friend WithEvents CboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents charText As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
