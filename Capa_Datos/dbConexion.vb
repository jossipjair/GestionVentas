Imports System.Data.Sql
Imports System.Data.SqlClient

Module dbConexion

    Dim conex As New SqlConnection("Data Source = .; Initial Catalog = dbGestionVentas; Integrated Security = True")
    Public adp As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public dt As DataTable

    Public Function Conexion() As SqlConnection
        Return conex
    End Function

    Public Sub Conectar()
        Conexion.Open()
    End Sub

    Public Sub Desconectar()
        Conexion.Close()
    End Sub


End Module
