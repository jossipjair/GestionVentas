Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmPais
    Dim pais As New Capa_Datos.Paises
    Dim tipoGuardado As Integer

    Private Sub frmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        estadoBotonInicial()
        estadoTextInicial()
    End Sub


    Public Sub llenarGrid()
        Me.dgvPais.DataSource = pais.mostrarPais
        Me.dgvPais.AutoResizeColumns()
    End Sub

    Public Sub insertarPais()
        pais.insertarPais(Me.txtDescripcion.Text)
        llenarGrid()
    End Sub

    Public Sub editarPais()
        pais.editarPais(Me.txtIdPais.Text, Me.txtDescripcion.Text)
        llenarGrid()
    End Sub

    Public Sub eliminarPais()
        pais.eliminarPais(Me.txtIdPais.Text)
        llenarGrid()
    End Sub
    'INICIADO EL FORMULARIO
    Public Sub estadoBotonInicial()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnCerrar.Enabled = True

        If Me.dgvPais.RowCount = 0 Then
            Me.btnEditar.Enabled = False
            Me.btnEliminar.Enabled = False
        Else
            Me.btnEditar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If
    End Sub

    Public Sub estadoTextInicial()
        Me.txtIdPais.Enabled = False
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
        Me.txtIdPais.Enabled = False
        Me.txtDescripcion.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If tipoGuardado = 2 Then
                If MsgBox("¿Desea guardar registro editado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Edición de registro") = MsgBoxResult.Yes Then
                    editarPais()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvPais.Enabled = True
                    Me.dgvPais.Focus()
                End If
            ElseIf tipoGuardado = 1 Then
                If MsgBox("¿Desea guardar registro nuevo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar registro") = MsgBoxResult.Yes Then
                    insertarPais()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvPais.Enabled = True
                    Me.dgvPais.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar!" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de guardado")
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipoGuardado = 1
        limpiar()
        If Me.dgvPais.RowCount = 0 Then
            Me.txtIdPais.Text = 1
        Else
            Me.txtIdPais.Text = pais.ultimoRegistro + 1
        End If
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvPais.Enabled = False
    End Sub
    Public Sub limpiar()
        Me.txtIdPais.Clear()
        Me.txtDescripcion.Clear()
        Me.txtDescripcion.Focus()
    End Sub
    Public Sub llenarTextBox()
        If Me.dgvPais.Rows.Count = 0 Then
            MsgBox("Sin datos que mostrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
            Me.btnEditar.Enabled = True
        Else
            Me.txtIdPais.Text = Me.dgvPais.CurrentRow.Cells(0).Value
            Me.txtDescripcion.Text = Me.dgvPais.CurrentRow.Cells(1).Value
            Me.btnEditar.Enabled = True
        End If
    End Sub

    Private Sub dgvPais_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPais.CellEnter
        llenarTextBox()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        estadoBotonInicial()
        estadoTextInicial()
        Me.dgvPais.Enabled = True
        Me.dgvPais.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        tipoGuardado = 2
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvPais.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Desea eliminar registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro") = MsgBoxResult.Yes Then
            eliminarPais()
            Me.dgvPais.Focus()
        End If
    End Sub
End Class