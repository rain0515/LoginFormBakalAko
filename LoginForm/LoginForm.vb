Public Class LoginForm
    Private forgotPasswordForm As New ForgotPasswordForm
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim userID As String = userIDTextBox.Text
        Dim username As String = usernameTextBox.Text
        Dim password As String = passwordTextBox.Text
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub forgotPasswordLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgotPasswordLabel.LinkClicked
        forgotPasswordForm.Visible = True
        Me.Visible = False
    End Sub
End Class
