<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtUname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPassword = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.POS.My.Resources.Resources.Brown_and_White_Modern_Cafe_Logo
        Me.GunaPictureBox1.Location = New System.Drawing.Point(23, 64)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(301, 251)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 4
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(549, 0)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Transparent
        Me.GunaButton1.Size = New System.Drawing.Size(32, 36)
        Me.GunaButton1.TabIndex = 7
        Me.GunaButton1.Text = "X"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.White
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(71, 36)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(60, 20)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "LOG IN"
        '
        'txtUname
        '
        Me.txtUname.BackColor = System.Drawing.Color.White
        Me.txtUname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtUname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUname.LineColor = System.Drawing.Color.Gainsboro
        Me.txtUname.Location = New System.Drawing.Point(32, 67)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUname.SelectedText = ""
        Me.txtUname.Size = New System.Drawing.Size(137, 26)
        Me.txtUname.TabIndex = 6
        Me.txtUname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPassword.Location = New System.Drawing.Point(32, 127)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(137, 26)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.White
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(73, 96)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(60, 15)
        Me.GunaLabel2.TabIndex = 8
        Me.GunaLabel2.Text = "Username"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.White
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(73, 156)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(57, 15)
        Me.GunaLabel3.TabIndex = 9
        Me.GunaLabel3.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.Transparent
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.Location = New System.Drawing.Point(44, 193)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.White
        Me.btnLogin.Radius = 14
        Me.btnLogin.Size = New System.Drawing.Size(111, 29)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.btnLogin)
        Me.GunaShadowPanel1.Controls.Add(Me.txtUname)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaShadowPanel1.Controls.Add(Me.txtPassword)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(342, 55)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.Radius = 8
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(197, 260)
        Me.GunaShadowPanel1.TabIndex = 8
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(582, 363)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtUname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
End Class
