Imports System.Threading.Thread
Public Class Form1

    Dim allBlocks(64) As Block

    Dim blocksCoor(8, 8) As Block

    Function generateCommandInput()

        Dim returnStr = ""

        For y = 0 To 7
            For x = 0 To 7
                If Not x = 7 Then
                    returnStr += CStr(blocksCoor(x, y).colorID)
                    returnStr += " "
                Else
                    returnStr += CStr(blocksCoor(x, y).colorID)
                End If
            Next
            returnStr += vbCrLf
        Next

        Return returnStr

    End Function

    Private Sub Load_Timer(sender As Object, e As EventArgs) Handles LoadTimer.Tick

        LoadTimer.Stop()

        allBlocks = {Block1, Block2, Block3, Block4, Block5, Block6, Block7, Block8, Block9, Block10, Block11, Block12, Block13, Block14, Block15, Block16, Block17, Block18, Block19, Block20, Block21, Block22, Block23, Block24, Block25, Block26, Block27, Block28, Block29, Block30, Block31, Block32, Block33, Block34, Block35, Block36, Block37, Block38, Block39, Block40, Block41, Block42, Block43, Block44, Block45, Block46, Block47, Block48, Block49, Block50, Block51, Block52, Block53, Block54, Block55, Block56, Block57, Block58, Block59, Block60, Block61, Block62, Block63, Block64}

        For Each block As Block In allBlocks
            blocksCoor(block.xIndex, block.yIndex) = block
        Next

    End Sub

    Dim isRunning = False
    Dim runningThread As Threading.Thread

    Private Sub btnCalc_Click(sender As Object, e As EventArgs)

        If Not isRunning Then

            runningThread = New Threading.Thread(AddressOf Calculate)

            ' Calc GIF
            imgCalc.Show()
            lblCalc.Show()

            ' Abort Button
            btnAbort.Show()

            runningThread.Start()

            ' Timer Initialize
            Label4.Text = "00"
            totalTime = 0
            isRunning = True
            CalcTimer.Start()

        Else

            Alert1.showAlert()

        End If

    End Sub
    Private Sub Calculate()

        Dim p As New ShellOperation("EastFlowAlgo.exe")

        p.run()
        p.input(generateCommandInput())
        Dim result As String = p.getOutput()
        RichTextBox2.Text = result
        'MessageBox.Show(result)

        Try
            Dim x = 0, y = 0
            Dim resultCoor(8, 8) As Integer

            For Each line In result.Split(vbNewLine)
                If line.Length > 2 Then
                    Dim data = line.Split(" ")
                    For x = 0 To 7
                        resultCoor(x, y) = data(x)
                    Next
                    y += 1
                End If

            Next

            For y = 0 To 7
                For x = 0 To 7
                    If blocksCoor(x, y).colorID = resultCoor(x, y) Then
                        resultCoor(x, y) = -1
                    End If
                Next
            Next

            For y = 0 To 7
                For x = 0 To 7
                    If resultCoor(x, y) >= 0 Then
                        blocksCoor(x, y).colorID = resultCoor(x, y)
                        blocksCoor(x, y).isCastle = False
                    End If
                Next
            Next
        Catch ex As Exception

        End Try

        ' GIF
        imgCalc.Hide()
        lblCalc.Hide()

        ' Timer
        CalcTimer.Stop()

        ' Abort Button
        btnAbort.Hide()

        isRunning = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        For Each block As Block In allBlocks
            block.resetColor()
        Next

        ' Timer Initialize
        Label4.Text = "00"
        totalTime = 0

    End Sub

    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        RichTextBox2.Text = generateCommandInput()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        If RichTextBox1.TextLength = 128 Or RichTextBox1.TextLength = 127 Then
            loadFromText(sender, e)
        End If
    End Sub

    Private Sub loadFromText(sender As Object, e As EventArgs) Handles btnLoad.Click
        For Each block As Block In allBlocks
            block.resetColor()
        Next
        Try
            Dim x = 0, y = 0

            For Each line In RichTextBox1.Lines
                If line.Length > 2 Then
                    Dim data = line.Split(" ")
                    For x = 0 To 7
                        blocksCoor(x, y).colorID = data(x)
                        If blocksCoor(x, y).colorID > 0 Then
                            blocksCoor(x, y).isCastle = True
                        End If
                    Next
                    y += 1
                End If

            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CheckForIllegalCrossThreadCalls = False

        For Each ctrl As Control In btnAbort.Controls
            AddHandler ctrl.MouseClick, AddressOf btnAbort_Click
        Next

        For Each ctrl As Control In btnCalc.Controls
            AddHandler ctrl.MouseDown, AddressOf btnCalc_Click
        Next
        AddHandler btnCalc.MouseDown, AddressOf btnCalc_Click

        For Each ctrl As Control In btnClear.Controls
            AddHandler ctrl.MouseClick, AddressOf btnClear_Click
        Next

        For Each ctrl As Control In btnGen.Controls
            AddHandler ctrl.MouseClick, AddressOf btnGen_Click
        Next

        For Each ctrl As Control In btnLoad.Controls
            AddHandler ctrl.MouseClick, AddressOf loadFromText
        Next

        For Each ctrl As Control In btnClose.Controls
            AddHandler ctrl.MouseClick, AddressOf btnClose_Click
        Next
        AddHandler btnClose.MouseClick, AddressOf btnClose_Click

    End Sub

    Dim totalTime = 0
    Dim min = 0, sec = 0, sep = 0

    Private Sub ThreadUpdateTimer_Tick(sender As Object, e As EventArgs) Handles ThreadUpdateTimer.Tick

        Try

            If runningThread.IsAlive Then

                isRunning = True

                ' Calc GIF
                imgCalc.Show()
                lblCalc.Show()

                ' Abort Button
                btnAbort.Show()

            Else

                isRunning = False

                ' Calc GIF
                imgCalc.Hide()
                lblCalc.Hide()

                ' Abort Button
                btnAbort.Hide()

            End If

        Catch ex As Exception

            isRunning = False

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)

        Try
            runningThread.Abort()
        Catch ex As Exception
        End Try

        Me.Dispose()

    End Sub

    Private Sub btnAbort_Click(sender As Object, e As EventArgs) Handles btnAbort.Click

        runningThread.Abort()

        ' GIF
        imgCalc.Hide()
        lblCalc.Hide()

        ' Timer
        CalcTimer.Stop()

        ' Abort Button
        btnAbort.Hide()

        ' Timer Initialize
        Label4.Text = "00"
        totalTime = 0

        isRunning = False

    End Sub

    Private Sub CalcTimer_Tick(sender As Object, e As EventArgs) Handles CalcTimer.Tick
        totalTime += 60
        sec = CInt(totalTime / 1000)
        If sec < 10 Then
            sec = "0" + Str(sec)
        End If

        Label4.Text = CStr(sec).Replace(" ", "")
    End Sub
End Class
