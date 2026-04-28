Public Class LoginForm

    Private ReadOnly authService As New AuthService()

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterLoginCard()
    End Sub

    Private Sub LoginForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterLoginCard()
    End Sub

    Private Sub CenterLoginCard()
        pnlLoginCard.Left = (Me.ClientSize.Width - pnlLoginCard.Width) \ 2
        pnlLoginCard.Top = (Me.ClientSize.Height - pnlLoginCard.Height) \ 2
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim username As String = txtUsername.Text
            Dim password As String = txtPassword.Text

            Dim isValid As Boolean = authService.Login(username, password)

            If isValid Then
                MessageBox.Show("Login successful.")

                Dim dashboard As New DashboardForm()
                AddHandler dashboard.FormClosed, Sub()
                                                     Me.Show()
                                                 End Sub

                dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class