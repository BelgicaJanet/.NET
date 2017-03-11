<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClaseString
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
        Me.BtnGenrar = New System.Windows.Forms.Button()
        Me.TxtCadena = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cadena"
        '
        'BtnGenrar
        '
        Me.BtnGenrar.Location = New System.Drawing.Point(283, 10)
        Me.BtnGenrar.Name = "BtnGenrar"
        Me.BtnGenrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenrar.TabIndex = 4
        Me.BtnGenrar.Text = "Genarar"
        Me.BtnGenrar.UseVisualStyleBackColor = True
        '
        'TxtCadena
        '
        Me.TxtCadena.Location = New System.Drawing.Point(66, 12)
        Me.TxtCadena.Name = "TxtCadena"
        Me.TxtCadena.Size = New System.Drawing.Size(198, 20)
        Me.TxtCadena.TabIndex = 3
        '
        'FrmClaseString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 313)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGenrar)
        Me.Controls.Add(Me.TxtCadena)
        Me.Name = "FrmClaseString"
        Me.Text = "FrmClaseString"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGenrar As System.Windows.Forms.Button
    Friend WithEvents TxtCadena As System.Windows.Forms.TextBox
End Class
