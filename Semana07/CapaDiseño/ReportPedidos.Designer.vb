<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPedidos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboDesde = New System.Windows.Forms.ComboBox()
        Me.comboHasta = New System.Windows.Forms.ComboBox()
        Me.comboUsuario = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnWord = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnText = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtro de Reportes"
        '
        'comboDesde
        '
        Me.comboDesde.FormattingEnabled = True
        Me.comboDesde.Location = New System.Drawing.Point(29, 43)
        Me.comboDesde.Name = "comboDesde"
        Me.comboDesde.Size = New System.Drawing.Size(121, 21)
        Me.comboDesde.TabIndex = 1
        '
        'comboHasta
        '
        Me.comboHasta.FormattingEnabled = True
        Me.comboHasta.Location = New System.Drawing.Point(29, 80)
        Me.comboHasta.Name = "comboHasta"
        Me.comboHasta.Size = New System.Drawing.Size(121, 21)
        Me.comboHasta.TabIndex = 2
        '
        'comboUsuario
        '
        Me.comboUsuario.FormattingEnabled = True
        Me.comboUsuario.Location = New System.Drawing.Point(177, 43)
        Me.comboUsuario.Name = "comboUsuario"
        Me.comboUsuario.Size = New System.Drawing.Size(85, 21)
        Me.comboUsuario.TabIndex = 3
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(298, 43)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(298, 66)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(407, 43)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 58)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(29, 125)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(471, 290)
        Me.ListBox1.TabIndex = 7
        '
        'btnWord
        '
        Me.btnWord.Location = New System.Drawing.Point(566, 43)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(93, 58)
        Me.btnWord.TabIndex = 8
        Me.btnWord.Text = "Exportar Word"
        Me.btnWord.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Location = New System.Drawing.Point(681, 43)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(93, 58)
        Me.btnExcel.TabIndex = 9
        Me.btnExcel.Text = "Exportar Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnText
        '
        Me.btnText.Location = New System.Drawing.Point(798, 43)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(93, 58)
        Me.btnText.TabIndex = 10
        Me.btnText.Text = "Exportar Texto"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(542, 242)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(369, 173)
        Me.TextBox1.TabIndex = 11
        '
        'ReportPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 436)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnWord)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.comboUsuario)
        Me.Controls.Add(Me.comboHasta)
        Me.Controls.Add(Me.comboDesde)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReportPedidos"
        Me.Text = "ReportPedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboDesde As System.Windows.Forms.ComboBox
    Friend WithEvents comboHasta As System.Windows.Forms.ComboBox
    Friend WithEvents comboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnWord As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnText As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
