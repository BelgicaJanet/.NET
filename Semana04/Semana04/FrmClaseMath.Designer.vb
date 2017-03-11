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
        Me.BtnGenrar.Location = New System.Drawing.Point(160, 23)
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
        'FrmClaseMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 358)
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
End Class
