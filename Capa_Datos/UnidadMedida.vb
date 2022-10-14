Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class UnidadMedida

    Public Function mostrarUnidadMedida() As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarUnidadMedida"
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function

    Public Sub insertarUnidadMedida(dscUnidadMedida As String, preUnidadMedida As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_InsertarUnidadMedida"
            .Parameters.AddWithValue("@Dsc", dscUnidadMedida)
            .Parameters.AddWithValue("@Pre", preUnidadMedida)
        End With
        cmd.Connection = Conexion()


        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub

    Public Sub editarUnidadMedida(idUnidadMedida As Integer, dscUnidadMedida As String, preUnidadMedida As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EditarUnidadMedida"
            .Parameters.AddWithValue("@Id", idUnidadMedida)
            .Parameters.AddWithValue("@Dsc", dscUnidadMedida)
            .Parameters.AddWithValue("@Pre", preUnidadMedida)
        End With

        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub


    Public Sub eliminarUnidadMedida(idUnidadMedida As Integer)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EliminarUnidadMedida"
            .Parameters.AddWithValue("@Id", idUnidadMedida)
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
            .CommandText = "sp_UltimoRegistroUnidadMedida"
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

End Class
