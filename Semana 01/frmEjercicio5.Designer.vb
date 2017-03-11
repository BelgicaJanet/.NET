<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio5
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
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.btnMayor = New System.Windows.Forms.Button()
        Me.lbltext = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero 2"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(109, 32)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 2
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(109, 70)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero2.TabIndex = 3
        '
        'btnMayor
        '
        Me.btnMayor.Location = New System.Drawing.Point(79, 111)
        Me.btnMayor.Name = "btnMayor"
        Me.btnMayor.Size = New System.Drawing.Size(75, 23)
        Me.btnMayor.TabIndex = 4
        Me.btnMayor.Text = "Button1"
        Me.btnMayor.UseVisualStyleBackColor = True
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Location = New System.Drawing.Point(30, 173)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(39, 13)
        Me.lbltext.TabIndex = 5
        Me.lbltext.Text = "Label3"
        '
        'frmEjercicio5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.btnMayor)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEjercicio5"
        Me.Text = "frmEjercicio5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero2 As System.Windows.Forms.TextBox
    Friend WithEvents btnMayor As System.Windows.Forms.Button
    Friend WithEvents lbltext As System.Windows.Forms.Label
End Class
