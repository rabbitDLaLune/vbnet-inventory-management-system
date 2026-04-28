<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierForm
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
        dgvSuppliers = New DataGridView()
        txtSearch = New TextBox()
        lblSearch = New Label()
        btnClear = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnAdd = New Button()
        txtPhone = New TextBox()
        txtSupplierName = New TextBox()
        lblPhone = New Label()
        lblSupplierName = New Label()
        lblTitle = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        txtAddress = New TextBox()
        lblAddress = New Label()
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvSuppliers
        ' 
        dgvSuppliers.AllowUserToAddRows = False
        dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSuppliers.Location = New Point(32, 271)
        dgvSuppliers.MultiSelect = False
        dgvSuppliers.Name = "dgvSuppliers"
        dgvSuppliers.ReadOnly = True
        dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSuppliers.Size = New Size(804, 251)
        dgvSuppliers.TabIndex = 27
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(32, 242)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(478, 23)
        txtSearch.TabIndex = 26
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(32, 224)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(42, 15)
        lblSearch.TabIndex = 25
        lblSearch.Text = "Search"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(537, 178)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 23
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(537, 143)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 22
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(537, 108)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 21
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(537, 73)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 20
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(285, 74)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(226, 23)
        txtPhone.TabIndex = 19
        ' 
        ' txtSupplierName
        ' 
        txtSupplierName.Location = New Point(32, 74)
        txtSupplierName.Name = "txtSupplierName"
        txtSupplierName.Size = New Size(226, 23)
        txtSupplierName.TabIndex = 18
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(285, 56)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(41, 15)
        lblPhone.TabIndex = 17
        lblPhone.Text = "Phone"
        ' 
        ' lblSupplierName
        ' 
        lblSupplierName.AutoSize = True
        lblSupplierName.Location = New Point(32, 56)
        lblSupplierName.Name = "lblSupplierName"
        lblSupplierName.Size = New Size(85, 15)
        lblSupplierName.TabIndex = 16
        lblSupplierName.Text = "Supplier Name"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(32, 29)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(118, 17)
        lblTitle.TabIndex = 15
        lblTitle.Text = "Manage Suppliers"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(32, 128)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(226, 23)
        txtEmail.TabIndex = 29
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(32, 110)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(36, 15)
        lblEmail.TabIndex = 28
        lblEmail.Text = "Email"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(285, 128)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(226, 73)
        txtAddress.TabIndex = 31
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(285, 110)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(49, 15)
        lblAddress.TabIndex = 30
        lblAddress.Text = "Address"
        ' 
        ' SupplierForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 600)
        Controls.Add(txtAddress)
        Controls.Add(lblAddress)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(dgvSuppliers)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(txtPhone)
        Controls.Add(txtSupplierName)
        Controls.Add(lblPhone)
        Controls.Add(lblSupplierName)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "SupplierForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Suppliers"
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblSupplierName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
End Class
