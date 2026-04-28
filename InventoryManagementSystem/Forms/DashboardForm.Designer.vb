<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        pnlContent = New Panel()
        pnlSidebar = New Panel()
        lblTitle = New Label()
        btnReports = New Button()
        btnStock = New Button()
        btnLogout = New Button()
        btnSuppliers = New Button()
        lblWelcome = New Label()
        btnCategories = New Button()
        btnProducts = New Button()
        pnlSidebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(220, 0)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(664, 561)
        pnlContent.TabIndex = 9
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        pnlSidebar.Controls.Add(lblTitle)
        pnlSidebar.Controls.Add(btnReports)
        pnlSidebar.Controls.Add(btnStock)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnSuppliers)
        pnlSidebar.Controls.Add(lblWelcome)
        pnlSidebar.Controls.Add(btnCategories)
        pnlSidebar.Controls.Add(btnProducts)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 561)
        pnlSidebar.TabIndex = 8
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(12, 24)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(201, 17)
        lblTitle.TabIndex = 8
        lblTitle.Text = "Inventory Management System"
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(22, 332)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(177, 23)
        btnReports.TabIndex = 14
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' btnStock
        ' 
        btnStock.Location = New Point(22, 293)
        btnStock.Name = "btnStock"
        btnStock.Size = New Size(177, 23)
        btnStock.TabIndex = 13
        btnStock.Text = "Stock In / Out"
        btnStock.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(68, 526)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 15
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnSuppliers
        ' 
        btnSuppliers.Location = New Point(22, 254)
        btnSuppliers.Name = "btnSuppliers"
        btnSuppliers.Size = New Size(177, 23)
        btnSuppliers.TabIndex = 12
        btnSuppliers.Text = "Manage Suppliers"
        btnSuppliers.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(12, 47)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(99, 15)
        lblWelcome.TabIndex = 9
        lblWelcome.Text = "Welcome, Admin"
        ' 
        ' btnCategories
        ' 
        btnCategories.Location = New Point(22, 215)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(177, 23)
        btnCategories.TabIndex = 11
        btnCategories.Text = "Manage Categories"
        btnCategories.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.Location = New Point(22, 176)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(177, 23)
        btnProducts.TabIndex = 10
        btnProducts.Text = "Manage Products"
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 561)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Name = "DashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management System - Dashboard"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnReports As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnProducts As Button
End Class
