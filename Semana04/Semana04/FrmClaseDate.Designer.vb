<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClaseDate
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
        Me.BtnCapturar = New System.Windows.Forms.Button()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDia = New System.Windows.Forms.TextBox()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtSegundos = New System.Windows.Forms.TextBox()
        Me.txtMinutos = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt5diasD = New System.Windows.Forms.TextBox()
        Me.txt4h = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt3Antes = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha"
        '
        'BtnCapturar
        '
        Me.BtnCapturar.Location = New System.Drawing.Point(283, 9)
        Me.BtnCapturar.Name = "BtnCapturar"
        Me.BtnCapturar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCapturar.TabIndex = 4
        Me.BtnCapturar.Text = "Capturar"
        Me.BtnCapturar.UseVisualStyleBackColor = True
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(68, 12)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(199, 20)
        Me.TxtFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DIA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "MES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "AÑO"
        '
        'txtDia
        '
        Me.txtDia.Location = New System.Drawing.Point(68, 58)
        Me.txtDia.Name = "txtDia"
        Me.txtDia.Size = New System.Drawing.Size(100, 20)
        Me.txtDia.TabIndex = 9
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(68, 92)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 10
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(68, 124)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(100, 20)
        Me.txtAno.TabIndex = 11
        '
        'txtSegundos
        '
        Me.txtSegundos.Location = New System.Drawing.Point(283, 124)
        Me.txtSegundos.Name = "txtSegundos"
        Me.txtSegundos.Size = New System.Drawing.Size(100, 20)
        Me.txtSegundos.TabIndex = 17
        '
        'txtMinutos
        '
        Me.txtMinutos.Location = New System.Drawing.Point(283, 92)
        Me.txtMinutos.Name = "txtMinutos"
        Me.txtMinutos.Size = New System.Drawing.Size(100, 20)
        Me.txtMinutos.TabIndex = 16
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(283, 58)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(100, 20)
        Me.txtHora.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SEGUNDOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(205, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "MINUTOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(205, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "HORA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "FECHA 5 DIAS DESPUES"
        '
        'txt5diasD
        '
        Me.txt5diasD.Location = New System.Drawing.Point(227, 170)
        Me.txt5diasD.Name = "txt5diasD"
        Me.txt5diasD.Size = New System.Drawing.Size(100, 20)
        Me.txt5diasD.TabIndex = 19
        '
        'txt4h
        '
        Me.txt4h.Location = New System.Drawing.Point(227, 196)
        Me.txt4h.Name = "txt4h"
        Me.txt4h.Size = New System.Drawing.Size(100, 20)
        Me.txt4h.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(64, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "FECHA 4 HORAS DESPUES"
        '
        'txt3Antes
        '
        Me.txt3Antes.Location = New System.Drawing.Point(227, 222)
        Me.txt3Antes.Name = "txt3Antes"
        Me.txt3Antes.Size = New System.Drawing.Size(100, 20)
        Me.txt3Antes.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(64, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "FECHA 3 DIAS ANTES"
        '
        'FrmClaseDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 309)
        Me.Controls.Add(Me.txt3Antes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt4h)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt5diasD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSegundos)
        Me.Controls.Add(Me.txtMinutos)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.txtDia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCapturar)
        Me.Controls.Add(Me.TxtFecha)
        Me.Name = "FrmClaseDate"
        Me.Text = "FrmClaseDate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCapturar As System.Windows.Forms.Button
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDia As System.Windows.Forms.TextBox
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundos As System.Windows.Forms.TextBox
    Friend WithEvents txtMinutos As System.Windows.Forms.TextBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt5diasD As System.Windows.Forms.TextBox
    Friend WithEvents txt4h As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt3Antes As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
