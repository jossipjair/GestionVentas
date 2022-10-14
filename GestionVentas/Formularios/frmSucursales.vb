Public Class frmSucursales

    Dim sucursal As New Capa_Datos.Sucursales
    Dim tipoGuardado As Integer

    Private Sub frmSucursales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        estadoBotonInicial()
        estadoTextInicial()
    End Sub


    Public Sub llenarGrid()
        Me.dgvSucursal.DataSource = sucursal.mostrarSucursal
        Me.dgvSucursal.AutoResizeColumns()
    End Sub

    Public Sub insertarSucursal()
        sucursal.insertarSucursal(Me.txtDescripcion.Text)
        llenarGrid()
    End Sub

    Public Sub editarSucursal()
        sucursal.editarSucursal(Me.txtIdSucursal.Text, Me.txtDescripcion.Text)
        llenarGrid()
    End Sub

    Public Sub eliminarSucursal()
        sucursal.eliminarSucursal(Me.txtIdSucursal.Text)
        llenarGrid()
    End Sub
    'INICIADO EL FORMULARIO
    Public Sub estadoBotonInicial()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnCerrar.Enabled = True

        If Me.dgvSucursal.RowCount = 0 Then
            Me.btnEditar.Enabled = False
            Me.btnEliminar.Enabled = False
        Else
            Me.btnEditar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If
    End Sub

    Public Sub estadoTextInicial()
        Me.txtIdSucursal.Enabled = False
        Me.txtDescripcion.Enabled = False
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
        Me.txtIdSucursal.Enabled = False
        Me.txtDescripcion.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If tipoGuardado = 2 Then
                If MsgBox("¿Desea guardar registro editado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Edición de registro") = MsgBoxResult.Yes Then
                    editarSucursal()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvSucursal.Enabled = True
                    Me.dgvSucursal.Focus()
                End If
            ElseIf tipoGuardado = 1 Then
                If MsgBox("¿Desea guardar registro nuevo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar registro") = MsgBoxResult.Yes Then
                    insertarSucursal()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvSucursal.Enabled = True
                    Me.dgvSucursal.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de guardado")
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipoGuardado = 1
        limpiar()
        If Me.dgvSucursal.RowCount = 0 Then
            Me.txtIdSucursal.Text = 1
        Else
            Me.txtIdSucursal.Text = sucursal.ultimoRegistro + 1
        End If
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvSucursal.Enabled = False
    End Sub
    Public Sub limpiar()
        Me.txtIdSucursal.Clear()
        Me.txtDescripcion.Clear()
        Me.txtDescripcion.Focus()
    End Sub
    Public Sub llenarTextBox()
        If Me.dgvSucursal.Rows.Count = 0 Then
            MsgBox("Sin datos que mostrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
            Me.btnEditar.Enabled = True
        Else
            Me.txtIdSucursal.Text = Me.dgvSucursal.CurrentRow.Cells(0).Value
            Me.txtDescripcion.Text = Me.dgvSucursal.CurrentRow.Cells(1).Value
            Me.btnEditar.Enabled = True
        End If
    End Sub

    Private Sub dgvSucursal_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSucursal.CellEnter
        llenarTextBox()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        estadoBotonInicial()
        estadoTextInicial()
        Me.dgvSucursal.Enabled = True
        Me.dgvSucursal.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        tipoGuardado = 2
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvSucursal.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Desea eliminar registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro") = MsgBoxResult.Yes Then
            eliminarSucursal()
            Me.dgvSucursal.Focus()
        End If
    End Sub
End Class