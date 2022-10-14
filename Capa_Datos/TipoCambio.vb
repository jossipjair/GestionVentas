Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class TipoCambio

    Public Function mostrarTipoCambio() As DataTable
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_MostrarTipoCambio"
        End With

        dt = New DataTable
        Conectar()
        dr = cmd.ExecuteReader
        dt.Load(dr)
        Desconectar()
        Return dt

    End Function

    Public Sub insertarTipoCambio(fecha As Date, dolarCompra As Double, dolarVenta As Double, euroCompra As Double, euroVenta As Double)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_InsertarTipoCambio"
            .Parameters.AddWithValue("@fecha", fecha)
            .Parameters.AddWithValue("@DolarCompra", dolarCompra)
            .Parameters.AddWithValue("@DolarVenta", dolarVenta)
            .Parameters.AddWithValue("@EuroCompra", euroCompra)
            .Parameters.AddWithValue("@EuroVenta", euroVenta)
        End With
        cmd.Connection = Conexion()


        Conectar()
        cmd.ExecuteNonQuery()
        Desconectar()

    End Sub

    Public Sub editarTipoCambio(idTipoCambio As Integer, dolarCompra As Double, dolarVenta As Double, euroCompra As Double, euroVenta As Double)
        Desconectar()
        cmd = New SqlCommand
        With cmd
            .Connection = Conexion()
            .CommandType = CommandType.StoredProcedure
            .CommandText = "sp_EditarTipoCambio"
            .Parameters.AddWithValue("@Id", idTipoCambio)
            .Parameters.AddWithValue("@DolarCompra", dolarCompra)
            .Parameters.AddWithValue("@DolarVenta", dolarVenta)
            .Parameters.AddWithValue("@EuroCompra", euroCompra)
            .Parameters.AddWithValue("@EuroVenta", euroVenta)
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
            .CommandText = "sp_UltimoRegistroTipoCambio"
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
