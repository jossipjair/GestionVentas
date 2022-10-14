Public Class frmTipoMovimiento
    Dim tipoMov As New Capa_Datos.TipoMovimiento
    Dim tipoGuardado As Integer

    Private Sub frmTipoMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        estadoBotonInicial()
        estadoTextInicial()
    End Sub

    Public Sub llenarGrid()
        Me.dgvTipoMovimiento.DataSource = tipoMov.mostrarTipoMovimiento
        Me.dgvTipoMovimiento.AutoResizeColumns()
    End Sub

    Public Sub insertarTipoMovimiento()
        tipoMov.insertarTipoMovimiento(Me.txtDscMovimiento.Text)
        llenarGrid()
    End Sub

    Public Sub editarTipoMovimiento()
        tipoMov.editarTipoMovimiento(Me.txtIdMovimiento.Text, Me.txtDscMovimiento.Text)
        llenarGrid()
    End Sub

    Public Sub eliminarTipoMovimiento()
        tipoMov.eliminarTipoMovimiento(Me.txtIdMovimiento.Text)
        llenarGrid()
    End Sub
    'INICIADO EL FORMULARIO
    Public Sub estadoBotonInicial()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnCerrar.Enabled = True

        If Me.dgvTipoMovimiento.RowCount = 0 Then
            Me.btnEditar.Enabled = False
            Me.btnEliminar.Enabled = False
        Else
            Me.btnEditar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If
    End Sub

    Public Sub estadoTextInicial()
        Me.txtIdMovimiento.Enabled = False
        Me.txtDscMovimiento.Enabled = False
    End Sub

    'CLIC EN BOTON NUEVO
    Public Sub estadoBotonEdicion()
        Me.btnNuevo.Enabled = False
        Me.btnGuardar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnCerrar.Enabled = False

        Me.btnEditar.Enabled = False
        Me.btnEliminar.Enabled = False

    End Sub

    Public Sub estadoTextEdicion()
        Me.txtIdMovimiento.Enabled = False
        Me.txtDscMovimiento.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If tipoGuardado = 2 Then
                If MsgBox("¿Desea guardar registro editado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Edición de registro") = MsgBoxResult.Yes Then
                    editarTipoMovimiento()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvTipoMovimiento.Enabled = True
                    Me.dgvTipoMovimiento.Focus()
                End If
            ElseIf tipoGuardado = 1 Then
                If MsgBox("¿Desea guardar registro nuevo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar registro") = MsgBoxResult.Yes Then
                    insertarTipoMovimiento()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvTipoMovimiento.Enabled = True
                    Me.dgvTipoMovimiento.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar!" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de guardado")
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipoGuardado = 1
        limpiar()
        If Me.dgvTipoMovimiento.RowCount = 0 Then
            Me.txtIdMovimiento.Text = 1
        Else
            Me.txtIdMovimiento.Text = tipoMov.ultimoRegistro + 1
        End If
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvTipoMovimiento.Enabled = False
    End Sub
    Public Sub limpiar()
        Me.txtIdMovimiento.Clear()
        Me.txtDscMovimiento.Clear()
        Me.txtDscMovimiento.Focus()
    End Sub
    Public Sub llenarTextBox()
        If Me.dgvTipoMovimiento.Rows.Count = 0 Then
            MsgBox("Sin datos que mostrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
            Me.btnEditar.Enabled = True
        Else
            Me.txtIdMovimiento.Text = Me.dgvTipoMovimiento.CurrentRow.Cells(0).Value
            Me.txtDscMovimiento.Text = Me.dgvTipoMovimiento.CurrentRow.Cells(1).Value
            Me.btnEditar.Enabled = True
        End If
    End Sub

    Private Sub dgvTipoMovimiento_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipoMovimiento.CellEnter
        llenarTextBox()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        estadoBotonInicial()
        estadoTextInicial()
        Me.dgvTipoMovimiento.Enabled = True
        Me.dgvTipoMovimiento.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        tipoGuardado = 2
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvTipoMovimiento.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Desea eliminar registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro") = MsgBoxResult.Yes Then
            eliminarTipoMovimiento()
            Me.dgvTipoMovimiento.Focus()
        End If
    End Sub
End Class