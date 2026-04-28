Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class CategoryRepository

    Public Function GetAll() As List(Of Category)
        Dim categories As New List(Of Category)()

        Dim sql As String = "
            SELECT CategoryId, CategoryName, Description
            FROM Categories
            ORDER BY CategoryName
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                conn.Open()

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        categories.Add(New Category With {
                            .CategoryId = Convert.ToInt32(reader("CategoryId")),
                            .CategoryName = reader("CategoryName").ToString(),
                            .Description = If(IsDBNull(reader("Description")), "", reader("Description").ToString())
                        })
                    End While
                End Using
            End Using
        End Using

        Return categories
    End Function

    Public Function GetAllTable(searchText As String) As DataTable
        Dim table As New DataTable()

        Dim sql As String = "
            SELECT 
                CategoryId,
                CategoryName,
                Description,
                CreatedAt
            FROM Categories
            WHERE CategoryName LIKE @Search
               OR Description LIKE @Search
            ORDER BY CategoryId DESC
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

    Public Sub AddCategory(category As Category)
        Dim sql As String = "
            INSERT INTO Categories (CategoryName, Description)
            VALUES (@CategoryName, @Description)
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName)
                cmd.Parameters.AddWithValue("@Description", If(String.IsNullOrWhiteSpace(category.Description), DBNull.Value, category.Description))

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateCategory(category As Category)
        Dim sql As String = "
            UPDATE Categories
            SET CategoryName = @CategoryName,
                Description = @Description
            WHERE CategoryId = @CategoryId
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CategoryId", category.CategoryId)
                cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName)
                cmd.Parameters.AddWithValue("@Description", If(String.IsNullOrWhiteSpace(category.Description), DBNull.Value, category.Description))

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteCategory(categoryId As Integer)
        Dim sql As String = "
            DELETE FROM Categories
            WHERE CategoryId = @CategoryId
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CategoryId", categoryId)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class