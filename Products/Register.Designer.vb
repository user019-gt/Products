<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button2 = New Button()
        TextBox2 = New TextBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.BurlyWood
        Button2.Font = New Font("Segoe UI", 13F)
        Button2.Location = New Point(168, 279)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 45)
        Button2.TabIndex = 9
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 17F)
        TextBox2.Location = New Point(32, 115)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(244, 45)
        TextBox2.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Chartreuse
        Button1.Font = New Font("Segoe UI", 13F)
        Button1.Location = New Point(32, 279)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 45)
        Button1.TabIndex = 7
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 17F)
        TextBox1.Location = New Point(32, 36)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "UserName"
        TextBox1.Size = New Size(244, 45)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 17F)
        TextBox3.Location = New Point(32, 193)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Password"
        TextBox3.Size = New Size(244, 45)
        TextBox3.TabIndex = 10
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(319, 371)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
