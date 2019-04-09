<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PtClose = New System.Windows.Forms.PictureBox()
        Me.PtMinimize = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PbLogin = New System.Windows.Forms.PictureBox()
        Me.PbRegister = New System.Windows.Forms.PictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.PictureBoxError = New System.Windows.Forms.PictureBox()
        Me.lblErrorUP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Indi.My.Resources.Resources.TopBannerWhiteLine
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(720, 20)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PtClose
        '
        Me.PtClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PtClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PtClose.Image = Global.Indi.My.Resources.Resources._2020
        Me.PtClose.Location = New System.Drawing.Point(695, 0)
        Me.PtClose.Name = "PtClose"
        Me.PtClose.Size = New System.Drawing.Size(20, 20)
        Me.PtClose.TabIndex = 2
        Me.PtClose.TabStop = False
        '
        'PtMinimize
        '
        Me.PtMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PtMinimize.Image = Global.Indi.My.Resources.Resources._2020MininizeInvert
        Me.PtMinimize.Location = New System.Drawing.Point(670, 0)
        Me.PtMinimize.Name = "PtMinimize"
        Me.PtMinimize.Size = New System.Drawing.Size(20, 20)
        Me.PtMinimize.TabIndex = 3
        Me.PtMinimize.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(272, 118)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(164, 65)
        Me.lblHeader.TabIndex = 4
        Me.lblHeader.Text = "Sign in"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(242, 212)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(257, 28)
        Me.txtUsername.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.Indi.My.Resources.Resources.BoxU
        Me.PictureBox4.Location = New System.Drawing.Point(208, 207)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(300, 40)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.Indi.My.Resources.Resources.BoxP
        Me.PictureBox5.Location = New System.Drawing.Point(208, 246)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(300, 40)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(242, 250)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(257, 28)
        Me.txtPassword.TabIndex = 2
        '
        'PbLogin
        '
        Me.PbLogin.BackColor = System.Drawing.Color.Transparent
        Me.PbLogin.Image = Global.Indi.My.Resources.Resources._300PxBox
        Me.PbLogin.Location = New System.Drawing.Point(208, 312)
        Me.PbLogin.Name = "PbLogin"
        Me.PbLogin.Size = New System.Drawing.Size(300, 50)
        Me.PbLogin.TabIndex = 8
        Me.PbLogin.TabStop = False
        '
        'PbRegister
        '
        Me.PbRegister.BackColor = System.Drawing.Color.Transparent
        Me.PbRegister.Image = Global.Indi.My.Resources.Resources._300PxBox
        Me.PbRegister.Location = New System.Drawing.Point(208, 368)
        Me.PbRegister.Name = "PbRegister"
        Me.PbRegister.Size = New System.Drawing.Size(300, 50)
        Me.PbRegister.TabIndex = 8
        Me.PbRegister.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(323, 319)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(64, 30)
        Me.lblLogin.TabIndex = 3
        Me.lblLogin.Text = "Login"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.BackColor = System.Drawing.Color.Transparent
        Me.lblRegister.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.White
        Me.lblRegister.Location = New System.Drawing.Point(314, 374)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(86, 30)
        Me.lblRegister.TabIndex = 4
        Me.lblRegister.Text = "Register"
        '
        'PictureBoxError
        '
        Me.PictureBoxError.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxError.Image = Global.Indi.My.Resources.Resources.icon__1_
        Me.PictureBoxError.Location = New System.Drawing.Point(152, 502)
        Me.PictureBoxError.Name = "PictureBoxError"
        Me.PictureBoxError.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxError.TabIndex = 10
        Me.PictureBoxError.TabStop = False
        '
        'lblErrorUP
        '
        Me.lblErrorUP.AutoSize = True
        Me.lblErrorUP.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorUP.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorUP.ForeColor = System.Drawing.Color.Red
        Me.lblErrorUP.Location = New System.Drawing.Point(190, 501)
        Me.lblErrorUP.Name = "lblErrorUP"
        Me.lblErrorUP.Size = New System.Drawing.Size(382, 30)
        Me.lblErrorUP.TabIndex = 11
        Me.lblErrorUP.Text = "Your Username or Password is incorrect!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(324, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Indi Spice"
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.Red
        Me.btnHelp.Location = New System.Drawing.Point(208, 424)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(300, 50)
        Me.btnHelp.TabIndex = 15
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Indi.My.Resources.Resources.BPattern
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 540)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblErrorUP)
        Me.Controls.Add(Me.PictureBoxError)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.PbRegister)
        Me.Controls.Add(Me.PbLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.PtMinimize)
        Me.Controls.Add(Me.PtClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRegister, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PtClose As PictureBox
    Friend WithEvents PtMinimize As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PbLogin As PictureBox
    Friend WithEvents PbRegister As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents PictureBoxError As PictureBox
    Friend WithEvents lblErrorUP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHelp As Button
End Class
