Imports System.ComponentModel
Public Class ShellOperation

    Private __process As Process
    Private __process_info As ProcessStartInfo

    Private __inputStream As IO.StreamWriter
    Private __outputStream As IO.StreamReader

    Private __exe_location As String = "cmd.exe"
    Private __argument As String = ""

    Private __inited = False

    Private Sub updateStartInfo()
        Me.__process.StartInfo = Me.__process_info
    End Sub


    Sub New(exe_location)
        Me.__exe_location = exe_location
        Me.__inited = True
        Me.__process = New Process
        Me.__process_info = New ProcessStartInfo(Me.__exe_location)

        Me.__process_info.UseShellExecute = False
        Me.__process_info.RedirectStandardOutput = True
        Me.__process_info.RedirectStandardInput = True
        Me.__process_info.CreateNoWindow = True

        Me.updateStartInfo()
    End Sub

    Public Sub run()

        Me.__process.Start()
        Me.__inputStream = Me.__process.StandardInput
        Me.__running = True

    End Sub

    Public Sub input(content, Optional newLine = True)

        If newLine Then
            Me.__inputStream.WriteLine(content)
        Else
            Me.__inputStream.Write(content)
        End If

    End Sub

    Public Sub killProcess()
        Me.__process.Kill()
    End Sub


    Public Function getOutput()

        Me.__process.WaitForExit()

        Dim myStreamReader As IO.StreamReader = Me.__process.StandardOutput
        Dim myStr As String = myStreamReader.ReadToEnd

        Return myStr

    End Function

    Private argument As String
    Public Property NewProperty() As String
        Get
            Return argument
        End Get
        Set(ByVal value As String)
            argument = value
        End Set
    End Property

    Private __running As Boolean
    Public Property isRunning() As Boolean
        Get
            Return __running
        End Get
        Set(ByVal value As Boolean)
            __running = value
        End Set
    End Property

End Class
