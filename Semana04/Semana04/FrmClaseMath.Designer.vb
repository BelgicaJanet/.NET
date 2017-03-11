<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClaseMath
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
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.BtnGenrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMayor = New System.Windows.Forms.TextBox()
        Me.txtMenor = New System.Windows.Forms.TextBox()
        Me.txtPotencia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRaiz = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPI = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(68, 23)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(68, 20)
        Me.TxtNumero.TabIndex = 0
        '
        'BtnGenrar
        '
        Me.BtnGenrar.Location = New System.Drawing.Point(341, 20)
        Me.BtnGenrar.Name = "BtnGenrar"
        Me.BtnGenrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenrar.TabIndex = 1
        Me.BtnGenrar.Text = "Genarar"
        Me.BtnGenrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(153, 22)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(68, 20)
        Me.txtNum2.TabIndex = 3
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(242, 22)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(68, 20)
        Me.txtNum3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mayor Numero"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Menor Numero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Menor Numero al cuadrado"
        '
        'txtMayor
        '
        Me.txtMayor.Location = New System.Drawing.Point(183, 83)
        Me.txtMayor.Name = "txtMayor"
        Me.txtMayor.Size = New System.Drawing.Size(68, 20)
        Me.txtMayor.TabIndex = 8
        '
        'txtMenor
        '
        Me.txtMenor.Location = New System.Drawing.Point(183, 114)
        Me.txtMenor.Name = "txtMenor"
        Me.txtMenor.Size = New System.Drawing.Size(68, 20)
        Me.txtMenor.TabIndex = 9
        '
        'txtPotencia
        '
        Me.txtPotencia.Location = New System.Drawing.Point(183, 148)
        Me.txtPotencia.Name = "txtPotencia"
        Me.txtPotencia.Size = New System.Drawing.Size(68, 20)
        Me.txtPotencia.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Mayor numero raiz"
        '
        'txtRaiz
        '
        Me.txtRaiz.Location = New System.Drawing.Point(183, 183)
        Me.txtRaiz.Name = "txtRaiz"
        Me.txtRaiz.Size = New System.Drawing.Size(68, 20)
        Me.txtRaiz.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(289, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "PI"
        '
        'txtPI
        '
        Me.txtPI.Location = New System.Drawing.Point(312, 80)
        Me.txtPI.Name = "txtPI"
        Me.txtPI.Size = New System.Drawing.Size(68, 20)
        Me.txtPI.TabIndex = 14
        '
        'FrmClaseMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 358)
        Me.Controls.Add(Me.txtPI)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRaiz)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPotencia)
        Me.Controls.Add(Me.txtMenor)
        Me.Controls.Add(Me.txtMayor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNum3)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGenrar)
        Me.Controls.Add(Me.TxtNumero)
        Me.Name = "FrmClaseMath"
        Me.Text = "FrmClaseMath"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents BtnGenrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMayor As System.Windows.Forms.TextBox
    Friend WithEvents txtMenor As System.Windows.Forms.TextBox
    Friend WithEvents txtPotencia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRaiz As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPI As System.Windows.Forms.TextBox
End Class
