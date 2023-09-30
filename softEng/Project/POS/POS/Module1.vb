Imports System.Data.OleDb
Module Module1
    Public connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= C:\Users\Akito Yamada\Desktop\Demo\dbDemo.mdb"
    Public conn As New OleDbConnection(connStr)

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function
End Module
