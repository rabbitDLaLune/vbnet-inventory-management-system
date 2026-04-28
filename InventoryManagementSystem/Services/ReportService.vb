Public Class ReportService

    Private ReadOnly reportRepository As New ReportRepository()

    Public Function GetTotalProducts() As Integer
        Return reportRepository.GetTotalProducts()
    End Function

    Public Function GetTotalCategories() As Integer
        Return reportRepository.GetTotalCategories()
    End Function

    Public Function GetTotalSuppliers() As Integer
        Return reportRepository.GetTotalSuppliers()
    End Function

    Public Function GetTotalTransactions() As Integer
        Return reportRepository.GetTotalTransactions()
    End Function

    Public Function GetLowStockCount() As Integer
        Return reportRepository.GetLowStockCount()
    End Function

    Public Function GetLowStockProducts() As DataTable
        Return reportRepository.GetLowStockProducts()
    End Function

End Class