Public Class FlatButton

    Private __xIndex As Integer = 0
    Private __yIndex As Integer = 0

    Private __defaultBackgroundColor = Color.WhiteSmoke

    Private __blockColor As Color = __defaultBackgroundColor
    Private __dimRatio As Double = 0.2 ' Dimming ratio of the background color
    Private __dimDuration As Integer = 300 ' Animation duration

    Private __dimFrameDuration As Integer = 16 ' Unit -> Milisecond

    Private __dimMaxFrame = 19 ' The last frame
    Private __dimFrame = 0 ' Now frame

    Private colorChangeTimer As Timer
    Private colorChangeDirection As Boolean = True ' True as positive direction, and False as negative

    Private colorList() As Color = {Color.FromArgb(255, 255, 177, 153), Color.FromArgb(255, 132, 220, 185),
       Color.FromArgb(255, 143, 211, 244), Color.FromArgb(255, 251, 237, 150)} ' RGBY
    Private colorIndex = -1
    Private colorIndex_Max = 3

    Private __text = ""
    Private __font As New Font("Microsoft Yahei UI", 2.8)


    Sub handleMouseRightClick(sender As Object, e As EventArgs)

        Me.colorIndex = -1
        Me.BackColor = Me.__defaultBackgroundColor
        Me.blockColor = Me.__defaultBackgroundColor

        renderColor()

    End Sub

    Sub handleMouseLeftClick(sender As Object, e As EventArgs)

        If Me.colorIndex = Me.colorIndex_Max Then
            Me.colorIndex = 0
        ElseIf Me.colorIndex < Me.colorIndex_Max Then
            Me.colorIndex += 1
        End If

        Me.BackColor = colorList(Me.colorIndex)
        Me.blockColor = Me.BackColor

        renderColor()

    End Sub

    Private Sub Block_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.colorChangeDirection = True
        Me.colorChangeTimer.Start()
    End Sub

    Private Sub Block_MouseUnHover(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.colorChangeDirection = False
        Me.colorChangeTimer.Start()
    End Sub

    Private Sub lblCoor_MouseMove(sender As Object, e As MouseEventArgs) Handles lblCoor.MouseMove
        Me.colorChangeDirection = True
        Me.colorChangeTimer.Start()
    End Sub

    Private Sub lblCoor_MouseUnHover(sender As Object, e As EventArgs) Handles lblCoor.MouseLeave
        Me.colorChangeDirection = False
        Me.colorChangeTimer.Start()
    End Sub

    Public Property backgroundColorDimmingRatio As Double
        Get
            Return Me.__dimRatio
        End Get
        Set(ByVal value As Double)
            Me.__dimRatio = value
        End Set
    End Property

    Public Property backgroundColorDimmingDuration As Integer ' Unit -> Milisecond
        Get
            Return Me.__dimDuration
        End Get
        Set(ByVal value As Integer)
            Me.__dimDuration = value
            Me.__dimMaxFrame = CInt(value / Me.__dimFrameDuration)
        End Set
    End Property

    Public Property blockColor As Color
        Get
            Return Me.__blockColor
        End Get
        Set(ByVal value As Color)
            Me.__blockColor = value
            renderColor()
        End Set
    End Property

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.colorChangeTimer = New Timer
        Me.colorChangeTimer.Interval = 16 ' 16ms delay to render per frame of animation
        Me.colorChangeTimer.Enabled = False
        AddHandler Me.colorChangeTimer.Tick, AddressOf onColorChangeTimerTick
    End Sub

    Sub renderColor()

        Dim sourceColor = Me.blockColor
        Dim r = sourceColor.R, g = sourceColor.G, b = sourceColor.B

        Dim nowFrame = Me.__dimFrame, maxFrame = Me.__dimMaxFrame
        Dim nowRatio = nowFrame / maxFrame * Me.__dimRatio

        'Debug.WriteLine(nowFrame)

        r = r * (1 - nowRatio)
        g = g * (1 - nowRatio)
        b = b * (1 - nowRatio)

        'Debug.WriteLine(CStr(r) + "," + CStr(g) + "," + CStr(b))

        Me.BackColor = Color.FromArgb(255, r, g, b)

    End Sub

    Private Sub onColorChangeTimerTick()

        If (Me.colorChangeDirection = True And Me.__dimFrame = Me.__dimMaxFrame) Or (Me.colorChangeDirection = False And Me.__dimFrame = 0) Then
            Me.colorChangeTimer.Stop()
        Else

            renderColor()

            If Me.colorChangeDirection = True Then
                Me.__dimFrame += 1
            End If

            If Me.colorChangeDirection = False Then
                Me.__dimFrame -= 1
            End If

        End If

        Application.DoEvents()

    End Sub

    Public Property LblText As String
        Get
            Return Me.__text
        End Get
        Set(ByVal value As String)
            Me.__text = value
            Me.lblCoor.Text = value
        End Set
    End Property

    Public Overrides Property Font As Font
        Get
            Return Me.__font
        End Get
        Set(ByVal value As Font)
            Me.__font = value
            Me.lblCoor.Font = value
        End Set
    End Property

End Class
