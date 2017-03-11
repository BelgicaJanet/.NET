<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TablasMaestrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuConsultaProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsslUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsbProductos = New System.Windows.Forms.ToolStripButton()
        Me.TsbConsultaProductos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TablasMaestrasToolStripMenuItem, Me.ProcesoToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TablasMaestrasToolStripMenuItem
        '
        Me.TablasMaestrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuProductos, Me.ToolStripMenuItem1, Me.MnuSalir})
        Me.TablasMaestrasToolStripMenuItem.Name = "TablasMaestrasToolStripMenuItem"
        Me.TablasMaestrasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.TablasMaestrasToolStripMenuItem.Text = "Maestros"
        '
        'MnuProductos
        '
        Me.MnuProductos.Image = CType(resources.GetObject("MnuProductos.Image"), System.Drawing.Image)
        Me.MnuProductos.Name = "MnuProductos"
        Me.MnuProductos.Size = New System.Drawing.Size(128, 22)
        Me.MnuProductos.Text = "Productos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(125, 6)
        '
        'MnuSalir
        '
        Me.MnuSalir.Image = CType(resources.GetObject("MnuSalir.Image"), System.Drawing.Image)
        Me.MnuSalir.Name = "MnuSalir"
        Me.MnuSalir.Size = New System.Drawing.Size(128, 22)
        Me.MnuSalir.Text = "Salir"
        '
        'ProcesoToolStripMenuItem
        '
        Me.ProcesoToolStripMenuItem.Name = "ProcesoToolStripMenuItem"
        Me.ProcesoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProcesoToolStripMenuItem.Text = "Procesos"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuConsultaProductos})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'MnuConsultaProductos
        '
        Me.MnuConsultaProductos.Image = CType(resources.GetObject("MnuConsultaProductos.Image"), System.Drawing.Image)
        Me.MnuConsultaProductos.Name = "MnuConsultaProductos"
        Me.MnuConsultaProductos.Size = New System.Drawing.Size(152, 22)
        Me.MnuConsultaProductos.Text = "Productos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsslUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 324)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(511, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsslUsuario
        '
        Me.TsslUsuario.AutoSize = False
        Me.TsslUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TsslUsuario.Name = "TsslUsuario"
        Me.TsslUsuario.Size = New System.Drawing.Size(200, 17)
        Me.TsslUsuario.Text = "Usuario: "
        Me.TsslUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbProductos, Me.TsbConsultaProductos, Me.ToolStripSeparator1, Me.TsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(511, 39)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsbProductos
        '
        Me.TsbProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbProductos.Image = CType(resources.GetObject("TsbProductos.Image"), System.Drawing.Image)
        Me.TsbProductos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbProductos.Name = "TsbProductos"
        Me.TsbProductos.Size = New System.Drawing.Size(36, 36)
        Me.TsbProductos.Text = "ToolStripButton1"
        Me.TsbProductos.ToolTipText = "Maestro de Productos"
        '
        'TsbConsultaProductos
        '
        Me.TsbConsultaProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbConsultaProductos.Image = CType(resources.GetObject("TsbConsultaProductos.Image"), System.Drawing.Image)
        Me.TsbConsultaProductos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbConsultaProductos.Name = "TsbConsultaProductos"
        Me.TsbConsultaProductos.Size = New System.Drawing.Size(36, 36)
        Me.TsbConsultaProductos.Text = "ToolStripButton2"
        Me.TsbConsultaProductos.ToolTipText = "Consulta de Productos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'TsbSalir
        '
        Me.TsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbSalir.Image = CType(resources.GetObject("TsbSalir.Image"), System.Drawing.Image)
        Me.TsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSalir.Name = "TsbSalir"
        Me.TsbSalir.Size = New System.Drawing.Size(36, 36)
        Me.TsbSalir.Text = "ToolStripButton3"
        Me.TsbSalir.ToolTipText = "Salir del Sistema"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 346)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "Sistema de Gestión"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TablasMaestrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuConsultaProductos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TsslUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TsbProductos As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbConsultaProductos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsbSalir As System.Windows.Forms.ToolStripButton
End Class
