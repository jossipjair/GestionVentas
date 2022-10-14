Public Class frmTipoCambio
    Dim tipoCambio As New Capa_Datos.TipoCambio
    Dim tipoGuardado As Integer

    Private Sub frmMoneda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        estadoBotonInicial()
        estadoTextInicial()
    End Sub

    Public Sub llenarGrid()
        Me.dgvTipoCambio.DataSource = tipoCambio.mostrarTipoCambio
        Me.dgvTipoCambio.AutoResizeColumns()
    End Sub

    Public Sub insertarTipoCambio()
        tipoCambio.insertarTipoCambio(Me.dtpFecha.Value.ToString, Me.txtDolarCompra.Text, Me.txtDolarVenta.Text, Me.txtEuroCompra.Text, Me.txtEuroVenta.Text)
        llenarGrid()
    End Sub

    Public Sub editarTipoCambio()
        tipoCambio.editarTipoCambio(Me.txtId.Text, Me.txtDolarCompra.Text, Me.txtDolarVenta.Text, Me.txtEuroCompra.Text, Me.txtEuroVenta.Text)
        llenarGrid()
    End Sub

    'INICIADO EL FORMULARIO
    Public Sub estadoBotonInicial()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnCerrar.Enabled = True

        If Me.dgvTipoCambio.RowCount = 0 Then
            Me.btnEditar.Enabled = False

        Else
            Me.btnEditar.Enabled = True
        End If
    End Sub

    Public Sub estadoTextInicial()
        Me.txtDolarCompra.Enabled = False
        Me.txtDolarVenta.Enabled = False
        Me.txtEuroCompra.Enabled = False
        Me.txtEuroVenta.Enabled = False
        Me.dtpFecha.Enabled = False
    End Sub

    'CLIC EN BOTON NUEVO
    Public Sub estadoBotonEdicion()
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnCerrar.Enabled = False

        Me.btnEditar.Enabled = False
    End Sub

    Public Sub estadoTextEdicion()
        Me.txtDolarCompra.Enabled = True
        Me.txtDolarVenta.Enabled = True
        Me.txtEuroCompra.Enabled = True
        Me.txtEuroVenta.Enabled = True
        Me.dtpFecha.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If tipoGuardado = 2 Then
                If MsgBox("¿Desea guardar registro editado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Edición de registro") = MsgBoxResult.Yes Then
                    editarTipoCambio()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvTipoCambio.Enabled = True
                    Me.dgvTipoCambio.Focus()
                End If
            ElseIf tipoGuardado = 1 Then
                If MsgBox("¿Desea guardar registro nuevo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar registro") = MsgBoxResult.Yes Then
                    insertarTipoCambio()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvTipoCambio.Enabled = True
                    Me.dgvTipoCambio.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar!" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de guardado")
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipoGuardado = 1
        limpiar()
        If Me.dgvTipoCambio.RowCount = 0 Then
            Me.txtId.Text = 1
        Else
            Me.txtId.Text = tipoCambio.ultimoRegistro + 1
        End If
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvTipoCambio.Enabled = False
    End Sub
    Public Sub limpiar()
        Me.txtId.Clear()
        Me.txtDolarCompra.Clear()
        Me.txtDolarVenta.Clear()
        Me.txtEuroCompra.Clear()
        Me.txtEuroVenta.Clear()
        Me.dtpFecha.Value = DateTime.Now
        Me.dtpFecha.Focus()
    End Sub
    Public Sub llenarTextBox()
        If Me.dgvTipoCambio.Rows.Count = 0 Then
            MsgBox("Sin datos que mostrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
            Me.btnEditar.Enabled = True
        Else
            Me.txtId.Text = Me.dgvTipoCambio.CurrentRow.Cells(0).Value
            Me.dtpFecha.Text = Me.dgvTipoCambio.CurrentRow.Cells(1).Value
            Me.txtDolarCompra.Text = Me.dgvTipoCambio.CurrentRow.Cells(2).Value
            Me.txtDolarVenta.Text = Me.dgvTipoCambio.CurrentRow.Cells(3).Value
            Me.txtEuroCompra.Text = Me.dgvTipoCambio.CurrentRow.Cells(4).Value
            Me.txtEuroVenta.Text = Me.dgvTipoCambio.CurrentRow.Cells(5).Value
            Me.btnEditar.Enabled = True
        End If
    End Sub

    Private Sub dgvTipoCambio_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipoCambio.CellEnter
        llenarTextBox()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        estadoBotonInicial()
        estadoTextInicial()
        Me.dgvTipoCambio.Enabled = True
        Me.dgvTipoCambio.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        tipoGuardado = 2
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvTipoCambio.Enabled = False
    End Sub


End Class