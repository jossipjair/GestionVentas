Public Class frmAlmacen

    Dim sucursal As New Capa_Datos.Sucursales
    Dim almacen As New Capa_Datos.Almacen
    Dim tipoGuardado As Integer

    Private Sub frmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGrid()
        estadoBotonInicial()
        estadoTextInicial()
        llenarCombo()
    End Sub

    Public Sub llenarCombo()
        Me.cboSucursal.DataSource = sucursal.listarSucursal
        Me.cboSucursal.ValueMember = "IdSucursal"
        Me.cboSucursal.DisplayMember = "DscSucursal"
    End Sub

    Public Sub llenarGrid()
        Me.dgvAlmacen.DataSource = almacen.mostrarAlmacen
        Me.dgvAlmacen.AutoResizeColumns()
    End Sub

    Public Sub insertarAlmacen()
        almacen.insertarAlmacen(Me.cboSucursal.SelectedValue, Me.txtDescripcion.Text)
        llenarGrid()
    End Sub

    Public Sub editarAlmacen()
        almacen.editarAlmacen(Me.txtIdAlmacen.Text, Me.cboSucursal.SelectedValue, Me.txtDescripcion.Text)
        llenarGrid()
    End Sub

    Public Sub eliminarAlmacen()
        almacen.eliminarAlmacen(Me.txtIdAlmacen.Text)
        llenarGrid()
    End Sub
    'INICIADO EL FORMULARIO
    Public Sub estadoBotonInicial()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnCerrar.Enabled = True

        If Me.dgvAlmacen.RowCount = 0 Then
            Me.btnEditar.Enabled = False
            Me.btnEliminar.Enabled = False
        Else
            Me.btnEditar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If
    End Sub

    Public Sub estadoTextInicial()
        Me.txtIdAlmacen.Enabled = False
        Me.cboSucursal.Enabled = False
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
        Me.txtIdAlmacen.Enabled = False
        Me.cboSucursal.Enabled = True
        Me.txtDescripcion.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If tipoGuardado = 2 Then
                If MsgBox("¿Desea guardar registro editado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Edición de registro") = MsgBoxResult.Yes Then
                    editarAlmacen()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvAlmacen.Enabled = True
                    Me.dgvAlmacen.Focus()
                End If
            ElseIf tipoGuardado = 1 Then
                If MsgBox("¿Desea guardar registro nuevo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar registro") = MsgBoxResult.Yes Then
                    insertarAlmacen()
                    estadoBotonInicial()
                    estadoTextInicial()
                    Me.dgvAlmacen.Enabled = True
                    Me.dgvAlmacen.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar!" & ex.Message & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de guardado")
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipoGuardado = 1
        limpiar()
        If Me.dgvAlmacen.RowCount = 0 Then
            Me.txtIdAlmacen.Text = 1
        Else
            Me.txtIdAlmacen.Text = almacen.ultimoRegistro + 1
        End If
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvAlmacen.Enabled = False
    End Sub
    Public Sub limpiar()
        Me.txtIdAlmacen.Clear()
        If Me.cboSucursal.Text = "" Then
            MsgBox("Registre al menos una Sucursal para registrar almacén", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
        Else
            Me.cboSucursal.SelectedIndex = 0
            Me.txtDescripcion.Clear()
            Me.txtDescripcion.Focus()
        End If

    End Sub
    Public Sub llenarTextBox()
        If Me.dgvAlmacen.Rows.Count = 0 Then
            MsgBox("Sin datos que mostrar", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
            Me.btnEditar.Enabled = True
        Else
            Me.txtIdAlmacen.Text = Me.dgvAlmacen.CurrentRow.Cells(0).Value
            Me.cboSucursal.Text = Me.dgvAlmacen.CurrentRow.Cells(1).Value
            Me.txtDescripcion.Text = Me.dgvAlmacen.CurrentRow.Cells(2).Value
            Me.btnEditar.Enabled = True
        End If
    End Sub

    Private Sub dgvAlmacen_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlmacen.CellEnter
        llenarTextBox()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        estadoBotonInicial()
        estadoTextInicial()
        Me.dgvAlmacen.Enabled = True
        Me.dgvAlmacen.Focus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        tipoGuardado = 2
        estadoBotonEdicion()
        estadoTextEdicion()
        Me.dgvAlmacen.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Desea eliminar registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro") = MsgBoxResult.Yes Then
            eliminarAlmacen()
            Me.dgvAlmacen.Focus()
        End If
    End Sub

End Class