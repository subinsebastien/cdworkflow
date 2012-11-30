Imports System.Data.SqlClient

Public Class DataBaseInterface
    Public servern As String
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim rdr As SqlDataReader
    Dim obj As Object
    Dim ds As New DataSet
    Dim i As Integer

    Sub New()
        Dim connectionString As String = "data Source=[HOST_NAME]\SQLEXPRESS;initial catalog=dbcdworkflow;integrated security=true"
        connectionString = connectionString.Replace("[HOST_NAME]", My.Computer.Name)
        con = New SqlConnection(connectionString)
        com = New SqlCommand
        com.Connection = con
    End Sub

    Function manipulate(ByVal str As String)
        con.Close()
        com.CommandType = CommandType.Text
        com.CommandText = str
        con.Open()
        i = com.ExecuteNonQuery
        Return i
    End Function

    Function reader(ByVal str As String) As SqlDataReader
        con.Close()
        com.CommandType = CommandType.Text
        com.CommandText = str
        con.Open()
        rdr = com.ExecuteReader
        Return rdr
    End Function

    Function exscalar(ByVal str As String) As Object
        con.Close()
        com.CommandType = CommandType.Text
        com.CommandText = str
        con.Open()
        obj = com.ExecuteScalar
        Return obj
    End Function

End Class