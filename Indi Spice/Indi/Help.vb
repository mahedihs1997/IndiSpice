Public Class Help

    'Starts the timer to show the timee
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        'Hides the tabs
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.SizeMode = TabSizeMode.Fixed


    End Sub

    'Puts the time and date into the labels 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm")
        lblDate.Text = DateTime.Now.ToString("dd/MM/yy")
    End Sub

    'Shows login form 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub

    'This buttons code allows to change the tabs 
    Private Sub lblHTSI_Click(sender As Object, e As EventArgs) Handles lblHTSI.Click
        TabControl1.SelectedTab = HTSI
    End Sub

    Private Sub lblHTR_Click(sender As Object, e As EventArgs) Handles lblHTR.Click
        TabControl1.SelectedTab = HTR
    End Sub

    Private Sub lblHTA_Click(sender As Object, e As EventArgs) Handles lblHTA.Click
        TabControl1.SelectedTab = HTD
    End Sub

    Private Sub lblHTADI_Click(sender As Object, e As EventArgs) Handles lblHTADI.Click
        TabControl1.SelectedTab = HTDAI
    End Sub

    Private Sub lblHTCA_Click(sender As Object, e As EventArgs) Handles lblHTCA.Click
        TabControl1.SelectedTab = HTCA
    End Sub

    Private Sub lblHTP_Click(sender As Object, e As EventArgs) Handles lblHTP.Click
        TabControl1.SelectedTab = HTP
    End Sub

    Private Sub lblPT_Click(sender As Object, e As EventArgs) Handles lblPT.Click
        TabControl1.SelectedTab = PR
    End Sub

    Private Sub lblPDNW_Click(sender As Object, e As EventArgs) Handles lblPDNW.Click
        TabControl1.SelectedTab = PDNW
    End Sub

    Private Sub lblHCIGFH_Click(sender As Object, e As EventArgs) Handles lblHCIGFH.Click
        TabControl1.SelectedTab = HCIGFH
    End Sub

    Private Sub lblPDNS_Click(sender As Object, e As EventArgs) Handles lblPDNS.Click
        TabControl1.SelectedTab = PDNS
    End Sub
End Class