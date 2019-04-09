Public Class Register

    ' This closes all the forms
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form1.Close()
        Login.Close()
        EPOS.Close()
    End Sub

    ' This event minimizes the current form 
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' This event hides the current form and opens the login form 
    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblSignIn.Click
        Me.Hide()
        Login.Show()
    End Sub

    ' This event calls the create account event
    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblCreateAccount.Click
        Call CreateAccount()
    End Sub

    ' This procedure saves all the text inside the textbox's of the register form and saves them in the settings 
    Private Sub CreateAccount()
        ' This if statement makes sure that the password and repeat password box are the same
        If txtRPassword.Text = txtRPasswordR.Text Then

            My.Settings.Username = txtRUsername.Text
            My.Settings.Password = txtRPassword.Text
            My.Settings.Name = txtName.Text
            My.Settings.Position = txtRPosition.Text
            My.Settings.Email = txtREmail.Text
            My.Settings.Save()

            MsgBox("Your account was created successfully!")
            ' This message is displayed if the passwords are not correct
        Else
            MsgBox("Passwords does not match!")
        End If
    End Sub

    ' The code bellow fills up all the labels with text, and make sure that they have the correct colour
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PbCreateAccount.Select()
        txtName.Text = "Full Name"
        txtName.ForeColor = Color.DimGray
        txtRUsername.Text = "Username"
        txtRUsername.ForeColor = Color.DimGray
        txtRPassword.Text = "Password"
        txtRPassword.ForeColor = Color.DimGray
        txtRPasswordR.Text = "Repeat Password"
        txtRPasswordR.ForeColor = Color.DimGray
        txtRPosition.Text = "Position"
        txtRPosition.ForeColor = Color.DimGray
        txtREmail.Text = "Email"
        txtREmail.ForeColor = Color.DimGray
    End Sub


    ' All the events down bellow changes the colour and deletes the while the enters, when the mouse leaves if the texbox is empty it is filled up back 
    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        If txtName.Text = "Full Name" Then
            txtName.Clear()
            txtName.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        If txtName.Text = "" Then
            txtName.Text = "Full Name"
            txtName.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtRUsername_Enter(sender As Object, e As EventArgs) Handles txtRUsername.Enter
        If txtRUsername.Text = "Username" Then
            txtRUsername.Clear()
            txtRUsername.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtRUsername_Leave(sender As Object, e As EventArgs) Handles txtRUsername.Leave
        If txtRUsername.Text = "" Then
            txtRUsername.Text = "Username"
            txtRUsername.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtRPassword_Enter(sender As Object, e As EventArgs) Handles txtRPassword.Enter
        If txtRPassword.Text = "Password" Then
            txtRPassword.Clear()
            txtRPassword.ForeColor = Color.White
            txtRPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub txtRPassword_Leave(sender As Object, e As EventArgs) Handles txtRPassword.Leave
        If txtRPassword.Text = "" Then
            txtRPassword.Text = "Password"
            txtRPassword.ForeColor = Color.DimGray
            txtRPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub txtRPasswordR_Enter(sender As Object, e As EventArgs) Handles txtRPasswordR.Enter
        If txtRPasswordR.Text = "Repeat Password" Then
            txtRPasswordR.Clear()
            txtRPasswordR.ForeColor = Color.White
            txtRPasswordR.PasswordChar = "•"
        End If
    End Sub

    Private Sub txtRPasswordR_Leave(sender As Object, e As EventArgs) Handles txtRPasswordR.Leave
        If txtRPasswordR.Text = "" Then
            txtRPasswordR.Text = "Repeat Password"
            txtRPasswordR.ForeColor = Color.DimGray
            txtRPasswordR.PasswordChar = ""
        End If
    End Sub

    Private Sub txtRPosition_Enter(sender As Object, e As EventArgs) Handles txtRPosition.Enter
        If txtRPosition.Text = "Position" Then
            txtRPosition.Clear()
            txtRPosition.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtRPosition_Leave(sender As Object, e As EventArgs) Handles txtRPosition.Leave
        If txtRPosition.Text = "" Then
            txtRPosition.Text = "Position"
            txtRPosition.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtREmail_Enter(sender As Object, e As EventArgs) Handles txtREmail.Enter
        If txtREmail.Text = "Email" Then
            txtREmail.Clear()
            txtREmail.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtREmail_Leave(sender As Object, e As EventArgs) Handles txtREmail.Leave
        If txtREmail.Text = "" Then
            txtREmail.Text = "Email"
            txtREmail.ForeColor = Color.DimGray
        End If
    End Sub

    ' This is used for the hover effect on the close and minize button 
    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources._2020_Inverse
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources._2020
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources._2020MininizeInvert
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Image = My.Resources._2020Mininize
    End Sub

    'This code below allows to drag arround the application when its on 
    Dim drag As Boolean
    Dim MoveFormMouse As Point
    Private Sub Register_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            Me.Cursor = Cursors.NoMove2D
            MoveFormMouse = e.Location

        End If
    End Sub

    Private Sub Register_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Location = Me.Location + (e.Location - MoveFormMouse)
        End If
    End Sub

    Private Sub Register_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            drag = False
            Me.Cursor = Cursors.Default
        End If
    End Sub


    'This code bellow allows the hover effect on the buttons 
    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PbCreateAccount.MouseEnter
        PbCreateAccount.Image = My.Resources._300PxBoxWhite
        lblCreateAccount.BackColor = Color.White
        lblCreateAccount.ForeColor = Color.FromArgb(31, 31, 40)
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PbCreateAccount.MouseLeave
        PbCreateAccount.Image = My.Resources._300PxBox
        lblCreateAccount.BackColor = Color.Transparent
        lblCreateAccount.ForeColor = Color.White
    End Sub

    Private Sub lblLogin_MouseEnter(sender As Object, e As EventArgs) Handles lblCreateAccount.MouseEnter
        PbCreateAccount.Image = My.Resources._300PxBoxWhite
        lblCreateAccount.BackColor = Color.White
        lblCreateAccount.ForeColor = Color.FromArgb(31, 31, 40)
    End Sub

    Private Sub lblLogin_MouseLeave(sender As Object, e As EventArgs) Handles lblCreateAccount.MouseLeave
        PbCreateAccount.Image = My.Resources._300PxBoxWhite
        lblCreateAccount.BackColor = Color.Transparent
        lblCreateAccount.ForeColor = Color.White
    End Sub

    Private Sub PbSignIn_MouseEnter(sender As Object, e As EventArgs) Handles PbSignIn.MouseEnter
        PbSignIn.Image = My.Resources._300PxBoxWhite
        lblSignIn.BackColor = Color.White
        lblSignIn.ForeColor = Color.FromArgb(31, 31, 40)
    End Sub

    Private Sub PbSignIn_MouseLeave(sender As Object, e As EventArgs) Handles PbSignIn.MouseLeave
        PbSignIn.Image = My.Resources._300PxBox
        lblSignIn.BackColor = Color.Transparent
        lblSignIn.ForeColor = Color.White
    End Sub

    Private Sub lblSignIn_MouseEnter(sender As Object, e As EventArgs) Handles lblSignIn.MouseEnter
        PbSignIn.Image = My.Resources._300PxBoxWhite
        lblSignIn.BackColor = Color.White
        lblSignIn.ForeColor = Color.FromArgb(31, 31, 40)
    End Sub

    Private Sub lblSignIn_MouseLeave(sender As Object, e As EventArgs) Handles lblSignIn.MouseLeave
        PbSignIn.Image = My.Resources._300PxBox
        lblSignIn.BackColor = Color.Transparent
        lblSignIn.ForeColor = Color.White
    End Sub

    'This calls the create account event
    Private Sub PbCreateAccount_Click(sender As Object, e As EventArgs) Handles PbCreateAccount.Click
        Call CreateAccount()
    End Sub

    'This shows the login form 
    Private Sub PbSignIn_Click(sender As Object, e As EventArgs) Handles PbSignIn.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class