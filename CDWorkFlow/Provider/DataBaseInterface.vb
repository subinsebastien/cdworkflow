﻿Imports System.Data.SqlClient

Public Class DataBaseInterface
    Public servern As String
    Dim con As SqlConnection
    Dim com As SqlCommand
    Dim rdr As SqlDataReader
    Dim obj As Object
    Dim ds As New DataSet
    Dim i As Integer

    Sub New()
        Dim conString As String = My.Computer.Name

        con = New SqlConnection("data Source=JOSEPH-PC\SQLEXPRESS;initial catalog=dbcdworkflow;integrated security=true")
        'conString = "data Source='" & conString & "';initial catalog=dbcdworkflow;integrated security=true"
        'MsgBox(conString)
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