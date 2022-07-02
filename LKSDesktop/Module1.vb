Imports System.Data
Imports System.Data.SqlClient
Module Module1
    Dim conn As SqlConnection
    Public sessionid As Integer = 1
    Public sessionnm As String
    Public Function konek() As SqlConnection
        conn = New SqlConnection("data source=localhost\SQLEXPRESS; initial catalog=LKSKasir; integrated security=true")
        conn.Open()
        Return conn
    End Function
End Module
