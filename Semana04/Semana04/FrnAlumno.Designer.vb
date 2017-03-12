<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrnAlumno
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApeP = New System.Windows.Forms.TextBox()
        Me.txtApeM = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtGeneral = New System.Windows.Forms.TextBox()
        Me.rdM = New System.Windows.Forms.RadioButton()
        Me.rdFeme = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido Paterno : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido Materno : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexo :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Edad : "
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(44, 234)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(164, 234)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 7
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(277, 234)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 22)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "DATOS ALUMNO"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(179, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(173, 20)
        Me.txtCodigo.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(179, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(173, 20)
        Me.txtNombre.TabIndex = 12
        '
        'txtApeP
        '
        Me.txtApeP.Location = New System.Drawing.Point(179, 86)
        Me.txtApeP.Name = "txtApeP"
        Me.txtApeP.Size = New System.Drawing.Size(173, 20)
        Me.txtApeP.TabIndex = 13
        '
        'txtApeM
        '
        Me.txtApeM.Location = New System.Drawing.Point(179, 120)
        Me.txtApeM.Name = "txtApeM"
        Me.txtApeM.Size = New System.Drawing.Size(173, 20)
        Me.txtApeM.TabIndex = 14
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(179, 185)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(173, 20)
        Me.txtEdad.TabIndex = 16
        '
        'txtGeneral
        '
        Me.txtGeneral.Location = New System.Drawing.Point(44, 299)
        Me.txtGeneral.Multiline = True
        Me.txtGeneral.Name = "txtGeneral"
        Me.txtGeneral.Size = New System.Drawing.Size(308, 100)
        Me.txtGeneral.TabIndex = 17
        '
        'rdM
        '
        Me.rdM.AutoSize = True
        Me.rdM.Location = New System.Drawing.Point(179, 157)
        Me.rdM.Name = "rdM"
        Me.rdM.Size = New System.Drawing.Size(73, 17)
        Me.rdM.TabIndex = 18
        Me.rdM.TabStop = True
        Me.rdM.Text = "Masculino"
        Me.rdM.UseVisualStyleBackColor = True
        '
        'rdFeme
        '
        Me.rdFeme.AutoSize = True
        Me.rdFeme.Location = New System.Drawing.Point(277, 157)
        Me.rdFeme.Name = "rdFeme"
        Me.rdFeme.Size = New System.Drawing.Size(71, 17)
        Me.rdFeme.TabIndex = 19
        Me.rdFeme.TabStop = True
        Me.rdFeme.Text = "Femenino"
        Me.rdFeme.UseVisualStyleBackColor = True
        '
        'FrnAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 428)
        Me.Controls.Add(Me.rdFeme)
        Me.Controls.Add(Me.rdM)
        Me.Controls.Add(Me.txtGeneral)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtApeM)
        Me.Controls.Add(Me.txtApeP)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrnAlumno"
        Me.Text = "FrnAlumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApeP As TextBox
    Friend WithEvents txtApeM As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtGeneral As TextBox
    Friend WithEvents rdM As RadioButton
    Friend WithEvents rdFeme As RadioButton
End Class
