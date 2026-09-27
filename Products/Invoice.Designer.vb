<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        DataGridView1 = New DataGridView()
        Barcode = New DataGridViewTextBoxColumn()
        Category = New DataGridViewTextBoxColumn()
        ItemDescription = New DataGridViewTextBoxColumn()
        Color = New DataGridViewTextBoxColumn()
        Size = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        Brand = New DataGridViewTextBoxColumn()
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Button3 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        MenuStrip1 = New MenuStrip()
        PagesToolStripMenuItem = New ToolStripMenuItem()
        AddProductsToolStripMenuItem = New ToolStripMenuItem()
        ReportToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Barcode, Category, ItemDescription, Color, Size, Price, Quantity, Brand})
        DataGridView1.Location = New Point(12, 68)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1054, 454)
        DataGridView1.TabIndex = 0
        ' 
        ' Barcode
        ' 
        Barcode.HeaderText = "Barcode"
        Barcode.MinimumWidth = 6
        Barcode.Name = "Barcode"
        Barcode.ReadOnly = True
        Barcode.Width = 125
        ' 
        ' Category
        ' 
        Category.HeaderText = "Category"
        Category.MinimumWidth = 6
        Category.Name = "Category"
        Category.Width = 125
        ' 
        ' ItemDescription
        ' 
        ItemDescription.HeaderText = "Item Description"
        ItemDescription.MinimumWidth = 6
        ItemDescription.Name = "ItemDescription"
        ItemDescription.Width = 125
        ' 
        ' Color
        ' 
        Color.HeaderText = "Color"
        Color.MinimumWidth = 6
        Color.Name = "Color"
        Color.Width = 125
        ' 
        ' Size
        ' 
        Size.HeaderText = "Size"
        Size.MinimumWidth = 6
        Size.Name = "Size"
        Size.Resizable = DataGridViewTriState.True
        Size.Width = 125
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.MinimumWidth = 6
        Price.Name = "Price"
        Price.Width = 125
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Quantity"
        Quantity.MinimumWidth = 6
        Quantity.Name = "Quantity"
        Quantity.Width = 125
        ' 
        ' Brand
        ' 
        Brand.HeaderText = "Brand"
        Brand.MinimumWidth = 6
        Brand.Name = "Brand"
        Brand.Width = 125
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(664, 536)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(402, 143)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(288, 86)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 44)
        Button5.TabIndex = 7
        Button5.Text = "Clear"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(288, 26)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 44)
        Button1.TabIndex = 6
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 89)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 5
        Label4.Text = "Final Total"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 4
        Label3.Text = "Discount"
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(124, 86)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(122, 27)
        TextBox3.TabIndex = 2
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(124, 26)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(122, 27)
        TextBox2.TabIndex = 1
        TextBox2.Text = "0"
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.GrayText
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(238, 561)
        Button3.Name = "Button3"
        Button3.Size = New Size(147, 63)
        Button3.TabIndex = 3
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkRed
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(473, 561)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 63)
        Button2.TabIndex = 4
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.GradientInactiveCaption
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(12, 561)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 63)
        Button4.TabIndex = 5
        Button4.Text = "Select From List"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PagesToolStripMenuItem, HelpToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1078, 28)
        MenuStrip1.TabIndex = 6
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PagesToolStripMenuItem
        ' 
        PagesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddProductsToolStripMenuItem, ReportToolStripMenuItem})
        PagesToolStripMenuItem.Name = "PagesToolStripMenuItem"
        PagesToolStripMenuItem.Size = New Size(61, 24)
        PagesToolStripMenuItem.Text = "Pages"
        ' 
        ' AddProductsToolStripMenuItem
        ' 
        AddProductsToolStripMenuItem.Name = "AddProductsToolStripMenuItem"
        AddProductsToolStripMenuItem.Size = New Size(224, 26)
        AddProductsToolStripMenuItem.Text = "Add Products"
        ' 
        ' ReportToolStripMenuItem
        ' 
        ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        ReportToolStripMenuItem.Size = New Size(224, 26)
        ReportToolStripMenuItem.Text = "Report"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(47, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' Invoice
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(1078, 685)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.None
        MainMenuStrip = MenuStrip1
        Name = "Invoice"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Invoice"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Barcode As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescription As DataGridViewTextBoxColumn
    Friend WithEvents Color As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
End Class
