<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsoList
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
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.LstDatos = New System.Windows.Forms.ListBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNroElem = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIndice = New System.Windows.Forms.TextBox()
        Me.TxtElemento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEliminarTodo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BtnLiberar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dato:"
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(52, 14)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(78, 20)
        Me.TxtDato.TabIndex = 3
        '
        'LstDatos
        '
        Me.LstDatos.FormattingEnabled = True
        Me.LstDatos.Location = New System.Drawing.Point(52, 50)
        Me.LstDatos.Name = "LstDatos"
        Me.LstDatos.Size = New System.Drawing.Size(158, 186)
        Me.LstDatos.TabIndex = 5
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(136, 12)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(74, 32)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "N° Elementos"
        '
        'LblNroElem
        '
        Me.LblNroElem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNroElem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNroElem.Location = New System.Drawing.Point(147, 249)
        Me.LblNroElem.Name = "LblNroElem"
        Me.LblNroElem.Size = New System.Drawing.Size(63, 15)
        Me.LblNroElem.TabIndex = 8
        Me.LblNroElem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtIndice)
        Me.GroupBox1.Controls.Add(Me.TxtElemento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 84)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elementos Seleccionado"
        '
        'TxtIndice
        '
        Me.TxtIndice.Location = New System.Drawing.Point(72, 51)
        Me.TxtIndice.Name = "TxtIndice"
        Me.TxtIndice.Size = New System.Drawing.Size(64, 20)
        Me.TxtIndice.TabIndex = 3
        '
        'TxtElemento
        '
        Me.TxtElemento.Location = New System.Drawing.Point(72, 19)
        Me.TxtElemento.Name = "TxtElemento"
        Me.TxtElemento.Size = New System.Drawing.Size(131, 20)
        Me.TxtElemento.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Indice:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Elemento:"
        '
        'BtnEliminarTodo
        '
        Me.BtnEliminarTodo.Location = New System.Drawing.Point(96, 287)
        Me.BtnEliminarTodo.Name = "BtnEliminarTodo"
        Me.BtnEliminarTodo.Size = New System.Drawing.Size(74, 44)
        Me.BtnEliminarTodo.TabIndex = 17
        Me.BtnEliminarTodo.Text = "Eliminar Todo"
        Me.BtnEliminarTodo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(16, 287)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(74, 44)
        Me.BtnEliminar.TabIndex = 16
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Location = New System.Drawing.Point(241, 125)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(84, 37)
        Me.BtnSeleccionar.TabIndex = 18
        Me.BtnSeleccionar.Text = "Seleccionar Elemento"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Location = New System.Drawing.Point(241, 179)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(84, 37)
        Me.BtnLiberar.TabIndex = 19
        Me.BtnLiberar.Text = "Liberar Elemento"
        Me.BtnLiberar.UseVisualStyleBackColor = True
        '
        'FrmUsoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 343)
        Me.Controls.Add(Me.BtnLiberar)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.BtnEliminarTodo)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblNroElem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.LstDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDato)
        Me.Name = "FrmUsoList"
        Me.Text = "FrmUsoListas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents LstDatos As System.Windows.Forms.ListBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblNroElem As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtIndice As System.Windows.Forms.TextBox
    Friend WithEvents TxtElemento As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminarTodo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnLiberar As System.Windows.Forms.Button

End Class
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsoList
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
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.LstDatos = New System.Windows.Forms.ListBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNroElem = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIndice = New System.Windows.Forms.TextBox()
        Me.TxtElemento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEliminarTodo = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BtnLiberar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dato:"
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(52, 14)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(78, 20)
        Me.TxtDato.TabIndex = 3
        '
        'LstDatos
        '
        Me.LstDatos.FormattingEnabled = True
        Me.LstDatos.Location = New System.Drawing.Point(52, 50)
        Me.LstDatos.Name = "LstDatos"
        Me.LstDatos.Size = New System.Drawing.Size(158, 186)
        Me.LstDatos.TabIndex = 5
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(136, 12)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(74, 32)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "N° Elementos"
        '
        'LblNroElem
        '
        Me.LblNroElem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNroElem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNroElem.Location = New System.Drawing.Point(147, 249)
        Me.LblNroElem.Name = "LblNroElem"
        Me.LblNroElem.Size = New System.Drawing.Size(63, 15)
        Me.LblNroElem.TabIndex = 8
        Me.LblNroElem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtIndice)
        Me.GroupBox1.Controls.Add(Me.TxtElemento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 84)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elementos Seleccionado"
        '
        'TxtIndice
        '
        Me.TxtIndice.Location = New System.Drawing.Point(72, 51)
        Me.TxtIndice.Name = "TxtIndice"
        Me.TxtIndice.Size = New System.Drawing.Size(64, 20)
        Me.TxtIndice.TabIndex = 3
        '
        'TxtElemento
        '
        Me.TxtElemento.Location = New System.Drawing.Point(72, 19)
        Me.TxtElemento.Name = "TxtElemento"
        Me.TxtElemento.Size = New System.Drawing.Size(131, 20)
        Me.TxtElemento.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Indice:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Elemento:"
        '
        'BtnEliminarTodo
        '
        Me.BtnEliminarTodo.Location = New System.Drawing.Point(96, 287)
        Me.BtnEliminarTodo.Name = "BtnEliminarTodo"
        Me.BtnEliminarTodo.Size = New System.Drawing.Size(74, 44)
        Me.BtnEliminarTodo.TabIndex = 17
        Me.BtnEliminarTodo.Text = "Eliminar Todo"
        Me.BtnEliminarTodo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(16, 287)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(74, 44)
        Me.BtnEliminar.TabIndex = 16
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Location = New System.Drawing.Point(241, 125)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(84, 37)
        Me.BtnSeleccionar.TabIndex = 18
        Me.BtnSeleccionar.Text = "Seleccionar Elemento"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Location = New System.Drawing.Point(241, 179)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(84, 37)
        Me.BtnLiberar.TabIndex = 19
        Me.BtnLiberar.Text = "Liberar Elemento"
        Me.BtnLiberar.UseVisualStyleBackColor = True
        '
        'FrmUsoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 343)
        Me.Controls.Add(Me.BtnLiberar)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.BtnEliminarTodo)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblNroElem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.LstDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDato)
        Me.Name = "FrmUsoList"
        Me.Text = "FrmUsoListas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents LstDatos As System.Windows.Forms.ListBox
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblNroElem As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtIndice As System.Windows.Forms.TextBox
    Friend WithEvents TxtElemento As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminarTodo As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnLiberar As System.Windows.Forms.Button

End Class
>>>>>>> 64b580890980be05fe093352e7379d408227b737
