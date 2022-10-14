Public Class frmFormasPago

    Dim formaPago As New Capa_Datos.FormaPago
    Dim tipoGuardado As Integer

    Private Sub frmFormasPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        estadoBotonInicial()
        estadoTextInicial()
    End Sub


    Public Sub llenarGrid()
        Me.dgvFormasPago.DataSource = formaPago.mostrarFormasPago
        Me.dgvFormasPago.AutoResizeColumns()
    End Sub

    Public Sub insertarForma()
        formaPago.insertarFormaPago(Me.txtDscFormaPago.Text)
        llenarGrid()
    End Sub

    Public Sub editarForma()
        formaPago.editarFormaPago(Me.txtidFormaPago.Text, Me.txtDscFormaPago.Text)
        llenarGrid()
    End Sub

    Public Sub eliminarForma()
        formaPago.eliminarFormaPago(Me.txtidFormaPago.Text)
        llenarGrid()
    End Sub
    'INICIADO EL FORMULARIO
    Public Sub estadoBotonInicial()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnCerrar.Enabled = True

        If Me.dgvFormasPago.RowCount = 0 Then
            Me.btnEditar.Enabled = False
            Me.btnEliminar.Enabled = False
        Else
            Me.btnEditar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If
    End Sub

    Public Sub estadoTextInicial()
        Me.txtidFormaPago.Enabled = False
        Me.txtDscFormaPago.Enabled = False
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
        Me.txtidFormaPago.Enabled = False
        Me.txtDscFormaPago.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If tipoGuardado = 2 Then
                If MsgBox("¿Desea guardar registro editado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Edición de registro") = MsgBoxResult.Yes Then
                    editarForma()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvFormasPago.Enabled = True
                    Me.dgvFormasPago.Focus()
                End If
            ElseIf tipoGuardado = 1 Then
                If MsgBox("¿Desea guardar registro nuevo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar registro") = MsgBoxResult.Yes Then
                    insertarForma()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvFormasPago.Enabled = True
                    Me.dgvFormasPago.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de guardado")
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipoGuardado = 1
        limpiar()
        If Me.dgvFormasPago.RowCount = 0 Then
            Me.txtidFormaPago.Text = 1
        Else
            Me.txtidFormaPago.Text = formaPago.ultimoRegistro + 1
        End If

        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvFormasPago.Enabled = False
    End Sub
    Public Sub limpiar()
        Me.txtidFormaPago.Clear()
        Me.txtDscFormaPago.Clear()
        Me.txtDscFormaPago.Focus()
    End Sub
    Public Sub llenarTextBox()
        If Me.dgvFormasPago.Rows.Count = 0 Then
            MsgBox("Sin datos que mostrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
            Me.btnEditar.Enabled = True
        Else
            Me.txtidFormaPago.Text = Me.dgvFormasPago.CurrentRow.Cells(0).Value
            Me.txtDscFormaPago.Text = Me.dgvFormasPago.CurrentRow.Cells(1).Value
            Me.btnEditar.Enabled = True
        End If
    End Sub

    Private Sub dgvFormasPago_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFormasPago.CellEnter
        llenarTextBox()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        estadoBotonInicial()
        estadoTextInicial()
        Me.dgvFormasPago.Enabled = True
        Me.dgvFormasPago.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        tipoGuardado = 2
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvFormasPago.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Desea eliminar registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro") = MsgBoxResult.Yes Then
            eliminarForma()
            Me.dgvFormasPago.Focus()
        End If
    End Sub
End Class