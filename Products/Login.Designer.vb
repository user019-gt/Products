<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Button2 = New Button()
        LinkLabel1 = New LinkLabel()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 17F)
        TextBox1.Location = New Point(43, 48)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "UserName"
        TextBox1.Size = New Size(244, 45)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Chartreuse
        Button1.Font = New Font("Segoe UI", 13F)
        Button1.Location = New Point(43, 267)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 45)
        Button1.TabIndex = 1
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 17F)
        TextBox2.Location = New Point(43, 131)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(244, 45)
        TextBox2.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ControlLightLight
        Button2.Font = New Font("Segoe UI", 13F)
        Button2.Location = New Point(179, 267)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 45)
        Button2.TabIndex = 3
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 12F)
        LinkLabel1.Location = New Point(194, 199)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(82, 28)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Register"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(43, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 28)
        Label1.TabIndex = 5
        Label1.Text = "No account?"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(325, 333)
        Controls.Add(Label1)
        Controls.Add(LinkLabel1)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
End Class
