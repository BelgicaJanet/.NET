<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlado = New System.Windows.Forms.TextBox()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.txtperimetro = New System.Windows.Forms.TextBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Area"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Perimetro"
        '
        'txtlado
        '
        Me.txtlado.Location = New System.Drawing.Point(70, 28)
        Me.txtlado.Name = "txtlado"
        Me.txtlado.Size = New System.Drawing.Size(100, 20)
        Me.txtlado.TabIndex = 4
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(70, 57)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(100, 20)
        Me.txtarea.TabIndex = 5
        '
        'txtperimetro
        '
        Me.txtperimetro.Location = New System.Drawing.Point(70, 98)
        Me.txtperimetro.Name = "txtperimetro"
        Me.txtperimetro.Size = New System.Drawing.Size(100, 20)
        Me.txtperimetro.TabIndex = 6
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(108, 151)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 7
        Me.btnEjecutar.Text = "Button1"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.txtperimetro)
        Me.Controls.Add(Me.txtarea)
        Me.Controls.Add(Me.txtlado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtlado As System.Windows.Forms.TextBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents txtperimetro As System.Windows.Forms.TextBox
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button

End Class
