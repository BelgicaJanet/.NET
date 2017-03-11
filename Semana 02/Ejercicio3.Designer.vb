<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio3
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
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listNota = New System.Windows.Forms.ListBox()
        Me.lbltxt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPuntaje = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(63, 31)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(100, 20)
        Me.txtNota.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(184, 27)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lista de Notas"
        '
        'listNota
        '
        Me.listNota.FormattingEnabled = True
        Me.listNota.Location = New System.Drawing.Point(32, 95)
        Me.listNota.Name = "listNota"
        Me.listNota.Size = New System.Drawing.Size(120, 108)
        Me.listNota.TabIndex = 4
        '
        'lbltxt
        '
        Me.lbltxt.AutoSize = True
        Me.lbltxt.Location = New System.Drawing.Point(49, 224)
        Me.lbltxt.Name = "lbltxt"
        Me.lbltxt.Size = New System.Drawing.Size(40, 13)
        Me.lbltxt.TabIndex = 5
        Me.lbltxt.Text = "lbltexto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Promedio"
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(241, 105)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(100, 20)
        Me.txtPromedio.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Puntaje"
        '
        'txtPuntaje
        '
        Me.txtPuntaje.Location = New System.Drawing.Point(241, 149)
        Me.txtPuntaje.Name = "txtPuntaje"
        Me.txtPuntaje.Size = New System.Drawing.Size(100, 20)
        Me.txtPuntaje.TabIndex = 9
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(253, 65)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 10
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Ejercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 261)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.txtPuntaje)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltxt)
        Me.Controls.Add(Me.listNota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ejercicio3"
        Me.Text = "Ejercicio3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents listNota As System.Windows.Forms.ListBox
    Friend WithEvents lbltxt As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPromedio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPuntaje As System.Windows.Forms.TextBox
    Friend WithEvents Calcular As System.Windows.Forms.Button
End Class
