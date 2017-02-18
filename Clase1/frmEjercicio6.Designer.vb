<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio6
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
        Me.Numero1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.btnAccion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Numero1
        '
        Me.Numero1.AutoSize = True
        Me.Numero1.Location = New System.Drawing.Point(28, 35)
        Me.Numero1.Name = "Numero1"
        Me.Numero1.Size = New System.Drawing.Size(50, 13)
        Me.Numero1.TabIndex = 0
        Me.Numero1.Text = "Numero1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero2"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(108, 35)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 2
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(108, 79)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 3
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Location = New System.Drawing.Point(31, 133)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(0, 13)
        Me.lblresult.TabIndex = 4
        '
        'btnAccion
        '
        Me.btnAccion.Location = New System.Drawing.Point(108, 193)
        Me.btnAccion.Name = "btnAccion"
        Me.btnAccion.Size = New System.Drawing.Size(75, 23)
        Me.btnAccion.TabIndex = 5
        Me.btnAccion.Text = "Button1"
        Me.btnAccion.UseVisualStyleBackColor = True
        '
        'frmEjercicio6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnAccion)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Numero1)
        Me.Name = "frmEjercicio6"
        Me.Text = "frmEjercicio6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Numero1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents btnAccion As System.Windows.Forms.Button
End Class
