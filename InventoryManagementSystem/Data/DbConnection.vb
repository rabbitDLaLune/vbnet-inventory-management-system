Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class DbConnection

    Private Shared ReadOnly dbPath As String =
        Path.Combine(Application.StartupPath, "InventoryDB.mdf")

    Private Shared ReadOnly connectionString As String =
        $"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;TrustServerCertificate=True"

    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class