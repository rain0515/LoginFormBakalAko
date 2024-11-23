<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        userIDTextBox = New Label()
        usernameLabel = New Label()
        passwordLabel = New Label()
        usernameTextBox = New TextBox()
        loginButton = New Button()
        forgotPasswordLabel = New LinkLabel()
        passwordTextBox = New TextBox()
        registerButton = New Button()
        MaskedTextBox1 = New MaskedTextBox()
        SuspendLayout()
        ' 
        ' userIDTextBox
        ' 
        userIDTextBox.AutoSize = True
        userIDTextBox.Font = New Font("Sitka Banner", 12F)
        userIDTextBox.ForeColor = SystemColors.ButtonFace
        userIDTextBox.Location = New Point(95, 59)
        userIDTextBox.Name = "userIDTextBox"
        userIDTextBox.Size = New Size(70, 29)
        userIDTextBox.TabIndex = 0
        userIDTextBox.Text = "User ID"
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Font = New Font("Sitka Banner", 12F)
        usernameLabel.ForeColor = SystemColors.ButtonFace
        usernameLabel.Location = New Point(95, 132)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(89, 29)
        usernameLabel.TabIndex = 1
        usernameLabel.Text = "Username"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Font = New Font("Sitka Banner", 12F)
        passwordLabel.ForeColor = SystemColors.ButtonFace
        passwordLabel.Location = New Point(95, 205)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(86, 29)
        passwordLabel.TabIndex = 2
        passwordLabel.Text = "Password"
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Font = New Font("Segoe UI", 13.8F)
        usernameTextBox.Location = New Point(95, 163)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(240, 38)
        usernameTextBox.TabIndex = 4
        ' 
        ' loginButton
        ' 
        loginButton.Location = New Point(127, 322)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(154, 40)
        loginButton.TabIndex = 6
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' forgotPasswordLabel
        ' 
        forgotPasswordLabel.AutoSize = True
        forgotPasswordLabel.Font = New Font("Sitka Banner", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        forgotPasswordLabel.ForeColor = SystemColors.ButtonFace
        forgotPasswordLabel.LinkColor = SystemColors.ButtonFace
        forgotPasswordLabel.Location = New Point(218, 277)
        forgotPasswordLabel.Name = "forgotPasswordLabel"
        forgotPasswordLabel.Size = New Size(117, 24)
        forgotPasswordLabel.TabIndex = 7
        forgotPasswordLabel.TabStop = True
        forgotPasswordLabel.Text = "Forgot Password"
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Font = New Font("Segoe UI", 13.8F)
        passwordTextBox.Location = New Point(95, 236)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.Size = New Size(240, 38)
        passwordTextBox.TabIndex = 8
        passwordTextBox.UseSystemPasswordChar = True
        ' 
        ' registerButton
        ' 
        registerButton.Location = New Point(127, 368)
        registerButton.Name = "registerButton"
        registerButton.Size = New Size(154, 40)
        registerButton.TabIndex = 9
        registerButton.Text = "Register"
        registerButton.UseVisualStyleBackColor = True
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(95, 91)
        MaskedTextBox1.Mask = "00-00000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.PromptChar = "0"c
        MaskedTextBox1.Size = New Size(240, 38)
        MaskedTextBox1.TabIndex = 10
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        ClientSize = New Size(436, 456)
        Controls.Add(MaskedTextBox1)
        Controls.Add(registerButton)
        Controls.Add(passwordTextBox)
        Controls.Add(forgotPasswordLabel)
        Controls.Add(loginButton)
        Controls.Add(usernameTextBox)
        Controls.Add(passwordLabel)
        Controls.Add(usernameLabel)
        Controls.Add(userIDTextBox)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "LoginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userIDTextBox As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents forgotPasswordLabel As LinkLabel
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents registerButton As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox

End Class
