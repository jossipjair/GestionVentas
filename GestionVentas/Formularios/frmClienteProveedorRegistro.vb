Public Class frmClienteProveedorRegistro

    Dim Cliente As New Capa_Datos.Clientes
    Dim Pais As New Capa_Datos.Paises
    Dim tipoGuardado As Integer
    Dim busquedaPais As String

    Private Sub frmClienteProveedorRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarBusqueda()
    End Sub
    Sub MostrarBusqueda()
        If busquedaCliente = 2 Then
            mostrarBusquedaCliente()
            estadoBotonInicial()
            estadoTextInicial()
        ElseIf busquedaCliente = 1 Then
            llenarPais()
            estadoBotonInicial()
            estadoTextInicial()
        End If

    End Sub
    Sub llenarPais()
        Me.cboPais.DataSource = Pais.listarPais
        Me.cboPais.ValueMember = "IdPais"
        Me.cboPais.DisplayMember = "DscPais"
        Me.cboPais.SelectedIndex = 0
    End Sub

    Sub mostrarBusquedaCliente()
        Dim DTR As DataRow = Cliente.buscarClienteProveedor(IdCliente)
        Me.txtIdCliente.Text = DTR(0)
        llenarPais()
        Me.cboPais.SelectedIndex = DTR(1) - 1
        Me.cboTipo.Text = DTR(2)
        Me.txtApePaterno.Text = DTR(3)
        Me.txtApeMaterno.Text = DTR(4)
        Me.txtNombres.Text = DTR(5)
        Me.txtRuc.Text = DTR(6)
        Me.txtNombreComercial.Text = DTR(7)
        Me.txtDireccion.Text = DTR(8)
        Me.txtRepreLegal.Text = DTR(9)
        Me.txtProvincia.Text = DTR(10)
        Me.txtDepartamento.Text = DTR(11)
        Me.txtEmail.Text = DTR(12)
        Me.txtTelefono.Text = DTR(13)
        Me.cboTipoPersona.Text = DTR(14)

    End Sub


    Public Sub insertarCliente()
        Try
            Cliente.insertarCliProv(Me.cboPais.SelectedValue, Me.cboTipo.Text, Me.txtApePaterno.Text, Me.txtApeMaterno.Text, Me.txtNombres.Text, Me.txtRuc.Text, Me.txtNombreComercial.Text, Me.txtDireccion.Text, Me.txtRepreLegal.Text, Me.txtDistrito.Text, Me.txtProvincia.Text, Me.txtDepartamento.Text, Me.txtEmail.Text, Me.txtTelefono.Text, Me.cboTipoPersona.Text)
        Catch ex As Exception
            MsgBox("Cliente ya se encuentra en la Base de Datos" & Chr(13) & "No se puede insertar registro" & Chr(13) & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
        End Try

    End Sub

    Public Sub editarCliente()
        Try
            Cliente.editarCliProv(Me.txtIdCliente.Text, Me.cboPais.SelectedValue, Me.cboTipo.Text, Me.txtApePaterno.Text, Me.txtApeMaterno.Text, Me.txtNombres.Text, Me.txtRuc.Text, Me.txtNombreComercial.Text, Me.txtDireccion.Text, Me.txtRepreLegal.Text, Me.txtDistrito.Text, Me.txtProvincia.Text, Me.txtDepartamento.Text, Me.txtEmail.Text, Me.txtTelefono.Text, Me.cboTipoPersona.Text)
        Catch ex As Exception
            MsgBox("Error de Edición" & Chr(13) & "No se puede editar registro" & Chr(13) & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
        End Try

    End Sub

    Public Sub eliminarCliente()
        Try
            Cliente.eliminarCliProv(Me.txtIdCliente.Text)
        Catch ex As Exception
            MsgBox("Cliente ya se encuentra relacionado, " & Chr(13) & "No se puede eliminar registro" & Chr(13) & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
        End Try
    End Sub
    'INICIADO EL FORMULARIO
    Public Sub estadoBotonInicial()
        Me.btnNuevo.Enabled = True
        Me.btnGuardar.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnCerrar.Enabled = True
        If Me.txtIdCliente.Text = "" Then
            Me.btnEditar.Enabled = False
            Me.btnEliminar.Enabled = False
        Else
            Me.btnEditar.Enabled = True
            Me.btnEliminar.Enabled = True
        End If


    End Sub

    Public Sub estadoTextInicial()
        If Me.cboPais.Items.Count = 0 And busquedaCliente = 1 Then
            MsgBox("No se ha cargado país, favor de agregar país", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
        End If

        Me.cboTipo.SelectedIndex = 0
        Me.cboTipoPersona.SelectedValue = 0

        Me.txtIdCliente.Enabled = False
        Me.cboTipo.Enabled = False
        Me.cboPais.Enabled = False
        Me.txtRuc.Enabled = False
        Me.cboTipoPersona.Enabled = False
        Me.txtNombreComercial.Enabled = False
        Me.txtApePaterno.Enabled = False
        Me.txtApeMaterno.Enabled = False
        Me.txtNombres.Enabled = False
        Me.txtRepreLegal.Enabled = False
        Me.txtEmail.Enabled = False
        Me.txtTelefono.Enabled = False
        Me.txtDireccion.Enabled = False
        Me.txtDepartamento.Enabled = False
        Me.txtProvincia.Enabled = False
        Me.txtDistrito.Enabled = False
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
        Me.txtIdCliente.Enabled = False
        Me.cboTipo.Enabled = True
        Me.cboPais.Enabled = True
        Me.txtRuc.Enabled = True
        Me.cboTipoPersona.Enabled = True
        Me.txtNombreComercial.Enabled = True
        Me.txtApePaterno.Enabled = True
        Me.txtApeMaterno.Enabled = True
        Me.txtNombres.Enabled = True
        Me.txtRepreLegal.Enabled = True
        Me.txtEmail.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.txtDireccion.Enabled = True
        Me.txtDepartamento.Enabled = True
        Me.txtProvincia.Enabled = True
        Me.txtDistrito.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If tipoGuardado = 2 Then
                If MsgBox("¿Desea guardar registro editado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Edición de registro") = MsgBoxResult.Yes Then
                    editarCliente()
                    estadoBotonInicial()
                    estadoTextInicial()
                End If
            ElseIf tipoGuardado = 1 Then
                If MsgBox("¿Desea guardar registro nuevo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar registro") = MsgBoxResult.Yes Then
                    insertarCliente()
                    estadoBotonInicial()
                    estadoTextInicial()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar!" & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error de guardado")
        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tipoGuardado = 1
        limpiar()
        llenarPais()
        If cantidadClientes = 0 Then
            Me.txtIdCliente.Text = 1
        ElseIf cantidadClientes = 1 Then
            Me.txtIdCliente.Text = Cliente.ultimoRegistro + 1
        End If
        estadoBotonEdicion()
        estadoTextEdicion()
    End Sub
    Public Sub limpiar()
        Me.txtIdCliente.Clear()
        Me.cboTipo.SelectedIndex = 0
        If Me.cboPais.Items.Count = 0 Then
            MsgBox("No se ha cargado país, favor de agregar país", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Mensaje del Sistema")
        End If
        Me.txtRuc.Clear()
        Me.cboTipoPersona.SelectedIndex = 0
        Me.txtNombreComercial.Clear()
        Me.txtApePaterno.Clear()
        Me.txtApeMaterno.Clear()
        Me.txtNombres.Clear()
        Me.txtRepreLegal.Clear()
        Me.txtEmail.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()
        Me.txtDepartamento.Clear()
        Me.txtProvincia.Clear()
        Me.txtDistrito.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        estadoBotonInicial()
        estadoTextInicial()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        tipoGuardado = 2
        estadoBotonEdicion()
        estadoTextEdicion()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Desea eliminar registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Eliminar registro") = MsgBoxResult.Yes Then
            eliminarCliente()
        End If
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        frmBuscarCliente.ShowDialog()
        MostrarBusqueda()
    End Sub
End Class