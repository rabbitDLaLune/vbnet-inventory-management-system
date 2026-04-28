Public Class AuthService

    Private ReadOnly userRepository As New UserRepository()

    Public Function Login(username As String, password As String) As Boolean
        If String.IsNullOrWhiteSpace(username) Then
            Throw New Exception("Username is required.")
        End If

        If String.IsNullOrWhiteSpace(password) Then
            Throw New Exception("Password is required.")
        End If

        Return userRepository.Login(username.Trim(), password)
    End Function

End Class