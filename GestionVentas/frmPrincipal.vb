Public Class frmPrincipal



    Private Sub MonedasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasToolStripMenuItem.Click
        Dim moneda As frmMoneda = Nothing
        If moneda Is Nothing OrElse Disposing = True Then
            moneda = New frmMoneda
        End If
        moneda.MdiParent = Me
        moneda.Show()
    End Sub

    Private Sub ClienteProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteProveedorToolStripMenuItem.Click
        Dim cliente As frmClienteProveedor = Nothing
        If cliente Is Nothing OrElse Disposing = True Then
            cliente = New frmClienteProveedor
        End If
        cliente.MdiParent = Me
        cliente.Show()
    End Sub

    Private Sub FormasDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormasDePagoToolStripMenuItem.Click
        Dim formaPago As frmFormasPago = Nothing
        If formaPago Is Nothing OrElse Disposing = True Then
            formaPago = New frmFormasPago
        End If
        formaPago.MdiParent = Me
        formaPago.Show()
    End Sub

    Private Sub EstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosToolStripMenuItem.Click
        Dim estadoDocu As frmEstado = Nothing
        If estadoDocu Is Nothing OrElse Disposing = True Then
            estadoDocu = New frmEstado
        End If
        estadoDocu.MdiParent = Me
        estadoDocu.Show()
    End Sub

    Private Sub PaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisToolStripMenuItem.Click
        Dim pais As frmPais = Nothing
        If pais Is Nothing OrElse Disposing = True Then
            pais = New frmPais
        End If
        pais.MdiParent = Me
        pais.Show()
    End Sub

    Private Sub TiposDeMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeMovimientosToolStripMenuItem.Click
        Dim tipoMov As frmTipoMovimiento = Nothing
        If tipoMov Is Nothing OrElse Disposing = True Then
            tipoMov = New frmTipoMovimiento
        End If
        tipoMov.MdiParent = Me
        tipoMov.Show()
    End Sub

    Private Sub UnidadesDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesDeMedidaToolStripMenuItem.Click
        Dim UM As frmUnidadMedida = Nothing
        If UM Is Nothing OrElse Disposing = True Then
            UM = New frmUnidadMedida
        End If
        UM.MdiParent = Me
        UM.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TipoDeCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeCambioToolStripMenuItem.Click
        Dim TipoCambio As frmTipoCambio = Nothing
        If TipoCambio Is Nothing OrElse Disposing = True Then
            TipoCambio = New frmTipoCambio
        End If
        TipoCambio.MdiParent = Me
        TipoCambio.Show()
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        Dim sucursal As frmSucursales = Nothing
        If sucursal Is Nothing OrElse Disposing = True Then
            sucursal = New frmSucursales
        End If
        sucursal.MdiParent = Me
        sucursal.Show()
    End Sub


    Private Sub MsOutlookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsOutlookToolStripMenuItem.Click
        Process.Start("outlook.exe")
    End Sub

    Private Sub MsExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsExcelToolStripMenuItem.Click
        Process.Start("excel.exe")
    End Sub

    Private Sub MsWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MsWordToolStripMenuItem.Click
        Process.Start("winword.exe")
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub BlockDeNotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlockDeNotasToolStripMenuItem.Click
        Process.Start("notepad.exe")
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click

    End Sub


    Private Sub AlmacenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenesToolStripMenuItem.Click
        Dim almacen As frmAlmacen = Nothing
        If almacen Is Nothing OrElse Disposing = True Then
            almacen = New frmAlmacen
        End If
        almacen.MdiParent = Me
        almacen.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim produto As frmProductos = Nothing
        If produto Is Nothing OrElse Disposing = True Then
            produto = New frmProductos
        End If
        produto.MdiParent = Me
        produto.Show()
    End Sub
End Class