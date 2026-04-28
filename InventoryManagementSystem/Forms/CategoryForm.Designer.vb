<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryForm
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
        lblTitle = New Label()
        lblCategoryName = New Label()
        lblDescription = New Label()
        txtCategoryName = New TextBox()
        txtDescription = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        lblSearch = New Label()
        txtSearch = New TextBox()
        dgvCategories = New DataGridView()
        CType(dgvCategories, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(32, 29)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(126, 17)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manage Categories"
        ' 
        ' lblCategoryName
        ' 
        lblCategoryName.AutoSize = True
        lblCategoryName.Location = New Point(32, 56)
        lblCategoryName.Name = "lblCategoryName"
        lblCategoryName.Size = New Size(90, 15)
        lblCategoryName.TabIndex = 1
        lblCategoryName.Text = "Category Name"
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(32, 110)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(67, 15)
        lblDescription.TabIndex = 2
        lblDescription.Text = "Description"
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.Location = New Point(32, 74)
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(226, 23)
        txtCategoryName.TabIndex = 4
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(32, 128)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(226, 73)
        txtDescription.TabIndex = 5
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(284, 73)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(284, 107)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 8
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(284, 144)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(284, 178)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(32, 224)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(42, 15)
        lblSearch.TabIndex = 12
        lblSearch.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(32, 242)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(478, 23)
        txtSearch.TabIndex = 13
        ' 
        ' dgvCategories
        ' 
        dgvCategories.AllowUserToAddRows = False
        dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCategories.Location = New Point(32, 271)
        dgvCategories.MultiSelect = False
        dgvCategories.Name = "dgvCategories"
        dgvCategories.ReadOnly = True
        dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCategories.Size = New Size(804, 251)
        dgvCategories.TabIndex = 14
        ' 
        ' CategoryForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 600)
        Controls.Add(dgvCategories)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtDescription)
        Controls.Add(txtCategoryName)
        Controls.Add(lblDescription)
        Controls.Add(lblCategoryName)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "CategoryForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Categories"
        CType(dgvCategories, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCategoryName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvCategories As DataGridView
End Class
