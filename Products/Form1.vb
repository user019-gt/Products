Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar

Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = True
    End Sub

    Private Sub MensCollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MensCollectionToolStripMenuItem.Click
        Dim sql As String = "SELECT * FROM Products WHERE Category LIKE 'Men%'"
        Using cn As New OleDbConnection(Conn.ConnectionString)
            Using da As New OleDbDataAdapter(sql, cn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        End Using
        DeleteBTN.Visible = True
        DbDelete.Visible = True
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        FRMProducts.Show()
    End Sub

    Public Sub GenerateBarCode()
        Randomize() ' Initialize the random number generator
        Dim randomNumber As Integer = Int((99999 - 10000 + 1) * Rnd() + 10000)
        FRMProducts.BarCode.Text = randomNumber.ToString()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("This is a test Project!!, Press the report button on the top corner and choose")
    End Sub

    Private Sub WomenCollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WomenCollectionToolStripMenuItem.Click
        Dim sql As String = "Select * FROM Products WHERE Category Like 'Wom%'"
        Using cn As New OleDbConnection(Conn.ConnectionString)
            Using da As New OleDbDataAdapter(sql, cn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        End Using
        DeleteBTN.Visible = True
        DbDelete.Visible = True
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        MsgBox("deleted successfully")
    End Sub

    Private Sub DbDelete_Click(sender As Object, e As EventArgs) Handles DbDelete.Click
        Dim barCode As String = DataGridView1.CurrentRow.Cells("BarCode").Value.ToString()
        AddToDatabase("DELETE FROM Products WHERE [BarCode] = '" & barCode & "'")
        MsgBox("deleted successfully")
        resetfct()
    End Sub

    Public Sub resetfct()
        DeleteBTN.Visible = False
        DbDelete.Visible = False
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim productGrid As DataGridView = DataGridView1   ' your products list grid

        If productGrid.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one product.")
            Return
        End If

        Dim selected = productGrid.SelectedRows.Cast(Of DataGridViewRow)() _
                                                  .OrderBy(Function(r) r.Index)

        Dim skipped As Integer = 0

        For Each row In selected
            If row.IsNewRow Then Continue For

            Dim Barcode As String = row.Cells("BarCode").Value.ToString()

            If ExistsOnInvoice(Barcode) Then
                skipped += 1
                Continue For
            End If

            Dim Category As String = row.Cells("Category").Value.ToString()
            Dim ItemDescription As String = row.Cells("ItemDescription").Value.ToString()
            Dim Color As String = row.Cells("Color").Value.ToString()
            Dim Size As String = row.Cells("Size").Value.ToString()
            Dim Quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
            Dim Price As Decimal = Convert.ToDecimal(row.Cells("SaleUnitPrice").Value)
            Dim Brand As String = row.Cells("Brand").Value.ToString()

            Invoice.DataGridView1.Rows.Add(Barcode, Category, ItemDescription, Color, Size, Price, Quantity, Brand)
        Next

        If skipped > 0 Then
            MessageBox.Show(skipped & " item(s) were already on the invoice and were skipped.")
        End If

    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click

    End Sub

    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem.Click
        Dim sql As String = "SELECT * FROM Products"
        Using cn As New OleDbConnection(Conn.ConnectionString)
            Using da As New OleDbDataAdapter(sql, cn)
                Dim dt As New DataTable()
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        Me.Hide()
        Invoice.Show()
    End Sub


    Private Function ExistsOnInvoice(barcode As String) As Boolean

        For Each invRow As DataGridViewRow In Invoice.DataGridView1.Rows
            If invRow.IsNewRow Then Continue For
            If invRow.Cells("Barcode").Value IsNot Nothing AndAlso
               invRow.Cells("Barcode").Value.ToString() = barcode Then
                Return True
            End If
        Next

        Return False

    End Function
End Class
