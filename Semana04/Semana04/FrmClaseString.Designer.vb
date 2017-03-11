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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMayuscula = New System.Windows.Forms.TextBox()
        Me.Centro = New System.Windows.Forms.Label()
        Me.txtCentro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMinuscula = New System.Windows.Forms.TextBox()
        Me.lstCaracteres = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrueba = New System.Windows.Forms.TextBox()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mayuscula"
        '
        'txtMayuscula
        '
        Me.txtMayuscula.Location = New System.Drawing.Point(74, 55)
        Me.txtMayuscula.Name = "txtMayuscula"
        Me.txtMayuscula.Size = New System.Drawing.Size(198, 20)
        Me.txtMayuscula.TabIndex = 6
        '
        'Centro
        '
        Me.Centro.AutoSize = True
        Me.Centro.Location = New System.Drawing.Point(10, 97)
        Me.Centro.Name = "Centro"
        Me.Centro.Size = New System.Drawing.Size(38, 13)
        Me.Centro.TabIndex = 9
        Me.Centro.Text = "Centro"
        '
        'txtCentro
        '
        Me.txtCentro.Location = New System.Drawing.Point(74, 94)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.Size = New System.Drawing.Size(198, 20)
        Me.txtCentro.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Minuscula"
        '
        'txtMinuscula
        '
        Me.txtMinuscula.Location = New System.Drawing.Point(74, 131)
        Me.txtMinuscula.Name = "txtMinuscula"
        Me.txtMinuscula.Size = New System.Drawing.Size(198, 20)
        Me.txtMinuscula.TabIndex = 10
        '
        'lstCaracteres
        '
        Me.lstCaracteres.FormattingEnabled = True
        Me.lstCaracteres.Location = New System.Drawing.Point(283, 39)
        Me.lstCaracteres.Name = "lstCaracteres"
        Me.lstCaracteres.Size = New System.Drawing.Size(89, 251)
        Me.lstCaracteres.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Prueba"
        '
        'txtPrueba
        '
        Me.txtPrueba.Location = New System.Drawing.Point(74, 175)
        Me.txtPrueba.Name = "txtPrueba"
        Me.txtPrueba.Size = New System.Drawing.Size(198, 20)
        Me.txtPrueba.TabIndex = 13
        '
        'FrmClaseString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 313)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrueba)
        Me.Controls.Add(Me.lstCaracteres)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMinuscula)
        Me.Controls.Add(Me.Centro)
        Me.Controls.Add(Me.txtCentro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMayuscula)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMayuscula As System.Windows.Forms.TextBox
    Friend WithEvents Centro As System.Windows.Forms.Label
    Friend WithEvents txtCentro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMinuscula As System.Windows.Forms.TextBox
    Friend WithEvents lstCaracteres As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPrueba As System.Windows.Forms.TextBox
End Class
