Public Class StockService

    Private ReadOnly stockRepository As New StockRepository()

    Public Function GetTransactions() As DataTable
        Return stockRepository.GetAllTransactions()
    End Function

    Public Sub AddTransaction(transaction As StockTransaction)
        If transaction.ProductId <= 0 Then
            Throw New Exception("Please select a product.")
        End If

        If transaction.TransactionType <> "IN" AndAlso transaction.TransactionType <> "OUT" Then
            Throw New Exception("Please select transaction type.")
        End If

        If transaction.Quantity <= 0 Then
            Throw New Exception("Quantity must be greater than 0.")
        End If

        If transaction.TransactionType = "OUT" Then
            Dim currentQuantity As Integer = stockRepository.GetCurrentQuantity(transaction.ProductId)

            If transaction.Quantity > currentQuantity Then
                Throw New Exception("Stock out quantity cannot be greater than current stock. Current stock: " & currentQuantity.ToString())
            End If
        End If

        stockRepository.AddTransaction(transaction)
    End Sub

End Class