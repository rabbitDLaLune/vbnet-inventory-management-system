<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        pnlLoginCard = New Panel()
        chkShowPassword = New CheckBox()
        btnExit = New Button()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        lblTitle = New Label()
        pnlLoginCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.BackColor = Color.White
        pnlLoginCard.Controls.Add(chkShowPassword)
        pnlLoginCard.Controls.Add(btnExit)
        pnlLoginCard.Controls.Add(btnLogin)
        pnlLoginCard.Controls.Add(txtPassword)
        pnlLoginCard.Controls.Add(txtUsername)
        pnlLoginCard.Controls.Add(lblPassword)
        pnlLoginCard.Controls.Add(lblUsername)
        pnlLoginCard.Controls.Add(lblTitle)
        pnlLoginCard.Location = New Point(353, 37)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(400, 420)
        pnlLoginCard.TabIndex = 8
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(40, 255)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(108, 19)
        chkShowPassword.TabIndex = 15
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(229), CByte(231), CByte(235))
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.FromArgb(CByte(17), CByte(24), CByte(39))
        btnExit.Location = New Point(40, 345)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(320, 35)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(40, 300)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(320, 38)
        btnLogin.TabIndex = 13
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(40, 215)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(320, 27)
        txtPassword.TabIndex = 12
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(40, 145)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(320, 27)
        txtUsername.TabIndex = 11
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(40, 190)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(64, 17)
        lblPassword.TabIndex = 10
        lblPassword.Text = "Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(40, 120)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(67, 17)
        lblUsername.TabIndex = 9
        lblUsername.Text = "Username"
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 70)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(360, 37)
        lblTitle.TabIndex = 8
        lblTitle.Text = "Inventory Management System"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        ClientSize = New Size(884, 511)
        Controls.Add(pnlLoginCard)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management System - Login"
        pnlLoginCard.ResumeLayout(False)
        pnlLoginCard.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblTitle As Label

End Class
