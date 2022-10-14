Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Clientes

    Public Function mostrarClientes(buscar As String) As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarClientes"
            .Parameters.AddWithValue("@Buscar", buscar)
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function


    Public Function mostrarProveedores(buscar As String) As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarProveedores"
            .Parameters.AddWithValue("@Buscar", buscar)
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function
    Public Function mostrarTodos(buscar As String) As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarClienteTodos"
            .Parameters.AddWithValue("@Buscar", buscar)
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function

    Public Sub insertarCliProv(idPais As Integer, tipoClivProv As String, ApePaterno As String, ApeMaterno As String, nombres As String, nroRuc As String, nomComercial As String, direccion As String, repreLegal As String, distrito As String, provincia As String, departamento As String, email As String, telefono As String, tipoPersona As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_InsertarClienteProveedor"
            .Parameters.AddWithValue("@IdPais", idPais)
            .Parameters.AddWithValue("@TipoCliProv", tipoClivProv)
            .Parameters.AddWithValue("@ApePaterno", ApePaterno)
            .Parameters.AddWithValue("@ApeMaterno", ApeMaterno)
            .Parameters.AddWithValue("@Nombres", nombres)
            .Parameters.AddWithValue("@NroRuc", nroRuc)
            .Parameters.AddWithValue("@NomComercial", nomComercial)
            .Parameters.AddWithValue("@Direccion", direccion)
            .Parameters.AddWithValue("@RepreLegal", repreLegal)
            .Parameters.AddWithValue("@Distrito", distrito)
            .Parameters.AddWithValue("@Provincia", provincia)
            .Parameters.AddWithValue("@Departamento", departamento)
            .Parameters.AddWithValue("@Email", email)
            .Parameters.AddWithValue("@Telefono", telefono)
            .Parameters.AddWithValue("@TipoPersona", tipoPersona)
        End With

        cmd.Connection = Conexion()
        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub

    Public Sub editarCliProv(id As Integer, idPais As Integer, tipoClivProv As String, ApePaterno As String, ApeMaterno As String, nombres As String, nroRuc As String, nomComercial As String, direccion As String, repreLegal As String, distrito As String, provincia As String, departamento As String, email As String, telefono As String, tipoPersona As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EditarClienteProveedor"
            .Parameters.AddWithValue("@Id", id)
            .Parameters.AddWithValue("@IdPais", idPais)
            .Parameters.AddWithValue("@TipoCliProv", tipoClivProv)
            .Parameters.AddWithValue("@ApePaterno", ApePaterno)
            .Parameters.AddWithValue("@ApeMaterno", ApeMaterno)
            .Parameters.AddWithValue("@Nombres", nombres)
            .Parameters.AddWithValue("@NroRuc", nroRuc)
            .Parameters.AddWithValue("@NomComercial", nomComercial)
            .Parameters.AddWithValue("@Direccion", direccion)
            .Parameters.AddWithValue("@RepreLegal", repreLegal)
            .Parameters.AddWithValue("@Distrito", distrito)
            .Parameters.AddWithValue("@Provincia", provincia)
            .Parameters.AddWithValue("@Departamento", departamento)
            .Parameters.AddWithValue("@Email", email)
            .Parameters.AddWithValue("@Telefono", telefono)
            .Parameters.AddWithValue("@TipoPersona", tipoPersona)
        End With

        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub


    Public Sub eliminarCliProv(idCliProv As Integer)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EliminarClienteProveedor"
            .Parameters.AddWithValue("@Id", idCliProv)
        End With
        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()
    End Sub

    Public Function ultimoRegistro() As Integer
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_UltimoRegistroClienteProveedor"
        End With

        dt = New DataTable

        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()
        Dim cantidad As Integer
        cantidad = dt(0)(0).ToString

        Return cantidad

    End Function

    Public Function buscarClienteProveedor(idCliente As Integer) As DataRow
        Desconectar()
        'cmd = New SqlCommand("SELECT * FROM ClienteProveedor", Conexion)
        cmd = New SqlCommand
        cmd.Connection = Conexion()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_BuscarClienteProveedorForm"
        cmd.Parameters.AddWithValue("@Id", idCliente)
        Conectar()
        dr = cmd.ExecuteReader
        dt = New DataTable
        dt.Load(dr)
        Desconectar()
        Dim dtRow As DataRow
        dtRow = dt.Rows(0)
        Return dtRow
    End Function

    Public Function buscarClienteRuc(NroRuc As String) As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_BuscarClienteRUC"
            .Parameters.AddWithValue("@Ruc", NroRuc)
        End With
        dt = New DataTable

        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function


    Public Function buscarClienteNombreComercial(NombreComercial As String) As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_BuscarClienteNombre"
            .Parameters.AddWithValue("@Nom", NombreComercial)
        End With
        dt = New DataTable

        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function

    Public Function buscarClienteApellidoPaterno(ApellidoPat As String) As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_BuscarClienteApellidoPat"
            .Parameters.AddWithValue("@ApePaterno", ApellidoPat)
        End With
        dt = New DataTable

        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function


End Class
