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
        Me.ChtGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BtnTorta = New System.Windows.Forms.Button()
        Me.BtnColumna = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboCategoria = New System.Windows.Forms.ComboBox()
        CType(Me.ChtGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChtGrafico
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChtGrafico.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChtGrafico.Legends.Add(Legend1)
        Me.ChtGrafico.Location = New System.Drawing.Point(9, 66)
        Me.ChtGrafico.Name = "ChtGrafico"
        Me.ChtGrafico.Size = New System.Drawing.Size(598, 457)
        Me.ChtGrafico.TabIndex = 0
        Me.ChtGrafico.Text = "Chart1"
        '
        'BtnTorta
        '
        Me.BtnTorta.Location = New System.Drawing.Point(404, 16)
        Me.BtnTorta.Name = "BtnTorta"
        Me.BtnTorta.Size = New System.Drawing.Size(96, 34)
        Me.BtnTorta.TabIndex = 1
        Me.BtnTorta.Text = "Torta"
        Me.BtnTorta.UseVisualStyleBackColor = True
        '
        'BtnColumna
        '
        Me.BtnColumna.Location = New System.Drawing.Point(519, 15)
        Me.BtnColumna.Name = "BtnColumna"
        Me.BtnColumna.Size = New System.Drawing.Size(95, 35)
        Me.BtnColumna.TabIndex = 3
        Me.BtnColumna.Text = "Columna"
        Me.BtnColumna.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Categoria:"
        '
        'CboCategoria
        '
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(9, 29)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(162, 21)
        Me.CboCategoria.TabIndex = 6
        '
        'FrmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 526)
        Me.Controls.Add(Me.CboCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnColumna)
        Me.Controls.Add(Me.BtnTorta)
        Me.Controls.Add(Me.ChtGrafico)
        Me.Name = "FrmReporte"
        Me.Text = "FrmReporte"
        CType(Me.ChtGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChtGrafico As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents BtnTorta As System.Windows.Forms.Button
    Friend WithEvents BtnColumna As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboCategoria As System.Windows.Forms.ComboBox
End Class
