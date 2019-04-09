Public Class Form1
    ' This is a timer that will allow to increase the invisible progress bar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(1)

        ' This if statement opens the login form when the progress bar completes
        If ProgressBar.Value = 100 Then
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' This code makes the progress bar invisible
        ProgressBar.Visible = False
    End Sub
End Class
