Public Class Register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox2.Text = TextBox3.Text Then
            AddToDatabase("INSERT INTO UserInfo (UserName, UserPass) VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "')")
            MsgBox("Registered successfully")
            Me.Hide()
            Login.Show()
        Else
            MsgBox("Please fill in all fields correctly.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeConnection()
    End Sub
End Class