Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class ReportRepository

    Public Function GetTotalProducts() As Integer
        Return ExecuteCount("SELECT COUNT(*) FROM Products")
    End Function

    Public Function GetTotalCategories() As Integer
        Return ExecuteCount("SELECT COUNT(*) FROM Categories")
    End Function

    Public Function GetTotalSuppliers() As Integer
        Return ExecuteCount("SELECT COUNT(*) FROM Suppliers")
    End Function

    Public Function GetTotalTransactions() As Integer
        Return ExecuteCount("SELECT COUNT(*) FROM StockTransactions")
    End Function

    Public Function GetLowStockCount() As Integer
        Return ExecuteCount("SELECT COUNT(*) FROM Products WHERE Quantity <= ReorderLevel")
    End Function

    Public Function GetLowStockProducts() As DataTable
        Dim table As New DataTable()

        Dim sql As String = "
            SELECT 
                ProductName,
                Quantity,
                ReorderLevel,
                SellingPrice
            FROM Products
            WHERE Quantity <= ReorderLevel
            ORDER BY Quantity ASC
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

    Private Function ExecuteCount(sql As String) As Integer
        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                conn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

End Class