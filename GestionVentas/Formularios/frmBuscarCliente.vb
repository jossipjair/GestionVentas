Imports Capa_Datos.Clientes

Public Class frmBuscarCliente

    Dim Cliente As New Capa_Datos.Clientes

    Private Sub frmBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboParBusqueda.SelectedIndex = 0
        Me.dgvBusqueda.DataSource = Cliente.buscarClienteNombreComercial(Me.txtBusqueda.Text)
        Me.dgvBusqueda.AutoResizeColumns()
    End Sub

    Sub buscar()
        Dim parBusqueda As String = ""
        If Me.cboParBusqueda.Text = "RUC / DNI" Then
            parBusqueda = Me.txtBusqueda.Text
            Me.dgvBusqueda.DataSource = Cliente.buscarClienteRuc(parBusqueda)
        ElseIf Me.cboParBusqueda.Text = "NOMBRE COMERCIAL" Then
            parBusqueda = "%" & Me.txtBusqueda.Text & "%"
            Me.dgvBusqueda.DataSource = Cliente.buscarClienteNombreComercial(parBusqueda)
        ElseIf Me.cboParBusqueda.Text = "APELLIDO PATERNO" Then
            parBusqueda = "%" & Me.txtBusqueda.Text & "%"
            Me.dgvBusqueda.DataSource = Cliente.buscarClienteApellidoPaterno(parBusqueda)
        End If
        Me.dgvBusqueda.AutoResizeColumns()
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Private Sub dgvBusqueda_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellDoubleClick
        busquedaCliente = 2
        Me.Close()
    End Sub
End Class