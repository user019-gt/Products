Public Class Invoice
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        FRMProducts.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClearBoxes()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Final_total As Double
        Dim Total As Double = 0
        Dim Discount As Decimal = 0
        Discount = TextBox2.Text
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("Price").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("Price").Value) Then
                Total += Convert.ToDecimal(row.Cells("Price").Value)
            End If
        Next
        Final_total = Total - (Total * Discount / 100)
        TextBox3.Text = Final_total
    End Sub

    Private Sub DataGridView1_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) _
        Handles DataGridView1.DefaultValuesNeeded

        e.Row.Cells("BarCode").Value = GenerateBarCode()

    End Sub

    Function ClearBoxes()
        TextBox2.Text = 0
        TextBox3.Clear()
        Return True
    End Function

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns("BarCode").ReadOnly = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("This is a test Project!!")
    End Sub

    Private Sub AddProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductsToolStripMenuItem.Click
        Me.Hide()
        FRMProducts.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class