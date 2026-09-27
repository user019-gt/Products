Imports System.Data.OleDb
Module Module1
    Public Conn As New OleDbConnection

    Public Sub InitializeConnection()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\qwerty\Documents\Coding\Visual Sudio\Access Files\Products.accdb;"

        'Conn.Open()
        'MsgBox("Connecion with Success")
    End Sub

    Public Sub AddToDatabase(sql As String)
        Dim cmd As New OleDbCommand
        Conn.Open()
        cmd.Connection = Conn
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub

    Public Function GenerateBarCode() As String
        Randomize() ' Initialize the random number generator
        Dim randomNumber As Integer = Int((99999 - 10000 + 1) * Rnd() + 10000)
        FRMProducts.BarCode.Text = randomNumber.ToString()
        Return True
    End Function
End Module
