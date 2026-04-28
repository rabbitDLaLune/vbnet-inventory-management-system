<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockForm
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
        txtNotes = New TextBox()
        lblNotes = New Label()
        txtQuantity = New TextBox()
        lblQuantity = New Label()
        dgvTransactions = New DataGridView()
        txtSearch = New TextBox()
        lblSearch = New Label()
        btnClear = New Button()
        btnSave = New Button()
        lblTransactionType = New Label()
        lblProduct = New Label()
        lblTitle = New Label()
        cmbProduct = New ComboBox()
        cmbTransactionType = New ComboBox()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(284, 128)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(226, 73)
        txtNotes.TabIndex = 48
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.Location = New Point(284, 110)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(38, 15)
        lblNotes.TabIndex = 47
        lblNotes.Text = "Notes"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(32, 128)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(226, 23)
        txtQuantity.TabIndex = 46
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(32, 110)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(53, 15)
        lblQuantity.TabIndex = 45
        lblQuantity.Text = "Quantity"
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.AllowUserToAddRows = False
        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Location = New Point(32, 271)
        dgvTransactions.MultiSelect = False
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.ReadOnly = True
        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactions.Size = New Size(804, 251)
        dgvTransactions.TabIndex = 44
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(32, 242)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(478, 23)
        txtSearch.TabIndex = 43
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(32, 224)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(42, 15)
        lblSearch.TabIndex = 42
        lblSearch.Text = "Search"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(537, 106)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 40
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(537, 74)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(131, 23)
        btnSave.TabIndex = 37
        btnSave.Text = "Save Transaction"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' lblTransactionType
        ' 
        lblTransactionType.AutoSize = True
        lblTransactionType.Location = New Point(284, 56)
        lblTransactionType.Name = "lblTransactionType"
        lblTransactionType.Size = New Size(96, 15)
        lblTransactionType.TabIndex = 34
        lblTransactionType.Text = "Transaction Type"
        ' 
        ' lblProduct
        ' 
        lblProduct.AutoSize = True
        lblProduct.Location = New Point(32, 56)
        lblProduct.Name = "lblProduct"
        lblProduct.Size = New Size(49, 15)
        lblProduct.TabIndex = 33
        lblProduct.Text = "Product"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(32, 29)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(131, 17)
        lblTitle.TabIndex = 32
        lblTitle.Text = "Stock In / Stock Out"
        ' 
        ' cmbProduct
        ' 
        cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProduct.FormattingEnabled = True
        cmbProduct.Location = New Point(32, 74)
        cmbProduct.Name = "cmbProduct"
        cmbProduct.Size = New Size(226, 23)
        cmbProduct.TabIndex = 49
        ' 
        ' cmbTransactionType
        ' 
        cmbTransactionType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTransactionType.FormattingEnabled = True
        cmbTransactionType.Location = New Point(284, 74)
        cmbTransactionType.Name = "cmbTransactionType"
        cmbTransactionType.Size = New Size(226, 23)
        cmbTransactionType.TabIndex = 50
        ' 
        ' StockForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 600)
        Controls.Add(cmbTransactionType)
        Controls.Add(cmbProduct)
        Controls.Add(txtNotes)
        Controls.Add(lblNotes)
        Controls.Add(txtQuantity)
        Controls.Add(lblQuantity)
        Controls.Add(dgvTransactions)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(lblTransactionType)
        Controls.Add(lblProduct)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "StockForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Stock In / Stock Out"
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNotes As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents dgvTransactions As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents lblTransactionType As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents cmbTransactionType As ComboBox
End Class
