Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim p As New ShellOperation("test.exe")

        p.run()
        p.input("1 2")
        p.getOutput()

    End Sub
End Class
