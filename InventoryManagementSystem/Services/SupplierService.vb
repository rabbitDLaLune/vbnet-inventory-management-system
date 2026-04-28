Public Class SupplierService

    Private ReadOnly supplierRepository As New SupplierRepository()

    Public Function GetAllSuppliers() As List(Of Supplier)
        Return supplierRepository.GetAll()
    End Function

    Public Function GetSuppliers(searchText As String) As DataTable
        Return supplierRepository.GetAllTable(searchText.Trim())
    End Function

    Public Sub AddSupplier(supplier As Supplier)
        If String.IsNullOrWhiteSpace(supplier.SupplierName) Then
            Throw New Exception("Supplier name is required.")
        End If

        supplierRepository.AddSupplier(supplier)
    End Sub

    Public Sub UpdateSupplier(supplier As Supplier)
        If supplier.SupplierId <= 0 Then
            Throw New Exception("Please select a supplier to update.")
        End If

        If String.IsNullOrWhiteSpace(supplier.SupplierName) Then
            Throw New Exception("Supplier name is required.")
        End If

        supplierRepository.UpdateSupplier(supplier)
    End Sub

    Public Sub DeleteSupplier(supplierId As Integer)
        If supplierId <= 0 Then
            Throw New Exception("Please select a supplier to delete.")
        End If

        supplierRepository.DeleteSupplier(supplierId)
    End Sub

End Class