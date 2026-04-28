Public Class ProductService

    Private ReadOnly productRepository As New ProductRepository()

    Public Function GetProducts(searchText As String) As DataTable
        Return productRepository.GetAll(searchText.Trim())
    End Function

    Public Sub AddProduct(product As Product)
        If String.IsNullOrWhiteSpace(product.ProductName) Then
            Throw New Exception("Product name is required.")
        End If

        If product.CategoryId <= 0 Then
            Throw New Exception("Please select a category.")
        End If

        If product.CostPrice < 0 Then
            Throw New Exception("Cost price cannot be negative.")
        End If

        If product.SellingPrice < 0 Then
            Throw New Exception("Selling price cannot be negative.")
        End If

        If product.Quantity < 0 Then
            Throw New Exception("Quantity cannot be negative.")
        End If

        If product.ReorderLevel < 0 Then
            Throw New Exception("Reorder level cannot be negative.")
        End If

        productRepository.AddProduct(product)
    End Sub
    Public Sub UpdateProduct(product As Product)
        If product.ProductId <= 0 Then
            Throw New Exception("Please select a product to update.")
        End If

        If String.IsNullOrWhiteSpace(product.ProductName) Then
            Throw New Exception("Product name is required.")
        End If

        If product.CategoryId <= 0 Then
            Throw New Exception("Please select a category.")
        End If

        If product.CostPrice < 0 Then
            Throw New Exception("Cost price cannot be negative.")
        End If

        If product.SellingPrice < 0 Then
            Throw New Exception("Selling price cannot be negative.")
        End If

        If product.Quantity < 0 Then
            Throw New Exception("Quantity cannot be negative.")
        End If

        If product.ReorderLevel < 0 Then
            Throw New Exception("Reorder level cannot be negative.")
        End If

        productRepository.UpdateProduct(product)
    End Sub
    Public Function GetProductList() As DataTable
        Return productRepository.GetProductList()
    End Function
    Public Sub DeleteProduct(productId As Integer)
        If productId <= 0 Then
            Throw New Exception("Please select a product to delete.")
        End If

        productRepository.DeleteProduct(productId)
    End Sub

End Class