<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio7
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
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.lbltext = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero 1"
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(116, 32)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero1.TabIndex = 2
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(89, 103)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(75, 23)
        Me.btnAccion.TabIndex = 4
        Me.btnAccion.Text = "Button1"
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Location = New System.Drawing.Point(31, 175)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(0, 13)
        Me.lbltext.TabIndex = 5
        '
        'frmEjercicio7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbltext)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEjercicio7"
        Me.Text = "frmEjercicio7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumero1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAccion As System.Windows.Forms.Button
    Friend WithEvents lbltext As System.Windows.Forms.Label
End Class
