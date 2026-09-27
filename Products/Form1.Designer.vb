<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        AddToolStripMenuItem = New ToolStripMenuItem()
        ReportToolStripMenuItem = New ToolStripMenuItem()
        MensCollectionToolStripMenuItem = New ToolStripMenuItem()
        WomenCollectionToolStripMenuItem = New ToolStripMenuItem()
        AllToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ResetToolStripMenuItem = New ToolStripMenuItem()
        InvoiceToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        DataGridView1 = New DataGridView()
        DeleteBTN = New Button()
        DbDelete = New Button()
        Button1 = New Button()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AddToolStripMenuItem, ReportToolStripMenuItem, HelpToolStripMenuItem, ResetToolStripMenuItem, InvoiceToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(1006, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AddToolStripMenuItem
        ' 
        AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        AddToolStripMenuItem.Size = New Size(51, 24)
        AddToolStripMenuItem.Text = "Add"
        ' 
        ' ReportToolStripMenuItem
        ' 
        ReportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MensCollectionToolStripMenuItem, WomenCollectionToolStripMenuItem, AllToolStripMenuItem})
        ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        ReportToolStripMenuItem.Size = New Size(68, 24)
        ReportToolStripMenuItem.Text = "Report"
        ' 
        ' MensCollectionToolStripMenuItem
        ' 
        MensCollectionToolStripMenuItem.Name = "MensCollectionToolStripMenuItem"
        MensCollectionToolStripMenuItem.Size = New Size(214, 26)
        MensCollectionToolStripMenuItem.Text = "Mens Collection"
        ' 
        ' WomenCollectionToolStripMenuItem
        ' 
        WomenCollectionToolStripMenuItem.Name = "WomenCollectionToolStripMenuItem"
        WomenCollectionToolStripMenuItem.Size = New Size(214, 26)
        WomenCollectionToolStripMenuItem.Text = "Women Collection"
        ' 
        ' AllToolStripMenuItem
        ' 
        AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        AllToolStripMenuItem.Size = New Size(214, 26)
        AllToolStripMenuItem.Text = "All"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' ResetToolStripMenuItem
        ' 
        ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        ResetToolStripMenuItem.Size = New Size(59, 24)
        ResetToolStripMenuItem.Text = "Reset"
        ' 
        ' InvoiceToolStripMenuItem
        ' 
        InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        InvoiceToolStripMenuItem.Size = New Size(70, 24)
        InvoiceToolStripMenuItem.Text = "Invoice"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(47, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(48, 69)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(909, 427)
        DataGridView1.TabIndex = 1
        ' 
        ' DeleteBTN
        ' 
        DeleteBTN.Font = New Font("Segoe UI", 14F)
        DeleteBTN.Location = New Point(403, 529)
        DeleteBTN.Margin = New Padding(3, 4, 3, 4)
        DeleteBTN.Name = "DeleteBTN"
        DeleteBTN.Size = New Size(159, 59)
        DeleteBTN.TabIndex = 2
        DeleteBTN.Text = "Delete"
        DeleteBTN.UseVisualStyleBackColor = True
        ' 
        ' DbDelete
        ' 
        DbDelete.Font = New Font("Segoe UI", 14F)
        DbDelete.Location = New Point(713, 529)
        DbDelete.Margin = New Padding(3, 4, 3, 4)
        DbDelete.Name = "DbDelete"
        DbDelete.Size = New Size(205, 59)
        DbDelete.TabIndex = 3
        DbDelete.Text = "Delete From DB"
        DbDelete.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(83, 529)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 59)
        Button1.TabIndex = 4
        Button1.Text = "Add To Invoice"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1006, 615)
        Controls.Add(Button1)
        Controls.Add(DbDelete)
        Controls.Add(DeleteBTN)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MensCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WomenCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DeleteBTN As Button
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DbDelete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents AllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem

End Class
