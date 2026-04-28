Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class SupplierRepository

    Public Function GetAll() As List(Of Supplier)
        Dim suppliers As New List(Of Supplier)()

        Dim sql As String = "
            SELECT SupplierId, SupplierName, Phone, Email, Address
            FROM Suppliers
            ORDER BY SupplierName
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                conn.Open()

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        suppliers.Add(New Supplier With {
                            .SupplierId = Convert.ToInt32(reader("SupplierId")),
                            .SupplierName = reader("SupplierName").ToString(),
                            .Phone = If(IsDBNull(reader("Phone")), "", reader("Phone").ToString()),
                            .Email = If(IsDBNull(reader("Email")), "", reader("Email").ToString()),
                            .Address = If(IsDBNull(reader("Address")), "", reader("Address").ToString())
                        })
                    End While
                End Using
            End Using
        End Using

        Return suppliers
    End Function

    Public Function GetAllTable(searchText As String) As DataTable
        Dim table As New DataTable()

        Dim sql As String = "
            SELECT 
                SupplierId,
                SupplierName,
                Phone,
                Email,
                Address,
                CreatedAt
            FROM Suppliers
            WHERE SupplierName LIKE @Search
               OR Phone LIKE @Search
               OR Email LIKE @Search
               OR Address LIKE @Search
            ORDER BY SupplierId DESC
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

    Public Sub AddSupplier(supplier As Supplier)
        Dim sql As String = "
            INSERT INTO Suppliers (SupplierName, Phone, Email, Address)
            VALUES (@SupplierName, @Phone, @Email, @Address)
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName)
                cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrWhiteSpace(supplier.Phone), DBNull.Value, supplier.Phone))
                cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(supplier.Email), DBNull.Value, supplier.Email))
                cmd.Parameters.AddWithValue("@Address", If(String.IsNullOrWhiteSpace(supplier.Address), DBNull.Value, supplier.Address))

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub UpdateSupplier(supplier As Supplier)
        Dim sql As String = "
            UPDATE Suppliers
            SET SupplierName = @SupplierName,
                Phone = @Phone,
                Email = @Email,
                Address = @Address
            WHERE SupplierId = @SupplierId
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@SupplierId", supplier.SupplierId)
                cmd.Parameters.AddWithValue("@SupplierName", supplier.SupplierName)
                cmd.Parameters.AddWithValue("@Phone", If(String.IsNullOrWhiteSpace(supplier.Phone), DBNull.Value, supplier.Phone))
                cmd.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(supplier.Email), DBNull.Value, supplier.Email))
                cmd.Parameters.AddWithValue("@Address", If(String.IsNullOrWhiteSpace(supplier.Address), DBNull.Value, supplier.Address))

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub DeleteSupplier(supplierId As Integer)
        Dim sql As String = "
            DELETE FROM Suppliers
            WHERE SupplierId = @SupplierId
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@SupplierId", supplierId)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class