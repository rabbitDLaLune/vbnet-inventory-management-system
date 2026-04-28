Imports Microsoft.Data.SqlClient

Public Class ProductRepository

    Public Function GetAll(searchText As String) As DataTable
        Dim table As New DataTable()

        Dim sql As String = "
            SELECT 
                p.ProductId,
                p.ProductName,
                p.CategoryId,
                p.SupplierId,
                c.CategoryName,
                s.SupplierName,
                p.CostPrice,
                p.SellingPrice,
                p.Quantity,
                p.ReorderLevel,
                p.CreatedAt
            FROM Products p
            INNER JOIN Categories c ON p.CategoryId = c.CategoryId
            LEFT JOIN Suppliers s ON p.SupplierId = s.SupplierId
            WHERE 
                p.ProductName LIKE @Search
                OR c.CategoryName LIKE @Search
                OR s.SupplierName LIKE @Search
            ORDER BY p.ProductId DESC
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Search", "%" & searchText & "%")

                conn.Open()

                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using

        Return table
    End Function

    Public Sub AddProduct(product As Product)
        Dim sql As String = "
        INSERT INTO Products 
        (ProductName, CategoryId, SupplierId, CostPrice, SellingPrice, Quantity, ReorderLevel)
        VALUES
        (@ProductName, @CategoryId, @SupplierId, @CostPrice, @SellingPrice, @Quantity, @ReorderLevel)
    "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName)
                cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId)

                If product.SupplierId.HasValue AndAlso product.SupplierId.Value > 0 Then
                    cmd.Parameters.AddWithValue("@SupplierId", product.SupplierId.Value)
                Else
                    cmd.Parameters.AddWithValue("@SupplierId", DBNull.Value)
                End If

                cmd.Parameters.AddWithValue("@CostPrice", product.CostPrice)
                cmd.Parameters.AddWithValue("@SellingPrice", product.SellingPrice)
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity)
                cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub UpdateProduct(product As Product)
        Dim sql As String = "
        UPDATE Products
        SET 
            ProductName = @ProductName,
            CategoryId = @CategoryId,
            SupplierId = @SupplierId,
            CostPrice = @CostPrice,
            SellingPrice = @SellingPrice,
            Quantity = @Quantity,
            ReorderLevel = @ReorderLevel,
            UpdatedAt = GETDATE()
        WHERE ProductId = @ProductId
    "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ProductId", product.ProductId)
                cmd.Parameters.AddWithValue("@ProductName", product.ProductName)
                cmd.Parameters.AddWithValue("@CategoryId", product.CategoryId)

                If product.SupplierId.HasValue AndAlso product.SupplierId.Value > 0 Then
                    cmd.Parameters.AddWithValue("@SupplierId", product.SupplierId.Value)
                Else
                    cmd.Parameters.AddWithValue("@SupplierId", DBNull.Value)
                End If

                cmd.Parameters.AddWithValue("@CostPrice", product.CostPrice)
                cmd.Parameters.AddWithValue("@SellingPrice", product.SellingPrice)
                cmd.Parameters.AddWithValue("@Quantity", product.Quantity)
                cmd.Parameters.AddWithValue("@ReorderLevel", product.ReorderLevel)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function GetProductList() As DataTable
        Dim table As New DataTable()

        Dim sql As String = "
        SELECT ProductId, ProductName
        FROM Products
        ORDER BY ProductName
    "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                conn.Open()

                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(table)
                End Using
            End Using
        End Using

        Return table
    End Function
    Public Sub DeleteProduct(productId As Integer)
        Dim sql As String = "
        DELETE FROM Products
        WHERE ProductId = @ProductId
    "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ProductId", productId)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub



End Class