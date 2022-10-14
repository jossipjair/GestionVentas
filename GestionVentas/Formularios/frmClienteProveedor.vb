Public Class frmClienteProveedor
    Dim clienteProveedor As New Capa_Datos.Clientes
    Private Sub frmClienteProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboTipoCliente.SelectedIndex = 0
        llenarGridInicial()
        Me.dgvListaClienteProveedor.AutoResizeColumns()
    End Sub

    Public Sub llenarGridInicial()
        Me.dgvListaClienteProveedor.DataSource = clienteProveedor.mostrarTodos("%" & Me.txtBuscar.Text & "%")
    End Sub

    Public Sub llenarGridFiltro()
        If Me.cboTipoCliente.Text = "(Todos)" Then
            Me.dgvListaClienteProveedor.DataSource = clienteProveedor.mostrarTodos("%" & Me.txtBuscar.Text & "%")
        ElseIf Me.cboTipoCliente.Text = "CLIENTE" Then
            Me.dgvListaClienteProveedor.DataSource = clienteProveedor.mostrarClientes("%" & Me.txtBuscar.Text & "%")
        ElseIf Me.cboTipoCliente.Text = "PROVEEDOR" Then
            Me.dgvListaClienteProveedor.DataSource = clienteProveedor.mostrarProveedores("%" & Me.txtBuscar.Text & "%")
        End If
        Me.dgvListaClienteProveedor.AutoResizeColumns()
    End Sub

    Private Sub dgvListaClienteProveedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaClienteProveedor.CellDoubleClick
        Static Cliente As frmClienteProveedorRegistro = Nothing
        If Cliente Is Nothing OrElse Cliente.IsDisposed Then
            Cliente = New frmClienteProveedorRegistro
        End If
        IdCliente = Me.dgvListaClienteProveedor.CurrentRow.Cells(0).Value
        'Oco.MdiParent = frmPrincipal
        busquedaCliente = 2
        Cliente.ShowDialog()
        llenarGridInicial()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        llenarGridFiltro()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        busquedaCliente = 1
        If Me.dgvListaClienteProveedor.RowCount = 0 Then
            Dim registrarCliente As frmClienteProveedorRegistro = New frmClienteProveedorRegistro
            cantidadClientes = 0

            registrarCliente.ShowDialog()
            llenarGridInicial()
        Else
            cantidadClientes = 1
            Dim registrarCliente As frmClienteProveedorRegistro = New frmClienteProveedorRegistro
            registrarCliente.ShowDialog()
            llenarGridInicial()
        End If


    End Sub

    Private Sub dgvListaClienteProveedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaClienteProveedor.CellContentClick

    End Sub
End Class