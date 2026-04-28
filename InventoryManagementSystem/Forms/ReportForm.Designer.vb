<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        lblLowStockProducts = New Label()
        lblTotalSuppliers = New Label()
        dgvLowStock = New DataGridView()
        btnRefresh = New Button()
        lblTotalCategories = New Label()
        lblTotalProducts = New Label()
        lblTitle = New Label()
        lblTotalTransactions = New Label()
        CType(dgvLowStock, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblLowStockProducts
        ' 
        lblLowStockProducts.AutoSize = True
        lblLowStockProducts.Location = New Point(32, 132)
        lblLowStockProducts.Name = "lblLowStockProducts"
        lblLowStockProducts.Size = New Size(123, 15)
        lblLowStockProducts.TabIndex = 62
        lblLowStockProducts.Text = "Low Stock Products: 0"
        ' 
        ' lblTotalSuppliers
        ' 
        lblTotalSuppliers.AutoSize = True
        lblTotalSuppliers.Location = New Point(32, 107)
        lblTotalSuppliers.Name = "lblTotalSuppliers"
        lblTotalSuppliers.Size = New Size(96, 15)
        lblTotalSuppliers.TabIndex = 60
        lblTotalSuppliers.Text = "Total Suppliers: 0"
        ' 
        ' dgvLowStock
        ' 
        dgvLowStock.AllowUserToAddRows = False
        dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLowStock.Location = New Point(32, 224)
        dgvLowStock.MultiSelect = False
        dgvLowStock.Name = "dgvLowStock"
        dgvLowStock.ReadOnly = True
        dgvLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLowStock.Size = New Size(804, 251)
        dgvLowStock.TabIndex = 59
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(32, 195)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 55
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' lblTotalCategories
        ' 
        lblTotalCategories.AutoSize = True
        lblTotalCategories.Location = New Point(31, 82)
        lblTotalCategories.Name = "lblTotalCategories"
        lblTotalCategories.Size = New Size(104, 15)
        lblTotalCategories.TabIndex = 53
        lblTotalCategories.Text = "Total Categories: 0"
        ' 
        ' lblTotalProducts
        ' 
        lblTotalProducts.AutoSize = True
        lblTotalProducts.Location = New Point(32, 57)
        lblTotalProducts.Name = "lblTotalProducts"
        lblTotalProducts.Size = New Size(95, 15)
        lblTotalProducts.TabIndex = 52
        lblTotalProducts.Text = "Total Products: 0"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(32, 30)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(119, 17)
        lblTitle.TabIndex = 51
        lblTitle.Text = "Inventory Reports"
        ' 
        ' lblTotalTransactions
        ' 
        lblTotalTransactions.AutoSize = True
        lblTotalTransactions.Location = New Point(32, 157)
        lblTotalTransactions.Name = "lblTotalTransactions"
        lblTotalTransactions.Size = New Size(146, 15)
        lblTotalTransactions.TabIndex = 63
        lblTotalTransactions.Text = "Total Stock Transactions: 0"
        ' 
        ' ReportForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(lblTotalTransactions)
        Controls.Add(lblLowStockProducts)
        Controls.Add(lblTotalSuppliers)
        Controls.Add(dgvLowStock)
        Controls.Add(btnRefresh)
        Controls.Add(lblTotalCategories)
        Controls.Add(lblTotalProducts)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.None
        Name = "ReportForm"
        Text = "Reports"
        CType(dgvLowStock, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblLowStockProducts As Label
    Friend WithEvents lblTotalSuppliers As Label
    Friend WithEvents dgvLowStock As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblTotalCategories As Label
    Friend WithEvents lblTotalProducts As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTotalTransactions As Label
End Class
