<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ES1
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
        Me.Temperatura = New System.Windows.Forms.Label()
        Me.txtTemperatura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Temperatura
        '
        Me.Temperatura.AutoSize = True
        Me.Temperatura.Location = New System.Drawing.Point(23, 38)
        Me.Temperatura.Name = "Temperatura"
        Me.Temperatura.Size = New System.Drawing.Size(67, 13)
        Me.Temperatura.TabIndex = 0
        Me.Temperatura.Text = "Temperatura"
        '
        'txtTemperatura
        '
        Me.txtTemperatura.Location = New System.Drawing.Point(97, 38)
        Me.txtTemperatura.Name = "txtTemperatura"
        Me.txtTemperatura.Size = New System.Drawing.Size(100, 20)
        Me.txtTemperatura.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(97, 82)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 3
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(197, 123)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 4
        Me.Calcular.Text = "Button1"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'ES1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 163)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTemperatura)
        Me.Controls.Add(Me.Temperatura)
        Me.Name = "ES1"
        Me.Text = "ES1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Temperatura As Label
    Friend WithEvents txtTemperatura As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Calcular As Button
End Class
