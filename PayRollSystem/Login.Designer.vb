<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtUserName = New TextBox()
        txtPassword = New TextBox()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(87, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 27)
        Label1.TabIndex = 1
        Label1.Text = "PayRoll Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(87, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 2
        Label2.Text = "Username :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(87, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 3
        Label3.Text = "Password :"
        ' 
        ' txtUserName
        ' 
        txtUserName.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtUserName.Location = New Point(198, 91)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(192, 27)
        txtUserName.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(198, 138)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(192, 27)
        txtPassword.TabIndex = 5
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges5
        Guna2PictureBox1.Image = My.Resources.Resources.username
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(45, 84)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2PictureBox1.Size = New Size(36, 41)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 6
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges7
        Guna2PictureBox2.Image = My.Resources.Resources.password
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(45, 129)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2PictureBox2.Size = New Size(36, 41)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox2.TabIndex = 7
        Guna2PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MidnightBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(102, 191)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 29)
        Button1.TabIndex = 8
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MidnightBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(274, 191)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 29)
        Button2.TabIndex = 9
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(467, 251)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(txtPassword)
        Controls.Add(txtUserName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
