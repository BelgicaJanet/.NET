<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio4
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInv1 = New System.Windows.Forms.TextBox()
        Me.txtInv2 = New System.Windows.Forms.TextBox()
        Me.txtInv3 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtresul1 = New System.Windows.Forms.TextBox()
        Me.txtresul2 = New System.Windows.Forms.TextBox()
        Me.txtresul3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inversion A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inversion B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Inversion C"
        '
        'txtInv1
        '
        Me.txtInv1.Location = New System.Drawing.Point(102, 22)
        Me.txtInv1.Name = "txtInv1"
        Me.txtInv1.Size = New System.Drawing.Size(100, 20)
        Me.txtInv1.TabIndex = 3
        '
        'txtInv2
        '
        Me.txtInv2.Location = New System.Drawing.Point(102, 68)
        Me.txtInv2.Name = "txtInv2"
        Me.txtInv2.Size = New System.Drawing.Size(100, 20)
        Me.txtInv2.TabIndex = 4
        '
        'txtInv3
        '
        Me.txtInv3.Location = New System.Drawing.Point(102, 121)
        Me.txtInv3.Name = "txtInv3"
        Me.txtInv3.Size = New System.Drawing.Size(100, 20)
        Me.txtInv3.TabIndex = 5
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(194, 173)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtresul1
        '
        Me.txtresul1.Location = New System.Drawing.Point(264, 22)
        Me.txtresul1.Name = "txtresul1"
        Me.txtresul1.Size = New System.Drawing.Size(100, 20)
        Me.txtresul1.TabIndex = 7
        '
        'txtresul2
        '
        Me.txtresul2.Location = New System.Drawing.Point(264, 68)
        Me.txtresul2.Name = "txtresul2"
        Me.txtresul2.Size = New System.Drawing.Size(100, 20)
        Me.txtresul2.TabIndex = 8
        '
        'txtresul3
        '
        Me.txtresul3.Location = New System.Drawing.Point(264, 121)
        Me.txtresul3.Name = "txtresul3"
        Me.txtresul3.Size = New System.Drawing.Size(100, 20)
        Me.txtresul3.TabIndex = 9
        '
        'frmEjercicio4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 262)
        Me.Controls.Add(Me.txtresul3)
        Me.Controls.Add(Me.txtresul2)
        Me.Controls.Add(Me.txtresul1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtInv3)
        Me.Controls.Add(Me.txtInv2)
        Me.Controls.Add(Me.txtInv1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEjercicio4"
        Me.Text = "frmEjercicio4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInv1 As System.Windows.Forms.TextBox
    Friend WithEvents txtInv2 As System.Windows.Forms.TextBox
    Friend WithEvents txtInv3 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents txtresul1 As System.Windows.Forms.TextBox
    Friend WithEvents txtresul2 As System.Windows.Forms.TextBox
    Friend WithEvents txtresul3 As System.Windows.Forms.TextBox
End Class
