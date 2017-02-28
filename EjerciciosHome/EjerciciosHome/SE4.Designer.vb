<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SE4
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLado = New System.Windows.Forms.TextBox()
        Me.txtDiametro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPeriemtro = New System.Windows.Forms.TextBox()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtDiametro2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diametro"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtLado
        '
        Me.txtLado.Location = New System.Drawing.Point(114, 34)
        Me.txtLado.Name = "txtLado"
        Me.txtLado.Size = New System.Drawing.Size(100, 20)
        Me.txtLado.TabIndex = 2
        '
        'txtDiametro
        '
        Me.txtDiametro.Location = New System.Drawing.Point(114, 70)
        Me.txtDiametro.Name = "txtDiametro"
        Me.txtDiametro.Size = New System.Drawing.Size(100, 20)
        Me.txtDiametro.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Perimetro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Area"
        '
        'txtPeriemtro
        '
        Me.txtPeriemtro.Location = New System.Drawing.Point(113, 142)
        Me.txtPeriemtro.Name = "txtPeriemtro"
        Me.txtPeriemtro.Size = New System.Drawing.Size(100, 20)
        Me.txtPeriemtro.TabIndex = 6
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(113, 174)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(100, 20)
        Me.txtArea.TabIndex = 7
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(138, 210)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtDiametro2
        '
        Me.txtDiametro2.Location = New System.Drawing.Point(114, 104)
        Me.txtDiametro2.Name = "txtDiametro2"
        Me.txtDiametro2.Size = New System.Drawing.Size(100, 20)
        Me.txtDiametro2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Diametro2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SE4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtDiametro2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtPeriemtro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDiametro)
        Me.Controls.Add(Me.txtLado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SE4"
        Me.Text = "SE4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLado As TextBox
    Friend WithEvents txtDiametro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPeriemtro As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtDiametro2 As TextBox
    Friend WithEvents Label5 As Label
End Class
