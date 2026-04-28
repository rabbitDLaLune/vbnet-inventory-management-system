Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class StockRepository

    Public Function GetAllTransactions() As DataTable
        Dim table As New DataTable()

        Dim sql As String = "
            SELECT 
                st.TransactionId,
                p.ProductName,
                st.TransactionType,
                st.Quantity,
                st.Notes,
                st.CreatedAt
            FROM StockTransactions st
            INNER JOIN Products p ON st.ProductId = p.ProductId
            ORDER BY st.TransactionId DESC
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

    Public Sub AddTransaction(transaction As StockTransaction)
        Dim quantityChange As Integer = transaction.Quantity

        If transaction.TransactionType = "OUT" Then
            quantityChange = -transaction.Quantity
        End If

        Dim sqlInsert As String = "
            INSERT INTO StockTransactions (ProductId, TransactionType, Quantity, Notes)
            VALUES (@ProductId, @TransactionType, @Quantity, @Notes)
        "

        Dim sqlUpdateProduct As String = "
            UPDATE Products
            SET Quantity = Quantity + @QuantityChange,
                UpdatedAt = GETDATE()
            WHERE ProductId = @ProductId
        "

        Using conn = DbConnection.GetConnection()
            conn.Open()

            Using dbTransaction = conn.BeginTransaction()
                Try
                    Using cmdInsert As New SqlCommand(sqlInsert, conn, dbTransaction)
                        cmdInsert.Parameters.AddWithValue("@ProductId", transaction.ProductId)
                        cmdInsert.Parameters.AddWithValue("@TransactionType", transaction.TransactionType)
                        cmdInsert.Parameters.AddWithValue("@Quantity", transaction.Quantity)
                        cmdInsert.Parameters.AddWithValue("@Notes", If(String.IsNullOrWhiteSpace(transaction.Notes), DBNull.Value, transaction.Notes))
                        cmdInsert.ExecuteNonQuery()
                    End Using

                    Using cmdUpdate As New SqlCommand(sqlUpdateProduct, conn, dbTransaction)
                        cmdUpdate.Parameters.AddWithValue("@ProductId", transaction.ProductId)
                        cmdUpdate.Parameters.AddWithValue("@QuantityChange", quantityChange)
                        cmdUpdate.ExecuteNonQuery()
                    End Using

                    dbTransaction.Commit()

                Catch
                    dbTransaction.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub
    Public Function GetCurrentQuantity(productId As Integer) As Integer
        Dim sql As String = "
        SELECT Quantity
        FROM Products
        WHERE ProductId = @ProductId
    "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ProductId", productId)

                conn.Open()

                Dim result = cmd.ExecuteScalar()

                If result Is Nothing OrElse IsDBNull(result) Then
                    Return 0
                End If

                Return Convert.ToInt32(result)
            End Using
        End Using
    End Function

End Class