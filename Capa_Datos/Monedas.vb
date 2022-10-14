Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Monedas

    Public Function mostrarMonedas() As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarMoneda"
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()
        Return dt

    End Function

    Public Sub insertarMoneda(dscMoneda As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_insertarMoneda"
            .Parameters.AddWithValue("@Moneda", dscMoneda)
        End With
        cmd.Connection = Conexion()


        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub

    Public Sub editarMoneda(idMoneda As Integer, dscMoneda As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_editarMoneda"
            .Parameters.AddWithValue("@Id", idMoneda)
            .Parameters.AddWithValue("@Moneda", dscMoneda)
        End With

        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub


    Public Sub eliminarMoneda(idMoneda As Integer)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EliminarMoneda"
            .Parameters.AddWithValue("@Id", idMoneda)
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
            .CommandText = "sp_UltimoRegistro"
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
