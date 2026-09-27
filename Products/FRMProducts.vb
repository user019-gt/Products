Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class FRMProducts
    Private Sub FRMProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.GenerateBarCode()
        InitializeConnection()
    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As EventArgs) Handles ExitBTN.Click
        End
    End Sub

    Private Sub clearForm()
        Form1.GenerateBarCode()
        Type.Clear()
        Color.Clear()
        SalePrice.Clear()
        BuyPrice.Clear()
        Quantity.Clear()
        Brand.Clear()
    End Sub

    Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
        clearForm()
    End Sub

    Public Function CheckExistingProduct() As Boolean
        Dim SQL As String
        SQL = "SELECT * FROM Products WHERE Barcode = '" & BarCode.Text & "'"
        Conn.Open()
        Dim cmd As New OleDb.OleDbCommand(SQL, Conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Try
            If dr.Read = False Then
                Conn.Close()
                Return False
            Else
                Conn.Close()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            Conn.Close()
        End Try
        Return True
    End Function

    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        If CategoryBox.Text <> "" And Type.Text <> "" And Color.Text <> "" And SizeBox.Text <> "" And IsNumeric(SalePrice.Text) And IsNumeric(BuyPrice.Text) And IsNumeric(Quantity.Text) And Brand.Text <> "" Then
            If CheckExistingProduct() Then
                MsgBox("Already exists")
                clearForm()
            Else
                AddToDatabase("INSERT INTO Products ([BarCode], [Category], [ItemDescription], [Color], [Size], [SaleUnitPrice], [BuyUnitPrice], [Quantity], [Brand], [Description]) VALUES ('" & BarCode.Text & "', '" & CategoryBox.Text & "', '" & [Type].Text & "', '" & Color.Text & "', '" & SizeBox.Text & "', " & SalePrice.Text & ", " & BuyPrice.Text & ", " & Quantity.Text & ", '" & Brand.Text & "')")
                MsgBox("added successfully")
                clearForm()
            End If
        Else
            MsgBox("Please fill in all fields correctly.")
        End If
    End Sub

    Private Sub Description_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Invoice.Show()
    End Sub
End Class