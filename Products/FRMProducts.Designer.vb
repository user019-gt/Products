<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMProducts
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
        BarCodelbl = New Label()
        BarCode = New TextBox()
        SaveBTN = New Button()
        Categorylbl = New Label()
        Color = New TextBox()
        Colorlbl = New Label()
        Type = New TextBox()
        Typelbl = New Label()
        Brand = New TextBox()
        Label5 = New Label()
        Quantity = New TextBox()
        Label6 = New Label()
        BuyPrice = New TextBox()
        Label7 = New Label()
        SalePrice = New TextBox()
        Label8 = New Label()
        CategoryBox = New ComboBox()
        SizeBox = New ComboBox()
        Sizelbl = New Label()
        ClearBTN = New Button()
        ExitBTN = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' BarCodelbl
        ' 
        BarCodelbl.AutoSize = True
        BarCodelbl.Font = New Font("Segoe UI", 15F)
        BarCodelbl.Location = New Point(42, 57)
        BarCodelbl.Name = "BarCodelbl"
        BarCodelbl.Size = New Size(109, 35)
        BarCodelbl.TabIndex = 0
        BarCodelbl.Text = "BarCode"
        ' 
        ' BarCode
        ' 
        BarCode.Enabled = False
        BarCode.Font = New Font("Segoe UI", 15F)
        BarCode.Location = New Point(157, 57)
        BarCode.Margin = New Padding(3, 4, 3, 4)
        BarCode.MaxLength = 10
        BarCode.Name = "BarCode"
        BarCode.Size = New Size(166, 41)
        BarCode.TabIndex = 1
        ' 
        ' SaveBTN
        ' 
        SaveBTN.BackColor = Color.GreenYellow
        SaveBTN.FlatStyle = FlatStyle.Popup
        SaveBTN.Font = New Font("Segoe UI", 13.8F)
        SaveBTN.ForeColor = SystemColors.ControlText
        SaveBTN.Location = New Point(76, 426)
        SaveBTN.Margin = New Padding(3, 4, 3, 4)
        SaveBTN.Name = "SaveBTN"
        SaveBTN.Size = New Size(123, 55)
        SaveBTN.TabIndex = 3
        SaveBTN.Text = "Save"
        SaveBTN.UseVisualStyleBackColor = False
        ' 
        ' Categorylbl
        ' 
        Categorylbl.AutoSize = True
        Categorylbl.Font = New Font("Segoe UI", 15F)
        Categorylbl.Location = New Point(41, 133)
        Categorylbl.Name = "Categorylbl"
        Categorylbl.Size = New Size(115, 35)
        Categorylbl.TabIndex = 4
        Categorylbl.Text = "Category"
        ' 
        ' Color
        ' 
        Color.Font = New Font("Segoe UI", 15F)
        Color.Location = New Point(157, 252)
        Color.Margin = New Padding(3, 4, 3, 4)
        Color.MaxLength = 15
        Color.Name = "Color"
        Color.Size = New Size(166, 41)
        Color.TabIndex = 9
        ' 
        ' Colorlbl
        ' 
        Colorlbl.AutoSize = True
        Colorlbl.Font = New Font("Segoe UI", 15F)
        Colorlbl.Location = New Point(42, 252)
        Colorlbl.Name = "Colorlbl"
        Colorlbl.Size = New Size(75, 35)
        Colorlbl.TabIndex = 8
        Colorlbl.Text = "Color"
        ' 
        ' Type
        ' 
        Type.Font = New Font("Segoe UI", 15F)
        Type.Location = New Point(157, 192)
        Type.Margin = New Padding(3, 4, 3, 4)
        Type.MaxLength = 15
        Type.Name = "Type"
        Type.Size = New Size(166, 41)
        Type.TabIndex = 7
        ' 
        ' Typelbl
        ' 
        Typelbl.AutoSize = True
        Typelbl.Font = New Font("Segoe UI", 15F)
        Typelbl.Location = New Point(42, 192)
        Typelbl.Name = "Typelbl"
        Typelbl.Size = New Size(67, 35)
        Typelbl.TabIndex = 6
        Typelbl.Text = "Type"
        ' 
        ' Brand
        ' 
        Brand.Font = New Font("Segoe UI", 15F)
        Brand.Location = New Point(566, 298)
        Brand.Margin = New Padding(3, 4, 3, 4)
        Brand.MaxLength = 25
        Brand.Name = "Brand"
        Brand.Size = New Size(153, 41)
        Brand.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(457, 304)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 35)
        Label5.TabIndex = 16
        Label5.Text = "Brand"
        ' 
        ' Quantity
        ' 
        Quantity.Font = New Font("Segoe UI", 15F)
        Quantity.Location = New Point(566, 226)
        Quantity.Margin = New Padding(3, 4, 3, 4)
        Quantity.MaxLength = 4
        Quantity.Name = "Quantity"
        Quantity.Size = New Size(153, 41)
        Quantity.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(428, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 35)
        Label6.TabIndex = 14
        Label6.Text = "Quantity"
        ' 
        ' BuyPrice
        ' 
        BuyPrice.Font = New Font("Segoe UI", 15F)
        BuyPrice.Location = New Point(566, 158)
        BuyPrice.Margin = New Padding(3, 4, 3, 4)
        BuyPrice.MaxLength = 4
        BuyPrice.Name = "BuyPrice"
        BuyPrice.Size = New Size(153, 41)
        BuyPrice.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15F)
        Label7.Location = New Point(392, 161)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 35)
        Label7.TabIndex = 12
        Label7.Text = "Buy Unit Price"
        ' 
        ' SalePrice
        ' 
        SalePrice.Font = New Font("Segoe UI", 15F)
        SalePrice.Location = New Point(566, 91)
        SalePrice.Margin = New Padding(3, 4, 3, 4)
        SalePrice.MaxLength = 4
        SalePrice.Name = "SalePrice"
        SalePrice.Size = New Size(153, 41)
        SalePrice.TabIndex = 11
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.Location = New Point(387, 94)
        Label8.Name = "Label8"
        Label8.Size = New Size(173, 35)
        Label8.TabIndex = 10
        Label8.Text = "Sale Unit Price"
        ' 
        ' CategoryBox
        ' 
        CategoryBox.Font = New Font("Segoe UI", 15F)
        CategoryBox.FormattingEnabled = True
        CategoryBox.Items.AddRange(New Object() {"Mens Collection", "Women Collection"})
        CategoryBox.Location = New Point(157, 127)
        CategoryBox.Margin = New Padding(3, 4, 3, 4)
        CategoryBox.Name = "CategoryBox"
        CategoryBox.Size = New Size(166, 43)
        CategoryBox.TabIndex = 18
        ' 
        ' SizeBox
        ' 
        SizeBox.Font = New Font("Segoe UI", 15F)
        SizeBox.FormattingEnabled = True
        SizeBox.Items.AddRange(New Object() {"S", "M", "L", "XL"})
        SizeBox.Location = New Point(157, 329)
        SizeBox.Margin = New Padding(3, 4, 3, 4)
        SizeBox.Name = "SizeBox"
        SizeBox.Size = New Size(166, 43)
        SizeBox.TabIndex = 20
        ' 
        ' Sizelbl
        ' 
        Sizelbl.AutoSize = True
        Sizelbl.Font = New Font("Segoe UI", 15F)
        Sizelbl.Location = New Point(57, 333)
        Sizelbl.Name = "Sizelbl"
        Sizelbl.Size = New Size(58, 35)
        Sizelbl.TabIndex = 19
        Sizelbl.Text = "Size"
        ' 
        ' ClearBTN
        ' 
        ClearBTN.BackColor = SystemColors.HotTrack
        ClearBTN.FlatStyle = FlatStyle.Popup
        ClearBTN.Font = New Font("Segoe UI", 13.8F)
        ClearBTN.ForeColor = SystemColors.ButtonHighlight
        ClearBTN.Location = New Point(240, 426)
        ClearBTN.Margin = New Padding(3, 4, 3, 4)
        ClearBTN.Name = "ClearBTN"
        ClearBTN.Size = New Size(123, 55)
        ClearBTN.TabIndex = 23
        ClearBTN.Text = "Clear"
        ClearBTN.UseVisualStyleBackColor = False
        ' 
        ' ExitBTN
        ' 
        ExitBTN.BackColor = Color.Firebrick
        ExitBTN.FlatStyle = FlatStyle.Popup
        ExitBTN.Font = New Font("Segoe UI", 14F)
        ExitBTN.ForeColor = SystemColors.ControlLightLight
        ExitBTN.Location = New Point(566, 426)
        ExitBTN.Margin = New Padding(3, 4, 3, 4)
        ExitBTN.Name = "ExitBTN"
        ExitBTN.Size = New Size(123, 55)
        ExitBTN.TabIndex = 24
        ExitBTN.Text = "Exit"
        ExitBTN.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MistyRose
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        Button1.Location = New Point(404, 426)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(123, 55)
        Button1.TabIndex = 25
        Button1.Text = "See Invoice"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FRMProducts
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(745, 517)
        Controls.Add(Button1)
        Controls.Add(ExitBTN)
        Controls.Add(ClearBTN)
        Controls.Add(SizeBox)
        Controls.Add(Sizelbl)
        Controls.Add(CategoryBox)
        Controls.Add(Brand)
        Controls.Add(Label5)
        Controls.Add(Quantity)
        Controls.Add(Label6)
        Controls.Add(BuyPrice)
        Controls.Add(Label7)
        Controls.Add(SalePrice)
        Controls.Add(Color)
        Controls.Add(Colorlbl)
        Controls.Add(Type)
        Controls.Add(Typelbl)
        Controls.Add(Categorylbl)
        Controls.Add(SaveBTN)
        Controls.Add(BarCode)
        Controls.Add(BarCodelbl)
        Controls.Add(Label8)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FRMProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FRMProducts"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BarCodelbl As Label
    Friend WithEvents BarCode As TextBox
    Friend WithEvents SaveBTN As Button
    Friend WithEvents Categorylbl As Label
    Friend WithEvents Color As TextBox
    Friend WithEvents Colorlbl As Label
    Friend WithEvents Type As TextBox
    Friend WithEvents Typelbl As Label
    Friend WithEvents Brand As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Quantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BuyPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SalePrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CategoryBox As ComboBox
    Friend WithEvents SizeBox As ComboBox
    Friend WithEvents Sizelbl As Label
    Friend WithEvents ClearBTN As Button
    Friend WithEvents ExitBTN As Button
    Friend WithEvents Button1 As Button
End Class
