<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim CustomizableEdges27 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges28 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges29 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges30 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-1, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(491, 225)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(107, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 27)
        Label1.TabIndex = 2
        Label1.Text = "PayRoll Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(417, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 23)
        Label2.TabIndex = 0
        Label2.Text = "Logout"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(44, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 23)
        Label3.TabIndex = 3
        Label3.Text = "Home"
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.Transparent
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges27
        Guna2PictureBox1.Image = My.Resources.Resources.logout
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(396, 36)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges28
        Guna2PictureBox1.Size = New Size(22, 24)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.BackColor = Color.Transparent
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges29
        Guna2PictureBox2.Image = My.Resources.Resources.home
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(16, 33)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges30
        Guna2PictureBox2.Size = New Size(22, 24)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox2.TabIndex = 4
        Guna2PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.employee
        PictureBox1.Location = New Point(45, 56)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(91, 92)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = My.Resources.Resources.attendance
        PictureBox2.Location = New Point(191, 56)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(91, 92)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Image = My.Resources.Resources.pay
        PictureBox3.Location = New Point(347, 56)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(91, 92)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.MidnightBlue
        Button1.Location = New Point(46, 169)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 29)
        Button1.TabIndex = 9
        Button1.Text = "Employee"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.MidnightBlue
        Button2.Location = New Point(184, 169)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 29)
        Button2.TabIndex = 10
        Button2.Text = "Attendance"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.MidnightBlue
        Button3.Location = New Point(348, 169)
        Button3.Name = "Button3"
        Button3.Size = New Size(90, 29)
        Button3.TabIndex = 11
        Button3.Text = "Salary"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(488, 317)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MainForm"
        Text = "MainForm"
        Panel1.ResumeLayout(False)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
