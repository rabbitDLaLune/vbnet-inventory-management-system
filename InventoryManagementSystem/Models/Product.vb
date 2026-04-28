Public Class Product

    Public Property ProductId As Integer
    Public Property ProductName As String
    Public Property CategoryId As Integer
    Public Property SupplierId As Integer?
    Public Property CostPrice As Decimal
    Public Property SellingPrice As Decimal
    Public Property Quantity As Integer
    Public Property ReorderLevel As Integer
    Public Property CreatedAt As DateTime
    Public Property UpdatedAt As DateTime?

End Class