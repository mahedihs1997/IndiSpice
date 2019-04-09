Public Class Login

    ' This event closes all the forms 
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PtClose.Click
        Me.Close()
        Form1.Close()
        EPOS.Close()
        Register.Close()
    End Sub

    ' This event minimizes this form 
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PtMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' This event hides this form and opens the register form
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PbRegister.Click
        Me.Hide()
        Register.Show()
    End Sub

    ' This event hides this form and opens the register form (this is when the white box is clicked)
    Private Sub lblRegister_Click(sender As Object, e As EventArgs) Handles lblRegister.Click
        Me.Hide()
        Register.Show()
    End Sub

    ' This event calls the event CheckUsernamePassword
    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Call CheckUsernamePassword()
    End Sub

    ' This an event that occurs when the form loads
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code enables the timer that is used for the date and time
        Form1.Timer1.Enabled = False

        'This code hides the error messages
        PictureBoxError.Visible = False
        lblErrorUP.Visible = False

        'This code selects the login button
        PbLogin.Select()

        'This code adds text in the Username and Password textbox, and makes them gray color
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.DimGray
        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.DimGray
    End Sub

    ' This event makes sure that the username and password inserted in the texbox are correct
    Private Sub CheckUsernamePassword()
        ' This is an if statement that checks the textbox text with the stored text 
        If txtUsername.Text = My.Settings.Username And txtPassword.Text = My.Settings.Password Then
            Me.Hide()
            EPOS.Show()
            ' If the username or password is wrong then the error messages will become visible
        Else
            PictureBoxError.Visible = True
            lblErrorUP.Visible = True
        End If
    End Sub

    ' This event calls the CheckUsernamePassword event
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PbLogin.Click
        Call CheckUsernamePassword()
    End Sub

    ' This formats the textbox control apropietly when the users enters the textbox
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Clear()
            txtUsername.ForeColor = Color.White
            PictureBoxError.Visible = False
            lblErrorUP.Visible = False
        End If
    End Sub

    ' This formats the texbox control apropietly when te users leaves the textbox
    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.DimGray
        End If
    End Sub

    ' This formats the textbox control apropietly when the users enters the textbox
    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Clear()
            txtPassword.ForeColor = Color.White
            txtPassword.PasswordChar = "•"
            PictureBoxError.Visible = False
            lblErrorUP.Visible = False
        End If
    End Sub

    ' This formats the texbox control apropietly when te users leaves the textbox
    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.DimGray
            txtPassword.PasswordChar = ""
        End If
    End Sub

    ' This event opens the EPOS (main application)
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EPOS.Show()
    End Sub

    ' The 4 events below allows the close and minize button to change colour when hovered over
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PtMinimize.MouseEnter
        PtMinimize.Image = My.Resources._2020Mininize
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PtMinimize.MouseLeave
        PtMinimize.Image = My.Resources._2020MininizeInvert
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PtClose.MouseEnter
        PtClose.Image = My.Resources._2020_Inverse
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PtClose.MouseLeave
        PtClose.Image = My.Resources._2020
    End Sub


    'This code below allows to drag arround the application when its on 
    Dim drag As Boolean
    Dim MoveFormMouse As Point

    ' This code enables drag and move if mouse left click is clicked on the form 
    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            Me.Cursor = Cursors.NoMove2D
            MoveFormMouse = e.Location

        End If
    End Sub

    ' This code allows to move the form 
    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Location = Me.Location + (e.Location - MoveFormMouse)
        End If
    End Sub

    ' This code disables drag when mouse click is stopped clicking 
    Private Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            drag = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    ' All the events below allows the buttons change the colour to white when hovered over
    Private Sub PbLogin_MouseEnter(sender As Object, e As EventArgs) Handles PbLogin.MouseEnter
        PbLogin.Image = My.Resources._300PxBoxWhite
        lblLogin.ForeColor = Color.FromArgb(31, 31, 40)
        lblLogin.BackColor = Color.White
    End Sub

    Private Sub PbLogin_MouseLeave(sender As Object, e As EventArgs) Handles PbLogin.MouseLeave
        PbLogin.Image = My.Resources._300PxBox
        lblLogin.ForeColor = Color.White
        lblLogin.BackColor = Color.Transparent

    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As EventArgs) Handles PbRegister.MouseEnter
        PbRegister.Image = My.Resources._300PxBoxWhite
        lblRegister.ForeColor = Color.FromArgb(31, 31, 40)
        lblRegister.BackColor = Color.White
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PbRegister.MouseLeave
        PbRegister.Image = My.Resources._300PxBox
        lblRegister.ForeColor = Color.White
        lblRegister.BackColor = Color.Transparent
    End Sub

    Private Sub lblLogin_MouseEnter(sender As Object, e As EventArgs) Handles lblLogin.MouseEnter
        PbLogin.Image = My.Resources._300PxBoxWhite
        lblLogin.ForeColor = Color.FromArgb(31, 31, 40)
        lblLogin.BackColor = Color.White
    End Sub

    Private Sub lblLogin_MouseLeave(sender As Object, e As EventArgs) Handles lblLogin.MouseLeave
        PbLogin.Image = My.Resources._300PxBox
        lblLogin.ForeColor = Color.White
        lblLogin.BackColor = Color.Transparent

    End Sub

    Private Sub lblRegister_MouseEnter(sender As Object, e As EventArgs) Handles lblRegister.MouseEnter
        PbRegister.Image = My.Resources._300PxBoxWhite
        lblRegister.ForeColor = Color.FromArgb(31, 31, 40)
        lblRegister.BackColor = Color.White
    End Sub

    Private Sub lblRegister_MouseLeave(sender As Object, e As EventArgs) Handles lblRegister.MouseLeave
        PbRegister.Image = My.Resources._300PxBox
        lblRegister.ForeColor = Color.White
        lblRegister.BackColor = Color.Transparent
    End Sub

    ' This opens the help form
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Me.Hide()
        Help.Show()
    End Sub
End Class