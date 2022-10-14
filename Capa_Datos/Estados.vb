Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Estados

    Public Function mostrarEstados() As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarEstados"
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function

    Public Sub insertarEstados(dscEstado As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_InsertarEstados"
            .Parameters.AddWithValue("@Dsc", dscEstado)
        End With
        cmd.Connection = Conexion()


        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub

    Public Sub editarEstados(idEstado As Integer, dscEstado As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EditarEstados"
            .Parameters.AddWithValue("@Id", idEstado)
            .Parameters.AddWithValue("@Dsc", dscEstado)
        End With

        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub


    Public Sub eliminarEstado(idEstado As Integer)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EliminarEstados"
            .Parameters.AddWithValue("@Id", idEstado)
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
            .CommandText = "sp_UltimoRegistroEstados"
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
