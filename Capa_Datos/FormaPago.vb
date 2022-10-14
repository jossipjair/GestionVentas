Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class FormaPago

    Public Function mostrarFormasPago() As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarFormasPago"
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function

    Public Sub insertarFormaPago(dscFormaPago As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_InsertarFormasPago"
            .Parameters.AddWithValue("@Dsc", dscFormaPago)
        End With
        cmd.Connection = Conexion()


        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub

    Public Sub editarFormaPago(idFormaPago As Integer, dscFormPago As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EditarFormaPago"
            .Parameters.AddWithValue("@Id", idFormaPago)
            .Parameters.AddWithValue("@Dsc", dscFormPago)
        End With

        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub


    Public Sub eliminarFormaPago(idFormaPago As Integer)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EliminarFormaPago"
            .Parameters.AddWithValue("@Id", idFormaPago)
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
            .CommandText = "sp_UltimoRegistroFormaPago"
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
