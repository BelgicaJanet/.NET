<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaProd
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.RbtCantidad = New System.Windows.Forms.RadioButton()
        Me.RbtPrecio = New System.Windows.Forms.RadioButton()
        Me.RbtNombre = New System.Windows.Forms.RadioButton()
        Me.RbtCodigo = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LstCantidad = New System.Windows.Forms.ListBox()
        Me.LstPrecio = New System.Windows.Forms.ListBox()
        Me.LstProducto = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.TxtValor)
        Me.GroupBox1.Controls.Add(Me.LblDescripcion)
        Me.GroupBox1.Controls.Add(Me.RbtCantidad)
        Me.GroupBox1.Controls.Add(Me.RbtPrecio)
        Me.GroupBox1.Controls.Add(Me.RbtNombre)
        Me.GroupBox1.Controls.Add(Me.RbtCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(291, 74)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(115, 32)
        Me.BtnBuscar.TabIndex = 8
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(242, 41)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(164, 20)
        Me.TxtValor.TabIndex = 5
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(167, 44)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(43, 13)
        Me.LblDescripcion.TabIndex = 4
        Me.LblDescripcion.Text = "Código:"
        '
        'RbtCantidad
        '
        Me.RbtCantidad.AutoSize = True
        Me.RbtCantidad.Location = New System.Drawing.Point(16, 89)
        Me.RbtCantidad.Name = "RbtCantidad"
        Me.RbtCantidad.Size = New System.Drawing.Size(67, 17)
        Me.RbtCantidad.TabIndex = 3
        Me.RbtCantidad.Text = "Cantidad"
        Me.RbtCantidad.UseVisualStyleBackColor = True
        '
        'RbtPrecio
        '
        Me.RbtPrecio.AutoSize = True
        Me.RbtPrecio.Location = New System.Drawing.Point(16, 66)
        Me.RbtPrecio.Name = "RbtPrecio"
        Me.RbtPrecio.Size = New System.Drawing.Size(55, 17)
        Me.RbtPrecio.TabIndex = 2
        Me.RbtPrecio.Text = "Precio"
        Me.RbtPrecio.UseVisualStyleBackColor = True
        '
        'RbtNombre
        '
        Me.RbtNombre.AutoSize = True
        Me.RbtNombre.Location = New System.Drawing.Point(16, 43)
        Me.RbtNombre.Name = "RbtNombre"
        Me.RbtNombre.Size = New System.Drawing.Size(62, 17)
        Me.RbtNombre.TabIndex = 1
        Me.RbtNombre.Text = "Nombre"
        Me.RbtNombre.UseVisualStyleBackColor = True
        '
        'RbtCodigo
        '
        Me.RbtCodigo.AutoSize = True
        Me.RbtCodigo.Checked = True
        Me.RbtCodigo.Location = New System.Drawing.Point(16, 20)
        Me.RbtCodigo.Name = "RbtCodigo"
        Me.RbtCodigo.Size = New System.Drawing.Size(58, 17)
        Me.RbtCodigo.TabIndex = 0
        Me.RbtCodigo.TabStop = True
        Me.RbtCodigo.Text = "Código"
        Me.RbtCodigo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LstCantidad)
        Me.GroupBox2.Controls.Add(Me.LstPrecio)
        Me.GroupBox2.Controls.Add(Me.LstProducto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(426, 266)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'LstCantidad
        '
        Me.LstCantidad.FormattingEnabled = True
        Me.LstCantidad.Location = New System.Drawing.Point(332, 41)
        Me.LstCantidad.Name = "LstCantidad"
        Me.LstCantidad.Size = New System.Drawing.Size(73, 212)
        Me.LstCantidad.TabIndex = 5
        '
        'LstPrecio
        '
        Me.LstPrecio.FormattingEnabled = True
        Me.LstPrecio.Location = New System.Drawing.Point(243, 41)
        Me.LstPrecio.Name = "LstPrecio"
        Me.LstPrecio.Size = New System.Drawing.Size(78, 212)
        Me.LstPrecio.TabIndex = 4
        '
        'LstProducto
        '
        Me.LstProducto.FormattingEnabled = True
        Me.LstProducto.Location = New System.Drawing.Point(18, 41)
        Me.LstProducto.Name = "LstProducto"
        Me.LstProducto.Size = New System.Drawing.Size(210, 212)
        Me.LstProducto.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Producto"
        '
        'FrmConsultaProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 415)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultaProd"
        Me.Text = "FrmConsultaProd"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents RbtCantidad As System.Windows.Forms.RadioButton
    Friend WithEvents RbtPrecio As System.Windows.Forms.RadioButton
    Friend WithEvents RbtNombre As System.Windows.Forms.RadioButton
    Friend WithEvents RbtCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LstCantidad As System.Windows.Forms.ListBox
    Friend WithEvents LstPrecio As System.Windows.Forms.ListBox
    Friend WithEvents LstProducto As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
