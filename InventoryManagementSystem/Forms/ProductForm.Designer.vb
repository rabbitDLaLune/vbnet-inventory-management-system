<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Label1 = New Label()
        lblProductName = New Label()
        txtProductName = New TextBox()
        lblCategory = New Label()
        cmbCategory = New ComboBox()
        lblSupplier = New Label()
        cmbSupplier = New ComboBox()
        lblCostPrice = New Label()
        txtCostPrice = New TextBox()
        lblSellingPrice = New Label()
        txtSellingPrice = New TextBox()
        lblQuantity = New Label()
        txtQuantity = New TextBox()
        lblReorderLevel = New Label()
        txtReorderLevel = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        lblSearch = New Label()
        txtSearch = New TextBox()
        dgvProducts = New DataGridView()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(32, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 17)
        Label1.TabIndex = 0
        Label1.Text = "Manage Products"
        ' 
        ' lblProductName
        ' 
        lblProductName.AutoSize = True
        lblProductName.Location = New Point(35, 56)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(84, 15)
        lblProductName.TabIndex = 1
        lblProductName.Text = "Product Name"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(35, 74)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(226, 23)
        txtProductName.TabIndex = 2
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(287, 56)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(55, 15)
        lblCategory.TabIndex = 3
        lblCategory.Text = "Category"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.FormattingEnabled = True
        cmbCategory.Location = New Point(287, 74)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(226, 23)
        cmbCategory.TabIndex = 4
        ' 
        ' lblSupplier
        ' 
        lblSupplier.AutoSize = True
        lblSupplier.Location = New Point(539, 56)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New Size(50, 15)
        lblSupplier.TabIndex = 5
        lblSupplier.Text = "Supplier"
        ' 
        ' cmbSupplier
        ' 
        cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSupplier.FormattingEnabled = True
        cmbSupplier.Location = New Point(539, 74)
        cmbSupplier.Name = "cmbSupplier"
        cmbSupplier.Size = New Size(226, 23)
        cmbSupplier.TabIndex = 6
        ' 
        ' lblCostPrice
        ' 
        lblCostPrice.AutoSize = True
        lblCostPrice.Location = New Point(35, 110)
        lblCostPrice.Name = "lblCostPrice"
        lblCostPrice.Size = New Size(60, 15)
        lblCostPrice.TabIndex = 7
        lblCostPrice.Text = "Cost Price"
        ' 
        ' txtCostPrice
        ' 
        txtCostPrice.Location = New Point(35, 128)
        txtCostPrice.Name = "txtCostPrice"
        txtCostPrice.Size = New Size(226, 23)
        txtCostPrice.TabIndex = 8
        ' 
        ' lblSellingPrice
        ' 
        lblSellingPrice.AutoSize = True
        lblSellingPrice.Location = New Point(287, 110)
        lblSellingPrice.Name = "lblSellingPrice"
        lblSellingPrice.Size = New Size(71, 15)
        lblSellingPrice.TabIndex = 9
        lblSellingPrice.Text = "Selling Price"
        ' 
        ' txtSellingPrice
        ' 
        txtSellingPrice.Location = New Point(287, 128)
        txtSellingPrice.Name = "txtSellingPrice"
        txtSellingPrice.Size = New Size(226, 23)
        txtSellingPrice.TabIndex = 10
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(539, 110)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(53, 15)
        lblQuantity.TabIndex = 11
        lblQuantity.Text = "Quantity"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(539, 128)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(226, 23)
        txtQuantity.TabIndex = 12
        ' 
        ' lblReorderLevel
        ' 
        lblReorderLevel.AutoSize = True
        lblReorderLevel.Location = New Point(35, 164)
        lblReorderLevel.Name = "lblReorderLevel"
        lblReorderLevel.Size = New Size(78, 15)
        lblReorderLevel.TabIndex = 13
        lblReorderLevel.Text = "Reorder Level"
        ' 
        ' txtReorderLevel
        ' 
        txtReorderLevel.Location = New Point(35, 182)
        txtReorderLevel.Name = "txtReorderLevel"
        txtReorderLevel.Size = New Size(226, 23)
        txtReorderLevel.TabIndex = 14
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(287, 182)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 15
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(368, 182)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 16
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(449, 182)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 17
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(530, 182)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 18
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(35, 238)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(42, 15)
        lblSearch.TabIndex = 20
        lblSearch.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(35, 256)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(478, 23)
        txtSearch.TabIndex = 21
        ' 
        ' dgvProducts
        ' 
        dgvProducts.AllowUserToAddRows = False
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(35, 285)
        dgvProducts.MultiSelect = False
        dgvProducts.Name = "dgvProducts"
        dgvProducts.ReadOnly = True
        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProducts.Size = New Size(804, 251)
        dgvProducts.TabIndex = 22
        ' 
        ' ProductForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(dgvProducts)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtReorderLevel)
        Controls.Add(lblReorderLevel)
        Controls.Add(txtQuantity)
        Controls.Add(lblQuantity)
        Controls.Add(txtSellingPrice)
        Controls.Add(lblSellingPrice)
        Controls.Add(txtCostPrice)
        Controls.Add(lblCostPrice)
        Controls.Add(cmbSupplier)
        Controls.Add(lblSupplier)
        Controls.Add(cmbCategory)
        Controls.Add(lblCategory)
        Controls.Add(txtProductName)
        Controls.Add(lblProductName)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ProductForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Products"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblSupplier As Label
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents lblCostPrice As Label
    Friend WithEvents txtCostPrice As TextBox
    Friend WithEvents lblSellingPrice As Label
    Friend WithEvents txtSellingPrice As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblReorderLevel As Label
    Friend WithEvents txtReorderLevel As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvProducts As DataGridView
End Class
