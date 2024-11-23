<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        emailLabel = New Label()
        enterPasswordLabel = New Label()
        confirmPassword = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Location = New Point(101, 81)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(46, 20)
        emailLabel.TabIndex = 0
        emailLabel.Text = "Email"
        ' 
        ' enterPasswordLabel
        ' 
        enterPasswordLabel.AutoSize = True
        enterPasswordLabel.Location = New Point(101, 376)
        enterPasswordLabel.Name = "enterPasswordLabel"
        enterPasswordLabel.Size = New Size(108, 20)
        enterPasswordLabel.TabIndex = 1
        enterPasswordLabel.Text = "Enter Password"
        ' 
        ' confirmPassword
        ' 
        confirmPassword.AutoSize = True
        confirmPassword.Location = New Point(101, 233)
        confirmPassword.Name = "confirmPassword"
        confirmPassword.Size = New Size(127, 20)
        confirmPassword.TabIndex = 2
        confirmPassword.Text = "Confirm Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(101, 104)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(240, 38)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(101, 256)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(240, 38)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(193, 85)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(0, 27)
        TextBox3.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(101, 399)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(240, 38)
        TextBox4.TabIndex = 6
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(101, 182)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(240, 38)
        TextBox5.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(101, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 7
        Label1.Text = "Email"
        ' 
        ' ForgotPasswordForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        ClientSize = New Size(436, 456)
        Controls.Add(TextBox5)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(confirmPassword)
        Controls.Add(enterPasswordLabel)
        Controls.Add(emailLabel)
        Name = "ForgotPasswordForm"
        Text = "ForgotPasswordForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents emailLabel As Label
    Friend WithEvents enterPasswordLabel As Label
    Friend WithEvents confirmPassword As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
End Class
