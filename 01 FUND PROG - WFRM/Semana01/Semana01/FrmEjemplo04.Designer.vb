<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjemplo04
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
        Me.RbtOpcion01 = New System.Windows.Forms.RadioButton()
        Me.RbtOpcion02 = New System.Windows.Forms.RadioButton()
        Me.RbtOpcion03 = New System.Windows.Forms.RadioButton()
        Me.ChkOpcional = New System.Windows.Forms.CheckBox()
        Me.BtnVerificarRbt = New System.Windows.Forms.Button()
        Me.BtnVerificarChk = New System.Windows.Forms.Button()
        Me.BtnLimpiarObj = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RbtOpcion01
        '
        Me.RbtOpcion01.AutoSize = True
        Me.RbtOpcion01.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtOpcion01.Location = New System.Drawing.Point(38, 12)
        Me.RbtOpcion01.Name = "RbtOpcion01"
        Me.RbtOpcion01.Size = New System.Drawing.Size(89, 22)
        Me.RbtOpcion01.TabIndex = 0
        Me.RbtOpcion01.Text = "Opción 1"
        Me.RbtOpcion01.UseVisualStyleBackColor = True
        '
        'RbtOpcion02
        '
        Me.RbtOpcion02.AutoSize = True
        Me.RbtOpcion02.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtOpcion02.Location = New System.Drawing.Point(38, 43)
        Me.RbtOpcion02.Name = "RbtOpcion02"
        Me.RbtOpcion02.Size = New System.Drawing.Size(89, 22)
        Me.RbtOpcion02.TabIndex = 1
        Me.RbtOpcion02.Text = "Opción 2"
        Me.RbtOpcion02.UseVisualStyleBackColor = True
        '
        'RbtOpcion03
        '
        Me.RbtOpcion03.AutoSize = True
        Me.RbtOpcion03.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbtOpcion03.Location = New System.Drawing.Point(38, 77)
        Me.RbtOpcion03.Name = "RbtOpcion03"
        Me.RbtOpcion03.Size = New System.Drawing.Size(89, 22)
        Me.RbtOpcion03.TabIndex = 2
        Me.RbtOpcion03.Text = "Opción 3"
        Me.RbtOpcion03.UseVisualStyleBackColor = True
        '
        'ChkOpcional
        '
        Me.ChkOpcional.AutoSize = True
        Me.ChkOpcional.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkOpcional.Location = New System.Drawing.Point(38, 140)
        Me.ChkOpcional.Name = "ChkOpcional"
        Me.ChkOpcional.Size = New System.Drawing.Size(89, 22)
        Me.ChkOpcional.TabIndex = 3
        Me.ChkOpcional.Text = "Opcional"
        Me.ChkOpcional.UseVisualStyleBackColor = True
        '
        'BtnVerificarRbt
        '
        Me.BtnVerificarRbt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificarRbt.Location = New System.Drawing.Point(245, 12)
        Me.BtnVerificarRbt.Name = "BtnVerificarRbt"
        Me.BtnVerificarRbt.Size = New System.Drawing.Size(141, 68)
        Me.BtnVerificarRbt.TabIndex = 4
        Me.BtnVerificarRbt.Text = "Verificar RadioButton"
        Me.BtnVerificarRbt.UseVisualStyleBackColor = True
        '
        'BtnVerificarChk
        '
        Me.BtnVerificarChk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerificarChk.Location = New System.Drawing.Point(245, 140)
        Me.BtnVerificarChk.Name = "BtnVerificarChk"
        Me.BtnVerificarChk.Size = New System.Drawing.Size(141, 68)
        Me.BtnVerificarChk.TabIndex = 5
        Me.BtnVerificarChk.Text = "Verificar CheckBox"
        Me.BtnVerificarChk.UseVisualStyleBackColor = True
        '
        'BtnLimpiarObj
        '
        Me.BtnLimpiarObj.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiarObj.Location = New System.Drawing.Point(38, 199)
        Me.BtnLimpiarObj.Name = "BtnLimpiarObj"
        Me.BtnLimpiarObj.Size = New System.Drawing.Size(141, 68)
        Me.BtnLimpiarObj.TabIndex = 6
        Me.BtnLimpiarObj.Text = "Limpiar Objetos"
        Me.BtnLimpiarObj.UseVisualStyleBackColor = True
        '
        'FrmEjemplo04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 290)
        Me.Controls.Add(Me.BtnLimpiarObj)
        Me.Controls.Add(Me.BtnVerificarChk)
        Me.Controls.Add(Me.BtnVerificarRbt)
        Me.Controls.Add(Me.ChkOpcional)
        Me.Controls.Add(Me.RbtOpcion03)
        Me.Controls.Add(Me.RbtOpcion02)
        Me.Controls.Add(Me.RbtOpcion01)
        Me.Name = "FrmEjemplo04"
        Me.Text = "CONTROLES DE SELECCION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RbtOpcion01 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtOpcion02 As System.Windows.Forms.RadioButton
    Friend WithEvents RbtOpcion03 As System.Windows.Forms.RadioButton
    Friend WithEvents ChkOpcional As System.Windows.Forms.CheckBox
    Friend WithEvents BtnVerificarRbt As System.Windows.Forms.Button
    Friend WithEvents BtnVerificarChk As System.Windows.Forms.Button
    Friend WithEvents BtnLimpiarObj As System.Windows.Forms.Button
End Class
