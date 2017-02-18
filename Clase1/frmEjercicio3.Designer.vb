<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio3
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
        Me.txt1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtIGV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Location = New System.Drawing.Point(13, 25)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(50, 13)
        Me.txt1.TabIndex = 0
        Me.txt1.Text = "Producto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cantidad"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(82, 25)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtProducto.TabIndex = 2
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(82, 57)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Precio"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(82, 91)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(82, 126)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 6
        '
        'txtIGV
        '
        Me.txtIGV.Location = New System.Drawing.Point(82, 164)
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.Size = New System.Drawing.Size(100, 20)
        Me.txtIGV.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Importe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "IGV"
        '
        'txtotal
        '
        Me.txtotal.Location = New System.Drawing.Point(82, 203)
        Me.txtotal.Name = "txtotal"
        Me.txtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtotal.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "total"
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(95, 246)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 12
        Me.btncalcular.Text = "Button1"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'frmEjercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 290)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIGV)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt1)
        Me.Name = "frmEjercicio3"
        Me.Text = "frmEjercicio3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtIGV As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btncalcular As System.Windows.Forms.Button
End Class
