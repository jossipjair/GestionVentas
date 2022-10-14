Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Almacen

    Public Function mostrarAlmacen() As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarAlmacen"
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()

        Return dt
    End Function

    Public Sub insertarAlmacen(idSucursal As Integer, dscAlmacen As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_InsertarAlmacen"
            .Parameters.AddWithValue("@IdSucursal", idSucursal)
            .Parameters.AddWithValue("@DscAlmacen", dscAlmacen)
        End With
        cmd.Connection = Conexion()


        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub

    Public Sub editarAlmacen(idAlmacen As Integer, idSucursal As Integer, dscAlmacen As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EditarAlmacen"
            .Parameters.AddWithValue("@IdAlmacen", idAlmacen)
            .Parameters.AddWithValue("@IdSucursal", idSucursal)
            .Parameters.AddWithValue("@DscAlmacen", dscAlmacen)
        End With

        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub


    Public Sub eliminarAlmacen(idAlmacen As Integer)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EliminarAlmacen"
            .Parameters.AddWithValue("@IdAlmacen", idAlmacen)
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
            .CommandText = "sp_UltimoRegistroAlmacen"
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
