Public Class Alert
    Public Sub showAlert()
        Me.Visible = True
        Me.CloseTimer.Start()
    End Sub

    Private Sub CloseTimer_Tick(sender As Object, e As EventArgs) Handles CloseTimer.Tick
        Me.Hide()
        Me.CloseTimer.Stop()
    End Sub
End Class
