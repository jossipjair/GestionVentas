Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Paises

    Public Function mostrarPais() As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarPais"
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function

    Public Function listarPais() As DataTable
        adp = New SqlDataAdapter("SELECT * FROM Pais", Conexion)
        ds = New DataSet
        adp.Fill(ds, "Pais")
        Return ds.Tables(0)
    End Function
    Public Sub insertarPais(dscPais As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_InsertarPais"
            .Parameters.AddWithValue("@Dsc", dscPais)
        End With
        cmd.Connection = Conexion()


        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub

    Public Sub editarPais(idPais As Integer, dscPais As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EditarPais"
            .Parameters.AddWithValue("@Id", idPais)
            .Parameters.AddWithValue("@Dsc", dscPais)
        End With

        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub


    Public Sub eliminarPais(idPais As Integer)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EliminarPais"
            .Parameters.AddWithValue("@Id", idPais)
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
            .CommandText = "sp_UltimoRegistroPais"
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


    'Buscar Pais para mostrar desde el DataRow
    Public Function buscarPais(idPais As Integer) As DataTable
        Desconectar()
        cmd = New SqlCommand
        cmd.Connection = Conexion()
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_BuscarPais"
        cmd.Parameters.AddWithValue("@Id", idPais)
        Conectar()
        dr = cmd.ExecuteReader
        dt = New DataTable
        dt.Load(dr)
        Desconectar()
        Return dt
    End Function

End Class
