Public Class frmUnidadMedida
    Dim UM As New Capa_Datos.UnidadMedida
    Dim tipoGuardado As Integer

    Private Sub frmUnidadMedida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        estadoBotonInicial()
        estadoTextInicial()
    End Sub


    Public Sub llenarGrid()
        Me.dgvUnidadMedida.DataSource = UM.mostrarUnidadMedida
        Me.dgvUnidadMedida.AutoResizeColumns()
    End Sub

    Public Sub insertarUnidadMedida()
        UM.insertarUnidadMedida(Me.txtDscUnidadMedida.Text, Me.txtPrefijo.Text)
        llenarGrid()
    End Sub

    Public Sub editarUnidadMedida()
        UM.editarUnidadMedida(Me.txtIdUnidadMedida.Text, Me.txtDscUnidadMedida.Text, Me.txtPrefijo.Text)
        llenarGrid()
    End Sub

    Public Sub elimnarUnidadMedida()
        UM.eliminarUnidadMedida(Me.txtIdUnidadMedida.Text)
        llenarGrid()
    End Sub
    'INICIADO EL FORMULARIO
    Public Sub estadoBotonInicial()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnCerrar.Enabled = True

        If Me.dgvUnidadMedida.RowCount = 0 Then
            Me.btnEditar.Enabled = False
            Me.btnEliminar.Enabled = False
        Else
            Me.btnEditar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If
    End Sub

    Public Sub estadoTextInicial()
        Me.txtIdUnidadMedida.Enabled = False
        Me.txtDscUnidadMedida.Enabled = False
        Me.txtPrefijo.Enabled = False
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
        Me.txtIdUnidadMedida.Enabled = False
        Me.txtDscUnidadMedida.Enabled = True
        Me.txtPrefijo.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If tipoGuardado = 2 Then
                If MsgBox("¿Desea guardar registro editado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Edición de registro") = MsgBoxResult.Yes Then
                    editarUnidadMedida()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvUnidadMedida.Enabled = True
                    Me.dgvUnidadMedida.Focus()
                End If
            ElseIf tipoGuardado = 1 Then
                If MsgBox("¿Desea guardar registro nuevo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar registro") = MsgBoxResult.Yes Then
                    insertarUnidadMedida()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvUnidadMedida.Enabled = True
                    Me.dgvUnidadMedida.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar!" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de guardado")
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipoGuardado = 1
        limpiar()
        If Me.dgvUnidadMedida.RowCount = 0 Then
            Me.txtIdUnidadMedida.Text = 1
        Else
            Me.txtIdUnidadMedida.Text = UM.ultimoRegistro + 1
        End If
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvUnidadMedida.Enabled = False
    End Sub
    Public Sub limpiar()
        Me.txtIdUnidadMedida.Clear()
        Me.txtDscUnidadMedida.Clear()
        Me.txtPrefijo.Clear()
        Me.txtDscUnidadMedida.Focus()
    End Sub
    Public Sub llenarTextBox()
        If Me.dgvUnidadMedida.Rows.Count = 0 Then
            MsgBox("Sin datos que mostrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
            Me.btnEditar.Enabled = True
        Else
            Me.txtIdUnidadMedida.Text = Me.dgvUnidadMedida.CurrentRow.Cells(0).Value
            Me.txtDscUnidadMedida.Text = Me.dgvUnidadMedida.CurrentRow.Cells(1).Value
            Me.txtPrefijo.Text = Me.dgvUnidadMedida.CurrentRow.Cells(2).Value
            Me.btnEditar.Enabled = True
        End If
    End Sub

    Private Sub dgvUnidadMedida_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnidadMedida.CellEnter
        llenarTextBox()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        estadoBotonInicial()
        estadoTextInicial()
        Me.dgvUnidadMedida.Enabled = True
        Me.dgvUnidadMedida.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        tipoGuardado = 2
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvUnidadMedida.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Desea eliminar registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro") = MsgBoxResult.Yes Then
            elimnarUnidadMedida()
            Me.dgvUnidadMedida.Focus()
        End If
    End Sub
End Class