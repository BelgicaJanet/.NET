<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsoCheckedList
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
        Me.CklbDatos = New System.Windows.Forms.CheckedListBox()
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnElemSel = New System.Windows.Forms.Button()
        Me.TxtElementos = New System.Windows.Forms.TextBox()
        Me.TxtIndices = New System.Windows.Forms.TextBox()
        Me.BtnElimElem = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BtnLiberar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CklbDatos
        '
        Me.CklbDatos.CheckOnClick = True
        Me.CklbDatos.FormattingEnabled = True
        Me.CklbDatos.Location = New System.Drawing.Point(53, 44)
        Me.CklbDatos.Name = "CklbDatos"
        Me.CklbDatos.Size = New System.Drawing.Size(130, 229)
        Me.CklbDatos.TabIndex = 0
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(53, 6)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(69, 20)
        Me.TxtDato.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dato:"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(128, 6)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(74, 32)
        Me.BtnAgregar.TabIndex = 10
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnElemSel
        '
        Me.BtnElemSel.Location = New System.Drawing.Point(230, 187)
        Me.BtnElemSel.Name = "BtnElemSel"
        Me.BtnElemSel.Size = New System.Drawing.Size(84, 37)
        Me.BtnElemSel.TabIndex = 11
        Me.BtnElemSel.Text = "Elementos Seleccionados"
        Me.BtnElemSel.UseVisualStyleBackColor = True
        '
        'TxtElementos
        '
        Me.TxtElementos.Location = New System.Drawing.Point(330, 189)
        Me.TxtElementos.Multiline = True
        Me.TxtElementos.Name = "TxtElementos"
        Me.TxtElementos.Size = New System.Drawing.Size(263, 39)
        Me.TxtElementos.TabIndex = 12
        '
        'TxtIndices
        '
        Me.TxtIndices.Location = New System.Drawing.Point(330, 234)
        Me.TxtIndices.Multiline = True
        Me.TxtIndices.Name = "TxtIndices"
        Me.TxtIndices.Size = New System.Drawing.Size(263, 39)
        Me.TxtIndices.TabIndex = 13
        '
        'BtnElimElem
        '
        Me.BtnElimElem.Location = New System.Drawing.Point(230, 131)
        Me.BtnElimElem.Name = "BtnElimElem"
        Me.BtnElimElem.Size = New System.Drawing.Size(84, 37)
        Me.BtnElimElem.TabIndex = 14
        Me.BtnElimElem.Text = "Eliminar Elementos"
        Me.BtnElimElem.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Location = New System.Drawing.Point(230, 44)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(84, 37)
        Me.BtnSeleccionar.TabIndex = 15
        Me.BtnSeleccionar.Text = "Seleccionar Elemento"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Location = New System.Drawing.Point(230, 88)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(84, 37)
        Me.BtnLiberar.TabIndex = 16
        Me.BtnLiberar.Text = "Liberar Elemento"
        Me.BtnLiberar.UseVisualStyleBackColor = True
        '
        'FrmUsoCheckedList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 281)
        Me.Controls.Add(Me.BtnLiberar)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.BtnElimElem)
        Me.Controls.Add(Me.TxtIndices)
        Me.Controls.Add(Me.TxtElementos)
        Me.Controls.Add(Me.BtnElemSel)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDato)
        Me.Controls.Add(Me.CklbDatos)
        Me.Name = "FrmUsoCheckedList"
        Me.Text = "FrmUsoCheckedList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CklbDatos As System.Windows.Forms.CheckedListBox
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnElemSel As System.Windows.Forms.Button
    Friend WithEvents TxtElementos As System.Windows.Forms.TextBox
    Friend WithEvents TxtIndices As System.Windows.Forms.TextBox
    Friend WithEvents BtnElimElem As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnLiberar As System.Windows.Forms.Button
End Class
