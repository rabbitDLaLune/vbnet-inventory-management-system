Public Class ReportForm

    Private ReadOnly reportService As New ReportService()

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReports()
    End Sub

    Private Sub LoadReports()
        Try
            lblTotalProducts.Text = "Total Products: " & reportService.GetTotalProducts().ToString()
            lblTotalCategories.Text = "Total Categories: " & reportService.GetTotalCategories().ToString()
            lblTotalSuppliers.Text = "Total Suppliers: " & reportService.GetTotalSuppliers().ToString()
            lblLowStockProducts.Text = "Low Stock Products: " & reportService.GetLowStockCount().ToString()
            lblTotalTransactions.Text = "Total Stock Transactions: " & reportService.GetTotalTransactions().ToString()

            dgvLowStock.DataSource = reportService.GetLowStockProducts()
            dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Failed to load reports: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadReports()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Close
    End Sub

End Class