<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CD3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lstNota = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Curso"
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(54, 17)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(100, 20)
        Me.txtCurso.TabIndex = 1
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(54, 43)
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(100, 20)
        Me.txtNotas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Notas"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(160, 40)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lstNota
        '
        Me.lstNota.FormattingEnabled = True
        Me.lstNota.Location = New System.Drawing.Point(34, 79)
        Me.lstNota.Name = "lstNota"
        Me.lstNota.Size = New System.Drawing.Size(120, 121)
        Me.lstNota.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Promedio"
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(213, 94)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(52, 20)
        Me.txtPromedio.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(213, 126)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(52, 20)
        Me.txtEstado.TabIndex = 9
        '
        'CD3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstNota)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CD3"
        Me.Text = "CD3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstNota As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEstado As TextBox
End Class
