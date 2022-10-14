Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Sucursales

    Public Function mostrarSucursal() As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarSucursal"
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()
        Return dt

    End Function

    Public Function listarSucursal() As DataTable

        adp = New SqlDataAdapter("SELECT * FROM sucursal", Conexion)
        ds = New DataSet

        adp.Fill(ds, "Sucursal")

        Return ds.Tables(0)

    End Function


    Public Sub insertarSucursal(dscSucursal As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_InsertarSucursal"
            .Parameters.AddWithValue("@Dsc", dscSucursal)
        End With
        cmd.Connection = Conexion()


        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub

    Public Sub editarSucursal(idSucursal As Integer, dscSucursal As String)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EditarSucursal"
            .Parameters.AddWithValue("@Id", idSucursal)
            .Parameters.AddWithValue("@Dsc", dscSucursal)
        End With

        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub


    Public Sub eliminarSucursal(idSucursal As Integer)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EliminarSucursal"
            .Parameters.AddWithValue("@Id", idSucursal)
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
            .CommandText = "sp_UltimoRegistrSucursal"
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
