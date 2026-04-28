Imports Microsoft.Data.SqlClient

Public Class UserRepository

    Public Function Login(username As String, password As String) As Boolean
        Dim passwordHash As String = PasswordHelper.HashPassword(password)

        Dim sql As String = "
            SELECT COUNT(*) 
            FROM Users 
            WHERE Username = @Username 
            AND PasswordHash = @PasswordHash 
            AND IsActive = 1
        "

        Using conn = DbConnection.GetConnection()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash)

                conn.Open()

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Return count > 0
            End Using
        End Using
    End Function

End Class