<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CD2
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
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRemuneracion = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.checkbono = New System.Windows.Forms.CheckBox()
        Me.checkhijo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sueldo"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(75, 33)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Remuneracion Total"
        '
        'txtRemuneracion
        '
        Me.txtRemuneracion.Location = New System.Drawing.Point(151, 151)
        Me.txtRemuneracion.Name = "txtRemuneracion"
        Me.txtRemuneracion.Size = New System.Drawing.Size(100, 20)
        Me.txtRemuneracion.TabIndex = 5
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(176, 75)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(176, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'checkbono
        '
        Me.checkbono.AutoSize = True
        Me.checkbono.Location = New System.Drawing.Point(33, 80)
        Me.checkbono.Name = "checkbono"
        Me.checkbono.Size = New System.Drawing.Size(51, 17)
        Me.checkbono.TabIndex = 8
        Me.checkbono.Text = "Bono"
        Me.checkbono.UseVisualStyleBackColor = True
        '
        'checkhijo
        '
        Me.checkhijo.AutoSize = True
        Me.checkhijo.Location = New System.Drawing.Point(33, 103)
        Me.checkhijo.Name = "checkhijo"
        Me.checkhijo.Size = New System.Drawing.Size(49, 17)
        Me.checkhijo.TabIndex = 9
        Me.checkhijo.Text = "Hijos"
        Me.checkhijo.UseVisualStyleBackColor = True
        '
        'CD2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 200)
        Me.Controls.Add(Me.checkhijo)
        Me.Controls.Add(Me.checkbono)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtRemuneracion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CD2"
        Me.Text = "CD2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRemuneracion As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents checkbono As CheckBox
    Friend WithEvents checkhijo As CheckBox
End Class
