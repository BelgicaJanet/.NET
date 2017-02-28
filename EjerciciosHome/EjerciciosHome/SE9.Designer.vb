<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SE9
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
        Me.txtDeposito = New System.Windows.Forms.TextBox()
        Me.txtComputacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAdministracion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContabilidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiseño = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deposito"
        '
        'txtDeposito
        '
        Me.txtDeposito.Location = New System.Drawing.Point(107, 35)
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.Size = New System.Drawing.Size(100, 20)
        Me.txtDeposito.TabIndex = 1
        '
        'txtComputacion
        '
        Me.txtComputacion.Location = New System.Drawing.Point(107, 76)
        Me.txtComputacion.Name = "txtComputacion"
        Me.txtComputacion.Size = New System.Drawing.Size(100, 20)
        Me.txtComputacion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Computacion"
        '
        'txtAdministracion
        '
        Me.txtAdministracion.Location = New System.Drawing.Point(107, 102)
        Me.txtAdministracion.Name = "txtAdministracion"
        Me.txtAdministracion.Size = New System.Drawing.Size(100, 20)
        Me.txtAdministracion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Administracion"
        '
        'txtContabilidad
        '
        Me.txtContabilidad.Location = New System.Drawing.Point(107, 128)
        Me.txtContabilidad.Name = "txtContabilidad"
        Me.txtContabilidad.Size = New System.Drawing.Size(100, 20)
        Me.txtContabilidad.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contabilidad"
        '
        'txtDiseño
        '
        Me.txtDiseño.Location = New System.Drawing.Point(107, 154)
        Me.txtDiseño.Name = "txtDiseño"
        Me.txtDiseño.Size = New System.Drawing.Size(100, 20)
        Me.txtDiseño.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Diseño"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(185, 195)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calculadora"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'SE9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtDiseño)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtContabilidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdministracion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtComputacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDeposito)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SE9"
        Me.Text = "SE9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDeposito As TextBox
    Friend WithEvents txtComputacion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdministracion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContabilidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDiseño As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalcular As Button
End Class
