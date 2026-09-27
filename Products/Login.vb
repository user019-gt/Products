Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SQL As String
        SQL = "SELECT * FROM UserInfo WHERE UserName = '" & TextBox1.Text & "' AND UserPass = '" & TextBox2.Text & "'"
        Conn.Open()
        Dim cmd As New OleDb.OleDbCommand(SQL, Conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Try
            If dr.Read = False Then
                MsgBox("Not Found.")
                Conn.Close()
            Else
                MsgBox("Found.")
                Conn.Close()
                'Form1.Show()
                'Me.Hide()
                Me.Hide()
                Form1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class