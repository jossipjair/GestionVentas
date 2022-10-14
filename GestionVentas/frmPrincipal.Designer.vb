<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.mnsPrincipal = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MonedasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeCambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FormasDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlmacénToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadesDeMedidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TiposDeMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsOutlookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockDeNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 668)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1354, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'mnsPrincipal
        '
        Me.mnsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.UtilitariosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.mnsPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnsPrincipal.MdiWindowListItem = Me.PrincipalToolStripMenuItem
        Me.mnsPrincipal.Name = "mnsPrincipal"
        Me.mnsPrincipal.Size = New System.Drawing.Size(1354, 56)
        Me.mnsPrincipal.TabIndex = 2
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem1})
        Me.PrincipalToolStripMenuItem.Image = Global.GestionVentas.My.Resources.Resources._48px_Crystal_128_mymac
        Me.PrincipalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(113, 52)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem1.Text = "&Salir"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContabilidadToolStripMenuItem, Me.ToolStripMenuItem3, Me.AlmacénToolStripMenuItem, Me.ToolStripMenuItem5, Me.SistemaToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Image = Global.GestionVentas.My.Resources.Resources._48px_Crystal_Clear_action_db_add
        Me.MantenimientoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(149, 52)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'ContabilidadToolStripMenuItem
        '
        Me.ContabilidadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteProveedorToolStripMenuItem, Me.ToolStripMenuItem1, Me.MonedasToolStripMenuItem, Me.TipoDeCambioToolStripMenuItem, Me.ToolStripMenuItem2, Me.FormasDePagoToolStripMenuItem})
        Me.ContabilidadToolStripMenuItem.Name = "ContabilidadToolStripMenuItem"
        Me.ContabilidadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ContabilidadToolStripMenuItem.Text = "Contabilidad"
        '
        'ClienteProveedorToolStripMenuItem
        '
        Me.ClienteProveedorToolStripMenuItem.Name = "ClienteProveedorToolStripMenuItem"
        Me.ClienteProveedorToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ClienteProveedorToolStripMenuItem.Text = "Cliente - Proveedor"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(173, 6)
        '
        'MonedasToolStripMenuItem
        '
        Me.MonedasToolStripMenuItem.Name = "MonedasToolStripMenuItem"
        Me.MonedasToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.MonedasToolStripMenuItem.Text = "Monedas"
        '
        'TipoDeCambioToolStripMenuItem
        '
        Me.TipoDeCambioToolStripMenuItem.Name = "TipoDeCambioToolStripMenuItem"
        Me.TipoDeCambioToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.TipoDeCambioToolStripMenuItem.Text = "Tipo de Cambio"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(173, 6)
        '
        'FormasDePagoToolStripMenuItem
        '
        Me.FormasDePagoToolStripMenuItem.Name = "FormasDePagoToolStripMenuItem"
        Me.FormasDePagoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FormasDePagoToolStripMenuItem.Text = "Formas de Pago"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(149, 6)
        '
        'AlmacénToolStripMenuItem
        '
        Me.AlmacénToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnidadesDeMedidaToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.StocksToolStripMenuItem, Me.ToolStripMenuItem4, Me.SucursalesToolStripMenuItem, Me.AlmacenesToolStripMenuItem, Me.ToolStripMenuItem8, Me.TiposDeMovimientosToolStripMenuItem})
        Me.AlmacénToolStripMenuItem.Name = "AlmacénToolStripMenuItem"
        Me.AlmacénToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AlmacénToolStripMenuItem.Text = "Almacén"
        '
        'UnidadesDeMedidaToolStripMenuItem
        '
        Me.UnidadesDeMedidaToolStripMenuItem.Name = "UnidadesDeMedidaToolStripMenuItem"
        Me.UnidadesDeMedidaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.UnidadesDeMedidaToolStripMenuItem.Text = "Unidades de Medida"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(189, 6)
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'AlmacenesToolStripMenuItem
        '
        Me.AlmacenesToolStripMenuItem.Name = "AlmacenesToolStripMenuItem"
        Me.AlmacenesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AlmacenesToolStripMenuItem.Text = "Almacén"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(189, 6)
        '
        'TiposDeMovimientosToolStripMenuItem
        '
        Me.TiposDeMovimientosToolStripMenuItem.Name = "TiposDeMovimientosToolStripMenuItem"
        Me.TiposDeMovimientosToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.TiposDeMovimientosToolStripMenuItem.Text = "Tipos de Movimientos"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(149, 6)
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaisToolStripMenuItem, Me.ToolStripMenuItem6, Me.EstadosToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'PaisToolStripMenuItem
        '
        Me.PaisToolStripMenuItem.Name = "PaisToolStripMenuItem"
        Me.PaisToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.PaisToolStripMenuItem.Text = "Pais"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(188, 6)
        '
        'EstadosToolStripMenuItem
        '
        Me.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem"
        Me.EstadosToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EstadosToolStripMenuItem.Text = "Estado de Documento"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Image = Global.GestionVentas.My.Resources.Resources._48px_Crystal_Clear_app_kwrite
        Me.MovimientosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(137, 52)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Image = Global.GestionVentas.My.Resources.Resources._48px_Crystal_Clear_app_kappfinder
        Me.ConsultasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(119, 52)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Image = Global.GestionVentas.My.Resources.Resources._48px_Crystal_Clear_action_fileprint
        Me.ReportesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(113, 52)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'UtilitariosToolStripMenuItem
        '
        Me.UtilitariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsOutlookToolStripMenuItem, Me.MsExcelToolStripMenuItem, Me.MsWordToolStripMenuItem, Me.ToolStripMenuItem7, Me.CalculadoraToolStripMenuItem, Me.BlockDeNotasToolStripMenuItem, Me.ToolStripMenuItem9, Me.AcercaDeToolStripMenuItem})
        Me.UtilitariosToolStripMenuItem.Image = Global.GestionVentas.My.Resources.Resources._48px_Crystal_Clear_app_Network_Connection_Manager
        Me.UtilitariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UtilitariosToolStripMenuItem.Name = "UtilitariosToolStripMenuItem"
        Me.UtilitariosToolStripMenuItem.Size = New System.Drawing.Size(117, 52)
        Me.UtilitariosToolStripMenuItem.Text = "Utilitarios"
        '
        'MsOutlookToolStripMenuItem
        '
        Me.MsOutlookToolStripMenuItem.Name = "MsOutlookToolStripMenuItem"
        Me.MsOutlookToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MsOutlookToolStripMenuItem.Text = "Ms Outlook"
        '
        'MsExcelToolStripMenuItem
        '
        Me.MsExcelToolStripMenuItem.Name = "MsExcelToolStripMenuItem"
        Me.MsExcelToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MsExcelToolStripMenuItem.Text = "Ms Excel"
        '
        'MsWordToolStripMenuItem
        '
        Me.MsWordToolStripMenuItem.Name = "MsWordToolStripMenuItem"
        Me.MsWordToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.MsWordToolStripMenuItem.Text = "Ms Word"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(148, 6)
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'BlockDeNotasToolStripMenuItem
        '
        Me.BlockDeNotasToolStripMenuItem.Name = "BlockDeNotasToolStripMenuItem"
        Me.BlockDeNotasToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.BlockDeNotasToolStripMenuItem.Text = "Block de notas"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(148, 6)
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.GestionVentas.My.Resources.Resources._48px_Crystal_Clear_action_exit
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(89, 52)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.StocksToolStripMenuItem.Text = "Stocks"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 690)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnsPrincipal)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnsPrincipal
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion Ventas "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnsPrincipal.ResumeLayout(False)
        Me.mnsPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents mnsPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilitariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContabilidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MonedasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeCambioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormasDePagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AlmacénToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadesDeMedidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SucursalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposDeMovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EstadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MsOutlookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MsExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MsWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlockDeNotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlmacenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
